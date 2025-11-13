---
title: What&apos;s new in the source control plug-in API 1.3
description: Learn about what's new in the Source Control Plug-in API version 1.3, which introduces the new functions to provide more advanced control.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- source control plug-ins, what's new in API v1.3
- what's new [Visual Studio SDK], source control plug-ins
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# What&#39;s New in the Source Control Plug-in API Version 1.3

The Source Control Plug-in API version 1.3 introduces the following new functions to provide more advanced control.

## Changes
 The following functions are new to the Source Control Plug-in API version 1.3:

|Function|Overview|
|--------------|--------------|
|[SccGetExtendedCapabilities](../../extensibility/sccgetextendedcapabilities-function.md)|Allows additional capability bits to be reported|
|[SccEnumChangedFiles](../../extensibility/sccenumchangedfiles-function.md)|Allows examination of files that have newer versions in the version control database than on the local disk|
|[SccQueryChanges](../../extensibility/sccquerychanges-function.md)|Allows examination of the state of name changes (renames, additions, and deletions) for specified files|
|[SccPopulateDirList](../../extensibility/sccpopulatedirlist-function.md)|Allows examination of directories and files in the version control database|
|[SccAddFilesFromSCC](../../extensibility/sccaddfilesfromscc-function.md)|Adds a specified list of files from the version control database to the current project|
|[SccBackgroundGet](../../extensibility/sccbackgroundget-function.md)|Performs a silent "Get" of the specified files (no user interface is shown)|
|[SccGetUserOption](../../extensibility/sccgetuseroption-function.md)|Allows access to user-specific options|

## Related content
- [Getting Started](../../extensibility/internals/getting-started-with-source-control-plug-ins.md)
- [What's New in the Source Control Plug-in API Version 1.2](/previous-versions/visualstudio/visual-studio-2017/extensibility/internals/what-s-new-in-the-source-control-plug-in-api-version-1-2)
