---
title: "IEnumDebugApplicationNodes::Skip | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugApplicationNodes.Skip"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IEnumDebugApplicationNodes::Skip"
ms.assetid: b2ad1957-95b5-4c09-9a44-5a765a5308ae
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugApplicationNodes::Skip
Skips a specified number of segments in an enumeration sequence.  
  
## Syntax  
  
```cpp
HRESULT Skip(  
   ULONG  celt  
);  
```  
  
#### Parameters  
 `celt`  
 [in] Number of segments in the enumeration sequence to skip.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method skips a specified number of segments in an enumeration sequence.  
  
## See also  
 [IEnumDebugApplicationNodes Interface](../../winscript/reference/ienumdebugapplicationnodes-interface.md)