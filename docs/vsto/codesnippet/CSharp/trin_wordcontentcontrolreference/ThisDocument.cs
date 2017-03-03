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

namespace Trin_ContentControlReference
{
    public partial class ThisDocument
    {
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            //AddBuildingBlockControlAtSelection();
            //AddBuildingBlockControlAtRange();
            //CreateBuildingBlockControlsFromNativeControls();

            //AddComboBoxControlAtSelection();
            //AddComboBoxControlAtRange();
            //CreateComboBoxControlsFromNativeControls();

            //AddDatePickerControlAtSelection();
            //AddDatePickerControlAtRange();
            //CreateDatePickerControlsFromNativeControls();

            //AddDropDownListControlAtSelection();
            //AddDropDownListControlAtRange();
            //CreateDropDownListControlsFromNativeControls();

            //AddGroupControlAtSelection();
            //AddGroupControlAtRange();
            //CreateGroupControlsFromNativeControls();

            //AddPictureControlAtSelection();
            //AddPictureControlAtRange();
            //CreatePictureControlFromNativeControl();

            //AddTextControlAtSelection();
            //AddTextControlAtRange();
            //CreateTextControlsFromNativeControls();

            //AddRichTextControlAtSelection();
            //AddRichTextControlAtRange();
            //CreateRichTextControlsFromNativeControls();

            //AddCheckBoxControlAtSelection();

            //this.ContentControlAfterAdd +=
            //    new Word.DocumentEvents2_ContentControlAfterAddEventHandler(
            //    ThisDocument_BuildingBlockContentControlAfterAdd);

            //this.ContentControlAfterAdd +=
            //    new Word.DocumentEvents2_ContentControlAfterAddEventHandler(
            //    ThisDocument_ComboBoxContentControlAfterAdd);

            //this.ContentControlAfterAdd +=
            //    new Word.DocumentEvents2_ContentControlAfterAddEventHandler(
            //    ThisDocument_DatePickerContentControlAfterAdd);

            //this.ContentControlAfterAdd +=
            //    new Word.DocumentEvents2_ContentControlAfterAddEventHandler(
            //    ThisDocument_DropDownListContentControlAfterAdd);

            //this.ContentControlAfterAdd +=
            //    new Word.DocumentEvents2_ContentControlAfterAddEventHandler(
            //    ThisDocument_GroupContentControlAfterAdd);

            //this.ContentControlAfterAdd +=
            //    new Word.DocumentEvents2_ContentControlAfterAddEventHandler(
            //    ThisDocument_PictureContentControlAfterAdd);

            //this.ContentControlAfterAdd +=
            //    new Word.DocumentEvents2_ContentControlAfterAddEventHandler(
            //    ThisDocument_PlainTextContentControlAfterAdd);

            //this.ContentControlAfterAdd += 
            //    new Word.DocumentEvents2_ContentControlAfterAddEventHandler(
            //    ThisDocument_RichTextContentControlAfterAdd);
        }

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
