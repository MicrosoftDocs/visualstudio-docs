---
description: "This method adds a program node for each debug engine (DE) specified."
title: IDebugProcessEx2::AddImplicitProgramNodes | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcessEx2::AddImplicitProgramNodes
helpviewer_keywords:
- IDebugProcessEx2::AddImplicitProgramNodes method
ms.assetid: 8b491b00-f9e7-45b3-9115-fe58c3464289
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugProcessEx2::AddImplicitProgramNodes
This method adds a program node for each debug engine (DE) specified.

## Syntax

```cpp
HRESULT AddImplicitProgramNodes(
   REFGUID guidLaunchingEngine,
   GUID*   rgguidSpecificEngines,
   DWORD   celtSpecificEngines
);
```

```csharp
int AddImplicitProgramNodes(
   ref Guid guidLaunchingEngine,
   Guid[]   rgguidSpecificEngines,
   uint     celtSpecificEngines
);
```

## Parameters
`guidLaunchingEngine`\
[in] The `GUID` of a DE that is to be used to launch programs (and is assumed to add its own program nodes).

`rgguidSpecificEngines`\
[in] Array of `GUID`s of DEs for which program nodes will be added.

`celtSpecificEngines`\
[in] The number of `GUID`s in the `rgguidSpecificEngines` array.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
- [Program Nodes](../../../extensibility/debugger/program-nodes.md) will be added for each DE listed in `rgguidSpecificEngines`—excluding the launching engine (as given in `guidLaunchingEngine`), which is assumed to add its own program node when it launches a program.

## See also
- [IDebugProgramEx2](../../../extensibility/debugger/reference/idebugprogramex2.md)
- [Program Nodes](../../../extensibility/debugger/program-nodes.md)
