

#using <System.dll>
#using <System.Drawing.dll>
#using <System.Windows.Forms.dll>

// <snippet1>
using namespace System::Drawing;
using namespace System::Windows::Forms;
public ref class Form1: public Form
{
private:
   TabControl^ tabControl1;
   TabPage^ tabPage1;
   TabPage^ tabPage2;
   TabPage^ tabPage3;

public:
   Form1()
   {
      this->tabControl1 = gcnew TabControl;
      array<System::String^>^tabText = {"tabPage1","tabPage2","tabPage3"};
      this->tabPage1 = gcnew TabPage( tabText[ 0 ]->ToString() );
      this->tabPage2 = gcnew TabPage( tabText[ 1 ]->ToString() );
      this->tabPage3 = gcnew TabPage( tabText[ 2 ]->ToString() );
      
      // Populates the tabControl1 with two tab pages.
      array<TabPage^>^tabPages = {tabPage1,tabPage2};
      this->tabControl1->TabPages->AddRange( tabPages );
      
      // Checks the tabControl1 controls collection for tabPage3.
      // Adds tabPage3 to tabControl1 if it is not in the collection.
      if ( tabControl1->TabPages->Contains( tabPage3 ) == false )
            this->tabControl1->TabPages->Add( tabPage3 );

      this->tabControl1->Location = Point(25,25);
      this->tabControl1->Size = System::Drawing::Size( 250, 250 );
      this->ClientSize = System::Drawing::Size( 300, 300 );
      this->Controls->Add( tabControl1 );
   }

};

int main()
{
   Application::Run( gcnew Form1 );
}

// </snippet1>
