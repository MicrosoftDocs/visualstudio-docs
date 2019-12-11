---
title: "IDebugStackFrame::GetDebugProperty | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugStackFrame.GetDebugProperty"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugStackFrame::GetDebugProperty"
ms.assetid: e03c7504-bce4-4a44-81e4-db8c0216538d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugStackFrame::GetDebugProperty
Returns a property browser for the current frame.  
  
## Syntax  
  
```cpp
HRESULT GetDebugProperty(  
   IDebugProperty**  ppDebugProp  
);  
```  
  
#### Parameters  
 `ppDebugProp`  
 [out] A property browser for the current frame.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns a property browser for the current frame.  
  
## See also  
 [IDebugStackFrame Interface](../../winscript/reference/idebugstackframe-interface.md)