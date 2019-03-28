---
title: "Error: Mixed mode debugging is supported only when using Microsoft .NET Framework 2.0 or greater | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "troubleshooting"
f1_keywords:
  - "vs.debug.error.interop_unsupported_to_old"
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
# Error: Mixed mode debugging is supported only when using Microsoft .NET Framework 2.0 or greater
To debug mixed native and managed code, you must have [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] version 2.0, 3.0. 3.5, or 4.0. Mixed-mode debugging with earlier versions of the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] is not supported.

### To correct this error

- Upgrade the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] to version 2.0, 3.0, 3.5, or 4.0.

## See Also
- [Remote Debugging](../debugger/remote-debugging.md)