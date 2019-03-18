---
title: "IActiveScriptProfilerControl3 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 64bc860a-54d4-475a-80f6-2f9dba6448ee
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerControl3 Interface
Provides a method to enumerate over the GC heap objects associated with a script engine.  
  
## Syntax  
  
```cpp
interface IActiveScriptProfilerControl3 : IActiveScriptProfilerControl2  
```  
  
## Methods  
 [IActiveScriptProfilerControl3::EnumHeap Method](../../winscript/reference/iactivescriptprofilercontrol3-enumheap-method.md)  
 Returns an interface ([IActiveScriptProfilerHeapEnum Interface](../../winscript/reference/iactivescriptprofilerheapenum-interface.md)) that can be used to iterate over the GC heap objects in the context of the associated script engine.