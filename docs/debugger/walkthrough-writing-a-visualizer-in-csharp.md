---
title: "Write a visualizer in C# | Microsoft Docs"
description: Follow a walkthrough to create a simple visualizer in C#. It shows the steps required both with and without using the Visualizer item template.

ms.date: "07/02/2021"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "visualizers, writing"
  - "walkthroughs [Visual Studio], visualizers"
ms.assetid: 53467461-8e0f-45ee-9bc4-374bbaeaf00f
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "dotnet"
---
# Walkthrough: Writing a Visualizer in C\#

This walkthrough shows how to write a simple visualizer by using C#. The visualizer you will create in this walkthrough displays the contents of a string using a Windows Form. This simple string visualizer is not especially useful in itself, but it shows the basic steps that you must follow to create more useful visualizers for other data types.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help, depending on your active settings or edition. To change your settings, go to the **Tools** menu and choose **Import and Export Settings**. For more information, see [Reset settings](../ide/environment-settings.md#reset-settings).

Visualizer code must be placed in a DLL, which will be read by the debugger. Therefore, the first step is to create a Class Library project for the DLL.

## Create a visualizer manually

Follow the tasks below to create a visualizer.

### To create a class library project

* Create a new class library project.

    ::: moniker range=">=vs-2019"
    Choose **File** > **New** > **Project**. In the language drop-down, choose **C#**. In the search box, type **class library**, and then choose **Class Library (.NET Framework)**. Click **Next**. In the dialog box that appears, type the name `MyFirstVisualizer`, and then click **Create**.

    For the visualizer project, make sure you select a .NET Framework class library and not .NET. Although the visualizer needs to be .NET Framework, the calling app can be .NET.
    ::: moniker-end
    ::: moniker range="vs-2017"
    From the top menu bar, choose **File** > **New** > **Project**. In the left pane of the **New project** dialog box, under **Visual C#**, choose **.NET Framework**, and then in the middle pane choose **Class Library (.NET Framework)**.

    Type an appropriate name for the class library, such as `MyFirstVisualizer`, and then click **Create** or **OK**.
    ::: moniker-end

   After you have created the class library, you must add a reference to Microsoft.VisualStudio.DebuggerVisualizers.DLL so that you can use the classes defined there. Before you add the reference, however, you must rename some classes so that they have meaningful names.

### To rename Class1.cs and add Microsoft.VisualStudio.DebuggerVisualizers

1. In **Solution Explorer**, right-click Class1.cs and choose **Rename** on the shortcut menu.

2. Change the name from Class1.cs to something meaningful, such as DebuggerSide.cs.

   > [!NOTE]
   > [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] automatically changes the class declaration in DebuggerSide.cs to match the new file name.

3. In **Solution Explorer**, right-click **References** and choose **Add Reference** on the shortcut menu.

4. In the **Add Reference** dialog box, on the **Browse** tab, select **Browse** and find the Microsoft.VisualStudio.DebuggerVisualizers.DLL.

    You can find the DLL in *\<Visual Studio Install Directory>\Common7\IDE\PublicAssemblies* subdirectory of Visual Studio's installation directory.

5. Click **OK**.

6. In DebuggerSide.cs, add the following to the `using` directives:

   ```csharp
   using Microsoft.VisualStudio.DebuggerVisualizers;
   ```

   Now you are ready to create the debugger-side code. This is the code that runs within the debugger to display the information that you want to visualize. First, you have to change the declaration of the `DebuggerSide` object so that inherits from the base class `DialogDebuggerVisualizer`.

### To inherit from DialogDebuggerVisualizer

1. In DebuggerSide.cs, go to the following line of code:

   ```csharp
   public class DebuggerSide
   ```

2. Change the code to:

   ```csharp
   public class DebuggerSide : DialogDebuggerVisualizer
   ```

   `DialogDebuggerVisualizer` has one abstract method (`Show`) that you must override.

