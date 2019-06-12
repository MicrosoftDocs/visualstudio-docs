---
title: "Devenv Command-Line Switches for VSPackage Development | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "/setup command line switch"
  - "/resetskippkgs command line switch"
  - "/noVSIP command line switch"
  - "/rootsuffix command line switch"
  - "command-line switches"
  - "registry, Visual Studio SDK"
  - "command line, switches"
  - "Visual Studio SDK, command-line switches"
ms.assetid: d65d2c04-dd84-42b0-b956-555b11f5a645
caps.latest.revision: 17
ms.author: gregvanl
manager: jillfra
---
# Devenv Command-Line Switches for VSPackage Development
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

[!INCLUDE[vsprvs](../includes/vsprvs-md.md)] allows developers to automate tasks from the command line when executing devenv.exe, the file that starts the Visual Studio integrated development environment (IDE).  
  
 Tasks include:  
  
- Deploying applications in predesigned configurations from outside the IDE.  
  
- Automatically building projects using preset build settings or debug configurations.  
  
- Loading the IDE in specific configurations, all from outside the IDE. In addition, you can customize the IDE upon launch.  
  
## Guidelines for Switches  
 [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] documentation describes the user-level devenv command line switches. For more information, see [Devenv Command Line Switches](../ide/reference/devenv-command-line-switches.md). Devenv also supports additional command-line switches that are useful with VSPackage development, deployment, and debugging.  
  
|Command-line switch|Description|  
|--------------------------|-----------------|  
|/safemode|Launches [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] in safe mode, loading only the default IDE and services. The /safemode switch prevents all third-party VSPackages from loading when [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] starts, thus ensuring stable execution.<br /><br /> This switch takes no arguments.|  
|/resetskippkgs|Clears all skip loading options that have been added by users who want to avoid loading problematic VSPackages, then starts [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. The presence of a SkipLoading tag disables the loading of a VSPackage. Clearing the tag re-enables the loading of the VSPackage.<br /><br /> This switch takes no arguments.|  
|/rootsuffix|Starts [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] by using an alternate location. The following command is run by the shortcut created by the [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)] installer:<br /><br /> devenv /RootSuffix exp<br /><br /> In this case, exp identifies a location with a particular suffix, for example 10.0Exp rather than 10.0. The experimental instance allows you to debug a VSPackage separately from the instance of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] that you are using to write code.<br /><br /> This switch can take any string that identifies a location that you have created by using VSRegEx.exe. For more information, see [The Experimental Instance](../extensibility/the-experimental-instance.md).|  
|/splash|Shows the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] splash screen as usual and then shows a message box before showing the main IDE. The message box lets you study the splash screen, to check for a VSPackage product icon, for example.<br /><br /> This switch takes no arguments.|  
  
## See Also  
 [Adding Command-Line Switches](../extensibility/adding-command-line-switches.md)   
 [Devenv Command Line Switches](../ide/reference/devenv-command-line-switches.md)
