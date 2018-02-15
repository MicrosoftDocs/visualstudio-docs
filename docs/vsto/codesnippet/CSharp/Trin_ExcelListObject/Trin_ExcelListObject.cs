using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace Trin_ExcelListObject
{
    public partial class Trin_ExcelListObject
    {
        // This object is to allow Snippet6 to compile. This snippet assumes
        // an existing ListObject.
        Microsoft.Office.Tools.Excel.ListObject customerListObject = null;

        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            try
            {
                //ListObject_Metadata();
                //ListObject_SelectedIndex();
                //ListObject_Delete();
                //ListObject_Publish("URL");
                //ListObject_Resize();
                //ListObject_UpdateChanges();
                //ListObject_SetDataBinding();
                //ListObject_Application();
                //ListObject_BeforeAddDataBoundRow();
                //ListObject_BeforeDoubleClick();
                //ListObject_BeforeRightClick();
                //ListObject_Change();
                //ListObject_Creator();
                //ListObject_DataBindingFailure();
                //ListObject_DataBodyRange();
                //ListObject_DataBoundFormat();
                //ListObject_DataBoundFormatSettings();
                //ListObject_DataSourceAndMember();
                //ListObject_Deselected();
                //ListObject_ErrorAddDataBoundRow();
                //ListObject_HeaderRowRange();
                //ListObject_InsertRowRange();
                //ListObject_ListColumns();
                //ListObject_ListRows();
                //ListObject_OriginalDataRestored();
                //ListObject_Parent();
                //ListObject_QueryTable();
                //ListObject_Range();
                //ListObject_Selected();
                //ListObject_SelectionChange();
                //ListObject_SetDataBinding2();
                //ListObject_SetDataBinding3();
                //ListObject_SharePointURL();
                //ListObject_SourceType();
                //ListObject_TotalsRowRange();
                //ListObject_XmlMap();
                //ListObject_ListRanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }


        #region Used Snippets

        // This snippet uses Name and Tag.
        // The following code example creates a ListObject
        // on the current worksheet and then uses the Name 
        // property to set the name of the ListObject to "Employees".
        //<Snippet1>
        private void ListObject_Metadata()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(this.Range["A1", "D4"], "Employees");

            list1.Name = "Employees";
            list1.Tag = "Employee data";

            MessageBox.Show("The list name is " + list1.Name.ToString() +
                " and the tag is " + list1.Tag.ToString() + ".");
        }
        //</Snippet1>


        // This snippet uses AutoSelectRows, SelectedIndex, and SelectedIndexChanged.
        // The following code example creates a ListObject 
        // on the current worksheet and then uses the SelectedIndex 
        // and AutoSelectRows properties to select the second row 
        // by default and to specify that the entire row is selected 
        // when the user clicks a row. The code example also creates 
        // an event handler for the SelectedIndexChanged event that 
        // displays a message box whenever a new row is selected.
        //<Snippet2>
        private void ListObject_SelectedIndex()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(this.Range["A1", "D4"],
                "list1");

            list1.AutoSelectRows = true;
            list1.SelectedIndex = 2;
            list1.SelectedIndexChanged +=
                new EventHandler(list1_SelectedIndexChanged);
        }

        void list1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected index has changed.");
        }
        //</Snippet2>


        // The following code example creates a ListObject 
        // on the current worksheet and then displays a 
        // message box that asks the user whether to 
        // delete the ListObject. If the user accepts, 
        // then the Delete method is called to remove the ListObject.
        //<Snippet3>
        private void ListObject_Delete()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(this.Range["A1", "D4"], "list1");

            if (DialogResult.Yes == MessageBox.Show("Delete the ListObject?",
                "Test", MessageBoxButtons.YesNo))
            {
                list1.Delete();
            }
        }
        //</Snippet3>


        // This snippet uses Publish, SharePoint
        // The following code example creates a 
        // ListObject on the current worksheet and then 
        // calls the Publish method to publish the 
        // ListObject to a Web site that is running 
        // Microsoft Windows SharePoint Services. This 
        // example assumes that the SharePointURL parameter 
        // identifies a valid URL to a Web site running 
        // Microsoft Windows SharePoint Services. 
        //<Snippet4>
        private void ListObject_Publish(string SharePointURL)
        {
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(this.Range["A1", "D4"], "Employees");

            // Publish the list object to the SharePoint URL.
            object[] TargetParam = { SharePointURL, "Employees", "Employee data" };
            list1.Publish(TargetParam, false);
        }
        //</Snippet4>


        // The following code example creates a ListObject 
        // on the current worksheet and then calls the 
        // Resize method to increase the size of the ListObject.
        //<Snippet5>
        private void ListObject_Resize()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(this.Range["A1", "D4"], "list1");

            if (DialogResult.Yes == MessageBox.Show("Resize the ListObject?",
                "Test", MessageBoxButtons.YesNo))
            {
                list1.Resize(this.Range["A1", "H4"]);
            }
        }
        //</Snippet5>


        // The following code example uses the UpdateChanges 
        // method to submit changes to an existing ListObject 
        // to a Web site that is running Microsoft Windows 
        // SharePoint Services. This example assumes that 
        // the worksheet contains a ListObject named customerListObject 
        // that has already been published to a Web site 
        // running Microsoft Windows SharePoint Services.
        //<Snippet6>
        private void ListObject_UpdateChanges()
        {
            this.customerListObject.UpdateChanges(
                Excel.XlListConflict.xlListConflictDialog);
        }
        //</Snippet6>


        //<Snippet7>
        private void ListObject_SetDataBinding()
        {
            int[] Ages = { 32, 44, 28, 61 };
            string[] Names = { "Reggie", "Sally", "Henry", "Christine" };

            // Create a data table with two columns.
            System.Data.DataTable table = new DataTable();
            DataColumn column1 = new DataColumn("Names", typeof(string));
            DataColumn column2 = new DataColumn("Ages", typeof(int));
            table.Columns.Add(column1);
            table.Columns.Add(column2);

            // Add the four rows of data to the table.
            DataRow row;
            for (int i = 0; i < 4; i++)
            {
                row = table.NewRow();
                row["Names"] = Names[i];
                row["Ages"] = Ages[i];
                table.Rows.Add(row);
            }

            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(this.Range["A1", "B4"], "list1");

            // Bind the list object to the table.
            list1.SetDataBinding(table);
        }
        //</Snippet7>


        // The following code example gets the name and version of the 
        // application that contains the list object and displays the
        // information in a messagebox.
        //<Snippet8>
        private void ListObject_Application()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(this.Range["A1", "B2"],
                "list1");
            string applicationVersion = list1.Application.Name +
                " " + list1.Application.Version;
            MessageBox.Show(applicationVersion);
        }
        //</Snippet8>


        // The following code example creates a DataTable and a
        // list object, and binds the list object to the table.
        // It then creates a BeforeAddDataBoundRow event handler.
        // To test the event, manually add a new row to the list
        // object on sheet 1. The event handler removes the row
        // and displays a message.
        //<Snippet9>
        private void ListObject_BeforeAddDataBoundRow()
        {
            // Create a new DataSet and DataTable.
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("Customers");
            dt.Columns.Add(new DataColumn("LastName"));
            dt.Columns.Add(new DataColumn("FirstName"));

            // Add a new row to the DataTable.
            DataRow dr = dt.NewRow();
            dr["LastName"] = "Chan";
            dr["FirstName"] = "Gareth";
            dt.Rows.Add(dr);

            // Create a list object.
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(
                this.Range["A1"], "list1");

            // Bind the list object to the DataTable.
            list1.AutoSetDataBoundColumnHeaders = true;
            list1.SetDataBinding(ds, "Customers", "LastName",
                "FirstName");

            // Create the event handler.
            list1.BeforeAddDataBoundRow += new 
                Microsoft.Office.Tools.Excel.
                BeforeAddDataBoundRowEventHandler(
                list1_BeforeAddDataBoundRow);
        }

        void list1_BeforeAddDataBoundRow(object sender, 
            Microsoft.Office.Tools.Excel.BeforeAddDataBoundRowEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("This data is read-only.");
        }
        //</Snippet9>


        // The following code example creates a list object and
        // a BeforeDoubleClick event handler. When the list object
        // is double-clicked, a message is displayed that
        // indicates whether the list object is bound to data.
        //<Snippet10>
        Microsoft.Office.Tools.Excel.ListObject list2;
        private void ListObject_BeforeDoubleClick()
        {
            list2 = this.Controls.AddListObject(
                this.Range["A1", "C4"], "list2");
            list2.BeforeDoubleClick += new 
                Microsoft.Office.Interop.Excel.
                DocEvents_BeforeDoubleClickEventHandler(
                list2_BeforeDoubleClick);
        }

        void list2_BeforeDoubleClick(Microsoft.Office.Interop.Excel.Range 
            Target, ref bool Cancel)
        {
            MessageBox.Show("Data binding is " + list2.IsBinding);
        }
        //</Snippet10>


        // The following code example creates a list object and
        // a BeforeRightClick event handler. When the list object
        // is right-clicked, a message is displayed that
        // indicates whether the list object is bound to data.
        //<Snippet11>
        Microsoft.Office.Tools.Excel.ListObject list3;
        private void ListObject_BeforeRightClick()
        {
            list3 = this.Controls.AddListObject(
                this.Range["A1", "C4"], "list3");
            list3.BeforeRightClick += new 
                Microsoft.Office.Interop.Excel.
                DocEvents_BeforeRightClickEventHandler(
                list3_BeforeRightClick);
        }

        void list3_BeforeRightClick(Microsoft.Office.Interop.Excel.Range 
            Target, ref bool Cancel)
        {
            MessageBox.Show("Data binding is " + list3.IsBinding);
            Cancel = true;
        }
        //</Snippet11>


        // The following code example creates a list object and
        // a Change event handler. To raise the Change event, add
        // text to one of the cells in the list object and then 
        // press ENTER.
        //<Snippet12>
        private void ListObject_Change()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(
                this.Range["A1", "C4"], "list1");
            list1.Change += new Microsoft.Office.Tools.Excel.
                ListObjectChangeHandler(list1_Change);
        }

        void list1_Change(Microsoft.Office.Interop.Excel.Range 
            targetRange, Microsoft.Office.Tools.Excel.ListRanges 
            changedRanges)
        {
            string cellAddress = targetRange.get_Address(
                Excel.XlReferenceStyle.xlA1 
                );

            switch (changedRanges)
            {
                case Microsoft.Office.Tools.Excel.ListRanges.DataBodyRange:
                    MessageBox.Show("The cells at range " + cellAddress +
                        " in the data body changed.");
                    break;
                case Microsoft.Office.Tools.Excel.ListRanges.HeaderRowRange:
                    MessageBox.Show("The cells at range " + cellAddress +
                        " in the header row changed.");
                    break;
                case Microsoft.Office.Tools.Excel.ListRanges.TotalsRowRange:
                    MessageBox.Show("The cells at range " + cellAddress +
                        " in the totals row changed.");
                    break;
                default:
                    MessageBox.Show("The cells at range " + cellAddress +
                        " changed.");
                    break;
            }
        }
        //</Snippet12>


        // The following code example creates a list object and checks
        // whether the creator code matches Excel. If the creator code
        // matches, the code displays a message box.
        //<Snippet13>
        private void ListObject_Creator()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(
                this.Range["A1", "C4"], "list1");
            if (list1.Creator == Excel.XlCreator.xlCreatorCode)
            {
                MessageBox.Show("This list object was created in Microsoft Office Excel.");
            }
        }
        //</Snippet13>


        // The following code example creates a list object and adds
        // an event handler for the DataBindingFailure event. If list1
        // is bound to a data source and then the binding fails, the event
        // is caught and a message appears showing the state of the 
        // binding.
        //<Snippet14>
        Microsoft.Office.Tools.Excel.ListObject list4;
        private void ListObject_DataBindingFailure()
        {
            list4 = this.Controls.AddListObject(
                this.Range["A1", "C4"], "list4");
            list4.DataBindingFailure += new EventHandler(list4_DataBindingFailure);
        }

        void list4_DataBindingFailure(object sender, EventArgs e)
        {
            MessageBox.Show("Data binding is " + list4.IsBinding);
        }
        //</Snippet14>


        // The following code example creates a list object and then
        // shows the number of rows that are available for data.
        //<Snippet15>
        private void ListObject_DataBodyRange()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(
                this.Range["A1", "C4"], "list1");
            Excel.Range list1BodyRange = list1.DataBodyRange;
            int numberOfRows = list1BodyRange.Rows.Count;
            MessageBox.Show("The DataBodyRange of list1 has " +
                numberOfRows.ToString() + " rows.");
        }
        //</Snippet15>


        // The following code example creates a DataTable and a
        // list object, and binds the list object to the table.
        // It then uses an xlRangeAutoFormat value to format the
        // list object.
        //<Snippet16>
        private void ListObject_DataBoundFormat()
        {
            // Create a new DataSet and DataTable.
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("Customers");
            dt.Columns.Add(new DataColumn("LastName"));
            dt.Columns.Add(new DataColumn("FirstName"));

            // Add a new row to the DataTable.
            DataRow dr = dt.NewRow();
            dr["LastName"] = "Chan";
            dr["FirstName"] = "Gareth";
            dt.Rows.Add(dr);

            // Create a list object.
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(
                this.Range["A1"], "list1");

            // Bind the list object to the DataTable.
            list1.AutoSetDataBoundColumnHeaders = true;
            list1.SetDataBinding(ds, "Customers", "LastName",
                "FirstName");

            // Add a format to the list object.
            list1.DataBoundFormat = 
                Excel.XlRangeAutoFormat.xlRangeAutoFormatList2;
        }
        //</Snippet16>

        // The following code example creates a DataTable and a
        // list object, and binds the list object to the table.
        // It then sets the FormatSettings to apply to the list
        // object and uses an xlRangeAutoFormat value to supply
        // the format.
        //<Snippet17>
        private void ListObject_DataBoundFormatSettings()
        {
            // Create a new DataSet and DataTable.
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("Customers");
            dt.Columns.Add(new DataColumn("LastName"));
            dt.Columns.Add(new DataColumn("FirstName"));

            // Add a new row to the DataTable.
            DataRow dr = dt.NewRow();
            dr["LastName"] = "Chan";
            dr["FirstName"] = "Gareth";
            dt.Rows.Add(dr);

            // Create a list object.
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(
                this.Range["A1"], "list1");

            // Bind the list object to the DataTable.
            list1.AutoSetDataBoundColumnHeaders = true;
            list1.SetDataBinding(ds, "Customers", "LastName",
                "FirstName");

            // Specify the format settings that you want to include.
            // In this example, only the Font and Pattern 
            // settings are applied.
            list1.DataBoundFormatSettings =
                Microsoft.Office.Tools.Excel.FormatSettings.Font |
                Microsoft.Office.Tools.Excel.FormatSettings.Pattern;

            // Add a format to the list object.
            list1.DataBoundFormat = 
                Excel.XlRangeAutoFormat.xlRangeAutoFormatList2;
        }
        //</Snippet17>


        // The following code example creates a DataSet with two
        // DataTables and populates one of the tables with data.
        // The code then sets the DataSource and DataMember
        // properties of the list object to bind to the table
        // that contains data.
        //<Snippet18>
        private void ListObject_DataSourceAndMember()
        {
            // Create a DataSet and two DataTables.
            DataSet ordersDataSet = new DataSet("ordersDataSet");
            DataTable tableCustomers = new DataTable("Customers");
            DataTable tableProducts = new DataTable("Products");
            ordersDataSet.Tables.Add(tableCustomers);
            ordersDataSet.Tables.Add(tableProducts);

            // Add a data to the Customers DataTable.
            tableCustomers.Columns.Add(new DataColumn("LastName"));
            tableCustomers.Columns.Add(new DataColumn("FirstName"));
            DataRow dr = tableCustomers.NewRow();
            dr["LastName"] = "Chan";
            dr["FirstName"] = "Gareth";
            tableCustomers.Rows.Add(dr);

            // Create a list object.
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(
                this.Range["A1"], "Customers");

            // Bind the list object to the Customers table.
            list1.AutoSetDataBoundColumnHeaders = true;
            list1.DataSource = ordersDataSet;
            list1.DataMember = "Customers";
        }
        //</Snippet18>

        // For ListObject_DataSource, see the preceding snippet.


        // The following code example creates a list object and
        // a Deselected event handler. When the list object is
        // selected and then an object outside of the list object
        // is selected, a message is displayed that indicates
        // that the selection has changed.
        //<Snippet19>
        private void ListObject_Deselected()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(
                this.Range["A1", "C4"], "list1");
            list1.Deselected += new 
                Microsoft.Office.Interop.Excel.
                DocEvents_SelectionChangeEventHandler(list1_Deselected);
        }

        void list1_Deselected(Microsoft.Office.Interop.Excel.Range Target)
        {
            MessageBox.Show("List1 is no longer selected.");
        }
        //</Snippet19>


        // The following code example creates a DataTable and a
        // list object, and binds the list object to the table.
        // It then creates an ErrorAddDataBoundRow event handler.
        // To test the event, manually add a new row to the list
        // and enter the last name "Chan" and a first name. The 
        // event handler displays a message.
        //<Snippet20>
        private void ListObject_ErrorAddDataBoundRow()
        {
            // Create a new DataSet and DataTable.
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("Customers");
            DataColumn lastName = new DataColumn("LastName");
            dt.Columns.Add(lastName);
            dt.Columns.Add(new DataColumn("FirstName"));

            UniqueConstraint myUC = new UniqueConstraint( "CustConstraint", 
                lastName);
            dt.Constraints.Add(myUC);

            // Add a new row to the DataTable.
            DataRow dr = dt.NewRow();
            dr["LastName"] = "Chan";
            dr["FirstName"] = "Gareth";
            dt.Rows.Add(dr);

            // Create a list object.
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(
                this.Range["A1"], "list1");

            // Bind the list object to the DataTable.
            list1.AutoSetDataBoundColumnHeaders = true;
            list1.SetDataBinding(ds, "Customers", "LastName",
                "FirstName");

            // Create the event handler.
            list1.ErrorAddDataBoundRow += new 
                Microsoft.Office.Tools.Excel.
                ErrorAddDataBoundRowEventHandler(list1_ErrorAddDataBoundRow);
        }

        void list1_ErrorAddDataBoundRow(object sender, 
            Microsoft.Office.Tools.Excel.ErrorAddDataBoundRowEventArgs e)
        {
            MessageBox.Show("Last names must be unique.");
        }
        //</Snippet20>


        // The following code example creates a DataTable and a
        // list object, and binds the list object to the table.
        // It then gets the range that contains the header row
        // and changes the header row font to bold.
        //<Snippet21>
        private void ListObject_HeaderRowRange()
        {
            // Create a new DataSet and DataTable.
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("Customers");
            dt.Columns.Add(new DataColumn("LastName"));
            dt.Columns.Add(new DataColumn("FirstName"));

            // Add a new row to the DataTable.
            DataRow dr = dt.NewRow();
            dr["LastName"] = "Chan";
            dr["FirstName"] = "Gareth";
            dt.Rows.Add(dr);

            // Create a list object.
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(
                this.Range["A1"], "list1");

            // Bind the list object to the DataTable.
            list1.AutoSetDataBoundColumnHeaders = true;
            list1.SetDataBinding(ds, "Customers", "LastName",
                "FirstName");

            // Get the header row range and set the font to bold.
            Excel.Range headerRow = list1.HeaderRowRange;
            headerRow.Cells.Font.Bold = true;
        }
        //</Snippet21>


        // The following code example creates a list object, 
        // gets the range that contains the insert row, and
        // then displays a message showing how many cells the
        // insert row contains.
        //<Snippet22>
        private void ListObject_InsertRowRange()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(
                this.Range["A1", "C4"], "list1");
            
            Excel.Range insertRow = list1.InsertRowRange;
            MessageBox.Show("The insert row contains " + 
                insertRow.Cells.Count.ToString() +
                " cells.");
        }
        //</Snippet22>


        // The following code example creates a list object, 
        // gets the collection of columns, and then displays
        // a message showing how many columns the list object
        // contains.
        //<Snippet23>
        private void ListObject_ListColumns()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(
                this.Range["A1", "C4"], "list1");

            Excel.ListColumns list1Columns = list1.ListColumns;
            MessageBox.Show("The list object contains " + 
                list1Columns.Count.ToString() + " columns.");
        }
        //</Snippet23>


        // The following code example creates a list object, 
        // gets the collection of rows, and then displays
        // a message showing how many rows the list object
        // contains.
        //<Snippet24>
        private void ListObject_ListRows()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(
                this.Range["A1", "C4"], "list1");

            Excel.ListRows list1Rows = list1.ListRows;
            MessageBox.Show("The list object contains " +
                list1Rows.Count.ToString() + " rows.");
        }
        //</Snippet24>


        // The following code example creates a DataTable and a
        // list object, and binds the list object to the table.
        // It then creates an OriginalDataRestored event handler.
        // To test the event, right-click a column letter above 
        // the list object on sheet 1 and then click Delete in 
        // the shortcut menu. The event handler replaces the 
        // column and column header data and displays a message
        // each time.
        //<Snippet25>
        private void ListObject_OriginalDataRestored()
        {
            // Create a new DataSet and DataTable.
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("Customers");
            DataColumn lastName = new DataColumn("LastName");
            dt.Columns.Add(lastName);
            dt.Columns.Add(new DataColumn("FirstName"));

            // Add two new rows to the DataTable.
            DataRow dr1 = dt.NewRow();
            dr1["LastName"] = "Chan";
            dr1["FirstName"] = "Gareth";
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2["LastName"] = "Nitsche";
            dr2["FirstName"] = "Sonja";
            dt.Rows.Add(dr2);

            // Create a list object.
            Microsoft.Office.Tools.Excel.ListObject list1 = 
                this.Controls.AddListObject(
                this.Range["A1"], "list1");

            // Bind the list object to the DataTable.
            list1.AutoSetDataBoundColumnHeaders = true;
            list1.SetDataBinding(ds, "Customers", "LastName",
                "FirstName");

            // Create the event handler.
            list1.OriginalDataRestored += new 
                Microsoft.Office.Tools.Excel.
                OriginalDataRestoredEventHandler(list1_OriginalDataRestored);
        }

        void list1_OriginalDataRestored(object sender, 
            Microsoft.Office.Tools.Excel.OriginalDataRestoredEventArgs e)
        {
            MessageBox.Show("This data is bound to a data source and " +
            "will be restored. This change is: " + e.ChangeType.ToString() +
            ". The reason is: " + e.ChangeReason.ToString() + ".");
        }
        //</Snippet25>


        // The following code example creates a list object and
        // then displays the name of the list object's parent 
        // object in a message.
        //<Snippet26>
        private void ListObject_Parent()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(
                this.Range["A1", "C4"], "list1");

            Excel.Worksheet list1Parent = (Excel.Worksheet)list1.Parent;
            MessageBox.Show("The parent of list1 is " +
                list1Parent.Name.ToString());
        }
        //</Snippet26>


        // The following code example uses the QueryTable 
        // property to refresh the query table that intersects 
        // a list object. This code example assumes that 
        // the current worksheet contains a list object 
        // named customerListObject that is intersected by 
        // a query table.
        //<Snippet27>
        private void ListObject_QueryTable()
        {
            this.customerListObject.QueryTable.Refresh();
        }
        //</Snippet27>


        // The following code example creates a list object
        // and then displays a message showing how many cells
        // are in the range to which the list object applies.
        //<Snippet28>
        private void ListObject_Range()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(
                this.Range["A1", "C4"], "list1");

            MessageBox.Show("The list object contains " +
                list1.Range.Cells.Count.ToString() + " cells.");
        }
        //</Snippet28>


        // The following code example creates a list object
        // and then creates an event handler for the Selected
        // event. To test the event handler, ensure that the 
        // list object is not selected, and then select it.
        //<Snippet29>
        private void ListObject_Selected()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(
                this.Range["A1", "C4"], "list1");

            list1.Selected += new Microsoft.Office.Interop.Excel.
                DocEvents_SelectionChangeEventHandler(list1_Selected);
        }

        void list1_Selected(Microsoft.Office.Interop.Excel.Range Target)
        {
            MessageBox.Show("The list object has been selected.");
        }
        //</Snippet29>


        // The following code example creates a list object
        // and then creates an event handler for the
        // SelectionChange event. To test the event handler,
        // select a cell in the list object and then select
        // a different cell in the list object.
        //<Snippet30>
        private void ListObject_SelectionChange()
        {
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(
                this.Range["A1", "C4"], "list1");
            list1.SelectionChange += new Microsoft.Office.Interop.
                Excel.DocEvents_SelectionChangeEventHandler(
                list1_SelectionChange);
        }

        void list1_SelectionChange(Microsoft.Office.Interop.Excel.Range Target)
        {
            MessageBox.Show("The selection in the list object has changed.");
        }
        //</Snippet30>


        // The following code example creates a DataSet, a
        // DataTable, and a list object. It then binds the
        // list object to the DataSet and the DataTable.
        //<Snippet31>
        private void ListObject_SetDataBinding2()
        {
            int[] Ages = { 32, 44, 28, 61 };
            string[] Names = { "Reggie", "Sally", "Henry", "Christine" };

            // Create a data table with two columns.
            DataSet ds = new DataSet();
            DataTable table = ds.Tables.Add("Customers");
            DataColumn column1 = new DataColumn("Names", typeof(string));
            DataColumn column2 = new DataColumn("Ages", typeof(int));
            table.Columns.Add(column1);
            table.Columns.Add(column2);

            // Add the four rows of data to the table.
            DataRow row;
            for (int i = 0; i < 4; i++)
            {
                row = table.NewRow();
                row["Names"] = Names[i];
                row["Ages"] = Ages[i];
                table.Rows.Add(row);
            }

            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(this.Range["A1", "B4"], "list1");

            // Bind the list object to the table.
            list1.SetDataBinding(ds, "Customers");
        }
        //</Snippet31>


        // The following code example creates a DataSet, a
        // DataTable, and a list object. It then binds the
        // list object to the DataSet and the DataTable, but
        // only includes one of the two possible table 
        // columns in the list object.
        //<Snippet32>
        private void ListObject_SetDataBinding3()
        {
            int[] Ages = { 32, 44, 28, 61 };
            string[] Names = { "Reggie", "Sally", "Henry", "Christine" };

            // Create a data table with two columns.
            DataSet ds = new DataSet();
            DataTable table = ds.Tables.Add("Customers");
            DataColumn column1 = new DataColumn("Names", typeof(string));
            DataColumn column2 = new DataColumn("Ages", typeof(int));
            table.Columns.Add(column1);
            table.Columns.Add(column2);

            // Add the four rows of data to the table.
            DataRow row;
            for (int i = 0; i < 4; i++)
            {
                row = table.NewRow();
                row["Names"] = Names[i];
                row["Ages"] = Ages[i];
                table.Rows.Add(row);
            }

            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(this.Range["A1", "B4"], "list1");

            // Bind the list object to the table.
            string[] mappedColumn = { "Names" };
            list1.SetDataBinding(ds, "Customers", mappedColumn);
        }
        //</Snippet32>


        // The following code example publishes a ListObject 
        // to a Web site that is running Microsoft Windows 
        // SharePoint Services. This example assumes that 
        // there is a list object named customerListObject 
        // on the current worksheet, and that the list object is
        // linked to a SharePoint site. 
        //<Snippet33>
        private void ListObject_SharePointURL()
        {
            string[] TargetParam = { customerListObject.SharePointURL,
                "Customers", "Customer data" };
            customerListObject.Publish(TargetParam, false);
        }
        //</Snippet33>


        // The following code example creates a DataTable
        // and a list object, and then binds the list object
        // to the table. It then displays the source of the
        // list in a message.
        //<Snippet34>
        private void ListObject_SourceType()
        {
            // Create a new DataSet and DataTable.
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("Customers");
            dt.Columns.Add(new DataColumn("LastName"));
            dt.Columns.Add(new DataColumn("FirstName"));

            // Add a new row to the DataTable.
            DataRow dr = dt.NewRow();
            dr["LastName"] = "Chan";
            dr["FirstName"] = "Gareth";
            dt.Rows.Add(dr);

            // Create a list object.
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(
                this.Range["A1"], "list1");

            // Bind the list object to the DataTable.
            list1.AutoSetDataBoundColumnHeaders = true;
            list1.SetDataBinding(ds, "Customers", "LastName",
                "FirstName");

            // Get the source type and display it in a message.
            MessageBox.Show("The source type of list1 is " +
                list1.SourceType.ToString() + ".");
        }
        //</Snippet34>


        // The following code example creates a DataTable and a
        // list object, and binds the list object to the table.
        // It then gets the range that contains the Total row
        // and changes the Total row font to italic.
        //<Snippet35>
        private void ListObject_TotalsRowRange()
        {
            // Create a new DataSet and DataTable.
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("Sales");
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("Quarter1"));

            // Add a new row to the DataTable.
            DataRow dr1 = dt.NewRow();
            dr1["Name"] = "Sidney";
            dr1["Quarter1"] = "150";
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2["Name"] = "Julia";
            dr2["Quarter1"] = "175";
            dt.Rows.Add(dr2);

            // Create a list object.
            Microsoft.Office.Tools.Excel.ListObject list1 =
                this.Controls.AddListObject(
                this.Range["A1"], "list1");

            // Bind the list object to the DataTable.
            list1.AutoSetDataBoundColumnHeaders = true;
            list1.SetDataBinding(ds, "Sales", "Name",
                "Quarter1");
            list1.ShowTotals = true;

            // Get the header row range and set the font to bold.
            Excel.Range totalRow = list1.TotalsRowRange;
            totalRow.Cells.Font.Italic = true;
        }
        //</Snippet35>


        // The following code example displays the name of
        // the XmlMap that is mapped to a list object. This
        // example assumes that there is a list object named
        // customerListObject on the current worksheet, and
        // that the list object uses a schema map.
        //<Snippet36>
        private void ListObject_XmlMap()
        {
            Excel.XmlMap customerXmlMap = customerListObject.XmlMap;
            MessageBox.Show("The current XmlMap for customerListObject is " +
                customerXmlMap.Name.ToString() + ".");
        }
        //</Snippet36>


        #endregion


        #region Unused Snippets - Events

        //private void WireEvents()
        //{
        //    //<friendlyName ID=36>Microsoft.Office.Tools.Excel.ListObject.BeforeDoubleClick</friendlyName>
        //    //<snippetID:36>
        //    List1.BeforeDoubleClick += new Microsoft.Office.Interop.Excel.DocEvents_BeforeDoubleClickEventHandler(List1_BeforeDoubleClick);
        //    //</snippetID:36>

        //    //<friendlyName ID=37>Microsoft.Office.Tools.Excel.ListObject.BeforeRightClick</friendlyName>
        //    //<snippetID:37>
        //    List1.BeforeRightClick += new Microsoft.Office.Interop.Excel.DocEvents_BeforeRightClickEventHandler(List1_BeforeRightClick);
        //    //</snippetID:37>

        //    //<friendlyName ID=38>Microsoft.Office.Tools.Excel.ListObject.Change</friendlyName>
        //    //<snippetID:38>
        //    List1.Change += new Microsoft.Office.Tools.Excel.ListObjectChangeHandler(List1_Change);
        //    //</snippetID:38>

        //    //<friendlyName ID=39>Microsoft.Office.Tools.Excel.ListObject.SelectionChange</friendlyName>
        //    //<snippetID:39>
        //    List1.SelectionChange += new Microsoft.Office.Interop.Excel.DocEvents_SelectionChangeEventHandler(List1_SelectionChange);
        //    //</snippetID:39>

        //    //<friendlyName ID=40>Microsoft.Office.Tools.Excel.ListObject.Selected</friendlyName>
        //    //<snippetID:40>
        //    List1.Selected += new Microsoft.Office.Interop.Excel.DocEvents_SelectionChangeEventHandler(ListObject_Selected);
        //    //</snippetID:40>

        //    //<friendlyName ID=41>Microsoft.Office.Tools.Excel.ListObject.Deselected</friendlyName>
        //    //<snippetID:41>
        //    List1.Deselected += new Microsoft.Office.Interop.Excel.DocEvents_SelectionChangeEventHandler(ListObject_Deselected);
        //    //</snippetID:41>

        //    //<friendlyName ID=42>Microsoft.Office.Tools.Excel.ListObject.DataSourceChanged</friendlyName>
        //    //<snippetID:42>
        //    List1.DataSourceChanged += new System.EventHandler(ListObject_DataSourceChanged);
        //    //</snippetID:42>

        //    //<friendlyName ID=43>Microsoft.Office.Tools.Excel.ListObject.DataMemberChanged</friendlyName>
        //    //<snippetID:43>
        //    List1.DataMemberChanged += new System.EventHandler(ListObject_DataMemberChanged);
        //    //</snippetID:43>

        //    //<friendlyName ID=44>Microsoft.Office.Tools.Excel.ListObject.SelectedIndexChanged</friendlyName>
        //    //<snippetID:44>
        //    List1.SelectedIndexChanged += new System.EventHandler(ListObject_SelectedIndexChanged);
        //    //</snippetID:44>

        //    //<friendlyName ID=45>Microsoft.Office.Tools.Excel.ListObject.DataBindingFailure</friendlyName>
        //    //<snippetID:45>
        //    List1.DataBindingFailure += new System.EventHandler(ListObject_DataBindingFailure);
        //    //</snippetID:45>

        //    //<friendlyName ID=46>Microsoft.Office.Tools.Excel.ListObject.ErrorAddDataboundRow</friendlyName>
        //    //<snippetID:46>
        //    List1.ErrorAddDataboundRow += new Microsoft.Office.Tools.Excel.ErrorAddDataboundRowHandler(ListObject_ErrorAddDataboundRow);
        //    //</snippetID:46>

        //    //<friendlyName ID=47>Microsoft.Office.Tools.Excel.ListObject.BeforeAddDataboundRow</friendlyName>
        //    //<snippetID:47>
        //    List1.BeforeAddDataboundRow += new Microsoft.Office.Tools.Excel.BeforeAddDataboundRowHandler(ListObject_BeforeAddDataboundRow);
        //    //</snippetID:47>

        //    //<friendlyName ID=48>Microsoft.Office.Tools.Excel.ListObject.OriginalDataRestored</friendlyName>
        //    //<snippetID:48>
        //    List1.OriginalDataRestored += new Microsoft.Office.Tools.Excel.OriginalDataRestoredEventHandler(ListObject_OriginalDataRestored);
        //    //</snippetID:48>

        //    //<friendlyName ID=49>Microsoft.Office.Tools.Excel.ListObject.BindingContextChanged</friendlyName>
        //    //<snippetID:49>
        //    List1.BindingContextChanged += new System.EventHandler(ListObject_BindingContextChanged);
        //    //</snippetID:49>

        //    //<friendlyName ID=50>Microsoft.Office.Tools.Excel.ListObject.Disposed</friendlyName>
        //    //<snippetID:50>
        //    List1.Disposed += new System.EventHandler(ListObject_Disposed);
        //    //</snippetID:50>

        //}
        ////<friendlyName ID=51>Microsoft.Office.Tools.Excel.ListObject.BeforeDoubleClick</friendlyName>
        ////<snippetID:51>
        //void List1_BeforeDoubleClick(Microsoft.Office.Interop.Excel.Range Target, ref bool Cancel)
        //{
        //    throw new NotImplementedException();
        //}
        ////</snippetID:51>

        ////<friendlyName ID=52>Microsoft.Office.Tools.Excel.ListObject.BeforeRightClick</friendlyName>
        ////<snippetID:52>
        //void List1_BeforeRightClick(Microsoft.Office.Interop.Excel.Range Target, ref bool Cancel)
        //{
        //    throw new NotImplementedException();
        //}
        ////</snippetID:52>

        ////<friendlyName ID=53>Microsoft.Office.Tools.Excel.ListObject.Change</friendlyName>
        ////<snippetID:53>
        //void List1_Change(Microsoft.Office.Interop.Excel.Range targetRange, Microsoft.Office.Tools.Excel.ListRanges changedRanges)
        //{
        //    throw new NotImplementedException();
        //}
        ////</snippetID:53>

        ////<friendlyName ID=54>Microsoft.Office.Tools.Excel.ListObject.SelectionChange</friendlyName>
        ////<snippetID:54>
        //void List1_SelectionChange(Microsoft.Office.Interop.Excel.Range Target)
        //{
        //    throw new NotImplementedException();
        //}
        ////</snippetID:54>

        ////<friendlyName ID=55>Microsoft.Office.Tools.Excel.ListObject.Selected</friendlyName>
        ////<snippetID:55>
        //private void ListObject_Selected(object Sender, EventArgs e)
        //{

        //}
        ////</snippetID:55>

        ////<friendlyName ID=56>Microsoft.Office.Tools.Excel.ListObject.Deselected</friendlyName>
        ////<snippetID:56>
        //private void ListObject_Deselected(object Sender, EventArgs e)
        //{

        //}
        ////</snippetID:56>

        ////<friendlyName ID=57>Microsoft.Office.Tools.Excel.ListObject.DataSourceChanged</friendlyName>
        ////<snippetID:57>
        //private void ListObject_DataSourceChanged(object Sender, EventArgs e)
        //{

        //}
        ////</snippetID:57>

        ////<friendlyName ID=58>Microsoft.Office.Tools.Excel.ListObject.DataMemberChanged</friendlyName>
        ////<snippetID:58>
        //private void ListObject_DataMemberChanged(object Sender, EventArgs e)
        //{

        //}
        ////</snippetID:58>

        ////<friendlyName ID=59>Microsoft.Office.Tools.Excel.ListObject.SelectedIndexChanged</friendlyName>
        ////<snippetID:59>
        //private void ListObject_SelectedIndexChanged(object Sender, EventArgs e)
        //{

        //}
        ////</snippetID:59>

        ////<friendlyName ID=60>Microsoft.Office.Tools.Excel.ListObject.DataBindingFailure</friendlyName>
        ////<snippetID:60>
        //private void ListObject_DataBindingFailure(object Sender, EventArgs e)
        //{

        //}
        ////</snippetID:60>

        ////<friendlyName ID=61>Microsoft.Office.Tools.Excel.ListObject.ErrorAddDataboundRow</friendlyName>
        ////<snippetID:61>
        //private void ListObject_ErrorAddDataboundRow(object Sender, EventArgs e)
        //{

        //}
        ////</snippetID:61>

        ////<friendlyName ID=62>Microsoft.Office.Tools.Excel.ListObject.BeforeAddDataboundRow</friendlyName>
        ////<snippetID:62>
        //private void ListObject_BeforeAddDataboundRow(object Sender, EventArgs e)
        //{

        //}
        ////</snippetID:62>

        ////<friendlyName ID=63>Microsoft.Office.Tools.Excel.ListObject.OriginalDataRestored</friendlyName>
        ////<snippetID:63>
        //private void ListObject_OriginalDataRestored(object Sender, EventArgs e)
        //{

        //}
        ////</snippetID:63>

        ////<friendlyName ID=64>Microsoft.Office.Tools.Excel.ListObject.BindingContextChanged</friendlyName>
        ////<snippetID:64>
        //private void ListObject_BindingContextChanged(object Sender, EventArgs e)
        //{

        //}
        ////</snippetID:64>

        ////<friendlyName ID=65>Microsoft.Office.Tools.Excel.ListObject.Disposed</friendlyName>
        ////<snippetID:65>
        //private void ListObject_Disposed(object Sender, EventArgs e)
        //{

        //}
        ////</snippetID:65>

        #endregion

        #region Unused Snippets - Boolean Properties

        ////<friendlyName ID=2>Microsoft.Office.Tools.Excel.ListObject.ShowAutoFilter</friendlyName>
        ////<snippetID:2>
        //private void ListObject_ShowAutoFilter()
        //{
        //    Microsoft.Office.Tools.Excel.ListObject ListObject1 =
        //        this.Controls.AddListObject(this.Range["A1", "D4"], "Employees");

        //    ListObject1.ShowAutoFilter = false;
        //}
        ////</snippetID:2>


        ////<friendlyName ID=3>Microsoft.Office.Tools.Excel.ListObject.ShowTotals</friendlyName>
        ////<snippetID:3>
        //private void ListObject_ShowTotals()
        //{
        //    Microsoft.Office.Tools.Excel.ListObject ListObject1 =
        //        this.Controls.AddListObject(this.Range["A1", "D4"], "Employees");

        //    List1.ShowTotals = false;
        //}
        ////</snippetID:3>


        ////<friendlyName ID=7>Microsoft.Office.Tools.Excel.ListObject.AutoSetDataboundColumnHeaders</friendlyName>
        ////<snippetID:7>
        //private void ListObject_AutoSetDataboundColumnHeaders()
        //{
        //    List1.AutoSetDataboundColumnHeaders = true;
        //}
        ////</snippetID:7>


        ////<friendlyName ID=9>Microsoft.Office.Tools.Excel.ListObject.AutoSelectRows</friendlyName>
        ////<snippetID:9>
        //private void ListObject_AutoSelectRows()
        //{
        //    List1.AutoSelectRows = true;
        //}
        ////</snippetID:9>

        #endregion

        #region Unused Snippets - Parameterless Methods

        ////<friendlyName ID=13>Microsoft.Office.Tools.Excel.ListObject.ResetPersistedBindingInformation</friendlyName>
        ////<snippetID:13>
        //private void ListObject_ResetPersistedBindingInformation()
        //{
        //    List1.ResetPersistedBindingInformation();
        //}
        ////</snippetID:13>


        ////<friendlyName ID=16>Microsoft.Office.Tools.Excel.ListObject.Refresh</friendlyName>
        ////<snippetID:16>
        //private void ListObject_Refresh()
        //{
        //    List1.Refresh();
        //}
        ////</snippetID:16>

        ////<friendlyName ID=18>Microsoft.Office.Tools.Excel.ListObject.Unlink</friendlyName>
        ////<snippetID:18>
        //private void ListObject_Unlink()
        //{
        //    List1.Unlink();
        //}
        ////</snippetID:18>


        ////<friendlyName ID=19>Microsoft.Office.Tools.Excel.ListObject.Unlist</friendlyName>
        ////<snippetID:19>
        //private void ListObject_Unlist()
        //{
        //    List1.Unlist();
        //}
        ////</snippetID:19>


        ////<friendlyName ID=21>Microsoft.Office.Tools.Excel.ListObject.BeginInit</friendlyName>
        ////<snippetID:21>
        //private void ListObject_BeginInit()
        //{
        //    List1.BeginInit();
        //}
        ////</snippetID:21>


        ////<friendlyName ID=22>Microsoft.Office.Tools.Excel.ListObject.EndInit</friendlyName>
        ////<snippetID:22>
        //private void ListObject_EndInit()
        //{
        //    List1.EndInit();
        //}
        ////</snippetID:22>

        #endregion

        #region Unused Snippets - Never Completed

        ////<friendlyName ID=5>Microsoft.Office.Tools.Excel.ListObject.DataSource</friendlyName>
        ////<snippetID:5>
        //private void ListObject_DataSource()
        //{
        //    //List1.DataSource = System.Object
        //}
        ////</snippetID:5>


        ////<friendlyName ID=6>Microsoft.Office.Tools.Excel.ListObject.DataMember</friendlyName>
        ////<snippetID:6>
        //private void ListObject_DataMember()
        //{
        //    //List1.DataMember = System.String
        //}
        ////</snippetID:6>


        ////<friendlyName ID=27>Microsoft.Office.Tools.Excel.ListObject.SetDataBinding</friendlyName>
        ////Parameters:
        ////	dataSource = System.Object
        ////	dataMember = System.String
        ////	mappedColumns = System.String[]
        ////<snippetID:27>
        ////private void ListObject_SetDataBinding()
        ////{
        ////	object missing = System.Type.Missing;
        ////
        ////	object dataSource = missing;
        ////	string dataMember = String.Empty;
        ////	String[] mappedColumns = missing;
        ////
        ////	List1.SetDataBinding(dataSource,dataMember,mappedColumns);
        ////}
        ////</snippetID:27>

        #endregion

        #region Unused Snippets - Internal Only

        ////<friendlyName ID=10>Microsoft.Office.Tools.Excel.ListObject.MappedColumns</friendlyName>
        ////<snippetID:10>
        //private void ListObject_MappedColumns()
        //{
        //    Microsoft.Office.Tools.Excel.ListObject ListObject1 =
        //        this.Controls.AddListObject(this.Range["A1", "D4"], "Employees");

        //    string[] cols = { "Jan", "Feb", "Mar" };
        //    ListObject1.MappedColumns = cols;
        //}
        ////</snippetID:10>

        #endregion

        #region Unused Snippets - Inherited Members

        ////<friendlyName ID=11>Microsoft.Office.Tools.Excel.ListObject.BindingContext</friendlyName>
        ////<snippetID:11>
        //private void ListObject_BindingContext()
        //{
        //    //List1.BindingContext = System.Windows.Forms.BindingContext
        //}
        ////</snippetID:11>


        ////<friendlyName ID=12>Microsoft.Office.Tools.Excel.ListObject.Site</friendlyName>
        ////<snippetID:12>
        //private void ListObject_Site()
        //{
        //    //List1.Site = System.ComponentModel.ISite
        //}
        ////</snippetID:12>

        ////<friendlyName ID=23>Microsoft.Office.Tools.Excel.ListObject.InitializeControl</friendlyName>
        ////Parameters:
        ////	viewHost = Microsoft.VisualStudio.OfficeTools.Interop.Runtime.IViewHost
        ////	runtimeServiceProvider = Microsoft.VisualStudio.OfficeTools.Interop.Runtime.IRuntimeServiceProvider
        ////	primaryCookie = System.String
        ////	container = System.Object
        ////	identifier = System.String
        ////<snippetID:23>
        ////private void ListObject_InitializeControl()
        ////{
        ////	object missing = System.Type.Missing;
        ////
        ////	Excel.IViewHost viewHost = Microsoft.VisualStudio.OfficeTools.Interop.Runtime.IViewHost
        ////	IRuntimeServiceProvider runtimeServiceProvider = missing;
        ////	string primaryCookie = String.Empty;
        ////	object container = missing;
        ////	string identifier = String.Empty;
        ////
        ////	List1.InitializeControl(viewHost,runtimeServiceProvider,primaryCookie,container,identifier);
        ////}
        ////</snippetID:23>


        ////<friendlyName ID=24>Microsoft.Office.Tools.Excel.ListObject.InitializeControl</friendlyName>
        ////Parameters:
        ////	viewHost = Microsoft.VisualStudio.OfficeTools.Interop.Runtime.IViewHost
        ////	runtimeServiceProvider = Microsoft.VisualStudio.OfficeTools.Interop.Runtime.IRuntimeServiceProvider
        ////	primaryCookie = System.String
        ////	extenderCookie = System.String
        ////	container = System.Object
        ////	identifier = System.String
        ////<snippetID:24>
        ////private void ListObject_InitializeControl()
        ////{
        ////	object missing = System.Type.Missing;
        ////
        ////	IViewHost viewHost = missing;
        ////	IRuntimeServiceProvider runtimeServiceProvider = missing;
        ////	string primaryCookie = String.Empty;
        ////	string extenderCookie = String.Empty;
        ////	object container = missing;
        ////	string identifier = String.Empty;
        ////
        ////	List1.InitializeControl(viewHost,runtimeServiceProvider,primaryCookie,extenderCookie,container,identifier);
        ////}
        ////</snippetID:24>


        ////<friendlyName ID=28>Microsoft.Office.Tools.Excel.ListObject.Dispose</friendlyName>
        ////<snippetID:28>
        //private void ListObject_Dispose()
        //{
        //    List1.Dispose();
        //}
        ////</snippetID:28>


        ////<friendlyName ID=29>Microsoft.Office.Tools.Excel.ListObject.ToString</friendlyName>
        ////<snippetID:29>
        //private void ListObject_ToString()
        //{
        //    List1.ToString();
        //}
        ////</snippetID:29>

        ////<friendlyName ID=30>Microsoft.Office.Tools.Excel.ListObject.GetLifetimeService</friendlyName>
        ////<snippetID:30>
        //private void ListObject_GetLifetimeService()
        //{
        //    List1.GetLifetimeService();
        //}
        ////</snippetID:30>


        ////<friendlyName ID=31>Microsoft.Office.Tools.Excel.ListObject.InitializeLifetimeService</friendlyName>
        ////<snippetID:31>
        //private void ListObject_InitializeLifetimeService()
        //{
        //    List1.InitializeLifetimeService();
        //}
        ////</snippetID:31>


        ////<friendlyName ID=32>Microsoft.Office.Tools.Excel.ListObject.CreateObjRef</friendlyName>
        ////Parameters:
        ////	requestedType = System.Type
        ////<snippetID:32>
        ////private void ListObject_CreateObjRef()
        ////{
        ////	object missing = System.Type.Missing;
        ////
        ////	Type requestedType = string.GetType();
        ////
        ////	List1.CreateObjRef(requestedType);
        ////}
        ////</snippetID:32>


        ////<friendlyName ID=33>Microsoft.Office.Tools.Excel.ListObject.GetType</friendlyName>
        ////<snippetID:33>
        //private Type ListObject_GetType()
        //{
        //    return List1.GetType();
        //}
        ////</snippetID:33>


        ////<friendlyName ID=34>Microsoft.Office.Tools.Excel.ListObject.Equals</friendlyName>
        ////Parameters:
        ////	obj = System.Object
        ////<snippetID:34>
        //private void ListObject_Equals()
        //{
        //    object missing = System.Type.Missing;

        //    object obj = missing;

        //    List1.Equals(obj);
        //}
        ////</snippetID:34>


        ////<friendlyName ID=35>Microsoft.Office.Tools.Excel.ListObject.GetHashCode</friendlyName>
        ////<snippetID:35>
        //private void ListObject_GetHashCode()
        //{
        //    List1.GetHashCode();
        //}
        ////</snippetID:35>

        #endregion



        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet1_Startup);
            this.Shutdown += new System.EventHandler(Sheet1_Shutdown);
        }

        #endregion

    }
}
