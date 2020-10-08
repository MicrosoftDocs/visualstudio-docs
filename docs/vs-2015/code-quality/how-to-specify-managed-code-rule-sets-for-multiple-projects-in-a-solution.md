---
title: "How to: Specify Managed Code Rule Sets for Multiple Projects in a Solution | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vs.codeanalysis.propertypages.solution"
ms.assetid: 92dc3250-a010-4396-b515-f03a0b30cd2a
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# How to: Specify Managed Code Rule Sets for Multiple Projects in a Solution
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By default, all the managed projects of a solution are assigned the Microsoft Minimum Recommended Rules code analysis *rule set*. You can change the rule sets that are assigned to the projects of a solution in the properties dialog box for the solution.

> [!NOTE]
> By default, project code analysis is not run as a build step. To enable code analysis as a build step, see [How to: Configure Code Analysis for a Managed Code Project](../code-quality/how-to-configure-code-analysis-for-a-managed-code-project.md).

### To specify a rule set for multiple projects in a managed code  solution

1. In [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)]. [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], or [!INCLUDE[vsPro](../includes/vspro-md.md)] open the solution.

2. On the **Analyze** menu, click **Configure Code Analysis for Solution**.

3. If necessary, expand **Common Properties**, and then click **Code Analysis Settings**.

4. You can specify a rule set for one or more projects.

    - To specify a rule set for an individual project, click the project name.

    - To specify a rule set for multiple projects, hold down CTRL and click the project names.

    - To specify all the projects in the solution, hold down SHIFT and click in the project list.

5. Click the **Rule Set** field of a project and then click the name of the rule set that you want to apply.
