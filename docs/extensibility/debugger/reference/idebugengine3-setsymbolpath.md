---
description: "Sets the path or paths that are searched for debugging symbols."
title: IDebugEngine3::SetSymbolPath
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine3::SetSymbolPath
helpviewer_keywords:
- IDebugEngine3::SetSymbolPath
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine3::SetSymbolPath

Sets the path or paths that are searched for debugging symbols.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetSymbolPath(
   string                    szSymbolSearchPath,
   string                    szSymbolCachePath,
   enum_LOAD_SYMBOLS_FLAGS   Flags
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetSymbolPath (
   LPOLESTR            szSymbolSearchPath,
   LPOLESTR            szSymbolCachePath,
   LOAD_SYMBOLS_FLAGS  Flags
);
```
---

## Parameters

`szSymbolSearchPath`\
[in] String containing the symbol search path or paths. See "Remarks" for details. Cannot be null.

`szSymbolCachePath`\
[in] String containing the local path where symbols can be cached. Cannot be null.

`Flags`\
[in] Not used; always set to 0.

## Return Value
 If successful, returns S_OK; otherwise returns an error code.

## Remarks
 The string `szSymbolSearchPath` is a list of one or more paths, separated by semicolons, to search for symbols. These paths can be a local path, a UNC-style path, or a URL. These paths can also be a mix of different types. If the path is UNC (for example, \\\Symserver\Symbols), then the debug engine should determine if the path is to a symbol server and should be able to load symbols from that server, caching them in the path specified by `szSymbolCachePath`.

 The symbol path can also contain one or more cache locations. Caches are listed in priority order, with the highest priority cache first, and separated by * symbols. For example:

```
\\symbols\symbols;\\someotherserver\symbols;c:\symbols\httpsymbols*https://msdl.microsoft.com
```

 The [LoadSymbols](../../../extensibility/debugger/reference/idebugengine3-loadsymbols.md) method performs the actual load of the symbols.

## See also
- [LoadSymbols](../../../extensibility/debugger/reference/idebugengine3-loadsymbols.md)
- [IDebugEngine3](../../../extensibility/debugger/reference/idebugengine3.md)
