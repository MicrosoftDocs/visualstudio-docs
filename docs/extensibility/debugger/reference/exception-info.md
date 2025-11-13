---
description: "Describes an exception or run-time error thrown by the program being debugged."
title: EXCEPTION_INFO
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- EXCEPTION_INFO
helpviewer_keywords:
- EXCEPTION_INFO structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# EXCEPTION_INFO

Describes an exception or run-time error thrown by the program being debugged.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct EXCEPTION_INFO {
    public IDebugProgram2 pProgram;
    public string         bstrProgramName;
    public string         bstrExceptionName;
    public uint           dwCode;
    public uint           dwState;
    public Guid           guidType;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct tagEXCEPTION_INFO {
    IDebugProgram2* pProgram;
    BSTR            bstrProgramName;
    BSTR            bstrExceptionName;
    DWORD           dwCode;
    EXCEPTION_STATE dwState;
    GUID            guidType;
} EXCEPTION_INFO;
```
---

## Members
`pProgram`\
The [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) object that represents the program in which the exception occurred.

`bstrProgramName`\
The name of the program in which the exception occurred.

`bstrExceptionName`\
The name of the exception.

`dwCode`\
The identification code for the exception or run-time error.

`dwState`\
A value from the [EXCEPTION_STATE](../../../extensibility/debugger/reference/exception-state.md) enumeration that defines the state of the exception.

`guidType`\
The GUID language identifier, either `guidLang` or `guidEng`.

## Remarks
This structure is passed as a parameter to the [SetException](../../../extensibility/debugger/reference/idebugengine2-setexception.md) and the [RemoveSetException](../../../extensibility/debugger/reference/idebugengine2-removesetexception.md) methods. This structure is also passed to the [GetException](../../../extensibility/debugger/reference/idebugexceptionevent2-getexception.md) method to be filled in.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [EXCEPTION_STATE](../../../extensibility/debugger/reference/exception-state.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [SetException](../../../extensibility/debugger/reference/idebugengine2-setexception.md)
- [RemoveSetException](../../../extensibility/debugger/reference/idebugengine2-removesetexception.md)
- [GetException](../../../extensibility/debugger/reference/idebugexceptionevent2-getexception.md)
