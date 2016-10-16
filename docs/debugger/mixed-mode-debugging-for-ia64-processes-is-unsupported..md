---
title: "Mixed mode debugging for IA64 processes is unsupported."
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.error.interop_unsupported_ia64"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 20bc1e38-049b-4388-87c4-936815d85b46
caps.latest.revision: 3
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Mixed mode debugging for IA64 processes is unsupported.
Visual Studio does not support mixed-mode debugging of managed and native code in IA64 processes. This means that you cannot step from managed code to native code, or from native code to managed code, while debugging.  
  
### Workarounds  
  
-   Debug your managed and native code in separate debugging sessions.  
  
     –or–  
  
     Debug your mixed code as a 32-bit process, as described in the following procedures.  
  
### To Change the Platform to 32-bit (Visual Basic or C#)  
  
1.  In **Solution Explorer**, right-click on your project, then click **Properties** in the shortcut menu.  
  
2.  In the property pages, click the **Compile** or **Debug** tab.  
  
3.  Click **Platform** and select x86 from the list of platforms.  
  
     By default, the Visual Basic and C# compilers default produce code to run on any CPU. On a 64-bit computer, these binaries run as 64-bit processes. To run on a 32-bit process, you must choose **Win32**, not **AnyCPU**.  
  
### To Change the Platform to 32-bit (C/C++)  
  
1.  In **Solution Explorer**, right-click on your project, then click **Properties** in the shortcut menu.  
  
2.  In the Property Pages, click **Platform** and select Win32 from the list of platforms,  
  
## See Also  
 [Debug 64-Bit Applications](../debugger/debug-64-bit-applications.md)