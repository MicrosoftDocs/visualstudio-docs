---
description: "Gets the debug address that follows a given debug address in a method."
title: IDebugSymbolProvider::GetNextAddress
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugSymbolProvider::GetNextAddress
helpviewer_keywords:
- IDebugSymbolProvider::GetNextAddress method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSymbolProvider::GetNextAddress

Gets the debug address that follows a given debug address in a method.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetNextAddress( 
   IDebugAddress     pAddress,
   bool              fStatementOnly,
   out IDebugAddress ppAddress
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetNextAddress( 
   IDebugAddress*  pAddress,
   BOOL            fStatementOnly,
   IDebugAddress** ppAddress
);
```
---

## Parameters
`pAddress`\
[in] Given debug address.

`fStatementOnly`\
[in] If TRUE, limits the debug addresses to a single statement.

`ppAddress`\
[out] Returns the next debug address.

## Return Value
 Returns a valid `HRESULT`, typically S_OK.

## See also
- [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)
