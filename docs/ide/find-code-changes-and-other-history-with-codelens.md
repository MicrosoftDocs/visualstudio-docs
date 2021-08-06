---
title: Find code changes and other history with CodeLens
description: Learn about CodeLens and how to use it explore the history of your code without having to leave the editor.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.All_Languages.CodeLens
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Find code changes and other history with CodeLens

CodeLens lets you stay focused on your work while you find out what happened to your code&ndash;without leaving the editor. You can find references to a piece of code, changes to your code, linked bugs, work items, code reviews, and unit tests.

::: moniker range=">=vs-2019"

> [!NOTE]
> CodeLens is available in Visual Studio Community edition, however, the *source control* indicators are not available in this edition.

::: moniker-end

::: moniker range="vs-2017"

> [!NOTE]
> CodeLens is available only in Visual Studio Enterprise and Professional editions. It is not available in Visual Studio Community edition.

::: moniker-end

See where and how the individual parts of your code are used in your solution:

![CodeLens indicators in the code editor](../ide/media/codelens-overview.png)

Contact your team about changes to your code without leaving the editor:

![CodeLens - Contact your team](../ide/media/codelens-contact-info.png)

To choose the indicators that you want to see, or to turn CodeLens off and on, go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

## Find references to your code

You can find references in C# or Visual Basic code.

1. Choose the **references** indicator or press **Alt**+**2**.

   ![CodeLens references](../ide/media/codelens-view-references.png)

   > [!NOTE]
   > If the indicator shows **0 references**, you have no references from C# or Visual Basic code. However, there may be references in other items such as *.xaml* and *.aspx* files.

2. To view the referencing code, mouse over the reference in the list.

   ![CodeLens - Peek reference](../ide/media/codelens-peek-reference.png)

3. To open the file that contains the reference, double-click the reference.

### Code maps

To see relationships between the code and its references, [create a code map](../modeling/map-dependencies-across-your-solutions.md). In the code map shortcut menu, select **Show All References**.

![CodeLens - References on code map](../ide/media/codelensmappedreferences.png)

## Find changes in your code

Inspect your code's history to find out what happened to your code. Or, review changes before they're merged into your code so you can better understand how changes in other branches might affect your code.

You need:

- Visual Studio Enterprise or Professional edition

- Azure DevOps Services, Team Foundation Server 2013 or later, or Git

- [Skype for Business](/skypeforbusiness/) to contact your team from the code editor

For C# or Visual Basic code that's stored with Team Foundation Version Control (TFVC) or Git, you get CodeLens details at the class and method levels (*code element-level* indicators). If your Git repository is hosted in TfGit, you also get links to TFS work items.

![Code element-level indicators](../ide/media/codelens-element-level-indicators.png)

For file types other than *.cs* or *.vb*, you get CodeLens details for the entire file in one place at the bottom of the window (*file-level* indicators).

![File-level CodeLens indicators](../ide/media/almcodelensfilelevelindicators.png)

### Code element-level indicators

Code element-level indicators let you see who changed your code and what changes they made. Code element-level indicators are available for C# and Visual Basic code.

This is what you see when you use Team Foundation Version Control (TFVC) in Team Foundation Server or Azure DevOps Services:

![CodeLens: Get change history for your code in TFVC](../ide/media/codelens-code-changes.png)

The default time period is the last 12 months. If your code is stored in Team Foundation Server, you can change the time period by running the [TFSConfig command](/azure/devops/server/command-line/tfsconfig-cmd) with the [CodeIndex command](../ide/codeindex-command.md) and the **/indexHistoryPeriod** flag.

To see a detailed history of all the changes, including those from more than a year ago, choose **Show all file changes**:

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

To get more details about a change, right-click that item. Depending on whether you are using TFVC or Git, there are options to compare the versions of the file, view details and track the changeset, get the selected version of the file, and email the author of that change. Some of these details appear in **Team Explorer**.

You can also see who changed your code over time. This can help you find patterns in your team's changes and assess their impact.

![CodeLens: See code changes history as a graph](../ide/media/codelens.png)

### Find changes in your current branch

Your team may have multiple branches, for example a main branch and a child development branch, to reduce the risk of breaking stable code.

![CodeLens: Find changes in your current branch](../ide/media/codelensfirstbranchconceptual.png)

You can find out how many people changed your code and how many changes were made in the main branch by pressing **Alt**+**6**:

![CodeLens: Find how many changes in your branch](../ide/media/codelens-branch-changes.png)

### Find when your code was branched

To find when your code was branched, navigate to your code in the child branch. Then, select the **changes** indicator or press **Alt**+**6**:

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

## Linked work items

Find linked work items by selecting the **work items** indicator or by pressing **Alt**+**8**.

![CodeLens - Find work items for specific code](../ide/media/codelens-work-items.png)

## Linked code reviews

Find linked code reviews by selecting the **reviews** indicator. To use the keyboard, hold down the **Alt** key and then press **Left arrow** or **Right arrow** to navigate the indicator options.

![CodeLens - View code review requests](../ide/media/codelens-code-reviews.png)

## Linked bugs

Find linked bugs by selecting the **bugs** indicator or by pressing **Alt**+**7**.

![CodeLens - Find bugs linked to changesets](../ide/media/codelens-bugs-changesets.png)

## Contact the owner of an item

Find the author of an item by selecting the **authors** indicator or by pressing **Alt**+**5**.

![Contact the owner of an item](../ide/media/codelens-contact-item-owner.png)

Open the shortcut menu for an item to see the contact options. If you have Lync or Skype for Business installed, you see these options:

![Contact options for an item](../ide/media/codelens-item-contact-menu.png)

## Associated unit tests

