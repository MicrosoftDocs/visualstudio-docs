---
title: "IActiveScriptProfilerControl5 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 7fd0ce34-6ae3-428f-ba90-3e86a8a98ed0
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerControl5 Interface
Provides a method to enumerate over the GC heap objects associated with a script engine.  
  
## Syntax  
  
```cpp
interface IActiveScriptProfilerControl5 : IActiveScriptProfilerControl4  
```  
  
## Methods  
 [IActiveScriptProfilerControl5::EnumHeap2 Method](../../winscript/reference/iactivescriptprofilercontrol5-enumheap2-method.md)  
 Returns an interface ([IActiveScriptProfilerHeapEnum Interface](../../winscript/reference/iactivescriptprofilerheapenum-interface.md)) that can be used to iterate over the GC heap objects in the context of the associated script engine.