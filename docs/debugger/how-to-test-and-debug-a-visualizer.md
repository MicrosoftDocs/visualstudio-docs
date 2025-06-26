---
title: Test and Debug a Visualizer
description: Test and debug a visualizer by running it from a test driver (visualizer development host) or by installing in Visual Studio and calling it from a debugger window.
ms.date: 06/26/2025
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - visualizers, testing
  - visualizers, debugging
  - debugging [Visual Studio], visualizers
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Test and Debug a Visualizer

> [!IMPORTANT]
> Starting with Visual Studio 2022 version 17.9, visualizers can now be written in .NET 6.0+ that run out-of-process using the new VisualStudio.Extensibility model. For extensions created using the new model, see the documentation at [Create Visual Studio debugger visualizers](../extensibility/visualstudio.extensibility/debugger-visualizer/debugger-visualizers.md) instead. If you need to support older versions of Visual Studio or want to ship your custom visualizers as part of a library DLL, then use the information in this article, which applies only to the older model of extension development (VSSDK).

Once you write a visualizer, debug and test it.

One way to test a visualizer is by installing it in Visual Studio and calling it from a debugger window. (See [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md).) If you do that, then use a second instance of Visual Studio to attach and debug the visualizer, which is running in the first instance of the debugger.

An easier way to debug a visualizer is to run the visualizer from a test driver. The visualizer APIs make it easy to create such a driver, which is called the *visualizer development host*.

>[!NOTE]
> Currently, the test driver is supported only when calling the visualizer from a .NET Framework application.

### To create a visualizer development host

1. In your debugger-side class, include a static method that creates a <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerDevelopmentHost> object and calls its show method:

    ```csharp
    public static void TestShowVisualizer(object objectToVisualize)
    {
        VisualizerDevelopmentHost myHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerSide));
        myHost.ShowVisualizer();
    }
    ```

    The parameters used to construct the host are the data object that will be shown in the visualizer (`objectToVisualize`) and the type of the debugger side class.

2. To call `TestShowVisualizer`, add the following statement. If you created your visualizer in a class library, you need to create an executable to call the class library and place this statement in your executable:

    ```csharp
    DebuggerSide.TestShowVisualizer(myString);
    ```

    For a more complete example, see [Walkthrough: Writing a Visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md).

## Related content
- [Walkthrough: Writing a Visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md)
- [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md)
- [Create Custom Visualizers for .NET objects](../debugger/create-custom-visualizers-of-data.md)
