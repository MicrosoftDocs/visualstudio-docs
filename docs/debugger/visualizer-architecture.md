---
title: "Visualizer Architecture"
description: A visualizer displays a specific type of data element, and may allow editing also. Learn about the architecture of a visualizer.
ms.date: "11/04/2016"
ms.topic: article
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Visualizer Architecture

The architecture of a debugger visualizer has two parts:

- The *debugger side* runs within the Visual Studio debugger. The debugger-side code creates and displays the user interface for your visualizer.

- The *debuggee side* runs within the process Visual Studio is debugging (the *debuggee*).

  A visualizer is a debugger component that enables the debugger to display (*visualize*) the contents of a data object in a meaningful, understandable form. Some visualizers support editing of the data object also. By writing custom visualizers, you can extend the debugger to handle your own custom data types.

  The data object to be visualized resides within the process you are debugging (the *debuggee* process). The user interface that will display the data is created within the Visual Studio debugger process:

|Debugger Process|Debuggee Process|
|----------------------|----------------------|
|Debugger user interface (DataTips, Watch Window, QuickWatch)|Data Object to be visualized|

 To visualize the data object within the debugger interface, you need code to communicate between the two processes. Consequently, the visualizer architecture consists of two parts: *debugger side* code and *debuggee side* code.

 The debugger-side code creates its own user interface, which can be invoked from the debugger interface, such as a DataTip, the Watch Window, or QuickWatch. The visualizer interface is created by using the <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer> class and the <xref:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService> interface. Like all Visualizer APIs, DialogDebuggerVisualizer and IDialogVisualizerService are found in the <xref:Microsoft.VisualStudio.DebuggerVisualizers> namespace.

|Debugger Side|Debuggee Side|
|-------------------|-------------------|
|DialogDebuggerVisualizer Class<br /><br /> IDialogVisualizerService Interface|Data Object|

 The user interface gets the data to be visualized from an Object Provider, which exists on the debugger side:

|Debugger Side|Debuggee Side|
|-------------------|-------------------|
|DialogDebuggerVisualizer Class<br /><br /> IDialogVisualizerService Interface|Data Object|
|Object Provider (implements <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider>)||

 There is a corresponding object on the debuggee side called the Object Source:

|Debugger Side|Debuggee Side|
|-------------------|-------------------|
|DialogDebuggerVisualizer Class<br /><br /> IDialogVisualizerService Interface|Data Object|
|Object Provider (implements <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider>)|Object Source (derived from <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource>)|

 The Object Provider provides the object data that is to be visualized to the visualizer UI. The Object Provider gets the object data from the Object Source. The Object Provider and Object Source provide APIs to communicate object data between the debugger side and the debuggee side.

 Every visualizer must get the data object to be visualized. The following table shows the corresponding APIs that the Object Provider and Object Source use for this purpose:

|Object Provider|Object Source|
|---------------------|-------------------|
|<xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.GetData%2A><br /><br /> —or—<br /><br /> <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.GetObject%2A>|<xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.GetData%2A>|

 Notice that the object provider can use either <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.GetData%2A> or <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.GetObject%2A>. Either API results in a call to <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.GetData%2A> on the Object Source. A call to <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.GetData%2A?displayProperty=fullName> fills in a <xref:System.IO.Stream?displayProperty=fullName>, which represents a serialized form of the object that is being visualized.

 <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.GetObject%2A?displayProperty=fullName> deserializes the data back into object form, which you can then display in the UI you create with <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>. <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.GetData%2A?displayProperty=fullName> fills in the data as a raw `Stream`, which you must deserialize yourself. <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.GetObject%2A?displayProperty=fullName> works by calling <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.GetData%2A?displayProperty=fullName> to get the serialized `Stream`, then deserializing the data. Use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.GetData%2A?displayProperty=fullName> when the object is not serializable by .NET and requires custom serialization. In that case, you must also override the <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.Serialize%2A?displayProperty=fullName> method.

 If you are creating a read-only visualizer, one-way communication with <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.GetData%2A> or <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.GetObject%2A> is sufficient. If you are creating a visualizer that supports editing of data objects, you must do more. You must be able to send a data object from the Object Provider back to the Object Source also. The following table shows the Object Provider and Object Source APIs used for this purpose:

|Object Provider|Object Source|
|---------------------|-------------------|
|<xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.ReplaceData%2A><br /><br /> —or—<br /><br /> <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.ReplaceObject%2A>|<xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.CreateReplacementObject%2A>|

 Notice, again, that there are two APIs which the Object Provider can use. Data is always sent from the Object Provider to the Object Source as a `Stream`, but <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.ReplaceData%2A> requires that you serialize the object into a `Stream` yourself.

 <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.ReplaceObject%2A> takes an object that you provide, serializes it into a `Stream`, then calls <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.ReplaceData%2A> to send the `Stream` to <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.CreateReplacementObject%2A>.

 Using one of the Replace methods creates a new data object in the debuggee that replaces the object being visualized. If you want to change the contents of the original object without replacing it, use one of the Transfer methods shown in the following table. These APIs transfer data in both directions at the same time, without replacing the object that is being visualized:

|Object Provider|Object Source|
|---------------------|-------------------|
|<xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.TransferData%2A><br /><br /> —or—<br /><br /> <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.TransferObject%2A>|<xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.TransferData%2A>|

## Related content
- [Create custom visualizers for .NET objects](create-custom-visualizers-of-data.md)
- [Walkthrough: Writing a Visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md)
- [Walkthrough: Writing a Visualizer in Visual Basic](../debugger/walkthrough-writing-a-visualizer-in-visual-basic.md)
- [Visualizer Security Considerations](../debugger/visualizer-security-considerations.md)
