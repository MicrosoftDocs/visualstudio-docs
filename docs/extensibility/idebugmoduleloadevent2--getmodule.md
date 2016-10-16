---
title: "IDebugModuleLoadEvent2::GetModule"
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
  - "IDebugModuleLoadEvent2::GetModule"
helpviewer_keywords: 
  - "IDebugModuleLoadEvent2::GetModule"
ms.assetid: c86482bb-9ce5-4e63-bbe0-969b50169424
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
# IDebugModuleLoadEvent2::GetModule
Gets the module that is being loaded or unloaded.  
  
## Syntax  
  
```cpp#  
HRESULT GetModule(   
   IDebugModule2** pModule,  
   BSTR*           pbstrDebugMessage,  
   BOOL*           pbLoad  
);  
```  
  
```c#  
int GetModule(   
   out IDebugModule2 pModule,  
   ref string        pbstrDebugMessage,  
   ref int           pbLoad  
);  
```  
  
#### Parameters  
 `pModule`  
 [out] Returns an [IDebugModule2](../extensibility/idebugmodule2.md) object that represents the module which is loading or unloading.  
  
 `pbstrDebugMessage`  
 [in, out] Returns an optional message describing this event. If this parameter is a null value, no message is requested.  
  
 `pbLoad`  
 [in, out] Nonzero (`TRUE`) if the module is loading and zero (`FALSE`) if the module is unloading. If this parameter is a null value, no status is requested.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugModuleLoadEvent2](../extensibility/idebugmoduleloadevent2.md)   
 [IDebugModule2](../extensibility/idebugmodule2.md)