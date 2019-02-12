---
title: "IDebugReturnValueEvent2::GetReturnValue | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugReturnValueEvent2::GetReturnValue"
helpviewer_keywords: 
  - "IDebugReturnValueEvent2::GetReturnValue"
ms.assetid: 86c50d5a-6df6-4798-818a-c587a8741f90
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugReturnValueEvent2::GetReturnValue
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the value returned on stepping out of or over a function.  
  
## Syntax  
  
```cpp#  
HRESULT GetReturnValue (   
   IDebugProperty2** ppReturnValue  
);  
```  
  
```csharp  
int GetReturnValue (   
   out IDebugProperty2 ppReturnValue  
);  
```  
  
#### Parameters  
 `ppReturnValue`  
 [out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that represents the value to be retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugReturnValueEvent2](../../../extensibility/debugger/reference/idebugreturnvalueevent2.md)   
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
