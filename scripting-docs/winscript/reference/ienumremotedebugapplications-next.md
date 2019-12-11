---
title: "IEnumRemoteDebugApplications::Next | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumRemoteDebugApplications.Next"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IEnumRemoteDebugApplications::Next"
ms.assetid: 33f6c620-6dd3-4057-b982-b88a7a1f02b4
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumRemoteDebugApplications::Next
The `Next` method retrieves a specified number of segments in the enumeration sequence.  
  
## Syntax  
  
```cpp
HRESULT Next(  
   ULONG                      celt,  
   IRemoteDebugApplication**  ppda,  
   ULONG*                     pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of segments to retrieve.  
  
 `ppda`  
 [out] Returns an array of `IRemoteDebugApplication` interfaces that represents the segments being retrieved.  
  
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
 [IEnumRemoteDebugApplications Interface](../../winscript/reference/ienumremotedebugapplications-interface.md)