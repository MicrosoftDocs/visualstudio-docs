---
description: "Specifies the step kind for stepping."
title: STEPKIND
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- STEPKIND
helpviewer_keywords:
- STEPKIND enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# STEPKIND

Specifies the step kind for stepping.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_STEPKIND { 
   STEP_INTO      = 0,
   STEP_OVER      = 1,
   STEP_OUT       = 2,
   STEP_BACKWARDS = 3
};
```
### [C++](#tab/cpp)
```cpp
enum enum_STEPKIND { 
   STEP_INTO      = 0,
   STEP_OVER      = 1,
   STEP_OUT       = 2,
   STEP_BACKWARDS = 3
};
typedef DWORD STEPKIND;
```
---

## Fields
 `STEP_INTO`\
 Steps into a function.

 `STEP_OVER`\
 Steps over a function.

 `STEP_OUT`\
 Steps out of a function.

 `STEP_BACKWARDS`\
 Steps backward into a function.

## Remarks
 Passed as an argument to the [Step](../../../extensibility/debugger/reference/idebugprocess3-step.md) method.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [Step](../../../extensibility/debugger/reference/idebugprocess3-step.md)
