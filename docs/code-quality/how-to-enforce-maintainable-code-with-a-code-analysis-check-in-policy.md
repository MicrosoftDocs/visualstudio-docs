---
title: "How to: Enforce Maintainable Code with a Code Analysis Check-in Policy | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "code analysis, check-in policies"
ms.assetid: d1b3b04f-4dd9-40e6-b2d4-b414d33fb647
caps.latest.revision: 8
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
# How to: Enforce Maintainable Code with a Code Analysis Check-in Policy
Developers can use the Code Metrics tool to measure the complexity and maintainability of their code, but they cannot invoke code metrics as part of a check-in policy. However, a team  can enable Code Analysis rules that verify the compliance of their code with Code Metrics standards and enforce the rules through check-in policies. For more information about code metrics, see the [Code Metrics Values](../code-quality/code-metrics-values.md).  
  
 Developers can enable the Depth of Inheritance, Class Coupling, Maintainability Index, and Complexity rules to enforce maintainable code through Code Analysis check-in policies. All four of these rules are found under the "Maintainability Rules" category in the Code Analysis policy editor.  
  
 Administrators of version control for [!INCLUDE[esprfound](../code-quality/includes/esprfound_md.md)] can add the Code Analysis Maintainability Rules to the check-in policy requirements. These check-in policies require developers to run Code Analysis based on these rule changes before initiating a check-in.  
  
### To open the Code Analysis Policy Editor  
  
1.  In **Team Explorer**, right-click the team project, click **Team Project Settings**, and then click **Source Control**.  
  
     The **Source Control** dialog box appears.  
  
2.  On the **Check-in Policy** tab, and click **Add**.  
  
     The **Add Check-in Policy** dialog box appears.  
  
3.  In the **Check-in Policy** list, select the **Code Analysis** check box, and then click **OK**.  
  
     The **Code Analysis Policy Editor** dialog box appears.  
  
### To enable Code Analysis Maintainability Rules  
  
1.  In the **Code Analysis Policy Editor** dialog box, under **Rule Settings**, expand the **Maintainability Rules** node.  
  
2.  Select the check boxes for the following rules:  
  
    -   Depth of Inheritance: **CA1501 AvoidExcessiveInheritance** - Threshold: Warning at more than 5 levels deep  
  
    -   Complexity: **CA1502 AvoidExcessiveComplexity** - Threshold: Warning at more than 25  
  
    -   Maintainability Index: **CA1505 AvoidUnmaintainableCode** - Threshold: Warning at fewer than 20  
  
    -   Class Coupling: **CA1506 AvoidExcessiveClassCoupling** - Threshold: Warning at more than 80 for a class and more than 30 for a method  
  
    -   In addition, if you want a rule violation to prevent a build, select the **Treat Warning As An Error** check box next to the rule description.  
  
3.  Click **OK**. The new check-in policy now applies to future check-ins.  
  
## See Also  
 [Code Metrics Values](../code-quality/code-metrics-values.md)   
 [Creating and Using Code Analysis Check-In Policies](../code-quality/creating-and-using-code-analysis-check-in-policies.md)