---
title: "JsDebugPropertyInfo Structure | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "JsDebugPropertyInfo"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 3a5463a7-2013-4846-9ab2-8beb675a5a6a
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsDebugPropertyInfo Structure
Indicates information about a property.  
  
## Syntax  
  
```cpp
typedef struct tagJsDebugPropertyInfo{   BSTR name;   BSTR type;   BSTR value;   BSTR fullName;   JS_PROPERTY_ATTRIBUTES attr;} JsDebugPropertyInfo;  
```  
  
## Members  
 `name`  
 The name of the property.  
  
 `type`  
 The type of the property.  
  
 `value`  
 The value of the property.  
  
 `fullName`  
 The full name of the property.  
  
 `attr`  
 An enumeration that represents the property attributes.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [Windows Script Interfaces Reference](../../winscript/reference/windows-script-interfaces-reference.md)