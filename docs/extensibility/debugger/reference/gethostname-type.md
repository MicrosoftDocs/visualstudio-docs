---
description: "Specifies the type of host name."
title: GETHOSTNAME_TYPE
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- GETHOSTNAME_TYPE
helpviewer_keywords:
- GETHOSTNAME_TYPE enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# GETHOSTNAME_TYPE

Specifies the type of host name.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_GETHOSTNAME_TYPE {
    GHN_FRIENDLY_NAME = 0,
    GHN_FILE_NAME     = 1
};
```
### [C++](#tab/cpp)
```cpp
enum enum_GETHOSTNAME_TYPE {
    GHN_FRIENDLY_NAME = 0,
    GHN_FILE_NAME     = 1
};
typedef DWORD GETHOSTNAME_TYPE;
```
---

## Fields
`GHN_FRIENDLY_NAME`\
Specifies a friendly name of the host.

`GHN_FILE_NAME`\
Specifies a file name of the host.

## Remarks
These values are passed as an argument to the [GetHostName](../../../extensibility/debugger/reference/idebugprogramnode2-gethostname.md) method to retrieve a host name in different formats.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetHostName](../../../extensibility/debugger/reference/idebugprogramnode2-gethostname.md)
