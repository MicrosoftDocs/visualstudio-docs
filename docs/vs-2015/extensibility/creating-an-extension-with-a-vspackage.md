---
title: "Creating an Extension with a VSPackage | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
ms.assetid: c0cc5e08-4897-44f2-8309-e3478f1f999e
caps.latest.revision: 6
ms.author: gregvanl
manager: jillfra
---
# Creating an Extension with a VSPackage
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This walkthrough shows you how to create a VSIX project and add a VSPackage project item. We will use the VSPackage to get the UI Shell service in order to show a message box.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).  
  
## Creating a VSPackage  
  
1. Create a VSIX project named **FirstPackage**. You can find the VSIX project template in the **New Project** dialog under **Visual C# / Extensibility**.  
  
2. When the project opens, add a Visual Studio package item template named **FirstPackage**. In the **Solution Explorer**, right-click the project node and select **Add / New Item**. In the **Add New Item** dialog, go to **Visual C# / Extensibility** and select **Visual Studio Package**. In the **Name** field at the bottom of the window, change the command file name to **FirstPackage.cs**.  
  
3. Build the project and start debugging.  
  
     The experimental instance of Visual Studio appears. For more information about the experimental instance, see [The Experimental Instance](../extensibility/the-experimental-instance.md).  
  
4. In the experimental instance, open the **Tools / Extensions and Updates** window. You should see the **FirstPackage** extension here. (If you open **Extensions and Updates** in your working instance of Visual Studio, you won’t see **FirstPackage**).  
  
## Loading the VSPackage  
 At this point the extension does not load, because there is nothing that causes it to load. You can generally load an extension when you interact with its UI (clicking a menu command, opening a tool window), or by specifying that the VSPackage should load in a specific UI context. For more information about loading VSPackages and UI contexts, see [Loading VSPackages](../extensibility/loading-vspackages.md). For this procedure, we’ll show you how to load a VSPackage when a solution is open.  
  
1. Open the FirstPackage.cs file. Look for the declaration of the FirstPackage class. Replace the existing attributes with following:  
  
    ```csharp  
    [PackageRegistration(UseManagedResourcesOnly = true)]  
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About  
    [ProvideAutoLoad(UIContextGuids80.SolutionExists)]  
    [Guid(FirstPackageGuids.PackageGuidString)]  
    public sealed class FirstPackage : Package  
    ```  
  
2. Let’s add a message that lets us know that the VSPackage has loaded. We use the VSPackage’s Initialize() method to do this, because you can get Visual Studio services only after the VSPackage has been sited. (For more information about getting services, see [How to: Get a Service](../extensibility/how-to-get-a-service.md).) Replace the Initialize() method of FirstPackage with code that gets the <xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell> service, gets the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell> interface, and calls its <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ShowMessageBox%2A> method.  
  
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
