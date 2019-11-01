---
title: "Find code changes and other history with CodeLens | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: f697d7b4-704e-4cac-b13a-bc57d2ff8318
caps.latest.revision: 134
author: jillre
ms.author: jillfra
manager: jillfra
---
# Find code changes and other history with CodeLens
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Stay focused on your work while you find out what happened to your code - without leaving the editor. Find references and changes to your code, linked bugs, work items, code reviews, and unit tests.

> [!NOTE]
> CodeLens is available only in Visual Studio Enterprise and Visual Studio Professional editions. It is not available in Visual Studio Community edition.

 See where and how the individual parts of your code are used in your solution:

 ![CodeLens indicators in the code editor](../ide/media/codelensoverview.png "CodeLensOverview")

 Contact your team about changes to your code without leaving the editor:

 ![CodeLens &#45; Contact your team](../ide/media/codelensovervew2.png "CodeLensOvervew2")

 To choose the indicators that you want to see, or to turn CodeLens off and on, go to **Tools**, **Options**, **Text Editor**, **All Languages**, **CodeLens**.

## <a name="FindReferences"></a> Find references to your code
 You'll need:

- Visual Studio Enterprise or Visual Studio Professional

- Visual C# .NET or Visual Basic .NET code

  Choose the **references** indicator (**Alt + 2**). If you see **0 references**, you have no references from Visual C# or Visual Basic code. This doesn't include references from other items such as XAML and ASPX files.

  ![CodeLens &#45; Choose references indicator](../ide/media/codelensviewreferenceslist.png "CodeLensViewReferencesList")

  To view the referencing code, move your mouse on top of the reference.

  ![CodeLens &#45; Peek reference](../ide/media/codelensviewreferencespeekreference.png "CodeLensViewReferencesPeekReference")

  To open the file containing the reference, double-click the reference.

  To see relationships between this code and its references, [create a code map](../modeling/map-dependencies-across-your-solutions.md) and choose **Show All References** in the code map shortcut menu.

  ![CodeLens &#45; References on code map](../ide/media/codelensmappedreferences.png "CodeLensMappedReferences")

## <a name="FindCodeHistory"></a> Find your code's history and linked items
 Review your code's history to find out what happened to your code. Or, review changes before they're merged into your code so you can better understand how changes in other branches might affect your code.

 You'll need:

- Visual Studio Enterprise or Visual Studio Professional

- Team Foundation Server 2013 or later, Visual Studio Team Services, or Git

- [Lync 2010 or later, or Skype for Business](https://technet.microsoft.com/lync), to contact your team from the code editor

  For Visual C# .NET or Visual Basic .NET code that's stored with Team Foundation version control (TFVC) or Git, you get CodeLens details at the class and method levels (*code-element-level* indicators). If your Git repository is hosted in TfGit, you also get links to TFS work items.

  ![Code element&#45;level indicators](../ide/media/codelenselementlevelindicators.png "CodeLensElementLevelIndicators")

  For all other types of files that you can open in the Visual Studio editor, you get CodeLens details for the entire file in one place at the bottom of the window (*file-level* indicators).

  ![File&#45;level CodeLens indicators](../ide/media/almcodelensfilelevelindicators.png "ALMCodeLensFileLevelIndicators")

  To use the keyboard to select indicators, press and hold the **ALT** key to display the related number keys.

  ![Press ALT to see the keyboard access numbers](../ide/media/codelensaltkeyindicators.png "CodeLensAltKeyIndicators")

### Find changes in your code
 Find who changed your C# or Visual Basic code, and the changes they made, in code-element-level indicators. This is what you see when you use Team Foundation version control (TFVC) in Team Foundation Server or Visual Studio Team Services.

 ![CodeLens: Get change history for your code in TFVC](../ide/media/codelenscodechanges.png "CodeLensCodeChanges")

 The default time period is the last 12 months. If your code is stored in Team Foundation Server, you can change this by running the [TFSConfig command](https://msdn.microsoft.com/94424190-3b6b-4f33-a6b6-5807f4225b62) with the [CodeIndex command](../ide/codeindex-command.md) and the **/indexHistoryPeriod** flag.

 To see a detailed history of all the changes, including those from more than a year ago, choose **Show all file changes**.

 ![Show all code changes](../ide/media/codelensshowsallchanges.png "CodeLensShowsAllChanges")

 This opens the History window for the changesets.

 ![History window for all code changes](../ide/media/codelenscodechangeshistory.png "CodeLensCodeChangesHistory")

 When your files are in a Git repository and you choose the code-element-level changes indicator, this is what you see.

 ![CodeLens: Get change history for your code in Git](../ide/media/codelenscodechangesgit.png "CodeLensCodeChangesGit")

 Find changes for an entire file (except for C# and Visual Basic files) in the file-level indicators at the bottom of the window.

 ![CodeLens: Get code file details](../ide/media/codelensfilelevel.png "CodeLensFileLevel")

 To get more details about a change, right-click that item. Depending on whether you are using TFVC or Git you get a series of options to compare the versions of the file, view details and track the changeset, get the selected version of the file, and email the author of that change. Some of these details appear in Team Explorer.

 You can also see who changed your code over time. This can help you find patterns in your team's changes and assess their impact.

 ![CodeLens: See code changes history as a graph](../ide/media/codelens.png "CodeLens")

#### Find changes in your current branch
 Suppose your team has multiple branches - a main branch and a child development - to reduce the risk of breaking stable code:

 ![CodeLens: Find when your code was branched](../ide/media/codelensfirstbranchconceptual.png "CodeLensFirstBranchConceptual")

 Find how many people changed your code and how many changes were made (**Alt + 6**) in your main branch:

 ![CodeLens: Find how many changes in your branch](../ide/media/codelensbranchchanges.png "CodeLensBranchChanges")

#### Find when your code was branched
 Go to your code in the child branch, for example, the Dev branch here. Choose the changes indicator (**Alt + 6**):

 ![CodeLens: Find when your code was branched](../ide/media/codelensfirstbranchscreenshot.png "CodeLensFirstBranchScreenshot")

#### Find incoming changes from other branches
 ![CodeLens: Find code changes in other branches](../ide/media/codelensbranchchangecheckinconceptual.png "CodeLensBranchChangeCheckinConceptual")

 …like this bug fix in the Dev branch here:

 ![CodeLens: Change checked into another branch](../ide/media/codelensbranchchangedevscreenshot.png "CodeLensBranchChangeDevScreenshot")

 You can review this change without leaving your current branch (Main):

 ![CodeLens: See incoming change from another branch](../ide/media/codelensbranchchangemainscreenshot.png "CodeLensBranchChangeMainScreenshot")

#### Find when changes got merged
 So you can see which changes are included in your branch:

 ![CodeLens &#45; Merged changes between branches](../ide/media/codelensbranchmergedconceptual.png "CodeLensBranchMergedConceptual")

 For example, your code in the Main branch now has the bug fix from the Dev branch:

 ![CodeLens &#45; Merged chagnes between branches](../ide/media/codelensbranchmergedscreenshot.png "CodeLensBranchMergedScreenshot")

#### Compare an incoming change with your local version (Shift + F10)
 ![CodeLens: Compare incoming change with local](../ide/media/codelensbranchincomingchangemenu.png "CodeLensBranchIncomingChangeMenu")

 You can also double-click the changeset.

#### What do the icons mean?

|**Icon**|**Where did the change come from?**|
|--------------|-----------------------------------------|
|![CodeLens: Change from current branch icon](../ide/media/codelensbranchcurrenticon.png "CodeLensBranchCurrentIcon")|The current branch|
|![CodeLens &#45; Change from parent branch icon](../ide/media/codelensbranchparenticon.png "CodeLensBranchParentIcon")|The parent branch|
|![CodeLens: Change from child branch icon](../ide/media/codelensbranchchildicon.png "CodeLensBranchChildIcon")|A child branch|
|![CodeLens &#45; Change from peer branch icon](../ide/media/codelensbranchpeericon.png "CodeLensBranchPeerIcon")|A peer branch|
|![CodeLens &#45; Change from branch further away icon](../ide/media/codelensbranchfurtherawayicon.png "CodeLensBranchFurtherAwayIcon")|A branch further away than a parent, child, or peer|
|![CodeLens: Merge from parent icon](../ide/media/codelensbranchmergefromparenticon.png "CodeLensBranchMergeFromParentIcon")|A merge from the parent branch to a child branch|
|![CodeLens: Merge from child branch icon](../ide/media/codelensbranchmergefromchildicon.png "CodeLensBranchMergeFromChildIcon")|A merge from a child branch to the parent branch|
|![CodeLens: Merge from unrelated branch icon](../ide/media/codelensbranchmergefromunrelatedicon.png "CodeLensBranchMergeFromUnrelatedIcon")|A merge from an unrelated branch (baseless merge)|

### Find linked work items
 ![CodeLens &#45; Find work items for specific code](../ide/media/codelensworkitems.png "CodeLensWorkItems")

### Find linked code reviews
 ![CodeLens &#45; View code review requests](../ide/media/codelenscodereviews.png "CodeLensCodeReviews")

### Find linked bugs
 ![CodeLens &#45; Find bugs linked to changesets](../ide/media/codelensbugschangesets.png "CodeLensBugsChangesets")

### Contact the owner of an item
 ![Contact the owner of an item](../ide/media/codelenscontactitemowner.png "CodeLensContactItemOwner")

 Open the shortcut menu for an item to see the contact options. If you have Lync or Skype for Business installed, you see these options:

 ![Contact options for an item](../ide/media/codelensitemcontactmenu.png "CodeLensItemContactMenu")

## <a name="FindRunUnitTests"></a> Find unit tests for your code
 Find out more about unit tests that exist for your code without opening Test Explorer. You'll need:

- Visual Studio Enterprise or Visual Studio Professional

- Visual C# .NET or Visual Basic .NET code

- A [unit test project](../test/unit-test-your-code.md) that has unit tests for your application code

1. Go to application code that has unit tests.

2. Review the tests for that code (**Alt + 3**).

     ![CodeLens &#45; Choose test status in code editor](../ide/media/codelenschoosetestindicator.png "CodeLensChooseTestIndicator")

3. If you see a warning icon ![CodeLens &#45; Unit tests not yet run warning](../ide/media/codelenstestwarningicon.png "CodeLensTestWarningIcon"), run the tests.

     ![CodeLens &#45; View unit tests not run yet](../ide/media/codelenstestsnotyetrun.png "CodeLensTestsNotYetRun")

4. To review a test's definition, double-click the test item in the CodeLens indicator window to open the code file in the editor.

     ![CodeLens &#45; Go to unit test definition](../ide/media/codelensunittestdefinition.png "CodeLensUnitTestDefinition")

5. Review the test’s results. Choose the test status indicator (![CodeLens &#45; Unit test failed icon](../ide/media/codelenstestfailedicon.png "CodeLensTestFailedIcon") or ![CodeLens &#45; Unit test passed icon](../ide/media/codelenstestpassedicon.png "CodeLensTestPassedIcon")), or press **Alt + 1**.

     ![CodeLens &#45; See unit test result](../ide/media/codelensunittestresult.png "CodeLensUnitTestResult")

6. To see how many people changed this test, who changed this test, or how many changes were made to this test, [Find your code's history and linked items](#FindCodeHistory).

## <a name="QA"></a> Q & A

### <a name="ChangeOrTurnOff"></a> Q: How do I turn CodeLens off or on? Or choose which indicators to see?
 **A:**  You can turn indicators off or on, except for the references indicator. Go to **Tools**, **Options**, **Text Editor**, **All Languages**, **CodeLens**.

 When the indicators are turned on, you can also open the CodeLens options from the indicators.

 ![CodeLens &#45; Turn indicators off or on](../ide/media/codelensturnoffonindicatorsfromcode.png "CodeLensTurnOffOnIndicatorsFromCode")

 Turn CodeLens file-level indicators on and off using the chevron icons at the bottom of the editor window.

 ![Turn file&#45;level indicators on and off](../ide/media/codelensfilelevelonandoff.png "CodeLensFileLevelOnAndOff")

### <a name="NoIndicators"></a> Q: Where is CodeLens?
 **A:** CodeLens appears in Visual C# .NET and Visual Basic .NET code at the method, class, indexer, and property level. CodeLens appears at the file level for all other types of files.

- Make sure CodeLens is turned on. Go to **Tools**, **Options**, **Text Editor**, **All Languages**, **CodeLens**.

- If your code is stored in TFS, make sure that code indexing is turned on by using the [CodeIndex command](../ide/codeindex-command.md) with the [TFS Config command](https://msdn.microsoft.com/94424190-3b6b-4f33-a6b6-5807f4225b62).

- TFS-related indicators appear only when work items are linked to the code and when you have permissions to open linked work items. [Confirm that you have team member permissions.](/azure/devops/organizations/security/view-permissions)

- Unit test indicators don't appear when application code doesn't have unit tests. Test status indicators appear automatically in test projects. If you know that your application code has unit tests, but the test indicators don't appear, try building the solution (**Ctrl + Shift + B**).

### Q: Why don't I see the work item details for a commit?
 **A:** This might happen because CodeLens can't find the work items in TFS. Check that you're connected to the team project that has those work items and that you have permissions to see those work items. This might also happen if the commit description has incorrect information about the work item IDs in TFS.

### <a name="NoLync"></a> Q: Why don't I see the Lync or Skype indicators?
 **A:** They don't appear if you're not signed into Lync or Skype for Business, don't have one of these installed, or don't have a supported configuration. But you can still send mail:

 ![CodeLens &#45; Contact changeset owner by mail](../ide/media/codelenscodesendmailchangesetnolync1.png "CodeLensCodeSendMailChangesetNoLync1")

 **Which Lync and Skype configurations are supported?**

- Skype for Business (32-bit or 64-bit)

- Lync 2010 or later alone (32-bit or 64-bit), but not Lync Basic 2013 with Windows 8.1

  CodeLens doesn't support having different versions of Lync or Skype installed. They might not be localized for all localized versions of Visual Studio.

### Q: How do I change the font and color for CodeLens?
 **A:** Go to **Tools**, **Options**, **Environment**, **Fonts and Colors**.

 ![CodeLens &#45; Change font and color settings](../ide/media/codelensoptionsfontscolorssettings.png "CodeLensOptionsFontsColorsSettings")

 To use the keyboard:

1. Press **Alt + T + O** to open the **Options** box.

2. Press **Up Arrow** or **Down Arrow** to go to the **Environment** node, then press **Left Arrow** to expand the node.

3. Press **Down Arrow** to go to **Fonts and Colors**.

4. Press **TAB** to go to the **Show settings for** list, and then press **Down Arrow** to select **CodeLens**.

### Q: Can I move the CodeLens heads-up display?
 **A:** Yes, choose ![CodeLens &#45; Dock as a window](../ide/media/codelensdockwindow.png "CodeLensDockWindow") to dock CodeLens as a window.

 ![Dock the CodeLens indicator window](../ide/media/codelensselectdockwindow.png "CodeLensSelectDockWindow")

 ![The docked CodeLens References window](../ide/media/codelensreferencesdockedwindow.png "CodeLensReferencesDockedWindow")

### Q: How do I refresh the indicators?
 **A:** This depends on the indicator:

- **References**: This indicator updates automatically when the code changes. If you have this indicator docked as a separate window, refresh the indicator manually here:

     ![CodeLens &#45; Dock as window](../ide/media/codelensviewreferencesdocked.png "CodeLensViewReferencesDocked")

- **Team**: Refresh these indicators manually here:

     ![CodeLens &#45; Refresh indicators](../ide/media/codelensrefreshindicatorsfromcode.png "CodeLensRefreshIndicatorsFromCode")

- **Test**: [Find unit tests for your code](#FindRunUnitTests) to refresh this indicator.

### <a name="LocalVersion"></a> Q: What's "Local Version"?
 **A:** The **Local Version** arrow points at the most recent changeset in your local version of this file. When the server has more recent changesets, they appear above or below the **Local Version** arrow, depending on the order used to sort the changesets.

### Q: Can I manage how CodeLens processes code to show history and linked items?
 **A:** Yes, if your code is in TFS, use the [CodeIndex command](../ide/codeindex-command.md) with the [TFS Config command](https://msdn.microsoft.com/94424190-3b6b-4f33-a6b6-5807f4225b62).
