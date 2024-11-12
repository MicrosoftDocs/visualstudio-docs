---
title: Find code changes and other history with CodeLens
description: Explore CodeLens in Visual Studio and how to use the tool to explore the history of your code without having to leave the editor.
ms.date: 06/30/2023
ms.topic: conceptual
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.All_Languages.CodeLens
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Find code changes and other history with CodeLens

::: moniker range="vs-2022"

With CodeLens, you can stay focused on your work while you find out what happened to your code&ndash;all without leaving the editor. You can find references to a piece of code, changes to your code, linked bugs, Azure DevOps work items, code reviews, and unit tests.

> [!NOTE]
> CodeLens is available in the Community edition of Visual Studio; however, the *source control* indicators are not available in this edition.

CodeLens can show you both where and how the individual parts of your code are used in your solution.

![Screenshot of the CodeLens indicators in the code editor.](../ide/media/codelens-overview.png)

To choose the indicators that you want to see, or to turn CodeLens off and on, go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

## Find references to your code

You can find references in C# or Visual Basic code. Here's how.

1. In the code editor, select the **references** indicator or press **Alt**+**2**.

   > [!NOTE]
   > If the indicator shows **0 references**, you don't have any references from your C# or Visual Basic code. However, there might be references in other items such as *.xaml* and *.aspx* files.

1. To view the referencing code, mouse over the reference in the list.

1. To open the file that contains the reference, double-click the reference.

### Code maps

To see relationships between the code and its references, [create a code map](../modeling/map-dependencies-across-your-solutions.md). In the code map shortcut menu, select **Show All References**.

## Find changes in your code

Inspect your code's history to find out what happened to your code. Or, review changes before they're merged into your code so you can better understand how changes in other branches might affect your code.

You need:

