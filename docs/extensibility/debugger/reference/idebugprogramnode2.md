---
description: "This interface represents a program that can be debugged."
title: IDebugProgramNode2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramNode2
helpviewer_keywords:
- IDebugProgramNode2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProgramNode2

This interface represents a program that can be debugged.

## Syntax

```
IDebugProgramNode2 : IUnknown
```

## Notes for Implementers
 A debug engine (DE) or a custom port supplier implements this interface to represent a program that can be debugged. This interface is typically implemented on the same object that implements the [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) interface. This interface is registered with Visual Studio by calling [PublishProgramNode](../../../extensibility/debugger/reference/idebugprogrampublisher2-publishprogramnode.md).

## Notes for Callers
 Call [GetProviderProgramNode](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprogramnode.md) to return this interface. A custom port supplier receives this interface through a call to [AddProgramNode](../../../extensibility/debugger/reference/idebugportnotify2-addprogramnode.md). A DE receives this interface through a call to [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md).

## Methods in Vtable Order
 The following table shows the methods of `IDebugProgramNode2`.

|Method|Description|
|------------|-----------------|
|[GetProgramName](../../../extensibility/debugger/reference/idebugprogramnode2-getprogramname.md)|Gets the name of a program.|
|[GetHostName](../../../extensibility/debugger/reference/idebugprogramnode2-gethostname.md)|Gets the name of the process hosting a program.|
|[GetHostPid](../../../extensibility/debugger/reference/idebugprogramnode2-gethostpid.md)|Gets the system process identifier for the process hosting a program.|
|[GetHostMachineName_V7](../../../extensibility/debugger/reference/idebugprogramnode2-gethostmachinename-v7.md)|DEPRECATED. DO NOT USE.|
|[Attach_V7](../../../extensibility/debugger/reference/idebugprogramnode2-attach-v7.md)|DEPRECATED. DO NOT USE. See the [IDebugProgramNodeAttach2](../../../extensibility/debugger/reference/idebugprogramnodeattach2.md) interface for an alternative approach.|
|[GetEngineInfo](../../../extensibility/debugger/reference/idebugprogramnode2-getengineinfo.md)|Gets the name and identifier of the DE running this program.|
|[DetachDebugger_V7](../../../extensibility/debugger/reference/idebugprogramnode2-detachdebugger-v7.md)|DEPRECATED. DO NOT USE.|

## Remarks
 The session debug manager (SDM) typically calls [GetProviderProgramNode](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprogramnode.md) to obtain this interface.

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProgramNodeAttach2](../../../extensibility/debugger/reference/idebugprogramnodeattach2.md)
- [AddProgramNode](../../../extensibility/debugger/reference/idebugportnotify2-addprogramnode.md)
- [RemoveProgramNode](../../../extensibility/debugger/reference/idebugportnotify2-removeprogramnode.md)
- [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md)
- [GetProviderProgramNode](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprogramnode.md)
- [PublishProgramNode](../../../extensibility/debugger/reference/idebugprogrampublisher2-publishprogramnode.md)
