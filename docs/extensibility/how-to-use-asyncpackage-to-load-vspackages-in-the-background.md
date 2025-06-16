---
title: Use AsyncPackage to load VSPackages in the background
description: Learn how to use the AsyncPackage class that enables package loading on a background thread, which can prevent responsiveness issues from disk I/O.
ms.date: 11/04/2016
ms.topic: how-to
author: tinaschrepfer
ms.author: tinali
---
# Use AsyncPackage to load VSPackages in the background

Loading and initializing a VS package can result in disk I/O. If such I/O happens on the UI thread, it can lead to responsiveness issues. To address this, Visual Studio 2015 introduced the  <xref:Microsoft.VisualStudio.Shell.AsyncPackage> class that enables package loading on a background thread.

## Create an AsyncPackage
 You can start by creating a VSIX project (**File** > **New** > **Project** > **Visual C#** > **Extensibility** > **VSIX Project**) and adding a VSPackage to the project (right-click on the project and **Add** > **New Item** > **C# item** > **Extensibility** > **Visual Studio Package**). You can then create your services and add those services to your package.

1. Derive the package from <xref:Microsoft.VisualStudio.Shell.AsyncPackage>.

2. If you are providing services whose querying may cause your package to load:

    To indicate to Visual Studio that your package is safe for background loading and to opt into this behavior, your <xref:Microsoft.VisualStudio.Shell.PackageRegistrationAttribute> should set **AllowsBackgroundLoading** property to true in the attribute constructor.

   ```csharp
   [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]

   ```

    To indicate to Visual Studio that it is safe to instantiate your service on a background thread, you should set the <xref:Microsoft.VisualStudio.Shell.ProvideServiceAttributeBase.IsAsyncQueryable%2A> property to true in the <xref:Microsoft.VisualStudio.Shell.ProvideServiceAttribute> constructor.

   ```csharp
   [ProvideService(typeof(SMyTestService), IsAsyncQueryable = true)]

   ```

3. If you are loading via UI contexts, then you should specify **PackageAutoLoadFlags.BackgroundLoad** for the <xref:Microsoft.VisualStudio.Shell.ProvideAutoLoadAttribute> OR the value (0x2) into the flags written as the value of your package's auto-load entry.

   ```csharp
   [ProvideAutoLoad(UIContextGuid, PackageAutoLoadFlags.BackgroundLoad)]

   ```

4. If you have asynchronous initialization work to do, you should override <xref:Microsoft.VisualStudio.Shell.AsyncPackage.InitializeAsync%2A>. Remove the `Initialize()` method provided by the VSIX template. (The `Initialize()` method in **AsyncPackage** is sealed). You can use any of the <xref:Microsoft.VisualStudio.Shell.AsyncPackage.AddService%2A> methods to add asynchronous services to your package.

    NOTE: To call `base.InitializeAsync()`, you can change your source code to:

   ```csharp
   await base.InitializeAsync(cancellationToken, progress);
   ```

5. You must take care to NOT make RPCs (Remote Procedure Call) from your asynchronous initialization code (in **InitializeAsync**). These can occur when you call <xref:Microsoft.VisualStudio.Shell.Package.GetService%2A> directly or indirectly.  When sync loads are required, the UI thread will block using <xref:Microsoft.VisualStudio.Threading.JoinableTaskFactory>. The default blocking model disables RPCs. This means that if you attempt to use an RPC from your async tasks, you will deadlock if the UI thread is itself waiting for your package to load. The general alternative is to marshal your code to the UI thread if needed using something like **Joinable Task Factory**'s <xref:Microsoft.VisualStudio.Threading.JoinableTaskFactory.SwitchToMainThreadAsync%2A> or some other mechanism that does not use an RPC.  Do NOT use **ThreadHelper.Generic.Invoke** or generally block the calling thread waiting to get to the UI thread.

    NOTE: You should avoid using **GetService** or **QueryService** in your `InitializeAsync` method. If you have to use those, you will need to switch to the UI thread first. The alternative is to use <xref:Microsoft.VisualStudio.Shell.AsyncServiceProvider.GetServiceAsync%2A> from your **AsyncPackage** (by casting it to <xref:Microsoft.VisualStudio.Shell.Interop.IAsyncServiceProvider>.)

   C#: Create an AsyncPackage:

```csharp
[PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
[ProvideService(typeof(SMyTestService), IsAsyncQueryable = true)]
public sealed class TestPackage : AsyncPackage
{
    protected override Task InitializeAsync(System.Threading.CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
        this.AddService(typeof(SMyTestService), CreateService, true);
        return Task.FromResult<object>(null);
    }
}
```

## Convert an existing VSPackage to AsyncPackage
 The majority of the work is the same as creating a new **AsyncPackage**. Follow steps 1 through 5 above. You also need to take extra caution with the following recommendations:

1. Remember to remove the `Initialize` override you had in your package.

2. Avoid deadlocks: There could be hidden RPCs in your code. which now happen on a background thread. Make sure that if you are making an RPC (for example, **GetService**), you need to either (1) switch to the main thread or (2) use the asynchronous version of the API if one exists (for example, **GetServiceAsync**).

3. Do not switch between threads too frequently. Try to localize the work that can happen in a background thread to reduce the load time.

## Querying services from AsyncPackage
 An **AsyncPackage** may or may not load asynchronously depending on the caller. For instance,

- If the caller called **GetService** or **QueryService** (both synchronous APIs) or

- If the caller called **IVsShell::LoadPackage** (or **IVsShell5::LoadPackageWithContext**) or

- The load is triggered by a UI context, but you did not specify the UI context mechanism can load you asynchronously

  then your package will load synchronously.

  Your package still has an opportunity (in its asynchronous initialization phase) to do work off the UI thread, though the UI thread will be blocked for that work's completion. If the caller uses **IAsyncServiceProvider** to asynchronously query for your service, then your load and initialization will be done asynchronously assuming they don't immediately block on the resulting task object.

  C#: How to query service asynchronously:

```csharp
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

IAsyncServiceProvider asyncServiceProvider = Package.GetService(typeof(SAsyncServiceProvider)) as IAsyncServiceProvider;
IMyTestService testService = await asyncServiceProvider.GetServiceAsync(typeof(SMyTestService)) as IMyTestService;
```
