---
title: "Commands That Must Be Run After Installation | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "post-install commands"
ms.assetid: c9601f2e-2c6e-4da9-9a6e-e707319b39e2
caps.latest.revision: 23
ms.author: gregvanl
manager: jillfra
---
# Commands That Must Be Run After Installation
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

If you deploy your extension through an .msi file, you must run `devenv /setup` as part of your installation in order for Visual Studio to discover your extensions.  
  
> [!NOTE]
> The information in this topic applies to finding DevEnv with Visual Studio 2008 and earlier. For information about how to discover DevEnv with later versions of Visual Studio, see [Detecting System Requirements](../../extensibility/internals/detecting-system-requirements.md).  
  
## Finding devenv.exe  
 You can locate each version's devenv.exe from registry values that [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] installers write, using the RegLocator Table and AppSearch Table to store the registry values as properties. For more information, see [Detecting System Requirements](../../extensibility/internals/detecting-system-requirements.md).  
  
### RegLocator table rows to locate devenv.exe from different versions of Visual Studio  
  
|Signature_|Root|Key|Name|Type|  
|-----------------|----------|---------|----------|----------|  
|RL_DevenvExe_2002|2|SOFTWARE\Microsoft\VisualStudio\7.0\Setup\VS|EnvironmentPath|2|  
|RL_DevenvExe_2003|2|SOFTWARE\Microsoft\VisualStudio\7.1\Setup\VS|EnvironmentPath|2|  
|RL_DevenvExe_2005|2|SOFTWARE\Microsoft\VisualStudio\8.0\Setup\VS|EnvironmentPath|2|  
|RL_DevenvExe_2008|2|SOFTWARE\Microsoft\VisualStudio\9.0\Setup\VS|EnvironmentPath|2|  
  
### AppSearch table rows for corresponding RegLocator table rows  
  
|Property|Signature_|  
|--------------|-----------------|  
|DEVENV_EXE_2002|RL_DevenvExe_2002|  
|DEVENV_EXE_2003|RL_DevenvExe_2003|  
|DEVENV_EXE_2005|RL_DevenvExe_2005|  
|DEVENV_EXE_2008|RL_DevenvExe_2008|  
  
 For example, the Visual Studio installer writes the registry value of **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0\Setup\VS\EnvironmentPath** as **C:\VS2008\Common7\IDE\devenv.exe**, a complete path to the executable the installer must run.  
  
 **Note** Because the RegLocator Type column is 2, it is not necessary to specify additional version information in the Signature Table.  
  
## Running devenv.exe  
 After the AppSearch standard action runs in the installer, each property in the AppSearch table has a value pointing to the devenv.exe file for the corresponding version of Visual Studio. If any of the specified registry values are not present — because that version of Visual Studio is not installed — the specified property is set to null.  
  
 Windows Installer supports running an executable to which a property points through custom action type 50. The custom action should include the in-script execution options, msidbCustomActionTypeInScript (1024) and msidbCustomActionTypeCommit (512), to ensure that the VSPackage has been successfully installed before integrating it into [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)]. For more information, see CustomAction Table and Custom Action In-Script Execution Options.  
  
 Custom actions of type 50 specify the property containing the executable as the value of the Source column and command-line arguments in the Target column.  
  
### CustomAction table rows to run devenv.exe  
  
|Action|Type|Source|Target|  
|------------|----------|------------|------------|  
|CA_RunDevenv2002|1586|DEVENV_EXE_2002|/setup|  
|CA_RunDevenv2003|1586|DEVENV_EXE_2003|/setup|  
|CA_RunDevenv2005|1586|DEVENV_EXE_2005|/setup|  
|CA_RunDevenv2008|1586|DEVENV_EXE_2008|/setup|  
  
 Custom actions must be authored into the InstallExecuteSequence table to schedule them for execution during the installation. Use the corresponding property in each row of the Condition column to prevent the custom action from being run if that version of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] is not installed on the system.  
  
> [!NOTE]
> `Null` properties evaluate to `False` when used in conditions.  
  
 The value of the Sequence column for each custom action depends on other sequence values in your Windows Installer package. Sequence values should be such that the devenv.exe custom actions run as close as possible to immediately prior to the InstallFinalize standard action.  
  
### InstallExecuteSequence table to schedule the devenv.exe custom actions  
  
|Action|Condition|Sequence|  
|------------|---------------|--------------|  
|CA_RunDevenv2002|DEVENV_EXE_2002|6602|  
|CA_RunDevenv2003|DEVENV_EXE_2003|6603|  
|CA_RunDevenv2005|DEVENV_EXE_2005|6605|  
|CA_RunDevenv2008|DEVENV_EXE_2008|6608|  
  
## See Also  
 [Installing VSPackages With Windows Installer](../../extensibility/internals/installing-vspackages-with-windows-installer.md)
