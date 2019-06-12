---
title: "Stale Code Warning Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.ENC.stalecode"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Stale Code Warning dialog box"
  - "code, stale code warning"
  - "warnings, Stale Code Warning dialog box"
  - "Edit and Continue, stale code"
ms.assetid: 594b894c-e652-4e13-a980-9909473d5712
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Stale Code Warning Dialog Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This dialog box appears when you have made changes to native code that **Edit and Continue** could not immediately apply. As a result, some native code in the current stack frame is now out of date, that is, stale. For more information, see [How to: Work with Stale Code](https://msdn.microsoft.com/c7536e95-66a6-44a0-995d-3fe5035250b4).  
  
 **Don't show me this dialog again**  
 If you select this check box, Edit and Continue will apply code changes without asking permission in the future. You can turn this warning on again by going to the **Options** dialog box, opening the **Debugging** Folder, clicking the **Edit and Continue** page, and selecting **Warn about stale code**.  
  
## See Also  
 [Supported Code Changes (C++)](../debugger/supported-code-changes-cpp.md)   
 [Edit and Continue, Debugging, Options Dialog Box](https://msdn.microsoft.com/library/009d225f-ef65-463f-a146-e4c518f86103)
