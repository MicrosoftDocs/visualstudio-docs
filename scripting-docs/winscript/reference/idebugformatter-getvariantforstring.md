---
title: "IDebugFormatter::GetVariantForString | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugFormatter.GetVariantForString"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugFormatter::GetVariantForString"
ms.assetid: 2993431d-0ee2-4d8d-b62c-0a810a8bc391
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugFormatter::GetVariantForString
Returns a VARIANT containing the given string.  
  
## Syntax  
  
```cpp
HRESULT GetVariantForString(  
   LPCOLESTR  pwstrValue,  
   VARIANT*   pvar  
);  
```  
  
#### Parameters  
 `pwstrValue`  
 [in] String to store in a VARIANT.  
  
 `pvar`  
 [out] VARIANT containing `pwstrValue`.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns a VARIANT containing the given string.  
  
## See also  
 [IDebugFormatter Interface](../../winscript/reference/idebugformatter-interface.md)