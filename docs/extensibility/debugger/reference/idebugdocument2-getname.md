---
description: "Gets the name of the document in one of several forms."
title: IDebugDocument2::GetName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocument2::GetName
helpviewer_keywords:
- IDebugDocument2::GetName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocument2::GetName

Gets the name of the document in one of several forms.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetName( 
   enum_GETNAME_TYPE gnType,
   out string        pbstrFileName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetName( 
   GETNAME_TYPE gnType,
   BSTR*        pbstrFileName
);
```
---

## Parameters
`gnType`\
[in] A value from the [GETNAME_TYPE](../../../extensibility/debugger/reference/getname-type.md) enumeration that determines the type of name to return.

`pbstrFileName`\
[out] Returns a string containing the document name.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method can, for example, return the name of the document as a title or as a file name or even part of a file name.

## See also
- [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)
- [GETNAME_TYPE](../../../extensibility/debugger/reference/getname-type.md)
