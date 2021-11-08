---
description: "This method returns the number of argument types associated with this object."
title: IDebugBinder3::GetTypeArgumentCount | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder3::GetTypeArgumentCount
helpviewer_keywords:
- IDebugBinder3::GetTypeArgumentCount method
ms.assetid: caf68de6-6f7c-4efd-b803-121347a5032e
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugBinder3::GetTypeArgumentCount
This method returns the number of argument types associated with this object.

## Syntax

```cpp
HRESULT GetTypeArgumentCount(
   UINT* uCount
);
```

```csharp
int GetTypeArgumentCount(
   out uint uCount
);
```

## Parameters
`uCount`\
[out] Number of argument types associated with this object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The value returned by this method can be used to allocate an array for use with the [GetTypeArguments](../../../extensibility/debugger/reference/idebugbinder3-gettypearguments.md) method.

## See also
- [IDebugBinder3](../../../extensibility/debugger/reference/idebugbinder3.md)
- [GetTypeArguments](../../../extensibility/debugger/reference/idebugbinder3-gettypearguments.md)
