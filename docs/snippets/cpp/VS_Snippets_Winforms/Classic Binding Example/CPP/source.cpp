

// <Snippet1>
#using <system.dll>
#using <system.data.dll>
#using <system.drawing.dll>
#using <system.windows.forms.dll>
#using <system.xml.dll>

using namespace System;
using namespace System::Data;
using namespace System::Drawing;
using namespace System::Globalization;
using namespace System::Windows::Forms;

#define null 0L
public ref class Form1: public Form
{
private:
   System::ComponentModel::Container^ components;
   Button^ button1;
   Button^ button2;
   Button^ button3;
   Button^ button4;
   TextBox^ text1;
   TextBox^ text2;
   TextBox^ text3;
   BindingManagerBase^ bmCustomers;
   BindingManagerBase^ bmOrders;
   DataSet^ ds;
   DateTimePicker^ DateTimePicker1;

public:
   Form1()
   {
      // Required for Windows Form Designer support.
      InitializeComponent();

      // Call SetUp to bind the controls.
      SetUp();
   }

private:
   void InitializeComponent()
   {
      // Create the form and its controls.
      this->components = gcnew System::ComponentModel::Container;
      this->button1 = gcnew Button;
      this->button2 = gcnew Button;
      this->button3 = gcnew Button;
      this->button4 = gcnew Button;
      this->text1 = gcnew TextBox;
      this->text2 = gcnew TextBox;
      this->text3 = gcnew TextBox;
      this->DateTimePicker1 = gcnew DateTimePicker;
      this->Text =  "Binding Sample";
      this->ClientSize = System::Drawing::Size( 450, 200 );
      button1->Location = System::Drawing::Point( 24, 16 );
      button1->Size = System::Drawing::Size( 64, 24 );
      button1->Text =  "<";
      button1->Click += gcnew System::EventHandler( this, &Form1::button1_Click );
      button2->Location = System::Drawing::Point( 90, 16 );
      button2->Size = System::Drawing::Size( 64, 24 );
      button2->Text =  ">";
      button2->Click += gcnew System::EventHandler( this, &Form1::button2_Click );
      button3->Location = System::Drawing::Point( 90, 100 );
      button3->Size = System::Drawing::Size( 64, 24 );
      button3->Text =  "<";
      button3->Click += gcnew System::EventHandler( this, &Form1::button3_Click );
      button4->Location = System::Drawing::Point( 150, 100 );
      button4->Size = System::Drawing::Size( 64, 24 );
      button4->Text =  ">";
      button4->Click += gcnew System::EventHandler( this, &Form1::button4_Click );
      text1->Location = System::Drawing::Point( 24, 50 );
      text1->Size = System::Drawing::Size( 150, 24 );
      text2->Location = System::Drawing::Point( 190, 50 );
      text2->Size = System::Drawing::Size( 150, 24 );
      text3->Location = System::Drawing::Point( 290, 150 );
      text3->Size = System::Drawing::Size( 150, 24 );
      DateTimePicker1->Location = System::Drawing::Point( 90, 150 );
      DateTimePicker1->Size = System::Drawing::Size( 200, 800 );
      this->Controls->Add( button1 );
      this->Controls->Add( button2 );
      this->Controls->Add( button3 );
      this->Controls->Add( button4 );
      this->Controls->Add( text1 );
      this->Controls->Add( text2 );
      this->Controls->Add( text3 );
      this->Controls->Add( DateTimePicker1 );
   }

public:
   ~Form1()
   {
      if ( components != nullptr )
      {
         delete components;
      }
   }

private:
   void SetUp()
   {
      // Create a DataSet with two tables and one relation.
      MakeDataSet();
      BindControls();
   }

protected:
   void BindControls()
   {
      /* Create two Binding objects for the first two TextBox 
              controls. The data-bound property for both controls 
              is the Text property. The data source is a DataSet 
              (ds). The data member is the 
              "TableName.ColumnName" string. */
      text1->DataBindings->Add( gcnew Binding( "Text",ds,"customers.custName" ) );
      text2->DataBindings->Add( gcnew Binding( "Text",ds,"customers.custID" ) );

      /* Bind the DateTimePicker control by adding a new Binding. 
              The data member of the DateTimePicker is a 
              TableName.RelationName.ColumnName string. */
      DateTimePicker1->DataBindings->Add( gcnew Binding( "Value",ds,"customers.CustToOrders.OrderDate" ) );

      /* Add event delegates for the Parse and Format events to a 
              new Binding object, and add the object to the third 
              TextBox control's BindingsCollection. The delegates 
              must be added before adding the Binding to the 
              collection; otherwise, no formatting occurs until 
              the Current object of the BindingManagerBase for 
              the data source changes. */
      Binding^ b = gcnew Binding( "Text",ds,"customers.custToOrders.OrderAmount" );
      b->Parse += gcnew ConvertEventHandler( this, &Form1::CurrencyStringToDecimal );
      b->Format += gcnew ConvertEventHandler( this, &Form1::DecimalToCurrencyString );
      text3->DataBindings->Add( b );

      // Get the BindingManagerBase for the Customers table. 
      bmCustomers = this->BindingContext[ ds, "Customers" ];

      /* Get the BindingManagerBase for the Orders table using the 
              RelationName. */
      bmOrders = this->BindingContext[ ds, "customers.CustToOrders" ];
   }

private:
   void DecimalToCurrencyString( Object^ /*sender*/, ConvertEventArgs^ cevent )
   {
      /* This method is the Format event handler. Whenever the 
              control displays a new value, the value is converted from 
              its native Decimal type to a string. The ToString method 
              then formats the value as a Currency, by using the 
              formatting character "c". */
      // The application can only convert to string type. 
      if ( cevent->DesiredType != String::typeid )
            return;

      cevent->Value = (dynamic_cast<Decimal^>(cevent->Value))->ToString( "c" );
   }

   void CurrencyStringToDecimal( Object^ /*sender*/, ConvertEventArgs^ cevent )
   {
      /* This method is the Parse event handler. The Parse event 
              occurs whenever the displayed value changes. The static 
              ToDecimal method of the Convert class converts the 
              value back to its native Decimal type. */
      // Can only convert to Decimal type.
      if ( cevent->DesiredType != Decimal::typeid )
            return;

      cevent->Value = Decimal::Parse( cevent->Value->ToString(), NumberStyles::Currency, nullptr );
      
      /* To see that no precision is lost, print the unformatted 
              value. For example, changing a value to "10.0001" 
              causes the control to display "10.00", but the 
              unformatted value remains "10.0001". */
      Console::WriteLine( cevent->Value );
   }

private:
   void button1_Click( Object^ /*sender*/, System::EventArgs^ /*e*/ )
   {
      // Go to the previous item in the Customer list.
      bmCustomers->Position -= 1;
   }

   void button2_Click( Object^ /*sender*/, System::EventArgs^ /*e*/ )
   {
      // Go to the next item in the Customer list.
      bmCustomers->Position += 1;
   }

   void button3_Click( Object^ /*sender*/, System::EventArgs^ /*e*/ )
   {
      
      // Go to the previous item in the Orders list.
      bmOrders->Position = bmOrders->Position - 1;
   }

   void button4_Click( Object^ /*sender*/, System::EventArgs^ /*e*/ )
   {
      
      // Go to the next item in the Orders list.
      bmOrders->Position = bmOrders->Position + 1;
   }

private:

   // Create a DataSet with two tables and populate it.
   void MakeDataSet()
   {
      // Create a DataSet.
      ds = gcnew DataSet( "myDataSet" );

      // Create two DataTables.
      DataTable^ tCust = gcnew DataTable( "Customers" );
      DataTable^ tOrders = gcnew DataTable( "Orders" );

      // Create two columns, and add them to the first table.
      DataColumn^ cCustID = gcnew DataColumn( "CustID",Int32::typeid );
      DataColumn^ cCustName = gcnew DataColumn( "CustName" );
      tCust->Columns->Add( cCustID );
      tCust->Columns->Add( cCustName );

      // Create three columns, and add them to the second table.
      DataColumn^ cID = gcnew DataColumn( "CustID",Int32::typeid );
      DataColumn^ cOrderDate = gcnew DataColumn( "orderDate",DateTime::typeid );
      DataColumn^ cOrderAmount = gcnew DataColumn( "OrderAmount",Decimal::typeid );
      tOrders->Columns->Add( cOrderAmount );
      tOrders->Columns->Add( cID );
      tOrders->Columns->Add( cOrderDate );

      // Add the tables to the DataSet.
      ds->Tables->Add( tCust );
      ds->Tables->Add( tOrders );

      // Create a DataRelation, and add it to the DataSet.
      DataRelation^ dr = gcnew DataRelation( "custToOrders",cCustID,cID );
      ds->Relations->Add( dr );
      
      /* Populate the tables. For each customer and order, 
              create two DataRow variables. */
      DataRow^ newRow1; // = new DataRow();

      DataRow^ newRow2; // = new DataRow();

      // Create three customers in the Customers Table.
      for ( int i = 1; i < 4; i++ )
      {
         newRow1 = tCust->NewRow();
         newRow1[ "custID" ] = i;
         
         // Add the row to the Customers table.
         tCust->Rows->Add( newRow1 );

      }
      tCust->Rows[ 0 ][ "custName" ] = "Alpha";
      tCust->Rows[ 1 ][ "custName" ] = "Beta";
      tCust->Rows[ 2 ][ "custName" ] = "Omega";
      
      // For each customer, create five rows in the Orders table.
      for ( int i = 1; i < 4; i++ )
      {
         for ( int j = 1; j < 6; j++ )
         {
            newRow2 = tOrders->NewRow();
            newRow2[ "CustID" ] = i;
            newRow2[ "orderDate" ] = System::DateTime( 2001, i, j * 2 );
            newRow2[ "OrderAmount" ] = i * 10 + j * .1;
            
            // Add the row to the Orders table.
            tOrders->Rows->Add( newRow2 );
         }
      }
   }
};

int main()
{
   Application::Run( gcnew Form1 );
}
// </Snippet1>
