---
description: "Sets the name of the thread."
title: IDebugThread2::SetThreadName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugThread2::SetThreadName
helpviewer_keywords:
- IDebugThread2::SetThreadName
author: maiak
ms.author: maiak
manager: jmartens
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugThread2::SetThreadName

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Sets the name of the thread.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetThreadName ( 
   string pszName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetThreadName ( 
   LPCOLESTR pszName
);
```
---

## Parameters
`pszName`\
[in] The name of the thread.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 To get the thread name, call the [GetName](../../../extensibility/debugger/reference/idebugthread2-getname.md) method.

## See also
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [GetName](../../../extensibility/debugger/reference/idebugthread2-getname.md)