You can discover unit tests that exist for your C# or Visual Basic code without opening **Test Explorer**.

1. Go to application code that has associated [unit test code](../test/unit-test-your-code.md).

2. If you have not already, build your application to load the CodeLens test indicators.

3. Review the tests for the code by pressing **Alt**+**3**.

     ![CodeLens - Choose test status in code editor](../ide/media/codelens-choose-test-indicator.png)

4. If you see a warning icon ![warning icon](../ide/media/codelenstestwarningicon.png), the tests haven't run yet, so run them.

     ![CodeLens - View unit tests not run yet](../ide/media/codelens-tests-not-yet-run.png)

5. To review a test's definition, double-click the test item in the CodeLens indicator window to open the code file in the editor.

     ![CodeLens - Go to unit test definition](../ide/media/codelens-unit-test-definition.png)

6. To review the test's results, choose the test status indicator (![test failed icon](../ide/media/codelenstestfailedicon.png) or ![test passed icon](../ide/media/codelenstestpassedicon.png)) or press **Alt**+**1**.

     ![CodeLens - See unit test result](../ide/media/codelens-unit-test-result.png)

7. To see how many people changed this test, who changed this test, or how many changes were made to this test, [find your code's history](#find-changes-in-your-code) and linked items.

## Keyboard shortcuts

To use the keyboard to select indicators, press and hold the **Alt** key to display the related number keys, then press the number that corresponds to the indicator you want to select.

![Keyboard access numbers](../ide/media/codelens-alt-keys.png)

> [!NOTE]
> To select the **reviews** indicator, hold down **Alt** while using the left and right arrow keys to navigate.

## Q & A

### Q: How do I turn CodeLens off or on or choose which indicators to see?

**A:**  You can turn indicators off or on, except for the references indicator. Go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

When the indicators are turned on, you can also open the CodeLens options from the indicators.

![CodeLens - Turn indicators off or on](../ide/media/codelensturnoffonindicatorsfromcode.png)

Turn CodeLens file-level indicators on and off using the chevron icons at the bottom of the editor window.

![Turn file-level indicators on and off](../ide/media/codelensfilelevelonandoff.png)

### Q: Where is CodeLens?

**A:** CodeLens appears in C# and Visual Basic code at the method, class, indexer, and property level. CodeLens appears at the file level for all other types of files.

- Make sure CodeLens is turned on. Go to **Tools** > **Options** > **Text Editor** > **All Languages** > **CodeLens**.

- If your code is stored in TFS, make sure that code indexing is turned on by using the [CodeIndex command](../ide/codeindex-command.md) with the [TFS Config command](/azure/devops/server/command-line/tfsconfig-cmd).

- DevOps-related indicators appear only when work items are linked to the code and when you have permissions to open linked work items. Confirm that you have [team member permissions](/azure/devops/organizations/security/view-permissions?view=vsts&preserve-view=true).

- Unit test indicators don't appear when application code doesn't have unit tests. Test status indicators appear automatically in test projects. If you know that your application code has unit tests, but the test indicators don't appear, try building the solution (**Ctrl**+**Shift**+**B**).

::: moniker range=">=vs-2019"

> [!TIP]
> CodeLens is available in Visual Studio Community edition, however, the *source control* indicators are not available in this edition.

::: moniker-end

::: moniker range="vs-2017"

> [!TIP]
> CodeLens is not available in Visual Studio Community edition.

::: moniker-end

### Q: Why don't I see the work item details for a commit?

**A:** This might happen because CodeLens can't find the work items in Azure Boards or TFS. Check that you're connected to the project that has those work items, and that you have permissions to see those work items. Work item details might also not show if the commit description has incorrect information about the work item IDs in Azure Boards or TFS.

### Q: Why don't I see the Skype indicators?

**A:** Skype indicators don't appear if you're not signed into Skype for Business, don't have it installed, or don't have a supported configuration. However, you can still send email:

![CodeLens - Contact changeset owner by mail](../ide/media/codelenscodesendmailchangesetnolync1.png)

**Which Skype and Lync configurations are supported?**

- Skype for Business (32-bit or 64-bit)

- Lync 2010 or later alone (32-bit or 64-bit), but not Lync Basic 2013 with Windows 8.1

CodeLens doesn't support having different versions of Lync or Skype installed. They might not be localized for all localized versions of Visual Studio.

### Q: How do I change the font and color for CodeLens?

**A:** Go to **Tools** > **Options** > **Environment** > **Fonts and Colors**.

![CodeLens - Change font and color settings](../ide/media/codelensoptionsfontscolorssettings.png)

To use the keyboard:

1. Press **Alt**+**T**+**O** to open the **Options** dialog box.

2. Press **Up Arrow** or **Down Arrow** to go to the **Environment** node, then press **Left Arrow** to expand the node.

3. Press **Down Arrow** to go to **Fonts and Colors**.

4. Press **Tab** to go to the **Show settings for** list, and then press **Down Arrow** to select **CodeLens**.

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

### Q: Can I manage how CodeLens processes code to show history and linked items?

**A:** Yes. If your code is in TFS, use the [CodeIndex command](../ide/codeindex-command.md) with the [TFS Config command](/azure/devops/server/command-line/tfsconfig-cmd).

### Q: My CodeLens test indicators no longer appear in my file when I first open my solution. How can I load them?

**A:** Rebuild your project to get CodeLens test indicators to load in your file. To improve performance, Visual Studio no longer fetches source information for test indicators when code files are loaded. Test indicators are loaded after a build, or when you navigate to a test by double-clicking on it in **Test Explorer**.

## See also

- [Features of the code editor](../ide/writing-code-in-the-code-and-text-editor.md)
