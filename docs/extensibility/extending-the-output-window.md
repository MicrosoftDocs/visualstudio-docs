---
title: Extending the Output Window
description: Learn how to extend the Output window in the Visual Studio SDK and to create and manage your own custom panes.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- Output window, about Output window
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Extend the Output window

The **Output** window is a set of read/write text panes. Visual Studio has these built-in panes: **Build**, in which projects communicate messages about builds, and **General**, in which Visual Studio communicates messages about the IDE. Projects get a reference to the **Build** pane automatically through the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildableProjectCfg> interface methods, and Visual Studio offers direct access to the **General** pane through the <xref:Microsoft.VisualStudio.Shell.Interop.SVsGeneralOutputWindowPane> service. In addition to the built-in panes, you can create and manage your own custom panes.

 You can control the **Output** window directly through the <xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindow> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindowPane> interfaces. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindow> interface, which is offered by the <xref:Microsoft.VisualStudio.Shell.Interop.SVsOutputWindow> service, defines methods for creating, retrieving, and destroying **Output** window panes. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindowPane> interface defines methods for showing panes, hiding panes, and manipulating their text. An alternative way of controlling the **Output** window is through the <xref:EnvDTE.OutputWindow> and <xref:EnvDTE.OutputWindowPane> objects in the Visual Studio Automation object model. These objects encapsulate nearly all of the functionality of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindow> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindowPane> interfaces. In addition, the <xref:EnvDTE.OutputWindow> and <xref:EnvDTE.OutputWindowPane> objects add some higher-level functionality to make it easier to enumerate the **Output** window panes and to retrieve text from the panes.

## Create an extension that uses the Output pane
 You can make an extension that exercises different aspects of the Output pane.

1. Create a VSIX project named `TestOutput` with a menu command named **TestOutput**. For more information, see [Create an extension with a menu command](../extensibility/creating-an-extension-with-a-menu-command.md).

2. Add the following references:

    1. EnvDTE

    2. EnvDTE80

3. In *TestOutput.cs*, add the following using statement:

    ```fsharp
    using EnvDTE;
    using EnvDTE80;
    ```

4. In *TestOutput.cs*, delete the `ShowMessageBox` method. Add the following method stub:

    ```csharp
    private void OutputCommandHandler(object sender, EventArgs e)
    {
    }
    ```

5. In the TestOutput constructor, change the command handler to OutputCommandHandler. Here is the part that adds the commands:

    ```csharp
    OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
    if (commandService != null)
    {
        CommandID menuCommandID = new CommandID(MenuGroup, CommandId);
        EventHandler eventHandler = OutputCommandHandler;
        MenuCommand menuItem = new MenuCommand(eventHandler, menuCommandID);
        commandService.AddCommand(menuItem);
    }
    ```

6. The sections below have different methods that show different ways of dealing with the Output pane. You can call these methods to body of the `OutputCommandHandler()` method. For example, the following code adds the `CreatePane()` method given in the next section.

    ```csharp
    private void OutputCommandHandler(object sender, EventArgs e)
    {
        CreatePane(new Guid(), "Created Pane", true, false);
    }
    ```

## Create an Output window with IVsOutputWindow
 This example shows how to create a new **Output** window pane by using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindow> interface.

```csharp
void CreatePane(Guid paneGuid, string title,
    bool visible, bool clearWithSolution)
{
    IVsOutputWindow output =
        (IVsOutputWindow)GetService(typeof(SVsOutputWindow));
    IVsOutputWindowPane pane;

    // Create a new pane.
    output.CreatePane(
        ref paneGuid,
        title,
        Convert.ToInt32(visible),
        Convert.ToInt32(clearWithSolution));

    // Retrieve the new pane.
    output.GetPane(ref paneGuid, out pane);

     pane.OutputString("This is the Created Pane \n");
}
```

 If you add this method to the extension given in the preceding section, when you click the **Invoke TestOutput** command you should see the **Output** window with a header that says **Show output from: CreatedPane** and the words **This is the Created Pane** in the pane itself.

## Create an Output window with OutputWindow
 This example shows how to create an **Output** window pane by using the <xref:EnvDTE.OutputWindow> object.

```csharp
void CreatePane(string title)
{
    DTE2 dte = (DTE2)GetService(typeof(DTE));
    OutputWindowPanes panes =
        dte.ToolWindows.OutputWindow.OutputWindowPanes;

    try
    {
        // If the pane exists already, write to it.
        panes.Item(title);
    }
    catch (ArgumentException)
    {
        // Create a new pane and write to it.
        panes.Add(title);
    }
}
```

 Although the <xref:EnvDTE.OutputWindowPanes> collection lets you retrieve an **Output** window pane by its title, pane titles are not guaranteed to be unique. When you doubt the uniqueness of a title, use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindow.GetPane%2A> method to retrieve the correct pane by its GUID.

 If you add this method to the extension given in the preceding section, when you click the **Invoke TestOutput** command you should see the Output window with a header that says **Show output from: DTEPane** and the words **Added DTE Pane** in the pane itself.

## Delete an Output window
 This example shows how to delete an **Output** window pane.

```csharp
void DeletePane(Guid paneGuid)
{
    IVsOutputWindow output =
    (IVsOutputWindow)ServiceProvider.GetService(typeof(SVsOutputWindow));

    IVsOutputWindowPane pane;
    output.GetPane(ref paneGuid, out pane);

    if (pane == null)
    {
        CreatePane(paneGuid, "New Pane\n", true, true);
    }
     else
    {
        output.DeletePane(ref paneGuid);
    }
}
```

 If you add this method to the extension given in the preceding section, when you click the **Invoke TestOutput** command you should see the Output window with a header that says **Show output from: New Pane** and the words **Added Created Pane** in the pane itself. If you click the **Invoke TestOutput** command again, the pane is deleted.

## Get the General pane of the Output window
 This example shows how to get the built-in **General** pane of the **Output** window.

```csharp
IVsOutputWindowPane GetGeneralPane()
{
    return (IVsOutputWindowPane)GetService(
        typeof(SVsGeneralOutputWindowPane));
}
```

 If you add this method to the extension given in the preceding section, when you click the **Invoke TestOutput** command you should see that the **Output** window shows the words **Found General pane** in the pane.

## Get the Build pane of the Output window
 This example shows how to find the **Build** pane and write to it. Since the **Build** pane isn't activated by default, it activates it also.

```csharp
void OutputTaskItemStringExExample(string buildMessage)
{
    EnvDTE80.DTE2 dte = (EnvDTE80.DTE2)ServiceProvider.GetService(typeof(EnvDTE.DTE));

    EnvDTE.OutputWindowPanes panes =
        dte.ToolWindows.OutputWindow.OutputWindowPanes;
    foreach (EnvDTE.OutputWindowPane pane in panes)
        {
            if (pane.Name.Contains("Build"))
            {
                pane.OutputString(buildMessage + "\n");
                pane.Activate();
                return;
             }
        }
}
```
