---
title: Creating a Multi-Instance Tool Window
description: Learn how to modify a tool window so that multiple instances of it can be open simultaneously. By default, tool windows can have only one instance open.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- multi
- tool windows
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create a multi-instance tool window

You can program a tool window so that multiple instances of it can be open simultaneously. By default, tool windows can have only one instance open.

When you use a multi-instance tool window, you can show several related sources of information at the same time. For example, you could put a multi-line <xref:System.Windows.Forms.TextBox> control in a multi-instance tool window so that several code snippets are simultaneously available during a programming session. Also, for example, you could put a <xref:System.Windows.Forms.DataGrid> control and a drop-down list box in a multi-instance tool window so that several real-time data sources can be tracked simultaneously.

## Create a basic (single-instance) tool window

1. Create a project named **MultiInstanceToolWindow** using the VSIX template, and add a custom tool window item template named **MIToolWindow**.

    > [!NOTE]
    > For more information about creating an extension with a tool window, see [Create an extension with a tool window](../extensibility/creating-an-extension-with-a-tool-window.md).

## Make a tool window multi-instance

1. Open the *MIToolWindowPackage.cs* file and find the `ProvideToolWindow` attribute. and the `MultiInstances=true` parameter, as shown in the following example:

    ```csharp
    [PackageRegistration(UseManagedResourcesOnly = true)]
        [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
        [ProvideMenuResource("Menus.ctmenu", 1)]
        [ProvideToolWindow(typeof(MultiInstanceToolWindow.MIToolWindow), MultiInstances = true)]
        [Guid(MIToolWindowPackage.PackageGuidString)]
        public sealed class MIToolWindowPackage : Package
    {. . .}
    ```

2. In the *MIToolWindowCommand.cs* file, find the `ShowToolWindos()` method. In this method, call the <xref:Microsoft.VisualStudio.Shell.Package.FindToolWindow%2A> method and set its `create` flag to `false` so that it will iterate through existing tool window instances until an available `id` is found.

3. To create a tool window instance, call the <xref:Microsoft.VisualStudio.Shell.Package.FindToolWindow%2A> method and set its `id` to an available value and its `create` flag to `true`.

    By default, the value of the `id` parameter of the <xref:Microsoft.VisualStudio.Shell.Package.FindToolWindow%2A> method is `0`. This value makes a single-instance tool window. For more than one instance to be hosted, every instance must have its own unique `id`.

4. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.Show%2A> method on the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame> object that is returned by the <xref:Microsoft.VisualStudio.Shell.ToolWindowPane.Frame%2A> property of the tool window instance.

5. By default, the `ShowToolWindow` method that is created by the tool window item template creates a single-instance tool window. The following example shows how to modify the `ShowToolWindow` method to create multiple instances.

    ```csharp
    private void ShowToolWindow(object sender, EventArgs e)
    {
        for (int i = 0; i < 10; i++)
        {
            ToolWindowPane window = this.package.FindToolWindow(typeof(MIToolWindow), i, false);
            if (window == null)
            {
                // Create the window with the first free ID.
                window = (ToolWindowPane)this.package.FindToolWindow(typeof(MIToolWindow), i, true);
                if ((null == window) || (null == window.Frame))
                {
                    throw new NotSupportedException("Cannot create tool window");
                }

            IVsWindowFrame windowFrame = (IVsWindowFrame)window.Frame;
            Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(windowFrame.Show());
            break;
            }
        }
    }
    ```
