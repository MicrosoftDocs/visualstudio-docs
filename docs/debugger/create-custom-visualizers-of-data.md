---
title: "Create custom data visualizers | Microsoft Docs"
ms.date: "11/07/2018"
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
ms.assetid: c24c006f-f2ac-429f-89db-677fc0c6e1ea
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Create custom data visualizers
 A *visualizer* is part of the [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] debugger user interface that displays a variable or object in a manner appropriate to its data type. For example, an HTML visualizer interprets an HTML string and displays the result as it would appear in a browser window. A bitmap visualizer interprets a bitmap structure and displays the graphic it represents. Some visualizers let you modify as well as view the data.

 The [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] debugger includes six standard visualizers. The text, HTML, XML, and JSON visualizers work on string objects. The WPF Tree visualizer displays the properties of a WPF object visual tree. The dataset visualizer works for DataSet, DataView, and DataTable objects.

More visualizers may be available for download from Microsoft, third parties, and the community. You can also write your own visualizers and install them in the [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] debugger.

In the debugger, a visualizer is represented by a magnifying glass icon ![VisualizerIcon](../debugger/media/dbg-tips-visualizer-icon.png "Visualizer icon"). You can select the icon in a **DataTip**, debugger **Watch** window, or **QuickWatch** dialog box, and then select the appropriate visualizer for the corresponding object.

## Write custom visualizers

 > [!NOTE]
 > To create a custom visualizer for native code, see the [SQLite native Debugger Visualizer](https://github.com/Microsoft/VSSDK-Extensibility-Samples/tree/master/SqliteVisualizer) sample. Custom visualizers are not supported for UWP and Windows 8.x apps.

You can write a custom visualizer for an object of any managed class except for <xref:System.Object> and <xref:System.Array>.

The architecture of a debugger visualizer has two parts:

- The *debugger side* runs within the Visual Studio debugger, and creates and displays the visualizer user interface.

- The *debuggee side* runs within the process Visual Studio is debugging (the *debuggee*). The data object to visualize (for example, a String object) exists in the debuggee process. The debuggee side sends the object to the debugger side, which displays it in the user interface you create.

The debugger side receives the data object from an *object provider* that implements the <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider> interface. The debuggee side sends the object through the *object source*, which is derived from <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource>.

The object provider can also send data back to the object source, which lets you write a visualizer that can edit data. You override the object provider to talk to the expression evaluator and the object source.

The debuggee side and debugger side communicate with each other through <xref:System.IO.Stream> methods that serialize a data object into a <xref:System.IO.Stream> and deserialize the <xref:System.IO.Stream> back into a data object.

You can write a visualizer for a generic type only if the type is an open type. This restriction is the same as the restriction when using the `DebuggerTypeProxy` attribute. For details, see [Use the DebuggerTypeProxy attribute](../debugger/using-debuggertypeproxy-attribute.md).

Custom visualizers may have security considerations. See [Visualizer security considerations](../debugger/visualizer-security-considerations.md).

The following steps give a high-level overview of visualizer creation. For detailed instructions, see [Walkthrough: Write a visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md) or [Walkthrough: Write a visualizer in Visual Basic](../debugger/walkthrough-writing-a-visualizer-in-visual-basic.md).

### To create the debugger side

To create the visualizer user interface on the debugger side, you create a class that inherits from <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>, and override the <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer.Show%2A?displayProperty=fullName> method to display the interface. You can use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService> to display Windows forms, dialogs, and controls in your visualizer.

1. Use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider> methods to get the visualized object on the debugger side.

1. Create a class that inherits from <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>.

1. Override the <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer.Show%2A?displayProperty=fullName> method to display your interface. Use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService> methods to display Windows forms, dialogs, and controls in your interface.

4. Apply <xref:System.Diagnostics.DebuggerVisualizerAttribute>, giving it the visualizer to display (<xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>).

### To create the debuggee side

You specify debuggee-side code by using the <xref:System.Diagnostics.DebuggerVisualizerAttribute>.

1. Apply <xref:System.Diagnostics.DebuggerVisualizerAttribute>, giving it a visualizer (<xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>) and an object source (<xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource>). If you omit the object source, the visualizer will use a default object source.

1. To let the visualizer edit as well as display data objects, override the `TransferData` or `CreateReplacementObject` methods from <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource>.

## See also

- [Walkthrough: Write a visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md)
- [Walkthrough: Write a visualizer in Visual Basic](../debugger/walkthrough-writing-a-visualizer-in-visual-basic.md)
- [How to: Install a visualizer](../debugger/how-to-install-a-visualizer.md)
- [How to: Test and debug a visualizer](../debugger/how-to-test-and-debug-a-visualizer.md)
- [Visualizer API reference](../debugger/visualizer-api-reference.md)
- [View data in the debugger](../debugger/viewing-data-in-the-debugger.md)