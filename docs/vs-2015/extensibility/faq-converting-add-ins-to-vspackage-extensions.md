---
title: "FAQ: Converting Add-ins to VSPackage Extensions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
ms.assetid: 3a01d333-6e31-423f-ae06-5091a4fcb7a9
caps.latest.revision: 23
ms.author: gregvanl
manager: jillfra
---
# FAQ: Converting Add-ins to VSPackage Extensions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Add-ins are now deprecated. To make a new Visual Studio extension, you need to create a VSIX extension. Here are the answers to some frequently asked questions about how to convert a Visual Studio add-in to a VSIX extension.  
  
> [!WARNING]
> Starting in Visual Studio 2015, for C# and Visual Basic projects, you can use the VSIX project and add item templates for menu commands, tool windows, and VSPackages. For more information, see [What's New in the Visual Studio 2015 SDK](../extensibility/what-s-new-in-the-visual-studio-2015-sdk.md).  
  
> [!IMPORTANT]
> In many cases you can simply transfer your add-in code to a VSIX project with a VSPackage project item. You can get the DTE automation object by calling <xref:Microsoft.VisualStudio.Shell.Package.GetService%2A> in the <xref:Microsoft.VisualStudio.Shell.Package.Initialize%2A> method.  
>   
> `DTE2 dte = (DTE2)GetService(typeof(DTE));`  
>   
> For more information, see [How can I run my add-in code in a VSPackage?](../extensibility/faq-converting-add-ins-to-vspackage-extensions.md#BKMK_RunAddin) below.  
  
## What software do I need to develop VSIX extensions?  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).  
  
## Where's the extension documentation?  
 Start with [Starting to Develop Visual Studio Extensions](../extensibility/starting-to-develop-visual-studio-extensions.md). Other articles about VSSDK extension development on MSDN are below that one.  
  
## Can I convert my add-in project to a VSIX project?  
 An add-in project can't be converted directly to a VSIX project because the mechanisms used in VSIX projects are not the same as the ones in add-in projects. The VSIX project template, plus the right project item templates have a lot of code that makes it relatively easy to get up and running as a VSIX extension.  
  
## <a name="BKMK_StartDeveloping"></a> How do I start developing VSIX extensions?  
 Here’s how you make a VSIX that has a menu command:  
  
#### To make a VSIX extension that has a menu command  
  
1. Create a VSIX project. (**File**, **New**, **Project**, or type **project** in the **Quick Launch** window). In the **New Project** dialog box, expand **Visual C# / Extensibility** or **Visual Basic / Extensibility** and select **VSIX Project**.) Name the project **TestExtension** and specify a location for it.  
  
2. Add a **Custom Command** project item template. (Right-click the project node in the **Solution Explorer** and select **Add / New Item**. In the **New Project** dialog for either Visual C# or Visual Basic, select the **Extensibility** node and select **Custom Command**.)  
  
3. Press F5 to build and run the project in debug mode.  
  
     A second instance of Visual Studio appears. This second instance is called the experimental instance, and it may not have the same settings as the instance of Visual Studio you're using to write code. The first time you run the experimental instance, you will be asked to sign in to VS Online and specify your theme and profile.  
  
     On the **Tools** menu (in the experimental instance) you should see a button named **My Command name**. When you choose this button, a message should appear: **Inside TestVSPackagePackage.MenuItemCallback()**.  
  
## <a name="BKMK_RunAddin"></a> How can I run my add-in code in a VSPackage?  
 Add-in code usually runs in one of two ways:  
  
- Triggered by a menu command (the code is in the `IDTCommandTarget.Exec` method)  
  
- Automatically on startup (the code is in the `OnConnection` event handler.)  
  
  You can do the same things in a VSPackage. Here's how to add some add-in code in the callback method:  
  
#### To implement a menu command in a VSPackage  
  
1. Create a VSPackage that has a menu command. (For more information, see [Creating an Extension with a Menu Command](../extensibility/creating-an-extension-with-a-menu-command.md).)  
  
2. Open the file that contains the definition of the VSPackage. (In a C# project, it's <em>\<your project name></em>Package.cs.)  
  
3. Add the following `using` statements to the file:  
  
   ```csharp  
   using EnvDTE;  
   using EnvDTE80;  
   ```  
  
4. Find the `MenuItemCallback` method. Add a call to <xref:Microsoft.VisualStudio.Shell.Package.GetService%2A> to get the <xref:EnvDTE80.DTE2> object:  
  
   ```csharp  
   DTE2 dte = (DTE2)GetService(typeof(DTE));  
   ```  
  
5. Add the code that your add-in had in its `IDTCommandTarget.Exec` method. For example, here is some code that adds a new pane to the **Output** window and prints "Some Text" in the new pane.  
  
   ```csharp  
   private void MenuItemCallback(object sender, EventArgs e)  
   {  
       DTE2 dte = (DTE2) GetService(typeof(DTE));  
       OutputWindow outputWindow = dte.ToolWindows.OutputWindow;  
  
       OutputWindowPane outputWindowPane = outputWindow.OutputWindowPanes.Add("A New Pane");  
       outputWindowPane.OutputString("Some Text");  
   }  
  
   ```  
  
6. Build and run this project. Press F5 or select **Start** on the **Debug** toolbar. In the experimental instance of Visual Studio, the **Tools** menu should have a button named **My Command name**. When you choose this button, the words **Some Text** should appear in an **Output** window pane. (You may have to open the **Output** window.)  
  
   You can also have your code run on startup. However, this approach is generally discouraged for VSPackage extensions. If too many extensions try to load when Visual Studio starts, the start time might become noticeably longer. A better practice is to load the VSPackage automatically only when some condition is met (like a solution being opened).  
  
   This procedure shows how to run add-in code in a VSPackage that loads automatically when a solution is opened:  
  
#### To autoload a VSPackage  
  
1. Create a VSIX project with a Visual Studio Package project item. (For the steps to do this, see [How do I start developing VSIX extensions?](../extensibility/faq-converting-add-ins-to-vspackage-extensions.md#BKMK_StartDeveloping). Just add the **Visual Studio Package** project item instead.) Name the VSIX project **TestAutoload**.  
  
2. Open TestAutoloadPackage.cs. Find the line where the package class is declared:  
  
   ```csharp  
   public sealed class <name of your package>Package : Package  
   ```  
  
3. Above this line is a set of attributes. Add this attribute:  
  
   ```csharp  
   [ProvideAutoLoad(UIContextGuids80.SolutionExists)]  
   ```  
  
4. Set a breakpoint in the `Initialize()` method and start debugging (F5).  
  
5. In the experimental instance, open a project. The VSPackage should load, and your breakpoint should be hit.  
  
   You can specify other contexts in which to load your VSPackage by using the fields of <xref:Microsoft.VisualStudio.Shell.Interop.UIContextGuids80>. For more information, see [Loading VSPackages](../extensibility/loading-vspackages.md).  
  
## How can I get the DTE object?  
 If your add-in doesn't display UI—for example, menu commands, toolbar buttons, or tool windows—you may be able to use your code as-is as long as you get the DTE automation object from the VSPackage. Here's how:  
  
#### To get the DTE object from a VSPackage  
  
1. In a VSIX project with a Visual Studio Package item template, look for the <em>\<project name></em>Package.cs file. This is the class that derives from <xref:Microsoft.VisualStudio.Shell.Package>; it can help you interact with Visual Studio. In this case, you use its <xref:Microsoft.VisualStudio.Shell.Package.GetService%2A> to get the <xref:EnvDTE80.DTE2> object.  
  
2. Add these `using` statements:  
  
   ```csharp  
   using EnvDTE;  
   using EnvDTE80;  
   ```  
  
3. Find the `Initialize` method. This method handles the command you specified in the package wizard. Add a call to <xref:Microsoft.VisualStudio.Shell.Package.GetService%2A> to get the DTE object:  
  
   ```csharp  
   DTE dte = (DTE)GetService(typeof(DTE));  
   ```  
  
   After you have the <xref:EnvDTE.DTE> automation object, you can add the rest of your add-in code to the project. If you need the <xref:EnvDTE80.DTE2> object, you can do the same thing.  
  
## How do I change menu commands and toolbar buttons in my add-in to the VSPackage style?  
 VSPackage extensions use the .vsct file to create most of the menu commands, toolbars, toolbar buttons, and other UI. The **Custom Command** project item template gives you the option to create a command on the **Tools** menu. For more information, see [Creating an Extension with a Menu Command](../extensibility/creating-an-extension-with-a-menu-command.md).  
  
 For more information about .vsct files, see [How VSPackages Add User Interface Elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md). For walkthroughs that show how to use the .vsct file to add menu items, toolbars, and toolbar buttons, see [Extending Menus and Commands](../extensibility/extending-menus-and-commands.md).  
  
## How do I add custom tool windows in the VSPackage way?  
 The Custom Tool Window project item template gives you the option to create a tool window. For more information about this project item template, see [Creating an Extension with a Tool Window](../extensibility/creating-an-extension-with-a-tool-window.md). For information about tool windows, see [Extending and Customizing Tool Windows](../extensibility/extending-and-customizing-tool-windows.md) and the articles under it, especially [Adding a Tool Window](../extensibility/adding-a-tool-window.md).  
  
## How do I manage Visual Studio windows in the VSPackage way?  
 If your add-in manages Visual Studio windows, the add-in code should work in a VSPackage. For example, this procedure shows how to add code that manages the **Task List** to the `MenuItemCallback` method of the VSPackage.  
  
#### To insert window-management code from an add-in into a VSPackage  
  
1. Create a VSPackage that has a menu command, as in the [How do I start developing VSIX extensions?](../extensibility/faq-converting-add-ins-to-vspackage-extensions.md#BKMK_StartDeveloping) section.  
  
2. Open the file that contains the definition of the VSPackage. (In a C# project, it's <em>\<your project name></em>Package.cs.)  
  
3. Add these `using` statements:  
  
   ```csharp  
   using EnvDTE;  
   using EnvDTE80;  
   ```  
  
4. Find the `MenuItemCallback` method. Add a call to <xref:Microsoft.VisualStudio.Shell.Package.GetService%2A> to get the <xref:EnvDTE80.DTE2> object:  
  
   ```csharp  
   DTE2 dte = (DTE2)GetService(typeof(DTE));  
   ```  
  
5. Add the code from your add-in. For example, here is some code that adds new tasks to the **Task List**, lists the number of tasks, and then deletes one task.  
  
   ```csharp  
   private void MenuItemCallback(object sender, EventArgs e)   
   {  
       DTE2 dte = (DTE2) GetService(typeof(DTE));   
  
       TaskList tl = (TaskList)dte.ToolWindows.TaskList;   
       askItem tlItem;   
  
       // Add a couple of tasks to the Task List.   
       tlItem = tl.TaskItems.Add(" ", " ", "Test task 1.",    
           vsTaskPriority.vsTaskPriorityHigh, vsTaskIcon.vsTaskIconUser,   
           true, "", 10, true, true);  
       tlItem = tl.TaskItems.Add(" ", " ", "Test task 2.",   
           vsTaskPriority.vsTaskPriorityLow, vsTaskIcon.vsTaskIconComment, true, "", 20, true,true);  
  
       // List the total number of task list items after adding the new task items.  
       System.Windows.Forms.MessageBox.Show("Task Item 1 description: "+tl.TaskItems.Item(2).Description);  
       System.Windows.Forms.MessageBox.Show("Total number of task items: "+tl.TaskItems.Count);   
  
       // Remove the second task item. The items list in reverse numeric order.   
       System.Windows.Forms.MessageBox.Show("Deleting the second task item");  
       tl.TaskItems.Item(2).Delete();  
       System.Windows.Forms.MessageBox.Show("Total number of task items: "+tl.TaskItems.Count);   
   }  
   ```  
  
## How do I manage projects and solutions in a VSPackage?  
 If your add-in manages projects and solutions, the add-in code should work in a VSPackage. For example, this procedure shows how to add code that gets the startup project.  
  
1. Create a VSPackage that has a menu command, as in the [How do I start developing VSIX extensions?](../extensibility/faq-converting-add-ins-to-vspackage-extensions.md#BKMK_StartDeveloping) section.  
  
2. Open the file that contains the definition of the VSPackage. (In a C# project, it's <em>\<your project name></em>Package.cs.)  
  
3. Add these `using` statements:  
  
   ```csharp  
   using EnvDTE;  
   using EnvDTE80;  
   ```  
  
4. Find the `MenuItemCallback` method. Add a call to <xref:Microsoft.VisualStudio.Shell.Package.GetService%2A> to get the <xref:EnvDTE80.DTE2> object:  
  
   ```csharp  
   DTE2 dte = (DTE2)GetService(typeof(DTE));  
   ```  
  
5. Add the code from your add-in. For example, the following code gets the name of the startup project in a solution. (A multi-project solution must be open when this package runs.)  
  
   ```csharp  
   private void MenuItemCallback(object sender, EventArgs e)  
   {  
       DTE2 dte = (DTE2) GetService(typeof(DTE));   
  
       SolutionBuild2 sb = (SolutionBuild2)dte.Solution.SolutionBuild;   
       Project startupProj;   
       string msg = "";  
  
       foreach (String item in (Array)sb.StartupProjects)   
       {  
           msg += item;   
       }  
       System.Windows.Forms.MessageBox.Show("Solution startup Project: "+msg);   
       startupProj = dte.Solution.Item(msg);   
       System.Windows.Forms.MessageBox.Show("Full name of solution's startup project: "+"/n"+startupProj.FullName);   
   }  
   ```  
  
## How do I set keyboard shortcuts in a VSPackage?  
 You use the `<KeyBindings>` element of the .vsct file. In the following example, the keyboard shortcut for the command `idCommand1` is Alt+A, and the keyboard shortcut for the command `idCommand2` is Alt+Ctrl+A. Notice the syntax for the key names.  
  
```xml  
<KeyBindings>  
    <KeyBinding guid="MyProjectCmdSet" id="idCommand1" editor="guidVSStd97" key1="A" mod1="ALT" />  
    <KeyBinding guid="MyProjectCmdSet" id="idCommand2" editor="guidVSStd97" key1="A" mod1="CONTROL" mod2="ALT" />  
</KeyBindings>  
```  
  
## How do I handle automation events in a VSPackage?  
 You handle automation events in a VSPackage in the same way as in your add-in. The following code shows how to handle the `OnItemRenamed` event. (This example assumes that you've already gotten the DTE object.)  
  
```csharp  
Events2 dteEvents = (Events2)dte.Events;  
dteEvents.ProjectItemsEvents.ItemRenamed += listener1.OnItemRenamed;   
. . .  
public void OnItemRenamed(EnvDTE.ProjectItem projItem, string oldName)   
{  
    string s = "[Event] Renamed " + oldName + " to " + Path.GetFileName(projItem.get_FileNames(1) + " in project " + projItem.ContainingProject.Name;   
}  
```
