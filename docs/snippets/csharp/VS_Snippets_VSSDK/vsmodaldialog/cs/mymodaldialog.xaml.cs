﻿//<snippet11>
using System.Windows;
using Microsoft.VisualStudio.PlatformUI;

namespace Microsoft.VSModalDialog
{
    // Use this constructor to enable F1 Help.
    public partial class MyModalDialog : DialogWindow
    {
        //<snippet12>
        // Use this constructor to provide a Help button and F1 support.
        public MyModalDialog(string helpTopic) : base(helpTopic)
        {
            InitializeComponent();
        }
        //</snippet12>

        //<snippet13>
        // Use this constructor for minimize and maximize buttons and no F1 Help.
        public MyModalDialog()
        {
            this.HasMaximizeButton = true;
            this.HasMinimizeButton = true;
            InitializeComponent();
        }
        //</snippet13>
        
        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            var v = new MyModalDialog("Microsoft.VisualStudio.PlatformUI.DialogWindow");
            v.Content = "Here you go.";
            v.ShowModal();
            this.Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Okay.");
            this.Close();
        }
    }
}
//</snippet11>