---
title: 'Managing Multiple Threads in Managed Code'
description: Learn how to manage multiple threads in code if your managed VSPackage extension calls asynchronous methods or has operations off the Visual Studio UI thread.
ms.date: 11/04/2016
ms.topic: how-to
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Manage multiple threads in managed code

If you have a managed VSPackage extension that calls asynchronous methods or has operations that execute on threads other than the Visual Studio UI thread, you should follow the guidelines given below. You can keep the UI thread responsive because it doesn't need to wait for work on another thread to complete. You can make your code more efficient, because you don't have extra threads that take up stack space, and you can make it more reliable and easier to debug because you avoid deadlocks and unresponsive code.

 In general, you can switch from the UI thread to a different thread, or vice versa. When the method returns, the current thread is the thread from which it was originally called.

> [!IMPORTANT]
> The following guidelines use the APIs in the <xref:Microsoft.VisualStudio.Threading> namespace, in particular, the <xref:Microsoft.VisualStudio.Threading.JoinableTaskFactory> class. The APIs in this namespace are new in Visual Studio 2013. You can get an instance of a <xref:Microsoft.VisualStudio.Threading.JoinableTaskFactory> from the <xref:Microsoft.VisualStudio.Shell.ThreadHelper> property `ThreadHelper.JoinableTaskFactory`.

## Switch from the UI thread to a background thread

1. If you are on the UI thread and you want to do asynchronous work on a background thread, use `Task.Run()`:

    ```csharp
    await Task.Run(async delegate{
        // Now you're on a separate thread.
    });
    // Now you're back on the UI thread.

    ```

2. If you are on the UI thread and you want to synchronously block while you are performing work on a background thread, use the <xref:System.Threading.Tasks.TaskScheduler> property `TaskScheduler.Default` inside <xref:Microsoft.VisualStudio.Threading.JoinableTaskFactory.Run%2A>:

    ```csharp
    // using Microsoft.VisualStudio.Threading;
    ThreadHelper.JoinableTaskFactory.Run(async delegate {
        await TaskScheduler.Default;
        // You're now on a separate thread.
        DoSomethingSynchronous();
        await OrSomethingAsynchronous();
    });
    ```

## Switch from a background thread to the UI thread

1. If you're on a background thread and you want to do something on the UI thread, use <xref:Microsoft.VisualStudio.Threading.JoinableTaskFactory.SwitchToMainThreadAsync%2A>:

    ```csharp
    // Switch to main thread
    await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
    ```

     You can use the <xref:Microsoft.VisualStudio.Threading.JoinableTaskFactory.SwitchToMainThreadAsync%2A> method to switch to the UI thread. This method posts a message to the UI thread with the continuation of the current asynchronous method, and also communicates with the rest of the threading framework to set the correct priority and avoid deadlocks.

     If your background thread method isn't asynchronous and you can't make it asynchronous, you can still use the `await` syntax to switch to the UI thread by wrapping your work with <xref:Microsoft.VisualStudio.Threading.JoinableTaskFactory.Run%2A>, as in this example:

    ```csharp
    ThreadHelper.JoinableTaskFactory.Run(async delegate {
        // Switch to main thread
        await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
        // Do your work on the main thread here.
    });
    ```
