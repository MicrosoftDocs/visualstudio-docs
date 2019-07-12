---
title: "Error: Mixed-mode debugging for x64 processes is supported only when using Microsoft .NET Framework 4 or greater | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.debug.error.interop_unsupported_x64"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: e4b0216c-7006-4832-883f-08e982ba8d3f
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: Mixed-mode debugging for x64 processes is supported only when using Microsoft .NET Framework 4 or greater
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To debug mixed native and managed code in a 64-bit process, you must have [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] version 4. Mixed-mode debugging of 64-bit processes with [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] versions earlier than 4 is not supported.  
  
### To correct this error  
  
- Perform one of the following steps:  
  
  - Upgrade your [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] to version 4.  

  - Build a 32-bit version of your application for debugging.  
  
## See Also  
 [Set Up the Remote Tools on the Device](https://msdn.microsoft.com/library/90f45630-0d26-4698-8c1f-63f85a12db9c)
