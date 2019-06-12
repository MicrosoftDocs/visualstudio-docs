---
title: "IDebugFunctionObject2::CreateObject | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugFunctionObject2::CreateObject"
  - "CreateObject"
ms.assetid: 148de615-941e-4b64-ab11-75b692aae465
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugFunctionObject2::CreateObject
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Creates an object that uses a constructor given evaluation flag settings and a timeout value.  
  
## Syntax  
  
```cpp#  
HRESULT CreateObject (  
   IDebugFunctionObject* pConstructor,  
   DWORD                 dwArgs,  
   IDebugObject*         pArgs[],  
   DWORD                 dwEvalFlags,  
   DWORD                 dwTimeout,  
   IDebugObject**        ppObject  
);  
```  
  
```csharp  
int CreateObject (  
   IDebugFunctionObject pConstructor,  
   uint                 dwArgs,  
   IDebugObject[]       pArgs,  
   uint                 dwEvalFlags,  
   uint                 dwTimeout,  
   out IDebugObject**   ppObject  
);  
```  
  
#### Parameters  
 `pConstructor`  
 [in] An [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) object that represents the constructor of the object to be created.  
  
 `dwArgs`  
 [in] The number of parameters in the `pArg` array. Represents the number of parameters passed to the constructor.  
  
 `pArgs`  
 [in] An array of [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) objects that represents the parameters passed to the constructor.  
  
 `dwEvalFlags`  
 [in] A combination of flags from the [EVALFLAGS](../../../extensibility/debugger/reference/evalflags.md) enumeration that specify how the evaluation is to be performed.  
  
 `dwTimeout`  
 [in] Maximum time, in milliseconds, to wait before returning from this method. Use **INFINITE** to wait indefinitely.  
  
 `ppObject`  
 [out] Returns an **IDebugObject** representing the newly created object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Call this method to create an object that represents an instance of a class, or other complex type that requires a constructor, that is a parameter.  
  
## See Also  
 [IDebugFunctionObject2](../../../extensibility/debugger/reference/idebugfunctionobject2.md)
