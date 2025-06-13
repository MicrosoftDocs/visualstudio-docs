---
description: "Gets the name of the function to which this position points."
title: IDebugFunctionPosition2::GetFunctionName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugFunctionPosition2::GetFunctionName
helpviewer_keywords:
- IDebugFunctionPosition2::GetFunctionName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugFunctionPosition2::GetFunctionName

Gets the name of the function to which this position points.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetFunctionName(
   out string pbstrFunctionName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetFunctionName( 
   BSTR* pbstrFunctionName
);
```
---

## Parameters
`pbstrFunctionName`\
[out] Returns the name of the function.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugFunctionPosition2](../../../extensibility/debugger/reference/idebugfunctionposition2.md)
