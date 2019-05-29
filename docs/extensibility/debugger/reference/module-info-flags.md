---
title: "MODULE_INFO_FLAGS | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "MODULE_INFO_FLAGS"
helpviewer_keywords:
  - "MODULE_INFO_FLAGS enumeration"
ms.assetid: e22d3723-b4d4-4524-8a2f-3adb55bbd273
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# MODULE_INFO_FLAGS
Specifies the state of symbols for a module.

## Syntax

```cpp
enum enum_MODULE_INFO_FLAGS {
   MIF_SYMBOLS_LOADED = 0x0001
};
typedef DWORD MODULE_INFO_FLAGS;
```

```csharp
public enum enum_MODULE_INFO_FLAGS {
   MIF_SYMBOLS_LOADED = 0x0001
};
```

## Fields
 `MIF_SYMBOLS_LOADED`\
 At least one set of symbols was loaded by the module (otherwise no symbols were loaded).

## Remarks
 This value is returned by the [GetSymbolSearchInfo](../../../extensibility/debugger/reference/idebugsymbolsearchevent2-getsymbolsearchinfo.md) method.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetSymbolSearchInfo](../../../extensibility/debugger/reference/idebugsymbolsearchevent2-getsymbolsearchinfo.md)