---
title: "IDebugSymbolProvider::GetContextFromAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugSymbolProvider::GetContextFromAddress"
helpviewer_keywords:
  - "IDebugSymbolProvider::GetContextFromAddress method"
ms.assetid: 7a27d56f-20d4-4e5c-af7b-7307d3aff0a1
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugSymbolProvider::GetContextFromAddress
This method maps a debug address into a document context.

## Syntax

```cpp
HRESULT GetContextFromAddress( 
   IDebugAddress*           pAddress,
   IDebugDocumentContext2** ppDocContext
);
```

```csharp
int GetContextFromAddress(
   IDebugAddress              pAddress,
   out IDebugDocumentContext2 ppDocContext
);
```

## Parameters
`pAddress`\
[in] The debug address as represented by an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface.

`ppDocContext`\
[out] Returns a document context as represented by an [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) interface.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)
- [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)
- [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)