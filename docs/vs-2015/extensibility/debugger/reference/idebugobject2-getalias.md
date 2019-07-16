---
title: "IDebugObject2::GetAlias | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugObject2::GetAlias"
helpviewer_keywords: 
  - "IDebugObject2::GetAlias method"
ms.assetid: aa6824d5-c932-42ba-8713-950e7d1fb42f
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# IDebugObject2::GetAlias
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the alias associated with this object, if any.  
  
## Syntax  
  
```cpp  
HRESULT GetAlias(  
   IDebugAlias** ppAlias  
);  
```  
  
```csharp  
int GetAlias(  
   out IDebugAlias ppAlias  
);  
```  
  
#### Parameters  
 `ppAlias`  
 [out] Returns an [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md) object representing the alias for this object; otherwise, returns a null value.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 An alias for an object is created with a call to the [CreateAlias](../../../extensibility/debugger/reference/idebugobject2-createalias.md) method.  
  
## See Also  
 [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)   
 [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)
