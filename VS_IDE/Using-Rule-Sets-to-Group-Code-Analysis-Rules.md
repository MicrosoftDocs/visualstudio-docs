---
title: "Using Rule Sets to Group Code Analysis Rules"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ed0f3a2a-1516-42e2-92de-b8986dc75d42
caps.latest.revision: 36
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Using Rule Sets to Group Code Analysis Rules
When you configure code analysis in Visual Studio Ultimate, Visual Studio Premium, or Visual Studio Professional, you can choose from a list of Microsoft built-in *rule sets*. A rule set is a logical grouping of code analysis rules that identify targeted issues and specific conditions. For example, you can apply a rule set that is designed to scan code for publicly available APIs, or you can apply a rule set that includes only the minimum recommended rules. You can also apply a rule set that includes all the rules.  
  
 You can customize a rule set by adding or deleting rules, or by changing rules to appear in the **Error List** window as either warnings or errors. Customized rule sets can fulfill a need for your particular development environment. When you customize a rule set, the rule set page provides search and filtering tools to help you in the process.  
  
## Common Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Get hands-on practice:** Use the code analysis tools to specify a custom rule set to find and fix issues in a simple .NET Framework application.|-   [Walkthrough: Configuring and Using a Custom Rule Set](../VS_IDE/Walkthrough--Configuring-and-Using-a-Custom-Rule-Set.md)|  
|**Configure code analysis for a project:** Choose an existing rule set for a project, Web site, or solution.|-   [How to: Configure Code Analysis for a Managed Code Project](../VS_IDE/How-to--Configure-Code-Analysis-for-a-Managed-Code-Project.md)<br />-   [Using Rule Sets to Specify the C++ Rules to Run](../VS_IDE/Using-Rule-Sets-to-Specify-the-C---Rules-to-Run.md)<br />-   [How to: Configure Code Analysis for an ASP.NET Web Application](../VS_IDE/How-to--Configure-Code-Analysis-for-an-ASP.NET-Web-Application.md)<br />-   [How to: Specify Rule Sets for Multiple Projects in a Solution](../VS_IDE/How-to--Specify-Managed-Code-Rule-Sets-for-Multiple-Projects-in-a-Solution.md)|  
|**Customize a rule set:** Specify rules to apply to your project.|-   [Creating Custom Rule Sets](../VS_IDE/Creating-Custom-Code-Analysis-Rule-Sets.md)|  
|**Understand the built-in rule sets:** View the code analysis rules that make up the built-in rule sets.|-   [Code analysis rule set reference](../VS_IDE/Code-analysis-rule-set-reference.md)|  
|**Integrate code analysis with Team Foundation Server:** Team Foundation Server check-in policies enable development teams to make sure that all code check-ins meet a common set of code analysis standards.|-   [How to: Synchronize Code Project Rule Sets with Team Project Check-in Policy](../VS_IDE/How-to--Synchronize-Code-Project-Rule-Sets-with-Team-Project-Check-in-Policy.md)|