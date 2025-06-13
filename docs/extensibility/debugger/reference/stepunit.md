---
description: "Specifies the step unit for stepping."
title: STEPUNIT
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- STEPUNIT
helpviewer_keywords:
- STEPUNIT enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# STEPUNIT

Specifies the step unit for stepping.

## Syntax

### [C#](#tab/csharp)
```csharp
enum enum_STEPUNIT { 
   STEP_STATEMENT   = 0,
   STEP_LINE        = 1,
   STEP_INSTRUCTION = 2
};
```
### [C++](#tab/cpp)
```cpp
enum enum_STEPUNIT { 
   STEP_STATEMENT   = 0,
   STEP_LINE        = 1,
   STEP_INSTRUCTION = 2
};
typedef DWORD STEPUNIT;
```
---

## Fields
 `STEP_STATEMENT`\
 Steps by statement.

 `STEP_LINE`\
 Steps by line.

 `STEP_INSTRUCTION`\
 Steps by instruction.

## Remarks
 Passed as an argument to the [Step](../../../extensibility/debugger/reference/idebugprocess3-step.md) method.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [Step](../../../extensibility/debugger/reference/idebugprocess3-step.md)
