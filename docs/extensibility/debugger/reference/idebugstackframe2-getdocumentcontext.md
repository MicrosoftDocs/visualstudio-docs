---
description: "Gets the document context for this stack frame."
title: IDebugStackFrame2::GetDocumentContext
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugStackFrame2::GetDocumentContext
helpviewer_keywords:
- IDebugStackFrame2::GetDocumentContext
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugStackFrame2::GetDocumentContext

Gets the document context for this stack frame.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetDocumentContext ( 
   out IDebugDocumentContext2 ppCxt
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetDocumentContext ( 
   IDebugDocumentContext2** ppCxt
);
```
---

## Parameters
`ppCxt`\
[out] Returns an [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) object that represents the current position in a source document.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is faster than calling the [GetCodeContext](../../../extensibility/debugger/reference/idebugstackframe2-getcodecontext.md) method and then calling the [GetDocumentContext](../../../extensibility/debugger/reference/idebugcodecontext2-getdocumentcontext.md) method on the code context. However, it is not guaranteed that every debug engine (DE) will implement this method.

## See also
- [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
- [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)
- [GetDocumentContext](../../../extensibility/debugger/reference/idebugcodecontext2-getdocumentcontext.md)
- [GetCodeContext](../../../extensibility/debugger/reference/idebugstackframe2-getcodecontext.md)
