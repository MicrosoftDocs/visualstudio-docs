---
title: "JsDebugReadMemoryFlags Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "JsDebugReadMemoryFlags"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 0d98d154-9cb1-49de-b2df-a2d029d343b7
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsDebugReadMemoryFlags Enumeration
Flags to specify behavior when reading memory.  
  
## Syntax  
  
```cpp
enum JsDebugReadMemoryFlags{   None = 0,   JsDebugAllowPartialRead= 0x1} JsDebugReadMemoryFlags;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`JsDebugAllowPartialRead`|Indicates that the caller wants the read operation to succeed if only part of the memory read succeeded. If this is set, an E_JsDEBUG_INVALID_MEMORY_ADDRESS error will only be raised if 'Address' is invalid. If this flag is clear, a E_JsDEBUG_INVALID_MEMORY_ADDRESS error will be raised if any portion of the requested memory was unreadable.|  
|`None`|Indicates that the caller wants the default behavior for ReadMemory.|  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [Windows Script Interfaces Reference](../../winscript/reference/windows-script-interfaces-reference.md)