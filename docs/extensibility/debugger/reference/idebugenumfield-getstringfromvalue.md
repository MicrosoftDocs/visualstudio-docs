---
description: "This method obtains the name of the enumeration constant given its value."
title: IDebugEnumField::GetStringFromValue | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEnumField::GetStringFromValue
helpviewer_keywords:
- IDebugEnumField::GetStringFromValue method
ms.assetid: 5f95fd0c-fdce-497f-9f54-2ad8749494e9
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
# IDebugEnumField::GetStringFromValue
This method obtains the name of the enumeration constant given its value.

## Syntax

```cpp
HRESULT GetStringFromValue(
   ULONGLONG value,
   BSTR*     pbstrValue
);
```

```csharp
int GetStringFromValue(
   ulong      value,
   out string pbstrValue
);
```

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
