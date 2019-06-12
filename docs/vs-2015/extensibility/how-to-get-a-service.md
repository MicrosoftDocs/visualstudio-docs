---
title: "How to: Get a Service | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "services, consuming"
ms.assetid: 1f000020-8fb7-4e39-8e1e-2e38c7fec3d4
caps.latest.revision: 21
ms.author: gregvanl
manager: jillfra
---
# How to: Get a Service
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You often need to get Visual Studio services to access different features. In general, a Visual Studio service provides one or more interfaces that you can use. You can get most services from a VSPackage.  
  
 Any VSPackage that derives from <xref:Microsoft.VisualStudio.Shell.Package> and that has been correctly sited can ask for any global service. Because the Package class implements <xref:System.IServiceProvider>, any VSPackage that derives from Package is also a service provider.  
  
 When Visual Studio loads a <xref:Microsoft.VisualStudio.Shell.Package>, it passes an <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider> object to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.SetSite%2A> method during initialization. This is called *siting* the VSPackage. The Package class wraps this service provider and provides the <xref:Microsoft.VisualStudio.Shell.Package.GetService%2A> method for getting services.  
  
## Getting a service from an initialized VSPackage  
  
1. Every Visual Studio extension starts with a VSIX deployment project which will contain the extension assets. Create a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] VSIX project named `GetServiceExtension`. You can find the VSIX project template in the **New Project** dialog under **Visual C# / Extensibility**.  
  
2. Now add a custom command item template named **GetServiceCommand**. In the **Add New Item** dialog, go to **Visual C# / Extensibility** and select **Custom Command**. In the **Name** field at the bottom of the window, change the command file name to **GetServiceCommand.cs**. For more information about how to create a custom command, [Creating an Extension with a Menu Command](../extensibility/creating-an-extension-with-a-menu-command.md)  
  
3. In GetServiceCommand.cs, remove the body of the MenuItemCommand method and add the following code:  
  
    ```csharp  
    IVsActivityLog activityLog = ServiceProvider.GetService(typeof(SVsActivityLog)) as IVsActivityLog;  
    if (activityLog == null) return;  
    System.Windows.Forms.MessageBox.Show("Found the activity log service.");  
  
    ```  
  
     This code gets an SVsActivityLog service and casts it to an <xref:Microsoft.VisualStudio.Shell.Interop.IVsActivityLog> interface, which can be used to write to the activity log. For an example, see [How to: Use the Activity Log](../extensibility/how-to-use-the-activity-log.md).  
  
4. Build the project and start debugging. The experimental instance appears.  
  
5. On the Tools menu of the experimental instance, find the **Invoke GetServiceCommand** button. When you click this button, you should see a message box that says **Found the activity log service.**  
  
## Getting a service from a tool window or control container  
 Sometimes you may need to get a service from a tool window or control container that has not been sited, or else has been sited with a service provider that does not know about the service you want. For example, you might want to write to the activity log from within a control.  
  
 The static <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> method relies on a cached service provider that is initialized the first time any VSPackage derived from <xref:Microsoft.VisualStudio.Shell.Package> is sited.  
  
 Because the VSPackage constructor is called before the VSPackage is sited, global services are typically unavailable from within the VSPackage constructor. See [How to: Troubleshoot Services](../extensibility/how-to-troubleshoot-services.md) for a workaround.  
  
 Here’s an example of the way to get a service in a tool window or other non-VSPackage element.  
  
```csharp  
IVsActivityLog log = Package.GetGlobalService(typeof(SVsActivityLog)) as IVsActivityLog;  
if (log == null) return;  
```  
  
## Getting a service from the DTE object  
 You can also get services from <xref:EnvDTE.DTEClass> object. However, you must get the DTE object as a service from a VSPackage or by calling the static <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> method.  
  
 The DTE object implements <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider>, which you can use to query for a service by using <xref:Microsoft.VisualStudio.Shell.ServiceProvider.GetService%2A>.  
  
 Here’s how to get a service from the DTE object.  
  
```csharp  
// Start with the DTE object, for example:   
// using EnvDTE;  
// DTE dte = (DTE)GetService(typeof(DTE));  
  
ServiceProvider sp = new ServiceProvider((Microsoft.VisualStudio.OLE.Interop.IServiceProvider)dte);  
if (sp != null)  
{  
    IVsActivityLog log = sp.GetService(typeof(SVsActivityLog)) as IVsActivityLog;  
    if (log != null)  
    {   
        System.Windows.Forms.MessageBox.Show("Found the activity log service.");  
    }  
}  
```  
  
## See Also  
 [How to: Provide a Service](../extensibility/how-to-provide-a-service.md)   
 [Using and Providing Services](../extensibility/using-and-providing-services.md)   
 [Service Essentials](../extensibility/internals/service-essentials.md)
