---
title: "IDebugBinder::ResolveDynamicType | Microsoft Docs"
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
  - "IDebugBinder::ResolveDynamicType"
helpviewer_keywords: 
  - "IDebugBinder::ResolveDynamicType method"
ms.assetid: 2c36ef92-5b44-4cfd-988e-54a2e5a6710c
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugBinder::ResolveDynamicType
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugBinder::ResolveDynamicType](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugbinder-resolvedynamictype).  
  
This method returns the exact type of a variable.  
  
## Syntax  
  
```cpp#  
HRESULT ResolveDynamicType (  
   IDebugDynamicField *pDynamic,  
   IDebugField       **ppResolved  
);  
```  
  
```csharp  
int ResolveDynamicType(  
   IDebugDynamicField pDynamic,   
   out IDebugField    ppResolved  
);  
```  
  
#### Parameters  
 `pDynamic`  
 [in] An [IDebugDynamicField](../../../extensibility/debugger/reference/idebugdynamicfield.md) representing a type of a variable.  
  
 `ppResolved`  
 [out] Returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) giving specific information about the variable's type.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)   
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)   
 [IDebugDynamicField](../../../extensibility/debugger/reference/idebugdynamicfield.md)

