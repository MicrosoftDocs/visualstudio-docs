---
title: "IEnumDebugStackFrames::Clone | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugStackFrames.Clone"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IEnumDebugStackFrames::Clone"
ms.assetid: 9d9e01a3-0be3-4336-832a-f065af388571
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugStackFrames::Clone
Creates an enumerator that contains the same state as the current enumerator.  
  
## Syntax  
  
```cpp
HRESULT Clone(  
   IEnumDebugStackFrames**  ppedsf  
);  
```  
  
#### Parameters  
 `ppedsf`  
 [out] Returns the `IEnumDebugStackFrames` interface of the clone of the enumerator.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method creates an enumerator that contains the same state as the current enumerator.  
  
## See also  
 [IEnumDebugStackFrames Interface](../../winscript/reference/ienumdebugstackframes-interface.md)