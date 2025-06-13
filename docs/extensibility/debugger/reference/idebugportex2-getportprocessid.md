---
description: "Gets the process ID of the port itself."
title: IDebugPortEx2::GetPortProcessId
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortEx2::GetPortProcessId
helpviewer_keywords:
- IDebugPortEx2::GetPortProcessId
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortEx2::GetPortProcessId

Gets the process ID of the port itself.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPortProcessId ( 
   out uint pdwProcessId
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPortProcessId ( 
   DWORD* pdwProcessId
);
```
---

## Parameters
`pdwProcessId`\
[out] Returns the physical process ID of the port itself.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 In the Win32 runtime for example, this method typically calls the Win32 function `GetCurrentProcessId` to get the physical process ID.

## See also
- [IDebugPortEx2](../../../extensibility/debugger/reference/idebugportex2.md)
