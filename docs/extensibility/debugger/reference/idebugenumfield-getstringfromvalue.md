---
description: "This method obtains the name of the enumeration constant given its value."
title: IDebugEnumField::GetStringFromValue
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEnumField::GetStringFromValue
helpviewer_keywords:
- IDebugEnumField::GetStringFromValue method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEnumField::GetStringFromValue

This method obtains the name of the enumeration constant given its value.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetStringFromValue(
   ulong      value,
   out string pbstrValue
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetStringFromValue(
   ULONGLONG value,
   BSTR*     pbstrValue
);
```
---

## Parameters
`value`\
[in] The value for which to get the name of the enumeration constant.

`pbstrValue`\
[out] Returns the name of the enumeration constant.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` if the value has no associated name, or returns an error code.

## Remarks
 If there is more than one name associated with the same value, the first name defined in the enumeration will be returned.

## See also
- [IDebugEnumField](../../../extensibility/debugger/reference/idebugenumfield.md)
