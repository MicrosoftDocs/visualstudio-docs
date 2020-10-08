---
title: "How to: Build to a Common Output Directory | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "output directory"
  - "builds [Visual Studio], common directory"
  - "common directory"
ms.assetid: 1fcc2c48-07cb-4c4f-9556-36945e7dfc4e
caps.latest.revision: 9
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Build to a Common Output Directory
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By default, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] builds each project in a solution in its own folder inside the solution. You can change the build output paths of your projects to force all outputs to be placed in the same folder.

### To place all solution outputs in a common directory

1. Click on one project in the solution.

2. On the **Project** menu, click **Properties**.

3. Depending on the type of project, click on either the **Compile** tab or the **Build** tab, and set the **Output path** to a folder to use for all projects in the solution.

4. Repeat steps 1-3 for all projects in the solution.

## See Also
 [Compiling and Building](../ide/compiling-and-building-in-visual-studio.md)
 [How to: Change the Build Output Directory](../ide/how-to-change-the-build-output-directory.md)
