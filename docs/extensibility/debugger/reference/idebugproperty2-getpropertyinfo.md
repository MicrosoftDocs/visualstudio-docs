---
title: "IDebugProperty2::GetPropertyInfo | Microsoft Docs"
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
  - "IDebugProperty2::GetPropertyInfo"
helpviewer_keywords: 
  - "IDebugProperty2::GetPropertyInfo"
ms.assetid: 39d6e942-df72-4c84-a5d9-a386d112714c
caps.latest.revision: 10
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
# IDebugProperty2::GetPropertyInfo
Gets the [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) structure that describes a property.  
  
## Syntax  
  
```cpp#  
HRESULT GetPropertyInfo (   
   DEBUGPROP_INFO_FLAGS dwFields,  
   DWORD                nRadix,  
   DWORD                dwTimeout,  
   IDebugReference2**   rgpArgs,  
   DWORD                dwArgCount,  
   DEBUG_PROPERTY_INFO* pPropertyInfo  
);  
```  
  
```cpp#  
int GetPropertyInfo (   
   enum_DEBUGPROP_INFO_FLAGS dwFields,  
   uint                      nRadix,  
   uint                      dwTimeout,  
   IDebugReference2[]        rgpArgs,  
   uint                      dwArgCount,  
   DEBUG_PROPERTY_INFO[]     pPropertyInfo  
);  
```  
  
#### Parameters  
 `dwFields`  
 [in] A combination of values from the [DEBUGPROP_INFO_FLAGS](../../../extensibility/debugger/reference/debugprop-info-flags.md) enumeration that specifies which fields are to be filled out in the `pPropertyInfo` structure.  
  
 `nRadix`  
 [in] Radix to be used in formatting any numerical information.  
  
 `dwTimeout`  
 [in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.  
  
 `rgpArgs`  
 [in, out] Reserved for future use; set to a null value.  
  
 `dwArgCount`  
 [in] Reserved for future use; set to zero.  
  
 `pPropertyInfo`  
 [out] A [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) structure that is filled in with the description of the property.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns error code.  
  
## See Also  
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)   
 [DEBUGPROP_INFO_FLAGS](../../../extensibility/debugger/reference/debugprop-info-flags.md)   
 [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)   
 [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md)