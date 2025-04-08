---
title: "Write a visualizer in Visual Basic"
description: Follow a walkthrough to create a simple visualizer in Visual Basic. You also create a test harness to test your visualizer.
ms.date: "05/27/2020"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "visualizers, writing"
  - "walkthroughs [Visual Studio], visualizers"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Walkthrough: Writing a Visualizer in Visual Basic

> [!IMPORTANT]
> Starting with Visual Studio 2022 version 17.9, visualizers can now be written in .NET 6.0+ that run out-of-process using the new VisualStudio.Extensibility model. We encourage visualizer authors to reference the new documentation at [Create Visual Studio debugger visualizers](../extensibility/visualstudio.extensibility/debugger-visualizer/debugger-visualizers.md) unless they want to support older versions of Visual Studio or want to ship their custom visualizers as part of a library DLL.

This walkthrough shows how to write a simple visualizer by using Visual Basic. The visualizer you'll create in this walkthrough displays the contents of a string using a Windows Forms message box. This simple string visualizer is a basic example to show how you can create visualizers for other data types more applicable to your projects.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help, depending on your active settings or edition. To change your settings, go to the **Tools** menu and choose **Import and Export** . For more information, see [Reset settings](../ide/personalizing-the-visual-studio-ide.md#reset-all-settings).

Visualizer code must be placed in a DLL that will be read by the debugger. The first step is to create a class library project for the DLL.

## Create and Prepare a Class Library Project

### To create a class library project

1. Create a new class library project.

    ::: moniker range=">=vs-2022"
    Press **Esc** to close the start window. Type **Ctrl + Q** to open the search box, type **class library**, and then select the Visual Basic **Class Library (.NET Framework)**.
    ::: moniker-end

    ::: moniker range="vs-2019"
    Press **Esc** to close the start window. Type **Ctrl + Q** to open the search box, type **visual basic**, choose **Templates**, then choose **Create a new Class Library (.NET Framework)**.
    ::: moniker-end

2. Type an appropriate name for the class library, such as `MyFirstVisualizer`, and then click **Create** or **OK**.

   When you have created the class library, you must add a reference to Microsoft.VisualStudio.DebuggerVisualizers.DLL, so that you can use the classes defined there. First, however, you give your project a meaningful name.

### To rename Class1.vb and add Microsoft.VisualStudio.DebuggerVisualizers

1. In **Solution Explorer**, right-click **Class1.vb**, and on the shortcut menu, click **Rename**.

2. Change the name from Class1.vb to something meaningful, such as DebuggerSide.vb.

   > [!NOTE]
   > Visual Studio automatically changes the class declaration in DebuggerSide.vb to match the new file name.

3. In **Solution Explorer**, right-click **My First Visualizer**, and on the shortcut menu, click **Add Reference**.

4. In the **Add Reference** dialog box, on the **Browse** tab, select **Browse** and find the Microsoft.VisualStudio.DebuggerVisualizers.DLL.

    You can find the DLL in *\<Visual Studio Install Directory>\Common7\IDE\PublicAssemblies* subdirectory of Visual Studio's installation directory.

5. Click **OK**.

6. In DebuggerSide.vb, add the following statement to the `Imports` statements:

   ```vb
   Imports Microsoft.VisualStudio.DebuggerVisualizers
   ```

## Add the Debugger-side Code
 Now, you're ready to create the debugger-side code. This is the code that runs within the debugger to display the information that you want to visualize. First, you have to change the declaration of the `DebuggerSide` object so that it inherits from the base class `DialogDebuggerVisualizer`.

### To inherit from DialogDebuggerVisualizer

1. In DebuggerSide.vb, go to the following line of code:

   ```vb
   Public Class DebuggerSide
   ```

