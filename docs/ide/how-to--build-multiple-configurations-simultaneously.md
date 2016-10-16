---
title: "How to: Build Multiple Configurations Simultaneously"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: ba830937-3317-4674-8cc2-c0cd565603c5
caps.latest.revision: 10
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
# How to: Build Multiple Configurations Simultaneously
You can build most types of projects with multiple, or even all, of their build configurations at the same time by using the **Batch Build** dialog box. However, you can't build the following types of projects in multiple build configurations at the same time:  
  
1.  [!INCLUDE[win8_appname_long](../codequality/includes/win8_appname_long_md.md)] apps built for Windows using JavaScript.  
  
2.  All Visual Basic projects.  
  
 For more information about build configurations, see [Understanding Build Configurations](../ide/understanding-build-configurations.md).  
  
### To build a project in multiple build configurations  
  
1.  On the menu bar, choose **Build**, **Batch Build**.  
  
2.  In the **Build** column, select the check boxes for the configurations in which you want to build a project.  
  
    > [!TIP]
    >  To edit or create a build configuration for a solution, choose **Build**, **Configuration Manager** on the menu bar to open the **Configuration Manager** dialog box. After you have edited a build configuration for a solution, choose the **Rebuild** button in the **Batch Build** dialog box to update all build configurations for the projects in the solution.  
  
3.  Choose the **Build** or **Rebuild** buttons to build the project with the configurations that you specified.  
  
## See Also  
 [How to: Create and Edit Configurations](../ide/how-to--create-and-edit-configurations.md)   
 [Understanding Build Configurations](../ide/understanding-build-configurations.md)   
 [Building Multiple Projects in Parallel](../reference/building-multiple-projects-in-parallel-with-msbuild.md)