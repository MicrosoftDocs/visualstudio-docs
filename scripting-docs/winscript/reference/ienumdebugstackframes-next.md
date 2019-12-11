---
title: "IEnumDebugStackFrames::Next | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugStackFrames.Next"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IEnumDebugStackFrames::Next"
ms.assetid: ade3f5b0-8ff3-48a0-9433-270789e6d53e
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugStackFrames::Next
Retrieves a specified number of segments in the enumeration sequence.  
  
## Syntax  
  
```cpp
HRESULT Next(  
   ULONG                       celt,  
   DebugStackFrameDescriptor*  prgdsfd,  
   ULONG*                      pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of segments to retrieve.  
  
 `prgdsfd`  
 [out] Returns an array of `DebugStackFrameDescriptor` interfaces that represents the segments being retrieved.  
  
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
 [IEnumDebugStackFrames Interface](../../winscript/reference/ienumdebugstackframes-interface.md)   
 [DebugStackFrameDescriptor Structure](../../winscript/reference/debugstackframedescriptor-structure.md)