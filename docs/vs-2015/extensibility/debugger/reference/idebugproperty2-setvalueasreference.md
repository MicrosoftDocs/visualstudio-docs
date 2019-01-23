---
title: "IDebugProperty2::SetValueAsReference | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProperty2::SetValueAsReference"
helpviewer_keywords: 
  - "IDebugProperty2::SetValueAsReference method"
ms.assetid: 341b1b89-4ab8-4e1c-abe2-fb955df5c6b0
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugProperty2::SetValueAsReference
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Sets the value of this property to the value of the given reference.  
  
## Syntax  
  
```cpp#  
HRESULT SetValueAsReference(  
   IDebugReference2** rgpArgs,  
   DWORD              dwArgCount,  
   IDebugReference2*  pValue,  
   DWORD              dwTimeout  
);  
```  
  
```csharp  
int SetValueAsReference(  
   IDebugReference2[] rgpArgs,  
   uint               dwArgCount,  
   IDebugReference2   pValue,  
   uint               dwTimeout  
);  
```  
  
#### Parameters  
 `rgpArgs`  
 [in] An array of arguments to pass to the managed code property setter. If the property setter does not take arguments or if this [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object does not refer to such a property setter, `rgpArgs` should be a null value. This parameter is typically a null value.  
  
 `dwArgCount`  
 [in] The number of arguments in the `rgpArgs` array.  
  
 `pValue`  
 [in] A reference, in the form of an [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) object, to the value to use to set this property.  
  
 `dwTimeout`  
 [in] How long to take to set the value, in milliseconds. A typical value is `INFINITE`. This affects the length of time that any possible evaluation can take.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns an error code, typically one of the following:  
  
|Error|Description|  
|-----------|-----------------|  
|`E_SETVALUEASREFERENCE_NOTSUPPORTED`|Setting the value from a reference is not supported.|  
|`E_SETVALUE_VALUE_CANNOT_BE_SET`|The value cannot be set, as this property refers to a method.|  
|`E_SETVALUE_VALUE_IS_READONLY`|The value is read-only and cannot be set.|  
|`E_NOTIMPL`|The method is not implemented.|  
  
## See Also  
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)   
 [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
