---
title: "IDebugApplication::AddStackFrameSniffer | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.AddStackFrameSniffer"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::AddStackFrameSniffer"
ms.assetid: a7a9684a-14c5-415a-ae63-a17397d58d07
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::AddStackFrameSniffer
Adds a stack frame enumerator provider to this application.  
  
## Syntax  
  
```cpp
HRESULT AddStackFrameSniffer(  
   IDebugStackFrameSniffer*  pdsfs,  
   DWORD*                    pdwCookie  
);  
```  
  
#### Parameters  
 `pdsfs`  
 [in] The stack frame enumerator provider to add to this application.  
  
 `pdwCookie`  
 [out] A cookie that is used to remove this stack frame enumerator provider from the application.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 Although language engines typically call this method to expose their stack frames to the debugger, it is possible for other entities to expose stack frames.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)   
 [IDebugApplication::RemoveStackFrameSniffer](../../winscript/reference/idebugapplication-removestackframesniffer.md)   
 [IDebugStackFrameSniffer Interface](../../winscript/reference/idebugstackframesniffer-interface.md)