---
description: "This registered interface allows the session debug manager (SDM) to obtain information about programs that have been published through the IDebugProgramPublisher2 interface."
title: IDebugProgramProvider2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramProvider2
helpviewer_keywords:
- IDebugProgramProvider2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProgramProvider2

This registered interface allows the session debug manager (SDM) to obtain information about programs that have been "published" through the [IDebugProgramPublisher2](../../../extensibility/debugger/reference/idebugprogrampublisher2.md) interface.

## Syntax

```
IDebugProgramProvider2 : IUnknown
```

## Notes for Implementers
The debug engine (DE) implements this interface to provide information about programs being debugged. This interface is registered in the DE section of the registry using the metric `metricProgramProvider`, as described in [SDK Helpers for Debugging](../../../extensibility/debugger/reference/sdk-helpers-for-debugging.md).

## Notes for Callers
Call COM's `CoCreateInstance` function with the `CLSID` of the program provider that is obtained from the registry. See the Example.

## Methods in Vtable order

|Method|Description|
|------------|-----------------|
|[GetProviderProcessData](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprocessdata.md)|Obtains information about programs running, filtered in a variety of ways.|
|[GetProviderProgramNode](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprogramnode.md)|Gets a program node, given a specific process ID.|
|[WatchForProviderEvents](../../../extensibility/debugger/reference/idebugprogramprovider2-watchforproviderevents.md)|Establishes a callback to watch for provider events associated with specific kinds of processes.|
|[SetLocale](../../../extensibility/debugger/reference/idebugprogramprovider2-setlocale.md)|Establishes a locale for any language-specific resources needed by the DE.|

## Remarks
Normally, a process uses this interface to find out about the programs running in that process.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## Example

```cpp
IDebugProgramProvider2 *GetProgramProvider(GUID *pDebugEngineGuid)
{
    // This is typically defined globally. For this example, it is
    // defined here.
    static const WCHAR strRegistrationRoot[] = L"Software\\Microsoft\\VisualStudio\\8.0Exp";
    IDebugProgramProvider2 *pProvider = NULL;
    if (pDebugEngineGuid != NULL) {
        CLSID clsidProvider = { 0 };
        ::GetMetric(NULL,
                    metrictypeEngine,
                    *pDebugEngineGuid,
                    metricProgramProvider,
                    &clsidProvider,
                    strRegistrationRoot);
        if (!IsEqualGUID(clsidProvider,GUID_NULL)) {
            CComPtr<IDebugProgramProvider2> spProgramProvider;
            spProgramProvider.CoCreateInstance(clsidProvider);
            if (spProgramProvider != NULL) {
                pProvider = spProgramProvider.Detach();
            }
        }
    }
    return(pProvider);
}
```

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProgramPublisher2](../../../extensibility/debugger/reference/idebugprogrampublisher2.md)
- [SDK Helpers for Debugging](../../../extensibility/debugger/reference/sdk-helpers-for-debugging.md)
