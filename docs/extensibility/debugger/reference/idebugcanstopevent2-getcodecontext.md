---
description: "Gets the code context that describes the location of this event."
title: IDebugCanStopEvent2::GetCodeContext
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCanStopEvent2::GetCodeContext
helpviewer_keywords:
- IDebugCanStopEvent2::GetCodeContext
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCanStopEvent2::GetCodeContext

Gets the code context that describes the location of this event.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetCodeContext( 
   out IDebugCodeContext2 ppCodeContext
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetCodeContext( 
   IDebugCodeContext2** ppCodeContext
);
```
---

## Parameters
`ppCodeContext`\
[out] Returns the [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object that represents the current code location.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 For most run-time architectures, a code context can be thought of as an address in a program's execution stream, pointing to a specific instruction.

 To get the document context, which is oriented towards lines of source code, call the [GetDocumentContext](../../../extensibility/debugger/reference/idebugcanstopevent2-getdocumentcontext.md) method.

## See also
- [IDebugCanStopEvent2](../../../extensibility/debugger/reference/idebugcanstopevent2.md)
- [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)
- [GetDocumentContext](../../../extensibility/debugger/reference/idebugcanstopevent2-getdocumentcontext.md)
