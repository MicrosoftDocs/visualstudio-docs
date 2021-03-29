---
description: "Gets a displayable description of the exception."
title: IDebugExceptionEvent2::GetExceptionDescription | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExceptionEvent2::GetExceptionDescription
helpviewer_keywords:
- IDebugExceptionEvent2::GetExceptionDescription
ms.assetid: d07d458f-5729-47e4-9b77-1bd59c61a75a
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugExceptionEvent2::GetExceptionDescription
Gets a displayable description of the exception.

## Syntax

```cpp
HRESULT GetExceptionDescription( 
   BSTR* pbstrDescription
);
```

```csharp
int GetExceptionDescription( 
   out string pbstrDescription
);
```

## Parameters
`pbstrDescription`\
[out] Returns a displayable description of the exception.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The string returned from this method is typically the name of the exception and is shown in the **Output** window when the exception occurs.

## See also
- [IDebugExceptionEvent2](../../../extensibility/debugger/reference/idebugexceptionevent2.md)
