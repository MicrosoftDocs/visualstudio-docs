---
title: Configure Code Analysis for ASP.NET Web app
ms.date: 11/04/2016
ms.topic: "conceptual"
f1_keywords:
  - "vs.codeanalysis.propertypages.asp"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "aspnet"
---
# How to: Configure Code Analysis for an ASP.NET Web Application

In Visual Studio, you can select from a list of Code Analysis *rule sets* to apply to [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application. The default rule set is the Microsoft Minimum Recommended Rules. You can select another rule set to apply to the web site.

1. Select the web site in **Solution Explorer**.

2. On the **Analyze** menu, click **Configure Code Analysis for Web Site**.

3. If you selected the solution and the solution has more than one project, select the build configuration and target operating system from the **Configuration** and **Platform** lists.

4. For each project in the solution, click the **Rule Set** column, and then click the name of the rule set to run.

5. By default, code analysis is run on all projects in the solution. To disable or enable code analysis for a particular project, follow these steps:

    1. Right-click the project name and then click Properties.

    2. Check or clear the **Enable Code Analysis** check box. You can also run code analysis manually by selecting **Run Code Analysis on Web Site** from the **Analyze** menu.

6. In the **Run this rule set** drop-down list, follow these steps:

    - Select the rule set that you want to use.

    - Select **\<Browse>** to specify an existing custom rule set that is not in the list.

    - Define a [custom rule set](../code-quality/how-to-create-a-custom-rule-set.md).