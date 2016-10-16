---
title: "IDebugReference2::EnumChildren"
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
  - "IDebugReference2::EnumChildren"
helpviewer_keywords: 
  - "IDebugReference2::EnumChildren"
ms.assetid: 35b3c2f3-69f4-4013-b555-f847221f62e8
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
# IDebugReference2::EnumChildren
Get a list of selected children of a reference. Reserved for future use.  
  
## Syntax  
  
```cpp#  
HRESULT EnumChildren (   
   DEBUGREF_INFO_FLAGS        dwFields,  
   DWORD                      dwRadix,  
   DBG_ATTRIB_FLAGS           dwAttribFilter,  
   LPCOLESTR                  pszNameFilter,  
   DWORD                      dwTimeout,  
   IEnumDebugReferenceInfo2** ppEnum  
);  
```  
  
```c#  
int EnumChildren (   
   enum_DEBUGREF_INFO_FLAGS     dwFields,  
   uint                         dwRadix,  
   enum_DBG_ATTRIB_FLAGS        dwAttribFilter,  
   string                       pszNameFilter,  
   uint                         dwTimeout,  
   out IEnumDebugReferenceInfo2 ppEnum  
);  
```  
  
#### Parameters  
 `dwFields`  
 [in] A combination of flags from the [DEBUGREF_INFO_FLAGS](../extensibility/debugref_info_flags.md) enumeration that specifies which fields in the enumerated [DEBUG_REFERENCE_INFO](../extensibility/debug_reference_info.md) structures are to be filled in.  
  
 `dwRadix`  
 [in] The radix to be used in formatting any numerical information.  
  
 `dwAttribFilter`  
 [in] A combination of flags from the [DBG_ATTRIB_FLAGS](../extensibility/dbg_attrib_flags.md) enumeration that is used as a filter in combination with the `pszNameFilter` parameter to select which structures are to be enumerated.  
  
 `pszNameFilter`  
 [in] A string specifying a filter, such as "MyX", used in combination with the `dwAttribFilter` parameter to select the structures to be enumerated.  
  
 `dwTimeout`  
 [in] Maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.  
  
 `ppEnum`  
 [out] Returns an [IEnumDebugReferenceInfo2](../extensibility/ienumdebugreferenceinfo2.md) object that contains a list of the requested child properties.  
  
## Return Value  
 Always returns `E_NOTIMPL`.  
  
## See Also  
 [IDebugReference2](../extensibility/idebugreference2.md)   
 [DEBUGREF_INFO_FLAGS](../extensibility/debugref_info_flags.md)   
 [DBG_ATTRIB_FLAGS](../extensibility/dbg_attrib_flags.md)   
 [IEnumDebugReferenceInfo2](../extensibility/ienumdebugreferenceinfo2.md)