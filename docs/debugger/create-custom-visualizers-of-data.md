---
title: "Create Custom Visualizers of Data | Microsoft Docs"
ms.custom: ""
ms.date: "06/19/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
caps.latest.revision: 28
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Create Custom Visualizers of Data
 Visualizers are components of the [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] debugger user interface. A *visualizer* creates a dialog box or another interface to display a variable or object in a manner that is appropriate to its data type. For example, an HTML visualizer interprets an HTML string and displays the result as it would appear in a browser window; a bitmap visualizer interprets a bitmap structure and displays the graphic it represents. Some visualizers enable you to modify as well as view the data.

 The [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] debugger includes six standard visualizers. These are the text, HTML, XML, and JSON visualizers, all of which work on string objects; the WPF Tree visualizer, for displaying the properties of a WPF object visual tree; and the dataset visualizer, which works for DataSet, DataView, and DataTable objects. Additional visualizers may be available for download from Microsoft Corporation in the future, and are available from third-parties and the community. In addition, you can write your own visualizers and install them in the [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] debugger.

 > [!NOTE]
 > To create a custom visualizer for native code, see the 
[SQLite native Debugger Visualizer](https://github.com/Microsoft/VSSDK-Extensibility-Samples/tree/master/SqliteVisualizer) sample. In UWP and Windows 8.x apps, custom visualizers are not supported.

 In the debugger, visualizers are represented by a magnifying glass icon ![VisualizerIcon](../debugger/media/dbg-tips-visualizer-icon.png "Visualizer icon"). When you see the magnifying glass icon in a **DataTip**, in a debugger window like the **Watch** window, or in the **QuickWatch** dialog box, you can click the magnifying glass to select a visualizer appropriate to the data type of the corresponding object.

## Overview of custom visualizers

You can write a custom visualizer for an object of any managed class except for <xref:System.Object> or <xref:System.Array>.  
  
 The architecture of a debugger visualizer has two parts:  
  
-   The *debugger side* runs within the Visual Studio debugger. The debugger-side code creates and displays the user interface for your visualizer.  
  
-   The *debuggee side* runs within the process Visual Studio is debugging (the *debuggee*).  
  
 The data object that you want to visualize (a String object, for example) exists in the debuggee-process. So, the debuggee side has to send that data object to the debugger side, which can then display it using a user interface you create.  
  
 The debugger side receives this data object to be visualized from an *object provider* that implements the <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider> interface. The debuggee side sends the data object through the *object source*, which is derived from <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource>. The object provider can also send data back to the object source, which enables you to write a visualizer that edits, as well as displays, data. The object provider can be overridden to talk to the expression evaluator and, therefore, to the object source  
  
 The debuggee side and debugger side communicate with one another through <xref:System.IO.Stream>. Methods are provided to serialize a data object into a <xref:System.IO.Stream> and deserialize the <xref:System.IO.Stream> back into a data object.  
  
 The debuggee side code is specified using the DebuggerVisualizer attribute (<xref:System.Diagnostics.DebuggerVisualizerAttribute>).  
  
 To create the visualizer user interface on the debugger side, you must create a class that inherits from <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer> and override the <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer.Show%2A?displayProperty=fullName> method to display the interface.  
  
 You can use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService> to display Windows forms, dialogs, and controls from your visualizer.  
  
 Support for generic types is limited. You can write a visualizer for a target that is a generic type only if the generic type is an open type. This restriction is the same as the restriction when using the `DebuggerTypeProxy` attribute. For details, see [Using DebuggerTypeProxy Attribute](../debugger/using-debuggertypeproxy-attribute.md).  
  
 Custom visualizers may have security considerations. See [Visualizer Security Considerations](../debugger/visualizer-security-considerations.md).  
  
 The procedures below, give a high-level view of what you need to do to create a visualizer. For a more detailed explanation, see [Walkthrough: Writing a Visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md).  
  
### To create the debugger side  
  
1.  Use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider> methods to get the visualized object on the debugger side.  
  
2.  Create a class that inherits from <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>.  
  
3.  Override the <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer.Show%2A?displayProperty=fullName> method to display your interface. Use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService> methods to display Windows forms, dialogs, and controls as part of your interface.  
  
4.  Apply <xref:System.Diagnostics.DebuggerVisualizerAttribute>, giving it a visualizer (<xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>).  
  
### To create the debuggee side  
  
1.  Apply <xref:System.Diagnostics.DebuggerVisualizerAttribute>, giving it a visualizer (<xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>) and an object source (<xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource>). If you omit the object source, a default object source will be used  
  
2.  If you want your visualizer to be able to edit data objects, as well as display them, you will need to override the `TransferData` or `CreateReplacementObject` methods from <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource>.   
  
## In This Section
  
 [Walkthrough: Writing a Visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md)  

 [Walkthrough: Writing a Visualizer in Visual Basic](../debugger/walkthrough-writing-a-visualizer-in-visual-basic.md)  
  
 [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md)  
  
 [How to: Test and Debug a Visualizer](../debugger/how-to-test-and-debug-a-visualizer.md)  
  
 [Visualizer API Reference](../debugger/visualizer-api-reference.md)  
  
## Related Sections  
 [View Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)