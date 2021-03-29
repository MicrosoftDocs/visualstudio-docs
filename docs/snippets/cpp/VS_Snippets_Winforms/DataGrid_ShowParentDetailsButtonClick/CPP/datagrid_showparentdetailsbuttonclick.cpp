/*
System::Windows::Forms::DataGrid::ShowParentDetailsButtonClick

The following program demonstrates the 'ShowParentDetailsButtonClick'
event of 'DataGrid' class. On the click of S"ParentDetailsButton" button in the
Datagrid, a message is displayed.
*/

#using <System.Xml.dll>
#using <System.dll>
#using <System.Drawing.dll>
#using <System.Windows.Forms.dll>
#using <System.Data.dll>

using namespace System;
using namespace System::Data;
using namespace System::Drawing;
using namespace System::Windows::Forms;

public ref class MyForm: public Form
{
private:
   System::ComponentModel::Container^ components;
   DataGrid^ myDataGrid;
   DataSet^ myDataSet;

public:
   MyForm()
   {
      components = nullptr;
      InitializeComponent();
      SetUp();
   }

public:

   // Clean up any resources being used.
   ~MyForm()
   {
      if ( components != nullptr )
      {
         delete components;
      }
   }

private:
   void InitializeComponent()
   {
      // Create the form and its controls.
      this->myDataGrid = gcnew DataGrid;
      this->ClientSize = System::Drawing::Size( 292, 300 );
      this->Name = "DataGridForm";
      this->Text = "Testing DataGrid Events";
      this->MaximizeBox = false;
      myDataGrid->Location = Point(20,70);
      myDataGrid->Size = System::Drawing::Size( 250, 170 );
      myDataGrid->CaptionText = "MS DataGrid Control";
      myDataGrid->ReadOnly = false;

      // Call the method that instantiate the Event Handlers.
      CallShowParentDetailsButtonClick();
      this->Controls->Add( myDataGrid );
   }

   void SetUp()
   {
      // Create a DataSet with two tables and one relation.
      MakeDataSet();

      // Bind the DataGrid to the DataSet.
      myDataGrid->SetDataBinding( myDataSet, "Person" );
   }

   // Create a DataSet with two tables and populate it.
   void MakeDataSet()
   {
      myDataSet = gcnew DataSet( "myDataSet" );
      DataTable^ personTable = gcnew DataTable( "Person" );
      DataTable^ detailTable = gcnew DataTable( "Detail" );

      // Create two columns, and add them to the Person table.
      DataColumn^ personID = gcnew DataColumn( "SSN",int::typeid );
      DataColumn^ personName = gcnew DataColumn( "PersonName" );
      personTable->Columns->Add( personID );
      personTable->Columns->Add( personName );

      // Create three columns, and add them to the Detail table.
      DataColumn^ detailID = gcnew DataColumn( "SSN",int::typeid );
      DataColumn^ detailPhone = gcnew DataColumn( "Phone" );
      detailTable->Columns->Add( detailID );
      detailTable->Columns->Add( detailPhone );

      // Add the tables to the DataSet.
      myDataSet->Tables->Add( personTable );
      myDataSet->Tables->Add( detailTable );

      // For each person create a DataRow variable.
      DataRow^ newRow1;
      DataRow^ newRow2;

      // Create a DataRelation, and add it to the DataSet.
      DataRelation^ myDataRelation = gcnew DataRelation( "PersonDetail",personID,detailID );
      myDataSet->Relations->Add( myDataRelation );

      // Create persons in the 'Person' Table.
      for ( int i = 1; i < 5; i++ )
      {
         newRow1 = personTable->NewRow();
         newRow1[ "SSN" ] = i;

         // Add the row to the 'Person' table.
         personTable->Rows->Add( newRow1 );

      }

      // Give each person a distinct name.
      personTable->Rows[ 0 ][ "PersonName" ] = "Robert";
      personTable->Rows[ 1 ][ "PersonName" ] = "Michael";
      personTable->Rows[ 2 ][ "PersonName" ] = "John";
      personTable->Rows[ 3 ][ "PersonName" ] = "Walter";

      // For each person, create a detail row in 'Detail' table.
      for ( int i = 0; i < 4; i++ )
      {
         newRow2 = detailTable->NewRow();
         newRow2[ "SSN" ] = personTable->Rows[ i ][ "SSN" ];
         newRow2[ "Phone" ] = 1000 + i;

         // Add the row to the 'Detail' table.
         detailTable->Rows->Add( newRow2 );

      }
   }

   // <Snippet1>
private:
   void CallShowParentDetailsButtonClick()
   {
      myDataGrid->ShowParentDetailsButtonClick += gcnew EventHandler( this, &MyForm::DataGridShowParentDetailsButtonClick_Clicked );
   }

   // raise the event when ParentDetailsButton is clicked.
   void DataGridShowParentDetailsButtonClick_Clicked( Object^ /*sender*/, EventArgs^ /*e*/ )
   {
      String^ myMessage = "ShowParentDetailsButtonClick event raised";

      // Show the message when event is raised.
      MessageBox::Show( myMessage, "ShowParentDetailsButtonClick information" );
   }
   // </Snippet1>
};

int main()
{
   Application::Run( gcnew MyForm );
}
