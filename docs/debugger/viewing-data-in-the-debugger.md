---
title: "View data in the debugger | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.debug"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords: 
  - "debugging [Visual Studio], inspecting programs"
  - "debugger, viewing data"
ms.assetid: 13e1105f-f987-402e-9108-ec6ac12be042
caps.latest.revision: 30
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Viewing data in the Visual Studio debugger
The [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] debugger provides a variety of tools for inspecting and modifying the state of your program. Most of these tools function only in break mode.

## DataTips  
 DataTips are one of the most convenient tools for viewing information about the variables and objects in your program during debugging. When the debugger is in break mode, you can view the value of a variable within the current scope by placing the mouse pointer over the variable in a source window. For more information, see [View data values in Data Tips](../debugger/view-data-values-in-data-tips-in-the-code-editor.md).  

## Variable windows
 Many of the [debugger windows](../debugger/debugger-windows.md), such as the **Autos** and **Watch** windows, allow you to inspect variables while you are debugging. In addition, you can customize the display of native types and managed objects in the debugger variable windows and in DataTips. This can be helpful to display the types you create in your own applications. For more information, see [Create custom views of native objects](../debugger/create-custom-views-of-native-objects.md) and [Create custom views of managed objects](../debugger/create-custom-views-of-dot-managed-objects.md).
  
## Visualizers  
 Visualizers enable you to view the contents of an object or variable in a meaningful way. In Visual Studio, a visualizer refers to the different windows that you can open using the magnifying glass icon ![VisualizerIcon](../debugger/media/dbg-tips-visualizer-icon.png "Visualizer icon"). For example, you can use the HTML visualizer to view an HTML string as it would be interpreted and displayed in a browser. You can access visualizers from DataTips, the **Watch** window, the **Autos** window, the **Locals** window, or the **QuickWatch** dialog box. For information on using string visualizers, see [Debugger Tips and Tricks](../debugger/debugger-tips-and-tricks.md#string_visualizer). For managed code, you can also [create custom visualizers](../debugger/create-custom-visualizers-of-data.md).

## Live Visual Tree
 You can get a real-time view of your running XAML code with the Live Visual Tree and the Live Property Explorer. These tools give you a tree view of the UI elements of your running application, and show you the runtime properties of any UI element you select. For these tools, you do not need to be in break mode. For more information, see [Inspect XAML properties while debugging](../debugger/inspect-xaml-properties-while-debugging.md).
  
## See Also  
 [Debugger Basics](../debugger/debugger-basics.md)   
 [Command Window](../ide/reference/command-window.md)   
 [Debugger Security](../debugger/debugger-security.md)