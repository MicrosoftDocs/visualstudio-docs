---
title: "IDebugPointerObject::Dereference | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugPointerObject::Dereference"
helpviewer_keywords: 
  - "IDebugPointerObject::Dereference method"
ms.assetid: 196ec2cc-8569-4780-b217-23b24e7f50ca
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugPointerObject::Dereference
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the object pointed to.  
  
## Syntax  
  
```cpp#  
HRESULT DeReference(   
   DWORD          dwIndex,  
   IDebugObject** ppObject  
);  
```  
  
```csharp  
int Dereference(  
   uint             dwIndex,   
   out IDebugObject ppObject  
);  
```  
  
#### Parameters  
 `dwIndex`  
 [in] A simple byte offset from the beginning of the object pointed to.  
  
 `ppObject`  
 [out] Returns an [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object representing the object pointed to, plus offset, if any.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code. Returns E_FAIL if this object does not point to another object.  
  
## Remarks  
 The object pointed to can be a primitive or a more complex type such as a class or structure.  
  
## See Also  
 [IDebugPointerObject](../../../extensibility/debugger/reference/idebugpointerobject.md)
