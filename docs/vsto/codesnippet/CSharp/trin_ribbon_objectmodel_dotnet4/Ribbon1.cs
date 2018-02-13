using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Trin_Ribbon_ObjectModel_DOTNET4
{
    public partial class Ribbon1
    {

        //<Snippet3>
        private void PopulateDynamicMenu()
        {
            menu1.Items.Add(this.Factory.CreateRibbonButton());
            ((RibbonButton)menu1.Items.Last()).Label = "Button 1";
            menu1.Items.Add(this.Factory.CreateRibbonButton());
            ((RibbonButton)menu1.Items.Last()).Label = "Button 2";
        }
        //</Snippet3>
        //<Snippet4>
        private void SetButtonProperties()
        {
            button1.ControlSize =
                Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            button1.Description = "My Ribbon Button";
        }
        //</Snippet4>
        //<Snippet5>
        private void LoadImages()
        {
            button1.ShowImage = true;
            button2.ShowImage = true;
            button1.Image = Properties.Resources.Image1;
            button2.Image = Properties.Resources.Image2;
        }
        //</Snippet5>
        //<Snippet6>
        private void Ribbon1_LoadImage(object sender, RibbonLoadImageEventArgs e)
        {
            switch (e.ImageName)
            {
                case "Button1Image":
                    e.Image = Properties.Resources.Image1;
                    break;
                case "Button2Image":
                    e.Image = Properties.Resources.Image2;
                    break;
            }
        }
        //</Snippet6>
        //<Snippet7>
        private void AssignKeyTips()
        {
            tab1.KeyTip = "Z";
            button1.KeyTip = "A1";
            checkBox1.KeyTip = "A2";
        }
        //</Snippet7>

        //<Snippet8>
        private void AssignTagToButton()
        {
            System.Collections.ArrayList customerArrayList =
                new System.Collections.ArrayList();
            customerArrayList.Add("Jay Hamlin");
            customerArrayList.Add("Yael Peled");
            customerArrayList.Add("Lori Penor");
            button2.Tag = customerArrayList;
        }
        private void Button2_Click(object sender,
            RibbonControlEventArgs e)
        {
            AssignTagToButton();
            System.Collections.ArrayList tempArrayList =
                (System.Collections.ArrayList)button2.Tag;
            foreach (string customer in tempArrayList)
            {
                System.Windows.Forms.MessageBox.Show(customer);
            }
        }
        //</Snippet8>
        //<Snippet9>
        private void AddButtonsToMenu()
        {
            RibbonButton tempButton = this.Factory.CreateRibbonButton();
            tempButton.Label = "Button 1";
            tempButton.ControlSize =
                Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            tempButton.Description = "My Ribbon Button";
            tempButton.ShowImage = true;
            tempButton.ShowImage = true;
            tempButton.Image = Properties.Resources.Image1;
            tempButton.Image = Properties.Resources.Image2;
            tempButton.KeyTip = "A1";
            menu1.Items.Add(tempButton);

        }
        //</Snippet9>
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }
    }
}
