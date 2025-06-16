---
description: "Compares this document context to a given array of document contexts."
title: IDebugDocumentContext2::Compare
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentContext2::Compare
helpviewer_keywords:
- IDebugDocumentContext2::Compare
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentContext2::Compare

Compares this document context to a given array of document contexts.

## Syntax

### [C#](#tab/csharp)
```csharp
int Compare( 
   enum_ DOCCONTEXT_COMPARE compare,
   IDebugDocumentContext2[] rgpDocContextSet,
   uint                     dwDocContextSetLen,
   out uint                 pdwDocContext
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Compare( 
   DOCCONTEXT_COMPARE       compare,
   IDebugDocumentContext2** rgpDocContextSet,
   DWORD                    dwDocContextSetLen,
   DWORD*                   pdwDocContext
);
```
---

## Parameters
`compare`\
[in] A value from the [DOCCONTEXT_COMPARE](../../../extensibility/debugger/reference/doccontext-compare.md) enumeration that specifies the type of comparison.

`rgpDocContextSet`\
[in] An array of [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) objects that represent the document contexts being compared to.

`dwDocContextSetLen`\
[in] The length of the array of document contexts to compare.

`pdwDocContext`\
[out] Returns the index into the `rgpDocContextSet` array of the first document context that satisfies the comparison.

## Return Value
 Returns `S_OK` if a match was found. Returns `S_FALSE` if no match was found. Otherwise, returns an error code.

## Remarks
 The [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) objects that are passed in the array must be implemented by the same debug engine that implements the `IDebugDocumentContext2` object being called on; otherwise, the comparison is not valid.

## See also
- [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)
- [DOCCONTEXT_COMPARE](../../../extensibility/debugger/reference/doccontext-compare.md)
