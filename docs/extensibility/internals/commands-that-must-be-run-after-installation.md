---
title: Commands That Must Be Run After Installation
description: Learn about the commands that must be run as part of your installation of an extension deployed through a .msi file in Visual Studio. 
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- post-install commands
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Commands that must be run after installation

If you deploy your extension through a *.msi* file, you must run **devenv /setup** as part of your installation in order for Visual Studio to discover your extensions.

> [!NOTE]
> The information in this topic applies to finding *devenv.exe* with Visual Studio 2008 and earlier. For information about how to discover *devenv.exe* with later versions of Visual Studio, see [Detect system requirements](../../extensibility/internals/detecting-system-requirements.md).

## Find devenv.exe
 You can locate each version's *devenv.exe* from registry values that Visual Studio installers write, using the RegLocator table and AppSearch tables to store the registry values as properties. For more information, see [Detect system requirements](../../extensibility/internals/detecting-system-requirements.md).

### RegLocator table rows to locate devenv.exe from different versions of Visual Studio

|Signature|Root|Key|Name|Type|
|-----------------|----------|---------|----------|----------|
|RL_DevenvExe_2002|2|SOFTWARE\Microsoft\VisualStudio\7.0\Setup\VS|EnvironmentPath|2|
|RL_DevenvExe_2003|2|SOFTWARE\Microsoft\VisualStudio\7.1\Setup\VS|EnvironmentPath|2|
|RL_DevenvExe_2005|2|SOFTWARE\Microsoft\VisualStudio\8.0\Setup\VS|EnvironmentPath|2|
|RL_DevenvExe_2008|2|SOFTWARE\Microsoft\VisualStudio\9.0\Setup\VS|EnvironmentPath|2|

### AppSearch table rows for corresponding RegLocator table rows

|Property|Signature|
|--------------|-----------------|
|DEVENV_EXE_2002|RL_DevenvExe_2002|
|DEVENV_EXE_2003|RL_DevenvExe_2003|
|DEVENV_EXE_2005|RL_DevenvExe_2005|
|DEVENV_EXE_2008|RL_DevenvExe_2008|

 For example, the Visual Studio installer writes the registry value of **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0\Setup\VS\EnvironmentPath** as *C:\VS2008\Common7\IDE\devenv.exe*, a complete path to the executable the installer must run.

> [!NOTE]
> Because the RegLocator table's Type column is 2, it is not necessary to specify additional version information in the Signature table.

## Run devenv.exe
 After the AppSearch standard action runs in the installer, each property in the AppSearch table has a value pointing to the *devenv.exe* file for the corresponding version of Visual Studio. If any of the specified registry values are not present — because that version of Visual Studio is not installed — the specified property is set to null.

 Windows Installer supports running an executable to which a property points through custom action type 50. The custom action should include the in-script execution options, `msidbCustomActionTypeInScript` (1024) and `msidbCustomActionTypeCommit` (512), to ensure that the VSPackage has been successfully installed before integrating it into Visual Studio. For more information, see [CustomAction table](/windows/desktop/msi/customaction-table) and [Custom action in-script execution options](/windows/desktop/msi/custom-action-in-script-execution-options).

 Custom actions of type 50 specify the property containing the executable as the value of the Source column and command-line arguments in the Target column.

### CustomAction table rows to run devenv.exe

|Action|Type|Source|Target|
|------------|----------|------------|------------|
|CA_RunDevenv2002|1586|DEVENV_EXE_2002|/setup|
|CA_RunDevenv2003|1586|DEVENV_EXE_2003|/setup|
|CA_RunDevenv2005|1586|DEVENV_EXE_2005|/setup|
|CA_RunDevenv2008|1586|DEVENV_EXE_2008|/setup|

 Custom actions must be authored into the InstallExecuteSequence table to schedule them for execution during the installation. Use the corresponding property in each row of the Condition column to prevent the custom action from being run if that version of Visual Studio is not installed on the system.

> [!NOTE]
> Null-valued properties evaluate to `False` when used in conditions.

 The value of the Sequence column for each custom action depends on other sequence values in your Windows Installer package. Sequence values should be such that the *devenv.exe* custom actions run as close as possible to immediately prior to the InstallFinalize standard action.

### InstallExecuteSequence table to schedule the devenv.exe custom actions

|Action|Condition|Sequence|
|------------|---------------|--------------|
|CA_RunDevenv2002|DEVENV_EXE_2002|6602|
|CA_RunDevenv2003|DEVENV_EXE_2003|6603|
|CA_RunDevenv2005|DEVENV_EXE_2005|6605|
|CA_RunDevenv2008|DEVENV_EXE_2008|6608|

## Related content
- [Install VSPackages with Windows Installer](../../extensibility/internals/installing-vspackages-with-windows-installer.md)
