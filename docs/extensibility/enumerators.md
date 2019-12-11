---
title: "Enumerators | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "source control plug-ins, enumerators"
ms.assetid: a60030c5-e1d1-47e1-84bb-cbfe838ab479
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Enumerators
This section lists the enumerator data types in the Source Control Plug-in API that the source control plug-in must know about.

## In this section
- [Command code](../extensibility/command-code-enumerator.md)
 Enumerates the options for the [SccGetCommandOptions](../extensibility/sccgetcommandoptions-function.md) and [SccPopulateList](../extensibility/sccpopulatelist-function.md) functions.

- [Message](../extensibility/message-enumerator.md)
 Enumerates flags used for the print callback, [LPTEXTOUTPROC](../extensibility/lptextoutproc.md).

- [File status code](../extensibility/file-status-code-enumerator.md)
 Contains named constant values that specify the state of a file under source control.

- [Directory status code](../extensibility/directory-status-code-enumerator.md)
 Contains named constant values that specify the state of a directory under source control.

## Related sections
- [Create a source control plug-in](../extensibility/internals/creating-a-source-control-plug-in.md)
 Defines the Source Control Plug-in SDK and describes the included resources.

- [SccGetCommandOptions](../extensibility/sccgetcommandoptions-function.md)
 Prompts the user for advanced options for the given command.

- [SccPopulateList](../extensibility/sccpopulatelist-function.md)
 Examines the list of files for their current status. In addition, uses the `pfnPopulate` function to notify the caller when a file does not match the criteria for the `nCommand`.

- [LPTEXTOUTPROC](../extensibility/lptextoutproc.md)
 Describes the callback function that is used by [SccOpenProject](../extensibility/sccopenproject-function.md) to display messages from the source control plug-in through the IDE.

- [Source control plug-ins](../extensibility/source-control-plug-ins.md)
 Provides a complete listing of all the elements in the Source Control Plug-in API.