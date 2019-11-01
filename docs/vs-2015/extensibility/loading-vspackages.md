---
title: "Loading VSPackages | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "VSPackages, autoloading"
  - "VSPackages, loading"
ms.assetid: f4c3dcea-5051-4065-898f-601269649d92
caps.latest.revision: 18
ms.author: gregvanl
manager: jillfra
---
# Loading VSPackages
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

VSPackages are loaded into Visual Studio only when their functionality is required. For example, a VSPackage is loaded when Visual Studio uses a project factory or a service that the VSPackage implements. This feature is called delayed loading, which is used whenever possible to improve performance.  
  
> [!NOTE]
> Visual Studio can determine certain VSPackage information, such as the commands that a VSPackage offers, without loading the VSPackage.  
  
 VSPackages can be set to autoload in a particular user interface (UI) context, for example, when a solution is open. The <xref:Microsoft.VisualStudio.Shell.ProvideAutoLoadAttribute> attribute sets this context.  
  
### Autoloading a VSPackage in a specific context  
  
- Add the `ProvideAutoLoad` attribute to the VSPackage attributes:  
  
    ```csharp  
    [DefaultRegistryRoot(@"Software\Microsoft\VisualStudio\14.0")]  
    [PackageRegistration(UseManagedResourcesOnly = true)]  
    [ProvideAutoLoad(UIContextGuids80.SolutionExists)]  
    [Guid("00000000-0000-0000-0000-000000000000")] // your specific package GUID  
    public class MyAutoloadedPackage : Package  
    {. . .}  
    ```  
  
     See the enumerated fields of <xref:Microsoft.VisualStudio.Shell.Interop.UIContextGuids80> for a list of the UI contexts and their GUID values.  
  
- Set a breakpoint in the <xref:Microsoft.VisualStudio.Shell.Package.Initialize%2A> method.  
  
- Build the VSPackage and start debugging.  
  
- Load a solution or create one.  
  
     The VSPackage loads and stops at the breakpoint.  
  
## Forcing a VSPackage to load  
 Under some circumstances a VSPackage may have to force another VSPackage to be loaded. For example, a lightweight VSPackage might load a larger VSPackage in a context that is not available as a CMDUIContext.  
  
 You can use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsShell.LoadPackage%2A> method to force a VSPackage to load.  
  
- Insert this code into the <xref:Microsoft.VisualStudio.Shell.Package.Initialize%2A> method of the VSPackage that forces another VSPackage to load:  
  
    ```csharp  
    IVsShell shell = GetService(typeof(SVsShell)) as IVsShell;  
    if (shell == null) return;  
  
    IVsPackage package = null;  
    Guid PackageToBeLoadedGuid =   
        new Guid(Microsoft.PackageToBeLoaded.GuidList.guidPackageToBeLoadedPkgString);  
    shell.LoadPackage(ref PackageToBeLoadedGuid, out package);  
  
    ```  
  
     When the VSPackage is initialized, it will force `PackageToBeLoaded` to load.  
  
     Force loading should not be used for VSPackage communication. Use [Using and Providing Services](../extensibility/using-and-providing-services.md) instead.  
  
## Using a custom attribute to register a VSPackage  
 In certain cases you may need to create a new registration attribute for your extension. You can use registration attributes to add new registry keys or to add new values to existing keys. The new attribute must derive from <xref:Microsoft.VisualStudio.Shell.RegistrationAttribute>, and it must override the <xref:Microsoft.VisualStudio.Shell.RegistrationAttribute.Register%2A> and <xref:Microsoft.VisualStudio.Shell.RegistrationAttribute.Unregister%2A> methods.  
  
## Creating a Registry Key  
 In the following code, the custom attribute creates a **Custom** subkey under the key for the VSPackage that is being registered.  
  
```csharp  
public override void Register(RegistrationAttribute.RegistrationContext context)  
{  
    Key packageKey = null;  
    try  
    {   
        packageKey = context.CreateKey(@"Packages\{" + context.ComponentType.GUID + @"}\Custom");  
        packageKey.SetValue("NewCustom", 1);  
    }  
    finally  
    {  
        if (packageKey != null)  
            packageKey.Close();  
    }  
}  
  
public override void Unregister(RegistrationContext context)  
{  
    context.RemoveKey(@"Packages\" + context.ComponentType.GUID + @"}\Custom");  
}  
  
```  
  
## Creating a New Value Under an Existing Registry Key  
 You can add custom values to an existing key. The following code shows how to add a new value to a VSPackage registration key.  
  
```csharp  
public override void Register(RegistrationAttribute.RegistrationContext context)  
{  
    Key packageKey = null;  
    try  
    {   
        packageKey = context.CreateKey(@"Packages\{" + context.ComponentType.GUID + "}");  
        packageKey.SetValue("NewCustom", 1);  
    }  
    finally  
    {  
        if (packageKey != null)  
            packageKey.Close();  
                }  
}  
  
public override void Unregister(RegistrationContext context)  
{  
    context.RemoveValue(@"Packages\" + context.ComponentType.GUID, "NewCustom");  
}  
```  
  
## See Also  
 [VSPackages](../extensibility/internals/vspackages.md)
