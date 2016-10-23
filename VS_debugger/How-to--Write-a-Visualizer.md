---
title: "How to: Write a Visualizer"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - JScript
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 625a0d4f-abcc-43f2-9f8c-31c131a4378e
caps.latest.revision: 24
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Write a Visualizer
You can write a custom visualizer for an object of any managed class except for <xref:System.Object?qualifyHint=False> or <xref:System.Array?qualifyHint=False>.  
  
> [!NOTE]
>  In **Store** apps, only the standard text, HTML, XML, and JSON visualizers are supported. Custom (user-created) visualizers are not supported.  
  
 The architecture of a debugger visualizer has two parts:  
  
-   The *debugger side* runs within the Visual Studio debugger. The debugger-side code creates and displays the user interface for your visualizer.  
  
-   The *debuggee side* runs within the process Visual Studio is debugging (the *debuggee*).  
  
 The data object that you want to visualize (a String object, for example) exists in the debuggee-process. So, the debuggee side has to send that data object to the debugger side, which can then display it using a user interface you create.  
  
 The debugger side receives this data object to be visualized from an *object provider* that implements the <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider?qualifyHint=False> interface. The debuggee side sends the data object through the *object source*, which is derived from <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource?qualifyHint=False>. The object provider can also send data back to the object source, which enables you to write a visualizer that edits, as well as displays, data. The object provider can be overridden to talk to the expression evaluator and, therefore, to the object source  
  
 The debuggee side and debugger side communicate with one another through <xref:System.IO.Stream?qualifyHint=False>. Methods are provided to serialize a data object into a <xref:System.IO.Stream?qualifyHint=False> and deserialize the <xref:System.IO.Stream?qualifyHint=False> back into a data object.  
  
 The debuggee side code is specified using the DebuggerVisualizer attribute (<xref:System.Diagnostics.DebuggerVisualizerAttribute?qualifyHint=False>).  
  
 To create the visualizer user interface on the debugger side, you must create a class that inherits from <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer?qualifyHint=False> and override the <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer.Show?qualifyHint=True> method to display the interface.  
  
 You can use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService?qualifyHint=False> to display Windows forms, dialogs, and controls from your visualizer.  
  
 Support for generic types is limited. You can write a visualizer for a target that is a generic type only if the generic type is an open type. This restriction is the same as the restriction when using the `DebuggerTypeProxy` attribute. For details, see [Using DebuggerTypeProxy Attribute](../VS_debugger/Using-DebuggerTypeProxy-Attribute.md).  
  
 Custom visualizers may have security considerations. See [Visualizer Security Considerations](../VS_debugger/Visualizer-Security-Considerations.md).  
  
 The procedures below, give a high-level view of what you need to do to create a visualizer. For a more detailed explanation, see [Walkthrough: Writing a Visualizer in C#](../VS_debugger/Walkthrough--Writing-a-Visualizer-in-C#.md).  
  
### To create the debugger side  
  
1.  Use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider?qualifyHint=False> methods to get the visualized object on the debugger side.  
  
2.  Create a class that inherits from <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer?qualifyHint=False>.  
  
3.  Override the <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer.Show?qualifyHint=True> method to display your interface. Use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService?qualifyHint=False> methods to display Windows forms, dialogs, and controls as part of your interface.  
  
4.  Apply <xref:System.Diagnostics.DebuggerVisualizerAttribute?qualifyHint=False>, giving it a visualizer (<xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer?qualifyHint=False>).  
  
### To create the debuggee side  
  
1.  Apply <xref:System.Diagnostics.DebuggerVisualizerAttribute?qualifyHint=False>, giving it a visualizer (<xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer?qualifyHint=False>) and an object source (<xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource?qualifyHint=False>). If you omit the object source, a default object source will be used  
  
2.  If you want your visualizer to be able to edit data objects, as well as display them, you will need to override the `TransferData` or `CreateReplacementObject` methods from <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource?qualifyHint=False>.  
  
## See Also  
 [Create Custom Visualizers](../VS_debugger/Create-Custom-Visualizers-of-Data.md)   
 [How to: Install a Visualizer](../VS_debugger/How-to--Install-a-Visualizer.md)   
 [How to: Test and Debug a Visualizer](../VS_debugger/How-to--Test-and-Debug-a-Visualizer.md)   
 [Visualizer Security Considerations](../VS_debugger/Visualizer-Security-Considerations.md)