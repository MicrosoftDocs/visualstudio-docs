---
description: "Returns the number of elements in the processes enumeration."
title: IEnumDebugProcesses2::GetCount | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugProcesses2::GetCount
helpviewer_keywords:
- IEnumDebugProcesses2::GetCount
ms.assetid: 5dc3e36c-46e5-4556-bf41-1870aa67d2a0
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
# IEnumDebugProcesses2::GetCount

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Returns the number of elements in the enumeration.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetCount(
   out uint pcelt
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetCount(
   ULONG* pcelt
);
```
---

## Parameters
`pcelt`\
[out] Returns the number of elements in the enumeration.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is not part of the customary COM enumeration interface which specifies that only the `Next`, `Clone`, `Skip`, and `Reset` methods need to be implemented.

## See also
- [IEnumDebugProcesses2](../../../extensibility/debugger/reference/ienumdebugprocesses2.md)
