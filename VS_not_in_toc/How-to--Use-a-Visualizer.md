---
title: "How to: Use a Visualizer"
ms.custom: na
ms.date: 10/01/2016
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
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d2611385-0134-4387-8c5a-979fe625a462
caps.latest.revision: 37
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# How to: Use a Visualizer
You can use a visualizer to display the contents of a variable or object in a way that is meaningful for the data type. You can use visualizers from **DataTips**, a **Watch** window, the **Autos** window, or the **Locals** window.  
  
 Visualizers are not supported on the Compact Framework.  
  
> [!NOTE]
>  In **Store** apps, only the standard text, HTML, XML, and JSON visualizers are supported. Custom (user-created) visualizers are not supported.  
  
### To open a visualizer  
  
1.  Click the magnifying glass icon that appears next to a variable name in **DataTips**, a **Watch** window, or in the **Autos**, **Locals**, or **Quick Watch** window.  
  
     A list of visualizers is displayed.  
  
2.  Click the visualizer you want to use.  
  
### To use a visualizer for managed code during remote debugging  
  
-   Copy the visualizer DLL to the remote computer before you start the debugging session.  
  
     The path to the DLL must be the same on both the remote and the local computers. This path can be either of the following locations:  
  
     *Visual Studio install path* `\Common7\Packages\Debugger\Visualizers`  
  
     -or-  
  
     `My Documents\Visual Studio 2010\Visualizers` *Visual Studio Version* `\Visualizers`  
  
## See Also  
 [Create Custom Visualizers](../VS_debugger/Create-Custom-Visualizers-of-Data.md)   
 [How to: Install a Visualizer](../VS_debugger/How-to--Install-a-Visualizer.md)   
 [How to: Write a Visualizer](../VS_debugger/How-to--Write-a-Visualizer.md)   
 [View data values in Data Tips](../VS_debugger/View-data-values-in-Data-Tips--in-the-code-editor.md)