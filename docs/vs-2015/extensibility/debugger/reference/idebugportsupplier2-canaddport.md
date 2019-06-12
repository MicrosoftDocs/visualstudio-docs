---
title: "IDebugPortSupplier2::CanAddPort | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugPortSupplier2::CanAddPort"
helpviewer_keywords: 
  - "IDebugPortSupplier2::CanAddPort"
ms.assetid: 41f69e0a-e82c-473d-8b7a-0c40fc5730fc
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugPortSupplier2::CanAddPort
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Verifies that a port supplier can add new ports.  
  
## Syntax  
  
```cpp#  
HRESULT CanAddPort(   
   void   
);  
```  
  
```csharp  
int CanAddPort();  
```  
  
## Return Value  
 If the port can be added, returns `S_OK`; otherwise, returns `S_FALSE` to indicate no ports can be added to this port supplier.  
  
## Remarks  
 Call this method before calling the [AddPort](../../../extensibility/debugger/reference/idebugportsupplier2-addport.md) method since the latter method creates the port as well as adding it, which could be a time-consuming operation.  
  
## See Also  
 [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)   
 [AddPort](../../../extensibility/debugger/reference/idebugportsupplier2-addport.md)
