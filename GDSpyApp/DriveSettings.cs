using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteLocker
{
    public class DriveSettings
    {
        public static string autoSaveLocation = string.Empty;
        public static int autoSaveInterval = 1;
        public static bool isLocalSaveOn = false;
        public static bool isRemoteSaveOn = true;
        public static int signInTimeOut = 30;
        public static string clientId = string.Empty;//"1049910356726-5083kl6di5alm0go24fno0gbga3c24ld.apps.googleusercontent.com";
        public static string clientSecret = string.Empty;//"7L6fxwixBD6aRyaYgzuvcJ2u";
    }
}
