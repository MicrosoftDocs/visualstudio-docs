---
description: "Determines whether the checksum is enabled for this document."
title: IDebugBreakpointChecksumRequest2::IsChecksumEnabled
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugBreakpointChecksumRequest2::IsChecksumEnabled
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBreakpointChecksumRequest2::IsChecksumEnabled

Determines whether the checksum is enabled for this document.

## Syntax

### [C#](#tab/csharp)
```csharp
public int IsChecksumEnabled(
   out int pfChecksumEnabled
);
```
### [C++](#tab/cpp)
```cpp
HRESULT IsChecksumEnabled(
   BOOL *pfChecksumEnabled
);
```
---

## Parameters
`pfChecksumEnabled`\
[out] Returns TRUE if the checksum is enabled; otherwise, returns FALSE.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugBreakpointChecksumRequest2](../../../extensibility/debugger/reference/idebugbreakpointchecksumrequest2.md)
