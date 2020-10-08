---
title: "Walkthrough: Writing a Visualizer in Visual Basic | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "visualizers, writing"
  - "walkthroughs [Visual Studio], visualizers"
ms.assetid: c93bf5a1-3e5e-422f-894e-bd72c9bc1b57
caps.latest.revision: 25
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Walkthrough: Writing a Visualizer in Visual Basic
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This walkthrough shows how to write a simple visualizer by using [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]. The visualizer you will create in this walkthrough displays the contents of a string using a Windows Forms message box. This simple string visualizer is a basic example to show how you can create visualizers for other data types more applicable to your projects.  
  
> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help, depending on your active settings or edition. To change your settings, go to the **Tools** menu and choose **Import and Export** . For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
 Visualizer code must be placed in a DLL that will be read by the debugger. The first step is to create a class library project for the DLL.  
  
## Create and Prepare a Class Library Project  
  
#### To create a class library project  
  
1. On the **File** menu, choose **New** and click **New Project**.  
  
2. In the **New Project** dialog box, under **Project Type**s, click **Visual Basic**.  
  
3. In the **Templates** box, click **Class Library**.  
  
4. In the **Name** box, type an appropriate name for the class library, such as **MyFirstVisualizer**.  
  
5. Click **OK**.  
  
   When you have created the class library, you must add a reference to Microsoft.VisualStudio.DebuggerVisualizers.DLL, so that you can use the classes defined there. First, however, you give your project a meaningful name.  
  
#### To rename Class1.vb and add Microsoft.VisualStudio.DebuggerVisualizers  
  
1. In **Solution Explorer**, right-click **Class1.vb**, and on the shortcut menu, click **Rename**.  
  
2. Change the name from Class1.vb to something meaningful, such as DebuggerSide.vb.  
  
    > [!NOTE]
    > [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] automatically changes the class declaration in DebuggerSide.vb to match the new file name.  
  
3. In **Solution Explorer**, right-click **My First Visualizer**, and on the shortcut menu, click **Add Reference**.  
  
4. In the **Add Reference** dialog box, on the **.NET** tab, click Microsoft.VisualStudio.DebuggerVisualizers.DLL.  
  
5. Click **OK**.  
  
6. In DebuggerSide.vb, add the following statement to the `Imports` statements:  
  
    ```  
    Imports Microsoft.VisualStudio.DebuggerVisualizers  
    ```  
  
## Add the Debugger-side Code  
 Now, you are ready to create the debugger-side code. This is the code that runs within the debugger to display the information that you want to visualize. First, you have to change the declaration of the `DebuggerSide` object so that it inherits from the base class `DialogDebuggerVisualizer`.  
  
#### To inherit from DialogDebuggerVisualizer  
  
1. In DebuggerSide.vb, go to the following line of code:  
  
   ```  
   Public Class DebuggerSide  
   ```  
  
2. Edit the code so that it looks like this:  
  
   ```  
   Public Class DebuggerSide  
   Inherits DialogDebuggerVisualizer  
   ```  
  
   `DialogDebuggerVisualizer` has one abstract method, `Show`, that you must override.  
  
#### To override the DialogDebuggerVisualizer.Show method  
  
- In `public class DebuggerSide`, add the following method:  
  
  ```  
  Protected Overrides Sub Show(ByVal windowService As Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService, ByVal objectProvider As Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider)  
  
      End Sub  
  ```  
  
  The `Show` method contains the code that actually creates the visualizer dialog box, or other user interface, and displays the information that has been passed to the visualizer from the debugger. You must add the code that creates the dialog box and displays the information. In this walkthrough, you will do this using a Windows Forms message box. First, you must add a reference and `Imports` statement for <xref:System.Windows.Forms>.  
  
#### To add System.Windows.Forms  
  
1. In **Solution Explorer**, right-click **References**, and on the shortcut menu, click **Add Reference**.  
  
2. In the **Add Reference** dialog box, on the **.NET** tab, click **System.Windows.Forms**.  
  
3. Click **OK**.  
  
4. In DebuggerSide.cs, add the following statement to the `Imports` statements:  
  
    ```  
    Imports System.Windows.Forms  
    ```  
  
## Create Your Visualizer's User Interface  
 Now you will add some code to create and show the user interface for your visualizer. Because this is your first visualizer, you will keep the user interface simple and use a Message Box.  
  
#### To show the visualizer output in a dialog box  
  
