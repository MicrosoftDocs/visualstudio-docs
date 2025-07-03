---
title: Custom data visualizers for .NET debugging
description: Visual Studio debugger visualizers are components that display data. Learn about the six standard visualizers, and about how you can write or download others.
ms.date: "08/08/2023"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.visualizer.troubleshoot"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "debugger, visualizers"
  - "visualizers"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Custom data visualizers for the Visual Studio debugger (.NET)

> [!IMPORTANT]
> Starting with Visual Studio 2022 version 17.9, visualizers can now be written in .NET 6.0+ that run out-of-process using the new VisualStudio.Extensibility model. For extensions created using the new model, see the documentation at [Create Visual Studio debugger visualizers](../extensibility/visualstudio.extensibility/debugger-visualizer/debugger-visualizers.md) instead. If you need to support older versions of Visual Studio or want to ship your custom visualizers as part of a library DLL, then use the information in this article, which applies only to the older model of extension development (VSSDK).

A *visualizer* is part of the Visual Studio debugger user interface that displays a variable or object in a manner appropriate to its data type. For example, a [bitmap visualizer](/previous-versions/visualstudio/visual-studio-2015/debugger/image-watch/image-watch) interprets a bitmap structure and displays the graphic it represents. Some visualizers let you modify as well as view the data. In the debugger, a visualizer is represented by a magnifying glass icon ![VisualizerIcon](../debugger/media/dbg-tips-visualizer-icon.png "Visualizer icon"). You can select the icon in a **DataTip**, debugger **Watch** window, or **QuickWatch** dialog box, and then select the appropriate visualizer for the corresponding object.

In addition to the [standard built-in visualizers](../debugger/view-strings-visualizer.md), more visualizers might be available for download from Microsoft, third parties, and the community. You can also write your own visualizers and install them in the Visual Studio debugger.

This article provides a high-level overview of visualizer creation. For detailed instructions, see the following articles instead:

