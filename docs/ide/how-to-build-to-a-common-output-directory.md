---
title: "How to: Build to a Common Output Directory | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "output directory"
  - "builds [Visual Studio], common directory"
  - "common directory"
ms.assetid: 1fcc2c48-07cb-4c4f-9556-36945e7dfc4e
caps.latest.revision: 7
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
# How to: Build to a Common Output Directory
By default, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] builds each project in a solution in its own folder inside the solution. You can change the build output paths of your projects to force all outputs to be placed in the same folder.  
  
### To place all solution outputs in a common directory  
  
1.  Click on one project in the solution.  
  
2.  On the **Project** menu, click **Properties**.  
  
3.  Depending on the type of project, click on either the **Compile** tab or the **Build** tab, and set the **Output path** to a folder to use for all projects in the solution.  
  
4.  Repeat steps 1-3 for all projects in the solution.  
  
## See Also  
 [Compiling and Building](../ide/compiling-and-building-in-visual-studio.md)   
 [How to: Change the Build Output Directory](../ide/how-to-change-the-build-output-directory.md)