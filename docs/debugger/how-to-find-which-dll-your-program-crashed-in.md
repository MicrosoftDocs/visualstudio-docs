---
title: "How to: Find Which DLL Your Program Crashed In | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.debug.dll"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "debugger, DLL crashes"
  - "Module List dialog box"
  - "errors [debugger], DLL crashes"
  - "Modules window"
  - "debugging [Visual Studio], DLL crashes"
  - "DLLs, load order of"
ms.assetid: ecf62568-8b65-4a41-b8a4-e962ff2dfb71
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# How to: Find Which DLL Your Program Crashed In
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose Import and Export Settings on the Tools menu. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).  
  
 If your application crashes during a call to a system DLL or someone else's code, you need to find out which DLL was active when the crash occurred. If you experience a crash in a DLL outside your own program, you can identify the location using the **Modules** window.  
  
### To find where a crash occurred using the Modules window  
  
1.  Note the address where the crash occurred.  
  
2.  On the **Debug** menu, choose **Windows**, and click **Modules**.  
  
3.  In the **Modules** window, find the **Address** column. You may need to use the scrollbar to see it.  
  
4.  Click the **Address** button at the top of the column to sort the DLLs by address.  
  
5.  Scan the sorted list to find the DLL whose address range contains the crash location.  
  
6.  Look at the **Name** and **Path** columns to see the DLL name and path.  
  
## See Also  
 [Debugging DLL Projects](../debugger/debugging-dll-projects.md)   
 [How to: Use the Modules Window](../debugger/how-to-use-the-modules-window.md)