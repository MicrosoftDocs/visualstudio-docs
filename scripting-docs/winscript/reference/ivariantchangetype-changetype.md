---
title: "IVariantChangeType::ChangeType | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IVariantChangeType.ChangeType"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IVariantChangeType::ChangeType"
ms.assetid: 52374764-c42e-49af-a219-ee00c535a118
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IVariantChangeType::ChangeType
Takes a variant value and creates a new variant with a specified type.  
  
## Syntax  
  
```cpp
HRESULT ChangeType(  
   VARIANT*  pvarDst,  
   VARIANT*  pvarSrc,  
   LCID  lcid,  
   VARTYPE  vtNew  
);  
```  
  
#### Parameters  
 `pvarDst`  
 [in, out] A variant to contain the value represented by `pvarSrc`, but with the type specified by `vtNew`.  
  
 `pvarSrc`  
 [in] A variant value to change into a new type.  
  
 `lcid`  
 [in] The locale context to use when converting the arguments to or from strings.  
  
 `vtNew`  
 [in] Specifies the type for `pvarDst` to become.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The `pvarDst` and `pvarSrc` arguments may be equal, in which case the original value is overwritten. This method passes `pvarDst` to the `VariantClear` function, and consequently `pvarDst` should be initialized to a valid value.  
  
## See also  
 [IVariantChangeType Interface](../../winscript/reference/ivariantchangetype-interface.md)