---
title: "How to: Configure Code Analysis for an ASP.NET Web Application | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vs.codeanalysis.propertypages.asp"
ms.assetid: b3000b31-fd9d-489e-81a2-a4bee49453ba
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# How to: Configure Code Analysis for an ASP.NET Web Application
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In [!INCLUDE[vsPreShort](../includes/vspreshort-md.md)] and [!INCLUDE[vsUltShort](../includes/vsultshort-md.md)] you can select from a list of Code Analysis *rule sets* to apply to [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] Web application. The default rule set is the Microsoft Mininimum Recommended Rules. You can select another rule set to apply to the Web site.

### To configure a rule set for an ASP.NET Page Framework project

1. Select the Web site in **Solution Explorer**.

2. On the **Analyze** menu, click **Configure Code Analysis for Web Site**.

3. If you selected the solution and the solution has more than one project, select the build configuration and target operating system from the **Configuration** and **Platform** lists.

4. For each project in the solution, click the **Rule Set** column, and then click the name of the rule set to run.

5. By default, code analysis is run on all projects in the solution. To disable or enable code analysis for a particular project, follow these steps:

    1. Right-click the project name and then click Properties.

    2. Check or clear the **Enable Code Analysis** check box. You can also run code analysis manually by selecting **Run Code Analysis on Web Site** from the **Analyze** menu.

6. In the **Run this rule set** drop-down list, follow these steps:

    - Select the rule set that you want to use.

    - Select **\<Browse>** to specify an existing custom rule set that is not in the list.

    - Define a custom rule set. For more information, see [Creating Custom Rule Sets](../code-quality/creating-custom-code-analysis-rule-sets.md).
