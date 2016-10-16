---
title: "Using Rule Sets to Group Code Analysis Rules"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.codeanalysis.rulesets.learnmore"
helpviewer_keywords: 
  - "code analysis, rule sets"
ms.assetid: ed0f3a2a-1516-42e2-92de-b8986dc75d42
caps.latest.revision: 36
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Using Rule Sets to Group Code Analysis Rules
When you configure code analysis in [!INCLUDE[vsUltLong](../codequality/includes/vsultlong_md.md)], [!INCLUDE[vsPreLong](../codequality/includes/vsprelong_md.md)], or [!INCLUDE[vsPro](../codequality/includes/vspro_md.md)], you can choose from a list of Microsoft built-in *rule sets*. A rule set is a logical grouping of code analysis rules that identify targeted issues and specific conditions. For example, you can apply a rule set that is designed to scan code for publicly available APIs, or you can apply a rule set that includes only the minimum recommended rules. You can also apply a rule set that includes all the rules.  
  
 You can customize a rule set by adding or deleting rules, or by changing rules to appear in the **Error List** window as either warnings or errors. Customized rule sets can fulfill a need for your particular development environment. When you customize a rule set, the rule set page provides search and filtering tools to help you in the process.  
  
## Common Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Get hands-on practice:** Use the code analysis tools to specify a custom rule set to find and fix issues in a simple .NET Framework application.|-   [Walkthrough: Configuring and Using a Custom Rule Set](../codequality/walkthrough--configuring-and-using-a-custom-rule-set.md)|  
|**Configure code analysis for a project:** Choose an existing rule set for a project, Web site, or solution.|-   [How to: Configure Code Analysis for a Managed Code Project](../codequality/how-to--configure-code-analysis-for-a-managed-code-project.md)<br />-   [Using Rule Sets to Specify the C++ Rules to Run](../codequality/using-rule-sets-to-specify-the-c---rules-to-run.md)<br />-   [How to: Configure Code Analysis for an ASP.NET Web Application](../codequality/how-to--configure-code-analysis-for-an-asp.net-web-application.md)<br />-   [How to: Specify Rule Sets for Multiple Projects in a Solution](../codequality/how-to--specify-managed-code-rule-sets-for-multiple-projects-in-a-solution.md)|  
|**Customize a rule set:** Specify rules to apply to your project.|-   [Creating Custom Rule Sets](../codequality/creating-custom-code-analysis-rule-sets.md)|  
|**Understand the built-in rule sets:** View the code analysis rules that make up the built-in rule sets.|-   [Code analysis rule set reference](../codequality/code-analysis-rule-set-reference.md)|  
|**Integrate code analysis with Team Foundation Server:** [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] check-in policies enable development teams to make sure that all code check-ins meet a common set of code analysis standards.|-   [How to: Synchronize Code Project Rule Sets with Team Project Check-in Policy](../codequality/how-to--synchronize-code-project-rule-sets-with-team-project-check-in-policy.md)|