---
title: "IDebugObject::GetManagedDebugObject | Microsoft Docs"
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
  - "IDebugObject::GetManagedDebugObject"
helpviewer_keywords: 
  - "IDebugObject::GetManagedDebugObject method"
ms.assetid: cb89692e-7657-47ff-846d-311943521951
caps.latest.revision: 9
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
# IDebugObject::GetManagedDebugObject
Creates a copy of the managed object in the address space of the debug engine.  
  
## Syntax  
  
```cpp#  
HRESULT GetManagedDebugObject(   
   IDebugManagedObject** ppObject  
);  
```  
  
```c#  
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