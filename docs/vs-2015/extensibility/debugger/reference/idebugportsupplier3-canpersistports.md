---
title: "IDebugPortSupplier3::CanPersistPorts | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugPortSupplier3::CanPersistPorts"
helpviewer_keywords: 
  - "IDebugPortSupplier3::CanPersistPorts"
ms.assetid: 4127760c-e602-4e86-9232-457e382a52c7
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugPortSupplier3::CanPersistPorts
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method determines whether the port supplier can persist ports (by writing them to disk) between invocations of the debugger.  
  
## Syntax  
  
```cpp  
HRESULT CanPersistPorts();  
```  
  
```csharp  
int CanPersistPorts();  
```  
  
#### Parameters  
 None.  
  
## Return Value  
 `S_OK` if ports can be persisted, or `S_FALSE` to indicate that ports cannot be persisted.  
  
## Remarks  
 If the port supplier can persist ports, it should do so when it is destroyed and then reload them when it is instantiated once again.  
  
## See Also  
 [IDebugPortSupplier3](../../../extensibility/debugger/reference/idebugportsupplier3.md)
