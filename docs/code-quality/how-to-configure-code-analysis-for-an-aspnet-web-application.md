---
title: "How to: Configure Code Analysis for an ASP.NET Web Application | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.codeanalysis.propertypages.asp"
ms.assetid: b3000b31-fd9d-489e-81a2-a4bee49453ba
caps.latest.revision: 13
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
# How to: Configure Code Analysis for an ASP.NET Web Application
In [!INCLUDE[vsPreShort](../code-quality/includes/vspreshort_md.md)] and [!INCLUDE[vsUltShort](../code-quality/includes/vsultshort_md.md)] you can select from a list of Code Analysis *rule sets* to apply to [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web application. The default rule set is the Microsoft Mininimum Recommended Rules. You can select another rule set to apply to the Web site.  
  
### To configure a rule set for an ASP.NET Page Framework project  
  
1.  Select the Web site in **Solution Explorer**.  
  
2.  On the **Analyze** menu, click **Configure Code Analysis for Web Site**.  
  
3.  If you selected the solution and the solution has more than one project, select the build configuration and target operating system from the **Configuration** and **Platform** lists.  
  
4.  For each project in the solution, click the **Rule Set** column, and then click the name of the rule set to run.  
  
5.  By default, code analysis is run on all projects in the solution. To disable or enable code analysis for a particular project, follow these steps:  
  
    1.  Right-click the project name and then click Properties.  
  
    2.  Check or clear the **Enable Code Analysis** check box. You can also run code analysis manually by selecting **Run Code Analysis on Web Site** from the **Analyze** menu.  
  
6.  In the **Run this rule set** drop-down list, follow these steps:  
  
    -   Select the rule set that you want to use.  
  
    -   Select **\<Browse>** to specify an existing custom rule set that is not in the list.  
  
    -   Define a custom rule set. For more information, see [Creating Custom Rule Sets](../code-quality/creating-custom-code-analysis-rule-sets.md).