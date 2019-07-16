---
title: "IDebugFunctionObject::CreateObjectNoConstructor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugFunctionObject::CreateObjectNoConstructor"
helpviewer_keywords: 
  - "IDebugFunctionObject::CreateObjectNoConstructor method"
ms.assetid: 4e2bd6d5-f4bd-4c10-a998-3db451c9a0c8
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugFunctionObject::CreateObjectNoConstructor
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Creates an object with no constructor.  
  
## Syntax  
  
```cpp#  
HRESULT CreateObjectNoConstructor(   
   IDebugField*   pClassObject,  
   IDebugObject** ppObject  
);  
```  
  
```csharp  
int CreateObjectNoConstructor(  
   IDebugField      pClassField,   
   out IDebugObject ppObject  
);  
```  
  
#### Parameters  
 `pClassObject`  
 [in] An [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object representing the type of the object to be created.  
  
 `ppObject`  
 [out] Returns an [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) representing the newly created object.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Call this method to create an object that represents an instance of a structure or complex type (that does not require a constructor) that is a parameter to the function which is represented by the [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) interface.  
  
 If the object parameter requires a constructor, call the [CreateObject](../../../extensibility/debugger/reference/idebugfunctionobject-createobject.md) method.  
  
## See Also  
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)   
 [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md)   
 [CreateObject](../../../extensibility/debugger/reference/idebugfunctionobject-createobject.md)
