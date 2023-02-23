---
description: "Resets the code contexts enumeration to the first element."
title: IEnumDebugCodeContexts2::Reset | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugCodeContexts2::Reset
helpviewer_keywords:
- IEnumDebugCodeContexts2::Reset
ms.assetid: df6cf1e3-2ef8-4d38-81a0-8e9adf151884
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
# IEnumDebugCodeContexts2::Reset

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Resets the enumeration to the first element.

## Syntax

### [C#](#tab/csharp)
```csharp
int Reset();
```
### [C++](#tab/cpp)
```cpp
HRESULT Reset(
   void
);
```
---

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugcodecontexts2-next.md) method returns the first element of the enumeration.

## See also
- [IEnumDebugCodeContexts2](../../../extensibility/debugger/reference/ienumdebugcodecontexts2.md)
