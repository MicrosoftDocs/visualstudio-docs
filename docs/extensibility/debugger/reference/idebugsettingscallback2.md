---
description: "Enables debug engines to read metric settings remotely."
title: IDebugSettingsCallback2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugSettingsCallback2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugSettingsCallback2

Enables debug engines to read metric settings remotely.

## Syntax

```
IDebugSettingsCallback2 : IUnknown
```

## Notes for Implementers
This interface is implemented by the event callback of the session debug manager and consumed by debug engines. It could also be used locally instead of Dbgmetric[d].lib.

## Methods
The following table shows the methods of `IDebugSettingsCallback2`.

|Method|Description|
|------------|-----------------|
|[EnumEEs](../../../extensibility/debugger/reference/idebugsettingscallback2-enumees.md)|Enumerates the available expression evaluators given the language and vendor identifiers.|
|[GetEELocalObject](../../../extensibility/debugger/reference/idebugsettingscallback2-geteelocalobject.md)|Retrieves an expression evaluator local object given the metric.|
|[GetEEMetricDword](../../../extensibility/debugger/reference/idebugsettingscallback2-geteemetricdword.md)|Retrieves a value that corresponds to the specified metric of the expression evaluator.|
|[GetEEMetricFile](../../../extensibility/debugger/reference/idebugsettingscallback2-geteemetricfile.md)|Retrieves the expression evaluator metric file given the name or the metric.|
|[GetEEMetricGuid](../../../extensibility/debugger/reference/idebugsettingscallback2-geteemetricguid.md)|Retrieves the unique identifier for an expression evaluator metric given its name.|
|[GetEEMetricString](../../../extensibility/debugger/reference/idebugsettingscallback2-geteemetricstring.md)|Retrieves the value string of an expression evaluator metric given its name.|
|[GetMetricDword](../../../extensibility/debugger/reference/idebugsettingscallback2-getmetricdword.md)|Retrieves the value of a metric given its name.|
|[GetMetricGuid](../../../extensibility/debugger/reference/idebugsettingscallback2-getmetricguid.md)|Retrieves the unique identifier of a metric given its name.|
|[GetMetricString](../../../extensibility/debugger/reference/idebugsettingscallback2-getmetricstring.md)|Retrieves the value string of the metric given its name.|

## Requirements
Header: Msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## Example
The following example shows a function that takes an **IDebugSettingsCallback2** object as a parameter.

```cpp
HRESULT GetDebugSettingsCallback (IDebugSettingsCallback2 **ppCallback)
{
    HRESULT hRes = E_FAIL;

    if ( ppCallback )
    {
        if ( EVAL(m_pdec) )
            hRes = m_pdec->QueryInterface(IID_IDebugSettingsCallback2, (void **)ppCallback);
        else
            hRes = E_FAIL;
    }
    else
        hRes = E_INVALIDARG;

    return ( hRes );
}
```
