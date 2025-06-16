---
description: "Sets the service provider."
title: IDebugPortPicker::SetSite
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugPortPicker::SetSite
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortPicker::SetSite

Sets the service provider.

## Syntax

### [C#](#tab/csharp)
```csharp
public int SetSite(
   IServiceProvider pSP
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetSite(
   IServiceProvider * pSP
);
```
---

## Parameters
`pSP`\
[in] Reference to the interface of the service provider.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method will be called before any other methods are called.

## See also
- [IDebugPortPicker](../../../extensibility/debugger/reference/idebugportpicker.md)
