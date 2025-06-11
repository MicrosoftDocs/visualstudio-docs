---
description: "Defines the metadata that can be retrieved about a port supplier."
title: PORT_SUPPLIER_DESCRIPTION_FLAGS
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- PORT_SUPPLIER_DESCRIPTION_FLAGS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# PORT_SUPPLIER_DESCRIPTION_FLAGS

Defines the metadata that can be retrieved about a port supplier.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_PORT_SUPPLIER_DESCRIPTION_FLAGS
{
    PSDFLAG_SHOW_WARNING_ICON = 0x1
};
```
### [C++](#tab/cpp)
```cpp
enum enum_PORT_SUPPLIER_DESCRIPTION_FLAGS
{
    PSDFLAG_SHOW_WARNING_ICON = 0x1
};
typedef DWORD PORT_SUPPLIER_DESCRIPTION_FLAGS;
```
---

## Fields

`PSDFLAG_SHOW_WARNING_ICON`\
If selected, the warning icon will be displayed in the UI.

## Remarks

This enumeration is returned by the [GetDescription](../../../extensibility/debugger/reference/idebugportsupplierdescription2-getdescription.md) method.

## Requirements

Header: Msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also

- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetDescription](../../../extensibility/debugger/reference/idebugportsupplierdescription2-getdescription.md)
