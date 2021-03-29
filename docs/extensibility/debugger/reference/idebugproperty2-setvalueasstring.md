---
description: "Sets the value of a property from a given string."
title: IDebugProperty2::SetValueAsString | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty2::SetValueAsString
helpviewer_keywords:
- IDebugProperty2::SetValueAsString
ms.assetid: 9e6a5054-41b7-4223-b509-b93689d366a5
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugProperty2::SetValueAsString
Sets the value of a property from a given string.

## Syntax

```cpp
HRESULT SetValueAsString ( 
   LPCOLESTR pszValue,
   UINT      nRadix,
   DWORD     dwTimeout
);
```

```csharp
int SetValueAsString ( 
   string pszValue,
   uint   nRadix,
   uint   dwTimeout
);
```

## Parameters
`pszValue`\
[in] A string containing the value to be set.

`nRadix`\
[in] A radix to be used in interpreting any numerical information. This can be 0 to attempt to determine the radix automatically.

`dwTimeout`\
[in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.

## Return Value
 If successful, returns `S_OK`; otherwise returns error code. The following table shows other possible values.

|Value|Description|
|-----------|-----------------|
|`E_SETVALUE_VALUE_CANNOT_BE_SET`|The string could not be converted into a property value, or the property value could not be set.|
|`E_SETVALUE_VALUE_IS_READONLY`|The property is read-only.|

## See also
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
