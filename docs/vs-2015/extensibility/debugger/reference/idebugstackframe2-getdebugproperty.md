---
title: "IDebugStackFrame2::GetDebugProperty | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugStackFrame2::GetDebugProperty"
helpviewer_keywords: 
  - "IDebugStackFrame2::GetDebugProperty"
ms.assetid: 02c2fa04-1424-4bca-9936-feaecd2afab6
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugStackFrame2::GetDebugProperty
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugStackFrame2::GetDebugProperty](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugstackframe2-getdebugproperty).  
  
Gets a description of the properties of a stack frame.  
  
## Syntax  
  
```cpp#  
HRESULT GetDebugProperty (   
   IDebugProperty2** ppDebugProp  
);  
```  
  
```csharp  
int GetDebugProperty (   
   out IDebugProperty2 ppDebugProp  
);  
```  
  
#### Parameters  
 `ppDebugProp`  
 [out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that describes the properties of this stack frame.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Calling the [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md) method with appropriate filters can retrieve the local variables, method parameters, registers, and "this" pointer associated with the stack frame.  
  
## See Also  
 [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)   
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)

