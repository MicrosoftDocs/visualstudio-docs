---
title: "Understanding Build Configurations | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "SolutionProperties.ActiveConfig"
  - "vs.build.newprojectconfiguration"
  - "vc.proj.configurationsctrl.multipleconfigs"
  - "vs.build.editsolutionconfigurations"
  - "vs.build.editprojectconfigurations"
  - "vs.multipleconfigurations"
  - "vs.build.newsolutionconfiguration"
  - "VS.ConfigurationManager"
  - "VS.MultipleConfig"
helpviewer_keywords: 
  - "solution build configurations, about build configurations"
  - "build configurations"
  - "project build configurations"
  - "build configurations, advanced"
  - "projects [Visual Studio], build configuration"
  - "solutions [Visual Studio], build configuration"
ms.assetid: 934c727d-3a22-429c-bd13-3552cecf2e24
caps.latest.revision: 21
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
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
# Understanding Build Configurations
You can store different configurations of solution and project properties to use in different kinds of builds. To create, select, modify, or delete a configuration, you can use the **Configuration Manager**. To open it, on the menu bar, choose **Build**, **Configuration Manager**, or just type **Configuration** in the **Quick Launch** box. You can also use the **Solution Configurations** list on the **Standard** toolbar to select a configuration or open the **Configuration Manager**.  
  
> [!NOTE]
>  If you can't find solution configuration settings on the toolbar and can't access the **Configuration Manager**, [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] development settings may be applied. For more information, see [How to: Manage Configurations with Visual Basic Developer Settings Applied](../ide/how-to-manage-build-configurations-with-visual-basic-developer-settings-applied.md).  
  
 By default, Debug and Release configurations are included in projects that are created by using [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] templates. A Debug configuration supports the debugging of an app, and a Release configuration builds a version of the app that can be deployed. For more information, see [How to: Set Debug and Release Configurations](../debugger/how-to-set-debug-and-release-configurations.md). You can also create custom solution configurations and project configurations. For more information, see [How to: Create and Edit Configurations](../ide/how-to-create-and-edit-configurations.md).  
  
## Solution Configurations  
 A solution configuration specifies how projects in the solution are to be built and deployed. To modify a solution configuration or define a new one, in the **Configuration Manager**, under **Active solution configuration**, choose **Edit** or **New**.  
  
 Each entry in the **Project contexts** box in a solution configuration represents a project in the solution. For every combination of **Active solution configuration** and **Active solution platform**, you can set how each project is used. (For more information about solution platforms, see [Understanding Build Platforms](../ide/understanding-build-platforms.md).)  
  
> [!NOTE]
>  When you define a new solution configuration and select the **Create new project configurations** check box, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] automatically assigns the new configuration to all of the projects. Likewise, when you define a new solution platform and select the **Create new project platforms** check box, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] automatically assigns the new platform to all of the projects. Also, if you add a project that targets a new platform, Visual Studio adds that platform to the list of solution platforms and assigns it to all of the projects.  
>   
>  You can still modify the settings for each project.  
  
 The active solution configuration also provides context to the IDE. For example, if you're working on a project and the configuration specifies that it will be built for a mobile device, the **Toolbox** displays only items that can be used in a mobile device project.  
  
## Project Configurations  
 The configuration and platform that a project targets are used together to specify the properties to use when it's built. A project can have a different set of property definitions for each combination of configuration and platform. To modify the properties of a project, you can use its Property Pages. (In **Solution Explorer**, open the shortcut menu for the project and then choose **Properties**.)  
  
 For each project configuration, you can define configuration-dependent properties as needed. For example, for a particular build, you can set which project items will be included, and what output files will be created, where they will be put, and how they will be optimized.  
  
 Project configurations can differ considerably. For example, the properties of one configuration might specify that its output file be optimized to occupy the minimum space, while another configuration might specify that its executable runs at the maximum speed.  
  
 Project configurations are stored by solution—not by user—so that they can be shared by a team.  
  
 Although project dependencies are configuration-independent, only the projects that are specified in the active solution configuration will be built.  
  
## How Visual Studio Assigns Project Configurations  
 When you define a new solution configuration and don't copy settings from an existing one, Visual Studio uses the following criteria to assign default project configurations. The criteria are evaluated in the order shown.  
  
1.  If a project has a configuration name (*\<configuration name> \<platform name>*) that exactly matches the name of the new solution configuration, that configuration is assigned. Configuration names are not case-sensitive.  
  
2.  If the project has a configuration name in which the configuration-name part matches the new solution configuration, that configuration is assigned, whether the platform portion matches or not.  
  
3.  If there is still no match, the first configuration that's listed in the project is assigned.  
  
## How Visual Studio Assigns Solution Configurations  
 When you create a project configuration (in the **Configuration Manager**, by choosing **New** on the drop-down menu in the **Configuration** column for that project) and select the **Create new solution configurations** check box, Visual Studio looks for a like-named solution configuration to build the project on each platform it supports. In some cases, Visual Studio renames existing solution configurations or defines new ones.  
  
 Visual Studio uses the following criteria to assign solution configurations.  
  
-   If a project configuration doesn't specify a platform or specifies just one platform, then a solution configuration whose name matches that of the new project configuration is either found or added. The default name of this solution configuration does not include a platform name; it takes the form *\<project configuration name>*.  
  
-   If a project supports multiple platforms, a solution configuration is either found or added for each supported platform. The name of each solution configuration includes both the project configuration name and the platform name, and has the form *\<project configuration name> \<platform name>*.  
  
## See Also  
 [Walkthrough: Building an Application](../ide/walkthrough-building-an-application.md)   
 [Compiling and Building](../ide/compiling-and-building-in-visual-studio.md)   
 [Solutions and Projects](../ide/solutions-and-projects-in-visual-studio.md)   
 [C/C++ Building Reference](/cpp/build/reference/c-cpp-building-reference)   
 [Devenv Command Line Switches](../ide/reference/devenv-command-line-switches.md)