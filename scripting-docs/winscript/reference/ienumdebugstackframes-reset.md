---
title: "IEnumDebugStackFrames::Reset | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugStackFrames.Reset"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IEnumDebugStackFrames::Reset"
ms.assetid: 57be2683-5346-4464-bdf5-6fd45b56253a
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugStackFrames::Reset
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
 [IEnumDebugStackFrames Interface](../../winscript/reference/ienumdebugstackframes-interface.md)