2. Edit the code so that it looks like this:

   ```vb
   Public Class DebuggerSide
   Inherits DialogDebuggerVisualizer
   ```

   > [!NOTE]
   > DialogDebuggerVisualizer expects a `FormatterPolicy` argument in its constructor. However, due to the security issues described in [Special debugger side considerations for .NET 5.0+](./create-custom-visualizers-of-data.md#special-debugger-side-considerations-for-net-50), starting with Visual Studio 2022 version 17.11, visualizers won't be able to specify the `Legacy` formatter policy.

   `DialogDebuggerVisualizer` has one abstract method, `Show`, that you must override.

### To override the DialogDebuggerVisualizer.Show method

- In `public class DebuggerSide`, add the following method:

  ```vb
  Protected Overrides Sub Show(ByVal windowService As Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService, ByVal objectProvider As Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider)

      End Sub
  ```

  The `Show` method contains the code that actually creates the visualizer dialog box, or other user interface, and displays the information that has been passed to the visualizer from the debugger. You must add the code that creates the dialog box and displays the information. In this walkthrough, you'll do this using a Windows Forms message box. First, you must add a reference and `Imports` statement for <xref:System.Windows.Forms>.

### To add System.Windows.Forms

1. In **Solution Explorer**, right-click **References**, and on the shortcut menu, click **Add Reference**.

2. In the **Add Reference** dialog box, on the **Browse** tab, select **Browse**, and find the System.Windows.Forms.DLL.

    You can find the DLL in *C:\Windows\Microsoft.NET\Framework\v4.0.30319*.

3. Click **OK**.

4. In DebuggerSide.cs, add the following statement to the `Imports` statements:

    ```vb
    Imports System.Windows.Forms
    ```

## Create Your Visualizer's User Interface
 Now you'll add some code to create and show the user interface for your visualizer. Because this is your first visualizer, you'll keep the user interface simple and use a Message Box.

### To show the visualizer output in a dialog box

1. In the `Show` method, add the following line of code:

    ```vb
    MessageBox.Show(objectProvider.GetObject().ToString())
    ```

     This example code doesn't include error handling. You should include error handling in a real visualizer, or any other kind of application.

2. On the **Build** menu, click **Build MyFirstVisualizer**. The project should build successfully. Correct any build errors before continuing.

## Add the Necessary Attribute
 That is the end of the debugger-side code. There's one more step, however: the attribute that tells the debuggee side which collection of classes comprises the visualizer.

### To add the type to visualize for the debuggee-side code

In the debugger-side code, you specify the type to visualize (the object source) for the debuggee using the <xref:System.Diagnostics.DebuggerVisualizerAttribute> attribute. The `Target` property sets the type to visualize.

1. Add the following attribute code to DebuggerSide.vb, after the `Imports` statements but before `namespace MyFirstVisualizer`:

    ```vb
    <Assembly: System.Diagnostics.DebuggerVisualizer(GetType(MyFirstVisualizer.DebuggerSide), GetType(VisualizerObjectSource), Target:=GetType(System.String), Description:="My First Visualizer")>
    ```

2. On the **Build** menu, click **Build MyFirstVisualizer**. The project should build successfully. Correct any build errors before continuing.

## Create a Test Harness
 At this point, your first visualizer is finished. If you have followed the steps correctly, you can build the visualizer and install it into Visual Studio. Before you install a visualizer into Visual Studio, however, you should test it to make sure that it runs correctly. you'll now create a test harness to run the visualizer without installing it into Visual Studio.

### To add a test method to show the visualizer

1. Add the following method to class `public DebuggerSide`:

   ```vb
   Shared Public Sub TestShowVisualizer(ByVal objectToVisualize As Object)
       Dim visualizerHost As New VisualizerDevelopmentHost(objectToVisualize, GetType(DebuggerSide))
   visualizerHost.ShowVisualizer()
   End Sub
   ```

2. On the **Build** menu, click **Build MyFirstVisualizer**. The project should build successfully. Correct any build errors before continuing.

   Next, you must create an executable project to call your visualizer DLL. For simplicity, use a console application project.

### To add a console application project to the solution

1. In Solution Explorer, right-click the solution, choose **Add**, and then click **New Project**.

    In the Search box, type **visual basic**, choose **Templates**, then choose **Create a new Console App (.NET Framework)**. In the dialog box that appears, choose **Create**.

2. Type an appropriate name for the class library, such as `MyTestConsole`, and then click **Create** or **OK**.

   Now, you must add the necessary references so MyTestConsole can call MyFirstVisualizer.

### To add necessary references to MyTestConsole

1. In **Solution Explorer**, right-click **MyTestConsole**, and on the shortcut menu, click **Add Reference**.

2. In the **Add Reference** dialog box, on the **Browse** tab, click Microsoft.VisualStudio.DebuggerVisualizers.

3. Click **OK**.

4. Right-click **MyTestConsole**, and then click **Add Reference** again.

5. In the **Add Reference** dialog box, click the **Projects** tab, and then select MyFirstVisualizer.

6. Click **OK**.

## Finish Your Test Harness and Test Your Visualizer
 Now, you'll add the code to finish the test harness.

### To add code to MyTestConsole

1. In **Solution Explorer**, right-click **Program.vb**, and on the shortcut menu, click **Rename**.

2. Edit the name from Module1.vb to something appropriate, such as **TestConsole.vb**.

    Notice that Visual Studio automatically changes the class declaration in TestConsole.vb to match the new file name.

3. In TestConsole. vb, add the following `Imports` statement:

   ```vb
   Imports MyFirstVisualizer
   ```

4. In method `Main`, add the following code:

   ```vb
   Dim myString As String = "Hello, World"
   DebuggerSide.TestShowVisualizer(myString)
   ```

   Now you're ready to test your first visualizer.

### To test the visualizer

1. In **Solution Explorer**, right-click **MyTestConsole**, and on the shortcut menu, click **Set as Startup Project**.

2. On the **Debug** menu, click **Start**.

    The console application starts. The visualizer appears and displays the string "Hello, World."

   Congratulations. You have just built and tested your first visualizer.

   If you want to use your visualizer in Visual Studio rather than just calling it from the test harness, you have to install it. For more information, see [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md).

## Related content

- [Visualizer Architecture](../debugger/visualizer-architecture.md)
- [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md)
- [Create Custom Visualizers](../debugger/create-custom-visualizers-of-data.md)