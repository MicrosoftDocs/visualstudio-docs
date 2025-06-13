---
description: "Describes the attributes of a document."
title: TEXT_DOC_ATTR_2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- TEXT_DOC_ATTR_2
helpviewer_keywords:
- TEXT_DOC_ATTR_2 enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# TEXT_DOC_ATTR_2

Describes the attributes of a document.

## Syntax

### [C#](#tab/csharp)
```csharp
public const uint TEXT_DOC_ATTR_READONLY_2 = 0x00000001;
```
### [C++](#tab/cpp)
```cpp
typedef DWORD TEXT_DOC_ATTR_2;
const TEXT_DOC_ATTR_2 TEXT_DOC_ATTR_READONLY_2 = 0x00000001;
```
---

## Members
 `TEXT_DOC_ATTR_READONLY_2`\
 Indicates that the document is read-only.

## Remarks

> [!NOTE]
> This value is not actually defined in the assembly for C#. Instead, you must copy the definition to your source file.

 Passed as an argument to the [onUpdateDocumentAttributes](../../../extensibility/debugger/reference/idebugdocumenttextevents2-onupdatedocumentattributes.md) method.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [onUpdateDocumentAttributes](../../../extensibility/debugger/reference/idebugdocumenttextevents2-onupdatedocumentattributes.md)
