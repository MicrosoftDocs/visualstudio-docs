---
title: "IDebugCoreServer2::GetPort | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugCoreServer2::GetPort"
helpviewer_keywords: 
  - "IDebugCoreServer2::GetPort"
ms.assetid: 3f5ea4a8-6085-4600-980a-9e48f8b5be56
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
# IDebugCoreServer2::GetPort
Retrieves a specific port.  
  
## Syntax  
  
```cpp#  
HRESULT GetPort(   
   REFGUID       guidPort,  
   IDebugPort2** ppPort  
);  
```  
  
```c#  
int GetPort(   
   ref Guid        guidPort,  
   out IDebugPort2 ppPort  
);  
```  
  
#### Parameters  
 `guidPort`  
 [in] GUID of the port to be retrieved.  
  
 `ppPort`  
 [out] Returns an [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) object representing the desired port.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_PORTSUPPLIER_NO_PORT` if there is no port with the given identifier.  
  
## See Also  
 [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)   
 [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)