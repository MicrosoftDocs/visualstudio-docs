---
title: "IDebugFormatter::GetStringForVarType | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugFormatter.GetStringForVarType"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugFormatter::GetStringForVarType"
ms.assetid: 1c1a0499-ca57-47e0-8367-fdb4c902bca3
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugFormatter::GetStringForVarType
Returns a string that represents the given VARTYPE value.  
  
## Syntax  
  
```cpp
HRESULT GetStringForVarType(  
   VARTYPE    vt,  
   TYPEDESC*  ptdescArrayType,  
   BSTR*      pbstr  
);  
```  
  
#### Parameters  
 `vt`  
 [in] VARTYPE to represent as a string.  
  
 `ptdescArrayType`  
 [in] Array of structures that describes types.  
  
 `pbstr`  
 [out] String representing `vt`.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The method returns a string that represents the given VARTYPE value.  
  
## See also  
 [IDebugFormatter Interface](../../winscript/reference/idebugformatter-interface.md)