- [Walkthrough: Write a visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md)
- [Walkthrough: Write a visualizer in Visual Basic](../debugger/walkthrough-writing-a-visualizer-in-visual-basic.md)
- [Install a visualizer](../debugger/how-to-install-a-visualizer.md)
- In the [Natvis](../debugger/create-custom-views-of-native-objects.md) documentation, see the [UIVisualizer element](../debugger/create-custom-views-of-native-objects.md#BKMK_UIVisualizer). Also, see the [SQLite native Debugger Visualizer](https://github.com/Microsoft/VSSDK-Extensibility-Samples/tree/master/SqliteVisualizer) sample.

> [!NOTE]
> Custom visualizers are not supported for Universal Windows Platform (UWP) and Windows 8.x apps.

## Overview

You can write a custom visualizer for an object of any managed class except for <xref:System.Object> and <xref:System.Array>.

The [architecture](../debugger/visualizer-architecture.md) of a debugger visualizer has two parts:

- The *debugger side* runs within the Visual Studio debugger, and creates and displays the visualizer user interface.

  Because Visual Studio executes on the .NET Framework Runtime, this component has to be written for .NET Framework. For this reason, it is not possible to write it for .NET Core.

- The *debuggee side* runs within the process Visual Studio is debugging (the *debuggee*). The data object to visualize (for example, a String object) exists in the debuggee process. The debuggee side sends the object to the debugger side, which displays it in the user interface you create.

  The runtime for which you build this component should match the one in which the debuggee process will run, that is, either .NET Framework or .NET Core.

The debugger side receives the data object from an *object provider* that implements the <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider> interface. The debuggee side sends the object through the *object source*, which is derived from <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource>.

The object provider can also send data back to the object source, which lets you write a visualizer that can edit data. You override the object provider to talk to the expression evaluator and the object source.

The debuggee side and debugger side communicate with each other through <xref:System.IO.Stream> methods that serialize a data object into a <xref:System.IO.Stream> and deserialize the <xref:System.IO.Stream> back into a data object.

You can write a visualizer for a generic type only if the type is an open type. This restriction is the same as the restriction when using the `DebuggerTypeProxy` attribute. For details, see [Use the DebuggerTypeProxy attribute](../debugger/using-debuggertypeproxy-attribute.md).

Custom visualizers might have security considerations. See [Visualizer security considerations](../debugger/visualizer-security-considerations.md).

## Create the debugger side user interface

To create the visualizer user interface on the debugger side, you create a class that inherits from <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>, and override the <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer.Show%2A?displayProperty=fullName> method to display the interface. You can use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService> to display Windows forms, dialogs, and controls in your visualizer.

1. Use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider> methods to get the visualized object on the debugger side.

1. Create a class that inherits from <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>.

  > [!NOTE]
  > Due to the security issues described in the section below, starting with Visual Studio 2022 version 17.11, visualizers won't be able to specify the `Legacy` formatter policy in the base class' constructor. From now on, visualizers can only use JSON serialization to communicate between the *debugger* and *debuggee-side* components.

1. Override the <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer.Show%2A?displayProperty=fullName> method to display your interface. Use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService> methods to display Windows forms, dialogs, and controls in your interface.

1. Apply <xref:System.Diagnostics.DebuggerVisualizerAttribute>, giving it the visualizer to display (<xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>).

### Special debugger side considerations for .NET 5.0+

Custom Visualizers transfer data between the *debuggee* and *debugger* sides through binary serialization using the <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> class by default. However, that kind of serialization is being curtailed in .NET 5 and above due to security concerns regarding its *unfixible* vulnerabilities.
Moreover, it has been marked completely obsolete in ASP.NET Core 5 and its usage will throw as described in the
[ASP.NET Core Documentation](/dotnet/core/compatibility/core-libraries/5.0/binaryformatter-serialization-obsolete).
This section describes the steps you should take to make sure your visualizer is still supported in this scenario.

- For compatibility reasons, the <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer.Show%2A> method that was overridden in the preceding section still takes in an <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider>. However, starting in Visual Studio 2019 version 16.10, it is actually of type <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider3>.
For this reason, cast the `objectProvider` object to the updated interface.

- When sending objects, like commands or data, to the *debuggee-side* use the `IVisualizerObjectProvider2.Serialize` method to pass it to a stream, it will determine the best serialization format to use based on the runtime of the *debuggee* process.
Then, pass the stream to the `IVisualizerObjectProvider2.TransferData` method.

- If the *debuggee-side* visualizer component needs to return anything to the *debugger-side*, it will be located in the <xref:System.IO.Stream> object returned by the <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.TransferData%2A> method. Use the `IVisualizerObjectProvider2.GetDeserializableObjectFrom` method to get an <xref:Microsoft.VisualStudio.DebuggerVisualizers.IDeserializableObject> instance from it and process it as required; or use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider3.DeserializeFromJson%2A> if it's a type that you know how to deserialize.

Please refer to the [Special debuggee side considerations for .NET 5.0+](#special-debuggee-side-considerations-for-net-50) section to learn what other changes are required on the *debuggee-side* when using Binary Serialization is not supported.

> [!NOTE]
> If you would like more information on the issue, see the [BinaryFormatter security guide](/dotnet/standard/serialization/binaryformatter-security-guide).

## Create the visualizer object source for the debuggee side

In the debugger side code, edit the <xref:System.Diagnostics.DebuggerVisualizerAttribute>, giving it the type to visualize (the debuggee-side object source) (<xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource>). The `Target` property sets the object source. If you omit the object source, the visualizer will use a default object source.

The debuggee side code contains the object source that gets visualized. The data object can override methods of <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource>. A debuggee side DLL is necessary if you want to create a standalone visualizer.

In the debuggee-side code:

- To let the visualizer edit data objects, the object source must inherit from <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource> and override the `TransferData` or `CreateReplacementObject` methods.

- If you need to support multi-targeting in your visualizer, you can use the following Target Framework Monikers (TFMs) in the debuggee-side project file.

   ```xml
   <TargetFrameworks>net20;netstandard2.0;netcoreapp2.0</TargetFrameworks>
   ```

   These are the only supported TFMs.

### Special debuggee side considerations for .NET 5.0+

> [!IMPORTANT]
> Additional steps might be needed for a visualizer to work starting in .NET 5.0 due to security concerns regarding the underlying binary serialization method used by default. Please read this [section](#special-debugger-side-considerations-for-net-50) before continuing.

- If the visualizer implements the <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.TransferData%2A> method, use the newly added <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.GetDeserializableObject%2A> method that is available in the latest version of `VisualizerObjectSource`. The <xref:Microsoft.VisualStudio.DebuggerVisualizers.IDeserializableObject>
it returns helps to determine the object's serialization format (binary or JSON) and to deserialize the underlying object so that it might be used.

- If the *debuggee-side* returns data to the *debugger-side* as part of the `TransferData` call, serialize the response to the
*debugger-side's* stream via the <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.Serialize%2A> method.

## Related content

- [Walkthrough: Write a visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md)
- [Walkthrough: Write a visualizer in Visual Basic](../debugger/walkthrough-writing-a-visualizer-in-visual-basic.md)
- [Install a visualizer](../debugger/how-to-install-a-visualizer.md)
- [Test and debug a visualizer](../debugger/how-to-test-and-debug-a-visualizer.md)
- [Visualizer API reference](../debugger/visualizer-api-reference.md)
- [View data in the debugger](../debugger/viewing-data-in-the-debugger.md)
