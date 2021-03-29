#using <System.Data.dll>
#using <System.Windows.Forms.dll>
#using <System.dll>
#using <System.Drawing.dll>

using namespace System;
using namespace System::Drawing;
using namespace System::Collections;
using namespace System::ComponentModel;
using namespace System::Windows::Forms;
using namespace System::Data;

/// <summary>
/// Summary description for Form1.
/// </summary>
public ref class Form1: public System::Windows::Forms::Form
{
private:
   System::Windows::Forms::TextBox^ textBox1;

   /// <summary>
   /// Required designer variable.
   /// </summary>
   System::ComponentModel::Container^ components;

public:
   Form1()
   {

      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();

      //
      // TODO: Add any constructor code after InitializeComponent call
      //
   }


public:

   /// <summary>
   /// Clean up any resources being used.
   /// </summary>
   ~Form1()
   {
      if ( components != nullptr )
      {
         delete components;
      }
   }

private:

   /// <summary>
   /// Required method for Designer support - do not modify
   /// the contents of this method with the code editor.
   /// </summary>
   void InitializeComponent()
   {
      this->textBox1 = gcnew System::Windows::Forms::TextBox;
      this->SuspendLayout();

      // 
      // textBox1
      // 
      this->textBox1->Multiline = true;
      this->textBox1->Name = "textBox1";
      this->textBox1->TabIndex = 0;
      this->textBox1->Text = "textBox1";

      // 
      // Form1
      // 
      this->ClientSize = System::Drawing::Size( 488, 301 );
      array<System::Windows::Forms::Control^>^temp1 = {this->textBox1};
      this->Controls->AddRange( temp1 );
      this->Name = "Form1";
      this->Text = "Form1";
      this->Load += gcnew System::EventHandler( this, &Form1::Form1_Load );
      this->ResumeLayout( false );
   }

   //<snippet1>
private:
   void Form1_Load( Object^ /*sender*/, System::EventArgs^ /*e*/ )
   {
      textBox1->Text = "changed";
      System::ComponentModel::TypeDescriptor::Refreshed += gcnew System::ComponentModel::RefreshEventHandler( OnRefresh );
      System::ComponentModel::TypeDescriptor::GetProperties( textBox1 );
      System::ComponentModel::TypeDescriptor::Refresh( textBox1 );
   }

protected:
   static void OnRefresh( System::ComponentModel::RefreshEventArgs^ e )
   {
      Console::WriteLine( e->ComponentChanged );
   }
   //</snippet1>
};

ref class Control: public Component
{
private:
   int position;

public:

   property int Position 
   {
      int get()
      {
         return position;
      }

      void set( int value )
      {
         if (  !position.Equals( value ) )
         {
            position = value;
            
            //RaisePropertyChangedEvent(position);
         }
      }
   }
};

/// <summary>
/// The main entry point for the application.
/// </summary>

[STAThread]
int main()
{
   Application::Run( gcnew Form1 );
}
