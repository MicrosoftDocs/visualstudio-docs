---
title: Creating an Extension with a VSPackage
description: Learn how to create a VSIX project and add a VSPackage project item using the VSPackage to get the UI Shell service in order to show a message box.
ms.date: 3/16/2019
ms.topic: how-to
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create an extension with a VSPackage

This walkthrough shows you how to create a VSIX project and add a VSPackage project item. We will use the VSPackage to get the UI Shell service in order to show a message box.

## Create a VSPackage

1. Create a VSIX project named **FirstPackage**. You can find the VSIX project template in the **New Project** dialog by searching for "vsix".

2. When the project opens, add a Visual Studio package item template named **FirstPackage**. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. In the **Add New Item** dialog, go to **Visual C#** > **Extensibility** and select **Visual Studio Package**. In the **Name** field at the bottom of the window, change the command file name to *FirstPackage.cs*.

3. Build the project and start debugging.

    The experimental instance of Visual Studio appears. For more information about the experimental instance, see [The experimental instance](../extensibility/the-experimental-instance.md).

4. In the experimental instance, open the **Tools** > **Extensions and Updates** window. You should see the **FirstPackage** extension here. (If you open **Extensions and Updates** in your working instance of Visual Studio, you won't see **FirstPackage**).

## Load the VSPackage

At this point, the extension does not load because there is nothing that causes it to load. You can generally load an extension when you interact with its UI (clicking a menu command, opening a tool window), or by specifying that the VSPackage should load in a specific UI context. For more information about loading VSPackages and UI contexts, see [Loading VSPackages](../extensibility/loading-vspackages.md). For this procedure, we'll show you how to load a VSPackage when a solution is open.

1. Open the *FirstPackage.cs* file. Look for the declaration of the `FirstPackage` class. Replace the existing attributes with the following attributes:

    ```csharp
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [ProvideAutoLoad(UIContextGuids80.SolutionExists)]
    [Guid(FirstPackage.PackageGuidString)]
    public sealed class FirstPackage : Package
    ```

2. Let's add a message that lets us know that the VSPackage has loaded. We use the VSPackage's `Initialize()` method to do this, because you can get Visual Studio services only after the VSPackage has been sited. (For more information about getting services, see [How to: Get a service](../extensibility/how-to-get-a-service.md).) Replace the `Initialize()` method of `FirstPackage` with code that gets the <xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell> service, gets the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell> interface, and calls its <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ShowMessageBox%2A> method.

    ```csharp
    protected override void Initialize()
    {
        base.Initialize();

        IVsUIShell uiShell = (IVsUIShell)GetService(typeof(SVsUIShell));
        Guid clsid = Guid.Empty;
        int result;
        Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(uiShell.ShowMessageBox(
            0,
            ref clsid,
            "FirstPackage",
             string.Format(CultureInfo.CurrentCulture, "Inside {0}.Initialize()", this.GetType().FullName),
            string.Empty,
            0,
            OLEMSGBUTTON.OLEMSGBUTTON_OK,
            OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST,
            OLEMSGICON.OLEMSGICON_INFO,
            0,
            out result));
    }
    ```

3. Build the project and start debugging. The experimental instance appears.

4. Open a solution in the experimental instance. You should see a message box that says **First Package Inside Initialize()**.
