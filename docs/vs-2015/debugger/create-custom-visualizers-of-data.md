---
title: "Create Custom Visualizers of Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.visualizer.troubleshoot"
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
  - "visualizers"
ms.assetid: c24c006f-f2ac-429f-89db-677fc0c6e1ea
caps.latest.revision: 31
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Create Custom Visualizers of Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visualizers are components of the [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] debugger user interface. A *visualizer* creates a dialog box or another interface to display a variable or object in a manner that is appropriate to its data type. For example, an HTML visualizer interprets an HTML string and displays the result as it would appear in a browser window; a bitmap visualizer interprets a bitmap structure and displays the graphic it represents. Some visualizers enable you to modify as well as view the data.  
  
 The [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] debugger includes six standard visualizers. These are the text, HTML, XML, and JSON visualizers, all of which work on string objects; the WPF Tree visualizer, for displaying the properties of a WPF object visual tree; and the dataset visualizer, which works for DataSet, DataView, and DataTable objects. Additional visualizers may be available for download from Microsoft Corporation in the future, and are available from third-parties and the community. In addition, you can write your own visualizers and install them in the [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] debugger.  
  
> [!NOTE]
> In **Store** apps, only the standard text, HTML, XML, and JSON visualizers are supported. Custom (user-created) visualizers are not supported.  
  
 Visualizers are represented in the debugger by a magnifying glass icon. When you see the magnifying glass icon in a **DataTip**, in a debugger variables window, or in the **QuickWatch** dialog box, you can click the magnifying glass to select a visualizer appropriate to the data type of the corresponding object.  
  
 Visualizers are not supported on the Compact Framework.  
  
> [!NOTE]
> Debugger visualizers require greater privileges than are allowed by a partial trust application. As a result, visualizers do not load when you are stopped in code with partial trust. To debug using a visualizer, you must run the code with full trust.  
  
## In This Section  
 [How to: Write a Visualizer](../debugger/how-to-write-a-visualizer.md)  
  
 [Walkthrough: Writing a Visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md)  
  
 [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md)  
  
 [How to: Test and Debug a Visualizer](../debugger/how-to-test-and-debug-a-visualizer.md)  
  
 [Visualizer API Reference](../debugger/visualizer-api-reference.md)  
  
## Related Sections  
 [Viewing Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)
