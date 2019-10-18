---
title: "IJsDebugProperty::GetMembers Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugProperty.GetMembers"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: a32b5372-d9cb-4b9a-9bc2-81b5e1df365c
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugProperty::GetMembers Method
Gets the members of this object.  
  
## Syntax  
  
```cpp
HRESULT GetMembers(  
   JS_PROPERTY_MEMBERS members,  
   IJsEnumDebugProperty **ppEnum  
);  
```  
  
#### Parameters  
 `members`  
 [in] Flags to specify what is included in the member information.  
  
 `ppEnum`  
 [out] The members of the object.  
  
## Return Value  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugProperty Interface](../../winscript/reference/ijsdebugproperty-interface.md)