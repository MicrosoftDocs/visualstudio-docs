---
description: "Gets the name of the function to which this position points."
title: IDebugFunctionPosition2::GetFunctionName | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugFunctionPosition2::GetFunctionName
helpviewer_keywords:
- IDebugFunctionPosition2::GetFunctionName
ms.assetid: eb7a348e-a7f5-4f25-be68-80482d5482a8
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugFunctionPosition2::GetFunctionName

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
