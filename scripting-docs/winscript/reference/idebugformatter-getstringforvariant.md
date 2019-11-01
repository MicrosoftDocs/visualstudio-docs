---
title: "IDebugFormatter::GetStringForVariant | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugFormatter.GetStringForVariant"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugFormatter::GetStringForVariant"
ms.assetid: 95189d03-1126-433e-8513-659107b3df16
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugFormatter::GetStringForVariant
Returns a string that represents the given VARIANT value.  
  
## Syntax  
  
```cpp
HRESULT GetStringForVariant(  
   VARIANT*  pvar,  
   ULONG     nRadix,  
   BSTR*     pbstrValue  
);  
```  
  
#### Parameters  
 `pvar`  
 [in] VARIANT to represent as a string.  
  
 `nRadix`  
 [in] Radix to use for numeric values.  
  
 `pbstrValue`  
 [out] String representing `pvar`.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns a string that represents the given variant value.  
  
## See also  
 [IDebugFormatter Interface](../../winscript/reference/idebugformatter-interface.md)