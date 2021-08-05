---
description: "Gets the name of the session that is debugging this process."
title: IDebugProcess2::GetAttachedSessionName | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess2::GetAttachedSessionName
helpviewer_keywords:
- IDebugProcess2::GetAttachedSessionName
ms.assetid: 7e5e116f-2c0c-4bc8-ad3f-e9fd2318a7e4
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
# IDebugProcess2::GetAttachedSessionName
Gets the name of the session that is debugging this process. An IDE can display this information to a user who is debugging a particular process on a particular machine.

> [!NOTE]
> This method is deprecated, and its implementation should always return `E_NOTIMPL`.

## Syntax

```
HRESULT GetAttachedSessionName(
   BSTR* pbstrSessionName
);
```

## Parameters
`pbstrSessionName`\

## Return Value
 This method should always return `E_NOTIMPL`.

## See also
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
