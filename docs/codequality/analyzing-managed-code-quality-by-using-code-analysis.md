---
title: "Analyzing Managed Code Quality by Using Code Analysis"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "code analysis,managed code"
  - "managed code analyis"
ms.assetid: 68510a55-da51-4381-81a5-0feba76b8b4f
caps.latest.revision: 24
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Analyzing Managed Code Quality by Using Code Analysis
You can use the code analysis tools in Visual Studio to discover potential issues in your code, such as non-secure data access, usage violations, and design problems. Code analysis works on .NET Framework, native (C and C++), and database applications. Code analysis for managed code organizes rules in *rule sets* that target specific coding issues.  
  
## Common Tasks  
  
|Common Tasks|Supporting Content|  
|------------------|------------------------|  
|**Get hands-on practice:** Learn the basics of code analysis by correcting defects in a simple .NET Framework application.|-   [Walkthrough: Analyzing Managed Code for Code Defects](../codequality/walkthrough--analyzing-managed-code-for-code-defects.md)|  
|**Configure code analysis for a project:** Rules for managed code are organized into rule sets that target specific areas, such as security and design. You can use one of the Microsoft standard rule sets or create your own.|-   [Code Analysis for Managed Code Overview](../codequality/code-analysis-for-managed-code-overview.md)<br />-   [Using Rule Sets to Group Code Analysis Rules](../codequality/using-rule-sets-to-group-code-analysis-rules.md)<br />-   [Suppress Warnings By Using the SuppressMessage Attribute](../codequality/suppress-warnings-by-using-the-suppressmessage-attribute.md)|  
|**Run code analysis:** You can specify code analysis to be run automatically every time that a project configuration is built, and you can run code analysis manually on a project.|-   [How to: Enable and Disable Automatic Code Analysis](../codequality/how-to--enable-and-disable-automatic-code-analysis-for-managed-code.md)<br />-   [How to: Run Code Analysis Manually](../codequality/how-to--run-code-analysis-manually-for-managed-code.md)|  
|**Analyze code analysis results:** Code analysis warnings and errors are listed in the Code Analysis window. You can choose a warning or an error title to display additional information about the warning, and to display and highlight the source code line that fired the rule. You can choose the warning id to display detailed information in the MSDN Library that includes information and examples of how to resolve the issue.|-   [How to: View Managed Code Defects](../codequality/how-to--view-managed-code-defects.md)<br />-   [Code Analysis for Managed Code Warnings](../codequality/code-analysis-for-managed-code-warnings.md)<br />-   [Warnings By CheckId](../codequality/code-analysis-warnings-for-managed-code-by-checkid.md)<br />-   [Anonymous Methods and Code Analysis](../codequality/anonymous-methods-and-code-analysis.md)|  
|**Integrate code analysis with your development life-cycle:** Check-in policies in [!INCLUDE[esprscc](../codequality/includes/esprscc_md.md)] enable development teams to make sure that all code check-ins meet a common set of code analysis standards. Creating a work item for a code analysis rule violation is simple procedure that you can perform in the Error List window.|-   [Enhancing Code Quality with Team Project Check-in Policies](../codequality/enhancing-code-quality-with-team-project-check-in-policies.md)<br />-   [How to: Synchronize Code Project Rule Sets with Team Project Check-in Policy](../codequality/how-to--synchronize-code-project-rule-sets-with-team-project-check-in-policy.md)<br />-   [How to: Create a Work Item for a Managed Code Defect](../codequality/how-to--create-a-work-item-for-a-managed-code-defect.md)|