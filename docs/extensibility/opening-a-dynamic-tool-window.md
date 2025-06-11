---
title: Opening a Dynamic Tool Window
description: Learn about dynamic tool windows, which opens whenever a specific UI context applies and closes when the UI context no longer applies.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- tool windows, dynamic
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Open a dynamic tool window

Tool windows are typically opened from a command on a menu, or an equivalent keyboard shortcut. At times, however, you might need a tool window that opens whenever a specific UI context applies, and closes when the UI context no longer applies. These types of tool windows are called *dynamic* or *auto-visible*.

> [!NOTE]
> For a list of predefined UI contexts, see <xref:Microsoft.VisualStudio.VSConstants.UICONTEXT>.

 If you want to open a dynamic tool window at startup, and it is possible for the creation to fail, you must implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackageDynamicToolOwnerEx> interface and test the failure conditions in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackageDynamicToolOwnerEx.QueryShowTool%2A> method. In order for the shell to know that you have a dynamic tool window that should be opened at startup, you must add the `SupportsDynamicToolOwner` value (set to 1) to your package registration. This value is not part of the standard <xref:Microsoft.VisualStudio.Shell.PackageRegistrationAttribute>, so you must create a custom attribute to add it. For more information about custom attributes, see [Use a custom registration attribute to register an extension](../extensibility/registering-and-unregistering-vspackages.md#using-a-custom-registration-attribute-to-register-an-extension).

 Use <xref:Microsoft.VisualStudio.Shell.Package.FindToolWindow%2A> to open a tool window. The tool window is created as needed.

> [!NOTE]
> A dynamic tool window can be closed by the user. If you want to create a menu command so the user can reopen the tool window, the menu command should be enabled in the same UI context that opens the tool window, and disabled otherwise.

## To open a dynamic tool window

1. Create a VSIX project named **DynamicToolWindow** and add a tool window item template named *DynamicWindowPane.cs*. For more information, see [Create an extension with a tool window](../extensibility/creating-an-extension-with-a-tool-window.md).

2. In the *DynamicWindowPanePackage.cs* file, find the DynamicWindowPanePackage declaration. Add the <xref:Microsoft.VisualStudio.Shell.ProvideToolWindowAttribute> and <xref:Microsoft.VisualStudio.Shell.ProvideToolWindowVisibilityAttribute> attributes to register the tool window.

    ```vb
    [ProvideToolWindow(typeof(DynamicWindowPane)]
    [ProvideToolWindowVisibility(typeof(DynamicWindowPane), VSConstants.UICONTEXT.SolutionExists_string)]
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [ProvideToolWindow(typeof(DynamicToolWindow.DynamicWindowPane))]
    [Guid(DynamicWindowPanePackage.PackageGuidString)]
    public sealed class DynamicWindowPanePackage : Package
    {. . .}
    ```

     The attributes above register the tool window named DynamicWindowPane as a transient window that is not persisted when Visual Studio is closed and reopened. DynamicWindowPane is opened whenever <xref:Microsoft.VisualStudio.VSConstants.UICONTEXT.SolutionExists_string> applies, and closed otherwise.

3. Build the project and start debugging. The experimental instance should appear. You should not see the tool window.

4. Open a project in the experimental instance. The tool window should appear.
