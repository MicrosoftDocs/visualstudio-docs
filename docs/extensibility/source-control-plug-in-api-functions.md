---
title: Source Control Plug-in API Functions
description: Learn about the functions that the Source Control Plug-in API provides, which must be implemented by the source control plug-in.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- source control plug-ins, functions
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Source Control Plug-in API Functions

The Source Control Plug-in API provides the following functions, which must be implemented by the source control plug-in in accordance with this API. The signatures of each function and the semantics associated with the bit flags and other parameters are described in detail in this reference.

## Initialization and Housekeeping Functions

|Function|Description|
|--------------|-----------------|
|[SccCloseProject](../extensibility/scccloseproject-function.md)|Closes a project.|
|[SccGetCommandOptions](../extensibility/sccgetcommandoptions-function.md)|Prompts the user for advanced options for the given command.|
|[SccGetVersion](../extensibility/sccgetversion-function.md)|Returns the version of the source control plug-in.|
|[SccInitialize](../extensibility/sccinitialize-function.md)|Initializes the source control plug-in. It is called once for each instance of the plug-in.|
|[SccOpenProject](../extensibility/sccopenproject-function.md)|Opens a project.|
|[SccSetOption](../extensibility/sccsetoption-function.md)|A generic function used to set a wide variety of options. Each option starts with `SCC_OPT_xxx` and has its own defined set of values.|
|[SccUninitialize](../extensibility/sccuninitialize-function.md)|Called once when a source control plug-in needs to be unplugged.|

## Core Source Control Functions

|Function|Description|
|--------------|-----------------|
|[SccAdd](../extensibility/sccadd-function.md)|Adds an array of files specified by fully qualified path names to the source control system.|
|[SccAddFromScc](../extensibility/sccaddfromscc-function.md)|Allows the user to browse for files that are already in the source control system and then make those files part of the current project.|
|[SccCheckin](../extensibility/scccheckin-function.md)|Checks in an array of files.|
|[SccCheckout](../extensibility/scccheckout-function.md)|Checks out an array of files.|
|[SccDiff](../extensibility/sccdiff-function.md)|Shows the differences between the local user's file specified by a fully qualified path name and the version under source control.|
|[SccGet](../extensibility/sccget-function.md)|Retrieves a read-only copy of a set of files.|
|[SccGetEvents](../extensibility/sccgetevents-function.md)|Checks the status of files that the caller has asked about (via `SccQueryInfo`).|
|[SccGetProjPath](../extensibility/sccgetprojpath-function.md)|Causes the source control plug-in to prompt the user for a project path that is meaningful to the plug-in.|
|[SccHistory](../extensibility/scchistory-function.md)|Shows the history for an array of fully qualified local file names.|
|[SccPopulateList](../extensibility/sccpopulatelist-function.md)|Examines the list of files for their current status. In addition, uses the `pfnPopulate` function to notify the caller when a file does not match the criteria for the `nCommand`.|
|[SccProperties](../extensibility/sccproperties-function.md)|Shows the properties of a fully qualified file.|
|[SccQueryInfo](../extensibility/sccqueryinfo-function.md)|Examines a list of fully qualified files for their current status.|
|[SccRemove](../extensibility/sccremove-function.md)|Removes the array of fully qualified files from the source control system.|
|[SccRename](../extensibility/sccrename-function.md)|Renames the given file to a new name in the source control system.|
|[SccRunScc](../extensibility/sccrunscc-function.md)|Accesses the full range of features of the source control system.|
|[SccUncheckout](../extensibility/sccuncheckout-function.md)|Undoes a checkout of an array of files.|

## Functions that Support Additional Capability (Version 1.2 of the Source Control Plug-in API)
 This group of functions defines the additional functionality included in version 1.2 of the Source Control Plug-in API. They provide access to more advanced source control features and capabilities.

|Function|Description|
|--------------|-----------------|
|[SccBeginBatch](../extensibility/sccbeginbatch-function.md)|Starts a batch operation.|
|[SccCreateSubProject](../extensibility/scccreatesubproject-function.md)|Creates a subproject with the given name under an existing parent project.|
|[SccDirDiff](../extensibility/sccdirdiff-function.md)|Shows the differences between the local user's directory specified by a fully qualified path name and the source control database location.|
|[SccDirQueryInfo](../extensibility/sccdirqueryinfo-function.md)|Examines a list of fully qualified directories for their current status.|
|[SccEndBatch](../extensibility/sccendbatch-function.md)|Ends a batch operation.|
|[SccGetParentProjectPath](../extensibility/sccgetparentprojectpath-function.md)|Returns parent path of the given project (the project must exist).|
|[SccIsMultiCheckoutEnabled](../extensibility/sccismulticheckoutenabled-function.md)|Checks whether multiple checkouts on a file are allowed.|
|[SccWillCreateSccFile](../extensibility/sccwillcreatesccfile-function.md)|Checks whether the plug-in will create MSSCCPRJ.SCC files.|

## Functions that Support Advanced Capability (Version 1.3 of the Source Control Plug-in API)
 This group of functions defines the additional functionality included in version 1.3 of the Source Control Plug-in API. They provide access to more advanced source control features and capabilities.

|Function|Description|
|--------------|-----------------|
|[SccAddFilesFromSCC](../extensibility/sccaddfilesfromscc-function.md)|Adds a list of files from source control to the current project.|
|[SccBackgroundGet](../extensibility/sccbackgroundget-function.md)|Retrieves a list of files from source control without a user interface.|
|[SccEnumChangedFiles](../extensibility/sccenumchangedfiles-function.md)|Retrieves a list of files in source control that are different from the local files.|
|[SccGetExtendedCapabilities](../extensibility/sccgetextendedcapabilities-function.md)|Retrieves flags that specify extended capabilities supported by the source control plug-in.|
|[SccGetUserOption](../extensibility/sccgetuseroption-function.md)|Retrieves user-specific options.|
|[SccPopulateDirList](../extensibility/sccpopulatedirlist-function.md)|Examines a list of directories and files in a project or projects that are under source control. Each directory and file name found is passed to a callback function.|
|[SccQueryChanges](../extensibility/sccquerychanges-function.md)|Examines name changes made to a list of files. Each file name is passed to a callback function with its change status.|

## Requirements
 Header: scc.h

 (Supplied in the Environment SDK common includes folder, by default *[drive]*\Program Files\VSIP 8.0\EnvSDK\common\inc; also supplied in the VSIP folder with the MSSCCI sample, *[drive]*\Program Files\VSIP 8.0\MSSCCI).

## See also
- [Source Control Plug-ins](../extensibility/source-control-plug-ins.md)
- [Creating a Source Control Plug-in](../extensibility/internals/creating-a-source-control-plug-in.md)
