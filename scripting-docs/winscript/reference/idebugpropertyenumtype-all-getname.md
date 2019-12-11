---
title: "IDebugPropertyEnumType_All::GetName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugPropertyEnumType_All.GetName"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugPropertyEnumType_All::GetName"
ms.assetid: 24bbe4d5-4263-48d0-8e8d-bff957ffcad2
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugPropertyEnumType_All::GetName
Returns a BSTR containing the name of the `EnumType`.  
  
## Syntax  
  
```cpp
HRESULT GetName(  
   BSTR*  pname  
);  
```  
  
#### Parameters  
 `pname`  
 [out] A BSTR containing the name of the `EnumType`.  
  
## Return Value  
 Returns a valid `HRESULT`, typically `S_OK`.  
  
## See also  
 [IDebugPropertyEnumType_All Interface](../../winscript/reference/idebugpropertyenumtype-all-interface.md)