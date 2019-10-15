---
title: "IDebugObject::IsProxy | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IDebugObject::IsProxy"
  - "IsProxy"
ms.assetid: 06c66b87-db95-4400-ab26-5d33e743a439
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugObject::IsProxy
Determines if the object is a transparent proxy.

## Syntax

```cpp
HRESULT IsProxy (
   BOOL* pfIsProxy
);
```

```csharp
int IsProxy (
   out bool pfIsProxy
);
```

## Parameters
`pfIsProxy`\
[out] `TRUE` if the object is a transparent proxy; otherwise, `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is implemented by the default C++ debug engine.

## See also
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)