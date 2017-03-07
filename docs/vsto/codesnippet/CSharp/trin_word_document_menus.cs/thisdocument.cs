using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Word;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace CS
{
    public partial class ThisDocument
    {
        //<Snippet2>
        public Microsoft.Office.Tools.Word.Bookmark selectedBookmark;
        public bool showBoldButton = false;
        public bool showItalicButton = false;
        public int WordTrue = -1;
        public int WordFalse = 0;

        //</Snippet2>

        //<Snippet4>
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            this.bookmark1.BeforeRightClick += new ClickEventHandler(bookmark_BeforeRightClick);
            this.bookmark2.BeforeRightClick += new ClickEventHandler(bookmark_BeforeRightClick);
        }
        //</Snippet4>

        //<Snippet3>

        void bookmark_BeforeRightClick(object sender, ClickEventArgs e)
        {
            int startPosition = 0;

            // If bookmarks overlap, get bookmark closest to cursor.
            for (int i = 1; i <= e.Selection.Bookmarks.Count; i++)
            {
                if (e.Selection.Bookmarks[i].Start > startPosition)
                {
                    startPosition = e.Selection.Bookmarks[i].Start;
                }
            }

            // If closest bookmark is the sender, show shortcut menu options.
            if (((Microsoft.Office.Tools.Word.Bookmark)sender).Start == startPosition)
            {
                selectedBookmark = (Microsoft.Office.Tools.Word.Bookmark)sender;
                
                showBoldButton = true;
                showItalicButton = true;

            }

        }

        //</Snippet3>
        //<Snippet1>
        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new Ribbon1();
        }
        //</Snippet1>
        


        private void ThisDocument_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisDocument_Startup);
            this.Shutdown += new System.EventHandler(ThisDocument_Shutdown);
        }

        #endregion
    }
}
