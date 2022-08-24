---
title: Learn about Solution Explorer
description: Learn how you can use the Solution Explorer tool window in Visual Studio to create & manage your files, projects, and solutions.
ms.date: 08/24/2022
ms.topic: conceptual
ms.custom: contperf-fy22q4
helpviewer_keywords:
- solution explorer [Visual Studio]
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Learn about Solution Explorer

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

You can use Solution Explorer to create & manage your solutions and projects and to view & interact with your code. In this article, we'll cover how to open Solution Explorer if you inadvertently close it. Then, we'll describe the Solution Explorer user interface (UI) in detail.

## Open Solution Explorer

By default, the Solution Explorer tool window appears as a pane in the upper-right side of the Visual Studio [integrated development environment](../get-started/visual-studio-ide.md) (IDE). If you don't see the Solution Explorer tool window, you can open it from the Visual Studio menu bar by using **View** > **Solution Explorer**, or by pressing **Ctrl**+**Alt**+**L**.

:::image type="content" source="media/visual-studio-integrated-development-environment.png" alt-text="Screenshot of the Visual Studio IDE that shows where Solution Explorer is positioned." lightbox="media/visual-studio-integrated-development-environment.png":::

## Solution Explorer tool window

Let's take a look at the Solution Explorer tool window and its UI (user interface). We'll start with an annotated screenshot of an open C# console solution that has two projects.

:::image type="content" source="media/solution-explorer-tool-window.png" alt-text="An annotated screenshot of the Solution Explorer tool window in Visual Studio." lightbox="media/solution-explorer-tool-window.png":::

The following table is a text-equivalent of the annotated screenshot, but with a few handy links you can use to learn more.

|UI element  |Action  |
|----------------------|---------|
|[**Menu** bar](#solution-explorer-menu-bar) | Control how your files appear |
|**Search** bar | Search for specific files and file types |
|**Main** window | View and manage your files, projects, & solutions |
|[**Solution** node](#solution-node-context-menu-options) | Manage your solution(s) |
|[**Project** node](#project-node-context-menu-options) | Manage your project(s) |
|**Dependencies** node | Manage your solution & project dependencies |
|**Program** node |  View, edit, and manage your program or application (app) |
|[**Git Changes** tab](../version-control/git-with-visual-studio.md) |  Use Git & GitHub within Visual Studio to collaborate on projects with your team |

## Solution Explorer menu bar

To continue, let's take a closer look at the menu bar in Solution Explorer.

:::image type="content" source="media/solution-explorer-menu-bar.png" alt-text="Screenshot of the Solution Explorer menu bar in Visual Studio." lightbox="media/solution-explorer-menu-bar.png":::

The menu bar contains the following UI elements, from left to right:

|UI element  |Action |
|---------|---------|
|**Back** button | Toggle between search results |
|**Forward** button | Toggle between search results |
|**Home** button |  Return to the default view |
|**Switch Views** button |  Switch between solutions and available views |
|**Pending Changes Filter** button & drop-down menu |  View open files or files with pending changes |
|**Sync with Active Document** button | Locate a file from the code editor |
|**Refresh** button (conditional) | Appears only when you select a dependency, such as a function or a package |
|**Collapse All** button | Collapse the file view in the main window |
|**Show All Files** button | View all files, including [unloaded projects](filtered-solutions.md#toggle-unloaded-project-visibility) |
|**Properties** button | View and change settings for specific files and components |
|**Preview Selected Items** button |  View a selected file or component in the code editor |

## Solution Explorer context menu

In Solution Explorer, there are several options that you can interact with by using the right-click context menu. The  context-specific options that appear depend on whether you select a **Solution** node or a **Project** node.

### Solution node context menu options

The following screenshot for a C# console app shows the context menu options that appear when you right-click the **Solution** node.

:::image type="content" source="media/solution-node-context-menu-sml.png" alt-text="Screenshot of the right-click context menu from a solution node in Solution Explorer." lightbox="media/solution-node-context-menu-lrg.png":::

What you see in the context menu from the **Solution** node also depends on your project type, programming language, or platform. The following screenshot highlights the following extra options for a C# app: **Project Dependencies**, **Project Build Order**, **Set Startup Projects**, and a **Git** fly-out menu. These extra options typically appear when you add another project to a solution and then add it to a repo.

:::image type="content" source="media/solution-node-context-menu-extra-items-sml.png" alt-text="Screenshot of the right-click context menu from a solution node in Solution Explorer, which shows extra options." lightbox="media/solution-node-context-menu-extra-items-lrg.png":::

### Project node context menu options

The following screenshot for a C# console app shows the context menu options that appear when you right-click the **Project** node.

:::image type="content" source="media/project-node-context-menu-sml.png" alt-text="Screenshot of the right-click context menu from a project node in Solution Explorer." lightbox="media/project-node-context-menu-lrg.png":::

What you see in the context menu from the **Project** node also depends on your project type, programming language, or platform. The following screenshot highlights the following extra option for a C# app: a **Build Dependencies** fly-out menu. Extra options typically appear when you add another project to a solution and then add it to a repo.

:::image type="content" source="media/project-node-context-menu-extra-items-sml.png" alt-text="Screenshot of the right-click context menu from a project node in Solution Explorer, which shows an extra option." lightbox="media/project-node-context-menu-extra-items-lrg.png":::

## The Add context menu fly-out

In the Solution Explorer context menu, one of the most useful options is the **Add** fly-out menu. From it, you can [add another project](../get-started/csharp/tutorial-console-part-2.md#add-another-project) to a solution. You can also add an item to a project, and more.

:::image type="content" source="media/solution-explorer-context-menu-add-flyout.png" alt-text="Screenshot of the Add fly-out menu from the right-click context menu in Solution Explorer." lightbox="media/solution-explorer-context-menu-add-flyout.png":::

You can view the **Add** fly-out menu from either the **Solution** node, the **Project** node, or the **Dependencies** node. The options vary, depending on which node you use.

For a tutorial that walks you through how to add items and projects by using the context menu in Solution Explorer, see the [Introduction to projects and solutions](../get-started/tutorial-projects-solutions.md#add-an-item-to-the-project) page.

## See also

- [What are solutions and projects in Visual Studio?](solutions-and-projects-in-visual-studio.md)
- [What is the .NET Project Designer?](reference/project-properties-reference.md)
- [Customize window layouts and personalize tabs in Visual Studio](customizing-window-layouts-in-visual-studio.md)
