---
title: "Create Custom Visualizers of Data"
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
ms.assetid: c24c006f-f2ac-429f-89db-677fc0c6e1ea
caps.latest.revision: 28
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
# Create Custom Visualizers of Data
Visualizers are components of the Visual Studio debugger user interface. A *visualizer* creates a dialog box or another interface to display a variable or object in a manner that is appropriate to its data type. For example, an HTML visualizer interprets an HTML string and displays the result as it would appear in a browser window; a bitmap visualizer interprets a bitmap structure and displays the graphic it represents. Some visualizers enable you to modify as well as view the data.  
  
 The Visual Studio debugger includes six standard visualizers. These are the text, HTML, XML, and JSON visualizers, all of which work on string objects; the WPF Tree visualizer, for displaying the properties of a WPF object visual tree; and the dataset visualizer, which works for DataSet, DataView, and DataTable objects. Additional visualizers may be available for download from Microsoft Corporation in the future, and are available from third-parties and the community. In addition, you can write your own visualizers and install them in the Visual Studio debugger.  
  
> [!NOTE]
>  In **Store** apps, only the standard text, HTML, XML, and JSON visualizers are supported. Custom (user-created) visualizers are not supported.  
  
 Visualizers are represented in the debugger by a magnifying glass icon. When you see the magnifying glass icon in a **DataTip**, in a debugger variables window, or in the **QuickWatch** dialog box, you can click the magnifying glass to select a visualizer appropriate to the data type of the corresponding object.  
  
 Visualizers are not supported on the Compact Framework.  
  
> [!NOTE]
>  Debugger visualizers require greater privileges than are allowed by a partial trust application. As a result, visualizers do not load when you are stopped in code with partial trust. To debug using a visualizer, you must run the code with full trust.  
  
## In This Section  
 [How to: Write a Visualizer](../VS_debugger/How-to--Write-a-Visualizer.md)  
  
 [Walkthrough: Writing a Visualizer in C#](../VS_debugger/Walkthrough--Writing-a-Visualizer-in-C#.md)  
  
 [How to: Install a Visualizer](../VS_debugger/How-to--Install-a-Visualizer.md)  
  
 [How to: Test and Debug a Visualizer](../VS_debugger/How-to--Test-and-Debug-a-Visualizer.md)  
  
 [Visualizer API Reference](../VS_debugger/Visualizer-API-Reference.md)  
  
## Related Sections  
 [Viewing Data in the Debugger](../VS_debugger/Viewing-Data-in-the-Debugger.md)