1. In the `Show` method, add the following line of code:  
  
    ```  
    MessageBox.Show(objectProvider.GetObject().ToString())  
    ```  
  
     This example code does not include error handling. You should include error handling in a real visualizer, or any other kind of application.  
  
2. On the **Build** menu, click **Build MyFirstVisualizer**. The project should build successfully. Correct any build errors before continuing.  
  
## Add the Necessary Attribute  
 That is the end of the debugger-side code. There is one more step, however: the attribute that tells the debuggee side which collection of classes comprises the visualizer.  
  
#### To add the debugee-side code  
  
1. Add the following attribute code to DebuggerSide.vb, after the `Imports` statements but before `namespace MyFirstVisualizer`:  
  
    ```  
    <Assembly: System.Diagnostics.DebuggerVisualizer(GetType(MyFirstVisualizer.DebuggerSide), GetType(VisualizerObjectSource), Target:=GetType(System.String), Description:="My First Visualizer")>  
    ```  
  
2. On the **Build** menu, click **Build MyFirstVisualizer**. The project should build successfully. Correct any build errors before continuing.  
  
## Create a Test Harness  
 At this point, your first visualizer is finished. If you have followed the steps correctly, you can build the visualizer and install it into [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. Before you install a visualizer into [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], however, you should test it to make sure that it runs correctly. You will now create a test harness to run the visualizer without installing it into [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
#### To add a test method to show the visualizer  
  
1. Add the following method to class `public DebuggerSide`:  
  
   ```  
   Shared Public Sub TestShowVisualizer(ByVal objectToVisualize As Object)  
       Dim visualizerHost As New VisualizerDevelopmentHost(objectToVisualize, GetType(DebuggerSide))  
   visualizerHost.ShowVisualizer()  
   End Sub  
   ```  
  
2. On the **Build** menu, click **Build MyFirstVisualizer**. The project should build successfully. Correct any build errors before continuing.  
  
   Next, you must create an executable project to call your visualizer DLL. For simplicity, use a console application project.  
  
#### To add a console application project to the solution  
  
1. On the **File** menu, click **Add**, and then click **New Project**.  
  
2. In the **Add New Project** dialog box, in the **Templates** box, click **Console Application**.  
  
3. In the **Name** box, type a meaningful name for the console application, such as **MyTestConsole**.  
  
4. Click **OK**.  
  
   Now, you must add the necessary references so MyTestConsole can call MyFirstVisualizer.  
  
#### To add necessary references to MyTestConsole  
  
1. In **Solution Explorer**, right-click **MyTestConsole**, and on the shortcut menu, click **Add Reference**.  
  
2. In the **Add Reference** dialog box, on the **.NET** tab, click Microsoft.VisualStudio.DebuggerVisualizers.  
  
3. Click **OK**.  
  
4. Right-click **MyTestConsole**, and then click **Add Reference** again.  
  
5. In the **Add Reference** dialog box, click the **Projects** tab, and then select MyFirstVisualizer.  
  
6. Click **OK**.  
  
## Finish Your Test Harness and Test Your Visualizer  
 Now, you will add the code to finish the test harness.  
  
#### To add code to MyTestConsole  
  
1. In **Solution Explorer**, right-click **Program.vb**, and on the shortcut menu, click **Rename**.  
  
2. Edit the name from Module1.vb to something appropriate, such as **TestConsole.vb**.  
  
    Notice that [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] automatically changes the class declaration in TestConsole.vb to match the new file name.  
  
3. In TestConsole. vb, add the following `Imports` statement:  
  
   ```  
   Imports MyFirstVisualizer  
   ```  
  
4. In method `Main`, add the following code:  
  
   ```  
   Dim myString As String = "Hello, World"  
   DebuggerSide.TestShowVisualizer(myString)  
   ```  
  
   Now you are ready to test your first visualizer.  
  
#### To test the visualizer  
  
1. In **Solution Explorer**, right-click **MyTestConsole**, and on the shortcut menu, click **Set as Startup Project**.  
  
2. On the **Debug** menu, click **Start**.  
  
    The console application starts. The visualizer appears and displays the string "Hello, World."  
  
   Congratulations. You have just built and tested your first visualizer.  
  
   If you want to use your visualizer in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] rather than just calling it from the test harness, you have to install it. For more information, see [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md).  
  
## See Also  
 [Visualizer Architecture](../debugger/visualizer-architecture.md)   
 [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md)   
 [Create Custom Visualizers](../debugger/create-custom-visualizers-of-data.md)
