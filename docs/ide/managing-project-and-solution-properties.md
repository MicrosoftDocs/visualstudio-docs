---
title: Manage project and solution properties
description: Learn how to manage both the project properties and the solution properties in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 04/25/2022
ms.topic: conceptual
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Manage project and solution properties

Projects have properties that govern many aspects of compilation, debugging, testing and deploying. Some properties are common among all project types, and some are unique to specific languages or platforms.

You access project properties by right-clicking the project node in **Solution Explorer** and choosing **Properties**, or by typing **properties** into the search box on the menu bar and choosing **Properties Window** from the results.

::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/properties-from-solution-explorer-context-menu.png" alt-text="Screenshot of the Solution Explorer context menu with the Properties option highlighted.":::

::: moniker-end

::: moniker range="vs-2019"

:::image type="content" source="media/vs-2019/properties-from-solution-explorer-context-menu.png" alt-text="Screenshot of the Solution Explorer context menu with the Properties option highlighted.":::

::: moniker-end

::: moniker range="vs-2017"

![Project context menu](../ide/media/vs2015_proj_prop_menu.gif)

::: moniker-end

.NET projects might also have a properties node in the project tree itself.

::: moniker range=">=vs-2019"

:::image type="content" source="media/vs-2022/properties-node-solution-explorer.png" alt-text="Screenshot of Solution Explorer with a Properties node showing.":::

::: moniker-end

::: moniker range="vs-2017"

![Properties node in Solution Explorer tree](../ide/media/vs2015_props_se.png)

::: moniker-end

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Managing solution and project properties (Visual Studio for Mac)](/visualstudio/mac/managing-solutions-and-project-properties).

## Project properties

Project properties are organized into groups, and each group has its own property page. The pages might be different for different languages and project types.

### C#, Visual Basic, and F# projects

In C#, Visual Basic, and F# projects, properties are exposed in the [**Project Designer**](reference/project-properties-reference.md).

::: moniker range="vs-2022"

The following screenshot shows the **Build** property page in the Project Designer for a console project in C#:

:::image type="content" source="media/vs-2022/properties-page-csharp-console.png" alt-text="Screenshot of the Properties page in Visual Studio 2022." lightbox="media/vs-2022/properties-page-csharp-console.png":::

::: moniker-end

::: moniker range="<=vs-2019"

The following screenshot shows the **Build** property page in the Project Designer for a WPF project in C#:

![Visual Studio Project Designer](../ide/media/vs2015_proppage_build.png)

::: moniker-end

For information about each of the property pages in **Project Designer**, see [What is the Project Designer?](reference/project-properties-reference.md).

> [!TIP]
> Solutions have a few properties, and so do project items; these properties are accessed in the [**Properties window**](reference/properties-window.md), not the [Project Designer](reference/project-properties-reference.md).

### C++ and JavaScript projects

C++ and JavaScript projects have a different user interface for managing project properties. This screenshot shows a C++ project property page (JavaScript pages are similar):

::: moniker range=">=vs-2019"

:::image type="content" source="media/vs-2022/properties-page-cpp-console.png" alt-text="Screenshot of the C++ project properties page.":::

::: moniker-end

::: moniker range="vs-2017"

![Visual C&#43;&#43; project properties](../ide/media/vs2015_projprops_cpp.png)

::: moniker-end

For information about C++ project properties, see [Work with project properties (C++)](/cpp/build/working-with-project-properties). For more information about JavaScript properties, see [Property pages, JavaScript](../ide/reference/property-pages-javascript.md).

## Solution properties

To access properties on the solution, right click the solution node in **Solution Explorer** and choose **Properties**. In the dialog, you can set project configurations for **Debug** or **Release** builds, choose which projects should be the startup project when **F5** is pressed, and set code analysis options.

## See also

- [Solutions and projects in Visual Studio](../ide/solutions-and-projects-in-visual-studio.md)
- [Managing solution and project properties (Visual Studio for Mac)](/visualstudio/mac/managing-solutions-and-project-properties)
