---
title: "IDebugCoreServer2::GetPortSupplier | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugCoreServer2::GetPortSupplier"
helpviewer_keywords: 
  - "IDebugCoreServer2::GetPortSupplier"
ms.assetid: acf181d4-ef42-4aa5-86f9-95fd5467ea31
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugCoreServer2::GetPortSupplier
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugCoreServer2::GetPortSupplier](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugcoreserver2-getportsupplier).  
  
Retrieves a specific port supplier.  
  
## Syntax  
  
```cpp#  
HRESULT GetPortSupplier(   
   REFGUID               guidPortSupplier,  
   IDebugPortSupplier2** ppPortSupplier  
);  
```  
  
```csharp  
int GetPortSupplier(   
   ref Guid                guidPortSupplier,  
   out IDebugPortSupplier2 ppPortSupplier  
);  
```  
  
#### Parameters  
 `guidPortSupplier`  
 [in] GUID of the port supplier to be retrieved.  
  
 `ppPortSupplier`  
 [out] Returns an [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md) object representing the desired port supplier.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)   
 [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)

