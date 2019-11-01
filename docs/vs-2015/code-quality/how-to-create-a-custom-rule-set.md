---
title: "How to: Create a Custom Rule Set | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vs.codeanalysis.addremoverulesets"
helpviewer_keywords:
  - "Development Edition, rule sets"
ms.assetid: bcc42508-9592-4802-9f66-a50111641d73
caps.latest.revision: 26
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# How to: Create a Custom Rule Set
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In [!INCLUDE[vsUltShort](../includes/vsultshort-md.md)], [!INCLUDE[vsPreShort](../includes/vspreshort-md.md)], and [!INCLUDE[vsPro](../includes/vspro-md.md)], you can create and modify a custom *rule set* to meet specific project needs associated with code analysis. To create a custom rule set, you open one or more standard rule sets in the rule set editor. You can then add or remove specific rules and you can change the action that occurs when code analysis determines that a rule has been violated.

 To create a new custom rule set, you save it by using a new file name. The custom rule set is automatically assigned to the project.

## Opening the rule set editor

#### To open an empty rule set file in the rule set editor

1. On the **File** menu of [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)], point to **New** and then click **File**.

2. In the **New File** dialog box, click **General** in the **Installed Templates** list, and then select **Code Analysis Rule Set**.

3. The rule set editor appears. No rules are selected in the editor list.

#### To create a custom rule from a single existing rule set

1. In Solution Explorer, right-click the project and then select **Properties**.

2. On the **Properties** tab, click **Code Analysis**.

3. In the **Rule Set** drop-down list, do one of the following:

   - Select the rule set that you want to customize.

     \- or -

   - Select **\<Browse...>** to specify an existing rule set that is not in the list.

4. Click **Open** to display the rules in the rule set editor.

#### To create a custom rule set from multiple existing rule sets

1. In Solution Explorer, right-click the project and then select **Properties**.

2. On the **Properties** tab, click **Code Analysis**.

3. Select **\<Choose multiple rule sets...>** from **Run this rule set**.

4. In the **Add or Remove Rule Sets** dialog box, select the rule sets on which you want to base your new rule set and then click **OK**.

5. Save the new rule set.

     The name of the new rule set is selected in the **Run this rule set** list. You can change the display name of the rule set in the next step.

6. (Optional) To change the display name of the rule set, on the **View** menu, click **Properties Window**. Type the display name in the **Name** box.

7. To add, remove, or modify specific code analysis rules in the new rule set, click **Open**.

## Modifying a rule set

#### To modify a rule set in the rule set editor

- To change the display name of the rule set, on the **View** menu, click **Properties Window**. Enter the display name in the **Name** box. Notice that the display name can differ from the file name.

- To add all the rules of the group to a custom rule set, select the check box of the group. To remove all the rules of the group, clear the check box.

- To add a specific rule to the custom rule set, select the check box of the rule. To remove the rule from the rule set, clear the check box.

- To change the action taken when a rule is violated in a code analysis, click in the **Action** field for the rule and then select one of the following values:

     **Warn** - generates a warning.

     **Error** - generates an error.

     **None** - disables the rule. This action is the same as removing the rule from the rule set.

## Changing the rule set editor display

#### To group, filter, or change the fields in the rule set editor by using the rule set editor toolbar

- To expand the rules in all groups, click **Expand All**.

- To collapse the rules in all groups, click **Collapse All**.

- To change the field that rules are grouped by, select the field from the **Group By** list. To display the rules ungrouped, select **\<None>**.

- To add or remove fields in rule columns, click **Column Options**.

- To hide rules that do not apply to the current solution, **Hide rules that do not apply to the current solution**.

- To switch between showing and hiding rules that are assigned the Error action, click **Show rules that can generate Code Analysis errors**.

- To switch between showing and hiding rules that are assigned the Warning action, click **Show rules that can generate Code Analysis warnings**.

- To switch between showing and hiding rules that are assigned the **None** action, click **Show rules that are not enabled**.

- To add or remove Microsoft default rule sets to the current rule set, click **Add or remove child rule sets**.

## See Also
 [How to: Configure Code Analysis for a Managed Code Project](../code-quality/how-to-configure-code-analysis-for-a-managed-code-project.md)
 [Code analysis rule set reference](../code-quality/code-analysis-rule-set-reference.md)
