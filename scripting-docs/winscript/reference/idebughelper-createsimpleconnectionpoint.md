---
title: "IDebugHelper::CreateSimpleConnectionPoint | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugHelper.CreateSimpleConnectionPoint"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugHelper::CreateSimpleConnectionPoint"
ms.assetid: 5e4798ce-6f9f-4184-9853-67bf8c8524ab
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugHelper::CreateSimpleConnectionPoint
Returns an event interface that wraps a given `IDispatch` object.  
  
## Syntax  
  
```cpp
HRESULT CreateSimpleConnectionPoint(  
   IDispatch*                pdisp  
   ISimpleConnectionPoint**  ppscp  
);  
```  
  
#### Parameters  
 `pdisp`  
 [in] The `IDispatch` object to wrap.  
  
 `ppscp`  
 [out] The event interface that wraps `pdisp`.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 Returns an event interface that wraps the given `IDispatch` (see [ISimpleConnectionPoint Interface](../../winscript/reference/isimpleconnectionpoint-interface.md)).  
  
## See also  
 [IDebugHelper Interface](../../winscript/reference/idebughelper-interface.md)   
 [ISimpleConnectionPoint Interface](../../winscript/reference/isimpleconnectionpoint-interface.md)