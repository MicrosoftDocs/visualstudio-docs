---
title: "IDebugProperty2::SetValueAsReference"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugProperty2::SetValueAsReference"
helpviewer_keywords: 
  - "IDebugProperty2::SetValueAsReference method"
ms.assetid: 341b1b89-4ab8-4e1c-abe2-fb955df5c6b0
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugProperty2::SetValueAsReference
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
  
```c#  
int SetValueAsReference(  
   IDebugReference2[] rgpArgs,  
   uint               dwArgCount,  
   IDebugReference2   pValue,  
   uint               dwTimeout  
);  
```  
  
#### Parameters  
 `rgpArgs`  
 [in] An array of arguments to pass to the managed code property setter. If the property setter does not take arguments or if this [IDebugProperty2](../extensibility/idebugproperty2.md) object does not refer to such a property setter, `rgpArgs` should be a null value. This parameter is typically a null value.  
  
 `dwArgCount`  
 [in] The number of arguments in the `rgpArgs` array.  
  
 `pValue`  
 [in] A reference, in the form of an [IDebugReference2](../extensibility/idebugreference2.md) object, to the value to use to set this property.  
  
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
 [IDebugProperty2](../extensibility/idebugproperty2.md)   
 [IDebugReference2](../extensibility/idebugreference2.md)