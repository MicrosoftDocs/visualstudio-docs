---
title: "IDebugDefaultPort2::GetPortNotify | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugDefaultPort2::GetPortNotify"
helpviewer_keywords: 
  - "IDebugDefaultPort2::GetPortNotify"
ms.assetid: 3ae715ee-9886-4694-a52b-59bb3b27467a
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugDefaultPort2::GetPortNotify
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method gets an [IDebugPortNotify2](../../../extensibility/debugger/reference/idebugportnotify2.md) interface for this port.  
  
## Syntax  
  
```cpp  
HRESULT GetPortNotify(  
   IDebugPortNotify2** ppPortNotify  
);  
```  
  
```csharp  
int GetPortNotify(  
   out IDebugPortNotify2 ppPortNotify  
);  
```  
  
#### Parameters  
 `ppPortNotify`  
 [out] An [IDebugPortNotify2](../../../extensibility/debugger/reference/idebugportnotify2.md) object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Normally, the `QueryInterface` method is called on the object implementing the [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) interface to obtain an [IDebugPortNotify2](../../../extensibility/debugger/reference/idebugportnotify2.md) interface. However, there are circumstances in which the desired interface is implemented on a different object. This method hides those circumstances and returns the `IDebugPortNotify2` interface from the most appropriate object.  
  
## See Also  
 [IDebugDefaultPort2](../../../extensibility/debugger/reference/idebugdefaultport2.md)   
 [IDebugPortNotify2](../../../extensibility/debugger/reference/idebugportnotify2.md)
