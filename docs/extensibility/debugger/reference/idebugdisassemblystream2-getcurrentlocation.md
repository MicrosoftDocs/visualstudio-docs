---
description: "Returns a code location identifier that represents the current code location."
title: IDebugDisassemblyStream2::GetCurrentLocation
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDisassemblyStream2::GetCurrentLocation
helpviewer_keywords:
- IDebugDisassemblyStream2::GetCurrentLocation
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDisassemblyStream2::GetCurrentLocation

Returns a code location identifier that represents the current code location.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetCurrentLocation( 
   out ulong puCodeLocationId
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetCurrentLocation( 
   UINT64* puCodeLocationId
);
```
---

## Parameters
`puCodeLocationId`\
[out] Returns the code location identifier. See the Remarks section for the [GetCodeLocationId](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcodelocationid.md) method for a description of a code location identifier.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The code location identifier can be converted to a code context by calling the [GetCodeContext](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcodecontext.md) method.

## See also
- [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)
- [GetCodeLocationId](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcodelocationid.md)
- [GetCodeContext](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcodecontext.md)
