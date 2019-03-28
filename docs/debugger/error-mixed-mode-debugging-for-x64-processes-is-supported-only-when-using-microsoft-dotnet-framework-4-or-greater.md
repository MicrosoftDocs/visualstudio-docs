---
title: "Error: Mixed-mode debugging for x64 processes is supported only when using Microsoft .NET Framework 4 or greater | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "troubleshooting"
f1_keywords:
  - "vs.debug.error.interop_unsupported_x64"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "dotnet"
---
# Error: Mixed-mode debugging for x64 processes is supported only when using Microsoft .NET Framework 4 or greater
To debug mixed native and managed code in a 64-bit process, you must have [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] version 4. Mixed-mode debugging of 64-bit processes with [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] versions earlier than 4 is not supported.

### To correct this error

- Perform one of the following steps:

  - Upgrade your [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] to version 4.

  - Build a 32-bit version of your application for debugging.

## See Also
- [Remote Debugging](../debugger/remote-debugging.md)