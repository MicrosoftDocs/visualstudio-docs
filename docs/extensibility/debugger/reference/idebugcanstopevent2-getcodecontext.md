---
description: "Gets the code context that describes the location of this event."
title: IDebugCanStopEvent2::GetCodeContext | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCanStopEvent2::GetCodeContext
helpviewer_keywords:
- IDebugCanStopEvent2::GetCodeContext
ms.assetid: eecf08b6-f9b7-4358-941b-3a448a92ac62
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugCanStopEvent2::GetCodeContext
Gets the code context that describes the location of this event.

## Syntax

```cpp
HRESULT GetCodeContext( 
   IDebugCodeContext2** ppCodeContext
);
```

```csharp
int GetCodeContext( 
   out IDebugCodeContext2 ppCodeContext
);
```

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
