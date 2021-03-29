

#using <System.Xml.dll>
#using <System.dll>
#using <System.Windows.Forms.dll>
#using <System.Drawing.dll>
#using <System.Data.dll>

using namespace System;
using namespace System::Data;
using namespace System::Drawing;
using namespace System::Windows::Forms;
using namespace System::ComponentModel;
public ref class Form1: public Form
{
protected:
   DataGrid^ myDataGrid;
   DataSet^ myDataSet;

private:

   // <Snippet1>
   void AddCustomDataTableStyle()
   {
      
      /* Create a new DataGridTableStyle and set
            its MappingName to the TableName of a DataTable. */
      DataGridTableStyle^ ts1 = gcnew DataGridTableStyle;
      ts1->MappingName = "Customers";
      
      /* Add a GridColumnStyle and set its MappingName 
            to the name of a DataColumn in the DataTable. 
            Set the HeaderText and Width properties. */
      DataGridColumnStyle^ boolCol = gcnew DataGridBoolColumn;
      boolCol->MappingName = "Current";
      boolCol->HeaderText = "IsCurrent Customer";
      boolCol->Width = 150;
      ts1->GridColumnStyles->Add( boolCol );
      
      // Add a second column style.
      DataGridColumnStyle^ TextCol = gcnew DataGridTextBoxColumn;
      TextCol->MappingName = "custName";
      TextCol->HeaderText = "Customer Name";
      TextCol->Width = 250;
      ts1->GridColumnStyles->Add( TextCol );
      
      // Create the second table style with columns.
      DataGridTableStyle^ ts2 = gcnew DataGridTableStyle;
      ts2->MappingName = "Orders";
      
      // Change the colors.
      ts2->ForeColor = Color::Yellow;
      ts2->AlternatingBackColor = Color::Blue;
      ts2->BackColor = Color::Blue;
      
      // Create new DataGridColumnStyle objects.
      DataGridColumnStyle^ cOrderDate = gcnew DataGridTextBoxColumn;
      cOrderDate->MappingName = "OrderDate";
      cOrderDate->HeaderText = "Order Date";
      cOrderDate->Width = 100;
      ts2->GridColumnStyles->Add( cOrderDate );
      PropertyDescriptorCollection^ pcol = this->BindingContext[ myDataSet,"Customers.custToOrders" ]->GetItemProperties();
      DataGridColumnStyle^ csOrderAmount = gcnew DataGridTextBoxColumn( pcol[ "OrderAmount" ],"c",true );
      csOrderAmount->MappingName = "OrderAmount";
      csOrderAmount->HeaderText = "Total";
      csOrderAmount->Width = 100;
      ts2->GridColumnStyles->Add( csOrderAmount );
      
      // Add the DataGridTableStyle objects to the collection.
      myDataGrid->TableStyles->Add( ts1 );
      myDataGrid->TableStyles->Add( ts2 );
   }

   // </Snippet1>
};
