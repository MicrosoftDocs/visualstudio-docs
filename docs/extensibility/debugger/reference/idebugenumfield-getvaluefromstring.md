---
description: "This method returns the value associated with the name of an enumeration constant."
title: IDebugEnumField::GetValueFromString
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEnumField::GetValueFromString
helpviewer_keywords:
- IDebugEnumField::GetValueFromString method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEnumField::GetValueFromString

This method returns the value associated with the name of an enumeration constant.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetValueFromString(
   string    pszValue,
   out ulong pValue
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetValueFromString(
   LPCOLESTR  pszValue,
   ULONGLONG* pvalue
);
```
---

## Parameters
`pszValue`\
[in] A string specifying the name for which to get the value. Note that for C++, this is a wide character string.

`pValue`\
[out] Returns the associated numerical value.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE`, if the name is not part of the enumeration, or an error code.

## Remarks
 This method is case-sensitive. If a case-insensitive search is needed (for example, in a language such as Visual Basic where names are not case sensitive), use [GetValueFromStringCaseInsensitive](../../../extensibility/debugger/reference/idebugenumfield-getvaluefromstringcaseinsensitive.md).

## See also
- [IDebugEnumField](../../../extensibility/debugger/reference/idebugenumfield.md)
- [GetValueFromStringCaseInsensitive](../../../extensibility/debugger/reference/idebugenumfield-getvaluefromstringcaseinsensitive.md)
