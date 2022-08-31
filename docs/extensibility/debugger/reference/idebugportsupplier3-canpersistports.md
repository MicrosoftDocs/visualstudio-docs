---
description: "This method determines whether the port supplier can persist ports (by writing them to disk) between invocations of the debugger."
title: IDebugPortSupplier3::CanPersistPorts | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortSupplier3::CanPersistPorts
helpviewer_keywords:
- IDebugPortSupplier3::CanPersistPorts
ms.assetid: 4127760c-e602-4e86-9232-457e382a52c7
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
# IDebugPortSupplier3::CanPersistPorts

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
This method determines whether the port supplier can persist ports (by writing them to disk) between invocations of the debugger.

## Syntax

### [C#](#tab/csharp)
```csharp
int CanPersistPorts();
```
### [C++](#tab/cpp)
```cpp
HRESULT CanPersistPorts();
```
---

## Parameters
 None.

## Return Value
 `S_OK` if ports can be persisted, or `S_FALSE` to indicate that ports cannot be persisted.

## Remarks
 If the port supplier can persist ports, it should do so when it is destroyed and then reload them when it is instantiated once again.

## See also
- [IDebugPortSupplier3](../../../extensibility/debugger/reference/idebugportsupplier3.md)
