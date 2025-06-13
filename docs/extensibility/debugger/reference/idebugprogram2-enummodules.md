---
description: "Retrieves a list of the modules that this program has loaded and is executing."
title: IDebugProgram2::EnumModules
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::EnumModules
helpviewer_keywords:
- IDebugProgram2::EnumModules
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::EnumModules

Retrieves a list of the modules that this program has loaded and is executing.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumModules( 
   out IEnumDebugModules2 ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumModules( 
   IEnumDebugModules2** ppEnum
);
```
---

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugModules2](../../../extensibility/debugger/reference/ienumdebugmodules2.md) object that contains a list of the modules.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A module is a DLL or assembly and is typically listed in the **Modules** debug window.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IEnumDebugModules2](../../../extensibility/debugger/reference/ienumdebugmodules2.md)
