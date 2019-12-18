---
title: "IDebugApplication::RemoveStackFrameSniffer | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.RemoveStackFrameSniffer"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::RemoveStackFrameSniffer"
ms.assetid: 00304b88-e435-4b87-a331-44e7492eb32d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::RemoveStackFrameSniffer
Removes a stack frame enumerator provider from this application.  
  
## Syntax  
  
```cpp
HRESULT RemoveStackFrameSniffer(  
   DWORD  dwCookie  
);  
```  
  
#### Parameters  
 `dwCookie`  
 [in] The cookie returned by the `AddStackFrameSniffer` method when the stack frame enumerator provider was added.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The `RemoveStackFrameSniffer` method removes a stack frame enumerator provider from this application.  
  
## See also  
 [IDebugApplication::AddStackFrameSniffer](../../winscript/reference/idebugapplication-addstackframesniffer.md)   
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)   
 [IDebugStackFrameSniffer Interface](../../winscript/reference/idebugstackframesniffer-interface.md)