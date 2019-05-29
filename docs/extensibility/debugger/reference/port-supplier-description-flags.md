---
title: "PORT_SUPPLIER_DESCRIPTION_FLAGS | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "PORT_SUPPLIER_DESCRIPTION_FLAGS enumeration"
ms.assetid: 5acee0ee-3a20-41c9-a7dc-0dadae6a5ba5
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# PORT_SUPPLIER_DESCRIPTION_FLAGS

Defines the metadata that can be retrieved about a port supplier.

## Syntax

```cpp
enum enum_PORT_SUPPLIER_DESCRIPTION_FLAGS
{
    PSDFLAG_SHOW_WARNING_ICON = 0x1
};
typedef DWORD PORT_SUPPLIER_DESCRIPTION_FLAGS;
```

```csharp
public enum enum_PORT_SUPPLIER_DESCRIPTION_FLAGS
{
    PSDFLAG_SHOW_WARNING_ICON = 0x1
};
```

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
