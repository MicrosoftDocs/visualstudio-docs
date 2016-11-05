---
title: "Devenv Command-Line Switches for VSPackage Development | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
caps.latest.revision: 16
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Devenv Command-Line Switches for VSPackage Development
[!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] allows developers to automate tasks from the command line when executing devenv.exe, the file that starts the Visual Studio integrated development environment (IDE).  
  
 Tasks include:  
  
-   Deploying applications in predesigned configurations from outside the IDE.  
  
-   Automatically building projects using preset build settings or debug configurations.  
  
-   Loading the IDE in specific configurations, all from outside the IDE. In addition, you can customize the IDE upon launch.  
  
## Guidelines for Switches  
 [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] documentation describes the user-level devenv command line switches. For more information, see [Devenv Command Line Switches](../ide/reference/devenv-command-line-switches.md). Devenv also supports additional command-line switches that are useful with VSPackage development, deployment, and debugging.  
  
|Command-line switch|Description|  
|--------------------------|-----------------|  
|/safemode|Launches [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] in safe mode, loading only the default IDE and services. The /safemode switch prevents all third-party VSPackages from loading when [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] starts, thus ensuring stable execution.<br /><br /> This switch takes no arguments.|  
|/resetskippkgs|Clears all skip loading options that have been added by users who want to avoid loading problematic VSPackages, then starts [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. The presence of a SkipLoading tag disables the loading of a VSPackage. Clearing the tag re-enables the loading of the VSPackage.<br /><br /> This switch takes no arguments.|  
|/rootsuffix|Starts [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] by using an alternate location. The following command is run by the shortcut created by the [!INCLUDE[vsipsdk](../extensibility/includes/vsipsdk_md.md)] installer:<br /><br /> devenv /RootSuffix exp<br /><br /> In this case, exp identifies a location with a particular suffix, for example 10.0Exp rather than 10.0. The experimental instance allows you to debug a VSPackage separately from the instance of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] that you are using to write code.<br /><br /> This switch can take any string that identifies a location that you have created by using VSRegEx.exe. For more information, see [The Experimental Instance](../extensibility/the-experimental-instance.md).|  
|/splash|Shows the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] splash screen as usual and then shows a message box before showing the main IDE. The message box lets you study the splash screen, to check for a VSPackage product icon, for example.<br /><br /> This switch takes no arguments.|  
  
## See Also  
 [Adding Command-Line Switches](../extensibility/adding-command-line-switches.md)   
 [Devenv Command Line Switches](../ide/reference/devenv-command-line-switches.md)