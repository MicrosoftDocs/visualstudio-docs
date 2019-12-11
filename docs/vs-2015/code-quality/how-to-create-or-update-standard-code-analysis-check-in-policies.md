---
title: "How to: Create or Update Standard Code Analysis Check-in Policies | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vs.codeanalysis.policyeditor"
helpviewer_keywords:
  - "code analysis, migrating check-in policy"
ms.assetid: 458eb3b8-bb5e-4056-82b7-7079ce9c4089
caps.latest.revision: 31
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# How to: Create or Update Standard Code Analysis Check-in Policies
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can require that code analysis be run on all code projects in a team project by using the code analysis check-in policy. Requiring code analysis can improve the quality of the code that is checked into the code base.

> [!NOTE]
> This feature is available only if you are using Team Foundation Server.

 Code analysis check-in policies are set in the team project settings and apply to each code project in the team project. Code analysis runs are configured for code projects in the project (.xxproj) file for the code project. Code analysis runs are performed on the local computer. When you enable a code analysis check-in policy, files in a code project that are to be checked in must be compiled after their last edit and a code analysis run that contains, at a minimum, the rules in the team project settings must be performed on the computer where the changes have been made.

- For managed code, you set the check-in policy by specifying a *rule set* that contains a subset of the code analysis rules.

- For C/C++ code, the check-in policy requires that all code analysis rules are run. You can add pre-processor directives to disable specific rules for the individual code projects in your team project.

  After you specify a check-in policy for managed code, team members can synchronize their code analysis settings for code projects to the team project policy settings.

### To open the check-in policy editor

1. In Team Explorer, right-click the team project name, point to **Team Project Settings**, and then click **Source Control**.

2. In the **Source Control** dialog box, select the **Check-in Policy** tab.

3. Do one of the following:

    - Click **Add** to create a new check-in policy.

    - Double-click the existing **Code Analysis** item in the **Policy Type** list to change the policy.

### To set policy options

- Select or clear the following options:

    |Option|Description|
    |------------|-----------------|
    |**Enforce check-in to only contain files that are part of current solution.**|Code analysis can run only on files specified in solution and project configuration files. This policy guarantees that all code that is part of a solution is analyzed.|
    |**Enforce C/C++ Code Analysis (/analyze)**|Requires that all C or C++ projects be built with the /analyze compiler option to run code analysis before they can be checked in.|
    |**Enforce Code Analysis for Managed Code**|Requires that all managed projects run code analysis and build before they can be checked in.|

-

### To specify a managed rule set

- From the **Run this rule set** list, use one of the following methods:

  - Select a Microsoft standard rule set.

  - To select a custom rule set, click **\<Select Rule Set from Source Control...>**, and then type the version control path of the rule set in the source control browser. The syntax of a version control path is:

  - **$/** `TeamProjectName` **/** `VersionControlPath`

  - For more information about how to create and implement a custom check-in policy rule set, see [Implementing Custom Check-in Policies for Managed Code](../code-quality/implementing-custom-code-analysis-check-in-policies-for-managed-code.md).

## See Also
 [Creating and Using Code Analysis Check-In Policies](../code-quality/creating-and-using-code-analysis-check-in-policies.md)
