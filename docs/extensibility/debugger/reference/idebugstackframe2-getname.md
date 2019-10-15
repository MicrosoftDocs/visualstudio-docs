---
title: "IDebugStackFrame2::GetName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugStackFrame2::GetName"
helpviewer_keywords:
  - "IDebugStackFrame2::GetName"
ms.assetid: 069d4f96-363f-404e-9c89-5318c4c9821b
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugStackFrame2::GetName
Gets the name of the stack frame.

## Syntax

```cpp
HRESULT GetName ( 
   BSTR* pbstrName
);
```

```csharp
int GetName ( 
   out string pbstrName
);
```

## Parameters
`pbstrName`\
[out] Returns the name of the stack frame.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The name of a stack frame is typically the name of the method being executed.

## See also
- [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)