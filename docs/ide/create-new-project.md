---
title: Create and configure a new project
description: Create and configure a new project in Visual Studio by choosing a template type, the Framework version, an authentication type, and more.
ms.date: 10/15/2024
ms.topic: how-to
f1_keywords:
- vs.newproject
helpviewer_keywords:
- projects [Visual Studio], creating
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
#customer intent: As a developer, I want to create cd..a new project in Visual Studio.
---
# Create a new project in Visual Studio

In this article, you learn how to quickly create a new project in Visual Studio from a template.

::: moniker range="vs-2019"

## Open the "Create a new project" dialog

There are multiple ways to create a new project in Visual Studio. When you first open Visual Studio, the start window appears, and from there, you can select **Create a new project**.

:::image type="content" source="media/vs-2019/start-window-create-new-project.png" alt-text="Screenshot of the 'Create a new project' dialog from the start window in Visual Studio 2019":::

If the Visual Studio development environment is already open, you can create a new project by choosing **File** > **New** > **Project** on the menu bar. You can also select the **New Project** button on the toolbar, or press **Ctrl**+**Shift**+**N**.

:::image type="content" source="media/vs-2019/new-project-button.png" alt-text="Screenshot of the New Project button in Visual Studio 2019.":::

::: moniker-end

::: moniker range=">=vs-2022"

## Open the "Create a new project" dialog

There are multiple ways to create a new project in Visual Studio. When you first open Visual Studio, the start window appears, and from there, you can select **Create a new project**.

:::image type="content" source="media/vs-2022/start-window-create-new-project.png" alt-text="Screenshot of the 'Create a new project' dialog from the start window in Visual Studio 2022.":::

If the Visual Studio development environment is already open, you can create a new project by choosing **File** > **New** > **Project** on the menu bar. You can also select the **New Project** button on the toolbar, or press **Ctrl**+**Shift**+**N**.

:::image type="content" source="media/vs-2022/new-project-button.png" alt-text="Screenshot of the New Project button in Visual Studio 2022.":::

::: moniker-end

## Select a template type

On the **Create a new project** dialog, a list of your recently selected templates appears on the left. The templates are sorted by *most recently used*.

If you're not selecting from the recently used templates, you can filter all available project templates by **Language** (for example, C# or C++), **Platform** (for example, Windows or Azure), and **Project type** (for example, Desktop or Web). You can also enter search text into the search box to further filter the templates, for example, **asp.net**.

::: moniker range="vs-2019"

:::image type="content" source="media/vs-2019/create-new-project-filters.png" alt-text="Screenshot of the project template filters in Visual Studio 2019.":::

The tags that appear under each template correspond to the three dropdown filters (language, platform, and project type).

> [!TIP]
> If you don't see the template you're looking for, you might be missing a workload for Visual Studio. To install additional workloads, for example, **Azure Development** or **Mobile Development with .NET**, select the **Install more tools and features** link to open Visual Studio Installer. From there, select the workloads you want to install, and then select **Modify**. After that, additional project templates will be available to choose from.
>
> :::image type="content" source="media/vs-2019/install-more-tools-features.png" alt-text="Screenshot of the 'Install more tools and features' link in Visual Studio 2019.":::

Select a template and then select **Next**.

::: moniker-end

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/create-new-project-filters.png" alt-text="Screenshot of the project template filters.":::

The tags that appear under each template correspond to the three dropdown filters (language, platform, and project type).

> [!TIP]
> If you don't see the template you're looking for, you might be missing a workload for Visual Studio. To install additional workloads, for example, **Azure Development** or **Mobile Development with .NET**, select the **Install more tools and features** link to open Visual Studio Installer. From there, select the workloads you want to install, and then select **Modify**. After that, additional project templates will be available to choose from.
>
> :::image type="content" source="../get-started/csharp/media/vs-2022/not-finding-what-looking-for.png" alt-text="Screenshot of the 'Install more tools and features' link in Visual Studio 2022.":::

Select a template and then select **Next**.

::: moniker-end

::: moniker range="vs-2019"

## Configure your new project

The **Configure your new project** dialog has options to name your project (and solution), select a disk location, and select a Framework version (if applicable to the template you chose).

:::image type="content" source="media/vs-2019/configure-new-project.png" alt-text="Screenshot of the 'Configure your new project' dialog in Visual Studio 2019.":::

> [!NOTE]
> If you create a new project when you already have a project or solution open in Visual Studio, an extra configuration option is available. You can choose to create a new solution or add the new project to the solution that's already open.
>
> :::image type="content" source="media/vs-2019/configure-new-project-solution.png" alt-text="Screenshot of the 'Create new solution' or 'Add to solution' dialog in Visual Studio 2019.":::

Select **Create** to create the new project.

::: moniker-end

::: moniker range=">=vs-2022"

## Configure your new project

The **Configure your new project** dialog has options to name your project (and solution), select a disk location, and more.

:::image type="content" source="media/vs-2022/configure-new-project.png" alt-text="Screenshot showing the Configure your new project dialog in Visual Studio and the options to set, including the project name and project location." lightbox="media/vs-2022/configure-new-project.png":::

The **Additional information** dialog includes options to select a Framework version, an authentication type, and more.

:::image type="content" source="media/vs-2022/aspnet-core-additional-information-dialog.png" alt-text="Screenshot of the Additional Information dialog in Visual Studio 2022 showing the selected .NET Framework version for the new project." lightbox="media/vs-2022/aspnet-core-additional-information-dialog.png":::

Select **Create** to create the new project.

::: moniker-end

## Add another project to a solution

If you want to add another project to a solution, right-click the solution node in **Solution Explorer** and then select **Add** > **New Project**.

> [!TIP]
> For an example of a project and solution created from scratch, complete with step-by-step instructions and sample code, see [Introduction to projects and solutions](../get-started/tutorial-projects-solutions.md).