// This example demonstrates using the Control.Region property by 
// creating a round button.  

#using <System.Drawing.dll>
#using <System.dll>
#using <System.Windows.Forms.dll>

using namespace System;
using namespace System::Windows::Forms;
using namespace System::Drawing::Drawing2D;

public ref class Form1: public System::Windows::Forms::Form
{
public:
   Form1() : Form()
   {
      InitializeComponent();
   }

internal:
   System::Windows::Forms::Button^ roundButton;

private:
   void InitializeComponent()
   {
      this->roundButton = gcnew System::Windows::Forms::Button;
      this->SuspendLayout();
      this->roundButton->BackColor = System::Drawing::Color::PowderBlue;
      this->roundButton->Location = System::Drawing::Point( 88, 72 );
      this->roundButton->Name = "RoundButton";
      this->roundButton->Size = System::Drawing::Size( 112, 112 );
      this->roundButton->TabIndex = 0;
      this->roundButton->Text = "I'm round";
      this->ClientSize = System::Drawing::Size( 292, 266 );
      this->Controls->Add( this->roundButton );
      this->Name = "Form1";
      this->Text = "Form1";
      this->ResumeLayout( false );
      this->roundButton->Paint += gcnew PaintEventHandler(
         this, &Form1::roundButton_Paint );
   }

   //<snippet1>
private:
   // This method will change the square button to a circular button by 
   // creating a new circle-shaped GraphicsPath object and setting it 
   // to the RoundButton objects region.
   void roundButton_Paint( Object^ sender,
      System::Windows::Forms::PaintEventArgs^ e )
   {
      System::Drawing::Drawing2D::GraphicsPath^ buttonPath =
         gcnew System::Drawing::Drawing2D::GraphicsPath;
      
      // Set a new rectangle to the same size as the button's 
      // ClientRectangle property.
      System::Drawing::Rectangle newRectangle = roundButton->ClientRectangle;
      
      // Decrease the size of the rectangle.
      newRectangle.Inflate(  -10, -10 );
      
      // Draw the button's border.
      e->Graphics->DrawEllipse( System::Drawing::Pens::Black, newRectangle );
      
      // Increase the size of the rectangle to include the border.
      newRectangle.Inflate( 1, 1 );
      
      // Create a circle within the new rectangle.
      buttonPath->AddEllipse( newRectangle );
      
      // Set the button's Region property to the newly created 
      // circle region.
      roundButton->Region = gcnew System::Drawing::Region( buttonPath );
   }
   //</snippet1>
};

[System::STAThreadAttribute]
int main()
{
   Application::Run( gcnew Form1 );
}
