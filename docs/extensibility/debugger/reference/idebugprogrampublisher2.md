---
description: "This interface allows a debug engine (DE) or custom port suppliers to register programs for debugging."
title: IDebugProgramPublisher2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramPublisher2
helpviewer_keywords:
- IDebugProgramPublisher2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProgramPublisher2

This interface allows a debug engine (DE) or custom port suppliers to register programs for debugging.

## Syntax

```
IDebugProgramPublisher2 : IUnknown
```

## Notes for Implementers
Visual Studio implements this interface to register programs being debugged in order to make them visible for debugging across multiple processes.

## Notes for Callers
Call COM's `CoCreateInstance` function with `CLSID_ProgramPublisher` to obtain this interface (see the Example). A DE or a custom port supplier uses this interface to register program nodes that represent programs being debugged.

## Methods in Vtable order
This interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[PublishProgramNode](../../../extensibility/debugger/reference/idebugprogrampublisher2-publishprogramnode.md)|Makes a program node available to DEs and the session debug manager (SDM).|
|[UnpublishProgramNode](../../../extensibility/debugger/reference/idebugprogrampublisher2-unpublishprogramnode.md)|Removes a program node so that it is no longer available.|
|[PublishProgram](../../../extensibility/debugger/reference/idebugprogrampublisher2-publishprogram.md)|Makes a program available to DEs and the SDM.|
|[UnpublishProgram](../../../extensibility/debugger/reference/idebugprogrampublisher2-unpublishprogram.md)|Removes a program so it is no longer available.|
|[SetDebuggerPresent](../../../extensibility/debugger/reference/idebugprogrampublisher2-setdebuggerpresent.md)|Sets a flag indicating that a debugger is present.|

## Remarks
This interface makes programs and program nodes available (that is, "publishes" them) for use by DEs and the session debug manager (SDM). To access published programs and program nodes, use the [IDebugProgramProvider2](../../../extensibility/debugger/reference/idebugprogramprovider2.md) interface. This is the only way Visual Studio can recognize that a program is being debugged.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## Example
This example shows how to instantiate the program publisher and register a program node. This is taken from the Tutorial, [Publishing the Program Node](/previous-versions/bb161795(v=vs.90)).

```cpp
// This is how m_srpProgramPublisher is defined in the class definition:
// CComPtr<IDebugProgramPublisher2> m_srpProgramPublisher.

void CProgram::Start(IDebugEngine2 * pEngine)
{
    m_spEngine = pEngine;

    HRESULT hr = m_srpProgramPublisher.CoCreateInstance(CLSID_ProgramPublisher);
    if ( FAILED(hr) )
    {
        ATLTRACE("Failed to create the program publisher: 0x%x.", hr);
        return;
    }

    // Register ourselves with the program publisher. Note that
    // CProgram implements the IDebgProgramNode2 interface, hence
    // the static cast on "this".
    hr = m_srpProgramPublisher->PublishProgramNode(
        static_cast<IDebugProgramNode2*>(this));
    if ( FAILED(hr) )
    {
        ATLTRACE("Failed to publish the program node: 0x%x.", hr);
        m_srpProgramPublisher.Release();
        return;
    }

    ATLTRACE("Added program node.\n");
}
```

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProgramProvider2](../../../extensibility/debugger/reference/idebugprogramprovider2.md)
