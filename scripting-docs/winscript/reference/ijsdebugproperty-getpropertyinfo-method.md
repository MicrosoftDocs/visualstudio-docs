---
title: "IJsDebugProperty::GetPropertyInfo Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugProperty.GetPropertyInfo"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: ab9d6e0b-0448-4f21-b0b0-1738867587d2
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugProperty::GetPropertyInfo Method
Gets Information for this object.  
  
## Syntax  
  
```cpp
HRESULT GetPropertyInfo(  
   UINT nRadix,  
   JsDebugPropertyInfo *pPropertyInfo  
);  
```  
  
#### Parameters  
 `nRadix`  
 [in] Radix to use.  
  
 `pPropertyInfo`  
 [out] Information about the object.  
  
## Return Value  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugProperty Interface](../../winscript/reference/ijsdebugproperty-interface.md)