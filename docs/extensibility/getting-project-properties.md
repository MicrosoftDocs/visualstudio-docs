---
title: Getting Project Properties
description: Learn how to display project properties in a tool window. This example shows the tree control in the tool window.
ms.date: 3/16/2019
ms.topic: how-to
helpviewer_keywords:
- project properties, displaying in tool window
- tool windows, displaying project properties
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Get project properties

This walkthrough shows how to displays project properties in a tool window.

### To create a VSIX Project and add a tool window

1. Every Visual Studio extension starts with a VSIX deployment project, which will contain the extension assets. Create a Visual Studio VSIX project named `ProjectPropertiesExtension`. You can find the VSIX project template in the **New Project** dialog by searching for "vsix".

2. Add a tool window by adding a Custom Tool Window item template named `ProjectPropertiesToolWindow`. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. In the **Add New Item dialog**, go to **Visual C# Items** > **Extensibility** and select **Custom Tool Window**. In the **Name** field at the bottom of the dialog, change the file name to `ProjectPropertiesToolWindow.cs`. For more information about how to create a custom tool window, see [Create an extension with a tool window](../extensibility/creating-an-extension-with-a-tool-window.md).

3. Build the solution and verify that it compiles without errors.

### To display project properties in a tool window

1. In the ProjectPropertiesToolWindowCommand.cs file, add the following using directives.

    ```csharp
    using EnvDTE;
    using System.Windows.Controls;

    ```

2. In *ProjectPropertiesToolWindowControl.xaml*, remove the existing button and add a TreeView from the Toolbox. You can also remove the click event handler from the *ProjectPropertiesToolWindowControl.xaml.cs* file.

3. In *ProjectPropertiesToolWindowCommand.cs*, use the `ShowToolWindow()` method to open the project and read its properties, then add the properties to the TreeView. The code for ShowToolWindow should look like the following:

    ```csharp
    private void ShowToolWindow(object sender, EventArgs e)
    {
        ToolWindowPane window = this.package.FindToolWindow(typeof(ProjectPropertiesToolWindow), 0, true);
        if ((null == window) || (null == window.Frame))
        {
            throw new NotSupportedException("Cannot create window.");
        }
        IVsWindowFrame windowFrame = (IVsWindowFrame)window.Frame;
        Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(windowFrame.Show());

        // Get the tree view and populate it if there is a project open.
        ProjectPropertiesToolWindowControl control = (ProjectPropertiesToolWindowControl)window.Content;
        TreeView treeView = control.treeView;

        // Reset the TreeView to 0 items.
        treeView.Items.Clear();

        DTE dte = (DTE)this.ServiceProvider.GetService(typeof(DTE));
        Projects projects = dte.Solution.Projects;
        if (projects.Count == 0)   // no project is open
        {
            TreeViewItem item = new TreeViewItem();
            item.Name = "Projects";
            item.ItemsSource = new string[]{ "no projects are open." };
            item.IsExpanded = true;
            treeView.Items.Add(item);
            return;
        }

        Project project = projects.Item(1);
        TreeViewItem item1 = new TreeViewItem();
        item1.Header = project.Name + "Properties";
        treeView.Items.Add(item1);

        foreach (Property property in project.Properties)
        {
            TreeViewItem item = new TreeViewItem();
            item.ItemsSource = new string[] { property.Name };
            item.IsExpanded = true;
            treeView.Items.Add(item);
        }
    }
    ```

4. Build the project and start debugging. The experimental instance should appear.

5. In the experimental instance, open a project.

6. In the **View** > **Other Windows** click **ProjectPropertiesToolWindow**.

  You should see the tree control in the tool window together with the name of the first project and of all its project properties.
