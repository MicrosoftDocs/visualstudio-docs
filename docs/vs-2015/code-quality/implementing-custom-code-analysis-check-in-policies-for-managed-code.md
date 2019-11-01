---
title: "Implementing Custom Code Analysis Check-in Policies for Managed Code | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vs.code.analysis.selecttfsrulesets"
  - "vs.code.analysis.browsefortfsruleset"
  - "vs.code.analysis.policyeditor"
ms.assetid: fd029003-5671-4b24-8b6f-032e0a98b2e8
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Implementing Custom Code Analysis Check-in Policies for Managed Code
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A code analysis check-in policy specifies a set of rules that members of a team project must run on source code before it is checked in to version control. Microsoft provides a set of standard *rule sets* that group code analysis rules into functional areas. *Custom check-in policy rule sets* specify a set of code analysis rules that are specific to a team project. A rule set is stored in a .ruleset file.

 Check-in policies are set at the team project level and specified by the location of a .ruleset file in the version control tree. There are no restrictions on the version control location of the team policy custom rule set.

 Code analysis is configured for the individual code projects in the properties window for each project. A custom rule set for a code project is specified by the physical location of the .ruleset file on the local computer. When a .ruleset file is specified that is located on the same drive as the code project, Visual Studio uses a relative path to the file in the project configuration.

 A suggested practice for creating a team project custom rule set is to store the check-in policy .ruleset file in a special folder that is not a part of any code project. If you store the file in a dedicated folder, you can apply permissions that restrict who can edit the rule file, and you can easily move the directory structure that contains the project to another directory or computer.

## Creating the Team Project Custom Check-in Rule Set
 To create a custom rule set for a team project, you first create a special folder for the check-in policy rule set in **Source Control Explorer**. Then you create the rule set file and add the file to version control. Finally, you specify the rule set as the code analysis check-in policy for the team project.

> [!NOTE]
> To create a folder in a team project, you first must map the team project root to a location on the local computer. For more information, see [Create and work with workspaces (old)](https://msdn.microsoft.com/db4d5692-179a-44fe-ad31-0c1c900c9cb2).

#### To create the version control folder for the check-in policy rule set

1. In [!INCLUDE[esprtfc](../includes/esprtfc-md.md)], expand the team project node, and then click **Source Control**.

2. In the **Folders** pane, right-click the team project and then click **New Folder**.

3. In the main Source Control pane, right-click **New Folder**, click **Rename**, and type a name for the rule set folder.

#### To create the check-in policy rule set

1. On the **File** menu, point to **New**, and then click **File**.

2. In the **Categories** list, click **General**.

3. In the **Templates** list, double-click **Code Analysis Rule Set**.

4. Specify the rules to include in the rule set, and then save the rule set file to the rule set folder that you created.

     For more information, see [Creating Custom Rule Sets](../code-quality/creating-custom-code-analysis-rule-sets.md)

#### To add the rule set file to version control

1. In **Source Control Explorer**, right-click the new folder, and then click **Add Items to Folder**.

     For more information, see [Use version control](https://msdn.microsoft.com/library/33267cee-fe5f-4aa3-b2cd-6d22ceace314).

2. Click the rule set file that you created, and then click **Finish**.

     The file is added to source control and checked out to you.

3. In the **Source Control Explorer** details window, right-click the file name and then click **Check in Pending Changes**.

4. In the **Check-in** dialog box, you  have the option to add a comment and then click **Check In**.

    > [!NOTE]
    > If you have already configured a code analysis check-in policy for your team project and you have selected the **Enforce check-in to only contain files that are part of current solution**, you will trigger a policy failure warning. In the Policy Failure dialog box, select **Override policy failure and continue checkin**. Add a required comment, and then click **OK**.

#### To specify the rule set file as the check-in policy

1. On the **Team** menu, point to **Team Project Settings**, and then click **Source Control**.

2. Click **Check-in Policy**, and then click **Add**.

3. In the **Check-in Policy** list, double-click **Code Analysis**, and make sure that the **Enforce Code Analysis for Managed Code** check box is selected.

4. In the **Run this rule set** list, click **\<Select Rule Set from Source Control>**.

5. Type the path of the check-in policy rule set file in version control.

     The path must conform to the following syntax:

     **$/** `TeamProjectName` **/** `VersionControlPath`

    > [!NOTE]
    > You can copy the path by using one of the following procedures in **Source Control Explorer**:

    - In the **Folders** pane, click the folder that contains the rule set file. Copy the version control path of the folder that appears in the **Source** box, and type the name of the rule set file manually.

    - In the details window, right-click the rule set file, and then click **Properties**. On the **General** tab, copy the value in **Server Name**.

## Synchronizing Code Projects to the Check-in Policy Rule Set
 You specify a team project check-in policy rule set as the code analysis rule set of a code project configuration in the properties dialog box of the code project. If the rule set is located on the same drive as the code project, a relative path is used to specify rule set when the path is selected from the file dialog box. The relative path enables the project properties settings to be portable to other computers that use similar local version control structures.

#### To specify a team project rule set as the rule set of a code project

1. If necessary, retrieve the check-in policy rule set folder and file from version control.

     You can perform this step in **Source Control Explorer** by right-clicking the rule set folder and then clicking **Get Latest Version**.

2. In **Solution Explorer**, right-click the code project, and then click **Properties**.

3. **Click Code Analysis**.

4. If necessary, click the appropriate options in the **Configuration** and **Platform** lists.

5. To run code analysis every time that the code project is built using the specified configuration, select the **Enable Code Analysis on Build (defines CODE_ANALYSIS constant)** check box.

6. To ignore code in components from other companies, select the **Suppress results from generated code** check box.

7. In the **Run this rule set** list, click **\<Browse...>**.

8. Specify the local version of the check-in policy rule set file.
