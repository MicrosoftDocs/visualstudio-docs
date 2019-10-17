---
title: "IDebugApplicationThread::SetDescription | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplicationThread.SetDescription"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplicationThread::SetDescription"
ms.assetid: 084e5b74-af95-41b4-ae55-01f6f4d22168
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationThread::SetDescription
Sets the description of this thread.  
  
## Syntax  
  
```cpp
HRESULT SetDescription(  
   LPCOLESTR  pstrDescription  
);  
```  
  
#### Parameters  
 `pstrDescription`  
 [in] The description of this thread.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method sets the description of this thread.  
  
## See also  
 [IDebugApplicationThread Interface](../../winscript/reference/idebugapplicationthread-interface.md)