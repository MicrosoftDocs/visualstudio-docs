---
title: Registering a Custom Debug Engine
description: Learn how the debug engine registers itself as a class factory, following COM conventions, as well as registering with Visual Studio through the registry.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debug engines, registering
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Register a custom debug engine

The debug engine must register itself as a class factory, following COM conventions as well as register with Visual Studio through the Visual Studio registry subkey.

> [!NOTE]
> You can find an example of how to register a debug engine in the TextInterpreter sample, which is built as part of the [Tutorial: Building a debug engine using ATL COM](/previous-versions/bb147024(v=vs.90)).

## DLL server process
 A debug engine is typically set up in its own DLL as a COM server. As such, the debug engine must register the CLSID of its class factory with COM before Visual Studio can access it. Then, the debug engine must register itself with Visual Studio to establish any properties (otherwise known as metrics) the debug engine supports. The choice of metrics written to the Visual Studio registry subkey depends on the features the debug engine supports.

 [SDK helpers for debugging](../../extensibility/debugger/reference/sdk-helpers-for-debugging.md) describes not only the registry locations necessary to register a debug engine; it also describes the *dbgmetric.lib* library, which contains a number of useful functions and declarations for C++ developers that make manipulating the registry easier.

### Example
 The following example (from the TextInterpreter sample) shows how to use the `SetMetric` function (from *dbgmetric.lib*), to register a debug engine with Visual Studio. The metrics being passed are also defined in *dbgmetric.lib*.

> [!NOTE]
> TextInterpreter is a basic debug engine; it does not set up—and therefore does not register—any other features. A more complete debug engine would have a whole list of `SetMetric` calls or their equivalent, one for each feature the debug engine supports.

```
// Define base registry subkey to Visual Studio.
static const WCHAR strRegistrationRoot[] = L"Software\\Microsoft\\VisualStudio\\8.0";

HRESULT CTextInterpreterModule::RegisterServer(BOOL bRegTypeLib, const CLSID * pCLSID)
{
    SetMetric(metrictypeEngine, __uuidof(Engine), metricName, L"Text File", false, strRegistrationRoot);
    SetMetric(metrictypeEngine, __uuidof(Engine), metricCLSID, CLSID_Engine, false, strRegistrationRoot);
    SetMetric(metrictypeEngine, __uuidof(Engine), metricProgramProvider, CLSID_MsProgramProvider, false, strRegistrationRoot);

    return base::RegisterServer(bRegTypeLib, pCLSID);
}
```

## Related content
- [Creating a custom debug engine](../../extensibility/debugger/creating-a-custom-debug-engine.md)
- [SDK helpers for debugging](../../extensibility/debugger/reference/sdk-helpers-for-debugging.md)
- [Tutorial: Building a debug engine using ATL COM](/previous-versions/bb147024(v=vs.90))