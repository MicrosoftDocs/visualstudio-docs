---
title: "How to: Write a Visualizer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugger, visualizers"
  - "visualizers, writing"
ms.assetid: 625a0d4f-abcc-43f2-9f8c-31c131a4378e
caps.latest.revision: 27
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Write a Visualizer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can write a custom visualizer for an object of any managed class except for <xref:System.Object> or <xref:System.Array>.  
  
> [!NOTE]
> In **Store** apps, only the standard text, HTML, XML, and JSON visualizers are supported. Custom (user-created) visualizers are not supported.  
  
 The architecture of a debugger visualizer has two parts:  
  
- The *debugger side* runs within the Visual Studio debugger. The debugger-side code creates and displays the user interface for your visualizer.  
  
- The *debuggee side* runs within the process Visual Studio is debugging (the *debuggee*).  
  
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
  
1. Use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider> methods to get the visualized object on the debugger side.  
  
2. Create a class that inherits from <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>.  
  
3. Override the <xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer.Show%2A?displayProperty=fullName> method to display your interface. Use <xref:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService> methods to display Windows forms, dialogs, and controls as part of your interface.  
  
4. Apply <xref:System.Diagnostics.DebuggerVisualizerAttribute>, giving it a visualizer (<xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>).  
  
### To create the debuggee side  
  
1. Apply <xref:System.Diagnostics.DebuggerVisualizerAttribute>, giving it a visualizer (<xref:Microsoft.VisualStudio.DebuggerVisualizers.DialogDebuggerVisualizer>) and an object source (<xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource>). If you omit the object source, a default object source will be used  
  
2. If you want your visualizer to be able to edit data objects, as well as display them, you will need to override the `TransferData` or `CreateReplacementObject` methods from <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource>.  
  
## See Also  
 [Create Custom Visualizers](../debugger/create-custom-visualizers-of-data.md)   
 [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md)   
 [How to: Test and Debug a Visualizer](../debugger/how-to-test-and-debug-a-visualizer.md)   
 [Visualizer Security Considerations](../debugger/visualizer-security-considerations.md)
