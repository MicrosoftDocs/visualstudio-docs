---
title: "IEnumDebugExpressionContexts::Next | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugExpressionContexts.Next"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IEnumDebugExpressionContexts::Next"
ms.assetid: aa223b0b-f7c1-4368-a59e-677e60133baf
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugExpressionContexts::Next
Retrieves a specified number of segments in the enumeration sequence.  
  
## Syntax  
  
```cpp
HRESULT Next(  
   ULONG                      celt,  
   IDebugExpressionContext**  ppdec,  
   ULONG*                     pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of segments to retrieve.  
  
 `ppdec`  
 [out] Returns an array of `IDebugExpressionContext` interfaces that represents the segments being retrieved.  
  
 `pceltFetched`  
 [out] The actual number of segments fetched by the enumerator.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method retrieves a specified number of segments in the enumeration sequence.  
  
## See also  
 [IEnumDebugExpressionContexts Interface](../../winscript/reference/ienumdebugexpressioncontexts-interface.md)