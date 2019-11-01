---
title: "IEnumDebugApplicationNodes::Clone | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugApplicationNodes.Clone"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IEnumDebugApplicationNodes::Clone"
ms.assetid: 7190954d-e2da-4a84-8e37-81d4d27886a8
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugApplicationNodes::Clone
Creates an enumerator that contains the same state as the current enumerator.  
  
## Syntax  
  
```cpp
HRESULT Clone(  
   IEnumDebugApplicationNodes**  pperddp  
);  
```  
  
#### Parameters  
 `pperddp`  
 [out] Returns the `IEnumDebugApplicationNodes` interface of the clone of the enumerator.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method creates an enumerator that contains the same state as the current enumerator.  
  
## See also  
 [IEnumDebugApplicationNodes Interface](../../winscript/reference/ienumdebugapplicationnodes-interface.md)