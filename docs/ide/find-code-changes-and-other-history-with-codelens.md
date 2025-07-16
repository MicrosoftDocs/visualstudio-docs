---
title: Find code changes and other history with CodeLens
description: Explore CodeLens in Visual Studio and learn how to use the tool to explore the history of your code without having to leave the editor.
ms.date: 12/20/2024
ms.topic: how-to
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.All_Languages.CodeLens
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a developer, I want to use CodeLens in Visual Studio so I can explore the history of my code directly in the code editor.
---

# Find code changes and other history with CodeLens

::: moniker range=">=vs-2022"

Visual Studio CodeLens helps you stay focused on your work while you find out what happened to your code - all without leaving the Interactive Development Environment (IDE) code editor. You can find references to a piece of code, changes to your code, linked bugs, Azure DevOps work items, code reviews, and unit tests.

> [!NOTE]
> CodeLens is available in the Community edition of Visual Studio, but the *source control* indicators aren't available in this edition.

CodeLens can show you both where and how the individual parts of your code are used in your solution:

:::image type="content" source="./media/vs-2022/codelens-overview.png" border="false" alt-text="Screenshot of CodeLens indicators in the Visual Studio code editor." lightbox="./media/codelens-overview.png":::

View details about user's code changes, and use the right-click **Send email to \<user>** option to contact users without leaving the code editor:

:::image type="content" source="./media/vs-2022/codelens-contact-info.png"  border="false" alt-text="Screenshot that shows how to view details about changes made by your team members in CodeLens for Visual Studio.":::

To choose the indicators that you want to see, or to turn CodeLens off and on, go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

## Keyboard shortcuts in Visual Studio 2022

Many of the operations described in the following sections are available by using keyboard shortcuts in the Visual Studio code editor window.

To use the keyboard to select indicators, select and hold the **Alt** key to display the related number keys, then select the number on the keyboard that corresponds to the desired indicator:

:::image type="content" source="./media/vs-2022/codelens-alt-keys.png" alt-text="Screenshot that shows the CodeLens keyboard access numbers in Visual Studio.":::

> [!NOTE]
> To select the **reviews** indicator, select **Alt** while using the **left arrow** and **right arrow key** to browse.

## Find references to your code

You can find references in C# or Visual Basic code.

1. In the code editor, select the **references** indicator or use the **Alt**+**2** keyboard shortcut:

   :::image type="content" source="./media/vs-2022/codelens-view-references.png"  border="false" alt-text="Screenshot that shows how to select the CodeLens references option in Visual Studio.":::

   > [!NOTE]
   > If the indicator shows **0 references**, you don't have any references from your C# or Visual Basic code. However, there might be references in other project items such as *.xaml* and *.aspx* files.

1. To view the referencing code, hover over the reference in the list.

   :::image type="content" source="./media/vs-2022/codelens-peek-reference.png"  border="false" alt-text="Screenshot that shows how to see the file with the reference by using CodeLens - Peek reference for Visual Studio.":::

1. To open the file that contains the reference, double-click the reference.

### Create a code map

To see relationships between the code and its references, you can [create a code map](../modeling/map-dependencies-across-your-solutions.md). In the **Code Map** toolbar, expand the **Show Related** dropdown menu and select **Find All References**:

:::image type="content" source="./media/vs-2022/codelens-references-map.png" border="false" alt-text="Screenshot that shows how to create a map of all references to specific code by using CodeLens in Visual Studio." lightbox="./media/vs-2022/codelens-references-map.png":::

## Find changes in your code

Inspect your code's history to find out what happened to your code. Or, review changes before they're merged into your code so you can better understand how changes in other branches might affect your code.

You need:

