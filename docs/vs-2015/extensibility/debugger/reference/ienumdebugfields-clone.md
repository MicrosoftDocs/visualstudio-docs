---
title: "IEnumDebugFields::Clone | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IEnumDebugFields::Clone"
helpviewer_keywords: 
  - "IEnumDebugFields::Clone method"
ms.assetid: 7ec265a8-696f-45ce-a2a2-0a83e96fee1b
caps.latest.revision: 6
ms.author: gregvanl
manager: jillfra
---
# IEnumDebugFields::Clone
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method returns a copy of the current enumeration as a separate object.  
  
## Syntax  
  
```cpp#  
HRESULT Clone(  
   IEnumDebugFields** ppEnum  
);  
```  
  
```csharp  
int Clone(  
   out IEnumDebugFields ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns a copy of this enumeration as a separate object.  
  
## Property Value/Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The copy of the enumeration has the same state as the original at the time this method is called. However, the copy's and the original's states are separate and can be changed individually.  
  
## See Also  
 [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)
