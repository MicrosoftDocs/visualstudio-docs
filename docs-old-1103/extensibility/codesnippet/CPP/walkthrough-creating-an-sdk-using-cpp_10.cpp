//
// MainPage.xaml.cpp
// Implementation of the MainPage class.
//

#include "pch.h"
#include "MainPage.xaml.h"

#include <sstream>

#include "NativeMath.h"

using namespace NativeMathSDKSample;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

using namespace NativeMathWRT;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

MainPage::MainPage()
{
    InitializeComponent();
}

/// <summary>
/// Invoked when this page is about to be displayed in a Frame.
/// </summary>
/// <param name="e">Event data that describes how this page was reached.  The Parameter
/// property is typically used to configure the page.</param>
void MainPage::OnNavigatedTo(NavigationEventArgs^ e)
{
}

void NativeMathSDKSample::MainPage::Execute_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
    double iFirstNumber = _wtof(FirstNumber->Text->Data());
    double iSecondNumber = _wtof(SecondNumber->Text->Data());
    double result = 0;

    BasicMathWinMD^ basicMathWinMD = ref new BasicMathWinMD();
    BasicMath basicMath;

    if(add->IsChecked->Value == true)
    {
        result = basicMath.add(iFirstNumber, iSecondNumber);
    }
    else if(subtract->IsChecked->Value == true)
    {
        result = basicMath.subtract(iFirstNumber, iSecondNumber);
    }
    else if(multiplyWRT->IsChecked->Value == true)
    {
        result = basicMathWinMD->multiply(iFirstNumber, iSecondNumber);
    }
    else if (divideWRT->IsChecked->Value == true)
    {
        result = basicMathWinMD->divide(iFirstNumber, iSecondNumber);
    }

    std::wstringstream s;
    s << result;

    resultText->Text = ref new String(s.str().c_str());

}