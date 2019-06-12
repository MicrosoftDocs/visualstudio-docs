---
title: "IDebugBinder::GetFunctionObject | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugBinder::GetFunctionObject"
helpviewer_keywords: 
  - "IDebugBinder::GetFunctionObject method"
ms.assetid: 8fb789df-8f30-420d-8ca5-bb496a6738f1
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugBinder::GetFunctionObject
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method gets an [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) object used to create function parameters.  
  
## Syntax  
  
```cpp#  
HRESULT GetFunctionObject(   
   IDebugFunctionObject **ppFunction  
);  
```  
  
```csharp  
int GetFunctionObject(  
   out IDebugFunctionObject ppFunction  
);  
```  
  
#### Parameters  
 `ppFunction`  
 [out] Returns the [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) interface that is used to create function parameters.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## See Also  
 [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)   
 [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md)
