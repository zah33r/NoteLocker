using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteLocker
{
    [Serializable]
    public class DocumentTab
    {
        public string title = string.Empty;
        public Google.Apis.Drive.v2.Data.File currentJobFile = null;
        public string content = null;
        public string textContent = string.Empty;
        public System.Drawing.Color textColor = System.Drawing.Color.Black;
        public System.Drawing.Color backgroundColor = System.Drawing.Color.White;
        public System.Drawing.Font font = null;
        public float ZoomFactor = 1;
        public bool wordWrap = false;
    }
}
