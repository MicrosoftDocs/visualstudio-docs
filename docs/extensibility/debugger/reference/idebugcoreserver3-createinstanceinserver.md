---
description: "Creates an instance of a debug engine on the server."
title: IDebugCoreServer3::CreateInstanceInServer
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer3::CreateInstanceInServer
helpviewer_keywords:
- IDebugCoreServer3::CreateInstanceInServer
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCoreServer3::CreateInstanceInServer

Creates an instance of a debug engine on the server.

## Syntax

### [C#](#tab/csharp)
```csharp
int CreateInstanceInServer(
   string     szDll,
   ushort     wLangID,
   ref Guid   clsidObject,
   ref Guid   riid,
   out IntPtr ppvObject
);
```
### [C++](#tab/cpp)
```cpp
HRESULT CreateInstanceInServer(
   LPCWSTR  szDll,
   WORD     wLangId,
   REFCLSID clsidObject,
   REFIID   riid,
   void**   ppvObject
);
```
---

## Parameters
`szDll`\
[in] Path to the dll that implements the CLSID specified in the `clsidObject` parameter. If this is `NULL`, then COM's `CoCreateInstance` function is called.

`wLangId`\
[in] Locale of the debug engine. This can be 0 if the [SetLocale](../../../extensibility/debugger/reference/idebugengine2-setlocale.md) method should not be called.

`clsidObject`\
[in] CLSID of the debug engine to create.

`riid`\
[in] Interface ID of the specific interface to retrieve from the class object.

`ppvObject`\
[out] `IUnknown` interface from the instantiated object. Cast or marshal this object to the desired interface.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)
- [SetLocale](../../../extensibility/debugger/reference/idebugengine2-setlocale.md)
