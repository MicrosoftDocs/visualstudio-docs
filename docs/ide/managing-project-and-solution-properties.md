---
title: Manage project and solution properties
description: Manage both the project properties and the solution properties in Visual Studio for C#, Visual Basic, F#, C++, and JavaScript projects.
ms.date: 02/25/2025
ms.topic: conceptual
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
#customer intent: As a developer, I want to understand product and solution properties in Visual Studio to manage different kinds of projects.
---
# Manage project and solution properties

Projects have properties that govern many aspects of compilation, debugging, testing, and deploying. Some properties are common among all project types, and some are unique to specific languages or platforms.

You access project properties by right-clicking the [project node](use-solution-explorer.md#solution-explorer-ui) in **Solution Explorer** and selecting **Properties**, or by typing **properties** into the search box on the menu bar and selecting **Properties Window** from the results.

Most project properties are not dependent on the configuration or the platform, but some are. Learn more about [setting properties based on configurations](how-to-create-and-edit-configurations.md#set-properties-based-on-configurations).

::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/properties-from-solution-explorer-context-menu.png" alt-text="Screenshot of the Solution Explorer context menu with the Properties option highlighted.":::

::: moniker-end

::: moniker range="vs-2019"

:::image type="content" source="media/vs-2019/properties-from-solution-explorer-context-menu.png" alt-text="Screenshot of the Solution Explorer context menu with the Properties option highlighted.":::

::: moniker-end

.NET projects might also have a properties node in the project tree itself.

:::image type="content" source="media/vs-2022/properties-node-solution-explorer.png" alt-text="Screenshot of Solution Explorer with a Properties node showing.":::

## Project properties

Project properties are organized into groups, and each group has its own property page. The pages might be different for different languages and project types.

### C#, Visual Basic, and F# projects

In C#, Visual Basic, and F# projects, properties are exposed in the [.NET Project Designer](reference/project-properties-reference.md).

The following screenshot shows the **Build** property page in the .NET **Project Designer** for a console project in C#:

::: moniker range="vs-2022"

:::image type="content" source="reference/media/vs-2022/project-properties-designer-build-csharp.png" alt-text="Screenshot of the Project Designer, with the Build tab selected.":::

::: moniker-end

::: moniker range="vs-2019"

:::image type="content" source="reference/media/vs-2019/project-properties-designer-build-csharp.png" alt-text="Screenshot of the Project Designer, with the Build tab selected.":::

::: moniker-end

The following screenshot shows the **Compile** property page in the .NET **Project Designer** for a console project in Visual Basic:

::: moniker range="vs-2022"

:::image type="content" source="reference/media/vs-2022/project-properties-designer-compile-visual-basic.png" alt-text="Screenshot of the Project Designer, with the Compile tab selected.":::

::: moniker-end

::: moniker range="vs-2019"

:::image type="content" source="reference/media/vs-2019/project-properties-designer-compile-visual-basic.png" alt-text="Screenshot of the Project Designer, with the Compile tab selected.":::

::: moniker-end

For more information about each of the **Project Designer** properties, see [What is the .NET Project Designer](reference/project-properties-reference.md).

> [!TIP]
> Solutions have a few properties, and so do project items; these properties are accessed in the [**Properties window**](reference/properties-window.md), not the [.NET Project Designer](reference/project-properties-reference.md).

### C++ and JavaScript projects

C++ and JavaScript projects have a different user interface for managing project properties. The following screenshot shows a C++ project property page. JavaScript pages are similar.

:::image type="content" source="media/vs-2022/properties-page-cpp-console.png" alt-text="Screenshot of the C++ project properties page.":::

For information about C++ project properties, see [Work with project properties (C++)](/cpp/build/working-with-project-properties). For more information about JavaScript properties, see [Property pages, JavaScript](../ide/reference/property-pages-javascript.md).

## Solution properties

::: moniker range="vs-2019"

To access properties on the solution, right-click the [solution node](use-solution-explorer.md#solution-explorer-ui) in **Solution Explorer** and select **Properties**. In the dialog box, you can set project configurations for **Debug** or **Release** builds, choose which projects should be the startup project when you select **F5**, and set code analysis options.

::: moniker-end

::: moniker range=">=vs-2022"

To access properties on the solution, right-click the [solution node](use-solution-explorer.md#solution-explorer-ui) in **Solution Explorer** and select **Properties**. What you see in the context menu from the Solution node also depends on your project type, programming language, or platform.

:::image type="content" source="media/vs-2022/solution-node-properties.png" alt-text="Screenshot of the solution node right-click menu.":::

In the dialog box, you can set [project configurations](understanding-build-configurations.md#solution-configurations) for **Debug** or **Release** builds, and choose which projects should be the [startup project](how-to-set-multiple-startup-projects.md) when you select **F5**. The Code Analysis property page at the solution level was [removed](../code-quality/analyzers-faq.yml#code-analysis-solution-property-page). You can still set code analysis properties at the project level.

:::image type="content" source="media/vs-2022/solution-properties-dialog.png" alt-text="Screenshot of the solution properties dialog.":::

::: moniker-end

Solution properties are stored in a Solution User Options (*.suo*) file. For more information about this file type, see [Solution file](solutions-and-projects-in-visual-studio.md#solution-file).

## Related content

- [What are solutions and projects in Visual Studio?](../ide/solutions-and-projects-in-visual-studio.md)
- [MSBuild Properties](../msbuild/msbuild-properties.md)
- [Use properties to control build settings](../msbuild/how-to-build-the-same-source-files-with-different-options.md#use-properties-to-control-build-settings)
- [Understand build configurations](understanding-build-configurations.md)
