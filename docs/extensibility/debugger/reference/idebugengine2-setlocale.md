---
description: "Sets the locale of the debug engine (DE)."
title: IDebugEngine2::SetLocale
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine2::SetLocale
helpviewer_keywords:
- IDebugEngine2::SetLocale
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine2::SetLocale

Sets the locale of the debug engine (DE).

## Syntax

### [C#](#tab/csharp)
```csharp
int SetLocale( 
   ushort wLangID
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetLocale( 
   WORD wLangID
);
```
---

## Parameters
`wLangID`\
[in] Specifies the language locale. For example, 1033 for English.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is called by the session debug manager (SDM) to propagate the locale settings of the IDE so that strings returned by the DE are properly localized.

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
