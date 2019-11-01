---
title: "IActiveScriptGarbageCollector::CollectGarbage | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 75f77c49-2190-4d49-a3e0-9dcf847c502b
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptGarbageCollector::CollectGarbage
The Active Script host calls this method to start garbage collection.  
  
## Syntax  
  
```cpp
HRESULT CollectGarbage(        SCRIPTGCTYPE scriptgctype    );  
```  
  
#### Parameters  
 `scriptgctype`  
 [in] The [SCRIPTGCTYPE Enumeration](../../winscript/reference/scriptgctype-enumeration.md) that specifies whether to do normal or exhaustive garbage collection.  
  
## Return Value  
 Returns an HRESULT.  
  
## See also  
 [IActiveScriptGarbageCollector Interface](../../winscript/reference/iactivescriptgarbagecollector-interface.md)