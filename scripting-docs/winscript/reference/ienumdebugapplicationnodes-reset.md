---
title: "IEnumDebugApplicationNodes::Reset | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugApplicationNodes.Reset"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IEnumDebugApplicationNodes::Reset"
ms.assetid: 56ecdafe-ff11-461a-92e1-93254a49f1a1
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugApplicationNodes::Reset
Resets an enumeration sequence to the beginning.  
  
## Syntax  
  
```cpp
HRESULT Reset();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method resets an enumeration sequence to the beginning.  
  
## See also  
 [IEnumDebugApplicationNodes Interface](../../winscript/reference/ienumdebugapplicationnodes-interface.md)