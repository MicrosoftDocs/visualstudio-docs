---
description: "This method returns a GUID representing the language of this process as set by a call to SetHostingProcessLanguage."
title: IDebugProcess3::GetHostingProcessLanguage | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess3::GetHostingProcessLanguage
helpviewer_keywords:
- IDebugProcess3::GetHostingProcessLanguage
ms.assetid: 52fca002-a9ef-43b1-9192-afbe7bb59ad4
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
# IDebugProcess3::GetHostingProcessLanguage

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
This method returns a `GUID` representing the language of this process as set by a call to [SetHostingProcessLanguage](../../../extensibility/debugger/reference/idebugprocess3-sethostingprocesslanguage.md).

## Syntax

### [C#](#tab/csharp)
```csharp
int GetHostingProcessLanguage(
   out Guid pguidLang
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetHostingProcessLanguage(
   GUID* pguidLang
);
```
---

## Parameters
`pguidLang`\
[out] The `GUID` of the language of this process. `GUID_NULL` (C++) or `Guid.Empty` (C#) means that the language is not set.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## See also
- [IDebugProcess3](../../../extensibility/debugger/reference/idebugprocess3.md)
- [SetHostingProcessLanguage](../../../extensibility/debugger/reference/idebugprocess3-sethostingprocesslanguage.md)
