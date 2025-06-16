---
title: 'Provide a Service'
description: A VSPackage can provide services that other VSPackages can use. Learn how a VSPackage registers a service with Visual Studio and adds the service.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- services, providing
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Provide a service

A VSPackage can provide services that other VSPackages can use. To provide a service, a VSPackage must register the service with Visual Studio and add the service.

 The <xref:Microsoft.VisualStudio.Shell.Package> class implements both <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider> and <xref:System.ComponentModel.Design.IServiceContainer>. <xref:System.ComponentModel.Design.IServiceContainer> contains callback methods that provide  services on demand.

 For more information about services, see [Service essentials](../extensibility/internals/service-essentials.md) .

> [!NOTE]
> When a VSPackage is about to be unloaded, Visual Studio waits until all requests for services that a VSPackage provides have been delivered. It does not allow new requests for these services. You should not explicitly call the <xref:Microsoft.VisualStudio.Shell.Interop.IProfferService.RevokeService%2A> method to revoke a service when unloading.

## Implement a service

1. Create a VSIX project (**File** > **New** > **Project** > **Visual C#** > **Extensibility** > **VSIX Project**).

2. Add a VSPackage to the project. Select the project node in the **Solution Explorer** and click **Add** > **New item** > **Visual C# Items** > **Extensibility** > **Visual Studio Package**.

3. To implement a service, you need to create three types:

   - An interface that describes the service. Many of these interfaces are empty, that is, they have no methods.

   - An interface that describes the service interface. This interface includes the methods to be implemented.

   - A class that implements both the service and the service interface.

     The following example shows a basic implementation of the three types. The constructor of the service class must set the service provider.

   ```csharp
   public class MyService : SMyService, IMyService
   {
       private Microsoft.VisualStudio.OLE.Interop.IServiceProvider serviceProvider;
       private string myString;
       public MyService(Microsoft.VisualStudio.OLE.Interop.IServiceProvider sp)
       {
           Trace.WriteLine(
                  "Constructing a new instance of MyService");
           serviceProvider = sp;
       }
       public void Hello()
       {
           myString = "hello";
       }
       public string Goodbye()
       {
          return "goodbye";
       }
   }
   public interface SMyService
   {
   }
   public interface IMyService
   {
       void Hello();
       string Goodbye();
   }

   ```

### Register a service

1. To register a service, add the <xref:Microsoft.VisualStudio.Shell.ProvideServiceAttribute> to the VSPackage that provides the service. Here is an example:

    ```csharp
    [ProvideService(typeof(SMyService))]
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [Guid(VSPackage1.PackageGuidString)]
    public sealed class VSPackage1 : Package
    {. . . }
    ```

     This attribute registers `SMyService` with Visual Studio.

    > [!NOTE]
    > To register a service that replaces another service with the same name, use the <xref:Microsoft.VisualStudio.Shell.ProvideServiceOverrideAttribute>. Note that only one override of a service is allowed.

### Add a service

1. In the VSPackage initializer, add the service and add a callback method to create the services. Here is the change to make to the <xref:Microsoft.VisualStudio.Shell.Package.Initialize%2A> method:

    ```csharp
    protected override void Initialize()
    {
        ServiceCreatorCallback callback =new ServiceCreatorCallback(CreateService);

        ((IServiceContainer)this).AddService(typeof(SMyService), callback);
    . . .
    }
    ```

2. Implement the callback method, which should create and return the service, or null if it cannot be created.

    ```csharp
    private object CreateService(IServiceContainer container, Type serviceType)
    {
        if (typeof(SMyService) == serviceType)
            return new MyService(this);
        return null;
    }
    ```

    > [!NOTE]
    > Visual Studio can reject a request to provide a service. It does so if another VSPackage already provides the service.

3. Now you can get the service and use its methods. The example below shows using the service in the initializer, but you can get the service anywhere you want to use the service.

    ```csharp
    protected override void Initialize()
    {
        ServiceCreatorCallback callback =new ServiceCreatorCallback(CreateService);

        ((IServiceContainer)this).AddService(typeof(SMyService), callback);

        MyService myService = (MyService) this.GetService(typeof(SMyService));
        myService.Hello();
        string helloString = myService.Goodbye();

        base.Initialize();
    }
    ```

     The value of `helloString` should be "Hello".

## Related content
- [How to: Get a service](../extensibility/how-to-get-a-service.md)
- [Use and provide services](../extensibility/using-and-providing-services.md)
- [Service essentials](../extensibility/internals/service-essentials.md)
