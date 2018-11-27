---
title: Load a subset of projects
ms.date: 12/04/2018
ms.topic: conceptual
ms.prod: visual-studio-dev16
ms.technology: vs-ide-general
helpviewer_keywords:
 - "filtered solution"
 - "solution filtering"
author: gewarre
ms.author: stsu
manager: douge
---
# Filtered solutions in Visual Studio

**New in Visual Studio 2019 preview 1**

Use solution filtering to more quickly open large solutions that contain many projects. Solution filtering improves solution-load performance in the following ways:

- You can get to code faster by opening a solution without loading any of its projects, and then selectively choosing which projects to load.

- When you reopen a solution locally, Visual Studio remembers which projects were loaded in the previous session.

- You can save one or more project-load configurations or share a configuration with teammates by creating a solution filter file.

## Open a filtered solution

To open a solution with only some of its projects loaded, follow these steps:

1. Choose **File** > **Open** > **Project/Solution** from the menu bar.

2. In the **New Project** dialog, select the solution, and then select **Do not load projects**.

   ![Visual Studio Open Project dialog with do not load projects checked](media/filtered-solutions/do-not-load-projects.png)

3. Choose **Open**.

   The solution opens with all of its projects unloaded.

4. In **Solution Explorer**, select the projects you want to load (press **Ctrl** while clicking to select more than one project), and then right-click on the project and choose **Reload Project**.

   ![Reload multiple projects in Visual Studio Solution Explorer](media/filtered-solutions/reload-project.png)

   Visual Studio will remember which projects are loaded the next time you open the solution locally.

## Toggle which projects are visible

You can toggle to see either all the projects in the solution or just the loaded ones. Do one of the following actions in **Solution Explorer**:

- Right-click on your solution and select **Show Unloaded Projects** or **Hide Unloaded Projects**.

- Select the **Show All Files** button.

   ![Show All Files button in Visual Studio Solution Explorer](media/filtered-solutions/show-all-files.PNG)

## Solution filter files

If you want to share your project-load configuration or commit it to source control, you can create a solution filter file (it has the extension *.slnf*). When you open this file, the solution opens in Visual Studio with the specified projects loaded and all unloaded projects hidden. You can toggle to view the unloaded projects.

Solution filter files are visually differentiated from regular solution files by the additional funnel glyph in the icon next to the solution in **Solution Explorer**. The name of the filter and the number of loaded projects are also shown next to the solution name.

![Solution filter file open in Visual Studio Solution Explorer](media/filtered-solutions/solution-filter.PNG)

> [!NOTE]
> If new projects are added to the original solution after you create the solution filter file, they appear as unloaded projects in **Solution Explorer**.

To create a solution filter file:

1. In **Solution Explorer**, right-click on the solution and select **Save As Solution Filter**.

   ![Save As Solution Filter menu in Visual Studio Solution Explorer](media/filtered-solutions/save-as-solution-filter.png)

2. Choose a name and location for the solution filter file.

   The solution filter file is added to your **Recent Projects and Solutions** list.

   ![Open recent in Visual Studio](media/filtered-solutions/open-recent.png)

## See also

- [Customize file nesting in Solution Explorer](file-nesting-solution-explorer.md)
- [Optimize Visual Studio performance](optimize-visual-studio-performance.md)