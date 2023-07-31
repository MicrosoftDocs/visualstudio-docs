---
description: "Determines if the object is a transparent proxy."
title: IDebugObject::IsProxy | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugObject::IsProxy
- IsProxy
ms.assetid: 06c66b87-db95-4400-ab26-5d33e743a439
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
# IDebugObject::IsProxy

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Determines if the object is a transparent proxy.

## Syntax

### [C#](#tab/csharp)
```csharp
int IsProxy (
   out bool pfIsProxy
);
```
### [C++](#tab/cpp)
```cpp
HRESULT IsProxy (
   BOOL* pfIsProxy
);
```
---

## Parameters
`pfIsProxy`\
[out] `TRUE` if the object is a transparent proxy; otherwise, `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is implemented by the default C++ debug engine.

## See also
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
