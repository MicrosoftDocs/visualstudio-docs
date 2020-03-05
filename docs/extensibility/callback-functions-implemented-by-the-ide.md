---
title: "Callback Functions Implemented by the IDE | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "source control plug-ins, callback functions"
  - "callback functions, source control plug-ins"
ms.assetid: 4a8833f0-6ac0-4ea7-9400-8275aa991468
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Callback functions implemented by the IDE
To make integration with the integrated development environment (IDE) as seamless as possible and to provide a unified end-user experience, the source control plug-in can use callback functions that are implemented by the IDE. The plug-in can call these functions at appropriate times during a source control operation to pass information to the IDE; the IDE can then display this information as embedded elements in its native UI. The user has a less fragmented experience in this scenario than if the plug-in employed its own UI.

 The required header file is *scc.h*. The default location is *\Program Files\VSIP 8.0\EnvSDK\common\inc\\*. It is also in the VSIP folder that has the source control plug-in sample at *\Program Files\VSIP 8.0\MSSCCI\\*.

## In this section
- [LPTEXTOUTPROC](../extensibility/lptextoutproc.md)
 Describes the callback function that is used by [SccOpenProject](../extensibility/sccopenproject-function.md) to display messages from the source control plug-in through the IDE.

- [POPLISTFUNC](../extensibility/poplistfunc.md)
 Describes the callback function that is used by [SccPopulateList](../extensibility/sccpopulatelist-function.md) when the IDE does not have complete access to information that is available only to the source control plug-in, such as a complete list of files under version control.

- [QUERYCHANGESFUNC](../extensibility/querychangesfunc.md)
 Describes the callback function that is used by the [SccQueryChanges](../extensibility/sccquerychanges-function.md) operation.

- [POPDIRLISTFUNC](../extensibility/popdirlistfunc.md)
 Describes the callback function that is used by the [SccPopulateDirList](../extensibility/sccpopulatedirlist-function.md) operation.

- [OPTNAMECHANGEPFN](../extensibility/optnamechangepfn.md)
 Describes the callback function set by a call to the [SccSetOption](../extensibility/sccsetoption-function.md) that enables the source control plug-in to communicate name changes back to the IDE.

## Related sections
- [SccOpenProject](../extensibility/sccopenproject-function.md)
 Opens a project.

- [SccPopulateList](../extensibility/sccpopulatelist-function.md)
 Examines the list of files for their current status. In addition, uses the `pfnPopulate` function to notify the caller when a file does not match the criteria for the `nCommand`.

- [SccPopulateDirList](../extensibility/sccpopulatedirlist-function.md)
 Examines a list of directories and files in a project or projects that are under source control. Each directory and file name found is passed to a callback function.

- [SccQueryChanges](../extensibility/sccquerychanges-function.md)
 Examines name changes that were made to a list of files. Each file name is passed to a callback function together with its change status.

- [SccSetOption](../extensibility/sccsetoption-function.md)
 Sets a wide variety of options. Each option starts with `SCC_OPT_xxx` and has its own defined set of values.

- [Source Control Plug-ins](../extensibility/source-control-plug-ins.md)
 Describes the contents of the reference section of the Source Control Plug-in SDK.