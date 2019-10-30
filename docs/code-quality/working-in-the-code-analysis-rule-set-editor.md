---
title: Use the Code Analysis Rule Set Editor
ms.date: 04/04/2018
ms.topic: conceptual
f1_keywords:
  - "vs.codeanalysis.ruleseteditor"
ms.assetid: 370c97bf-bb29-4b2f-b9ae-ba125bce7b2d
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Use the code analysis rule set editor

The code analysis rule set editor lets you specify the rules that are included in a custom rule set and set the severity of rule violations.

The following table shows the severity options:

|Action (Severity)|Description|
|-|-|
|Warning|Generates a warning in the **Error List** and also at build time.|
|Error|Generates an error in the **Error List** and also at build time.|
|Info|Generates a message in the **Error List**.|
|Hidden|The violation is not visible to the user. The IDE is notified of the violation, however.|
|None|The rule is suppressed. The behavior is the same as if the rule was removed from the rule set.|

The editor displays the rules in a tree structure that groups the rules by a rule set field that you specify. To add or remove rules from a rule set, perform one or more of the following steps:

- Select or clear the check box of the group node to add or remove all the rules in the group. When you select a group, all rules are set to the **Warning** action.

   > [!TIP]
   > You can change how rules are grouped in the **Group by** drop-down.

- Click the **Action** field of a group, and then specify the action to apply to all rules in the group.

- Select or clear the check box for an individual rule. When you select the check box for a rule, the rule is set to the Warning action.

## Toolbar

You can use the toolbar of the rule set editor to group, filter, and search the data that appears in the rule set grid.

The following table describes the controls on the toolbar of the rule set editor.

|Toolbar control|Description|
|---------------------|-----------------|
|**Expand All**|Shows the rules in all groups.|
|**Collapse All**|Hides the rules in all groups.|
|**Group By**|Specifies the field by which rules are grouped. Click **\<None>** to show the rules without groups.|
|**Column Options**|Specifies the rule fields to display.|
|**Hide rules that do not apply to the current solution**|Shows or hides rules that are not of the same Target Type as the solution.|
|**Show rules that can generate Code Analysis errors**|Shows or hides rules that are assigned the Error action.|
|**Show rules that can generate Code Analysis warnings**|Shows or hides rules that are assigned the Warning action.|
|**Show rules that are not enabled**|Shows or hides rules that are assigned the None action.|
|**Add or remove child rule sets**|Adds or removes the rules in the selected rule sets.|
|**Search rules**|Searches all field values for the string that you specify.|

## Rule set fields

Rule set fields display information about a rule set, and can be used to sort and group the rule list. To display or hide fields, select **Column Options** on the rule set editor toolbar, and then check or clear the check boxes of the fields to show or hide.

The following table describes the fields of a rule set:

|Field|Description|
|-----------|-----------------|
|**ID**|The identifier of the rule.|
|**Category**|In addition to their membership in rule sets, code analysis rules are also grouped by category. For more information, see [Code analysis warnings](../code-quality/code-analysis-for-managed-code-warnings.md).|
|**Name**|The title of the rule.|
|**Namespace**|The namespace of the rule.|
|**Target Type**|Indicates whether the rule is for native, managed, or database code.|
|**Action**|The action taken when the rule is violated in a code analysis run. You can edit the **Action** field.|
|**Source Rule Sets**|The rule set that contains the rule.|

## Sort and filter rule sets

From the column headers of the rule set grid, you can sort and filter the rules by the values of the field.

- To sort the rule set lists, click the column header of the field by which you want to sort. If the rule sets are grouped, each group is sorted individually.

- To filter the rule sets by the value of a field, click the filter button on the column header of the field by which you want to filter. Select the check boxes of the values that you want to show, and clear the check boxes of the values that you want to hide.

## See also

- [Create a custom rule set](../code-quality/how-to-create-a-custom-rule-set.md)
