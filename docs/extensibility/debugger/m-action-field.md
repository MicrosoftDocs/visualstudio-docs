---
description: "The delegate that represents the code to execute in the System.Threading.Tasks.Task object."
title: m_action Field | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- m_action field, Task class [.NET Framework debug engines]
ms.assetid: 201838c2-260d-4071-b6c3-f526874e19c9
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# m_action field
The delegate that represents the code to execute in the <xref:System.Threading.Tasks.Task> object.

 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>

 **Assembly:** mscorlib (in *mscorlib.dll*)

 Because you can't access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).

## Syntax

```csharp
.field assembly object m_action
```

## Remarks
 This is the `action` parameter in the <xref:System.Threading.Tasks.Task.%23ctor%2A> constructor.

## See also
- [Task class](../../extensibility/debugger/task-class-internal-members.md)
