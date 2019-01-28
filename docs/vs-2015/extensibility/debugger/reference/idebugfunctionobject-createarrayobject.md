---
title: "IDebugFunctionObject::CreateArrayObject | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugFunctionObject::CreateArrayObject"
helpviewer_keywords: 
  - "IDebugFunctionObject::CreateArrayObject method"
ms.assetid: a380e53c-15f1-401f-927f-f366eea789e6
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugFunctionObject::CreateArrayObject
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Creates an array object. This array can contain either primitive or object instance values.  
  
## Syntax  
  
```cpp#  
HRESULT CreateArrayObject(   
   OBJECT_TYPE    ot,  
   IDebugField*   pClassField,  
   DWORD          dwRank,  
   DWORD          dwDims[],  
   DWORD          dwLowBounds[],  
   IDebugObject** ppObject  
);  
```  
  
```csharp  
int CreateArrayObject(  
   enum_OBJECT_TYPE ot,   
   IDebugField      pClassField,   
   uint             dwRank,   
   uint[]           dwDims,   
   uint[]           dwLowBounds,   
   out IDebugObject ppObject  
);  
```  
  
#### Parameters  
 `ot`  
 [in] Specifies a value from the [OBJECT_TYPE](../../../extensibility/debugger/reference/object-type.md) enumeration indicating the type of the new array object.  
  
 `pClassField`  
 [in] An [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object representing the class of an object, if creating an array of object instance values. If creating an array of primitive objects, this parameter is a null value.  
  
 `dwRank`  
 [in] The rank or number of dimensions of the array.  
  
 `dwDims`  
 [in] The sizes of each dimension of the array.  
  
 `dwLowBounds`  
 [in] The origin of each dimension (typically 0 or 1).  
  
 `ppObject`  
 [out] Returns an [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object representing the newly created array. This is actually an [IDebugArrayObject](../../../extensibility/debugger/reference/idebugarrayobject.md) object.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Call this method to create an object that represents an array parameter to the function which is represented by the [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) interface.  
  
## See Also  
 [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md)
