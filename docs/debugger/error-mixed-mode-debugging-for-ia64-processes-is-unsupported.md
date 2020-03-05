---
title: "Error: Mixed mode debugging for IA64 processes is unsupported | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "troubleshooting"
f1_keywords:
  - "vs.debug.error.interop_unsupported_ia64"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Error: Mixed mode debugging for IA64 processes is unsupported
The [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] debugger does not support debugging mixed native and managed code in an Itanium-based process.

### To correct this error

- Build a 32-bit version of your application for debugging.

## See also
- [Remote Debugging](../debugger/remote-debugging.md)