#### To override the DialogDebuggerVisualizer.Show method

- In `public class DebuggerSide`, add the following **method:**

  ```csharp
  protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
  {
  }
  ```

  The `Show` method contains the code that actually creates the visualizer dialog box or other user interface and displays the information that has been passed to the visualizer from the debugger. You must add the code that creates the dialog box and displays the information. In this walkthrough, you will do this using a Windows Forms message box. First, you must add a reference and `using` directive for System.Windows.Forms.

### To add System.Windows.Forms

1. In **Solution Explorer**, right-click **References** and choose **Add Reference** on the shortcut menu.

2. In the **Add Reference** dialog box, on the **Browse** tab, select **Browse**, and find the System.Windows.Forms.DLL.

    You can find the DLL in *C:\Windows\Microsoft.NET\Framework\v4.0.30319*.

3. Click **OK**.

4. In DebuggerSide.cs, add the following to the `using` directives:

   ```csharp
   using System.Windows.Forms;
   ```

   Now, you will add some code to create and show the user interface for your visualizer. Because this is your first visualizer, we will keep the user interface simple and use a Message Box.

### To show the Visualizer Output in a dialog box

1. In the `Show` method, add the following line of code:

   ```csharp
   MessageBox.Show(objectProvider.GetObject().ToString());
   ```

    This example code does not include error handling. You should include error handling in a real visualizer or any other kind of application.

2. On the **Build** menu, choose **Build MyFirstVisualizer**. The project should build successfully. Correct any build errors before continuing.

   That is the end of the debugger side code. There is one more step, however; the attribute that tells the debuggee side which collection of classes comprises the visualizer.

### To add the type to visualize for the debuggee-side code

In the debugger-side code, you specify the type to visualize (the object source) for the debuggee using the <xref:System.Diagnostics.DebuggerVisualizerAttribute> attribute. The `Target` property sets the type to visualize.

1. Add the following attribute code to DebuggerSide.cs, after the `using` directives but before `namespace MyFirstVisualizer`:

   ```csharp
   [assembly:System.Diagnostics.DebuggerVisualizer(
   typeof(MyFirstVisualizer.DebuggerSide),
   typeof(VisualizerObjectSource),
   Target = typeof(System.String),
   Description = "My First Visualizer")]
   ```

