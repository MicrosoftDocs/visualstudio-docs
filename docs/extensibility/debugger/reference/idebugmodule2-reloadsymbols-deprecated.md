---
description: "OBSOLETE. Reloads the symbols for this module."
title: IDebugModule2::ReloadSymbols_Deprecated | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugModule2::ReloadSymbols
helpviewer_keywords:
- IDebugModule2::ReloadSymbols method
ms.assetid: 0f9f0133-7d58-4cd9-a6ca-1141e095749d
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugModule2::ReloadSymbols_Deprecated
OBSOLETE. DO NOT USE. Reloads the symbols for this module.

## Syntax

```cpp
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
