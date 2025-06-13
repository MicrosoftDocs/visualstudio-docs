---
title: Command Code Enumerator
description: The Command code enumerator is used in options for SccGetCommandOptions and SccPopulateListto to indicate the command for which the options are specified.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- command code enumerator
- source control plug-ins, command code enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Command code enumerator

This enumerator is used in the options for the [SccGetCommandOptions](../extensibility/sccgetcommandoptions-function.md) and the [SccPopulateList](../extensibility/sccpopulatelist-function.md)to indicate the command for which the options are specified.

## Syntax

```
enum SCCCOMMAND {
   SCC_COMMAND_GET,
   SCC_COMMAND_CHECKOUT,
   SCC_COMMAND_CHECKIN,
   SCC_COMMAND_UNCHECKOUT,
   SCC_COMMAND_ADD,
   SCC_COMMAND_REMOVE,
   SCC_COMMAND_DIFF,
   SCC_COMMAND_HISTORY,
   SCC_COMMAND_RENAME,
   SCC_COMMAND_PROPERTIES,
   SCC_COMMAND_OPTIONS
};
```

## Members
SCC_COMMAND_GET
Corresponds to the [SccGet](../extensibility/sccget-function.md).

SCC_COMMAND_CHECKOUT
Corresponds to the [SccCheckout](../extensibility/scccheckout-function.md).

SCC_COMMAND_CHECKIN
Corresponds to the [SccCheckin](../extensibility/scccheckin-function.md).

SCC_COMMAND_UNCHECKOUT
Corresponds to the [SccUncheckout](../extensibility/sccuncheckout-function.md).

SCC_COMMAND_ADD
Corresponds to the [SccAdd](../extensibility/sccadd-function.md).

SCC_COMMAND_REMOVE
Corresponds to the [SccRemove](../extensibility/sccremove-function.md).

SCC_COMMAND_DIFF
Corresponds to the [SccDiff](../extensibility/sccdiff-function.md).

SCC_COMMAND_HISTORY
Corresponds to the [SccHistory](../extensibility/scchistory-function.md).

SCC_COMMAND_RENAME
Corresponds to the [SccRename](../extensibility/sccrename-function.md).

SCC_COMMAND_PROPERTIES
Corresponds to the [SccProperties](../extensibility/sccproperties-function.md).

SCC_COMMAND_OPTIONS
Corresponds to the [SccSetOption](../extensibility/sccsetoption-function.md).

## See also
- [Source control plug-ins](../extensibility/source-control-plug-ins.md)
- [SccGetCommandOptions](../extensibility/sccgetcommandoptions-function.md)
- [SccPopulateList](../extensibility/sccpopulatelist-function.md)