2. On the **Build** menu, choose **Build MyFirstVisualizer**. The project should build successfully. Correct any build errors before continuing.

   At this point, your first visualizer is finished. If you have followed the steps correctly, you can build the visualizer and install it into [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. Before you install a visualizer into [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], however, you should test it to make sure that it runs correctly. You will now create a test harness to run the visualizer without installing it into [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].

### To add a Test Method to show the visualizer

1. Add the following method to class `public DebuggerSide`:

   ```csharp
   public static void TestShowVisualizer(object objectToVisualize)
   {
      VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerSide));
      visualizerHost.ShowVisualizer();
   }
   ```

2. On the **Build** menu, choose **Build MyFirstVisualizer**. The project should build successfully. Correct any build errors before continuing.

   Next, you must create an executable project to call your visualizer DLL. For simplicity, use a Console Application project.

### To add a console application project to the solution

1. In Solution Explorer, right-click the solution, choose **Add**, and then click **New Project**.

    ::: moniker range=">=vs-2019"

    Choose **File** > **New** > **Project**. In the language drop-down, choose **C#**. In the search box, type **console app**, and then choose either **Console App (.NET Framework)** or **Console Application** for .NET. Click **Next**. In the dialog box that appears, type the name `MyTestConsole`, and then click **Create**.

    > [!NOTE]
    > If you want to easily test the visualizer using a test harness, create a .NET Framework console app. You can create a .NET console app instead, but the test harness described later is not yet supported for .NET, so you will need to install the visualizer to test it. For a .NET console app, first create the console app here, add the required DLL and project references, and then follow steps described in [Add a debuggee-side data object](#add-a-debuggee-side-data-object). For ASP.NET Core scenarios, see [Special debugger side considerations for .NET 5.0+](../debugger/create-custom-visualizers-of-data.md#special-debugger-side-considerations-for-net-50).
    ::: moniker-end
    ::: moniker range="vs-2017"
    From the top menu bar, choose **File** > **New** > **Project**. In the left pane of the **New project** dialog box, under **Visual C#**, choose **Windows Desktop**, and then in the middle pane choose **Console App (.NET Framework)**.

    Type an appropriate name for the class library, such as `MyTestConsole`, and then click **OK**.
    ::: moniker-end

   Now, you must add the necessary references so MyTestConsole can call MyFirstVisualizer.

### To add necessary references to MyTestConsole

1. In **Solution Explorer**, right-click **MyTestConsole** and choose **Add Reference** on the shortcut menu.

2. In the **Add Reference** dialog box, **Browse** tab, choose Microsoft.VisualStudio.DebuggerVisualizers.DLL.

3. Click **OK**.

4. Right-click **MyTestConsole** and choose **Add Reference** again.

5. In the **Add Reference** dialog box, click the **Projects** tab and then click MyFirstVisualizer.

6. Click **OK**.

   Now, you will add the code to finish the test harness.

### To add code to MyTestConsole

1. In **Solution Explorer**, right-click Program.cs and choose **Rename** on the shortcut menu.

2. Edit the name from Program.cs to something more meaningful, such as TestConsole.cs.

    > [!NOTE]
    > [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] automatically changes the class declaration in TestConsole.cs to match the new file name.

3. In TestConsole.cs, add the following code to the `using` directives:

   ```csharp
   using MyFirstVisualizer;
   ```

4. In method `Main`, add the following code:

   ```csharp
   String myString = "Hello, World";
   DebuggerSide.TestShowVisualizer(myString);
   ```

   Now, you are ready to test your first visualizer.

### To test the visualizer

1. In **Solution Explorer**, right-click **MyTestConsole** and choose **Set as Startup Project** on the shortcut menu.

2. On the **Debug** menu, choose **Start**.

    The console application starts and the Visualizer appears and displays the string, "Hello, World."

   Congratulations. You have just built and tested your first visualizer!

   If you want to use your visualizer in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] rather than just calling it from the test harness, you have to install it. For more information, see [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md).

::: moniker range=">=vs-2019"
## Add a debuggee-side data object

In this section, you switch from the `System.String` data object to a custom data object.  

1. In Solution Explorer, right-click the solution, choose **Add**, and then click **New Project**. In the language drop-down, choose **C#**. In the search box, type **class library**, and then choose either **Class Library (.NET Framework)** or **Class Library** for .NET Standard.

   >[!NOTE]
   >If you are using a .NET Framework test console app, make sure you create a .NET Framework class library project.

1. Click **Next**. In the dialog box that appears, type the name `MyDataObject`, and then click **Create**.

1. (.NET Standard class library only) In Solution Explorer, right-click the project and choose **Edit Project File**. Change the `<TargetFramework>` value to `netstandard2.0`.

   ```xml
   <TargetFramework>netstandard2.0</TargetFramework>
   ```

1. Inside the `MyDataObject` namespace, replace the default code with the following code.

   ```csharp
   [Serializable] 
   public class CustomDataObject
   {
      public CustomDataObject()
      {
         this.MyData = "MyTestData";
      }
      public string MyData { get; set; }
   }
   ```

   For a read-only visualizer, such as in this example, it is not necessary to implement methods of [VisualizerObjectSource](/dotnet/api/microsoft.visualstudio.debuggervisualizers.visualizerobjectsource).

   Next, update the MyFirstVisualizer project to use the new data object.

1. In Solution Explorer under the MyFirstVisualizer project, right-click the **References** node and choose **Add Reference**.

1. Under **Projects**, select the **MyDataObject** project.

1. In the attribute code of DebuggerSide.cs, update the Target value, changing `System.String` to `MyDataObject.CustomDataObject`.

   ```csharp
   Target = typeof(MyDataObject.CustomDataObject),
   ```

1. In the MyFirstVisualizer project, replace the code for the `Show` method with the following code.

   ```csharp
   var data = objectProvider.GetObject() as MyDataObject.CustomDataObject;

   // You can replace displayForm with your own custom Form or Control.  
   Form displayForm = new Form();
   displayForm.Text = data.MyData;
   windowService.ShowDialog(displayForm);
   ```

   The preceding code uses a property of the data object to show in the Form's title.

   Next, update the console app to use the custom data object.

1. In Solution Explorer under the MyTestConsole project, right-click the **References** or **Dependencies** node, and add a project reference to `MyDataObject`.

1. In Program.cs, replace the code in the `Main` method with the following code.

   ```csharp
   // String myString = "Hello, World";
   CustomDataObject customDataObject = new CustomDataObject();

   DebuggerSide.TestShowVisualizer(customDataObject.MyData);
   ```

1. (.NET console app) Enclose the call to `TestShowVisualizer` in a try-catch statement, since the test harness is unsupported.

   ```csharp
   try
   {
         DebuggerSide.TestShowVisualizer(customDataObject.MyData);
   }
   catch (Exception) {
   }
   ```

   The console app needs a runtime reference to the visualizer. You can maintain the reference by keeping the preceding code instead of commenting it out.

1. For a .NET Framework console app, you can run the test harness (press **F5**), or you can follow instructions in [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md).

   If you run the app using the test harness, the app shows the Windows Form.

1. For a .NET console app, copy the `MyFirstVisualizer.dll` and the `MyDataObject.dll` to the folders described in [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md).

1. After installing the visualizer, set a breakpoint, run the console app, and hover over `customDataObject`. If everything is set up correctly, you should see the magnifying glass icon ![VisualizerIcon](../debugger/media/dbg-tips-visualizer-icon.png "Visualizer icon").

   :::image type="content" source="../debugger/media/vs-2019/visualizer-csharp-data-object.png" alt-text="Visualizer magnifying glass icon.":::

   When you choose **MyFirstVisualizer** from the magnifying glass, you will see the Form with the data object text in the title.

   ![Visualizer showing a Windows Form](../debugger/media/vs-2019/visualizer-csharp-windows-form.png)

::: moniker-end

::: moniker range="vs-2017"

## Create a visualizer using the Visualizer item template

So far, this walkthrough has shown you how to create a visualizer manually. This was done as a learning exercise. Now that you know how a simple visualizer works, there is an easier way to create one: using the visualizer item template.

First, you have to create a new class library project.

### To create a new class library

1. On the **File** menu, choose **New > Project**.

2. In the **New Project** dialog box, under **Visual C#**, select **.NET Framework**.

3. In the middle pane, choose **Class Library**.

4. In the **Name** box, type an appropriate name for the class library, such as MySecondVisualizer.

5. Click **OK**.

   Now, you can add a visualizer item to it:

### To add a visualizer item

1. In **Solution Explorer**, right-click MySecondVisualizer.

2. On the shortcut menu, choose **Add** and then click **New Item**.

3. In the **Add New Item** dialog box, under **Visual C# Items**, select **Debugger Visualizer**.

4. In the **Name** box, type an appropriate name, such as SecondVisualizer.cs.

5. Click **Add**.

   That is all there is to it. Look at the file SecondVisualizer.cs and view the code that the template added for you. Go ahead and experiment with the code. Now that you know the basics, you are on your way to creating more complex and useful visualizers of your own.
::: moniker-end

## See also

- [Visualizer Architecture](../debugger/visualizer-architecture.md)
- [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md)
- [Create Custom Visualizers](../debugger/create-custom-visualizers-of-data.md)
