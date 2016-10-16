---
title: "How to: Configure Projects to Target Multiple Platforms"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "projects [Visual Studio], targeting platforms"
  - "platforms, changing target platforms"
ms.assetid: affa2392-7aed-45ac-9ffa-1d8e0496d590
caps.latest.revision: 9
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
# How to: Configure Projects to Target Multiple Platforms
[!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] provides a way for a solution to target several different CPU architectures, or platforms, at once. The properties to set these are accessed through the **Configuration Manager** dialog box.  
  
## Targeting a Platform  
 The **Configuration Manager** dialog box allows you to create and set solution-level and project-level configurations and platforms. Each combination of solution-level configurations and targets can have a unique set of properties associated with it, allowing you to easily switch between, for example, a Release configuration that targets an [!INCLUDE[vcprx64](../extensibility/includes/vcprx64_md.md)] platform, a Release configuration that targets an x86 platform, and a Debug configuration that targets an x86 platform.  
  
#### To set your configuration to target a different platform  
  
1.  On the **Build** menu, click **Configuration Manager**.  
  
2.  In the **Active solution platform box**, select the platform you want your solution to target, or select **\<New>** to create a new platform. [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] will compile your application to target the platform that is set as the active platform in the **Configuration Manager** dialog box.  
  
## Removing a Platform  
 If you realize that you have no need for a platform, you can remove it using the Configuration Manager dialog box. This will remove all solution and project settings that you configured for that combination of configuration and target.  
  
#### To remove a platform  
  
1.  On the **Build** menu, click **Configuration Manager**.  
  
2.  In the **Active solution platform box**, select **\<Edit>**. The **Edit Solution Platforms** dialog box opens.  
  
3.  Click the platform you want to remove, and click **Remove**.  
  
## Targeting Multiple Platforms with One Solution  
 Because you can change the settings based on the combination of configuration and platform settings, you can set up a solution that can target more than one platform.  
  
#### To target multiple platforms  
  
1.  Use the **Configuration Manager** to add at least two target platforms for the solution.  
  
2.  Select the platform you want to target from the **Active solution platform** list.  
  
3.  Build the solution.  
  
#### To build multiple solution configurations at once  
  
1.  Use the **Configuration Manager** to add at least two target platforms for the solution.  
  
2.  Use the **Batch Build** window to build several solution configurations at once.  
  
 It is possible to have a solution-level platform set to, for example, [!INCLUDE[vcprx64](../extensibility/includes/vcprx64_md.md)], and have no projects within that solution targeting the same platform. It is also possible to have multiple projects in your solution, each targeting different platforms. It is recommended that if you have one of these situations, you create a new configuration with a descriptive name to avoid confusion.  
  
## See Also  
 [How to: Create and Edit Configurations](../ide/how-to--create-and-edit-configurations.md)   
 [Understanding Build Configurations](../ide/understanding-build-configurations.md)   
 [Building and Cleaning Projects and Solutions in Visual Studio](../ide/building-and-cleaning-projects-and-solutions-in-visual-studio.md)