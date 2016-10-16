---
title: "IDebugDefaultPort2::GetPortNotify"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugDefaultPort2::GetPortNotify"
helpviewer_keywords: 
  - "IDebugDefaultPort2::GetPortNotify"
ms.assetid: 3ae715ee-9886-4694-a52b-59bb3b27467a
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugDefaultPort2::GetPortNotify
This method gets an [IDebugPortNotify2](../extensibility/idebugportnotify2.md) interface for this port.  
  
## Syntax  
  
```cpp  
HRESULT GetPortNotify(  
   IDebugPortNotify2** ppPortNotify  
);  
```  
  
```c#  
int GetPortNotify(  
   out IDebugPortNotify2 ppPortNotify  
);  
```  
  
#### Parameters  
 `ppPortNotify`  
 [out] An [IDebugPortNotify2](../extensibility/idebugportnotify2.md) object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Normally, the `QueryInterface` method is called on the object implementing the [IDebugPort2](../extensibility/idebugport2.md) interface to obtain an [IDebugPortNotify2](../extensibility/idebugportnotify2.md) interface. However, there are circumstances in which the desired interface is implemented on a different object. This method hides those circumstances and returns the `IDebugPortNotify2` interface from the most appropriate object.  
  
## See Also  
 [IDebugDefaultPort2](../extensibility/idebugdefaultport2.md)   
 [IDebugPortNotify2](../extensibility/idebugportnotify2.md)