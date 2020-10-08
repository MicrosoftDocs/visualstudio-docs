---
title: "Mixed Mode Debugging Is Only Supported when Using Microsoft .NET Framework 2.0 or 3.0 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.error.interop_unsupported_to_old"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: f607af6f-57fe-472a-a32e-b6202067aa96
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Mixed Mode Debugging Is Only Supported when Using Microsoft .NET Framework 2.0 or 3.0
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Versions of the Microsoft .NET Framework earlier than 2.0 do not provide support for mixed-mode debugging of 64-bit processes. This means that you cannot step from managed code to native code, or from native code to managed code, while you are debugging.  
  
 To work around this problem, you can:  
  
- Update your project to use either Microsoft .NET Framework 2.0 or 3.0.  
  
- Debug your managed and native code in separate debugging sessions.  
  
- Debug your mixed code as a 32-bit process, as described in the following procedures.  
  
### To change the operating system to 32-bit (Visual Basic or C#)  
  
1. In **Solution Explorer**, right-click your project, and then click **Properties** in the shortcut menu.  
  
2. In the property pages, click the **Compile** or **Debug** tab.  
  
3. Click **Platform**, and then select **x86** from the list of platforms.  
  
     By default, the Visual Basic and C# compilers produce code to run on any CPU. On a 64-bit computer, these binaries run as 64-bit processes. To run on a 32-bit process, you must choose **Win32**, not **AnyCPU**.  
  
### To change the operating system to 32-bit (C/C++)  
  
1. In **Solution Explorer**, right-click your project, and then click **Properties** in the shortcut menu.  
  
     In the property pages, click **Platform**, and then select **Win32** from the list of platforms.  
  
### To correct this error  
  
- See [Setting Up SQL Debugging](https://msdn.microsoft.com/3db09e68-edcc-42de-9c22-4e97cfd55ab3).  
  
## See Also  
 [Debug 64-Bit Applications](../debugger/debug-64-bit-applications.md)
