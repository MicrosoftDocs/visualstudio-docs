---
description: "This method gets the language that was used to compile the code at the debug address."
title: IDebugSymbolProvider::GetLanguage
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugSymbolProvider::GetLanguage
helpviewer_keywords:
- IDebugSymbolProvider::GetLanguage method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSymbolProvider::GetLanguage

This method gets the language that was used to compile the code at the debug address.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetLanguage(
   IDebugAddress pAddress,
   out Guid      pguidLanguage,
   out Guid      pguidLanguageVendor
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetLanguage( 
   IDebugAddress* pAddress,
   GUID*          pguidLanguage,
   GUID*          pguidLanguageVendor
);
```
---

## Parameters
`pAddress`\
[in] An address object represented by an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface.

`pguidLanguage`\
[out] Returns a `GUID` that specifies the language.

`pguidLanguageVendor`\
[out] Returns a `GUID` that specifies the language vendor.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The debug engine calls this method to obtain the information it needs to select the correct expression evaluator.

## See also
- [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)
- [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)
