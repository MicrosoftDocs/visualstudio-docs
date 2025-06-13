---
title: INTERCEPT_EXCEPTION_ACTION
description: The INTERCEPT_EXCEPTION_ACTION enumeration specifies what action to take when intercepting exceptions in Visual Studio debugging.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- INTERCEPT_EXCEPTION_ACTION
helpviewer_keywords:
- INTERCEPT_EXCEPTION_ACTION enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# INTERCEPT_EXCEPTION_ACTION

Specifies what actions to take when intercepting exceptions.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_INTERCEPT_EXCEPTION_ACTION
{
    IEA_INTERCEPT = 0x0001
}
```
### [C++](#tab/cpp)
```cpp
enum enum_INTERCEPT_EXCEPTION_ACTION
{
    IEA_INTERCEPT = 0x0001
}
typedef DWORD INTERCEPT_EXCEPTION_ACTION;
```
---

## Parameters

`IEA_INTERCEPT`\
Enables intercepting the current exception. This is the only value supported at present and must be specified.

## Remarks
These values are passed into the [InterceptCurrentException](../../../extensibility/debugger/reference/idebugstackframe3-interceptcurrentexception.md) method.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [InterceptCurrentException](../../../extensibility/debugger/reference/idebugstackframe3-interceptcurrentexception.md)
