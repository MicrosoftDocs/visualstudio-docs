---
title: "IDebugCanStopEvent2::GetDocumentContext | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugCanStopEvent2::GetDocumentContext"
helpviewer_keywords:
  - "IDebugCanStopEvent2::GetDocumentContext"
ms.assetid: 936a6c4e-30c5-4c7e-9ad5-910cc605a4b5
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugCanStopEvent2::GetDocumentContext
Gets the document context that describes the location of this event.

## Syntax

```cpp
HRESULT GetDocumentContext ( 
   IDebugDocumentContext2** ppDocCxt
);
```

```csharp
int GetDocumentContext ( 
   out IDebugDocumentContext2 ppDocCxt
);
```

## Parameters
`ppDocCxt`\
[out] Returns the [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) interface that represents a position in a source file document corresponding to the current code location.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Generally, the document context can be thought of as a position in a source file.

 To get the code context, which is oriented towards code instructions, call the [GetCodeContext](../../../extensibility/debugger/reference/idebugcanstopevent2-getcodecontext.md) method.

## See also
- [IDebugCanStopEvent2](../../../extensibility/debugger/reference/idebugcanstopevent2.md)
- [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)
- [GetCodeContext](../../../extensibility/debugger/reference/idebugcanstopevent2-getcodecontext.md)