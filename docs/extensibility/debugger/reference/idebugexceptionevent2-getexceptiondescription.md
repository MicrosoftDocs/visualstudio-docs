---
description: "Gets a displayable description of the exception."
title: IDebugExceptionEvent2::GetExceptionDescription
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExceptionEvent2::GetExceptionDescription
helpviewer_keywords:
- IDebugExceptionEvent2::GetExceptionDescription
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExceptionEvent2::GetExceptionDescription

Gets a displayable description of the exception.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetExceptionDescription( 
   out string pbstrDescription
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetExceptionDescription( 
   BSTR* pbstrDescription
);
```
---

## Parameters
`pbstrDescription`\
[out] Returns a displayable description of the exception.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The string returned from this method is typically the name of the exception and is shown in the **Output** window when the exception occurs.

## See also
- [IDebugExceptionEvent2](../../../extensibility/debugger/reference/idebugexceptionevent2.md)
