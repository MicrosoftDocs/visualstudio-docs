---
title: "Mixed mode debugging for IA64 processes is unsupported. | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.error.interop_unsupported_ia64"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 20bc1e38-049b-4388-87c4-936815d85b46
caps.latest.revision: 6
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Mixed mode debugging for IA64 processes is unsupported.
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio does not support mixed-mode debugging of managed and native code in IA64 processes. This means that you cannot step from managed code to native code, or from native code to managed code, while debugging.  
  
### Workarounds  
  
- Debug your managed and native code in separate debugging sessions.  
  
     –or–  
  
     Debug your mixed code as a 32-bit process, as described in the following procedures.  
  
### To Change the Platform to 32-bit (Visual Basic or C#)  
  
1. In **Solution Explorer**, right-click on your project, then click **Properties** in the shortcut menu.  
  
2. In the property pages, click the **Compile** or **Debug** tab.  
  
3. Click **Platform** and select x86 from the list of platforms.  
  
     By default, the Visual Basic and C# compilers default produce code to run on any CPU. On a 64-bit computer, these binaries run as 64-bit processes. To run on a 32-bit process, you must choose **Win32**, not **AnyCPU**.  
  
### To Change the Platform to 32-bit (C/C++)  
  
1. In **Solution Explorer**, right-click on your project, then click **Properties** in the shortcut menu.  
  
2. In the Property Pages, click **Platform** and select Win32 from the list of platforms,  
  
## See Also  
 [Debug 64-Bit Applications](../debugger/debug-64-bit-applications.md)
