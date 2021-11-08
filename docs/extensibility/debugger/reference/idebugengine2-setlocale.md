---
description: "Sets the locale of the debug engine (DE)."
title: IDebugEngine2::SetLocale | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine2::SetLocale
helpviewer_keywords:
- IDebugEngine2::SetLocale
ms.assetid: cd0d2cf1-2aac-43da-a830-4bb3d696c219
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
# IDebugEngine2::SetLocale
Sets the locale of the debug engine (DE).

## Syntax

```cpp
HRESULT SetLocale( 
   WORD wLangID
);
```

```csharp
int SetLocale( 
   ushort wLangID
);
```

## Parameters
`wLangID`\
[in] Specifies the language locale. For example, 1033 for English.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is called by the session debug manager (SDM) to propagate the locale settings of the IDE so that strings returned by the DE are properly localized.

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