- Visual Studio [Enterprise](https://visualstudio.microsoft.com/vs/compare/) or Visual Studio [Professional](https://visualstudio.microsoft.com/vs/compare/)

- [Git](https://git-scm.com/) or [Azure DevOps Server](/azure/devops/server/whats-new?view=azure-devops-2022&preserve-view=true) (formerly [Team Foundation Server](/azure/devops/server/tfs-is-now-azure-devops-server?view=azure-devops&preserve-view=true)) or [Team Foundation Version Control](/azure/devops/repos/tfvc/what-is-tfvc?view=azure-devops&preserve-view=true)

For C# or Visual Basic code that's stored with Team Foundation Version Control (TFVC) or Git, you get CodeLens details at the class and method levels (*code element-level* indicators).

For file types other than *.cs* or *.vb*, you get CodeLens details for the entire file in one place (*file-level* indicators).

### Code element-level indicators

Code element-level indicators let you see who changed your code and what changes they made. Code element-level indicators are available for C# and Visual Basic code.

You can also view change history when you use Team Foundation Version Control (TFVC) in Azure DevOps Services.

The default time period is the last 12 months. 

To see a detailed history of all the changes, including those changes from more than a year ago, select **Show all file changes**, which opens a **History** window.

From the **History** window, you can view all your files that are in a Git repository. You can then select the code element-level changes indicator for more details.

### File-level indicators

You can also view the file-level indicators for an entire file.

> [!NOTE]
> File-level indicators are not available for C# and Visual Basic files.

To get more details about a change, right-click the item. Depending on whether you're using TFVC or Git, there are options to compare the versions of the file, view details and track the changeset, get the selected version of the file, and email the author of that change. Some of these details appear in **Team Explorer** if you have it enabled; otherwise, these details appear in **Git Changes** tab, and might also appear on the horizontal scrollbar at the bottom of the editor.

You can also see who changed your code over time, which can help you find patterns in your team's changes and assess their impact.

Starting in Visual Studio 2022 version 17.12 Preview 2, you can show or hide file-level indicators on the editor's horizontal scrollbar. To hide the indicators, open **Tools > Options > Text Editor > Advanced**, and then disable the **Show file level CodeLens indicator** option. This option affects visibility for file types that have the file-level CodeLens control in the bottom editor scrollbar such as XAML, HTML, and CSS, and does not affect files that contain inline CodeLens.

### Find changes in your current branch

Your team might have multiple branches, for example a main branch and a child development branch, to reduce the risk of breaking stable code. You can find out how many people changed your code and how many changes were made in the main branch by pressing **Alt**+**6**.

### Find when your code was branched

To find when your code was branched, navigate to your code in the child branch. Then, select the **changes** indicator (or press **Alt**+**6**).

### Find incoming changes from other branches

You can view incoming changes. And, you don't need to leave your current branch to review a change. 

### Find when changes got merged

You can see when changes got merged, so you can determine which changes are included in your branch.

### Compare an incoming change with your local version

To compare an incoming change with your local version, double-click the changeset or press **Shift**+**F10**.

### Branch icons

The icon in the **Branch** column tells you how the branch is related to the branch you're working in.

|**Icon**|**The change came from:**|
|--------------| - |
|![CodeLens: Change from current branch icon](../ide/media/codelensbranchcurrenticon.png)|The current branch|
|![CodeLens: Change from parent branch icon](../ide/media/codelensbranchparenticon.png)|The parent branch|
|![CodeLens: Change from child branch icon](../ide/media/codelensbranchchildicon.png)|A child branch|
|![CodeLens: Change from peer branch icon](../ide/media/codelensbranchpeericon.png)|A peer branch|
|![CodeLens: Change from branch further away icon](../ide/media/codelensbranchfurtherawayicon.png)|A branch further away than a parent, child, or peer|
|![CodeLens: Merge from parent icon](../ide/media/codelensbranchmergefromparenticon.png)|A merge from the parent branch to a child branch|
|![CodeLens: Merge from child branch icon](../ide/media/codelensbranchmergefromchildicon.png)|A merge from a child branch to the parent branch|
|![CodeLens: Merge from unrelated branch icon](../ide/media/codelensbranchmergefromunrelatedicon.png)|A merge from an unrelated branch (baseless merge)|

## Linked work items

Find linked work items by selecting the **work items** indicator or by pressing **Alt**+**8**.

## Linked code reviews

Find linked code reviews by selecting the **reviews** indicator. To use the keyboard, hold down the **Alt** key and then press **Left arrow** or **Right arrow** to navigate the indicator options.

## Linked bugs

Find linked bugs by selecting the **bugs** indicator or by pressing **Alt**+**7**.

## Contact the owner of an item

Find the author of an item by selecting the **authors** indicator or by pressing **Alt**+**5**.

You can also open the shortcut menu for an item to see the contact options. (If you have Teams installed, you have additional communication options available to you.) 

## Associated unit tests

You can discover unit tests that exist for your C# or Visual Basic code without opening **Test Explorer**.

1. Go to application code that has associated [unit test code](../test/unit-test-your-code.md).

1. If you haven't already, build your application to load the CodeLens test indicators.

1. Review the tests for the code by pressing **Alt**+**3**.

1. If you see a warning icon ![warning icon](../ide/media/codelenstestwarningicon.png), the tests haven't run yet, so run them.

1. To review a test's definition, double-click the test item in the CodeLens indicator window to open the code file in the editor.

1. To review the test's results, choose the test status indicator (![test failed icon](../ide/media/codelenstestfailedicon.png) or ![test passed icon](../ide/media/codelenstestpassedicon.png)) or press **Alt**+**1**.

1. To see how many people changed this test, who changed this test, or how many changes were made to this test, [find your code's history](#find-changes-in-your-code) and linked items.

## Keyboard shortcuts

To use the keyboard to select indicators, press and hold the **Alt** key to display the related number keys, then press the number that corresponds to the indicator you want to select.

> [!NOTE]
> To select the **reviews** indicator, hold down **Alt** while using the left and right arrow keys to navigate.

## Q & A

### Q: How do I turn CodeLens off or on or choose which indicators to see?

**A:**  You can turn indicators off or on, except for the references indicator. Go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

When the indicators are turned on, you can also open the CodeLens options from the indicators. And, you can turn CodeLens file-level indicators on and off by using the chevron icons at the bottom of the editor window.

### Q: Where is CodeLens?

**A:** CodeLens appears in C# and Visual Basic code at the method, class, indexer, and property level. CodeLens appears at the file level for all other types of files.

- Make sure CodeLens is turned on. Go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

- Azure DevOps-related indicators appear only when work items are linked to the code and when you have permissions to open linked work items. Confirm that you have [team member permissions](/azure/devops/organizations/security/view-permissions?view=vsts&preserve-view=true).

- Unit test indicators don't appear when application code doesn't have unit tests. Test status indicators appear automatically in test projects. If you know that your application code has unit tests, but the test indicators don't appear, try building the solution (**Ctrl**+**Shift**+**B**).

> [!TIP]
> CodeLens is available in Visual Studio Community edition, however, the *source control* indicators are not available in this edition.

### Q: Why don't I see the work item details for a commit?

**A:** This might happen because CodeLens can't find the work items in Azure Boards. Check that you're connected to the project that has those work items, and that you have permissions to see those work items. Work item details might also not show if the commit description has incorrect information about the work item IDs in Azure Boards.

### Q: How do I change the font and color for CodeLens?

**A:** Go to **Tools** > **Options** > **Environment** > **Fonts and Colors**.

![CodeLens - Change font and color settings](../ide/media/codelensoptionsfontscolorssettings.png)

To use the keyboard:

1. Press **Alt**+**T**+**O** to open the **Options** dialog box.

1. Press **Up Arrow** or **Down Arrow** to go to the **Environment** node, then press **Left Arrow** to expand the node.

1. Press **Down Arrow** to go to **Fonts and Colors**.

1. Press **Tab** to go to the **Show settings for** list, and then press **Down Arrow** to select **CodeLens**.

### Q: Can I move the CodeLens heads-up display?

**A:** Yes, choose ![Dock icon](../ide/media/codelensdockwindow.png) to dock CodeLens as a window.

### Q: How do I refresh the indicators?

**A:** This depends on the indicator:

- **References**: This indicator updates automatically when the code changes. If the **References** indicator is docked as a separate window, refresh the indicator by selecting **Refresh**.

- **Team**: Refresh these indicators by selecting **Refresh CodeLens Team Indicators** from the right-click menu.

- **Test**: [Find unit tests for your code](#associated-unit-tests) to refresh the **Test** indicator.

### Q: What's "Local Version"?

**A:** The **Local Version** arrow points at the most recent changeset in your local version of a file. When the server has more recent changesets, they appear above or below the **Local Version** arrow, depending on the order used to sort the changesets.

### Q: My CodeLens test indicators no longer appear in my file when I first open my solution. How can I load them?

**A:** Rebuild your project to get CodeLens test indicators to load in your file. To improve performance, Visual Studio no longer fetches source information for test indicators when code files are loaded. Test indicators are loaded after a build, or when you navigate to a test by double-clicking on it in **Test Explorer**.

::: moniker-end

::: moniker range="vs-2019"

CodeLens lets you stay focused on your work while you find out what happened to your code&ndash;without leaving the editor. You can find references to a piece of code, changes to your code, linked bugs, work items, code reviews, and unit tests.

> [!NOTE]
> CodeLens is available in Visual Studio Community edition, however, the *source control* indicators are not available in this edition.

See where and how the individual parts of your code are used in your solution:

![CodeLens indicators in the code editor](../ide/media/codelens-overview.png)

Contact your team about changes to your code without leaving the editor:

![CodeLens - Contact your team](../ide/media/codelens-contact-info.png)

To choose the indicators that you want to see, or to turn CodeLens off and on, go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

## Find references to your code in Visual Studio 2019

You can find references in C# or Visual Basic code.

1. Choose the **references** indicator or press **Alt**+**2**.

   ![CodeLens references](../ide/media/codelens-view-references.png)

   > [!NOTE]
   > If the indicator shows **0 references**, you have no references from C# or Visual Basic code. However, there may be references in other items such as *.xaml* and *.aspx* files.

1. To view the referencing code, mouse over the reference in the list.

   ![CodeLens - Peek reference](../ide/media/codelens-peek-reference.png)

1. To open the file that contains the reference, double-click the reference.

### Code maps

To see relationships between the code and its references, [create a code map](../modeling/map-dependencies-across-your-solutions.md). In the code map shortcut menu, select **Show All References**.

![CodeLens - References on code map](../ide/media/codelensmappedreferences.png)

## Find changes in your code in Visual Studio 2019

Inspect your code's history to find out what happened to your code. Or, review changes before they're merged into your code so you can better understand how changes in other branches might affect your code.

You need:

- Visual Studio [Enterprise](https://visualstudio.microsoft.com/vs/compare/) or Visual Studio [Professional](https://visualstudio.microsoft.com/vs/compare/)

- [Git](https://git-scm.com/) or [Azure DevOps Server](/azure/devops/server/whats-new?view=azure-devops-2022&preserve-view=true) (formerly [Team Foundation Server](/azure/devops/server/tfs-is-now-azure-devops-server?view=azure-devops&preserve-view=true)) or [Team Foundation Version Control](/azure/devops/repos/tfvc/what-is-tfvc?view=azure-devops&preserve-view=true)

For C# or Visual Basic code that's stored with Team Foundation Version Control (TFVC) or Git, you get CodeLens details at the class and method levels (*code element-level* indicators). 

![Code element-level indicators](../ide/media/codelens-element-level-indicators.png)

For file types other than *.cs* or *.vb*, you get CodeLens details for the entire file in one place at the bottom of the window (*file-level* indicators).

![File-level CodeLens indicators](../ide/media/almcodelensfilelevelindicators.png)

### Code element-level indicators

Code element-level indicators let you see who changed your code and what changes they made. Code element-level indicators are available for C# and Visual Basic code.

This is what you see when you use Team Foundation Version Control (TFVC) or Azure DevOps Services:

![CodeLens: Get change history for your code in TFVC](../ide/media/codelens-code-changes.png)

The default time period is the last 12 months. 

To see a detailed history of all the changes, including those changes from more than a year ago, choose **Show all file changes**:

![Show all code changes](../ide/media/codelens-show-all-file-changes.png)

The **History** window opens:

![History window for all code changes](../ide/media/codelenscodechangeshistory.png)

When your files are in a Git repository and you choose the code element-level changes indicator, this is what you see:

![CodeLens: Get change history for your code in Git](../ide/media/codelens-code-changes-git.png)

### File-level indicators

Find changes for an entire file in the file-level indicators at the bottom of the window:

![CodeLens: Get code file details](../ide/media/codelens-file-level.png)

> [!NOTE]
> File-level indicators are not available for C# and Visual Basic files.

To get more details about a change, right-click that item. Depending on whether you're using TFVC or Git, there are options to compare the versions of the file, view details and track the changeset, get the selected version of the file, and email the author of that change. Some of these details appear in **Team Explorer** in Visual Studio 2019 [version 16.7](/visualstudio/releases/2019/release-notes-v16.7#whats-new-in-visual-studio-2019-version-167/) and earlier. In Visual Studio 2019 [version 16.8](/visualstudio/releases/2019/release-notes-v16.8#whats-new-in-visual-studio-2019-version-168/) and later, these details appear in **Git Changes**.

You can also see who changed your code over time, which can help you find patterns in your team's changes and assess their impact.

![CodeLens: See code changes history as a graph](../ide/media/codelens.png)

### Find changes in your current branch

Your team might have multiple branches, for example a main branch and a child development branch, to reduce the risk of breaking stable code.

![CodeLens: Find changes in your current branch](../ide/media/codelensfirstbranchconceptual.png)

You can find out how many people changed your code and how many changes were made in the main branch by pressing **Alt**+**6**:

![CodeLens: Find how many changes in your branch](../ide/media/codelens-branch-changes.png)

### Find when your code was branched

To find when your code was branched, navigate to your code in the child branch. Then, select the **changes** indicator (or press **Alt**+**6**):

![CodeLens: Find when your code was branched](../ide/media/codelens-first-branch.png)

### Find incoming changes from other branches

![CodeLens: Find code changes in other branches](../ide/media/codelensbranchchangecheckinconceptual.png)

You can view incoming changes. In the following screenshot, a bug fix was made in the "Dev" branch:

![CodeLens: Change checked into another branch](../ide/media/codelens-branch-changes-dev.png)

You can review the change without leaving your current branch ("Main"):

![CodeLens: See incoming change from another branch](../ide/media/codelens-branch-changes-main.png)

### Find when changes got merged

You can see when changes got merged, so you can determine which changes are included in your branch:

![CodeLens - Find when changes got merged](../ide/media/codelensbranchmergedconceptual.png)

For example, your code in the Main branch now has the bug fix from the "Dev" branch:

![CodeLens - Merged changes between branches](../ide/media/codelens-branch-merged.png)

### Compare an incoming change with your local version

Compare an incoming change with your local version by pressing **Shift**+**F10**, or by double-clicking the changeset.

![CodeLens: Compare incoming change with local](../ide/media/codelens-branch-incoming-change-menu.png)

### Branch icons

The icon in the **Branch** column tells you how the branch is related to the branch you're working in.

|**Icon**|**The change came from:**|
|--------------| - |
|![CodeLens: Change from current branch icon](../ide/media/codelensbranchcurrenticon.png)|The current branch|
|![CodeLens: Change from parent branch icon](../ide/media/codelensbranchparenticon.png)|The parent branch|
|![CodeLens: Change from child branch icon](../ide/media/codelensbranchchildicon.png)|A child branch|
|![CodeLens: Change from peer branch icon](../ide/media/codelensbranchpeericon.png)|A peer branch|
|![CodeLens: Change from branch further away icon](../ide/media/codelensbranchfurtherawayicon.png)|A branch further away than a parent, child, or peer|
|![CodeLens: Merge from parent icon](../ide/media/codelensbranchmergefromparenticon.png)|A merge from the parent branch to a child branch|
|![CodeLens: Merge from child branch icon](../ide/media/codelensbranchmergefromchildicon.png)|A merge from a child branch to the parent branch|
|![CodeLens: Merge from unrelated branch icon](../ide/media/codelensbranchmergefromunrelatedicon.png)|A merge from an unrelated branch (baseless merge)|

## Linked work items in Visual Studio 2019

Find linked work items by selecting the **work items** indicator or by pressing **Alt**+**8**.

![CodeLens - Find work items for specific code](../ide/media/codelens-work-items.png)

## Linked code reviews in Visual Studio 2019

Find linked code reviews by selecting the **reviews** indicator. To use the keyboard, hold down the **Alt** key and then press **Left arrow** or **Right arrow** to navigate the indicator options.

![CodeLens - View code review requests](../ide/media/codelens-code-reviews.png)

## Linked bugs in Visual Studio 2019

Find linked bugs by selecting the **bugs** indicator or by pressing **Alt**+**7**.

![CodeLens - Find bugs linked to changesets](../ide/media/codelens-bugs-changesets.png)

## Contact the owner of an item in Visual Studio 2019

Find the author of an item by selecting the **authors** indicator or by pressing **Alt**+**5**.

![Contact the owner of an item](../ide/media/codelens-contact-item-owner.png)

Open the shortcut menu for an item to see the contact options. If you have Teams installed, you might see options similar to those in the following screenshot:

![Contact options for an item](../ide/media/codelens-item-contact-menu.png)

## Associated unit tests in Visual Studio 2019

You can discover unit tests that exist for your C# or Visual Basic code without opening **Test Explorer**.

1. Go to application code that has associated [unit test code](../test/unit-test-your-code.md).

1. If you haven't already, build your application to load the CodeLens test indicators.

1. Review the tests for the code by pressing **Alt**+**3**.

     ![CodeLens - Choose test status in code editor](../ide/media/codelens-choose-test-indicator.png)

1. If you see a warning icon ![warning icon](../ide/media/codelenstestwarningicon.png), the tests haven't run yet, so run them.

     ![CodeLens - View unit tests not run yet](../ide/media/codelens-tests-not-yet-run.png)

1. To review a test's definition, double-click the test item in the CodeLens indicator window to open the code file in the editor.

     ![CodeLens - Go to unit test definition](../ide/media/codelens-unit-test-definition.png)

1. To review the test's results, choose the test status indicator (![test failed icon](../ide/media/codelenstestfailedicon.png) or ![test passed icon](../ide/media/codelenstestpassedicon.png)) or press **Alt**+**1**.

     ![CodeLens - See unit test result](../ide/media/codelens-unit-test-result.png)

1. To see how many people changed this test, who changed this test, or how many changes were made to this test, [find your code's history](#find-changes-in-your-code) and linked items.

## Keyboard shortcuts in Visual Studio 2019

To use the keyboard to select indicators, press and hold the **Alt** key to display the related number keys, then press the number that corresponds to the indicator you want to select.

![Keyboard access numbers](../ide/media/codelens-alt-keys.png)

> [!NOTE]
> To select the **reviews** indicator, hold down **Alt** while using the left and right arrow keys to navigate.

## Q & A for CodeLens in Visual Studio 2019

### Q: How do I turn CodeLens off or on or choose which indicators to see?

**A:**  You can turn indicators off or on, except for the references indicator. Go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

When the indicators are turned on, you can also open the CodeLens options from the indicators.

![CodeLens - Turn indicators off or on](../ide/media/codelensturnoffonindicatorsfromcode.png)

Turn CodeLens file-level indicators on and off using the chevron icons at the bottom of the editor window.

![Turn file-level indicators on and off](../ide/media/codelensfilelevelonandoff.png)

### Q: Where is CodeLens?

**A:** CodeLens appears in C# and Visual Basic code at the method, class, indexer, and property level. CodeLens appears at the file level for all other types of files.

- Make sure CodeLens is turned on. Go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

- DevOps-related indicators appear only when work items are linked to the code and when you have permissions to open linked work items. Confirm that you have [team member permissions](/azure/devops/organizations/security/view-permissions?view=vsts&preserve-view=true).

- Unit test indicators don't appear when application code doesn't have unit tests. Test status indicators appear automatically in test projects. If you know that your application code has unit tests, but the test indicators don't appear, try building the solution (**Ctrl**+**Shift**+**B**).

> [!TIP]
> CodeLens is available in Visual Studio Community edition, however, the *source control* indicators are not available in this edition.

### Q: Why don't I see the work item details for a commit?

**A:** This might happen because CodeLens can't find the work items in Azure Boards. Check that you're connected to the project that has those work items, and that you have permissions to see those work items. Work item details might also not show if the commit description has incorrect information about the work item IDs in Azure Boards.

### Q: How do I change the font and color for CodeLens?

**A:** Go to **Tools** > **Options** > **Environment** > **Fonts and Colors**.

![CodeLens - Change font and color settings](../ide/media/codelensoptionsfontscolorssettings.png)

To use the keyboard:

1. Press **Alt**+**T**+**O** to open the **Options** dialog box.

1. Press **Up Arrow** or **Down Arrow** to go to the **Environment** node, then press **Left Arrow** to expand the node.

1. Press **Down Arrow** to go to **Fonts and Colors**.

1. Press **Tab** to go to the **Show settings for** list, and then press **Down Arrow** to select **CodeLens**.

### Q: Can I move the CodeLens heads-up display?

**A:** Yes, choose ![Dock icon](../ide/media/codelensdockwindow.png) to dock CodeLens as a window.

![Dock button in CodeLens indicator window](../ide/media/codelensselectdockwindow.png)

![Docked CodeLens References window](../ide/media/codelensreferencesdockedwindow.png)

### Q: How do I refresh the indicators?

**A:** This depends on the indicator:

- **References**: This indicator updates automatically when the code changes. If the **References** indicator is docked as a separate window, refresh the indicator by selecting **Refresh**:

   ![Refresh button in CodeLens References](../ide/media/codelensviewreferencesdocked.png)

- **Team**: Refresh these indicators by selecting **Refresh CodeLens Team Indicators** from the right-click menu:

   ![Refresh CodeLens Team Indicators menu item](../ide/media/codelensrefreshindicatorsfromcode.png)

- **Test**: [Find unit tests for your code](#associated-unit-tests) to refresh the **Test** indicator.

### Q: What's "Local Version"?

**A:** The **Local Version** arrow points at the most recent changeset in your local version of a file. When the server has more recent changesets, they appear above or below the **Local Version** arrow, depending on the order used to sort the changesets.

### Q: My CodeLens test indicators no longer appear in my file when I first open my solution. How can I load them?

**A:** Rebuild your project to get CodeLens test indicators to load in your file. To improve performance, Visual Studio no longer fetches source information for test indicators when code files are loaded. Test indicators are loaded after a build, or when you navigate to a test by double-clicking on it in **Test Explorer**.

::: moniker-end

## Related content

- [Visual Studio version control docs](../version-control/git-with-visual-studio.md).
- [Features of the code editor](../ide/writing-code-in-the-code-and-text-editor.md)