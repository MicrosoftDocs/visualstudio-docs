---
title: "IDebugProperty::SetValueAsString | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugProperty.SetValueAsString"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugProperty::SetValueAsString"
ms.assetid: cad8d7b2-19a5-4a29-9000-cafdecdc238b
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugProperty::SetValueAsString
Sets the value of a property from a given string.  
  
## Syntax  
  
```cpp
HRESULT SetValueAsString (  
   LPCOLESTR pszValue,  
   UINTnRadix,  
);  
```  
  
#### Parameters  
 `pszValue`  
 [in] The value to be set.  
  
 `nRadix`  
 [in] Radix to be used in interpreting any numerical information.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IDebugProperty Interface](../../winscript/reference/idebugproperty-interface.md)