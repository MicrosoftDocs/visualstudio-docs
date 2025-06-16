---
description: "Used to describe a module."
title: MODULE_FLAGS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- MODULE_FLAGS
helpviewer_keywords:
- MODULE_FLAGS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# MODULE_FLAGS

Used to describe a module.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_MODULE_FLAGS { 
   MODULE_FLAG_NONE        = 0x0000,
   MODULE_FLAG_SYSTEM      = 0x0001,
   MODULE_FLAG_SYMBOLS     = 0x0002,
   MODULE_FLAG_64BIT       = 0x0004,
   MODULE_FLAG_OPTIMIZED   = 0x0008,
   MODULE_FLAG_UNOPTIMIZED = 0x0010
};
```
### [C++](#tab/cpp)
```cpp
enum enum_MODULE_FLAGS { 
   MODULE_FLAG_NONE        = 0x0000,
   MODULE_FLAG_SYSTEM      = 0x0001,
   MODULE_FLAG_SYMBOLS     = 0x0002,
   MODULE_FLAG_64BIT       = 0x0004,
   MODULE_FLAG_OPTIMIZED   = 0x0008,
   MODULE_FLAG_UNOPTIMIZED = 0x0010
};
typedef DWORD MODULE_FLAGS;
```
---

## Fields
 `MODULE_FLAG_NONE`\
 Specifies no module.

 `MODULE_FLAG_SYSTEM`\
 Specifies a system module.

 `MODULE_FLAG_SYMBOLS`\
 Specifies a symbol module.

 `MODULE_FLAG_64BIT`\
 Specifies a 64-bit module.

 `MODULE_FLAG_OPTIMIZED`\
 Specifies the module has been optimized. This state is reflected in the **Modules** window.

 `MODULE_FLAG_UNOPTIMIZED`\
 Specifies the module has not been optimized. This state is reflected in the **Modules** window. This is the default state.

## Remarks
 Used for the `m_dwModuleFlags` member of the [MODULE_INFO](../../../extensibility/debugger/reference/module-info.md) structure.

 These flags may be combined with a bitwise `OR`.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [MODULE_INFO](../../../extensibility/debugger/reference/module-info.md)
