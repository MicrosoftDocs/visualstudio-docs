---
title: "IDebugBinder::ResolveRuntimeType | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugBinder::ResolveRuntimeType"
helpviewer_keywords: 
  - "IDebugBinder::ResolveRuntimeType method"
ms.assetid: 6456ab3e-1c03-4f3c-91f9-16797ab7f5e7
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# IDebugBinder::ResolveRuntimeType
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method determines the run-time type of an object.  
  
## Syntax  
  
```cpp#  
HRESULT ResolveRuntimeType(   
   IDebugObject* pObject,  
   IDebugField** ppResolved  
);  
```  
  
```csharp  
int ResolveRuntimeType(  
   IDebugObject     pObject,   
   out IDebugField  ppResolved  
);  
```  
  
#### Parameters  
 `pObject`  
 [in] The [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) to be resolved.  
  
 `ppResolved`  
 [out] Returns the type of the object as an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md).  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The run-time type of an object is not always known at compile time. For example, using polymorphism, an argument can be passed to a function as its base class, such as a button class. The actual argument might be a derived class, such as a radio button class.  
  
## See Also  
 [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)   
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)   
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
