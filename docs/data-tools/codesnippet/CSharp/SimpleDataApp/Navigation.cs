using System;
using System.Windows.Forms;

namespace SimpleDataApp
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        //<Snippet1>
        /// <summary>
        /// Opens the NewCustomer form as a dialog box,
        /// which returns focus to the calling form when it is closed. 
        /// </summary>
        private void btnGoToAdd_Click(object sender, EventArgs e)
        {
            Form frm = new NewCustomer();
            frm.Show();
        }

        /// <summary>
        /// Opens the FillorCancel form as a dialog box. 
        /// </summary>
        private void btnGoToFillOrCancel_Click(object sender, EventArgs e)
        {
            Form frm = new FillOrCancel();
            frm.ShowDialog();
        }

        /// <summary>
        /// Closes the application (not just the Navigation form).
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //</Snippet1>
    }
}
