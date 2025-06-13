---
title: Service Essentials
description: Learn about services, which are interfaces for another VSPackage to consume. Services in a VSPackage can override built-in or other services.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- services, essentials
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Service Essentials

A service is a contract between two VSPackages. One VSPackage provides a specific set of interfaces for another VSPackage to consume. Visual Studio is itself a collection of VSPackages that provides services to other VSPackages.

 For example, you can use the SVsActivityLog service to obtain an IVsActivityLog interface, which you can use to write to the activity log. For more information, see [How to: Use the Activity Log](../../extensibility/how-to-use-the-activity-log.md).

 Visual Studio also provides some built-in services which are not registered. VSPackages can replace built-in or other services by providing a service override. Only one service override is permitted for any service.

 Services have no discoverability. Therefore, you must know the service identifier (SID) of a service that you want to consume, and you must know which interfaces it provides. The reference documentation for the service provides this information.

- VSPackages that provide services are called service providers.

- Services that are provided to other VSPackages are called global services.

- Services that are available only to the VSPackage that implements them, or to any object it creates, are called local services.

- Services that replace built-in services or services provided by other packages, are called service overrides.

- Services, or service overrides, are loaded on demand, that is, the service provider is loaded when the service it provides is requested by another VSPackage.

- To support on-demand loading, a service provider registers its global services with Visual Studio. For more information, see [How to: Provide a Service](../../extensibility/how-to-provide-a-service.md).

- After you obtain a service, use [QueryInterface](/cpp/atl/queryinterface) (unmanaged code) or casting (managed code) to get the desired interface, for example:

  ### [C#](#tab/csharp)
  ```csharp
  GetService(typeof(SVsActivityLog)) as IVsActivityLog;
  ```

  ### [VB](#tab/vb)
  ```vb
  TryCast(GetService(GetType(SVsActivityLog)), IVsActivityLog)
  ```
  ---

- Managed code refers to a service by its type, whereas unmanaged code refers to a service by its GUID.

- When Visual Studio loads a VSPackage, it passes a service provider to the VSPackage to give the VSPackage access to global services. This is referred to as "siting" the VSPackage.

- VSPackages can be service providers for the objects they create. For example, a form might send a request for a color service to its frame, which might pass the request to Visual Studio.

- Managed objects that are deeply nested, or not sited at all, may call <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> for direct access to global services.

<a name="how-to-use-getglobalservice"></a>

## Use GetGlobalService

Sometimes you may need to get a service from a tool window or control container that has not been sited, or else has been sited with a service provider that does not know about the service you want. For example, you might want to write to the activity log from within a control. For more information about these and other scenarios, see [How to: Troubleshoot Services](../../extensibility/how-to-troubleshoot-services.md).

You can get most Visual Studio services by calling the static <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> method.

<xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> relies on a cached service provider that is initialized the first time any VSPackage derived from Package is sited. You must guarantee that this condition is met, or else be prepared for a null service.

Fortunately, <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> works correctly most of the time.

- If a VSPackage provides a service known only to another VSPackage, the VSPackage requesting the service is sited before the VSPackage providing the service is loaded.

- If a tool window is created by a VSPackage, the VSPackage is sited before the tool window is created.

- If a control container is hosted by a tool window created by a VSPackage, the VSPackage is sited before the control container is created.

### To get a service from within a tool window or control container

- Insert this code in the constructor, tool window, or control container:

    ### [C#](#tab/csharp)
    ```csharp
    IVsActivityLog log = Package.GetGlobalService(typeof(SVsActivityLog)) as IVsActivityLog;
        if (log == null) return;
    ```

    ### [VB](#tab/vb)
    ```vb
    Dim log As IVsActivityLog = TryCast(Package.GetGlobalService(GetType(SVsActivityLog)), IVsActivityLog)
    If log Is Nothing Then
        Return
    End If
    ```
    ---

    This code obtains an SVsActivityLog service and casts it to an IVsActivityLog interface, which can be used to write to the activity log. For an example, see [How to: Use the Activity Log](../../extensibility/how-to-use-the-activity-log.md).

## Related content

- [List of Available Services](../../extensibility/internals/list-of-available-services.md)
- [Using and Providing Services](../../extensibility/using-and-providing-services.md)
- [Casting and Type Conversions](/dotnet/csharp/programming-guide/types/casting-and-type-conversions)
- [Casting](/cpp/cpp/casting)
