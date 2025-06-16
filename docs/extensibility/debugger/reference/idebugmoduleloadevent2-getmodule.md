---
description: "Gets the module that is being loaded or unloaded."
title: IDebugModuleLoadEvent2::GetModule
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugModuleLoadEvent2::GetModule
helpviewer_keywords:
- IDebugModuleLoadEvent2::GetModule
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugModuleLoadEvent2::GetModule

Gets the module that is being loaded or unloaded.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetModule( 
   out IDebugModule2 pModule,
   ref string        pbstrDebugMessage,
   ref int           pbLoad
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetModule( 
   IDebugModule2** pModule,
   BSTR*           pbstrDebugMessage,
   BOOL*           pbLoad
);
```
---

## Parameters
`pModule`\
[out] Returns an [IDebugModule2](../../../extensibility/debugger/reference/idebugmodule2.md) object that represents the module which is loading or unloading.

`pbstrDebugMessage`\
[in, out] Returns an optional message describing this event. If this parameter is a null value, no message is requested.

`pbLoad`\
[in, out] Nonzero (`TRUE`) if the module is loading and zero (`FALSE`) if the module is unloading. If this parameter is a null value, no status is requested.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugModuleLoadEvent2](../../../extensibility/debugger/reference/idebugmoduleloadevent2.md)
- [IDebugModule2](../../../extensibility/debugger/reference/idebugmodule2.md)
