---
title: "INTERCEPT_EXCEPTION_ACTION | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "INTERCEPT_EXCEPTION_ACTION"
helpviewer_keywords:
  - "INTERCEPT_EXCEPTION_ACTION enumeration"
ms.assetid: e647f1eb-2932-4447-8c78-3b0d706fb972
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# INTERCEPT_EXCEPTION_ACTION
Specifies what actions to take when intercepting exceptions.

## Syntax

```cpp
enum enum_INTERCEPT_EXCEPTION_ACTION
{
    IEA_INTERCEPT = 0x0001
}
typedef DWORD INTERCEPT_EXCEPTION_ACTION;
```

```csharp
public enum enum_INTERCEPT_EXCEPTION_ACTION
{
    IEA_INTERCEPT = 0x0001
}
```

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
