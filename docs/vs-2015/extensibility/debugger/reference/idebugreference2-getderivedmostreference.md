---
title: "IDebugReference2::GetDerivedMostReference | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugReference2::GetDerivedMostReference"
helpviewer_keywords: 
  - "IDebugReference2::GetDerivedMostReference"
ms.assetid: 07253b74-7d39-48e0-8e85-ac8dfd919f6e
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugReference2::GetDerivedMostReference
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the derived-most reference of a reference. Reserved for future use.  
  
## Syntax  
  
```cpp#  
HRESULT GetDerivedMostReference(   
   IDebugReference2** ppDerivedMost  
);  
```  
  
```csharp  
int GetDerivedMostReference(   
   out IDebugReference2 ppDerivedMost  
);  
```  
  
#### Parameters  
 `ppDerivedMost`  
 [out] Returns an [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) object that represents the derived-most property.  
  
## Return Value  
 Always returns `E_NOTIMPL`.  
  
## Remarks  
 For example, if this property describes an object that implements `ClassRoot` but which is actually an instantiation of `ClassDerived` that is derived from `ClassRoot`, then this method returns an [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) object representing a reference to the `ClassDerived` object.  
  
## See Also  
 [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
