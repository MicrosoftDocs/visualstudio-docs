---
description: "Specifies the kind of symbol information to retrieve."
title: SYMBOL_SEARCH_INFO_FIELDS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SYMBOL_SEARCH_INFO_FIELDS
helpviewer_keywords:
- SYMBOL_SEARCH_INFO_FIELDS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# SYMBOL_SEARCH_INFO_FIELDS

Specifies the kind of symbol information to retrieve.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_SYMBOL_SEARCH_INFO_FIELDS
{
   SSIF_NONE                = 0x00000000,
   SSIF_VERBOSE_SEARCH_INFO = 0x00000001
};

```
### [C++](#tab/cpp)
```cpp
enum enum_SYMBOL_SEARCH_INFO_FIELDS
{
   SSIF_NONE                = 0x00000000,
   SSIF_VERBOSE_SEARCH_INFO = 0x00000001
};
typedef DWORD SYMBOL_SEARCH_INFO_FIELDS;
```
---

## Fields
 `SSIF_NONE`\
 Indicates no flags

 `SSIF_VERBOSE_SEARCH_INFO`\
 Returns all search paths used for finding symbols

## Remarks
 These flags are passed as a parameter to the [GetSymbolInfo](../../../extensibility/debugger/reference/idebugmodule3-getsymbolinfo.md) method to determine the amount of information returned.

> [!NOTE]
> Currently, only `SSIF_VERBOSE_SEARCH_INFO` is supported, and it must be specified as the `dwFlags` parameter to `IDebugModule3::GetSymbolInfo`. All other values return an error.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetSymbolInfo](../../../extensibility/debugger/reference/idebugmodule3-getsymbolinfo.md)
