---
title: "How to: Change the Debug Stepping Option (Legacy)"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: aedc06af-d58a-44d6-aee4-f397f1f923a0
caps.latest.revision: 5
manager: erikre
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
# How to: Change the Debug Stepping Option (Legacy)
This topic describes how to change the debug stepping option for Windows Workflow Foundation (WF) applications in the legacy Windows Workflow Designer that have concurrent actions. Use the legacy Workflow Designer when you need to target either the .NET Framework version 3.5 or the WinFX.  
  
 When you are debugging legacy activities that have concurrent execution, such as **ParallelActivity** or **ConditionedActivityGroup**, you can use one of two options to step through your code.  
  
 Follow these steps to change the debug stepping option in your legacy workflow project.  
  
## Procedures  
  
#### To change the debug stepping option  
  
1.  Start Visual Studio.  
  
2.  Open an existing legacy workflow project or create a new project that employs concurrent activities and that targets either the .NET Framework version 3.5 or the WinFX.  
  
3.  On the **Workflow** menu in the legacy Workflow Designer, point to **Debug**, and then point to **Stepping Options**.  
  
4.  Select either **Instance** or **Branch**.  
  
## See Also  
 [Debugging Legacy Workflows](../WF_Design/Debugging-Legacy-Workflows.md)   
 [Debug Stepping Options (Legacy)](../WF_Design/Debug-Stepping-Options--Legacy-.md)