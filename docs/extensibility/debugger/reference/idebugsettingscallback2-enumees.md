---
title: "IDebugSettingsCallback2::EnumEEs | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IDebugSettingsCallback2::EnumEEs"
ms.assetid: 9f884c49-426f-461b-b547-9d909486e73f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugSettingsCallback2::EnumEEs
Enumerates the available expression evaluators given the language and vendor identifiers.

## Syntax

```cpp
HRESULT EnumEEs(
   DWORD  celtBuffer,
   GUID*  rgguidLang,
   GUID*  rgguidVendor,
   DWORD* pceltEEs
);
```

```csharp
public int EnumEEs(
   uint       celtBuffer,
   ref Guid   rgguidLang,
   ref Guid   rgguidVendor,
   ref uint[] pceltEEs
);
```

## Parameters
`celtBuffer`\
[in] Number of elements in the `pceltEEs` buffer.

`rgguidLang`\
[in, out] Unique identifier for the programming language.

`rgguidVendor`\
[in, out] Unique identifier for the vendor.

`pceltEEs`\
[in, out] Array of expression evaluators.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSettingsCallback2](../../../extensibility/debugger/reference/idebugsettingscallback2.md)