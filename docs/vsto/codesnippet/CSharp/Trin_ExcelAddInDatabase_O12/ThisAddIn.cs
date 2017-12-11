using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace Trin_ExcelAddInDatabase_O12
{
    public partial class ThisAddIn
    {
        // <Snippet1>
        private Microsoft.Office.Tools.Excel.ListObject addressListObject;
        private AdventureWorksLTDataSet adventureWorksDataSet;
        private AdventureWorksLTDataSetTableAdapters.AddressTableAdapter addressTableAdapter;
        private System.Windows.Forms.BindingSource addressBindingSource;
        // </Snippet1>

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            // <Snippet2>
            this.addressTableAdapter = new AdventureWorksLTDataSetTableAdapters.AddressTableAdapter();
            this.adventureWorksDataSet = new AdventureWorksLTDataSet();
            this.addressTableAdapter.Fill(this.adventureWorksDataSet.Address);
            this.addressBindingSource = new System.Windows.Forms.BindingSource();
            // </Snippet2>

            // <Snippet3>
            Excel.Worksheet worksheet = (Excel.Worksheet)this.Application.ActiveWorkbook.Worksheets[1];
            // Create a workhseet host item.
            Worksheet extendedWorksheet = Globals.Factory.GetVstoObject(worksheet);
            

            // </Snippet3>

            // <Snippet4>
            Excel.Range cell = extendedWorksheet.Range["$A$1:$G$5"];
            this.addressListObject = extendedWorksheet.Controls.AddListObject(cell, "list1");
            // </Snippet4>

            // <Snippet5>
            this.addressBindingSource.DataSource = this.adventureWorksDataSet.Address;
            this.addressListObject.AutoSetDataBoundColumnHeaders = true;
            this.addressListObject.SetDataBinding(
                this.addressBindingSource, "", "AddressID", "AddressLine1", 
                "AddressLine2", "City", "StateProvince", "CountryRegion", "PostalCode");
            // </Snippet5>
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
