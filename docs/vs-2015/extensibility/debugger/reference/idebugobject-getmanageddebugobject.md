---
title: "IDebugObject::GetManagedDebugObject | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugObject::GetManagedDebugObject"
helpviewer_keywords: 
  - "IDebugObject::GetManagedDebugObject method"
ms.assetid: cb89692e-7657-47ff-846d-311943521951
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugObject::GetManagedDebugObject
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Creates a copy of the managed object in the address space of the debug engine.  
  
## Syntax  
  
```cpp#  
HRESULT GetManagedDebugObject(   
   IDebugManagedObject** ppObject  
);  
```  
  
```csharp  
int GetManagedDebugObject(  
   out IDebugManagedObject ppObject  
);  
```  
  
#### Parameters  
 `ppObject`  
 [out] Returns an [IDebugManagedObject](../../../extensibility/debugger/reference/idebugmanagedobject.md) object representing the newly created managed object.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code. Returns E_FAIL if this [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) does not represent a managed value class instance.  
  
## Remarks  
 This [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object must represent a managed value class instance, such as a `System.Decimal` instance. By having a local copy, the overhead of calling [Evaluate](../../../extensibility/debugger/reference/idebugfunctionobject-evaluate.md) is eliminated.  
  
## See Also  
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)   
 [IDebugManagedObject](../../../extensibility/debugger/reference/idebugmanagedobject.md)
