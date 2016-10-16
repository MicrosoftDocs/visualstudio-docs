---
title: "IDebugDefaultPort2::GetServer"
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
  - "IDebugDefaultPort2::GetServer"
helpviewer_keywords: 
  - "IDebugDefaultPort2::GetServer"
ms.assetid: cacb4b74-0f39-471c-af38-54b73f5b2868
caps.latest.revision: 10
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
# IDebugDefaultPort2::GetServer
This method obtains an interface to the server that this port is on.  
  
## Syntax  
  
```cpp  
HRESULT GetServer(  
   IDebugCoreServer3** ppServer  
);  
```  
  
```c#  
int GetServer(  
   out IDebugCoreServer3 ppServer  
);  
```  
  
#### Parameters  
 `ppServer`  
 [out] Returns an object implementing the [IDebugCoreServer3](../extensibility/idebugcoreserver3.md) interface.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The [IDebugCoreServer3](../extensibility/idebugcoreserver3.md) is implemented by Visual Studio and represents the server that the port is located on.  
  
## See Also  
 [IDebugDefaultPort2](../extensibility/idebugdefaultport2.md)   
 [IDebugCoreServer3](../extensibility/idebugcoreserver3.md)