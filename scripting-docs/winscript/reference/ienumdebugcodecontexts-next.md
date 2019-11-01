---
title: "IEnumDebugCodeContexts::Next | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugCodeContexts.Next"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IEnumDebugCodeContexts::Next"
ms.assetid: 844cc353-ae0b-45e1-84a6-32b0bb67f57f
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugCodeContexts::Next
Retrieves a specified number of segments in the enumeration sequence.  
  
## Syntax  
  
```cpp
HRESULT Next(  
   ULONG                celt,  
   IDebugCodeContext**  pscc,  
   ULONG*               pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of segments to retrieve.  
  
 `pscc`  
 [out] Returns an array of `IDebugCodeContext` interfaces that represents the segments being retrieved.  
  
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
 [IEnumDebugCodeContexts Interface](../../winscript/reference/ienumdebugcodecontexts-interface.md)