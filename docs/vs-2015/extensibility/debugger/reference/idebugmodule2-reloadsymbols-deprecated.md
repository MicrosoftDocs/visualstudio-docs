---
title: "IDebugModule2::ReloadSymbols_Deprecated | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugModule2::ReloadSymbols"
helpviewer_keywords: 
  - "IDebugModule2::ReloadSymbols method"
ms.assetid: 0f9f0133-7d58-4cd9-a6ca-1141e095749d
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugModule2::ReloadSymbols_Deprecated
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

OBSOLETE. DO NOT USE. Reloads the symbols for this module.  
  
## Syntax  
  
```cpp#  
HRESULT ReloadSymbols(   
   LPCOLESTR pszUrlToSymbols,  
   BSTR*     pbstrDebugMessage  
);  
```  
  
```csharp  
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
 This method is no longer supported. Implement the [LoadSymbols](../../../extensibility/debugger/reference/idebugmodule3-loadsymbols.md) method instead.  
  
## See Also  
 [IDebugModule2](../../../extensibility/debugger/reference/idebugmodule2.md)   
 [LoadSymbols](../../../extensibility/debugger/reference/idebugmodule3-loadsymbols.md)
