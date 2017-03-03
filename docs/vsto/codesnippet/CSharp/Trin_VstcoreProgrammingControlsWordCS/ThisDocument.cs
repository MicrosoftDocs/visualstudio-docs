using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Word=Microsoft.Office.Interop.Word;
using Office=Microsoft.Office.Core;

namespace Trin_VstcoreProgrammingControlsWordCS
{
    public partial class ThisDocument
    {
        //<Snippet15>
        private void ChartOptions1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                object index = 1;
                Word.Shape shape = this.Shapes.get_Item(ref index);

                // Activate the shape.
                shape.OLEFormat.Activate();

                Microsoft.Office.Interop.Graph.Chart dataChart = 
                    (Microsoft.Office.Interop.Graph.Chart)shape.OLEFormat.Object;
                dataChart.ChartType = this.ChartOptions1.Selection;

                // Deactivate the shape.
                this.ChartOptions1.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //</Snippet15>

        //<Snippet7>
        private void insertText_Click(object sender, EventArgs e)
        {
            this.displayText.Text += "Hello World!";
        }
        //</Snippet7>

        //<Snippet2>
        const int WordTrue = -1;
        const int WordFalse = 0;
        //</Snippet2>

        //<Snippet3>
        private void applyBoldFont_Click(object sender, System.EventArgs e)
        {
            if (this.applyBoldFont.Checked == true)
            {
                this.fontText.Bold = WordTrue;
            }
            else
            {
                this.fontText.Bold = WordFalse;
            }
        }
        //</Snippet3>

        //<Snippet4>
        private void applyItalicFont_Click(object sender, System.EventArgs e)
        {
            if (this.applyItalicFont.Checked == true)
            {
                this.fontText.Italic = WordTrue;
            }
            else
            {
                this.fontText.Italic = WordFalse;
            }
        }
        //</Snippet4>

        //<Snippet5>
        private void applyUnderlineFont_Click(object sender, System.EventArgs e)
        {
            if (this.applyUnderlineFont.Checked == true)
            {
                this.fontText.Underline = Word.WdUnderline.wdUnderlineSingle;
            }
            else
            {
                this.fontText.Underline = Word.WdUnderline.wdUnderlineNone;
            }
        }
        //</Snippet5>

        private void InternalStartup()
        {
            this.Startup+=new System.EventHandler(ThisDocument_Startup);
        }

        void StartUp()
        {
            //<Snippet16>
            this.ChartOptions1.SelectionChanged += new EventHandler(ChartOptions1_SelectionChanged);
            //</Snippet16>

            //<Snippet8>
            this.insertText.Click += new EventHandler(insertText_Click);
            //</Snippet8>

            //<Snippet6>
            this.applyBoldFont.Click += new EventHandler(applyBoldFont_Click);
            this.applyItalicFont.Click += new EventHandler(applyItalicFont_Click);
            this.applyUnderlineFont.Click += new EventHandler(applyUnderlineFont_Click);
            //</Snippet6>
        }

        //<Snippet1>
        // Create the command bar variables at the class level.
        Office.CommandBar commandBar;
        Office.CommandBarButton firstButton;
        Office.CommandBarButton secondButton;

        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            AddToolbar();
        }

        private void AddToolbar()
        {
            try
            {
                commandBar = Application.CommandBars["Test"];
            }
            catch (ArgumentException e)
            {
                // Toolbar named Test does not exist so we should create it.
            }

            if (commandBar == null)
            {
                // Add a commandbar named Test.
                commandBar = Application.CommandBars.Add("Test", 1, missing, true);
            }

            try
            {
                // Add a button to the command bar and an event handler.
                firstButton = (Office.CommandBarButton)commandBar.Controls.Add(
                    1, missing, missing, missing, missing);

                firstButton.Style = Office.MsoButtonStyle.msoButtonCaption;
                firstButton.Caption = "button 1";
                firstButton.Tag = "button1";
                firstButton.Click += new Office._CommandBarButtonEvents_ClickEventHandler(ButtonClick);

                // Add a second button to the command bar and an event handler.
                secondButton = (Office.CommandBarButton)commandBar.Controls.Add(
                    1, missing, missing, missing, missing);

                secondButton.Style = Office.MsoButtonStyle.msoButtonCaption;
                secondButton.Caption = "button 2";
                secondButton.Tag = "button2";
                secondButton.Click += new Office._CommandBarButtonEvents_ClickEventHandler(ButtonClick);

                commandBar.Visible = true;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // Handles the event when a button on the new toolbar is clicked.
        private void ButtonClick(Office.CommandBarButton ctrl, ref bool cancel)
        {
            MessageBox.Show("You clicked: " + ctrl.Caption);
        }
        //</Snippet1>
    }
}
