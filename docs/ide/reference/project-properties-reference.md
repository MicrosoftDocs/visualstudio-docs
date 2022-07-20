---
title: What is the .NET Project Designer?
description: Learn how to configure and customize .NET project properties by using the Project Designer.
ms.custom: SEO-VS-2020
ms.date: 06/17/2022
ms.topic: reference
helpviewer_keywords:
- user interface [Visual Studio], projects
- projects [Visual Studio], user interface
ms.assetid: eec49aec-5474-48a7-889d-709045b9a475
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# What is the .NET Project Designer?

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

The Project Designer in Visual Studio is a dialog box that you can use to specify applications settings and properties for a .NET project. The Project Designer includes several different project properties pages to interact with. What you see depends on your .NET project type, platform, and programming language.

The Project Designer appears after you select a [project node](../use-solution-explorer.md#tool-window) in **Solution Explorer** and then use the right-click context menu to select **Properties**.

> [!IMPORTANT]
> The project properties that you can access by using the .NET Project Designer differ from the properties you can access by using the [Properties window](properties-window.md) in Solution Explorer.

::: moniker range="vs-2022"

The following screenshot shows an example of the .NET project properties for a C# console project in the Project Designer. Notice that .NET 6.0 appears as the target framework.

:::image type="content" source="media/vs-2022/project-properties-designer-csharp-console.png" alt-text="Screenshot of the .NET Project Designer in Visual Studio 2022 with .NET 6.0 as the target framework.":::

The following screenshot shows an example of the .NET project properties for a Visual Basic console project in the Project Designer. Notice that .NET Framework 4.7.2 appears as the target framework.

:::image type="content" source="media/vs-2022/project-properties-designer-visual-basic-console.png" alt-text="Screenshot of the .NET Project Designer in Visual Studio 2022 with .NET Framework 4.7.2 as the target framework.":::

::: moniker-end

::: moniker range="vs-2019"

The following Visual Studio 2019 screenshot shows an example of the .NET project properties for a C# console project in the Project Designer. Notice that .NET 5.0 appears as the target framework.

:::image type="content" source="media/vs-2019/project-properties-designer-csharp-console.png" alt-text="Screenshot of the Project Designer in Visual Studio 2019 with .NET as the target framework.":::

The following Visual Studio 2019 screenshot shows an example of the .NET project properties for a Visual Basic console project in the Project Designer. Notice that .NET Framework 4.7.2 appears as the target framework.

:::image type="content" source="media/vs-2019/project-properties-designer-visual-basic-console.png" alt-text="Screenshot of the Project Designer in Visual Studio 2019 with .NET Framework as the target framework.":::

::: moniker-end

## Project properties in the .NET Project Designer

::: moniker range="vs-2022"

|Property       |Language/platform      |Description                                                              |
|---------------|-----------------------|-------------------------------------------------------------------------|
|Application     | [C#](application-page-project-designer-csharp.md), [Visual Basic](application-page-project-designer-visual-basic.md), [UWP](application-page-project-designer-uwp.md), WPF  | Specify application settings and properties for a project. |
|Build           | [C#](build-page-project-designer-csharp.md), WPF |  Specify build configuration properties for a project. |
|Build Events    | [C#](build-events-page-project-designer-csharp.md), Visual Basic, WPF | Specify build configuration instructions. |
|[Code Analysis](code-analysis-project-designer.md)  | C#, Visual Basic, WPF  | Configure the code analysis tool. |
|Compile         | [Visual Basic](compile-page-project-designer-visual-basic.md) | Specify compilation properties |
|My Extensions | Visual Basic | Manage [My Namespace](/dotnet/visual-basic/developing-apps/customizing-extending-my/) extensions. |
|Package | C#, Visual Basic | Generate a NuGet package on build. |
|[Publish](publish-page-project-designer.md) | Visual Basic, WPF | Configure properties for [!INCLUDE[ndptecclick](../../deployment/includes/ndptecclick_md.md)].|
|References      | [Visual Basic](references-page-project-designer-visual-basic.md) | Manage the references used by a project. |
|Reference Paths | WPF                   | Manage reference paths for a project. |
|Resources       | C#, Visual Basic, WPF |  Access the RESX file from Solution Explorer for a C# project, create a default resources file for a Visual Basic project, or add resources to a WPF project. |
|[Services](services-page-project-designer.md) | Visual Basic, WPF, Windows Forms | Enable client application services. |
|[Settings](settings-page-project-designer.md) | C#, Visual Basic, WPF | Specify a project's application settings. |
|[Signing](signing-page-project-designer.md) |  Visual Basic, WPF | Sign application and deployment manifests, and sign the assembly. (For a Visual Basic project, the [!INCLUDE[ndptecclick](../../deployment/includes/ndptecclick_md.md)] manifest signing for .NET projects is now under **Build** > **Publish**.) |
|Security |  Visual Basic, [WPF](security-page-project-designer.md) | Configure code access security settings for applications that are deployed by using [!INCLUDE[ndptecclick](../../deployment/includes/ndptecclick_md.md)] deployment.

::: moniker-end

::: moniker range="<=vs-2019"

| Title | Description |
| - | - |
| [Application Page, Project Designer (Visual Basic)](../../ide/reference/application-page-project-designer-visual-basic.md) | Specify application settings and properties for a [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] project. |
| [Application Page, Project Designer (C#)](../../ide/reference/application-page-project-designer-csharp.md) | Specify application settings and properties for a [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] project. |
| [Build Events Page, Project Designer (C#)](../../ide/reference/build-events-page-project-designer-csharp.md) | Specify build configuration instructions. |
| [Build Page, Project Designer (C#)](../../ide/reference/build-page-project-designer-csharp.md) | Specify build configuration properties for a [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] project. |
| [Compile Page, Project Designer (Visual Basic)](../../ide/reference/compile-page-project-designer-visual-basic.md) | Specify compilation properties for [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] projects. |
| [Debug Page, Project Designer](../../ide/reference/debug-page-project-designer.md) | Specify debugging properties for a project. |
| [Code Analysis, Project Designer](../../ide/reference/code-analysis-project-designer.md) | Configure the code analysis tool. |
| [Publish Page, Project Designer](../../ide/reference/publish-page-project-designer.md) | Configure properties for [!INCLUDE[ndptecclick](../../deployment/includes/ndptecclick_md.md)]. |
| [References Page, Project Designer (Visual Basic)](../../ide/reference/references-page-project-designer-visual-basic.md) | Manage references used by a project. |
| [Security Page, Project Designer](../../ide/reference/security-page-project-designer.md) | Configure code access security settings for applications that are deployed by using [!INCLUDE[ndptecclick](../../deployment/includes/ndptecclick_md.md)] deployment. |
| [Signing Page, Project Designer](../../ide/reference/signing-page-project-designer.md) | Sign application and deployment manifests, and sign the assembly. |

::: moniker-end

## See also

- [What are solutions and projects in Visual Studio?](../solutions-and-projects-in-visual-studio.md)
- [Learn about Solution Explorer](../use-solution-explorer.md)