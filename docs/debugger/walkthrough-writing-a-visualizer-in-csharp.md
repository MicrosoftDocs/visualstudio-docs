---
title: "Write a visualizer in C# | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "04/12/2019"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "visualizers, writing"
  - "walkthroughs [Visual Studio], visualizers"
ms.assetid: 53467461-8e0f-45ee-9bc4-374bbaeaf00f
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "dotnet"
---
# Walkthrough: Writing a Visualizer in C\#
This walkthrough shows how to write a simple visualizer by using C#. The visualizer you will create in this walkthrough displays the contents of a string using a Windows forms message box. This simple string visualizer is not especially useful in itself, but it shows the basic steps that you must follow to create more useful visualizers for other data types.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help, depending on your active settings or edition. To change your settings, go to the **Tools** menu and choose **Import and Export Settings**. For more information, see [Reset settings](../ide/environment-settings.md#reset-settings).

Visualizer code must be placed in a DLL, which will be read by the debugger. Therefore, the first step is to create a Class Library project for the DLL.

## Create a visualizer manually

Follow the tasks below to create a visualizer.

### To create a class library project

1. Create a new class library project.

    ::: moniker range=">=vs-2019"
    Press **Esc** to close the start window. Type **Ctrl + Q** to open the search box, type **class library**, choose **Templates**, then choose **Create a new Class Library (.NET Standard)**. In the dialog box that appears, choose **Create**.
    ::: moniker-end
    ::: moniker range="vs-2017"
    From the top menu bar, choose **File** > **New** > **Project**. In the left pane of the **New project** dialog box, under **Visual C#**, choose **.NET Standard**, and then in the middle pane choose **Class Library (.NET Standard)**.
    ::: moniker-end

2. Type an appropriate name for the class library, such as `MyFirstVisualizer`, and then click **Create** or **OK**.

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

  The `Show` method contains the code that actually creates the visualizer dialog box or other user interface and displays the information that has been passed to the visualizer from the debugger. You must add the code that creates the dialog box and displays the information. In this walkthrough, you will do this using a Windows forms message box. First, you must add a reference and `using` directive for System.Windows.Forms.

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

### To add the debuggee-side code

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

   Next, you must create an executable project to call your visualizer DLL. For simplicity, we will use a Console Application project.

### To add a console application project to the solution

1. In Solution Explorer, right-click the solution, choose **Add**, and then click **New Project**.

    ::: moniker range=">=vs-2019"
    In the Search box, type **console app**, choose **Templates**, then choose **Create a new Console App (.NET Framework)**. In the dialog box that appears, choose **Create**.
    ::: moniker-end
    ::: moniker range="vs-2017"
    From the top menu bar, choose **File** > **New** > **Project**. In the left pane of the **New project** dialog box, under **Visual C#**, choose **Windows Desktop**, and then in the middle pane choose **Console App (.NET Framework)**.
    ::: moniker-end

2. Type an appropriate name for the class library, such as `MyTestConsole`, and then click **Create** or **OK**.

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

   Congratulations. You have just built and tested your first visualizer.

   If you want to use your visualizer in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] rather than just calling it from the test harness, you have to install it. For more information, see [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md).

## Create a visualizer using the Visualizer item template

So far, this walkthrough has shown you how to create a visualizer manually. This was done as a learning exercise. Now that you know how a simple visualizer works, there is an easier way to create one: using the visualizer item template.

First, you have to create a new class library project.

### To create a new class library

1. On the **File** menu, choose **New > Project**.

2. In the **New Project** dialog box, under **Visual C#**, select **.NET Standard**.

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

## See also

- [Visualizer Architecture](../debugger/visualizer-architecture.md)
- [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md)
- [Create Custom Visualizers](../debugger/create-custom-visualizers-of-data.md)
