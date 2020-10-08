---
title: "IDebugModule2::GetInfo | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugModule2::GetInfo"
helpviewer_keywords: 
  - "GetInfo method"
  - "IDebugModule2::GetInfo method"
ms.assetid: de337e66-294f-4ac9-b21e-71fac7418e36
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugModule2::GetInfo
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets information about this module.  
  
## Syntax  
  
```cpp#  
HRESULT GetInfo(   
   MODULE_INFO_FIELDS dwFields,  
   MODULE_INFO*       pInfo  
);  
```  
  
```cpp#  
int GetInfo(   
   enum_MODULE_INFO_FIELDS dwFields,  
   MODULE_INFO[]           pInfo  
);  
```  
  
#### Parameters  
 `dwFields`  
 [in] A combination of flags from the [MODULE_INFO_FIELDS](../../../extensibility/debugger/reference/module-info-fields.md) enumeration that specify which fields of `pInfo` are to be filled out.  
  
 `pInfo`  
 [in, out] A [MODULE_INFO](../../../extensibility/debugger/reference/module-info.md) structure that is filled in with a description of the module.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The [MODULE_INFO](../../../extensibility/debugger/reference/module-info.md) structure contains the name of the module that is displayed in the **Modules** window.  
  
## See Also  
 [IDebugModule2](../../../extensibility/debugger/reference/idebugmodule2.md)   
 [MODULE_INFO_FIELDS](../../../extensibility/debugger/reference/module-info-fields.md)   
 [MODULE_INFO](../../../extensibility/debugger/reference/module-info.md)
