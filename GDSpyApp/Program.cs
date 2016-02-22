using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NoteLocker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTextPad());
        }
    }
}


//using System;
//using System.Threading;
//using System.Threading.Tasks;

//using Google;
//using Google.Apis.Auth.OAuth2;
//using Google.Apis.Drive.v2;
//using Google.Apis.Drive.v2.Data;
//using Google.Apis.Services;
//using System.Collections.Generic;

//using System.Linq;

//namespace GoogleDriveSamples
//{
//    class DriveCommandLineSample
//    {
//        static void Main(string[] args)
//        {            
//            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
//                new ClientSecrets
//                {
//                    ClientId = "1049910356726-5083kl6di5alm0go24fno0gbga3c24ld.apps.googleusercontent.com",
//                    ClientSecret = "7L6fxwixBD6aRyaYgzuvcJ2u",
//                },
//                new[] { DriveService.Scope.Drive },
//                "user",
//                CancellationToken.None).Result;
            
//            // Create the service.
//            var service = new DriveService(new BaseClientService.Initializer()
//            {
//                HttpClientInitializer = credential,
//                ApplicationName = "Drive API Sample",
//            });

//            List<File> listOfFiles = retrieveAllFiles(service);

//            string FileId = string.Empty;
//            File resultFile = retrieveFileById(FileId, service);
//            //File body = new File();
//            //body.Title = "My document";
//            //body.Description = "A test document";
//            //body.MimeType = "text/plain";

//            //byte[] byteArray = System.IO.File.ReadAllBytes("document.txt");
//            //System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);

//            //FilesResource.InsertMediaUpload request = service.Files.Insert(body, stream, "text/plain");
//            //FilesResource filesResource = service.Files;
//            //FilesResource.ListRequest listRequest = filesResource.List();
//            //request.Upload();

//            //File file = request.ResponseBody;
//            //Console.WriteLine("File id: " + file.Id);
//            //Console.WriteLine("Press Enter to end this process.");
//            Console.ReadLine();
//        }

//        /// <summary>
//        /// Retrieve a list of File resources.
//        /// </summary>
//        /// <param name="service">Drive API service instance.</param>
//        /// <returns>List of File resources.</returns>
//        public static List<File> retrieveAllFiles(DriveService service)
//        {
//            List<File> result = new List<File>();
//            FilesResource.ListRequest request = service.Files.List();

//            do
//            {
//                try
//                {
//                    FileList files = request.Execute();

//                    result.AddRange(files.Items);
//                    request.PageToken = files.NextPageToken;
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine("An error occurred: " + e.Message);
//                    request.PageToken = null;
//                }
//            } while (!String.IsNullOrEmpty(request.PageToken));
//            return result;
//        }

//        public static File retrieveFileById(string fileId, DriveService service)
//        {
//            try
//            {
//                List<File> listOfFiles = retrieveAllFiles(service);

//                IEnumerable<File> fileQuery = from resultFile in listOfFiles where resultFile.Id == fileId select resultFile;
//                return (File)fileQuery.FirstOrDefault();
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("An error occurred: " + e.Message);
//                return null;
//            }
//        }


//        /// <summary>
//        /// Update an existing file's metadata and content.
//        /// </summary>
//        /// <param name="service">Drive API service instance.</param>
//        /// <param name="fileId">ID of the file to update.</param>
//        /// <param name="newTitle">New title for the file.</param>
//        /// <param name="newDescription">New description for the file.</param>
//        /// <param name="newMimeType">New MIME type for the file.</param>
//        /// <param name="newFilename">Filename of the new content to upload.</param>
//        /// <param name="newRevision">Whether or not to create a new revision for this file.</param>
//        /// <returns>Updated file metadata, null is returned if an API error occurred.</returns>
//        private static File updateFile(DriveService service, String fileId, String newTitle,
//            String newDescription, String newMimeType, String newFilename, bool newRevision)
//        {
//            try
//            {
//                // First retrieve the file from the API.
//                File file = service.Files.Get(fileId).Execute();

//                // File's new metadata.
//                file.Title = newTitle;
//                file.Description = newDescription;
//                file.MimeType = newMimeType;

//                // File's new content.
//                byte[] byteArray = System.IO.File.ReadAllBytes(newFilename);
//                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);

//                // Send the request to the API.
//                FilesResource.UpdateMediaUpload request = service.Files.Update(file, fileId, stream, newMimeType);
//                request.NewRevision = newRevision;
//                request.Upload();

//                File updatedFile = request.ResponseBody;
//                return updatedFile;
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("An error occurred: " + e.Message);
//                return null;
//            }
//        }
//    }
//}
