---
description: "Describes the properties of a thread."
title: THREADPROPERTIES
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- THREADPROPERTIES
helpviewer_keywords:
- THREADPROPERTIES structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# THREADPROPERTIES

Describes the properties of a thread.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct THREADPROPERTIES { 
   public uint   dwFields;
   public uint   dwThreadId;
   public uint   dwSuspendCount;
   public uint   dwThreadState;
   public string bstrPriority;
   public string bstrName;
   public string bstrLocation;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct _tagTHREADPROPERTIES { 
   THREADPROPERTY_FIELDS dwFields;
   DWORD                 dwThreadId;
   DWORD                 dwSuspendCount;
   DWORD                 dwThreadState;
   BSTR                  bstrPriority;
   BSTR                  bstrName;
   BSTR                  bstrLocation;
} THREADPROPERTIES;
```
---

## Members
 `dwFields`\
 A combination of flags from the [THREADPROPERTY_FIELDS](../../../extensibility/debugger/reference/threadproperty-fields.md) enumeration, describing which fields in this structure are valid.

 `dwThreadId`\
 The thread ID.

 `dwSuspendCount`\
 The thread suspend count.

 `dwThreadState`\
 A value from the [THREADSTATE](../../../extensibility/debugger/reference/threadstate.md) enumeration indicating the state of the operating thread.

 `bstrPriority`\
 A string specifying the thread priority; for example, "Above Normal", "Normal", or "Time Critical".

 `bstName`\
 The thread name.

 `bstrLocation`\
 The thread location (usually the topmost stack frame), typically expressed as the name of the method where execution is currently halted.

## Remarks
 This structure is filled in by a call to the [GetThreadProperties](../../../extensibility/debugger/reference/idebugthread2-getthreadproperties.md) method. The information so returned is typically used in populating the **Threads** window.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [GetThreadProperties](../../../extensibility/debugger/reference/idebugthread2-getthreadproperties.md)
- [THREADPROPERTY_FIELDS](../../../extensibility/debugger/reference/threadproperty-fields.md)
- [THREADSTATE](../../../extensibility/debugger/reference/threadstate.md)
