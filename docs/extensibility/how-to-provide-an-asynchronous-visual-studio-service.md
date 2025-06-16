---
title: 'Provide an Asynchronous Visual Studio Service'
description: Learn how to provide an asynchronous Visual Studio service. This approach allows you to obtain a service without blocking the UI thread.
ms.date: 11/04/2016
ms.topic: how-to
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Provide an asynchronous Visual Studio service

If you want to obtain a service without blocking the UI thread, you should create an asynchronous service and load the package on a background thread. For this purpose you can use an <xref:Microsoft.VisualStudio.Shell.AsyncPackage> rather than a <xref:Microsoft.VisualStudio.Shell.Package>, and add the service with the asynchronous package's special asynchronous methods.

 For information about providing synchronous Visual Studio services, see [How to: Provide a service](../extensibility/how-to-provide-a-service.md).

## Implement an asynchronous service

1. Create a VSIX project (**File** > **New** > **Project** > **Visual C#** > **Extensiblity** > **VSIX Project**). Name the project **TestAsync**.

2. Add a VSPackage to the project. Select the project node in the **Solution Explorer** and click **Add** > **New item** > **Visual C# Items** > **Extensibility** > **Visual Studio Package**. Name this file *TestAsyncPackage.cs*.

3. In *TestAsyncPackage.cs*, change the package to inherit from `AsyncPackage` rather than `Package`:

    ```csharp
    public sealed class TestAsyncPackage : AsyncPackage
    ```

4. To implement a service, you need to create three types:

    - An interface that identifies the service. Many of these interfaces are empty, that is, they have no methods as they are only used for querying the service.

    - An interface that describes the service interface. This interface includes the methods to be implemented.

    - A class that implements both the service and the service interface.

5. The following example shows a very basic implementation of the three types. The constructor of the service class must set the service provider. In this example we'll just add the service to the package code file.

6. Add the following using directives to the package file:

    ```csharp
    using System.Threading;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;
    using System.IO;
    using Microsoft.VisualStudio.Threading;
    using IAsyncServiceProvider = Microsoft.VisualStudio.Shell.IAsyncServiceProvider;
    using Task = System.Threading.Tasks.Task;
    ```

7. Here's the asynchronous service implementation. Note that you need to set the asynchronous service provider rather than the synchronous service provider in the constructor:

    ```csharp
    public class TextWriterService : STextWriterService, ITextWriterService
    {
        private IAsyncServiceProvider asyncServiceProvider;

        public TextWriterService(IAsyncServiceProvider provider)
        {
            // constructor should only be used for simple initialization
            // any usage of Visual Studio service, expensive background operations should happen in the
            // asynchronous InitializeAsync method for best performance
            asyncServiceProvider = provider;
        }

        public async Task InitializeAsync(CancellationToken cancellationToken)
        {
            await TaskScheduler.Default;
            // do background operations that involve IO or other async methods

            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
            // query Visual Studio services on main thread unless they are documented as free threaded explicitly.
            // The reason for this is the final cast to service interface (such as IVsShell) may involve COM operations to add/release references.

            IVsShell vsShell = this.asyncServiceProvider.GetServiceAsync(typeof(SVsShell)) as IVsShell;
            // use Visual Studio services to continue initialization
        }

        public async Task WriteLineAsync(string path, string line)
        {
            StreamWriter writer = new StreamWriter(path);
            await writer.WriteLineAsync(line);
            writer.Close();
        }
    }

    public interface STextWriterService
    {
    }

    public interface ITextWriterService
    {
        System.Threading.Tasks.Task WriteLineAsync(string path, string line);
    }
    ```

## Register a service
 To register a service, add the <xref:Microsoft.VisualStudio.Shell.ProvideServiceAttribute> to the package that provides the service. Different to registering a synchronous service, you have to make sure both package and service supports async loading:

- You must add the **AllowsBackgroundLoading = true** field to the <xref:Microsoft.VisualStudio.Shell.PackageRegistrationAttribute> to ensure package can be initialized asynchronously For more information about the PackageRegistrationAttribute, see [Register and unregister VSPackages](../extensibility/registering-and-unregistering-vspackages.md).

- You must add the **IsAsyncQueryable = true** field to the <xref:Microsoft.VisualStudio.Shell.ProvideServiceAttribute> to ensure service instance can be initialized asynchronously.

  Here is an example of an `AsyncPackage` with an asynchronous service registration:

```csharp
[ProvideService((typeof(STextWriterService)), IsAsyncQueryable = true)]
[ProvideAutoLoad(UIContextGuids80.SolutionExists, PackageAutoLoadFlags.BackgroundLoad)]
[PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
[Guid(TestAsyncPackage.PackageGuidString)]
public sealed class TestAsyncPackage : AsyncPackage
{. . . }
```

## Add a service

1. In *TestAsyncPackage.cs*, remove the `Initialize()` method and override the `InitializeAsync()` method. Add the service, and add a callback method to create the services. Here is an example of the asynchronous initializer adding a service:

    ```csharp
    protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
        await base.InitializeAsync(cancellationToken, progress);
        this.AddService(typeof(STextWriterService), CreateTextWriterService);
    }

    ```
    To make this service visible outside this package, set the promote flag value to *true* as the last parameter:
    `this.AddService(typeof(STextWriterService), CreateTextWriterService, true);`

2. Add a reference to *Microsoft.VisualStudio.Shell.Interop.14.0.DesignTime.dll*.

3. Implement the callback method as an asynchronous method that creates and returns the service.

    ```csharp
    public async Task<object> CreateTextWriterService(IAsyncServiceContainer container, CancellationToken cancellationToken, Type serviceType)
    {
        TextWriterService service = new TextWriterService(this);
        await service.InitializeAsync(cancellationToken);
        return service;
    }

    ```

## Use a service
 Now you can get the service and use its methods.

1. We'll show this in the initializer, but you can get the service anywhere you want to use the service.

    ```csharp
    protected override async System.Threading.Tasks.Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
        await base.InitializeAsync(cancellationToken, progress);
        this.AddService(typeof(STextWriterService), CreateTextWriterService);

        ITextWriterService textService = await this.GetServiceAsync(typeof(STextWriterService)) as ITextWriterService;
        string userpath = @"C:\MyDir\MyFile.txt";
        await textService.WriteLineAsync(userpath, "this is a test");
    }

    ```

     Don't forget to change `userpath` to a filename and path that makes sense on your machine!

2. Build and run the code. When the experimental instance of Visual Studio appears, open a solution. This causes the `AsyncPackage` to autoload. When the initializer has run, you should find a file in the location you specified.

## Use an asynchronous service in a command handler
 Here's an example of how to use an asynchronous service in a menu command. You can use the procedure shown here to use the service in other non-asynchronous methods.

1. Add a menu command to your project. (In the **Solution Explorer**, select the project node, right-click, and select **Add** > **New Item** > **Extensibility** > **Custom Command**.) Name the command file *TestAsyncCommand.cs*.

2. The custom command template re-adds the `Initialize()` method to the *TestAsyncPackage.cs* file in order to initialize the command. In the `Initialize()` method, copy the line that initializes the command. It should look like this:

    ```csharp
    TestAsyncCommand.Initialize(this);
    ```

     Move this line to the `InitializeAsync()` method in the *AsyncPackageForService.cs* file. Since this is in an asynchronous initialization, you must switch to the main thread before you initialize the command using <xref:Microsoft.VisualStudio.Threading.JoinableTaskFactory.SwitchToMainThreadAsync%2A>. It should now look like this:

    ```csharp

    protected override async System.Threading.Tasks.Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
        await base.InitializeAsync(cancellationToken, progress);
        this.AddService(typeof(STextWriterService), CreateTextWriterService);

        ITextWriterService textService =
           await this.GetServiceAsync(typeof(STextWriterService)) as ITextWriterService;
        
        string userpath = @"C:\MyDir\MyFile.txt";
        await textService.WriteLineAsync(userpath, "this is a test");

        await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
        TestAsyncCommand.Initialize(this);
    }

    ```

3. Delete the `Initialize()` method.

4. In the *TestAsyncCommand.cs* file, find the `MenuItemCallback()` method. Delete the body of the method.

5. Add a using directive:

    ```csharp
    using System.IO;
    ```

6. Add an asynchronous method named `UseTextWriterAsync()`, which gets the service and uses its methods:

    ```csharp
    private async System.Threading.Tasks.Task UseTextWriterAsync()
    {
        // Query text writer service asynchronously to avoid a blocking call.
        ITextWriterService textService =
           await AsyncServiceProvider.GlobalProvider.GetServiceAsync(typeof(STextWriterService))
              as ITextWriterService;

        string userpath = @"C:\MyDir\MyFile.txt";
        await textService.WriteLineAsync(userpath, "this is a test");
       }

    ```

7. Call this method from the `MenuItemCallback()` method:

    ```csharp
    private void MenuItemCallback(object sender, EventArgs e)
    {
        UseTextWriterAsync();
    }

    ```

8. Build the solution and start debugging. When the experimental instance of Visual Studio appears, go to the **Tools** menu and look for the **Invoke TestAsyncCommand** menu item. When you click it, the TextWriterService writes to the file you specified. (You don't need to open a solution, because invoking the command also causes the package to load.)

## Related content
- [Use and provide services](../extensibility/using-and-providing-services.md)
