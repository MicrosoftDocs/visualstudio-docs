---
title: "IDebugApplicationThread::SetStateString | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplicationThread.SetStateString"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplicationThread::SetStateString"
ms.assetid: a59001d5-ea00-4fd0-bb20-0b592d9c795d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationThread::SetStateString
Sets the description of thread state.  
  
## Syntax  
  
```cpp
HRESULT SetStateString(  
   LPCOLESTR  pstrState  
);  
```  
  
#### Parameters  
 `pstrState`  
 [in] The description of the thread state.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method sets the description of the thread state.  
  
## See also  
 [IDebugApplicationThread Interface](../../winscript/reference/idebugapplicationthread-interface.md)