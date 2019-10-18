---
title: "JS_PROPERTY_ATTRIBUTES Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "JS_PROPERTY_ATTRIBUTES"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: e83b9b6c-5b21-48d1-92b6-22bed926b18b
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JS_PROPERTY_ATTRIBUTES Enumeration
Indicates the attributes of a property.  
  
## Syntax  
  
```cpp
enum JS_PROPERTY_ATTRIBUTES{   JS_PROPERTY_ATTRIBUTE_NONE = 0,   JS_PROPERTY_HAS_CHILDREN = 0x1,   JS_PROPERTY_FAKE = 0x2,   JS_PROPERTY_METHOD = 0x4,   JS_PROPERTY_READONLY = 0x8,   JS_PROPERTY_NATIVE_WINRT_POINTER = 0x10} JS_PROPERTY_ATTRIBUTES;  
```  
  
## Members  
  
|Name|Description|  
|----------|-----------------|  
|`JS_PROPERTY_ATTRIBUTE_NONE`|The property has no attributes.|  
|`JS_PROPERTY_HAS_CHILDREN`|The property has children.|  
|`JS_PROPERTY_FAKE`|The property represents a fake node, such as "[Methods]".|  
|`JS_PROPERTY_METHOD`|The property is a method.|  
|`JS_PROPERTY_READONLY`|The property is read-only.|  
|`JS_PROPERTY_NATIVE_WINRT_POINTER`|The property is a pointer to a native WinRT object.|  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [Windows Script Interfaces Reference](../../winscript/reference/windows-script-interfaces-reference.md)