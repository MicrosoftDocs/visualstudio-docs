---
title: What is the .NET Project Designer?
description: Learn how to configure and customize .NET project properties by using the Project Designer.
ms.date: 12/13/2024
ms.topic: reference
helpviewer_keywords:
- user interface [Visual Studio], projects
- projects [Visual Studio], user interface
ms.custom: "ide-ref"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# What is the .NET Project Designer?

::: moniker range=">=vs-2022"
The Project Designer in Visual Studio is a dialog box that you can use to specify applications settings and properties for a .NET or .NET Framework project. The Project Designer includes several different project properties tabs or pages to interact with. What you see depends on your .NET version, since the project designer for .NET Framework projects is different from the project designer for projects that target .NET Core and .NET 5 and later. For detailed information on properties in the .NET Project Designer, see [.NET Project Designer](../ide/project-designer-dotnet-csharp.md). For detailed information on the .NET Framework Project Designer, see [Project properties in the .NET Framework Project Designer](#project-properties-in-the-net-framework-project-designer).
::: moniker-end

::: moniker range="vs-2019"
The Project Designer in Visual Studio is a dialog box that you can use to specify applications settings and properties for a .NET or .NET Framework project. The Project Designer includes several different project properties tabs or pages to interact with. What you see depends on your .NET project type, platform, and programming language.
::: moniker-end

The Project Designer appears after you select a [project node](../ide/use-solution-explorer.md#solution-explorer-ui) in **Solution Explorer** and then use the right-click context menu to select **Properties**.

> [!IMPORTANT]
> The project properties that you can access by using the .NET Project Designer differ from the properties you can access by using the [Properties window](properties-window.md) in Solution Explorer.

::: moniker range=">=vs-2022"

The following screenshot shows an example of the .NET project properties for a C# console project in the Project Designer.

:::image type="content" source="media/vs-2022/project-properties-designer-csharp-console.png" alt-text="Screenshot of the .NET Project Designer in Visual Studio 2022 with .NET 8.0 as the target framework.":::

The following screenshot shows an example of the .NET Framework project properties for a Visual Basic console project in the Project Designer. Notice that .NET Framework 4.7.2 appears as the target framework.

:::image type="content" source="media/vs-2022/project-properties-designer-visual-basic-console.png" alt-text="Screenshot of the .NET Project Designer in Visual Studio 2022 with .NET Framework 4.7.2 as the target framework.":::

::: moniker-end

::: moniker range="vs-2019"

The following Visual Studio 2019 screenshot shows an example of the .NET project properties for a C# console project in the Project Designer. Notice that .NET 5.0 appears as the target framework.

:::image type="content" source="media/vs-2019/project-properties-designer-csharp-console.png" alt-text="Screenshot of the Project Designer in Visual Studio 2019 with .NET as the target framework.":::

The following Visual Studio 2019 screenshot shows an example of the .NET project properties for a Visual Basic console project in the Project Designer. Notice that .NET Framework 4.7.2 appears as the target framework.

:::image type="content" source="media/vs-2019/project-properties-designer-visual-basic-console.png" alt-text="Screenshot of the Project Designer in Visual Studio 2019 with .NET Framework as the target framework.":::

::: moniker-end

::: moniker range=">=vs-2022"

## Project properties in the .NET Framework Project Designer

For .NET Framework projects, use links in the following table to get information about properties.

|Property       |Language/platform      |Description                                                              |
|---------------|-----------------------|-------------------------------------------------------------------------|
|Application     | [C#](/previous-versions/visualstudio/visual-studio-2017/ide/reference/application-page-project-designer-csharp), F#, [Visual Basic](/previous-versions/visualstudio/visual-studio-2017/ide/reference/application-page-project-designer-visual-basic), [UWP](/previous-versions/visualstudio/visual-studio-2017/ide/reference/application-page-project-designer-uwp), WPF  | Specify application settings and properties for a project. |
|Build           | [C#](/previous-versions/visualstudio/visual-studio-2017/ide/reference/build-page-project-designer-csharp), F#, WPF |  Specify build configuration properties for a project. |
|Build Events    | [C#](/previous-versions/visualstudio/visual-studio-2017/ide/reference/build-events-page-project-designer-csharp), Visual Basic, WPF | Specify build configuration instructions. |
|[Code Analysis](/previous-versions/visualstudio/visual-studio-2017/ide/reference/code-analysis-project-designer)  | C#, F#, Visual Basic, WPF  | Configure the code analysis tool. |
|Compile         | [Visual Basic](/previous-versions/visualstudio/visual-studio-2017/ide/reference/compile-page-project-designer-visual-basic) | Specify compilation properties |
|My Extensions | Visual Basic | Manage [My Namespace](/dotnet/visual-basic/developing-apps/customizing-extending-my/) extensions. |
|Package | C#, F#, Visual Basic | Generate a NuGet package on build. |
|[Publish](/previous-versions/visualstudio/visual-studio-2017/ide/reference/publish-page-project-designer) | Visual Basic, WPF | Configure properties for ClickOnce.|
|References      | [Visual Basic](/previous-versions/visualstudio/visual-studio-2017/ide/reference/references-page-project-designer-visual-basic) | Manage the references used by a project. |
|Reference Paths | WPF                   | Manage reference paths for a project. |
|Resources       | C#, F#, Visual Basic, WPF |  Access the RESX file from Solution Explorer for a C# project, create a default resources file for a Visual Basic project, or add resources to a WPF project. |
|[Services](/previous-versions/visualstudio/visual-studio-2017/ide/reference/services-page-project-designer) | Visual Basic, WPF, Windows Forms | Enable client application services. |
|[Settings](/previous-versions/visualstudio/visual-studio-2017/ide/reference/settings-page-project-designer) | C#, F#, Visual Basic, WPF | Specify a project's application settings. |
|[Signing](/previous-versions/visualstudio/visual-studio-2017/ide/reference/signing-page-project-designer) |  Visual Basic, WPF | Sign application and deployment manifests, and sign the assembly. (For a Visual Basic project, the ClickOnce manifest signing for .NET projects is now under **Build** > **Publish**.) |
|Security |  Visual Basic, [WPF](/previous-versions/visualstudio/visual-studio-2017/ide/reference/security-page-project-designer) | Configure code access security settings for applications that are deployed by using ClickOnce deployment.

::: moniker-end

::: moniker range="<=vs-2019"

## Project properties in the .NET Project Designer

Use links in the following table to get information about properties.

| Title | Description |
| - | - |
| [Application Page, Project Designer (Visual Basic)](/previous-versions/visualstudio/visual-studio-2017/ide/reference/application-page-project-designer-visual-basic) | Specify application settings and properties for a Visual Basic project. |
| [Application Page, Project Designer (C#)](/previous-versions/visualstudio/visual-studio-2017/ide/reference/application-page-project-designer-csharp) | Specify application settings and properties for a Visual C# project. |
| [Build Events Page, Project Designer (C#)](/previous-versions/visualstudio/visual-studio-2017/ide/reference/build-events-page-project-designer-csharp) | Specify build configuration instructions. |
| [Build Page, Project Designer (C#)](/previous-versions/visualstudio/visual-studio-2017/ide/reference/build-page-project-designer-csharp) | Specify build configuration properties for a Visual C# project. |
| [Compile Page, Project Designer (Visual Basic)](/previous-versions/visualstudio/visual-studio-2017/ide/reference/compile-page-project-designer-visual-basic) | Specify compilation properties for Visual Basic projects. |
| [Debug Page, Project Designer](/previous-versions/visualstudio/visual-studio-2017/ide/reference/debug-page-project-designer) | Specify debugging properties for a project. |
| [Code Analysis, Project Designer](/previous-versions/visualstudio/visual-studio-2017/ide/reference/code-analysis-project-designer) | Configure the code analysis tool. |
| [Publish Page, Project Designer](/previous-versions/visualstudio/visual-studio-2017/ide/reference/publish-page-project-designer) | Configure properties for ClickOnce. |
| [References Page, Project Designer (Visual Basic)](/previous-versions/visualstudio/visual-studio-2017/ide/reference/references-page-project-designer-visual-basic) | Manage references used by a project. |
| [Security Page, Project Designer](/previous-versions/visualstudio/visual-studio-2017/ide/reference/security-page-project-designer) | Configure code access security settings for applications that are deployed by using ClickOnce deployment. |
| [Signing Page, Project Designer](/previous-versions/visualstudio/visual-studio-2017/ide/reference/signing-page-project-designer) | Sign application and deployment manifests, and sign the assembly. |

::: moniker-end

## See also

- [What are solutions and projects in Visual Studio?](../ide/solutions-and-projects-in-visual-studio.md)
- [Learn about Solution Explorer](../ide/use-solution-explorer.md)
