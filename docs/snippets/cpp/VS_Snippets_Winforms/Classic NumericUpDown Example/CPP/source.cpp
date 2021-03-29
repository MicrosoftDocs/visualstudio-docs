#using <system.dll>
#using <System.Drawing.dll>
#using <system.data.dll>
#using <system.windows.forms.dll>

using namespace System;
using namespace System::Data;
using namespace System::ComponentModel;
using namespace System::Windows::Forms;

public ref class Form1: public Form
{
protected:
   NumericUpDown^ numericUpDown1;

   // <Snippet1>
public:
   void InstantiateMyNumericUpDown()
   {
      // Create and initialize a NumericUpDown control.
      numericUpDown1 = gcnew NumericUpDown;
      
      // Dock the control to the top of the form.
      numericUpDown1->Dock = System::Windows::Forms::DockStyle::Top;
      
      // Set the Minimum, Maximum, and initial Value.
      numericUpDown1->Value = 5;
      numericUpDown1->Maximum = 2500;
      numericUpDown1->Minimum = -100;
      
      // Add the NumericUpDown to the Form.
      Controls->Add( numericUpDown1 );
   }

private:
   // Check box to toggle decimal places to be displayed.
   void checkBox1_Click( Object^ sender, EventArgs^ e )
   {
      /* If DecimalPlaces is greater than 0, set them to 0 and round the 
         current Value; otherwise, set DecimalPlaces to 2 and change the 
         Increment to 0.25. */
      if ( numericUpDown1->DecimalPlaces > 0 )
      {
         numericUpDown1->DecimalPlaces = 0;
         numericUpDown1->Value = Decimal::Round( numericUpDown1->Value, 0 );
      }
      else
      {
         numericUpDown1->DecimalPlaces = 2;
         numericUpDown1->Increment = Decimal(0.25);
      }
   }

   // Check box to toggle thousands separators to be displayed.
   void checkBox2_Click( Object^ sender, EventArgs^ e )
   {
      /* If ThousandsSeparator is true, set it to false; 
         otherwise, set it to true. */
      if ( numericUpDown1->ThousandsSeparator )
      {
         numericUpDown1->ThousandsSeparator = false;
      }
      else
      {
         numericUpDown1->ThousandsSeparator = true;
      }
   }

   // Check box to toggle hexadecimal to be displayed.
   void checkBox3_Click( Object^ sender, EventArgs^ e )
   {
      /* If Hexadecimal is true, set it to false; 
         otherwise, set it to true. */
      if ( numericUpDown1->Hexadecimal )
      {
         numericUpDown1->Hexadecimal = false;
      }
      else
      {
         numericUpDown1->Hexadecimal = true;
      }
   }
   // </Snippet1>
};
