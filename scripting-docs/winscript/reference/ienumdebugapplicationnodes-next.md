---
title: "IEnumDebugApplicationNodes::Next | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugApplicationNodes.Next"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IEnumDebugApplicationNodes::Next"
ms.assetid: 925511c8-4f11-423d-ba2d-01589457050c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugApplicationNodes::Next
Retrieves a specified number of segments in the enumeration sequence.  
  
## Syntax  
  
```cpp
HRESULT Next(  
   ULONG                    celt,  
   IDebugApplicationNode**  pprddp,  
   ULONG*                   pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of segments to retrieve.  
  
 `pprddp`  
 [out] Returns an array of `IDebugApplicationNode` interfaces that represents the segments being retrieved.  
  
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
 [IEnumDebugApplicationNodes Interface](../../winscript/reference/ienumdebugapplicationnodes-interface.md)