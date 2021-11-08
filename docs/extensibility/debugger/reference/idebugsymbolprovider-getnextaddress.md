---
description: "Gets the debug address that follows a given debug address in a method."
title: IDebugSymbolProvider::GetNextAddress | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugSymbolProvider::GetNextAddress
helpviewer_keywords:
- IDebugSymbolProvider::GetNextAddress method
ms.assetid: 704eeb94-cb13-49d1-82b6-7d83ed0f19c0
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
# IDebugSymbolProvider::GetNextAddress
Gets the debug address that follows a given debug address in a method.

## Syntax

```cpp
HRESULT GetNextAddress( 
   IDebugAddress*  pAddress,
   BOOL            fStatementOnly,
   IDebugAddress** ppAddress
);
```

```csharp
int GetNextAddress( 
   IDebugAddress     pAddress,
   bool              fStatementOnly,
   out IDebugAddress ppAddress
);
```

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
