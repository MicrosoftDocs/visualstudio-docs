---
title: "SCRIPTGCTYPE Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: f289cc7d-2a69-4720-bee0-ea27d054f308
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# SCRIPTGCTYPE Enumeration
The type of garbage collection to perform. Used in the [IActiveScriptGarbageCollector::CollectGarbage](../../winscript/reference/iactivescriptgarbagecollector-collectgarbage.md) method.  
  
## Syntax  
  
```cpp  
typedef enum tagSCRIPTGCTYPE {    SCRIPTGCTYPE_NORMAL           = 0,    SCRIPTGCTYPE_EXHAUSTIVE       = 1,} SCRIPTGCTYPE;  
```  
  
## Enumeration Values  
  
|||  
|-|-|  
|SCRIPTGCTYPE_NORMAL|Do normal garbage collection. The integer value is 0.|  
|SCRIPTGCTYPE_EXHAUSTIVE|Do exhaustive garbage collection. The integer value is 1.|  
  
## See also  
 [Active Script Constants, Enumerations, and Error Codes](../../winscript/reference/active-script-constants-enumerations-and-error-codes.md)