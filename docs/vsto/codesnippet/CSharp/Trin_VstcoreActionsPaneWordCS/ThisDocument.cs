using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Word=Microsoft.Office.Interop.Word;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreActionsPaneWordCS
{
    public partial class ThisDocument
    {
        //---------------------------------------------------------------------
        //<Snippet10>
        private InsertTextControl insertText = new InsertTextControl();
        //</Snippet10>

        //<Snippet6>
        private ActionsControl actions = new ActionsControl();
        //</Snippet6>

        //<Snippet14>
        private HelloControl hello = new HelloControl();
        //</Snippet14>

        //<Snippet16>
        private AddTextControl addText = new AddTextControl();
        private ShowPropertiesControl showProperties = new ShowPropertiesControl();
        private ShowAllControl showAll = new ShowAllControl();
        //</Snippet16>


        //---------------------------------------------------------------------
        private void StartUp(object sender, System.EventArgs e)
        {
            //<Snippet7>
            this.ActionsPane.Controls.Add(actions);
            //</Snippet7>


            //<Snippet11>
            this.ActionsPane.Controls.Add(insertText);
            //</Snippet11>


            //<Snippet15>
            this.ActionsPane.Controls.Add(hello);
            //</Snippet15>


            //<Snippet17>
            this.ActionsPane.Controls.Add(showAll);
            //</Snippet17>

            //<Snippet34>
            this.Application.TaskPanes[Word.WdTaskPanes.wdTaskPaneDocumentActions].Visible = false;
            //</Snippet34>


            //<Snippet22>
            this.SampleInsertNode.ContextEnter +=new Microsoft.Office.Tools.Word.
                ContextChangeEventHandler(SampleInsertNode_ContextEnter); 
            
            this.SampleInsertNode.ContextLeave += new Microsoft.Office.Tools.Word.
                ContextChangeEventHandler(SampleInsertNode_ContextLeave);

            this.SampleTableNode.ContextEnter += new Microsoft.Office.Tools.Word.
                ContextChangeEventHandler(SampleTableNode_ContextEnter);

            this.SampleTableNode.ContextLeave += new Microsoft.Office.Tools.Word.
                ContextChangeEventHandler(SampleTableNode_ContextLeave);
            //</Snippet22>


            //<Snippet24>
            showAll.showCheck.CheckStateChanged += new EventHandler(showCheck_CheckStateChanged);
            //</Snippet24>
        }



        //---------------------------------------------------------------------
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisDocument_Startup);
            this.Startup += new System.EventHandler(StartUp);
        }


        //---------------------------------------------------------------------
        //<Snippet18>
        private void SampleInsertNode_ContextEnter(object sender,
            Microsoft.Office.Tools.Word.ContextChangeEventArgs e)
        {
            if (showAll.showCheck.Checked == false)
            {
                this.ActionsPane.Controls.Add(addText);
                this.ActionsPane.Controls.Remove(showProperties);
            }
        }
        //</Snippet18>


        //<Snippet19>
        private void SampleInsertNode_ContextLeave(object sender,
            Microsoft.Office.Tools.Word.ContextChangeEventArgs e)
        {
            if (showAll.showCheck.Checked == false)
            {
                this.ActionsPane.Controls.Remove(addText);
            }
        }
        //</Snippet19>


        //<Snippet20>
        private void SampleTableNode_ContextEnter(object sender,
            Microsoft.Office.Tools.Word.ContextChangeEventArgs e)
        {
            if (showAll.showCheck.Checked == false)
            {
                this.ActionsPane.Controls.Remove(addText);
                this.ActionsPane.Controls.Add(showProperties);
            }
            showProperties.tableProperties.Enabled = true;
        }
        //</Snippet20>


        //<Snippet21>
        private void SampleTableNode_ContextLeave(object sender,
            Microsoft.Office.Tools.Word.ContextChangeEventArgs e)
        {
            if (showAll.showCheck.Checked == false)
            {
                this.ActionsPane.Controls.Remove(showProperties);
            }
            showProperties.tableProperties.Enabled = false;
        }
        //</Snippet21>


        //---------------------------------------------------------------------
        //<Snippet23>
        private void showCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (showAll.showCheck.Checked)
            {
                this.ActionsPane.Controls.Add(addText);
                this.ActionsPane.Controls.Add(showProperties);
            }
            else
            {
                this.ActionsPane.Controls.Remove(addText);
                this.ActionsPane.Controls.Remove(showProperties);
            }
        }
        //</Snippet23>


        //---------------------------------------------------------------------
        //<Snippet29>
        //<Snippet32>
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            this.ActionsPane.OrientationChanged += new EventHandler(ActionsPane_OrientationChanged);
        }
        //</Snippet32>

        //<Snippet30>
        private void ActionsPane_OrientationChanged(object sender, EventArgs e)
        {
            if (ActionsPane.Orientation == Orientation.Horizontal)
            {
        //</Snippet30>
        //<Snippet31>
                this.ActionsPane.StackOrder = Microsoft.Office.Tools.StackStyle.FromLeft;
            }
            else
            {
                this.ActionsPane.StackOrder = Microsoft.Office.Tools.StackStyle.FromTop;
            }
        }
        //</Snippet31>
        //</Snippet29>

        private void Position()
        {
            //<Snippet100>
            this.CommandBars["Task Pane"].Position =
                Microsoft.Office.Core.MsoBarPosition.msoBarLeft;
            //</Snippet100>
        }

        private void SetTopandLeft()
        {
        //<Snippet101>
            if (this.CommandBars["Task Pane"].Position == 
                Microsoft.Office.Core.MsoBarPosition.msoBarFloating)
            {
                this.CommandBars["Task Pane"].Top = 0;
                this.CommandBars["Task Pane"].Left = 0;
            }
        //</Snippet101>
        }

       private void SetAPWidth()
       {
           //<Snippet102>
           this.CommandBars["Task Pane"].Width = 200;
           //</Snippet102>
       }
     }
}
