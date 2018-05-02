---
title: "IDebugPortSupplier2::GetPortSupplierId | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugPortSupplier2::GetPortSupplierId"
helpviewer_keywords: 
  - "IDebugPortSupplier2::GetPortSupplierId"
ms.assetid: 741d0829-0943-49bf-b56e-61e836043006
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugPortSupplier2::GetPortSupplierId
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugPortSupplier2::GetPortSupplierId](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugportsupplier2-getportsupplierid).  
  
Gets the port supplier identifier.  
  
## Syntax  
  
```cpp#  
HRESULT GetPortSupplierId(   
   GUID* pguidPortSupplier  
);  
```  
  
```csharp  
HRESULT GetPortSupplierId(   
   out Guid pguidPortSupplier  
);  
```  
  
#### Parameters  
 `pguidPortSupplier`  
 [out] Returns the GUID of the port supplier.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)

