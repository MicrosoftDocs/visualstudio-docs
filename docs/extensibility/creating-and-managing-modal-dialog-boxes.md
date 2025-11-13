---
title: Creating and Managing Modal Dialog Boxes
description: Create a modal dialog box in Visual Studio from DialogWindow and also without using DialogWindow and disable the parent window while the dialog box is open.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- dialog boxes, managing in Visual Studio
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create and manage modal dialog boxes

When you create a modal dialog box inside Visual Studio, you must make sure that the parent window of the dialog box is disabled while the dialog box is displayed, then re-enable the parent window after the dialog box is closed. If you do not do so, you may receive the error: *Microsoft Visual Studio cannot shut down because a modal dialog is active. Close the active dialog and try again.*

There are two ways of doing this. The recommended way, if you have a WPF dialog box, is to derive it from <xref:Microsoft.VisualStudio.PlatformUI.DialogWindow>, and then call <xref:Microsoft.VisualStudio.PlatformUI.DialogWindow.ShowModal%2A> to display the dialog box. If you do this, you do not need to manage the modal state of the parent window.

If your dialog box is not WPF, or for some other reason you cannot derive your dialog box class from <xref:Microsoft.VisualStudio.PlatformUI.DialogWindow>, then you must get the parent of the dialog box by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.GetDialogOwnerHwnd%2A> and manage the modal state yourself, by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.EnableModeless%2A> method with a parameter of 0 (false) before displaying the dialog box and calling the method again with a parameter of 1 (true) after closing the dialog box.

## Create a dialog box derived from DialogWindow

1. Create a VSIX project named **OpenDialogTest** and add a menu command named **OpenDialog**. For more information about how to do this, see [Create an extension with a menu command](../extensibility/creating-an-extension-with-a-menu-command.md).

2. To use the <xref:Microsoft.VisualStudio.PlatformUI.DialogWindow> class, you must add references to the following assemblies (in the Framework tab of the **Add Reference** dialog box):

    - *PresentationCore*

    - *PresentationFramework*

    - *WindowsBase*

    - *System.Xaml*

3. In *OpenDialog.cs*, add the following `using` statement:

    ```csharp
    using Microsoft.VisualStudio.PlatformUI;
    ```

4. Declare a class named `TestDialogWindow` that derives from <xref:Microsoft.VisualStudio.PlatformUI.DialogWindow>:

    ```csharp
    class TestDialogWindow : DialogWindow
    {. . .}
    ```

5. To be able to minimize and maximize the dialog box, set <xref:Microsoft.VisualStudio.PlatformUI.DialogWindowBase.HasMaximizeButton%2A> and <xref:Microsoft.VisualStudio.PlatformUI.DialogWindowBase.HasMinimizeButton%2A> to true:

    ```csharp
    internal TestDialogWindow()
    {
        this.HasMaximizeButton = true;
        this.HasMinimizeButton = true;
    }
    ```

6. In the `OpenDialog.ShowMessageBox` method, replace the existing code with the following:

    ```csharp
    TestDialogWindow testDialog = new TestDialogWindow();
    testDialog.ShowModal();
    ```

7. Build and run the application. The experimental instance of Visual Studio should appear. On the **Tools** menu of the experimental instance you should see a command named **Invoke OpenDialog**. When you click this command, you should see the dialog window. You should be able to minimize and maximize the window.

## Create and manage a dialog box not derived from DialogWindow

1. For this procedure, you can use the **OpenDialogTest** solution you created in the previous procedure, with the same assembly references.

2. Add the following `using` declarations:

    ```csharp
    using System.Windows;
    using Microsoft.Internal.VisualStudio.PlatformUI;
    ```

3. Create a class named `TestDialogWindow2` that derives from <xref:System.Windows.Window>:

    ```csharp
    class TestDialogWindow2 : Window
    {. . .}
    ```

4. Add a private reference to <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell>:

    ```
    private IVsUIShell shell;
    ```

5. Add a constructor that sets the reference to <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell>:

    ```csharp
    public TestDialogWindow2(IVsUIShell uiShell)
    {
        shell = uiShell;
    }
    ```

6. In the `OpenDialog.ShowMessageBox` method, replace the existing code with the following:

    ```csharp
    IVsUIShell uiShell = (IVsUIShell)ServiceProvider.GetService(typeof(SVsUIShell));

    TestDialogWindow2 testDialog2 = new TestDialogWindow2(uiShell);
    //get the owner of this dialog
    IntPtr hwnd;
    uiShell.GetDialogOwnerHwnd(out hwnd);
    testDialog2.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
    uiShell.EnableModeless(0);
    try
    {
        WindowHelper.ShowModal(testDialog2, hwnd);
    }
    finally
    {
        // This will take place after the window is closed.
        uiShell.EnableModeless(1);
    }
    ```

7. Build and run the application. On the **Tools** menu you should see a command named **Invoke OpenDialog**. When you click this command, you should see the dialog window.
