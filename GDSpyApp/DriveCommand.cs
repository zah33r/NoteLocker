using System;
using System.Threading;
using System.Threading.Tasks;

using Google;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Services;
using System.Collections.Generic;

using System.Linq;
using System.IO;

namespace NoteLocker
{
    class DriveCommand
    {
        #region Variables

        public static Google.Apis.Drive.v2.DriveService service = null;
        public static UserCredential credential = null;
        public static Google.Apis.Drive.v2.Data.File currentJobFile = null;
        public static bool IsLoginFailed = false;
        private static string credentialDataStore = string.Empty;
        private static Google.Apis.Http.HandleUnsuccessfulResponseArgs hUFRArgs = null;

        #endregion Variables

        #region Methods

        /// <summary>
        /// The entry point of Google Drive Service
        /// </summary>
        public static void initGoogleService()
        {

            DriveCommand.credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
               new ClientSecrets
               {
                   ClientId = DriveSettings.clientId,
                   ClientSecret = DriveSettings.clientSecret,
               },
               new[] { DriveService.Scope.Drive },
               "user",
               CancellationToken.None).Result;

            // Create the service.
            DriveCommand.service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Google Drive Text Pad.",
            });
        }        

        /// <summary>
        /// Retrieve a list of File resources.
        /// </summary>
        /// <param name="service">Drive API service instance.</param>
        /// <returns>List of File resources.</returns>
        public static List<Google.Apis.Drive.v2.Data.File> retrieveAllFiles(DriveService service)
        {
            List<Google.Apis.Drive.v2.Data.File> result = new List<Google.Apis.Drive.v2.Data.File>();
            FilesResource.ListRequest request = service.Files.List();

            do
            {
                try
                {
                    FileList files = request.Execute();

                    result.AddRange(files.Items);
                    request.PageToken = files.NextPageToken;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                    request.PageToken = null;
                }
            } while (!String.IsNullOrEmpty(request.PageToken));
            return result;
        }

        /// <summary>
        /// Retrieve a File resource.
        /// </summary>
        /// <param name="service">Drive API service instance.</param>
        /// <returns>File resource.</returns>
        public static Google.Apis.Drive.v2.Data.File retrieveFileById(string fileId, DriveService service)
        {
            try
            {
                List<Google.Apis.Drive.v2.Data.File> listOfFiles = retrieveAllFiles(service);

                IEnumerable<Google.Apis.Drive.v2.Data.File> fileQuery = from resultFile in listOfFiles where resultFile.Id == fileId select resultFile;
                return (Google.Apis.Drive.v2.Data.File)fileQuery.FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                return null;
            }
        }

        /// <summary>
        /// Update an existing file's metadata and content.
        /// </summary>
        /// <param name="service">Drive API service instance.</param>
        /// <param name="fileId">ID of the file to update.</param>
        /// <param name="newTitle">New title for the file.</param>
        /// <param name="newDescription">New description for the file.</param>
        /// <param name="newMimeType">New MIME type for the file.</param>
        /// <param name="newFilename">Filename of the new content to upload.</param>
        /// <param name="newRevision">Whether or not to create a new revision for this file.</param>
        /// <returns>Updated file metadata, null is returned if an API error occurred.</returns>
        public static Google.Apis.Drive.v2.Data.File updateFile(String fileId, String newTitle, String newContent, String newFilename, bool newRevision)
        {
            try
            {
                // First retrieve the file from the API.
                Google.Apis.Drive.v2.Data.File file = service.Files.Get(fileId).Execute();

                // File's new metadata.
                file.Title = newTitle;                

                // File's new content.
                //byte[] byteArray = System.IO.File.ReadAllBytes(newFilename);
                byte[] byteArray = System.Text.Encoding.Unicode.GetBytes(newContent);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);

                // Send the request to the API.
                FilesResource.UpdateMediaUpload request = service.Files.Update(file, fileId, stream, file.MimeType);
                request.NewRevision = newRevision;
                request.Upload();

                currentJobFile = request.ResponseBody;
                return currentJobFile;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                return null;
            }
        }

        /// <summary>
        /// Update an existing file's metadata and content.
        /// </summary>
        /// <param name="service">Drive API service instance.</param>
        /// <param name="fileId">ID of the file to update.</param>
        /// <param name="newTitle">New title for the file.</param>
        /// <param name="newDescription">New description for the file.</param>
        /// <param name="newMimeType">New MIME type for the file.</param>
        /// <param name="newFilename">Filename of the new content to upload.</param>
        /// <param name="newRevision">Whether or not to create a new revision for this file.</param>
        /// <returns>Updated file metadata, null is returned if an API error occurred.</returns>
        public static Google.Apis.Drive.v2.Data.File updateFile(String fileId, String newTitle, Stream stream, String newFilename, bool newRevision)
        {
            try
            {
                // First retrieve the file from the API.
                Google.Apis.Drive.v2.Data.File file = service.Files.Get(fileId).Execute();

                // File's new metadata.
                file.Title = newTitle;                

                // Send the request to the API.
                FilesResource.UpdateMediaUpload request = service.Files.Update(file, fileId, stream, file.MimeType);
                request.NewRevision = newRevision;
                request.Upload();

                currentJobFile = request.ResponseBody;
                return currentJobFile;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                return null;
            }
        }

        /// <summary>
        /// Creates the files for the very first time on Google Drive
        /// </summary>
        /// <param name="title">Title of the Document.</param>
        /// <param name="contents">Document's body.</param>
        /// <returns></returns>
        public static bool createFile(string title, string contents)
        {            
            try
            {
                Google.Apis.Drive.v2.Data.File body = new Google.Apis.Drive.v2.Data.File();
                body.Title = title;
                body.Description = "Uploaded from Google Docs Desktop Utility.";
                body.MimeType = "text/plain";

                //byte[] byteArray = System.IO.File.ReadAllBytes("document.txt");
                byte[] byteArray = System.Text.Encoding.Unicode.GetBytes(contents);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);

                FilesResource.InsertMediaUpload request = service.Files.Insert(body, stream, "text/plain");
                FilesResource filesResource = service.Files;
                FilesResource.ListRequest listRequest = filesResource.List();
                request.Upload();

                currentJobFile = request.ResponseBody;

                return true;
            }
            catch (Exception)
            {                
                return false;
            }
        }

        /// <summary>
        /// Creates the files for the very first time on Google Drive
        /// </summary>
        /// <param name="title">Title of the Document.</param>
        /// <param name="contents">Document's body.</param>
        /// <returns></returns>
        public static bool createFile(string title, Stream stream)
        {
            try
            {
                Google.Apis.Drive.v2.Data.File body = new Google.Apis.Drive.v2.Data.File();
                body.Title = title;
                body.Description = "Uploaded from Google Docs Desktop Utility.";
                body.MimeType = "text/rtf";//"text/plain";                

                FilesResource.InsertMediaUpload request = service.Files.Insert(body, stream, "text/rtf");
                FilesResource filesResource = service.Files;
                FilesResource.ListRequest listRequest = filesResource.List();
                request.Upload();

                currentJobFile = request.ResponseBody;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool createFile(string title, Stream stream, out Google.Apis.Drive.v2.Data.File _currentJobFile)
        {
            try
            {
                Google.Apis.Drive.v2.Data.File body = new Google.Apis.Drive.v2.Data.File();
                body.Title = title;
                body.Description = "Uploaded from Google Docs Desktop Utility.";
                body.MimeType = "text/rtf";//"text/plain";                

                FilesResource.InsertMediaUpload request = service.Files.Insert(body, stream, "text/rtf");
                FilesResource filesResource = service.Files;
                FilesResource.ListRequest listRequest = filesResource.List();
                request.Upload();

                _currentJobFile = currentJobFile = request.ResponseBody;

                return true;
            }
            catch (Exception)
            {
                _currentJobFile = null;
                return false;
            }
        }

        /// <summary>
        /// Removes the currenlty associated User Account
        /// </summary>
        /// <returns></returns>
        public static bool removeUserCredentials()
        {
            try
            {
                string[] credFiles = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Google.Apis.Auth.OAuth2.Responses.TokenResponse-user", SearchOption.AllDirectories);

                foreach (string path in credFiles)
                {
                    if (System.IO.File.Exists(path))
                        System.IO.File.Delete(path);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }        

        #endregion Methods
    }
}