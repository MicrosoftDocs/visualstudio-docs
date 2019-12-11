---
title: "IDebugApplication::FireDebuggerEvent | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.FireDebuggerEvent"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::FireDebuggerEvent"
ms.assetid: fd1f602e-fc15-4158-a6e7-497ff5b4a509
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::FireDebuggerEvent
Fires a generic event to the debugger's `IApplicationDebugger` interface.  
  
## Syntax  
  
```cpp
HRESULT FireDebuggerEvent(  
   REFGUID    riid,  
   IUnknown*  punk  
);  
```  
  
#### Parameters  
 `riid`  
 [in] A GUID for the object.  
  
 `punk`  
 [in] An event object to pass to the debugger.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_NOTIMPL`|The method is not currently implemented.|  
  
## Remarks  
 The semantics of the GUID and the `IUnknown` are entirely application/debugger defined.  
  
 This method allows for custom extensions of the debugger model; it is not currently implemented.  
  
 This method causes `IApplicationDebugger::onDebuggerEvent` to be called.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)   
 [IApplicationDebugger::onDebuggerEvent](../../winscript/reference/iapplicationdebugger-ondebuggerevent.md)