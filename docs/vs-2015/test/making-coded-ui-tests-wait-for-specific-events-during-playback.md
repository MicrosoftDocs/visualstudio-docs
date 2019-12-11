---
title: "Making Coded UI Tests Wait For Specific Events During Playback | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
ms.assetid: 41981ad6-673e-492e-b739-9863b14157b1
caps.latest.revision: 26
ms.author: jillfra
manager: jillfra
---
# Making Coded UI Tests Wait For Specific Events During Playback
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In a coded UI test playback, you can instruct the test to wait for certain events to occur, such as a window to appear, the progress bar to disappear, and so on. To do this, use the appropriate UITestControl.WaitForControlXXX() method, as described in the following table. For an example of a coded UI test that waits for a control to be enabled using the <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestControl.WaitForControlEnabled%2A> method, see [Walkthrough: Creating, Editing and Maintaining a Coded UI Test](../test/walkthrough-creating-editing-and-maintaining-a-coded-ui-test.md).

 **Requirements**

 Visual Studio Enterprise

> [!TIP]
> You can also add delays before actions using the Coded UI Test Editor. For more information, see [How to: Insert a Delay Before a UI Action Using the Coded UI Test Editor](https://msdn.microsoft.com/library/509f8ef7-e105-4049-b11b-d64549e055b0).

 **UITestControl.WaitForControlXXX() Methods**

 <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestControl.WaitForControlReady%2A>

 Waits for the control to be ready to accept mouse and keyboard input. The engine implicitly calls this API for all actions to wait for the control to be ready before doing any operation. However, in certain esoteric scenario, you may have to do explicit call.

 <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestControl.WaitForControlEnabled%2A>

 Waits for the control to be enabled when the wizard is doing some asynchronous validation of the input by making calls to the server. For example, you can method to wait for the **Next** button of the wizard to be enabled (). For an example of this method, see [Walkthrough: Creating, Editing and Maintaining a Coded UI Test](../test/walkthrough-creating-editing-and-maintaining-a-coded-ui-test.md).

 <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestControl.WaitForControlExist%2A>

 Waits for the control to appear on the UI. For example, you are expecting an error dialog after the application has done the validation of the parameters. The time taken for validation is variable. You can use this method to wait for the error dialog box.

 <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestControl.WaitForControlNotExist%2A>

 Waits for the control to   disappear from the UI. For example, you can wait for the progress bar to disappear.

 <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestControl.WaitForControlPropertyEqual%2A>

 Waits for the specified property of the control to have the given value. For example, you wait for the status text to change to **Done**.

 <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestControl.WaitForControlPropertyNotEqual%2A>

 Waits for the specified property of the control to have the opposite of a specified value. For example, you wait for the edit box to be not read-only, that is, editable.

 <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestControl.WaitForControlCondition%2A>

 Waits for the specified predicate returns to be `true`. This can be used for complex wait operation (like OR conditions) on a given control. For example, you can wait until the status text is **Succeeded** or **Failed** as shown in the following code:

```csharp

// Define the method to evaluate the condition
private static bool IsStatusDone(UITestControl control)
{
    WinText statusText = control as WinText;
    return statusText.DisplayText == "Succeeded" || statusText.DisplayText == "Failed";
}

// In test method, wait till the method evaluates to true
statusText.WaitForControlCondition(IsStatusDone);

```

 <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestControl.WaitForCondition%2A>

 All the previous methods are instance methods of UITestControl. This method is a static method. This method also waits for the specified predicate to be `true` but it can be used for complex wait operation (like OR conditions) on multiple controls. For example, you can wait until the status text is **Succeeded** or until an error message appears, as shown in the following code:

```csharp

// Define the method to evaluate the condition
private static bool IsStatusDoneOrError(UITestControl[] controls)
{
    WinText statusText = controls[0] as WinText;
    WinWindow errorDialog = controls[1] as WinWindow;
    return statusText.DisplayText == "Succeeded" || errorDialog.Exists;
}

// In test method, wait till the method evaluates to true
UITestControl.WaitForCondition<UITestControl[]>(new UITestControl[] { statusText, errorDialog }, IsStatusDoneOrError);

```

 All these methods have following behavior:

 The methods return true if the wait is successful and false if the wait failed.

 The implicit timeout for the wait operation is specified by <xref:Microsoft.VisualStudio.TestTools.UITesting.PlaybackSettings.WaitForReadyTimeout%2A> property. The default value of this property is 60000 milliseconds (one minute).

 The methods have an overload to take explicit timeout in milliseconds. However, when the wait operation results in an implicit search for the control or, when the application is busy, the actual wait time could be more than the timeout specified.

 The previous functions are powerful and flexible and should satisfy almost all conditions. However, in case these methods do not satisfy your needs and you need to code either a <xref:Microsoft.VisualStudio.TestTools.UITesting.Playback.Wait%2A>, or a <xref:System.Threading.Thread.Sleep%2A> in your code, it is recommended that you use the Playback.Wait() instead of Thread.Sleep() API. The reasons for this are:

 You can use the  <xref:Microsoft.VisualStudio.TestTools.UITesting.PlaybackSettings.ThinkTimeMultiplier%2A>property to modify the duration of sleep. By default, this variable is 1 but you can increase or decrease it to change the wait time all over the code. For example, if you are specifically testing over slow network, or some other slow performance case, you can change this variable at one place (or even in the configuration file) to 1.5 to add 50% extra wait at all places.

 Playback.Wait() internally calls Thread.Sleep() (after above computation) in smaller chunks in a for-loop while checking for user cancel\break operation. In other words, Playback.Wait() lets you cancel playback before the end of the wait whereas sleep might not or throw exception.

> [!TIP]
> The Coded UI Test Editor lets you easily modify your coded UI tests. Using the Coded UI Test Editor, you can locate, view, and edit your test methods. You can also edit UI actions and their associated controls in the UI control map. For more information, see [Editing Coded UI Tests Using the Coded UI Test Editor](../test/editing-coded-ui-tests-using-the-coded-ui-test-editor.md).

 **Guidance**

 For additional information, see [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 5: Automating System Tests](https://go.microsoft.com/fwlink/?LinkID=255196)

## See Also
 [Use UI Automation To Test Your Code](../test/use-ui-automation-to-test-your-code.md)
 [Creating Coded UI Tests](../test/use-ui-automation-to-test-your-code.md#VerifyingCodeUsingCUITCreate)
 [Walkthrough: Creating, Editing and Maintaining a Coded UI Test](../test/walkthrough-creating-editing-and-maintaining-a-coded-ui-test.md)
 [Anatomy of a Coded UI Test](../test/anatomy-of-a-coded-ui-test.md)
 [Supported Configurations and Platforms for Coded UI Tests and Action Recordings](../test/supported-configurations-and-platforms-for-coded-ui-tests-and-action-recordings.md)
 [How to: Insert a Delay Before a UI Action Using the Coded UI Test Editor](https://msdn.microsoft.com/library/509f8ef7-e105-4049-b11b-d64549e055b0)
