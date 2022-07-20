---
description: "Retrieves a managed code interface that represents the value associated with this alias."
title: IDebugAlias::GetICorDebugValue | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugAlias::GetICorDebugValue
helpviewer_keywords:
- IDebugAlias::GetICorDebugValue method
ms.assetid: b9eb39ee-84af-4ace-9cfe-236b3d48aff5
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
# IDebugAlias::GetICorDebugValue

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Retrieves a managed code interface that represents the value associated with this alias.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetICorDebugValue(
   out object ppUnk
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetICorDebugValue(
   IUnknown** ppUnk
);
```
---

## Parameters
`ppUnk`\
[out] `IUnknown` interface that represents the value associated with this alias. This interface can be queried for the `ICorDebugValue` interface.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 This method applies only to managed values (the `ICorDebugValue` is an interface available in the .NET Framework and is defined in the .NET Framework SDK in the cordebug.idl file).

## See also
- [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)
