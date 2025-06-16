---
description: "Gets a description of the process."
title: IDebugProcess2::GetInfo
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess2::GetInfo
helpviewer_keywords:
- IDebugProcess2::GetInfo
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcess2::GetInfo

Gets a description of the process.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetInfo(
   enum_PROCESS_INFO_FIELDS  Fields,
   PROCESS_INFO[]            pProcessInfo
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetInfo(
   PROCESS_INFO_FIELDS  Fields,
   PROCESS_INFO*        pProcessInfo
);
```
---

## Parameters
`Fields`\
[in] A combination of values from the [PROCESS_INFO_FIELDS](../../../extensibility/debugger/reference/process-info-fields.md) enumeration that specifies which fields of the `pProcessInfo` parameter are to be filled in.

`pProcessInfo`\
[out] A [PROCESS_INFO](../../../extensibility/debugger/reference/process-info.md) structure that is filled in with a description of the process.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
- [PROCESS_INFO_FIELDS](../../../extensibility/debugger/reference/process-info-fields.md)
- [PROCESS_INFO](../../../extensibility/debugger/reference/process-info.md)
