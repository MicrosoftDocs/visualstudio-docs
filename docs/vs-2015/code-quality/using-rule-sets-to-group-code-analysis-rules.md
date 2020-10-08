---
title: "Using Rule Sets to Group Code Analysis Rules | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vs.codeanalysis.rulesets.learnmore"
helpviewer_keywords:
  - "code analysis, rule sets"
ms.assetid: ed0f3a2a-1516-42e2-92de-b8986dc75d42
caps.latest.revision: 38
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Using Rule Sets to Group Code Analysis Rules
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you configure code analysis in [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], or [!INCLUDE[vsPro](../includes/vspro-md.md)], you can choose from a list of Microsoft built-in *rule sets*. A rule set is a logical grouping of code analysis rules that identify targeted issues and specific conditions. For example, you can apply a rule set that is designed to scan code for publicly available APIs, or you can apply a rule set that includes only the minimum recommended rules. You can also apply a rule set that includes all the rules.

 You can customize a rule set by adding or deleting rules, or by changing rules to appear in the **Error List** window as either warnings or errors. Customized rule sets can fulfill a need for your particular development environment. When you customize a rule set, the rule set page provides search and filtering tools to help you in the process.

## Common Tasks

|Task|Related Content|
|----------|---------------------|
|**Get hands-on practice:** Use the code analysis tools to specify a custom rule set to find and fix issues in a simple .NET Framework application.|-   [Walkthrough: Configuring and Using a Custom Rule Set](../code-quality/walkthrough-configuring-and-using-a-custom-rule-set.md)|
|**Configure code analysis for a project:** Choose an existing rule set for a project, Web site, or solution.|-   [How to: Configure Code Analysis for a Managed Code Project](../code-quality/how-to-configure-code-analysis-for-a-managed-code-project.md)<br />-   [Using Rule Sets to Specify the C++ Rules to Run](../code-quality/using-rule-sets-to-specify-the-cpp-rules-to-run.md)<br />-   [How to: Configure Code Analysis for an ASP.NET Web Application](../code-quality/how-to-configure-code-analysis-for-an-aspnet-web-application.md)<br />-   [How to: Specify Rule Sets for Multiple Projects in a Solution](../code-quality/how-to-specify-managed-code-rule-sets-for-multiple-projects-in-a-solution.md)|
|**Customize a rule set:** Specify rules to apply to your project.|-   [Creating Custom Rule Sets](../code-quality/creating-custom-code-analysis-rule-sets.md)|
|**Understand the built-in rule sets:** View the code analysis rules that make up the built-in rule sets.|-   [Code analysis rule set reference](../code-quality/code-analysis-rule-set-reference.md)|
|**Integrate code analysis with Team Foundation Server:** [!INCLUDE[esprtfs](../includes/esprtfs-md.md)] check-in policies enable development teams to make sure that all code check-ins meet a common set of code analysis standards.|-   [How to: Synchronize Code Project Rule Sets with Team Project Check-in Policy](../code-quality/how-to-synchronize-code-project-rule-sets-with-team-project-check-in-policy.md)|
