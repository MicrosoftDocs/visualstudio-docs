---
description: "Gets the range for this document position."
title: IDebugDocumentPosition2::GetRange
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentPosition2::GetRange
helpviewer_keywords:
- IDebugDocumentPosition2::GetRange
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentPosition2::GetRange

Gets the range for this document position.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetRange( 
   TEXT_POSITION[] pBegPosition,
   TEXT_POSITION[] pEndPosition
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetRange( 
   TEXT_POSITION* pBegPosition,
   TEXT_POSITION* pEndPosition
);
```
---

## Parameters
`pBegPosition`\
[in, out] A [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) structure that is filled in with the starting position. Set this argument to a null value if this information is not needed.

`pEndPosition`\
[in, out] A [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) structure that is filled in with the ending position. Set this argument to a null value if this information is not needed.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The range specified in a document position for a location breakpoint is used by the debug engine (DE) to search ahead for a statement that actually contributes code. For example, consider the following code:

```
Line 5: // comment
Line 6: x = 1;
```

 Line 5 contributes no code to the program being debugged. If the debugger that sets the breakpoint on line 5 wants the DE to search forward a certain amount for the first line that contributes code, the debugger would specify a range that includes additional candidate lines where a breakpoint might be properly placed. The DE would then search forward through those lines until it found a line that could accept a breakpoint.

## See also
- [IDebugDocumentPosition2](../../../extensibility/debugger/reference/idebugdocumentposition2.md)
- [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)
