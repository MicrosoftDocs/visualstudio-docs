---
title: "IDebugProperty2::GetParent | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProperty2::GetParent"
helpviewer_keywords: 
  - "IDebugProperty2::GetParent"
ms.assetid: 58780469-fe25-4d84-9187-67940ca0767f
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugProperty2::GetParent
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the parent property of a property.  
  
## Syntax  
  
```cpp#  
HRESULT GetParent (   
   IDebugProperty2** ppParent  
);  
```  
  
```csharp  
int GetParent (   
   out IDebugProperty2 ppParent  
);  
```  
  
#### Parameters  
 `ppParent`  
 [out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that represents the parent of the property.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns error code. Returns `S_GETPARENT_NO_PARENT` if there is no parent.  
  
## See Also  
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
