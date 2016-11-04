---
title: "IDebugProperty2::EnumChildren | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugProperty2::EnumChildren"
helpviewer_keywords: 
  - "IDebugProperty2::EnumChildren"
ms.assetid: cf79f666-65d1-417c-af7c-9271bac9a267
caps.latest.revision: 11
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
# IDebugProperty2::EnumChildren
Retrieves a list of the children of the property.  
  
## Syntax  
  
```cpp#  
HRESULT EnumChildren (   
   DEBUGPROP_INFO_FLAGS      dwFields,  
   DWORD                     dwRadix,  
   REFGUID                   guidFilter,  
   DBG_ATTRIB_FLAGS          dwAttribFilter,  
   LPCOLESTR                 pszNameFilter,  
   DWORD                     dwTimeout,  
   IEnumDebugPropertyInfo2** ppEnum  
);  
```  
  
```c#  
int EnumChildren (   
   enum_DEBUGPROP_INFO_FLAGS   dwFields,  
   uint                        dwRadix,  
   ref Guid                    guidFilter,  
   uint                        dwAttribFilter,  
   string                      pszNameFilter,  
   uint                        dwTimeout,  
   out IEnumDebugPropertyInfo2 ppEnum  
);  
```  
  
#### Parameters  
 `dwFields`  
 [in] A combination of flags from the [DEBUGPROP_INFO_FLAGS](../../../extensibility/debugger/reference/debugprop-info-flags.md) enumeration that specifies which fields in the enumerated [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) structures are to be filled in.  
  
 `dwRadix`  
 [in] Specifies the radix to be used in formatting any numerical information.  
  
 `guidFilter`  
 [in] GUID of the filter used with the `dwAttribFilter` and `pszNameFilter` parameters to select which `DEBUG_PROPERTY_INFO` children are to be enumerated. For example, `guidFilterLocals` filters for local variables.  
  
 `dwAttribFilter`  
 [in] A combination of flags from the [DBG_ATTRIB_FLAGS](../../../extensibility/debugger/reference/dbg-attrib-flags.md) enumeration that specifies what type of objects to enumerate, for example `DBG_ATTRIB_METHOD` for all methods that might be children of this property. Used in combination with the `guidFilter` and `pszNameFilter` parameters.  
  
 `pszNameFilter`  
 [in] The name of the filter used with the `guidFilter` and `dwAttribFilter` parameters to select which `DEBUG_PROPERTY_INFO` children are to be enumerated. For example, setting this parameter to "MyX" filters for all children with the name "MyX."  
  
 `dwTimeout`  
 [in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.  
  
 `ppEnum`  
 [out] Returns an [IEnumDebugPropertyInfo2](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2.md) object containing a list of the child properties.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns error code.  
  
## See Also  
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)   
 [DEBUGPROP_INFO_FLAGS](../../../extensibility/debugger/reference/debugprop-info-flags.md)   
 [DBG_ATTRIB_FLAGS](../../../extensibility/debugger/reference/dbg-attrib-flags.md)   
 [IEnumDebugPropertyInfo2](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2.md)