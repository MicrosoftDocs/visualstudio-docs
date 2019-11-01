---
title: "IEnumDebugExpressionContexts::Clone | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugExpressionContexts.Clone"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IEnumDebugExpressionContexts::Clone"
ms.assetid: c8070ae1-120c-4b5d-bd3d-ae8fca6f9277
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugExpressionContexts::Clone
Creates an enumerator that contains the same state as the current enumerator.  
  
## Syntax  
  
```cpp
HRESULT Clone(  
   IEnumDebugExpressionContexts**  ppedec  
);  
```  
  
#### Parameters  
 `ppedec`  
 [out] Returns the `IEnumDebugExpressionContexts` interface of the clone of the enumerator.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method creates an enumerator that contains the same state as the current enumerator.  
  
## See also  
 [IEnumDebugExpressionContexts Interface](../../winscript/reference/ienumdebugexpressioncontexts-interface.md)