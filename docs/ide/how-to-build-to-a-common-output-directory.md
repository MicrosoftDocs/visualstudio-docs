---
title: "How to: Build to a common output directory"
ms.date: 11/04/2016
ms.technology: vs-ide-compile
ms.topic: conceptual
helpviewer_keywords:
  - "output directory"
  - "builds [Visual Studio], common directory"
  - "common directory"
ms.assetid: 1fcc2c48-07cb-4c4f-9556-36945e7dfc4e
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Build to a common output directory

By default, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] builds each project in a solution in its own folder inside the solution. You can change the build output paths of your projects to force all outputs to be placed in the same folder.

## To place all solution outputs in a common directory

1. Click on one project in the solution.

2. On the **Project** menu, click **Properties**.

3. Depending on the type of project, click on either the **Compile** tab or the **Build** tab, and set the **Output path** to a folder to use for all projects in the solution.

4. Repeat steps 1-3 for all projects in the solution.

## See also

- [Compile and build](../ide/compiling-and-building-in-visual-studio.md)
- [How to: Change the build output directory](../ide/how-to-change-the-build-output-directory.md)