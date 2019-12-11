---
title: "IDebugStackFrame::GetThread | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugStackFrame.GetThread"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugStackFrame::GetThread"
ms.assetid: ece24728-a6b2-4b01-a6f0-0a82b15be39b
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugStackFrame::GetThread
Returns the thread associated with this stack frame.  
  
## Syntax  
  
```cpp
HRESULT GetThread(  
   IDebugApplicationThread**  ppat  
);  
```  
  
#### Parameters  
 `ppat`  
 [out] The thread associated with this stack frame.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the thread associated with this stack frame.  
  
## See also  
 [IDebugStackFrame Interface](../../winscript/reference/idebugstackframe-interface.md)