---
title: Manage project and solution properties
description: Manage project and solution properties in Visual Studio, including .NET and .NET Framework Project Designer settings, for C#, Visual Basic, F#, C++, and JavaScript projects.
ms.date: 04/20/2026
ms.topic: concept-article
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
ms.custom: awp-ai
monikerRange: '>= vs-2022'
#customer intent: As a developer, I want to understand project and solution properties in Visual Studio, including the .NET Project Designer, so I can configure settings for different project types.
---
# Manage project and solution properties

Projects have properties that govern many aspects of compilation, debugging, testing, and deploying. Some properties are common among all project types, and some are unique to specific languages or platforms.

You can access project properties by right-clicking the [project node](use-solution-explorer.md#solution-explorer-ui) in **Solution Explorer** and selecting **Properties**. You can also type **properties** into the search box on the menu bar and select **Properties Window** from the results.

Most project properties don't depend on the configuration or the platform, but some do. For more information, see [setting properties based on configurations](how-to-create-and-edit-configurations.md#set-properties-based-on-configurations).

:::moniker range="visualstudio"
:::image type="content" source="reference/media/visualstudio/properties-from-solution-explorer-context-menu.png" alt-text="Screenshot of the Solution Explorer context menu with the Properties option highlighted.":::
:::moniker-end

:::moniker range="vs-2022"
:::image type="content" source="media/vs-2022/properties-from-solution-explorer-context-menu.png" alt-text="Screenshot of the Solution Explorer context menu with the Properties option highlighted.":::
:::moniker-end

.NET projects might also have a properties node in the project tree itself.

:::moniker range="visualstudio"
:::image type="content" source="reference/media/visualstudio/properties-node-solution-explorer.png" alt-text="Screenshot of Solution Explorer with a Properties node showing.":::
:::moniker-end

:::moniker range="vs-2022"
:::image type="content" source="media/vs-2022/properties-node-solution-explorer.png" alt-text="Screenshot of Solution Explorer with a Properties node showing.":::
:::moniker-end

## Project properties

Project properties are organized into groups, and each group has its own property page. The pages might be different for different languages and project types.

### C#, Visual Basic, and F# project properties

In C#, Visual Basic, and F# projects, the [.NET Project Designer](project-designer-dotnet-csharp.md) exposes the properties.

The following screenshot shows the **Build** property page in the .NET **Project Designer** for a console project in C#:

:::moniker range="visualstudio"
:::image type="content" source="reference/media/visualstudio/project-properties-designer-build-csharp.png" alt-text="Screenshot of the Project Designer, with the Build tab selected.":::
:::moniker-end

:::moniker range="vs-2022"
:::image type="content" source="reference/media/vs-2022/project-properties-designer-build-csharp.png" alt-text="Screenshot of the Project Designer, with the Build tab selected.":::
:::moniker-end

The following screenshot shows the **Compile** property page in the .NET **Project Designer** for a console project in Visual Basic:

:::moniker range="visualstudio"
:::image type="content" source="reference/media/visualstudio/project-properties-designer-compile-visual-basic.png" alt-text="Screenshot of the Project Designer, with the Compile tab selected.":::
:::moniker-end

:::moniker range="vs-2022"
:::image type="content" source="reference/media/vs-2022/project-properties-designer-compile-visual-basic.png" alt-text="Screenshot of the Project Designer, with the Compile tab selected.":::
:::moniker-end

For more information about each .NET property, see [.NET Project Designer](project-designer-dotnet-csharp.md).

> [!TIP]
> Solutions and project items each have a few properties. Access these properties in the [**Properties window**](reference/properties-window.md), not the [.NET Project Designer](project-designer-dotnet-csharp.md).

### .NET Framework Project Designer

For .NET Framework projects, the Project Designer has a different set of tabs. The following table links to the property reference for each tab.

> [!IMPORTANT]
> The project properties that you access through the .NET Project Designer differ from the properties in the [Properties window](reference/properties-window.md).

| Property | Language/platform | Description |
|----------|-------------------|-------------|
| Application | C#, F#, Visual Basic, UWP, WPF | Specify application settings and properties for a project. |
| Build | C#, F#, WPF | Specify build configuration properties for a project. |
| Build Events | C#, Visual Basic, WPF | Specify build configuration instructions. |
| Code Analysis | C#, F#, Visual Basic, WPF | Configure the code analysis tool. |
| Compile | Visual Basic | Specify compilation properties. |
| My Extensions | Visual Basic | Manage [My Namespace](/dotnet/visual-basic/developing-apps/customizing-extending-my/) extensions. |
| Package | C#, F#, Visual Basic | Generate a NuGet package on build. |
| Publish | Visual Basic, WPF | Configure properties for ClickOnce. |
| References | Visual Basic | Manage the references used by a project. |
| Reference Paths | WPF | Manage reference paths for a project. |
| Resources | C#, F#, Visual Basic, WPF | Access the RESX file from Solution Explorer for a C# project, create a default resources file for a Visual Basic project, or add resources to a WPF project. |
| Services | Visual Basic, WPF, Windows Forms | Enable client application services. |
| Settings | C#, F#, Visual Basic, WPF | Specify a project's application settings. |
| Signing | Visual Basic, WPF | Sign application and deployment manifests, and sign the assembly. (For a Visual Basic project, the ClickOnce manifest signing for .NET projects is now under **Build** > **Publish**.) |
| Security | Visual Basic, WPF | Configure code access security settings for applications that are deployed by using ClickOnce deployment. |

### C++ and JavaScript projects

C++ and JavaScript projects use a different user interface for managing project properties. The following screenshot shows a C++ project property page. JavaScript pages are similar.

:::moniker range="visualstudio"
:::image type="content" source="reference/media/visualstudio/properties-page-cpp-console.png" alt-text="Screenshot of the C++ project properties page.":::
:::moniker-end

:::moniker range="vs-2022"
:::image type="content" source="media/vs-2022/properties-page-cpp-console.png" alt-text="Screenshot of the C++ project properties page.":::
:::moniker-end

For information about C++ project properties, see [Work with project properties (C++)](/cpp/build/working-with-project-properties). For more information about JavaScript properties, see [Property pages, JavaScript](/previous-versions/visualstudio/visual-studio-2017/ide/reference/property-pages-javascript).

## Solution properties


To access properties on the solution, right-click the [solution node](use-solution-explorer.md#solution-explorer-ui) in **Solution Explorer** and select **Properties**. The context menu from the Solution node also depends on your project type, programming language, or platform.

:::moniker range="visualstudio"
:::image type="content" source="reference/media/visualstudio/solution-node-properties.png" alt-text="Screenshot of the solution node right-click menu.":::
:::moniker-end

:::moniker range="vs-2022"
:::image type="content" source="media/vs-2022/solution-node-properties.png" alt-text="Screenshot of the solution node right-click menu.":::
:::moniker-end

In the dialog box, you can set [project configurations](understanding-build-configurations.md#solution-configurations) for **Debug** or **Release** builds, and choose which projects should be the [startup project](how-to-set-multiple-startup-projects.md) when you select **F5**. The Code Analysis property page at the solution level was [removed](../code-quality/analyzers-faq.yml#code-analysis-solution-property-page). You can still set code analysis properties at the project level.

:::moniker range="visualstudio"
:::image type="content" source="reference/media/visualstudio/solution-properties-dialog.png" alt-text="Screenshot of the solution properties dialog.":::
:::moniker-end

:::moniker range="vs-2022"
:::image type="content" source="media/vs-2022/solution-properties-dialog.png" alt-text="Screenshot of the solution properties dialog.":::
:::moniker-end

Solution properties are stored in a Solution User Options (*.suo*) file. For more information about this file type, see [Solution file](solutions-and-projects-in-visual-studio.md#solution-file).

## Related content

- [What are solutions and projects in Visual Studio?](../ide/solutions-and-projects-in-visual-studio.md)
- [MSBuild Properties](../msbuild/msbuild-properties.md)
- [Use properties to control build settings](../msbuild/how-to-build-the-same-source-files-with-different-options.md#use-properties-to-control-build-settings)
- [Understand build configurations](understanding-build-configurations.md)
