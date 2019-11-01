---
title: "How to: Synchronize Code Project Rule Sets with Team Project Check-in Policy | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vs.codeanalysis.selecttfsruleset"
ms.assetid: 9b02f934-2db6-41ec-aaff-9c31ceec2f04
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# How to: Synchronize Code Project Rule Sets with Team Project Check-in Policy
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You synchronize the code analysis settings for code projects to the check-in policy for the team project by specifying a rule set that contains at least the rules that are specified in the rule set for the check-in policy. Your developer lead can inform you of the name and location of the rule set for the check-in policy. You can use one of the following options to ensure that code analysis for the project uses the correct set of rules:

- If the check-in policy uses one of the Microsoft built-in rule sets, open the properties dialog box for the code project, display the Code Analysis page, and select the rule set on the Code Analysis page of the code project settings. The Microsoft standard rule sets are automatically installed with Visual Studio are set to read-only and should not be edited. If the rule sets are not edited, the rules in the policy and local rule sets are guaranteed to match.

- If the check-in policy uses a custom rule set, perform a get operation on the rule set file in version control to create a local copy. Then specify that local location in the code analysis settings for the code project. The rules are guaranteed to match if the rule set for the check-in policy is up to date.

     If you map the version control location to a local folder that is in the same relationship to the team project root as your code project, the location of the rule is set by using a relative path. The relative path ensures that the code project setting for code analysis can be moved to other computers.

- Customize a copy of the rule set for the check-in policy for a code project. Make sure that the new rule set contains all the rules in the check-in policy and any other rules that you want to include. You must make sure that your rule set includes all the rules in the rule set for the check-in policy.

### To specify a Microsoft standard rule set

1. In **Solution Explorer**, right-click the code project, and then click **Properties**.

2. Click **Code Analysis**.

3. In the **Run this rule set** list, click the check-in policy rule set.

### To specify a custom check-in policy rule set

1. If necessary, perform a get operation on the rule set file that specifies the check-in policy.

2. In **Solution Explorer**, right-click the code project, and then click **Properties**.

3. Click **Code Analysis**.

4. In the **Run this rule set** list, click **\<Browse...>**.

5. In the **Open** dialog box, specify the check-in policy rule set file.

### To create a custom rule set for a code project

1. Follow one of the procedures earlier in this topic to select the check-in policy of the team project on the Code Analysis page of the project settings dialog box.

2. Click **Open**.

3. Add or remove rules by using the rule set editor.

     For more information, see [Creating Custom Rule Sets](../code-quality/creating-custom-code-analysis-rule-sets.md).

4. Save the modified rule set to a .ruleset file on the local computer or to a UNC path.

5. Open the properties dialog box for the code project, and display the **Code Analysis** page.

6. In the **Run this rule set** list, click **\<Browse...>**.

7. In the **Open** dialog box, specify the rule set file.
