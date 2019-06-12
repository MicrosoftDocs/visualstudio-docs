---
title: "IDebugPortSupplierEx2::SetServer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugPortSupplierEx2::SetServer"
ms.assetid: 0e8ef194-3a4f-4abf-8382-4607ab3005d1
caps.latest.revision: 6
ms.author: gregvanl
manager: jillfra
---
# IDebugPortSupplierEx2::SetServer
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Sets the core server for the port supplier.  
  
## Syntax  
  
```cpp#  
HRESULT SetServer(  
   IDebugCoreServer2* pServer  
);  
```  
  
```csharp  
int SetServer(  
   IDebugCoreServer2 pServer  
);  
```  
  
#### Parameters  
 `pServer`  
 Core server to set for the port supplier.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPortSupplierEx2](../../../extensibility/debugger/reference/idebugportsupplierex2.md)
