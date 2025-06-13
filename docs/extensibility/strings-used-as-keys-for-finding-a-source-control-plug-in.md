---
title: Strings used as keys to find a source control plug-in
description: Learn about the strings that are the keys for accessing the registry to find information about the Source Control plug-in.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- source control plug-ins, strings used for finding
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Strings Used as Keys for Finding a Source Control Plug-in

The following strings are the keys for accessing the registry to find information about the source control plug-in.

 `STR_SCC_PROVIDER_REG_LOCATION`, `STR_PROVIDERREGKEY`, `STR_SCCPROVIDERPATH`, and `STR_SCCPROVIDERNAME` are registry keys or values used to register a DLL as a source control plug-in for Visual Studio.

 `SCC_PROJECTNAME_KEY`, `SCC_PROJECTAUX_KEY`, `SCC_KEY, SCC_FILE_SIGNATURE`, and `SCC_STATUS_FILE` are used to describe the format of the MSSCCPRJ.SCC file.

## String Keys and Values

|Key|Value|
|---------|-----------|
|`STR_SCC_PROVIDER_REG_LOCATION`|Software\SourceCodeControlProvider|
|`STR_PROVIDERREGKEY`|ProviderRegKey|
|`STR_SCCPROVIDERPATH`|SCCServerPath|
|`STR_SCCPROVIDERNAME`|SCCServerName|
|`STR_SCC_INI_SECTION`|Source Code Control|
|`STR_SCC_INI_KEY`|SourceCodeControlProvider|
|`SCC_PROJECTNAME_KEY`|SCC_Project_Name|
|`SCC_PROJECTAUX_KEY`|SCC_Aux_Path|
|`SCC_STATUS_FILE`|MSSCCPRJ.SCC|
|`SCC_KEY`|SCC|
|`SCC_FILE_SIGNATURE`|A source code control file|
|`SCC_NSE`|Namespace extension|
|`SCC_NSE_PREFIX`|Protocol Prefix|
|`SCC_NSE_DisableOpenSCC`|DisableOpenFromSourceControl|
|`STR_SCCHELPCOLLECTION`|HelpCollection|
|`STR_UI_LANGUAGE`|UILanguage|
|`STR_SRCSAFE_ROOT_KEY`|Software\Microsoft\SourceSafe|

## See also
- [Source Control Plug-ins](../extensibility/source-control-plug-ins.md)
- [How to: Install a Source Control Plug-in](../extensibility/internals/how-to-install-a-source-control-plug-in.md)
- [MSSCCPRJ.SCC File](../extensibility/mssccprj-scc-file.md)
