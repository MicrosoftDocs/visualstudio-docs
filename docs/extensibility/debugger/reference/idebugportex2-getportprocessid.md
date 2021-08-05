---
description: "Gets the process ID of the port itself."
title: IDebugPortEx2::GetPortProcessId | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortEx2::GetPortProcessId
helpviewer_keywords:
- IDebugPortEx2::GetPortProcessId
ms.assetid: be85be66-47e6-415f-b0ca-24599aa5f13c
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
# IDebugPortEx2::GetPortProcessId
Gets the process ID of the port itself.

## Syntax

```cpp
HRESULT GetPortProcessId ( 
   DWORD* pdwProcessId
);
```

```csharp
int GetPortProcessId ( 
   out uint pdwProcessId
);
```

## Parameters
`pdwProcessId`\
[out] Returns the physical process ID of the port itself.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 In the Win32 runtime for example, this method typically calls the Win32 function `GetCurrentProcessId` to get the physical process ID.

## See also
- [IDebugPortEx2](../../../extensibility/debugger/reference/idebugportex2.md)
