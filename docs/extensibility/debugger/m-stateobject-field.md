---
description: "An object that represents data that the action will use."
title: m_stateObject Field | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- m_stateObject field, Task class [.NET Framework debug engines]
ms.assetid: 68c54b22-3e1c-4031-b9c7-b972c519d8a0
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# m_stateObject field
An object that represents data that the action will use.

 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>

 **Assembly:** mscorlib (in *mscorlib.dll*)

 Because you can't access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).

## Syntax

```
.field assembly object m_stateObject
```

## Remarks
 This is the `state` parameter in the <xref:System.Threading.Tasks.Task.%23ctor%2A> constructor. It is also the backing field for the <xref:System.Threading.Tasks.Task.AsyncState%2A?displayProperty=fullName> property.

## See also
- [Task class](../../extensibility/debugger/task-class-internal-members.md)
