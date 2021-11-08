---
description: "Determines if the server is local to the caller."
title: IDebugCoreServer3::QueryIsLocal | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer3::QueryIsLocal
helpviewer_keywords:
- IDebugCoreServer3::QueryIsLocal
ms.assetid: cca030de-f853-4ed7-b2fb-395f08a6b884
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
# IDebugCoreServer3::QueryIsLocal
Determines if the server is local to the caller.

## Syntax

```cpp
HRESULT QueryIsLocal(
   void
);
```

```csharp
int QueryIsLocal();
```

## Return Value
 Returns `S_OK` to indicate the server is local. Returns `S_FALSE` if the server is running from an instance of msvsmon.exe, which is typically used for remote debugging.

## See also
- [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)
