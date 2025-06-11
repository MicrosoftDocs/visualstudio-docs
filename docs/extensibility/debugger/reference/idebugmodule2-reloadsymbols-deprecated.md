---
description: "OBSOLETE. Reloads the symbols for this module."
title: IDebugModule2::ReloadSymbols_Deprecated
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugModule2::ReloadSymbols
helpviewer_keywords:
- IDebugModule2::ReloadSymbols method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugModule2::ReloadSymbols_Deprecated

OBSOLETE. DO NOT USE. Reloads the symbols for this module.

## Syntax

### [C#](#tab/csharp)
```csharp
int ReloadSymbols( 
   string     pszUrlToSymbols,
   out string pbstrDebugMessage
);
```
### [C++](#tab/cpp)
```cpp
HRESULT ReloadSymbols( 
   LPCOLESTR pszUrlToSymbols,
   BSTR*     pbstrDebugMessage
);
```
---

## Parameters
`pszUrlToSymbols`\
[in] The path to the symbol store.

`pbstrDebugMessage`\
[out] Returns an informational message, such as a status or error message, that is displayed to the right of the module name in the Modules window.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. A debug engine should always return `E_FAIL`.

## Remarks
 This method is no longer supported. Implement the [LoadSymbols](../../../extensibility/debugger/reference/idebugmodule3-loadsymbols.md) method instead.

## See also
- [IDebugModule2](../../../extensibility/debugger/reference/idebugmodule2.md)
- [LoadSymbols](../../../extensibility/debugger/reference/idebugmodule3-loadsymbols.md)
