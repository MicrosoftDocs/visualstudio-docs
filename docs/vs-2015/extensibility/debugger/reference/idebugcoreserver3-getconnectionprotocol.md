---
title: "IDebugCoreServer3::GetConnectionProtocol | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugCoreServer3::GetConnectionProtocol"
helpviewer_keywords: 
  - "IDebugCoreServer3::GetConnectionProtocol"
ms.assetid: 368ced5b-c5d9-4090-a5b4-26ff400d1a55
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugCoreServer3::GetConnectionProtocol
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Returns a value indicating the protocol that is being used to communicate between the server and the debug package.  
  
## Syntax  
  
```cpp#  
HRESULT GetConnectionProtocol(  
   CONNECTION_PROTOCOL* pProtocol  
);  
```  
  
```csharp  
int GetConnectionProtocol(  
   CONNECTION_PROTOCOL[] pProtocol  
);  
```  
  
#### Parameters  
 `pProtocol`  
 [out] Returns one of the values from the [CONNECTION_PROTOCOL](../../../extensibility/debugger/reference/connection-protocol.md) enumeration.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## See Also  
 [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)   
 [CONNECTION_PROTOCOL](../../../extensibility/debugger/reference/connection-protocol.md)
