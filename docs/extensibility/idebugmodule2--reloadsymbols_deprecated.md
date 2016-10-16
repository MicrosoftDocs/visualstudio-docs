---
title: "IDebugModule2::ReloadSymbols_Deprecated"
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
  - "IDebugModule2::ReloadSymbols"
helpviewer_keywords: 
  - "IDebugModule2::ReloadSymbols method"
ms.assetid: 0f9f0133-7d58-4cd9-a6ca-1141e095749d
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
# IDebugModule2::ReloadSymbols_Deprecated
OBSOLETE. DO NOT USE. Reloads the symbols for this module.  
  
## Syntax  
  
```cpp#  
HRESULT ReloadSymbols(   
   LPCOLESTR pszUrlToSymbols,  
   BSTR*     pbstrDebugMessage  
);  
```  
  
```c#  
int ReloadSymbols(   
   string     pszUrlToSymbols,  
   out string pbstrDebugMessage  
);  
```  
  
#### Parameters  
 `pszUrlToSymbols`  
 [in] The path to the symbol store.  
  
 `pbstrDebugMessage`  
 [out] Returns an informational message, such as a status or error message, that is displayed to the right of the module name in the Modules window.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. A debug engine should always return `E_FAIL`.  
  
## Remarks  
 This method is no longer supported. Implement the [LoadSymbols](../extensibility/idebugmodule3--loadsymbols.md) method instead.  
  
## See Also  
 [IDebugModule2](../extensibility/idebugmodule2.md)   
 [LoadSymbols](../extensibility/idebugmodule3--loadsymbols.md)