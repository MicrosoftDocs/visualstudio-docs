---
title: "IDebugFunctionPosition2::GetFunctionName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugFunctionPosition2::GetFunctionName"
helpviewer_keywords:
  - "IDebugFunctionPosition2::GetFunctionName"
ms.assetid: eb7a348e-a7f5-4f25-be68-80482d5482a8
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugFunctionPosition2::GetFunctionName
Gets the name of the function to which this position points.

## Syntax

```cpp
HRESULT GetFunctionName( 
   BSTR* pbstrFunctionName
);
```

```csharp
int GetFunctionName(
   out string pbstrFunctionName
);
```

## Parameters
`pbstrFunctionName`\
[out] Returns the name of the function.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugFunctionPosition2](../../../extensibility/debugger/reference/idebugfunctionposition2.md)