- Visual Studio [Enterprise](https://visualstudio.microsoft.com/vs/compare/) or Visual Studio [Professional](https://visualstudio.microsoft.com/vs/compare/)

- [Git](https://git-scm.com/) or [Azure DevOps Server](/azure/devops/server/whats-new?view=azure-devops-2022&preserve-view=true) (formerly [Team Foundation Server](/azure/devops/server/tfs-is-now-azure-devops-server?view=azure-devops&preserve-view=true)) or [Team Foundation Version Control (TFVC)](/azure/devops/repos/tfvc/what-is-tfvc?view=azure-devops&preserve-view=true)

For C# (*.cs*) or Visual Basic (*.vb*) code stored with TFVC or Git, CodeLens details are visible at the class and method levels (*code element-level* indicators) within the file:

:::image type="content" source="./media/vs-2022/codelens-element-level-indicators.png" border="false" alt-text="Screenshot that shows code element-level indicators for team contributions in CodeLens for Visual Studio.":::

For file types other than *.cs* or *.vb*, the **Show file level Codelens indicator** option lets you view CodeLens details for the entire file. The *file-level* indicators are displayed at the bottom of the file in the code editor:

:::image type="content" source="./media/vs-2022/codelens-file-level-indicators.png" border="false" alt-text="Screenshot that shows file-level indicators for team contributions in CodeLens for Visual Studio.":::

### Code element-level indicators

Code element-level indicators let you see who changed your code and what changes they made. Code element-level indicators are available for C# and Visual Basic code.

You can also view change history when you use TFVC or Azure DevOps Services:

:::image type="content" source="./media/vs-2022/codelens-code-changes.png" border="false" alt-text="Screenshot that shows the change history data for your code in CodeLens for Visual Studio.":::

The default time period is the last 12 months (one year). 

To see a detailed history of all the changes, including those changes from more than a year ago, select **Show all file changes**, which opens a **History** window. From the **History** window, you can view all your files that are in a Git repository, and select the code element-level changes indicator for more details:

:::image type="content" source="./media/vs-2022/codelens-code-changes-git.png" border="false" alt-text="Screenshot that shows the CodeLens change history for code in a GitHub repository in Visual Studio.":::

### File-level indicators

You can also find changes for an entire file with file-level indicators at the bottom of the window in the code editor.

> [!NOTE]
> File-level indicators aren't available for C# and Visual Basic files.

To get more details about a change, right-click the item. Depending on whether you're using TFVC or Git, there are options to compare the versions of the file, view details and track the changeset, get the selected version of the file, and email the author of that change. Some of the details appear in **Team Explorer** when enabled; otherwise, the details appear in the **Git Changes** pane. You might also see the details on the horizontal scrollbar at the bottom of the code editor.

The indicators show who changed your code over time, which can help you find patterns in your team's changes and assess their impact:

:::image type="content" source="./media/vs-2022/codelens-element-level-indicators.png" border="false" alt-text="Screenshot that shows code element-level indicators for team contributions as a graph in CodeLens for Visual Studio.":::

Starting in Visual Studio 2022 version 17.12 Preview 2, you can show or hide file-level indicators on the code editor horizontal scrollbar with the **Tools > Options > Text Editor > Advanced** > **Show file level CodeLens indicator** option. This option updates visibility for file types that implement the file-level CodeLens control in the bottom editor scrollbar, such as XAML, HTML, and CSS. The option doesn't affect files that contain inline CodeLens (C# and VB).

### Find changes in your current branch

Your team might have multiple branches, such as a main branch and a child development branch, to reduce the risk of breaking stable code.

:::image type="content" source="./media/codelens-first-branch-conceptual.png" border="false" alt-text="Diagram that depicts changes from the current branch and a child branch with CodeLens.":::

You can discover how many contributors changed your code and how many changes were made in the main branch by selecting the **Alt**+**0** keyboard shortcut

### Find when your code was branched

To find when your code was branched, browse to your code in the child branch. Then, select the **changes** indicator (or select **Alt**+**0**):

:::image type="content" source="./media/vs-2022/codelens-first-branch.png" border="false" alt-text="Screenshot that shows how to discover when your code was branched with CodeLens in Visual Studio.":::

### Find incoming changes from other branches

:::image type="content" source="./media/codelens-branch-change-checkin-conceptual.png" border="false" alt-text="Diagram that demonstrates how you can find code changes in other branches with CodeLens in Visual Studio.":::

You can view incoming changes and you don't need to leave your current branch to review a change. 

### Find when changes got merged

You can see when changes got merged, so you can determine which changes are included in your branch.

:::image type="content" source="./media/codelens-branch-merged-conceptual.png" border="false" alt-text="Diagram that demonstrates how to discover when changes got merged with CodeLens in Visual Studio.":::

### Compare an incoming change with your local version

To compare an incoming change with your local version, double-click the changeset or select **Shift** + **F10**.

### Branch icons

The icon in the **Branch** column indicates how the branch is related to the branch you're working in.

| Icon | The change came from |
| --- | --- |
| :::image type="icon" source="./media/codelens-branch-current-icon.png":::            | The current branch |
| :::image type="icon" source="./media/codelens-branch-parent-icon.png":::             | The parent branch |
| :::image type="icon" source="./media/codelens-branch-child-icon.png":::              | A child branch |
| :::image type="icon" source="./media/codelens-branch-peer-icon.png":::               | A peer branch |
| :::image type="icon" source="./media/codelens-branch-further-away-icon.png":::        | A branch further away than a parent, child, or peer |
| :::image type="icon" source="./media/codelens-branch-merge-from-parent-icon.png":::    | A merge from the parent branch to a child branch |
| :::image type="icon" source="./media/codelens-branch-merge-from-child-icon.png":::     | A merge from a child branch to the parent branch |
| :::image type="icon" source="./media/codelens-branch-merge-from-unrelated-icon.png"::: | A merge from an unrelated branch (baseless merge) |

## Linked work items

Find linked work items by selecting the **work items** indicator or use the **Alt**+**8** keyboard shortcut.

## Linked code reviews

Find linked code reviews by selecting the **reviews** indicator. To use the keyboard, hold down the **Alt** key and then select **Left Arrow** or **Right Arrow** to browse the indicator options.

## Linked bugs

Find linked bugs by selecting the **bugs** indicator or use the **Alt** + **7** keyboard shortcut.

## Contact the owner of an item

Find the author of an item by selecting the **authors** indicator or use the **Alt** + **5** keyboard shortcut.

You can also open the shortcut menu for an item to see the contact options. (If you have Teams installed, you have other communication options available to you.) 

## Associated unit tests

You can discover unit tests that exist for your C# or Visual Basic code without opening **Test Explorer**.

1. Go to some application code with associated [unit test code](../test/unit-test-your-code.md).

1. As needed, build your application to load the CodeLens test indicators.

1. Review the tests for the code use the **Alt** + **3** keyboard shortcut.

1. If you see the **Warning** icon :::image type="icon" source="./media/codelens-test-warning-icon.png":::, the tests haven't run yet, so run them.

1. To review a test's definition, double-click the test item in the CodeLens indicator window and open the code file in the editor.

1. To review the test's results, choose the test status **Failed** or **Passed** indicator (:::image type="icon" source="./media/codelens-test-failed-icon.png"::: or :::image type="icon" source="./media/codelens-test-passed-icon.png":::) or use the **Alt**+**1** keyboard shortcut.

1. To see how many contributors changed this test, who changed this test, or how many changes were made to this test, [find your code's history](#find-changes-in-your-code) and linked items.

## Q & A

### Q: How do I turn CodeLens off or on or choose which indicators to see?

**A:**  You can turn indicators off or on, except for the references indicator. Go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

When the indicators are turned on, you can also open the CodeLens options from the indicators. And, you can turn CodeLens file-level indicators on and off by using the chevron icons at the bottom of the editor window.

### Q: Where is CodeLens?

**A:** CodeLens appears in C# and Visual Basic code at the method, class, indexer, and property level. CodeLens appears at the file level for all other types of files.

- Make sure CodeLens is turned on. Go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

- Azure DevOps-related indicators appear only when work items are linked to the code and when you have permissions to open linked work items. Confirm that you have [team member permissions](/azure/devops/organizations/security/view-permissions?view=vsts&preserve-view=true).

- Unit test indicators don't appear when application code doesn't have unit tests. Test status indicators appear automatically in test projects. If you know that your application code has unit tests, but the test indicators don't appear, try building the solution (**Ctrl** + **Shift** + **B**).

> [!TIP]
> CodeLens is available in Visual Studio Community edition, however, the *source control* indicators are not available in this edition.

### Q: Why don't I see the work item details for a commit?

**A:** This scenario might happen because CodeLens can't find the work items in Azure Boards. Check that you're connected to the project that has those work items, and that you have permissions to see those work items. Work item details might also not show if the commit description has incorrect information about the work item IDs in Azure Boards.

### Q: How do I change the font and color for CodeLens?

**A:** Go to **Tools** > **Options** > **Environment** > **Fonts and Colors**.

:::image type="content" source="./media/vs-2022/codelens-options-fonts-colors-settings.png" border="false" alt-text="Screenshot that shows how to change font and color settings for CodeLens in Visual Studio.":::

To use the keyboard:

1. Select **Alt** + **T** + **O** to open the **Options** dialog.

1. Select the **Up Arrow** or **Down Arrow** to go to the **Environment** node, then select the **Left Arrow** to expand the node.

1. Select the **Down Arrow** to go to **Fonts and Colors**.

1. Select **Tab** to go to the **Show settings for** list, and then select the **Down Arrow** to select **CodeLens**.

### Q: Can I move the CodeLens heads-up display?

**A:** Yes, choose the **Dock** icon :::image type="icon" source="./media/codelens-dock-window.png"::: to dock CodeLens as a window.

### Q: How do I refresh the indicators?

**A:** The refresh process is different depending on the indicator:

- **References**: This indicator updates automatically when the code changes. If the **References** indicator is docked as a separate window, refresh the indicator by selecting **Refresh**.

- **Team**: Refresh these indicators by selecting **Refresh CodeLens Team Indicators** from the right-click menu.

- **Test**: [Find unit tests for your code](#associated-unit-tests) to refresh the **Test** indicator.

### Q: What's "Local Version"?

**A:** The **Local Version** arrow points at the most recent changeset in your local version of a file. When the server has more recent changesets, they appear before or after the **Local Version** arrow, depending on the order used to sort the changesets.

### Q: My CodeLens test indicators no longer appear in my file when I first open my solution. How can I load them?

**A:** Rebuild your project to get CodeLens test indicators to load in your file. To improve performance, Visual Studio no longer fetches source information for test indicators when code files are loaded. Test indicators are loaded after a build, or when you navigate to a test by double-clicking on it in **Test Explorer**.

## Related content

- [About Git version control in Visual Studio](../version-control/git-with-visual-studio.md)
- [Features of the code editor](./writing-code-in-the-code-and-text-editor.md)

::: moniker-end
::: moniker range="vs-2019"

Visual Studio CodeLens helps you stay focused on your work while you find out what happened to your code - all without leaving the Interactive Development Environment (IDE) code editor. You can find references to a piece of code, changes to your code, linked bugs, code reviews, and unit tests.

> [!NOTE]
> CodeLens is available in the Community edition of Visual Studio, but the *source control* indicators aren't available in this edition.

CodeLens can show you both where and how the individual parts of your code are used in your solution.

:::image type="content" source="./media/vs-2019/codelens-overview.png" alt-text="Screenshot of CodeLens indicators in the Visual Studio 2019 code editor.":::

Contact your team about changes to your code without leaving the editor:

:::image type="content" source="./media/vs-2019/codelens-contact-info.png" alt-text="Screenshot that shows how to contact your team in CodeLens for Visual Studio 2019.":::

To choose the indicators that you want to see, or to turn CodeLens off and on, go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

## Keyboard shortcuts in Visual Studio 2019

Many of the operations described in the following sections are available by using keyboard shortcuts in the Visual Studio code editor window.

To use the keyboard to select indicators, select and hold the **Alt** key to display the related number keys, then select the number on the keyboard that corresponds to the desired indicator:

:::image type="content" source="./media/vs-2019/codelens-alt-keys.png" alt-text="Screenshot that shows the CodeLens keyboard access numbers in Visual Studio 2019.":::

> [!NOTE]
> To select the **reviews** indicator, select **Alt** while using the **Left Arrow** and **Right Arrow key** to browse.

## Find references to your code in Visual Studio

You can find references in C# or Visual Basic code.

1. In the code editor, select the **references** indicator or use the **Alt** + **2** keyboard shortcut:

   :::image type="content" source="./media/vs-2019/codelens-view-references.png" alt-text="Screenshot that shows how to select the CodeLens references option in Visual Studio 2019.":::

   > [!NOTE]
   > If the indicator shows **0 references**, you don't have any references from your C# or Visual Basic code. However, there might be references in other project items such as *.xaml* and *.aspx* files.

1. To view the referencing code, hover over the reference in the list.

   :::image type="content" source="./media/vs-2019/codelens-peek-reference.png" alt-text="Screenshot that shows how to see the file with the reference by using CodeLens - Peek reference for Visual Studio 2019.":::

1. To open the file that contains the reference, double-click the reference.

### Code maps

To see relationships between the code and its references, [create a code map](../modeling/map-dependencies-across-your-solutions.md?view=vs-2019&preserve-view=true). In the code map shortcut menu, select **Show All References**.

:::image type="content" source="./media/vs-2019/codelens-references-map.png" alt-text="Screenshot that shows how to create a code map of references by using CodeLens in Visual Studio 2019.":::

## Find changes in your code

Inspect your code's history to find out what happened to your code. Or, review changes before they're merged into your code so you can better understand how changes in other branches might affect your code.

You need:

- Visual Studio [Enterprise](https://visualstudio.microsoft.com/vs/compare/) or Visual Studio [Professional](https://visualstudio.microsoft.com/vs/compare/)

- [Git](https://git-scm.com/) or [Azure DevOps Server](/azure/devops/server/whats-new?view=azure-devops-2022&preserve-view=true) (formerly [Team Foundation Server](/azure/devops/server/tfs-is-now-azure-devops-server?view=azure-devops&preserve-view=true)) or [Team Foundation Version Control (TFVC)](/azure/devops/repos/tfvc/what-is-tfvc?view=azure-devops&preserve-view=true)

For C# or Visual Basic code stored with TFVC or Git, you get CodeLens details at the class and method levels (*code element-level* indicators). 

:::image type="content" source="./media/vs-2019/codelens-element-level-indicators.png" alt-text="Screenshot that shows code element-level indicators for team contributions in CodeLens for Visual Studio 2019.":::

For file types other than *.cs* or *.vb*, you get CodeLens details for the entire file in one place at the bottom of the window (*file-level* indicators):

:::image type="content" source="./media/vs-2019/codelens-file-level-indicators.png" alt-text="Screenshot that shows file-level indicators for team contributions in CodeLens for Visual Studio 2019.":::

### Code element-level indicators

Code element-level indicators let you see who changed your code and what changes they made. Code element-level indicators are available for C# and Visual Basic code.

You can also view change history when you use TFVC or Azure DevOps Services:

:::image type="content" source="./media/vs-2019/codelens-code-changes.png" alt-text="Screenshot that shows the change history data for your code in CodeLens for Visual Studio 2019.":::

The default time period is the last 12 months (one year). 

To see a detailed history of all the changes, including those changes from more than a year ago, select **Show all file changes**:

:::image type="content" source="./media/vs-2019/codelens-show-all-file-changes.png" alt-text="Screenshot that shows how to select the Show all file changes option in CodeLens for Visual Studio 2019.":::

The **History** window opens:

:::image type="content" source="./media/vs-2019/codelens-code-changes-history.png" alt-text="Screenshot of the history window for the Show all file changes option in CodeLens for Visual Studio 2019.":::

When your files are in a Git repository and you choose the code element-level changes indicator, the **History** window shows the details for the repository commits:

:::image type="content" source="./media/vs-2019/codelens-code-changes-git.png" alt-text="Screenshot that shows the CodeLens change history for code in a GitHub repository in Visual Studio 2019.":::

### File-level indicators

Find changes for an entire file with file-level indicators at the bottom of the window in the code editor:

:::image type="content" source="./media/vs-2019/codelens-file-level.png" alt-text="Screenshot that shows CodeLens details at the file level in Visual Studio 2019.":::

> [!NOTE]
> File-level indicators aren't available for C# and Visual Basic files.

To get more details about a change, right-click the item. Depending on whether you're using TFVC or Git, there are options to compare the versions of the file, view details and track the changeset, get the selected version of the file, and email the author of the change. Some of the details appear in **Team Explorer** in Visual Studio 2019 [version 16.7](/visualstudio/releases/2019/release-notes-v16.7#whats-new-in-visual-studio-2019-version-167/) and earlier. In Visual Studio 2019 [version 16.8](/visualstudio/releases/2019/release-notes-v16.8#whats-new-in-visual-studio-2019-version-168/) and later, the details appear in the **Git Changes** pane.

The indicators show who changed your code over time, which can help you find patterns in your team's changes and assess their impact.

:::image type="content" source="./media/vs-2019/codelens-element-level-indicators.png" alt-text="Screenshot that shows code element-level indicators for team contributions as a graph in CodeLens for Visual Studio 2019.":::

### Find changes in your current branch

Your team might have multiple branches, such as a main branch and a child development branch, to reduce the risk of breaking stable code.

:::image type="content" source="./media/codelens-first-branch-conceptual.png" border="false" alt-text="Diagram that depicts changes from the current branch and a child branch with CodeLens.":::

You can discover how many contributors changed your code and how many changes were made in the main branch by pressing **Alt**+**6**:

:::image type="content" source="./media/codelens-branch-changes.png" alt-text="Screenshot that shows how to discover how many changes are made in the main branch with CodeLens in Visual Studio 2019.":::

### Find when your code was branched

To find when your code was branched, navigate to your code in the child branch. Then, select the **changes** indicator (or press **Alt**+**6**):

:::image type="content" source="./media/vs-2019/codelens-first-branch.png" alt-text="Screenshot that shows how to discover when your code was branched with CodeLens in Visual Studio 2019.":::

### Find incoming changes from other branches

:::image type="content" source="./media/codelens-branch-change-checkin-conceptual.png" border="false" alt-text="Diagram that demonstrates how you can find code changes in other branches with CodeLens in Visual Studio.":::

You can view incoming changes. In the following screenshot, a bug fix was made in the `dev` branch:

:::image type="content" source="./media/codelens-branch-changes-dev.png" alt-text="Screenshot of CodeLens - Change checked into another branch in Visual Studio 2019.":::

You can review the change without leaving your current branch (`main`):

:::image type="content" source="./media/codelens-branch-changes-main.png" alt-text="Screenshot of CodeLens - See incoming change from another branch in Visual Studio 2019.":::

### Find when changes got merged

You can see when changes got merged, so you can determine which changes are included in your branch:

:::image type="content" source="./media/codelens-branch-merged-conceptual.png" border="false" alt-text="Diagram that demonstrates how to discover when changes got merged with CodeLens in Visual Studio.":::

For example, your code in the `main` branch now has the bug fix from the `dev` branch:

:::image type="content" source="./media/codelens-branch-merged.png" alt-text="Screenshot that shows how to view merged changes between branches with CodeLens in Visual Studio 2019.":::

### Compare incoming change with local version

Compare an incoming change with your local version by selecting **Shift**+**F10**, or by double-clicking the changeset.

:::image type="content" source="./media/codelens-branch-incoming-change-menu.png" alt-text="Screenshot of CodeLens - Compare incoming change with local in Visual Studio 2019.":::

### Branch icons

The icon in the **Branch** column indicates how the branch is related to the branch you're working in.

| Icon | The change came from |
| --- | --- |
| :::image type="icon" source="./media/codelens-branch-current-icon.png":::            | The current branch |
| :::image type="icon" source="./media/codelens-branch-parent-icon.png":::             | The parent branch |
| :::image type="icon" source="./media/codelens-branch-child-icon.png":::              | A child branch |
| :::image type="icon" source="./media/codelens-branch-peer-icon.png":::               | A peer branch |
| :::image type="icon" source="./media/codelens-branch-further-away-icon.png":::        | A branch further away than a parent, child, or peer |
| :::image type="icon" source="./media/codelens-branch-merge-from-parent-icon.png":::    | A merge from the parent branch to a child branch |
| :::image type="icon" source="./media/codelens-branch-merge-from-child-icon.png":::     | A merge from a child branch to the parent branch |
| :::image type="icon" source="./media/codelens-branch-merge-from-unrelated-icon.png"::: | A merge from an unrelated branch (baseless merge) |

## Linked work items in Visual Studio 2019

Find linked work items by selecting the **work items** indicator or use the **Alt**+**8** keyboard shortcut:

:::image type="content" source="./media/codelens-work-items.png" alt-text="Screenshot that shows how to find work items for specific code with CodeLens in Visual Studio 2019.":::

## Linked code reviews in Visual Studio 2019

Find linked code reviews by selecting the **reviews** indicator. To use the keyboard, hold the **Alt** key and select the **Left Arrow** or **Right Arrow** to browse the indicator options.

:::image type="content" source="./media/codelens-code-reviews.png" alt-text="Screenshot of CodeLens - View code review requests in Visual Studio 2019.":::

## Linked bugs in Visual Studio 2019

Find linked bugs by selecting the **bugs** indicator or use the  **Alt**+**7** keyboard shortcut:

:::image type="content" source="./media/codelens-bugs-changesets.png" alt-text="Screenshot that shows how to find bugs linked to changesets with CodeLens in Visual Studio 2019.":::

## Contact the owner of an item in Visual Studio 2019

Find the author of an item by selecting the **authors** indicator or use the **Alt**+**5** keyboard shortcut:

:::image type="content" source="./media/codelens-contact-item-owner.png" alt-text="Screenshot that shows how to contact the owner of an item with CodeLens in Visual Studio 2019.":::

Open the shortcut menu for an item to see the contact options. If you have Teams installed, you might see options similar to the following screenshot:

:::image type="content" source="./media/codelens-item-contact-menu.png" alt-text="Screenshot that shows the Contact options for an item with CodeLens in Visual Studio 2019.":::

## Associated unit tests in Visual Studio 2019

You can discover unit tests that exist for your C# or Visual Basic code without opening **Test Explorer**.

1. Go to some application code with associated [unit test code](../test/unit-test-your-code.md).

1. As needed, build your application to load the CodeLens test indicators.

1. Review the tests for the code by selecting the **Alt**+**3** keyboard shortcut:

   :::image type="content" source="./media/codelens-choose-test-indicator.png" alt-text="Screenshot that shows how to choose test status in the code editor with CodeLens in Visual Studio 2019.":::

1. If you see the **Warning** icon :::image type="icon" source="./media/codelens-test-warning-icon.png":::, the tests haven't run yet, so run them.

   :::image type="content" source="./media/codelens-tests-not-yet-run.png" alt-text="Screenshot that shows how to view unit tests not yet run with CodeLens in Visual Studio 2019.":::

1. To review a test's definition, double-click the test item in the CodeLens indicator window and open the code file in the editor:

   :::image type="content" source="./media/codelens-unit-test-definition.png" alt-text="Screenshot that shows how to go to a unit test definition with CodeLens in Visual Studio 2019.":::

1. To review the test's results, choose the test status **Failed** or **Passed** indicator (:::image type="icon" source="./media/codelens-test-failed-icon.png"::: or :::image type="icon" source="./media/codelens-test-passed-icon.png":::) or use the **Alt** + **1** keyboard shortcut:

   :::image type="content" source="./media/codelens-unit-test-result.png" alt-text="Screenshot that shows how to view the unit test result with CodeLens in Visual Studio 2019.":::

1. To see how many contributors changed the test, who changed this test, or how many changes were made to this test, [find your code's history](#find-changes-in-your-code) and linked items.

## Q & A for CodeLens in Visual Studio 2019

### Q: How do I turn CodeLens off or on or choose which indicators to see?

**A:**  You can turn indicators off or on, except for the references indicator. Go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

When the indicators are turned on, you can also open the CodeLens options from the indicators.

:::image type="content" source="./media/codelens-turn-off-on-indicators-from-code.png" alt-text="Screenshot of CodeLens - Turn indicators off or on in Visual Studio 2019.":::

Turn CodeLens file-level indicators on and off using the chevron icons at the bottom of the editor window.

:::image type="content" source="./media/codelens-file-level-on-and-off.png" alt-text="Screenshot of Turn file-level indicators on and off in Visual Studio 2019.":::

### Q: Where is CodeLens?

**A:** CodeLens appears in C# and Visual Basic code at the method, class, indexer, and property level. CodeLens appears at the file level for all other types of files.

- Make sure CodeLens is turned on. Go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

- DevOps-related indicators appear only when work items are linked to the code and when you have permissions to open linked work items. Confirm that you have [team member permissions](/azure/devops/organizations/security/view-permissions?view=vsts&preserve-view=true).

- Unit test indicators don't appear when application code doesn't have unit tests. Test status indicators appear automatically in test projects. If you know that your application code has unit tests, but the test indicators don't appear, try building the solution (**Ctrl**+**Shift**+**B**).

> [!TIP]
> CodeLens is available in Visual Studio Community edition, however, the *source control* indicators are not available in this edition.

### Q: Why don't I see the work item details for a commit?

**A:** This scenario might happen because CodeLens can't find the work items in Azure Boards. Check that you're connected to the project that has those work items, and that you have permissions to see those work items. Work item details might also not show if the commit description has incorrect information about the work item IDs in Azure Boards.

### Q: How do I change the font and color for CodeLens?

**A:** Go to **Tools** > **Options** > **Environment** > **Fonts and Colors**.

:::image type="content" source="./media/vs-2019/codelens-options-fonts-colors-settings.png" border="false" alt-text="Screenshot of that shows how to change font and color settings for CodeLens in Visual Studio 2019.":::

To use the keyboard:

1. Select **Alt** + **T** + **O** to open the **Options** dialog.

1. Select the **Up Arrow** or **Down Arrow** to go to the **Environment** node, then select the **Left Arrow** to expand the node.

1. Select the **Down Arrow** to go to **Fonts and Colors**.

1. Select **Tab** to go to the **Show settings for** list, and then select the **Down Arrow** to select **CodeLens**.

### Q: Can I move the CodeLens heads-up display?

**A:** Yes, choose the **Dock** icon :::image type="icon" source="./media/codelens-dock-window.png"::: to dock CodeLens as a window.

:::image type="content" source="./media/codelens-select-dock-window.png" alt-text="Screenshot of Dock button in CodeLens indicator window in Visual Studio 2019.":::

:::image type="content" source="./media/codelens-references-docked-window.png" alt-text="Screenshot of Docked CodeLens References window in Visual Studio 2019.":::

### Q: How do I refresh the indicators?

**A:** The refresh process is different depending on the indicator:

- **References**: This indicator updates automatically when the code changes. If the **References** indicator is docked as a separate window, refresh the indicator by selecting **Refresh**:

   :::image type="content" source="./media/codelens-view-references-docked.png" alt-text="Screenshot of Refresh button in CodeLens References in Visual Studio 2019.":::

- **Team**: Refresh these indicators by selecting **Refresh CodeLens Team Indicators** from the right-click menu:

   :::image type="content" source="./media/codelens-refresh-indicators-from-code.png" alt-text="Screenshot of Refresh CodeLens Team Indicators menu item in Visual Studio 2019.":::

- **Test**: [Find unit tests for your code](#associated-unit-tests) to refresh the **Test** indicator.

### Q: What's "Local Version"?

**A:** The **Local Version** arrow points at the most recent changeset in your local version of a file. When the server has more recent changesets, they appear before or after the **Local Version** arrow, depending on the order used to sort the changesets.

### Q: My CodeLens test indicators no longer appear in my file when I first open my solution. How can I load them?

**A:** Rebuild your project to get CodeLens test indicators to load in your file. To improve performance, Visual Studio no longer fetches source information for test indicators when code files are loaded. Test indicators are loaded after a build, or when you navigate to a test by double-clicking on it in **Test Explorer**.


## Related content

- [About Git version control in Visual Studio 2019](../version-control/git-with-visual-studio.md?view=vs-2019&preserve-view=true)
- [Features of the Visual Studio 2019 code editor](./writing-code-in-the-code-and-text-editor.md?view=vs-2019&preserve-view=true)

::: moniker-end
