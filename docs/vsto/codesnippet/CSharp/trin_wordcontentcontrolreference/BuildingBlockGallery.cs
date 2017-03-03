using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;

namespace Trin_ContentControlReference
{
    public partial class ThisDocument
    {
        // BuildingBlockGalleryContentControl constructor #1: create a 
        // BuildingBlockGalleryContentControl at the current selection.
        //<Snippet1>
        private Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl buildingBlockControl1;

        private void AddBuildingBlockControlAtSelection()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            this.Paragraphs[1].Range.Select();

            buildingBlockControl1 = this.Controls.AddBuildingBlockGalleryContentControl(
                "buildingBlockControl1");
            buildingBlockControl1.PlaceholderText = "Choose an equation";
            buildingBlockControl1.BuildingBlockCategory = "Built-In";
            buildingBlockControl1.BuildingBlockType = Word.WdBuildingBlockTypes.wdTypeEquations;
        }
        //</Snippet1>

        // BuildingBlockGalleryContentControl constructor #2: create a 
        // BuildingBlockGalleryContentControl at a specified range.
        //<Snippet2>
        private Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl buildingBlockControl2;

        private void AddBuildingBlockControlAtRange()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();

            buildingBlockControl2 = this.Controls.AddBuildingBlockGalleryContentControl(
               this.Paragraphs[1].Range, "buildingBlockControl2");
            buildingBlockControl2.PlaceholderText = "Choose an equation";
            buildingBlockControl2.BuildingBlockCategory = "Built-In";
            buildingBlockControl2.BuildingBlockType = Word.WdBuildingBlockTypes.wdTypeEquations;
        }
        //</Snippet2>

        // BuildingBlockGalleryContentControl constructor #3: create a 
        // BuildingBlockGalleryContentControl for every native building block control in the document.
        //<Snippet3>
        private System.Collections.Generic.List
           <Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl> buildingBlockControls;

        private void CreateBuildingBlockControlsFromNativeControls()
        {
            if (this.ContentControls.Count <= 0)
                return;

            buildingBlockControls = new System.Collections.Generic.List
                <Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl>();
            int count = 0;

            foreach (Word.ContentControl nativeControl in this.ContentControls)
            {
                if (nativeControl.Type == Word.WdContentControlType.wdContentControlBuildingBlockGallery)
                {
                    count++;
                    Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl tempControl =
                        this.Controls.AddBuildingBlockGalleryContentControl(nativeControl,
                        "VSTOBuildingBlockContentControl" + count.ToString());
                    buildingBlockControls.Add(tempControl);
                }
            }
        }
        //</Snippet3>


        // BuildingBlockGalleryContentControl constructor #3: create a 
        // BuildingBlockGalleryContentControl for every native building block control added to the document.
        //<Snippet4>
        void ThisDocument_BuildingBlockContentControlAfterAdd(Word.ContentControl NewContentControl, bool InUndoRedo)
        {
            if (NewContentControl.Type == Word.WdContentControlType.wdContentControlBuildingBlockGallery)
            {
                this.Controls.AddBuildingBlockGalleryContentControl(NewContentControl,
                    "BuildingBlockControl" + NewContentControl.ID);
            }
        }
        //</Snippet4>
    }
}
