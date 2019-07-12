---
title: "TEXT_DOC_ATTR_2 | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "TEXT_DOC_ATTR_2"
helpviewer_keywords:
  - "TEXT_DOC_ATTR_2 enumeration"
ms.assetid: 2333b33b-042b-4ac6-9ebe-e66f95f52f51
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# TEXT_DOC_ATTR_2
Describes the attributes of a document.

## Syntax

```cpp
typedef DWORD TEXT_DOC_ATTR_2;
const TEXT_DOC_ATTR_2 TEXT_DOC_ATTR_READONLY_2 = 0x00000001;
```

```csharp
public const uint TEXT_DOC_ATTR_READONLY_2 = 0x00000001;
```

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