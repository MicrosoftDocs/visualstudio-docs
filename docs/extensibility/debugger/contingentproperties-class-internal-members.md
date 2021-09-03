---
description: "Contains additional properties for a System.Threading.Tasks.Task object."
title: ContingentProperties Class - Internal Members | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- ContingentProperties class [.NET Framework debug engines]
- debug engines, ContingentProperties class [.NET Framework]
ms.assetid: c49d1362-ab1c-4b6d-9950-fcae40e0e66b
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# ContingentProperties class - internal members
Contains additional properties for a <xref:System.Threading.Tasks.Task> object.

 **Namespace:** <xref:System.Threading.Tasks?displayProperty=fullName>

 **Assembly:** mscorlib (in mscorlib.dll)

 Because you cannot access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).

## Syntax

```csharp
.class auto ansi nested assembly beforefieldinit ContingentProperties
       extends System.Object
```

## Members

### Fields

|Name|Description|
|----------|-----------------|
|[m_children](../../extensibility/debugger/m-children-field.md)|The list of child tasks that are registered with this task.|

## Remarks
 The .NET Framework initializes the fields of this class only when they are needed.

## See also
- [Parallel extension internals for the .NET Framework](../../extensibility/debugger/parallel-extension-internals-for-the-dotnet-framework.md)
