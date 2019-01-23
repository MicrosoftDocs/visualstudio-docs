---
title: "IDebugFunctionObject::CreatePrimitiveObject | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugFunctionObject::CreatePrimitiveObject"
helpviewer_keywords: 
  - "IDebugFunctionObject::CreatePrimitiveObject method"
ms.assetid: 6e9dc8b6-b4e1-4abf-b6e0-e885910775bc
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugFunctionObject::CreatePrimitiveObject
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Creates a primitive data object, such as a simple integer.  
  
## Syntax  
  
```cpp#  
HRESULT CreatePrimitiveObject(   
   OBJECT_TYPE    ot,  
   IDebugObject** ppObject  
);  
```  
  
```csharp  
int CreatePrimitiveObject(  
   enum_OBJECT_TYPE ot,   
   out IDebugObject ppObject  
);  
```  
  
#### Parameters  
 `ot`  
 [in] A value from the [OBJECT_TYPE](../../../extensibility/debugger/reference/object-type.md) enumeration representing the type of primitive to create.  
  
 `ppObject`  
 [out] Returns an [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) representing the newly created object.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Call this method to create an object that represents a primitive object that is a parameter to the function which is represented by the [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) interface. For example, if the expression string is "myString(5)", this method would be used to create an object representing the integer 5.  
  
## See Also  
 [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md)
