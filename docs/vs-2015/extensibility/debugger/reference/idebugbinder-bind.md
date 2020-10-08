---
title: "IDebugBinder::Bind | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugBinder::Bind"
helpviewer_keywords: 
  - "IDebugBinder::Bind method"
ms.assetid: 15a11ad7-0fcc-4e80-ae34-8a7dd7bae3c3
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# IDebugBinder::Bind
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method gets the memory context or object that contains the symbol's current value.  
  
## Syntax  
  
```cpp#  
HRESULT Bind(   
   IDebugObject*  pContainer,  
   IDebugField*   pField,  
   IDebugObject** ppObject  
);  
```  
  
```csharp  
int Bind(  
   IDebugObject     pContainer,  
   IDebugField      pField,  
   out IDebugObject ppObject  
);  
```  
  
#### Parameters  
 `pContainer`  
 [in] The [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) that contains the child referenced by `pField`.  
  
 `pField`  
 [in] The [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) that represents the symbol.  
  
 `ppObject`  
 [out] Returns the `IDebugObject` that represents the instance of the symbol.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)   
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)   
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
