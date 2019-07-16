---
title: "IDebugEngine2::RemoveAllSetExceptions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugEngine2::RemoveAllSetExceptions"
helpviewer_keywords: 
  - "IDebugEngine2::RemoveAllSetExceptions"
ms.assetid: 165fbe89-802d-4d99-85ca-c10fd6cccc09
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugEngine2::RemoveAllSetExceptions
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Removes the list of exceptions the IDE has set for a particular run-time architecture or language.  
  
## Syntax  
  
```cpp#  
HRESULT RemoveAllSetExceptions(   
   REFGUID guidType  
);  
```  
  
```csharp  
int RemoveAllSetExceptions(   
   ref Guid guidType  
);  
```  
  
#### Parameters  
 `guidType`  
 [in] Either the GUID for the language or the GUID for the debug engine that is specific to a run-time architecture.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The exceptions removed by this method were set by earlier calls to the [SetException](../../../extensibility/debugger/reference/idebugengine2-setexception.md) method.  
  
 To remove a specific exception, call the [RemoveSetException](../../../extensibility/debugger/reference/idebugengine2-removesetexception.md) method.  
  
## See Also  
 [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)   
 [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)   
 [RemoveSetException](../../../extensibility/debugger/reference/idebugengine2-removesetexception.md)
