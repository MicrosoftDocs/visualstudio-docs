---
title: Learn about Solution Explorer
description: Use Solution Explorer in Visual Studio and review the context menu options to manage the projects and files in a solution.
ms.date: 10/18/2024
ms.topic: conceptual
helpviewer_keywords:
- solution explorer [Visual Studio]
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Learn about Solution Explorer

You can use Solution Explorer to manage the projects and files within a solution. This article describes the Solution Explorer user interface (UI) in detail, and how to open Solution Explorer if you inadvertently close it. The article also describes how you can use right-click context menu in Solution Explorer to quickly add new files, folders, and code elements to a project.

## Open Solution Explorer

By default, the Solution Explorer tool window appears as a pane in the upper-right side of the Visual Studio [integrated development environment](../get-started/visual-studio-ide.md) (IDE). If you don't see the Solution Explorer tool window, you can open it from the Visual Studio menu bar by using **View** > **Solution Explorer**, or by selecting <kbd>Ctrl</kbd>+<kbd>Alt</kbd>+<kbd>L</kbd>.

:::image type="content" source="media/visual-studio-integrated-development-environment.png" alt-text="Screenshot of the Visual Studio IDE that shows where Solution Explorer is positioned." lightbox="media/visual-studio-integrated-development-environment.png":::

## Solution Explorer UI

Let's take a look at the Solution Explorer tool window and its UI (user interface). We'll start with an annotated screenshot of an open C# console solution that has two projects.

:::image type="content" source="media/solution-explorer-tool-window-sml.png" alt-text="An annotated screenshot of the Solution Explorer tool window in Visual Studio." lightbox="media/solution-explorer-tool-window-lrg.png":::

The following table is a text-equivalent of the annotated screenshot, but with a few handy links you can use to learn more.

