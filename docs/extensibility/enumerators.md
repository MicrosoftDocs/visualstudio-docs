---
title: Enumerators
description: Learn about the enumerator data types in the Source Control Plug-in API including Command code, Message, File status code, and Directory status code.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- source control plug-ins, enumerators
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Enumerators

This section lists the enumerator data types in the Source Control Plug-in API that the source control plug-in must know about.

## In this section

- [Command code](../extensibility/command-code-enumerator.md) enumerates the options for the [SccGetCommandOptions](../extensibility/sccgetcommandoptions-function.md) and [SccPopulateList](../extensibility/sccpopulatelist-function.md) functions.

- [Message](../extensibility/message-enumerator.md) enumerates flags used for the print callback, [LPTEXTOUTPROC](../extensibility/lptextoutproc.md).

- [File status code](../extensibility/file-status-code-enumerator.md) contains named constant values that specify the state of a file under source control.

- [Directory status code](../extensibility/directory-status-code-enumerator.md) contains named constant values that specify the state of a directory under source control.

## Related sections

- [Create a source control plug-in](../extensibility/internals/creating-a-source-control-plug-in.md) defines the Source Control Plug-in SDK and describes the included resources.

- [SccGetCommandOptions](../extensibility/sccgetcommandoptions-function.md) prompts the user for advanced options for the given command.

- [SccPopulateList](../extensibility/sccpopulatelist-function.md) examines the list of files for their current status. In addition, uses the `pfnPopulate` function to notify the caller when a file does not match the criteria for the `nCommand`.

- [LPTEXTOUTPROC](../extensibility/lptextoutproc.md) describes the callback function that is used by [SccOpenProject](../extensibility/sccopenproject-function.md) to display messages from the source control plug-in through the IDE.

- [Source control plug-ins](../extensibility/source-control-plug-ins.md) provides a complete listing of all the elements in the Source Control Plug-in API.
