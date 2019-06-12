---
title: "IDebugProgram2::GetDebugProperty | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgram2::GetDebugProperty"
helpviewer_keywords: 
  - "IDebugProgram2::GetDebugProperty"
ms.assetid: d194224e-f0e6-46ab-85d4-9e2639e28946
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugProgram2::GetDebugProperty
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the program's properties.  
  
## Syntax  
  
```cpp#  
HRESULT GetDebugProperty(   
   IDebugProperty2** ppProperty  
);  
```  
  
```csharp  
int GetDebugProperty(   
   out IDebugProperty2 ppProperty  
);  
```  
  
#### Parameters  
 `ppProperty`  
 [out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that represents the program's properties.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The properties returned by this method are specific to the program. If the program needs to return more than one property, then the [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object returned by this method is a container of additional properties and calling the [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md) method returns a list of all properties.  
  
 A program may expose any number and type of additional properties that can be described through the `IDebugProperty2` interface. An IDE might display the additional program properties through a generic property browser user interface.  
  
## See Also  
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)   
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)   
 [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md)
