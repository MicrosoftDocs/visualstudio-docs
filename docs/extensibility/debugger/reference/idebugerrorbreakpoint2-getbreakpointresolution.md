---
description: "Gets the breakpoint error resolution that describes the error."
title: IDebugErrorBreakpoint2::GetBreakpointResolution
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugErrorBreakpoint2::GetBreakpointResolution
helpviewer_keywords:
- IDebugErrorBreakpoint2::GetBreakpointResolution
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugErrorBreakpoint2::GetBreakpointResolution

Gets the breakpoint error resolution that describes the error.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetBreakpointResolution( 
   out IDebugErrorBreakpointResolution2 ppErrorResolution
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetBreakpointResolution( 
   IDebugErrorBreakpointResolution2** ppErrorResolution
);
```
---

## Parameters
`ppErrorResolution`\
[out] Returns an [IDebugErrorBreakpointResolution2](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2.md) object that describes the error.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugErrorBreakpoint2](../../../extensibility/debugger/reference/idebugerrorbreakpoint2.md)
- [IDebugErrorBreakpointResolution2](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2.md)
