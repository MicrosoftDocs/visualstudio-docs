---
description: "Specifies how to parse an expression."
title: PARSEFLAGS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- PARSEFLAGS
helpviewer_keywords:
- PARSEFLAGS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# PARSEFLAGS

Specifies how to parse an expression.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_PARSEFLAGS { 
   PARSE_EXPRESSION            = 0x0001,
   PARSE_FUNCTION_AS_ADDRESS   = 0x0002,
   PARSE_DESIGN_TIME_EXPR_EVAL = 0x1000
};
```
### [C++](#tab/cpp)
```cpp
enum enum_PARSEFLAGS { 
   PARSE_EXPRESSION            = 0x0001,
   PARSE_FUNCTION_AS_ADDRESS   = 0x0002,
   PARSE_DESIGN_TIME_EXPR_EVAL = 0x1000
};
typedef DWORD PARSEFLAGS;
```
---

## Fields
 `PARSE_EXPRESSION`\
 Indicates that the expression is not a statement.

 `PARSE_FUNCTION_AS_ADDRESS`\
 Indicates that the expression is to be parsed (and later evaluated) as an address.

 `PARSE_DESIGN_TIME_EXPR_EVAL`\
 Indicates that the expression is being parsed during design time (that is, when a designer is open).

## Remarks
 Passed as a parameter to the [ParseText](../../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) and [Parse](../../../extensibility/debugger/reference/idebugexpressionevaluator-parse.md) methods.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [ParseText](../../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md)
- [Parse](../../../extensibility/debugger/reference/idebugexpressionevaluator-parse.md)