|UI element  |Action  |
|----------------------|---------|
|[**Toolbar**](#solution-explorer-toolbar) | Control how your files appear |
|[**Search** bar](#solution-explorer-search-bar) | Search for specific files and file types |
|**Main** window | View and manage your files, projects, & solutions |
|[**Solution** node](#solution-node-menu-options) | Manage your solution(s) |
|[**Project** node](#project-node-menu-options)| Manage your project(s) |
|**Dependencies** node | Manage your solution & project dependencies |
|**Program** node |  View, edit, and manage your program or application (app) |
|[**Git Changes** tab](../version-control/git-with-visual-studio.md) |  Use Git & GitHub within Visual Studio to collaborate on projects with your team |

To view more of the application images and icons that appear in Visual Studio, download the [Visual Studio Image Library](https://www.microsoft.com/download/details.aspx?id=35825).

### Solution Explorer toolbar

To continue, let's take a closer look at the toolbar in Solution Explorer.

:::image type="content" source="media/solution-explorer-toolbar.png" alt-text="Screenshot of the Solution Explorer toolbar in Visual Studio.":::

The toolbar contains the following UI elements, from left to right:

|UI element  |Action |
|---------|---------|
|**Back** button | Toggle between search results |
|**Forward** button | Toggle between search results |
|**Home** button |  Return to the default view |
|**Switch Views** button | Switch between the default Solution view and the optional Folder view |
|**Pending Changes Filter** button & drop-down menu | View open files or files with pending changes |
|**Sync with Active Document** button | Locate a file from the code editor |
|**Refresh** button (conditional) | Appears only when you select a dependency, such as a function or a package |
|**Collapse All** button | Collapse the file view in the main window |
|**Show All Files** button | View all files, including [unloaded projects](filtered-solutions.md#toggle-unloaded-project-visibility) |
|**Properties** button | View and change settings for specific files and components |
|**Preview Selected Items** button |  View a selected file or component in the code editor |

### Solution Explorer search bar

Let's take a closer look at the search bar in Solution Explorer.

You can use the dropdown in the search bar and select from the **Search options**: **Search within file contents** and **Search within external items**, to scope your search.

:::image type="content" source="media/vs-2022/use-solution-explorer/solution-explorer-search-bar.png" alt-text="Screenshot of the Solution Explorer search bar and search options in Visual Studio.":::

## Solution Explorer context menu

In Solution Explorer, there are several options that you can interact with by using the right-click context menu. The  context-specific options that appear depend on whether you select a **Solution** node or a **Project** node.

### Solution node menu options

The following screenshot for a C# console app shows the context menu options that appear when you right-click the **Solution** node.

:::image type="content" source="media/solution-node-context-menu-sml.png" alt-text="Screenshot of the right-click context menu from a solution node in Solution Explorer." lightbox="media/solution-node-context-menu-lrg.png":::

What you see in the context menu from the **Solution** node also depends on your project type, programming language, or platform. The following screenshot highlights the following extra options for a C# app: **Project Dependencies**, **Project Build Order**, **Set Startup Projects**, and a **Git** fly-out menu. These extra options typically appear when you add another project to a solution and then add it to a repo.

:::image type="content" source="media/solution-node-context-menu-extra-items-sml.png" alt-text="Screenshot of the right-click context menu from a solution node in Solution Explorer, which shows extra options." lightbox="media/solution-node-context-menu-extra-items-lrg.png":::

### Project node menu options

The following screenshot for a C# console app shows the context menu options that appear when you right-click the **Project** node.

:::image type="content" source="media/project-node-context-menu-sml.png" alt-text="Screenshot of the right-click context menu from a project node in Solution Explorer." lightbox="media/project-node-context-menu-lrg.png":::

What you see in the context menu from the **Project** node also depends on your project type, programming language, or platform. The following screenshot highlights the following extra option for a C# app: a **Build Dependencies** fly-out menu. Extra options typically appear when you add another project to a solution and then add it to a repo.

:::image type="content" source="media/project-node-context-menu-extra-items-sml.png" alt-text="Screenshot of the right-click context menu from a project node in Solution Explorer, which shows an extra option." lightbox="media/project-node-context-menu-extra-items-lrg.png":::

## The Add menu

In the Solution Explorer context menu, one of the most useful options is the **Add** fly-out menu. From it, you can [add another project](../get-started/csharp/tutorial-console-part-2.md#add-another-project) to a solution. You can also add an item to a project, and more.

:::image type="content" source="media/solution-explorer-context-menu-add-flyout.png" alt-text="Screenshot of the Add fly-out menu from the right-click context menu in Solution Explorer." lightbox="media/solution-explorer-context-menu-add-flyout.png":::

You can view the **Add** fly-out menu from either the **Solution** node, the **Project** node, or the **Dependencies** node. The options vary, depending on which node you use.

For a tutorial that walks you through how to add items and projects by using the context menu in Solution Explorer, see the [Introduction to projects and solutions](../get-started/tutorial-projects-solutions.md#add-an-item-to-the-project) page.

::: moniker range=">=vs-2022"

## The Quick Add dialog

Starting with the Visual Studio 2022 version [17.5](/visualstudio/releases/2022/release-notes-v17.5) release, you can use the Quick Add dialog to create an empty file or a simple C# class. In Solution Explorer, right-click on a folder or project and then select **Add** > **New Item**. Or, if you prefer, use the <kbd>Ctrl</kbd>+<kbd>Shift</kbd>+<kbd>A</kbd> keyboard shortcut.

:::image type="content" source="media/vs-2022/quick-add-new-item.png" alt-text="Screenshot of the new Quick Add dialog in Visual Studio.":::

With Quick Add, you can perform the following tasks.

- Add a new file without browsing through the template list. <br> Example: *MyClass.cs*
- Create nested folders in a single operation. <br> Example: *Folder1/Folder2/*, *Folder1/Folder2/MyFile.cs*
- Add files with any extension, or with no extension at all. <br> Example: *File.MyExtension*, *README*, *.gitignore*
  - Quick Add populates a default extension for you, but you can select Escape (**Esc**) after you open the dialog to quickly clear the input box.
- Add multiple files at one time. <br> Example: *File1.cs*, *File2.html* or *File.cs, File.txt*.

You can also quickly switch between the Quick Add dialog and New Item dialog. Here's how.

- Use **Show All Templates** to open the **New Item** dialog.

    :::image type="content" source="media/vs-2022/quick-add-show-all-templates.png" alt-text="Screenshot of the Quick Add dialog with the Show All Templates button highlighted for emphasis.":::

- Use **Show Compact View** to open the **Quick Add** dialog.

    :::image type="content" source="media/vs-2022/quick-add-show-compact-view.png" alt-text="Screenshot of the Quick Add dialog class selection picker with the Show Compact View button highlighted for emphasis.":::

Visual Studio remembers your choice so that you get the experience that best suits your needs. If you'd like to return to the default Quick Add dialog, select <kbd>Shift</kbd>+<kbd>F2</kbd>.

> [!TIP]
> You can configure the [keyboard shortcuts](default-keyboard-shortcuts-in-visual-studio.md) for the **Project.AddNewItem** command and the **AddQuickFile** command from **Tools** > **Options** > **Environment** > **Keyboard**.

## The file comparison tool

Starting with the Visual Studio 2022 version [17.7](/visualstudio/releases/2022/release-notes-v17.7) release, you can now select two files in Solution Explorer and compare them by using the new **Compare With** and **Compare Selected** options.

:::image type="content" source="media/vs-2022/file-comparison.png" alt-text="Screenshot of the file comparison tool from the right-click context menu in Solution Explorer." lightbox="media/vs-2022/file-comparison.png":::

You can compare files in the following ways: 

- Right-click a single file, select **Compare With…** from the context menu, which opens File Explorer. Then, navigate to any file and select it for comparison.
- Multi-select two files by holding down the **Ctrl** button. Then, right-click and select **Compare Selected** from the context menu.

No matter which way you choose to compare your files, the file comparison tool should make it easier to compare your files without having to leave your IDE.

## The Collapse All Descendants command

Also included with the Visual Studio 2022 version [17.7](/visualstudio/releases/2022/release-notes-v17.7) release is the **Collapse All Descendants** command. This command recursively collapses all nodes under a selection so that you can tidy up deeply nested hierarchies as you navigate your project structure. 

:::image type="content" source="media/vs-2022/solution-explorer-collapse-descendants.png" alt-text="Screenshot of the Collapse All Descendants command from the right-click context menu in Solution Explorer.":::

You can find the **Collapse All Descendants** command on the right-click context menu for any item in Solution Explorer that has descendants. You can also press **Ctrl**+**Left Arrow** to use the command.

::: moniker-end

## New Solution Explorer View

You can use the **New Solution Explorer View** to add a new scoped Solution Explorer view. In the Solution Explorer, right-click on the folder you want to set as the root folder of the new view and then select **New Solution Explore View** from the context menu. A new Solution Explorer window appears that you can dock or float as needed.

:::image type="content" source="media/vs-2022/solution-explorer-view.png" alt-text="Screenshot of the New Solution Explorer View from the right-click context menu in Solution Explorer.":::

## Related content

- [What are solutions and projects in Visual Studio?](solutions-and-projects-in-visual-studio.md)
- [What is the .NET Project Designer?](reference/project-properties-reference.md)
- [Customize window layouts and personalize tabs in Visual Studio](customizing-window-layouts-in-visual-studio.md)
- [Visual Studio Image Library](https://www.microsoft.com/download/details.aspx?id=35825)
