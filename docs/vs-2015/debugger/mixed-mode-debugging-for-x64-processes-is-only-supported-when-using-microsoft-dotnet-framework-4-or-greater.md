---
title: "Mixed mode debugging for x64 processes is only supported when using Microsoft.NET Framework 4 or greater | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.error.interop_unsupported_x64"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: b7495655-54c0-4315-8422-43bf63b8c22e
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Mixed mode debugging for x64 processes is only supported when using Microsoft.NET Framework 4 or greater
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

NET Framework versions earlier than 4 do not provide support for mixed-mode debugging of x64 processes. That means that you cannot step from managed code to native code, or from native code to managed code, while debugging.  
  
### Workarounds  
  
- Update your project to use Microsoft .NET Framework 4 or later.  
  
     –or–  
  
     Debug your managed and native code in separate debugging sessions.  
  
     –or–  
  
     Debug your mixed code as a 32-bit process, as described in the following procedures.  
  
### To change the platform to 32-bit (Visual Basic or C#)  
  
1. In **Solution Explorer**, right-click your project, and then click **Properties**.  
  
2. In the property pages, click the **Compile** or the **Debug** tab.  
  
3. Click **Platform** and select x86 from the list of platforms.  
  
     By default, the Visual Basic and C# compilers default produce code to run on any CPU. On a 64-bit computer, these binaries run as 64-bit processes. To run on a 32-bit process, you must choose **Win32**, not **AnyCPU**.  
  
### To change the platform to 32-bit (C/C++)  
  
1. In **Solution Explorer**, right-click your project, then click **Properties**.  
  
2. In the Property Pages, click **Platform** and select Win32 from the list of platforms.  
  
### To correct this error  
  
- See [Setting Up SQL Debugging](https://msdn.microsoft.com/3db09e68-edcc-42de-9c22-4e97cfd55ab3).  
  
## See Also  
 [Debug 64-Bit Applications](../debugger/debug-64-bit-applications.md)
