---
title: "Create custom views of data in the debugger | Microsoft Docs"
ms.custom: ""
ms.date: "06/27/2017"
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
manager: ghogen
ms.workload: 
  - "multiple"
---
# Create custom views of data in the Visual Studio debugger
The [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] debugger provides a variety of tools for inspecting and modifying the state of your program. Most of these tools function only in break mode.

## Create custom views of data in variable windows and DataTips
 Many of the [debugger windows](../debugger/debugger-windows.md), such as the **Autos** and **Watch** windows, allow you to inspect variables while you are debugging. You can customize the display of native types and managed objects in the debugger variable windows and in [DataTips](../debugger/view-data-values-in-data-tips-in-the-code-editor.md). This can be helpful to display the types you create in your own applications. For more information, see [Create custom views of native objects](../debugger/create-custom-views-of-native-objects.md) and [Create custom views of managed objects](../debugger/create-custom-views-of-dot-managed-objects.md).
  
## Create custom visualizers  
 Visualizers enable you to view the contents of an object or variable in a meaningful way. In the Visual Studio debugger, a visualizer refers to the different windows that you can open using the magnifying glass icon ![VisualizerIcon](../debugger/media/dbg-tips-visualizer-icon.png "Visualizer icon"). For example, you can use the HTML visualizer to view an HTML string as it would be interpreted and displayed in a browser. You can access visualizers from DataTips, the **Watch** window, the **Autos** window, the **Locals** window, or the **QuickWatch** dialog box. For more information, see [Create custom visualizers](../debugger/create-custom-visualizers-of-data.md).
  
## See Also  
 [Debugger Basics](../debugger/debugger-basics.md)   
 [Command Window](../ide/reference/command-window.md)   
 [Debugger Security](../debugger/debugger-security.md)