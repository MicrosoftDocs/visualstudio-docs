---
title: "Analyzing Managed Code Quality by Using Code Analysis"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 68510a55-da51-4381-81a5-0feba76b8b4f
caps.latest.revision: 24
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Analyzing Managed Code Quality by Using Code Analysis
You can use the code analysis tools in Visual Studio to discover potential issues in your code, such as non-secure data access, usage violations, and design problems. Code analysis works on .NET Framework, native (C and C++), and database applications. Code analysis for managed code organizes rules in *rule sets* that target specific coding issues.  
  
## Common Tasks  
  
|Common Tasks|Supporting Content|  
|------------------|------------------------|  
|**Get hands-on practice:** Learn the basics of code analysis by correcting defects in a simple .NET Framework application.|-   [Walkthrough: Analyzing Managed Code for Code Defects](../VS_IDE/Walkthrough--Analyzing-Managed-Code-for-Code-Defects.md)|  
|**Configure code analysis for a project:** Rules for managed code are organized into rule sets that target specific areas, such as security and design. You can use one of the Microsoft standard rule sets or create your own.|-   [Code Analysis for Managed Code Overview](../VS_IDE/Code-Analysis-for-Managed-Code-Overview.md)<br />-   [Using Rule Sets to Group Code Analysis Rules](../VS_IDE/Using-Rule-Sets-to-Group-Code-Analysis-Rules.md)<br />-   [Suppress Warnings By Using the SuppressMessage Attribute](../VS_IDE/Suppress-Warnings-By-Using-the-SuppressMessage-Attribute.md)|  
|**Run code analysis:** You can specify code analysis to be run automatically every time that a project configuration is built, and you can run code analysis manually on a project.|-   [How to: Enable and Disable Automatic Code Analysis](../VS_IDE/How-to--Enable-and-Disable-Automatic-Code-Analysis-for-Managed-Code.md)<br />-   [How to: Run Code Analysis Manually](../VS_IDE/How-to--Run-Code-Analysis-Manually-for-Managed-Code.md)|  
|**Analyze code analysis results:** Code analysis warnings and errors are listed in the Code Analysis window. You can choose a warning or an error title to display additional information about the warning, and to display and highlight the source code line that fired the rule. You can choose the warning id to display detailed information in the MSDN Library that includes information and examples of how to resolve the issue.|-   [How to: View Managed Code Defects](../VS_IDE/How-to--View-Managed-Code-Defects.md)<br />-   [Code Analysis for Managed Code Warnings](../VS_IDE/Code-Analysis-for-Managed-Code-Warnings.md)<br />-   [Warnings By CheckId](../VS_IDE/Code-Analysis-Warnings-for-Managed-Code-by-CheckId.md)<br />-   [Anonymous Methods and Code Analysis](../VS_IDE/Anonymous-Methods-and-Code-Analysis.md)|  
|**Integrate code analysis with your development life-cycle:** Check-in policies in Team Foundation version control enable development teams to make sure that all code check-ins meet a common set of code analysis standards. Creating a work item for a code analysis rule violation is simple procedure that you can perform in the Error List window.|-   [Enhancing Code Quality with Team Project Check-in Policies](../VS_IDE/Enhancing-Code-Quality-with-Team-Project-Check-in-Policies.md)<br />-   [How to: Synchronize Code Project Rule Sets with Team Project Check-in Policy](../VS_IDE/How-to--Synchronize-Code-Project-Rule-Sets-with-Team-Project-Check-in-Policy.md)<br />-   [How to: Create a Work Item for a Managed Code Defect](../VS_IDE/How-to--Create-a-Work-Item-for-a-Managed-Code-Defect.md)|