---
title: "IDebugSymbolSearchEvent2::GetSymbolSearchInfo | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugSymbolSearchEvent2::GetSymbolSearchInfo"
helpviewer_keywords: 
  - "IDebugSymbolSearchEvent2::GetSymbolSearchInfo"
ms.assetid: ae9eb72b-f2aa-43b8-87ca-da19d2e78d17
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugSymbolSearchEvent2::GetSymbolSearchInfo
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Called by an event handler to retrieve results about a symbol load process.  
  
## Syntax  
  
```cpp  
HRESULT GetSymbolSearchInfo(  
   IDebugModule3**    pModule,  
   BSTR*              pbstrDebugMessage,  
   MODULE_INFO_FLAGS* pdwModuleInfoFlags  
);  
```  
  
```csharp  
int GetSymbolSearchInfo(  
   IDebugModule3              pModule,   
   ref string                 pbstrDebugMessage,   
   out enum_MODULE_INFO_FLAGS pdwModuleInfoFlags  
);  
  
```  
  
#### Parameters  
 `pModule`  
 [out] An IDebugModule3 object representing the module for which the symbols were loaded.  
  
 `pbstrDebugMessage`  
 [in, out] Returns a string containing any error messages from the module. If there is no error, then this string will just contain the module's name but it is never empty.  
  
> [!NOTE]
> [C++] `pbstrDebugMessage` cannot be `NULL` and must be freed with `SysFreeString`.  
  
 `pdwModuleInfoFlags`  
 [out] A combination of flags from the [MODULE_INFO_FLAGS](../../../extensibility/debugger/reference/module-info-flags.md) enumeration indicating whether any symbols were loaded.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns an error code.  
  
## Remarks  
 When a handler receives the [IDebugSymbolSearchEvent2](../../../extensibility/debugger/reference/idebugsymbolsearchevent2.md) event after an attempt is made to load debugging symbols for a module, the handler can call thismethod to determine the results of that load.  
  
## See Also  
 [IDebugModule3](../../../extensibility/debugger/reference/idebugmodule3.md)   
 [MODULE_INFO_FLAGS](../../../extensibility/debugger/reference/module-info-flags.md)   
 [IDebugSymbolSearchEvent2](../../../extensibility/debugger/reference/idebugsymbolsearchevent2.md)
