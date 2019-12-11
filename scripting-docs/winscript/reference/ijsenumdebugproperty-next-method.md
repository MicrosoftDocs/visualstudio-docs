---
title: "IJsEnumDebugProperty::Next Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsEnumDebugProperty.Next"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 9fad1893-483a-440c-88c1-469494212300
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsEnumDebugProperty::Next Method
Reads properties for this object.  
  
## Syntax  
  
```cpp
HRESULT Next(  
   ULONG count,  
   IJsDebugProperty **ppDebugProperty,  
   ULONG *pActualCount  
);  
```  
  
#### Parameters  
 `count`  
 [in] The number of properties to read.  
  
 `ppDebugProperty`  
 [out] Object representing the property browser.  
  
 `pActualCount`  
 [out] The actual number of properties of the object.  
  
## Return Value  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsEnumDebugProperty Interface](../../winscript/reference/ijsenumdebugproperty-interface.md)