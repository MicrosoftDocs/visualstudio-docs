---
title: "Sync project rule sets with check-in policy"
ms.date: 11/04/2016
ms.topic: conceptual
f1_keywords:
  - "vs.codeanalysis.selecttfsruleset"
ms.assetid: 9b02f934-2db6-41ec-aaff-9c31ceec2f04
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Synchronize Code Project Rule Sets with an Azure DevOps Project Check-in Policy

You synchronize the code analysis settings for code projects to the check-in policy for the Azure DevOps project by specifying a rule set that contains at least the rules that are specified in the rule set for the check-in policy. Your developer lead can inform you of the name and location of the rule set for the check-in policy. You can use one of the following options to ensure that code analysis for the project uses the correct set of rules:

- If the check-in policy uses one of the Microsoft built-in rule sets, open the properties dialog box for the code project, display the Code Analysis page, and select the rule set. The Microsoft standard rule sets are automatically installed with Visual Studio are set to read-only and should not be edited. If the rule sets are not edited, the rules in the policy and local rule sets are guaranteed to match.

- If the check-in policy uses a custom rule set, perform a get operation on the rule set file in version control to create a local copy. Then specify that local location in the code analysis settings for the code project. The rules are guaranteed to match if the rule set for the check-in policy is up to date.

     If you map the version control location to a local folder that is in the same relationship to the Azure DevOps project root as your code project, the location of the rule is set by using a relative path. The relative path ensures that the code project setting for code analysis can be moved to other computers.

- Customize a copy of the rule set for the check-in policy for a code project. Make sure that the new rule set contains all the rules in the check-in policy and any other rules that you want to include. You must make sure that your rule set includes all the rules in the rule set for the check-in policy.

## To specify a Microsoft standard rule set

1. In **Solution Explorer**, right-click the code project, and then click **Properties**.

2. Click **Code Analysis**.

::: moniker range="vs-2017"

3. In the **Run this rule set** list, select the check-in policy rule set.

::: moniker-end

::: moniker range=">=vs-2019"

3. In the **Active rules** list, select the check-in policy rule set.

::: moniker-end

## To specify a custom check-in policy rule set

1. If necessary, perform a get operation on the rule set file that specifies the check-in policy.

2. In **Solution Explorer**, right-click the code project, and then click **Properties**.

3. Click **Code Analysis**.

::: moniker range="vs-2017"

4. In the **Run this rule set** list, click **\<Browse>**.

::: moniker-end

::: moniker range=">=vs-2019"

4. In the **Active rules** list, click **\<Browse>**.

::: moniker-end

5. In the **Open** dialog box, specify the check-in policy rule set file.

## To create a custom rule set for a code project

For information about creating a custom rule set, see [Customize a rule set](how-to-create-a-custom-rule-set.md).
