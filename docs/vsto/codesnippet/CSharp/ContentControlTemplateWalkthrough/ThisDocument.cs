using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;

namespace ContentControlTemplateWalkthrough
{
    public partial class ThisDocument
    {
        //<Snippet1>
        private Microsoft.Office.Tools.Word.GroupContentControl groupControl1;
        private Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl buildingBlockControl1;
        private Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl buildingBlockControl2;
        //</Snippet1>

        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            try
            {
                //<Snippet2>
                comboBoxContentControl1.PlaceholderText = "Choose a title, or enter your own";
                comboBoxContentControl1.DropDownListEntries.Add("Engineer", "Engineer", 0);
                comboBoxContentControl1.DropDownListEntries.Add("Designer", "Designer", 1);
                comboBoxContentControl1.DropDownListEntries.Add("Manager", "Manager", 2);

                dropDownListContentControl1.PlaceholderText =
                    "Choose a rating (1 lowest, 3 highest)";
                dropDownListContentControl1.DropDownListEntries.Add("1", "1", 0);
                dropDownListContentControl1.DropDownListEntries.Add("2", "2", 1);
                dropDownListContentControl1.DropDownListEntries.Add("3", "3", 2);
                //</Snippet2>

                //<Snippet3>
                this.Tables[1].Range.Select();
                groupControl1 = this.Controls.AddGroupContentControl("groupControl1");
                //</Snippet3>

                //<Snippet4>
                Word.Template template1 = this.AttachedTemplate as Word.Template;

                if (template1 != null)
                {
                    object description = null;
                    template1.BuildingBlockEntries.Add("Employee Table",
                        Word.WdBuildingBlockTypes.wdTypeCustom1, "Employee and Customer Information",
                        this.Tables[1].Range, ref description, Word.WdDocPartInsertOptions.wdInsertContent);
                    template1.BuildingBlockEntries.Add("Customer Table",
                        Word.WdBuildingBlockTypes.wdTypeCustom1, "Employee and Customer Information",
                        this.Tables[2].Range, ref description, Word.WdDocPartInsertOptions.wdInsertContent);
                }
                //</Snippet4>

                //<Snippet5>
                if (!this.FormsDesign)
                {
                    this.ToggleFormsDesign();
                }
                this.Tables[2].Delete();
                this.Tables[1].Delete();
                this.ToggleFormsDesign();
                //</Snippet5>

                //<Snippet6>
                buildingBlockControl1 = this.Controls.AddBuildingBlockGalleryContentControl(
                    this.Paragraphs[1].Range, "buildingBlockControl1");
                buildingBlockControl1.BuildingBlockCategory = "Employee and Customer Information";
                buildingBlockControl1.BuildingBlockType = Word.WdBuildingBlockTypes.wdTypeCustom1;
                buildingBlockControl1.PlaceholderText = "Choose your first building block";

                buildingBlockControl2 = this.Controls.AddBuildingBlockGalleryContentControl(
                    this.Paragraphs[2].Range, "buildingBlockControl2");
                buildingBlockControl2.BuildingBlockCategory = "Employee and Customer Information";
                buildingBlockControl2.BuildingBlockType = Word.WdBuildingBlockTypes.wdTypeCustom1;
                buildingBlockControl2.PlaceholderText = "Choose your second building block";
                //</Snippet6>
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
