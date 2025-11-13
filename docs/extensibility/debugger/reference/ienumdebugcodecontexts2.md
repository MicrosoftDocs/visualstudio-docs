---
description: "This interface enumerates the code contexts associated with the debug session, or with a particular program or document."
title: IEnumDebugCodeContexts2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugCodeContexts2
helpviewer_keywords:
- IEnumDebugCodeContexts2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEnumDebugCodeContexts2

This interface enumerates the code contexts associated with the debug session, or with a particular program or document.

## Syntax

```
IEnumDebugCodeContexts2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface to represent a list of code contexts for a particular text position in a program, or a list of code contexts for a particular document context.

## Notes for Callers
 Call [EnumCodeContexts](../../../extensibility/debugger/reference/idebugprogram2-enumcodecontexts.md) to obtain this interface representing a list of code contexts for a specific text position in a program's source document.

 Call [EnumCodeContexts](../../../extensibility/debugger/reference/idebugdocumentcontext2-enumcodecontexts.md) to obtain this interface representing a list of all code contexts in a particular source document.

## Methods in Vtable Order
 The following table shows the methods of `IEnumDebugCodeContexts2`.

|Method|Description|
|------------|-----------------|
|[Next](../../../extensibility/debugger/reference/ienumdebugcodecontexts2-next.md)|Retrieves a specified number of code contexts in an enumeration sequence.|
|[Skip](../../../extensibility/debugger/reference/ienumdebugcodecontexts2-skip.md)|Skips a specified number of code contexts in an enumeration sequence.|
|[Reset](../../../extensibility/debugger/reference/ienumdebugcodecontexts2-reset.md)|Resets an enumeration sequence to the beginning.|
|[Clone](../../../extensibility/debugger/reference/ienumdebugcodecontexts2-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|
|[GetCount](../../../extensibility/debugger/reference/ienumdebugcodecontexts2-getcount.md)|Gets the number of code contexts in an enumerator.|

## Remarks
 Visual Studio calls [EnumCodeContexts](../../../extensibility/debugger/reference/idebugprogram2-enumcodecontexts.md) to populate a list of code contexts the user can choose from when setting the next statement or showing the disassembly for a source file. Multiple code contexts can occur, for example, when there are multiple instances of a C++-style template.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [EnumCodeContexts](../../../extensibility/debugger/reference/idebugprogram2-enumcodecontexts.md)
- [EnumCodeContexts](../../../extensibility/debugger/reference/idebugdocumentcontext2-enumcodecontexts.md)
