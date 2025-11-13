---
title: Managing Side-by-Side File Associations
description: If your VSPackage provides file associations, decide how to handle side-by-side installations in which a particular version of Visual Studio opens a file.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- verbs, setting default
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Manage side-by-side file associations

If your VSPackage provides file associations, you must decide how to handle side-by-side installations in which a particular version of Visual Studio should be invoked to open a file. Incompatible file formats compound the issue.

Users expect a new version of a product to be compatible with earlier versions, so that existing files can be loaded in a new version without losing data. Ideally, your VSPackage can both load and save the file formats of earlier versions. If that is not true, you should offer to upgrade the file format to the new version of your VSPackage. The downside to this approach is that the upgraded file cannot be opened in the earlier version.

To avoid this issue, you can change extensions when file formats become incompatible. For example, version 1 of your VSPackage could use the extension, *.mypkg10*, and version 2 could use the extension, *.mypkg20*. This difference identifies the VSPackage that opens a particular file. If you add newer VSPackages to the list of programs that are associated with an old extension, users can right-click the file and choose to open it in a newer VSPackage. At that point, your VSPackage can offer to upgrade the file to the new format or open the file and maintain compatibility with earlier versions of the VSPackage.

> [!NOTE]
> You can combine these approaches. For example, you can offer backward compatibility by loading an older file and offer to upgrade the file format when the user saves it.

## Face the Problem

If you want multiple side-by-side VSPackages to use the same extension, you must choose the version of Visual Studio that is associated with the extension. Here are two alternatives:

- Open the file in the latest version of Visual Studio installed on a user's computer.

   In this approach, your installer is responsible for determining the latest version of Visual Studio and including that in the registry entry written for the file association. In a Windows Installer package, you can include custom actions to set a property that indicates the latest version of Visual Studio.

  > [!NOTE]
  > In this context, "latest" means "latest supported version." These installer entries will not automatically detect a subsequent release of Visual Studio. Entries in [Detecting System Requirements](../extensibility/internals/detecting-system-requirements.md) and in [Commands That Must Be Run After Installation](../extensibility/internals/commands-that-must-be-run-after-installation.md) are similar to the ones presented here and are required to support additional versions of Visual Studio.

   The following rows in the CustomAction table set the DEVENV_EXE_LATEST property to be a property set by the AppSearch and RegLocator tables discussed in [Commands that must be run after installation](../extensibility/internals/commands-that-must-be-run-after-installation.md). Rows in the InstallExecuteSequence table schedule the custom actions early in the execute sequence. Values in the Condition column make the logic work:

  - Visual Studio .NET 2002 is the latest version if it is the only present version.

  - Visual Studio .NET 2003 is the latest version only if it is present and Visual Studio is not present.

  - Visual Studio is the latest version if it is the only present version.

    The net result is that DEVENV_EXE_LATEST contains the path of the latest version of devenv.exe.

  **CustomAction table rows that determine the latest version of Visual Studio**

  |Action|Type|Source|Target|
  |------------|----------|------------|------------|
  |CA_SetDevenvLatest_2002|51|DEVENV_EXE_LATEST|[DEVENV_EXE_2002]|
  |CA_SetDevenvLatest_2003|51|DEVENV_EXE_LATEST|[DEVENV_EXE_2003]|
  |CA_SetDevenvLatest_2005|51|DEVENV_EXE_LATEST|[DEVENV_EXE_2005]|

  **InstallExecuteSequence table rows that determine the latest version of Visual Studio**

  |Action|Condition|Sequence|
  |------------|---------------|--------------|
  |CA_SetDevenvLatest_2002|DEVENV_EXE_2002 AND NOT (DEVENV_EXE_2003 OR DEVENV_EXE_2005)|410|
  |CA_SetDevenvLatest_2003|DEVENV_EXE_2003 AND NOT DEVENV_EXE_2005|420|
  |CA_SetDevenvLatest_2005|DEVENV_EXE_2005|430|

   You can use the DEVENV_EXE_LATEST property in the Registry table of the Windows Installer package to write the **HKEY_CLASSES_ROOT*ProgId*ShellOpenCommand** key's default value, [DEVENV_EXE_LATEST] "%1"

- Run a shared launcher program that can make the best choice from available VSPackage versions.

   The developers of Visual Studio chose this approach to handle the complex requirements of the multiple formats of solutions and projects that result from many versions of Visual Studio. In this approach, you register a launcher program as the extension handler. The launcher examines the file and decides which version of Visual Studio and your VSPackage can handle that particular file. For example, if a user opens a file that was last saved by a particular version of your VSPackage, the launcher can start that VSPackage in the matching version of Visual Studio. In addition, a user could configure the launcher to always start the latest version. A launcher also could prompt a user to upgrade the format of the file. If the format of the file includes a version number, the launcher could inform a user if the file format is from a version that is later than one or more of the installed VSPackages.

   The launcher should be in a Windows Installer component that is shared with all versions of your VSPackage. This process makes sure that the latest version is always installed and is not removed until all versions of your VSPackage are uninstalled. In this way, the file associations and other registry entries of the launcher component are preserved even if one version of the VSPackage is uninstalled.

## Uninstall and file associations

Uninstalling a VSPackage that writes registry entries for file associations removes the file associations. Therefore, the extension has no associated programs. Windows Installer does not "recover" the registry entries that were added when the VSPackage was installed. Here are some ways to fix a user's file associations:

- Use a shared launcher component as previously described.

- Instruct the user to run a repair of the version of the VSPackage that the user wants to own the file association.

- Provide a separate executable program that rewrites the appropriate registry entries.

- Provide a configuration options page or dialog box that lets users choose file associations and reclaim lost associations. Instruct users to run it after uninstallation.

## Related content

- [Register file name extensions for side-by-side deployments](../extensibility/registering-file-name-extensions-for-side-by-side-deployments.md)
- [Register verbs for file name extensions](../extensibility/registering-verbs-for-file-name-extensions.md)
