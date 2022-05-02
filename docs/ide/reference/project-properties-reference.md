---
title: What is the Project Designer?
description: Learn how to configure and customize project properties by using the Project Designer.
ms.custom: SEO-VS-2020
ms.date: 04/29/2022
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
# What is the Project Designer?

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]?

The Project Designer in Visual Studio is a dialog box that you can use to specify applications settings and properties for a project. The Project Designer includes several different project properties pages to interact with. What you see depends on your project type, platform, or programming language.

The following screenshot shows an example of a project properties page for a C# console project in the Project Designer. The Project Designer appears after you select a [project node](../use-solution-explorer.md#tool-window) in **Solution Explorer** and then use the right-click context menu to select **Properties**.

::: moniker range="vs-2022"
:::image type="content" source="media/vs-2022/project-properties-designer.png" alt-text="Screenshot of the Project Designer in Visual Studio 2022.":::
::: moniker-end

::: moniker range="vs-2019"
:::image type="content" source="media/vs-2019/project-properties-designer.png" alt-text="Screenshot of the Project Designer in Visual Studio 2019.":::
::: moniker-end

::: moniker range="vs-2017"
:::image type="content" source="media/project-properties-designer-visual-studio-2017.png" alt-text="Screenshot of the Project Designer in Visual Studio 2017.":::
::: moniker-end

> [!IMPORTANT]
> The project properties that you can access by using the Project Designer differ from the properties you can access by using the [Properties window](properties-window.md) in Solution Explorer.

## Project properties pages in Project Designer

::: moniker range="vs-2022"

|Page name       |Language/platform      |Description                                                              |
|----------------|-----------------------|-------------------------------------------------------------------------|
|Application     | [C#](application-page-project-designer-csharp.md), [Visual Basic](application-page-project-designer-visual-basic.md), [UWP](application-page-project-designer-uwp.md), WPF  | Use this page to specify application settings and properties for a project. |
|Build           | [C#](build-page-project-designer-csharp.md), WPF |  Use this pane to specify build configuration properties for a project. |
|Build Events    | [C#](build-events-page-project-designer-csharp.md), Visual Basic, WPF | Use this page to specify build configuration instructions. |
|[Code Analysis](code-analysis-project-designer.md)  | C#, Visual Basic, WPF  | Use this page to configure the code analysis tool. |
|Compile         | [Visual Basic](compile-page-project-designer-visual-basic.md) | Use this page to specify compilation properties for a project. |
|[Debug Page](debug-page-project-designer.md) | C#, Visual Basic, WPF | Use this page to specify debugging properties for a project. |
|Package | C#, Visual Basic | Use this page to generate a NuGet package on build. |
|[Publish](publish-page-project-designer.md) | WPF | Use this page to configure properties for [!INCLUDE[ndptecclick](../../deployment/includes/ndptecclick_md.md)].|
|References      | [Visual Basic](references-page-project-designer-visual-basic.md) | Use this page to manage references used by a project. |
|Reference Paths | WPF                   | Use this page to manage reference paths for a project. |
|Resources       | C#, Visual Basic, WPF |  Use this page to access the RESX file from Solution Explorer for a C# project, to create a default resources file for a Visual Basic project, or to add resources to a WPF project. |
|[Services](services-page-project-designer.md) | WPF, Windows Forms | Use this page to enable client application services. |
|[Settings](settings-page-project-designer.md) | C#, Visual Basic, WPF | Use this page to specify a project's application settings. |
|[Signing](signing-page-project-designer.md) |  WPF | Use this page to sign application and deployment manifests, and sign the assembly. (For a Visual Basic project, the [!INCLUDE[ndptecclick](../../deployment/includes/ndptecclick_md.md)] manifest signing for .NET projects is now under **Build** > **Publish**.) |
|Security |  [WPF](security-page-project-designer.md) | Use this page to configure code access security settings for applications that are deployed by using [!INCLUDE[ndptecclick](../../deployment/includes/ndptecclick_md.md)] deployment.

::: moniker-end

::: moniker range="<=vs-2019"

| Title | Description |
| - | - |
| [Application Page, Project Designer (Visual Basic)](../../ide/reference/application-page-project-designer-visual-basic.md) | Use this page to specify application settings and properties for a [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] project. |
| [Application Page, Project Designer (C#)](../../ide/reference/application-page-project-designer-csharp.md) | Use this page to specify application settings and properties for a [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] project. |
| [Build Events Page, Project Designer (C#)](../../ide/reference/build-events-page-project-designer-csharp.md) | Use this pane to specify build configuration instructions. |
| [Build Page, Project Designer (C#)](../../ide/reference/build-page-project-designer-csharp.md) | Use this pane to specify build configuration properties for a [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] project. |
| [Compile Page, Project Designer (Visual Basic)](../../ide/reference/compile-page-project-designer-visual-basic.md) | Use this page to specify compilation properties for [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] projects. |
| [Debug Page, Project Designer](../../ide/reference/debug-page-project-designer.md) | Use this page to specify debugging properties for a project. |
| [Code Analysis, Project Designer](../../ide/reference/code-analysis-project-designer.md) | Use this page to configure the code analysis tool. |
| [Publish Page, Project Designer](../../ide/reference/publish-page-project-designer.md) | Use this page to configure properties for [!INCLUDE[ndptecclick](../../deployment/includes/ndptecclick_md.md)]. |
| [References Page, Project Designer (Visual Basic)](../../ide/reference/references-page-project-designer-visual-basic.md) | Use this page to manage references used by a project. |
| [Security Page, Project Designer](../../ide/reference/security-page-project-designer.md) | Use this page to configure code access security settings for applications that are deployed by using [!INCLUDE[ndptecclick](../../deployment/includes/ndptecclick_md.md)] deployment. |
| [Signing Page, Project Designer](../../ide/reference/signing-page-project-designer.md) | Use this page to sign application and deployment manifests, and sign the assembly. |

::: moniker-end

## See also

- [What are solutions and projects in Visual Studio?](../solutions-and-projects-in-visual-studio.md)
- [Learn about Solution Explorer](../use-solution-explorer.md)