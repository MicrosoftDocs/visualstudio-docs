---
title: "How to: Troubleshoot Services | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "services, troubleshooting"
ms.assetid: 001551da-4847-4f59-a0b2-fcd327d7f5ca
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# How to: Troubleshoot services
There are several common problems that can occur when you try to get a service:

- The service is not registered with [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].

- The service is requested by interface type and not by service type.

- The VSPackage requesting the service has not been sited.

- The wrong service provider is used.

  If the requested service cannot be obtained, the call to <xref:Microsoft.VisualStudio.Shell.Package.GetService%2A> returns null. You should always test for null after requesting a service:

```csharp
IVsActivityLog log =
    GetService(typeof(SVsActivityLog)) as IVsActivityLog;
if (log == null) return;
```

## To troubleshoot a service

1. Examine the system registry to see whether the service has been correctly registered. For more information, see [How to: Provide a service](../extensibility/how-to-provide-a-service.md).

    The following *.reg* file fragment shows how the SVsTextManager service might be registered:

   ```
   [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\<version number>\Services\{F5E7E71D-1401-11d1-883B-0000F87579D2}]
   @="{F5E7E720-1401-11d1-883B-0000F87579D2}"
   "Name"="SVsTextManager"
   ```

    In the example above, version number is the version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], such as 12.0 or 14.0, the key {F5E7E71D-1401-11d1-883B-0000F87579D2} is the service identifier (SID) of the service, SVsTextManager, and the default value {F5E7E720-1401-11d1-883B-0000F87579D2} is the package GUID of the text manager VSPackage, which provides the service.

2. Use the service type and not the interface type when you call GetService. When requesting a service from [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], <xref:Microsoft.VisualStudio.Shell.Package> extracts the GUID from the type. A service will not be found if the following conditions exist:

   1. An interface type is passed to GetService instead of the service type.

   2. No GUID is explicitly assigned to the interface. Therefore, the system creates a default GUID for an object as needed.

3. Be sure the VSPackage requesting the service has been sited. [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] sites a VSPackage after constructing it and before calling <xref:Microsoft.VisualStudio.Shell.Package.Initialize%2A>.

    If you have code in a VSPackage constructor that needs a service, move it to the `Initialize` method.

4. Be sure that you are using the correct service provider.

    Not all service providers are alike. The service provider that [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] passes to a tool window differs from the one it passes to a VSPackage. The tool window service provider knows about <xref:Microsoft.VisualStudio.Shell.Interop.STrackSelection>, but does not know about <xref:Microsoft.VisualStudio.Shell.Interop.SVsRunningDocumentTable>. You can call <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> to get a VSPackage service provider from within a tool window.

    If a tool window hosts a user control or any other control container, the container will be sited by the Windows component model and will not have access to any [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] services. You can call <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> to get a VSPackage service provider from within a control container.

## See also
- [List of available services](../extensibility/internals/list-of-available-services.md)
- [Use and provide services](../extensibility/using-and-providing-services.md)
- [Service essentials](../extensibility/internals/service-essentials.md)