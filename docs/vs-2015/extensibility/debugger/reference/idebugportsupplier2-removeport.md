---
title: "IDebugPortSupplier2::RemovePort | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugPortSupplier2::RemovePort"
helpviewer_keywords: 
  - "IDebugPortSupplier2::RemovePort"
ms.assetid: f5c1fbf2-9084-46f2-a682-7db963928df2
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugPortSupplier2::RemovePort
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Removes a port.  
  
## Syntax  
  
```cpp#  
HRESULT RemovePort(   
   IDebugPort2* pPort  
);  
```  
  
```csharp  
int RemovePort(   
   IDebugPort2 pPort  
);  
```  
  
#### Parameters  
 `pPort`  
 [in] An [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) object that represents the port to be removed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method removes the port from the port supplier's internal list of active ports.  
  
## See Also  
 [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)   
 [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
