---
title: "How to: Provide an Asynchronous Service | Microsoft Docs"
ms.date: 11/15/2016
ms.topic: conceptual
ms.assetid: 0448274c-d3d2-4e12-9d11-8aca78a1f3f5
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# How to: Provide an Asynchronous Visual Studio Service
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If you want to obtain a service without blocking the UI thread, you should create an asynchronous service and load the package on a background thread. For this purpose you can use an <xref:Microsoft.VisualStudio.Shell.AsyncPackage> rather than a <xref:Microsoft.VisualStudio.Shell.Package>, and add the service with the asynchronous package’s special asynchronous methods

 For information about providing synchronous Visual Studio services, see [How to: Provide a Service](../extensibility/how-to-provide-a-service.md).

## Implementing an Asynchronous Service

1. Create a VSIX project (**File / New / Project / Visual C# / Extensiblity / VSIX Project**). Name the project **TestAsync**.

2. Add a VSPackage to the project. Select the project node in the **Solution Explorer** and click **Add / New item / Visual C# Items / Extensibility / Visual Studio Package**. Name this file **TestAsyncPackage.cs**.

3. In TestAsyncPackage.cs, change the package to inherit from AsyncPackage rather than Package:

    ```csharp
    public sealed class TestAsyncPackage : AsyncPackage
    ```

4. To implement a service, you need to create three types:

    - An interface that describes the service. Many of these interfaces are empty, that is, they have no methods.

    - An interface that describes the service interface. This interface includes the methods to be implemented.

    - A class that implements both the service and the service interface.

5. The following example shows a very basic implementation of the three types. The constructor of the service class must set the service provider. In this example we’ll just add the service to the package code file.

6. Add the following using statements to the package file:

    ```csharp
    using System.Threading;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;
    using System.IO;
    ```

7. Here’s the asynchronous service implementation. Note that you need to set the asynchronous service provider rather than the synchronous service provider in the constructor:

    ```
    public class TextWriterService : STextWriterService, ITextWriterService
    {
        private Microsoft.VisualStudio.Shell.IAsyncServiceProvider serviceProvider;
        public TextWriterService(Microsoft.VisualStudio.Shell.IAsyncServiceProvider provider)
        {
            serviceProvider = provider;
        }
        public async System.Threading.Tasks.Task WriteLineAsync(string path, string line)
        {
            StreamWriter writer = new StreamWriter(path);
            await writer.WriteLineAsync(line);
            writer.Close();
        }
        public TaskAwaiter GetAwaiter()
        {
            return new TaskAwaiter();
        }
    }
    public interface STextWriterService
    {
    }
    public interface ITextWriterService
    {
        System.Threading.Tasks.Task WriteLineAsync(string path, string line);
        TaskAwaiter GetAwaiter();
    }
    ```

## Registering a Service
 To register a service, add the <xref:Microsoft.VisualStudio.Shell.ProvideServiceAttribute> to the package that provides the service. There are two differences from registering a synchronous service:

- If you are autoloading the package, you must add the <xref:Microsoft.VisualStudio.Shell.PackageAutoLoadFlags> BackgroundLoad value to the attribute. For more information about autoloading VSPackages, see [Loading VSPackages](../extensibility/loading-vspackages.md).

- You must add the **AllowsBackgroundLoading = true** field to the <xref:Microsoft.VisualStudio.Shell.PackageRegistrationAttribute>. For more information about the PackageRegistrationAttribute, see [Registering and Unregistering VSPackages](../extensibility/registering-and-unregistering-vspackages.md).

  Here is an example of an AsyncPackage with an asynchronous service registration::

```csharp
[ProvideService((typeof(STextWriterService)), IsAsyncQueryable = true)]
[ProvideAutoLoad(UIContextGuids80.SolutionExists, PackageAutoLoadFlags.BackgroundLoad)]
[PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
[Guid(TestAsyncPackage.PackageGuidString)]
public sealed class TestAsyncPackage : AsyncPackage
{. . . }
```

## Adding a service

1. In TestAsyncPackage.cs, remove the `Initialize()` method and override the `InitializeAsync()` method. Add the service, and add a callback method to create the services. Here is an example of the asynchronous initializer adding a service:

    ```
    protected override async System.Threading.Tasks.Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
        this.AddService(typeof(STextWriterService), CreateService);

        await base.InitializeAsync(cancellationToken, progress);
    }

    ```

2. Add a reference to Microsoft.VisualStudio.Shell.Interop.14.0.DesignTime.dll.

3. Implement the callback method as an asynchronous method that creates and returns the service.

    ```csharp
    public async System.Threading.Tasks.Task<object> CreateService(IAsyncServiceContainer container, CancellationToken cancellationToken, Type serviceType)
    {
        STextWriterService service = null;
        await System.Threading.Tasks.Task.Run(() => {
                    service = new TextWriterService(this);
             });

        return service;
    }

    ```

## Using a Service
 Now you can get the service and use its methods.

1. We’ll show this in the initializer, but you can get the service anywhere you want to use the service.

    ```csharp
    protected override async System.Threading.Tasks.Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
        this.AddService(typeof(STextWriterService), CreateService);

        ITextWriterService textService = await this.GetServiceAsync(typeof(STextWriterService)) as ITextWriterService;

        await writer.WriteLineAsync(<userpath>), "this is a test");

        await base.InitializeAsync(cancellationToken, progress);
    }

    ```

     Don’t forget to change *\<userpath>* to a filename and path that makes sense on your machine!

2. Build and run the code. When the experimental instance of Visual Studio appears, open a solution. This causes the AsyncPackage to autoload. When the initializer has run, you should find a file in the location you specified.

## Using an Asynchronous Service in a Command Handler
 Here’s an example of how to use an asynchronous service in a menu command. You can use the procedure shown here to use the service in other non-asynchronous methods.

1. Add a menu command to your project. (In the **Solution Explorer**, select the project node, right-click, and select **Add / New Item / Extensibility / Custom Command**.) Name the command file **TestAsyncCommand.cs.**

2. The custom command template re-adds the `Initialize()` method to the TestAsyncPackage.cs file in order to initialize the command. In the Initialize() method, copy the line that initializes the command. It should look like this:

    ```
    TestAsyncCommand.Initialize(this);
    ```

     Move this line to the `InitializeAsync()` method in the AsyncPackageForService.cs file. Since this is in an asynchronous initialization, you must switch to the main thread before you initialize the command using <xref:Microsoft.VisualStudio.Threading.JoinableTaskFactory.SwitchToMainThreadAsync%2A>. It should now look like this:

    ```csharp

    protected override async System.Threading.Tasks.Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
        await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
        TestAsyncCommand.Initialize(this);

        this.AddService(typeof(STextWriterService), CreateService);

        ITextWriterService textService =
           await this.GetServiceAsync(typeof(STextWriterService)) as ITextWriterService;

        await writer.WriteLineAsync((<userpath>, "this is a test");

        await base.InitializeAsync(cancellationToken, progress);
    }

    ```

3. Delete the `Initialize()` method.

4. In the TestAsyncCommand.cs file, find the `MenuItemCallback()` method. Delete the body of the method.

5. Add a using statement:

    ```
    using System.IO;
    ```

6. Add an asynchronous method named `GetAsyncService()`, which gets the service and uses its methods:

    ```csharp
    private async System.Threading.Tasks.Task GetAsyncService()
    {
        ITextWriterService textService =
           this.ServiceProvider.GetService(typeof(STextWriterService))
              as ITextWriterService;
        // don’t forget to change <userpath> to a local path
        await writer.WriteLineAsync((<userpath>),"this is a test");
       }

    ```

7. Call this method from the `MenuItemCallback()` method:

    ```
    private void MenuItemCallback(object sender, EventArgs e)
    {
        GetAsyncService();
    }

    ```

8. Build the solution and start debugging. When the experimental instance of Visual Studio appears, go to the **Tools** menu and look for the **Invoke TestAsyncCommand** menu item. When you click it, the TextWriterService writes to the file you specified. (You don’t need to open a solution, because invoking the command also causes the package to load.)

## See Also
 [Using and Providing Services](../extensibility/using-and-providing-services.md)
