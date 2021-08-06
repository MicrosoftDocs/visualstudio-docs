---
title: Multiple DSLs in One Solution
description: Learn how you can package several domain-specific languages (DSLs) as part of a single solution so that they are installed together.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
  - "multiple"
---
# Multiple DSLs in One Solution

You can package several DSLs as part of a single solution so that they are installed together.

You can use several techniques to integrate multiple DSLs. For more information, see [Integrating Models by using Visual Studio Modelbus](../modeling/integrating-models-by-using-visual-studio-modelbus.md) and [How to: Add a Drag-and-Drop Handler](../modeling/how-to-add-a-drag-and-drop-handler.md) and [Customizing Copy Behavior](../modeling/customizing-copy-behavior.md).

## Build more than one DSL in the same solution

1. Create a new **VSIX Project** project.

2. Create two or more DSL projects in the VSIX solution directory.

   - For each DSL, open a new instance of Visual Studio. Create the new DSL, and specify the same solution folder as the VSIX solution.

   - Make sure that you create each DSL with a different filename extension.

   - Change the names of the **Dsl** and **DslPackage** projects so that they are all different. For example: `Dsl1`, `DslPackage1`, `Dsl2`, `DslPackage2`.

   - In each **DslPackage\*\source.extension.tt**, update this line to the correct Dsl project name:

      `string dslProjectName = "Dsl2";`

   - In the VSIX solution, add the Dsl* and DslPackage\* projects. You might want to place each pair in its own solution folder.

2. Combine the VSIX manifests of the DSLs:

   1. Open _YourVsixProject_**\source.extension.manifest**.

   2. For each DSL, choose **Add Content** and add:

       - `Dsl*` project as a **MEF Component**

       - `DslPackage*` project as a **MEF Component**

       - `DslPackage*` project as a **VS Package**

3. Build the solution.

   The resulting VSIX will install both DSLs. You can test them by using F5, or deploy _YourVsixProject_**\bin\Debug\\\*.vsix**.

## See also

- [Integrating Models by using Visual Studio Modelbus](../modeling/integrating-models-by-using-visual-studio-modelbus.md)
- [How to: Add a Drag-and-Drop Handler](../modeling/how-to-add-a-drag-and-drop-handler.md)
- [Customizing Copy Behavior](../modeling/customizing-copy-behavior.md)