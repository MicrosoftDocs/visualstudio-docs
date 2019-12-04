---
title: "Rule Set Editor Dialog Box (Legacy) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Workflow.Activities.Rules.Design.RuleSetDialog.UI"
helpviewer_keywords:
  - "Rule Set Editor dialog box"
ms.assetid: 7cfd5df1-1115-4e5c-9b72-121f39419e83
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: jillfra
---
# Rule Set Editor Dialog Box (Legacy)
This topic describes how use the **Rule Set Editor** dialog box in the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)]. Use the legacy [!INCLUDE[wfd2](../includes/wfd2-md.md)] when you need to target either the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)].

 The **Rule Set Editor** dialog box is used to create and modify [PolicyActivity](https://go.microsoft.com/fwlink?LinkID=65019) rule sets, which are serialized to a .rules file.

> [!NOTE]
> If you want to open the .rules file with the **XML Editor with encoding**, you must first close the associated designer window for the workflow or activity.

 For information about how to access the **Rule Set Editor** dialog box, see [How to: Create a PolicyActivity Rule Set (Legacy)](../workflow-designer/how-to-create-a-policyactivity-rule-set-legacy.md).

> [!WARNING]
> The Rules editor of the legacy [!INCLUDE[wfd2](../includes/wfd2-md.md)] that is used to target either the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)] does not support Multitargeting.

 The following table describes the user interface (UI) elements of the **Rule Set Editor** dialog box.

|UI Element|Description|
|----------------|-----------------|
|**Add Rule**|Adds a new rule definition to the rule set.|
|**Delete**|Deletes the selected rule from the rule set.|
|**Chaining**|Specifies which type of forward chaining to use with the rule set. The available options are:<br /><br /> -   **Full Chaining**, which specifies to use all forward chaining mechanisms: implicit, method attributing, and explicit using an **Update** function.<br />-   **Sequential**, which specifies not to use any forward chaining.<br />-   **Explicit Update Only**, which specifies to only perform forward chaining on **Update** actions.<br /><br /> For more information about forward chaining, see [Using the PolicyActivity Activity](https://go.microsoft.com/fwlink?LinkID=65004).|
|**Name**|Rule set list column heading. Click to sort the list of rules by name.|
|**Priority**|Rule set list column heading. Click to sort the list of rules by priority.|
|**Reevaluation**|Rule set list column heading. Click to sort the list of rules by reevaluation type.|
|**Rule Preview**|Rule set list column heading. Click to sort the list of rules by the preview of a rule's condition and actions.|
|**Name:**|Enter the name of rule.|
|**Priority:**|Enter a priority for the rule. The default priority is 0.|
|**Reevaluation:**|Specifies which type of rule reevaluation to use with the rule. The available options are:<br /><br /> -   **Always**, which causes the rule to be reevaluated as needed.<br />-   **Never**, which causes the rule to never be reevaluated. In this case a rule executes only one time.|
|**Active**|Check to make the rule active.|
|**Condition:**|Enter an expression for the rule condition. For information about expression syntax, see the "Entering Condition and Action Expressions" section of this page.|
|**Then Actions:**|Enter expression for Then actions. For information about expression syntax, see the "Entering Condition and Action Expressions" section of this page.|
|**Else Actions:**|Enter expression for Else actions. For information about expression syntax, see the "Entering Condition and Action Expressions" section of this page.|
|**OK**|Click to save the rule set to a .rules file.|

 For more information about rule sets, see [Using the PolicyActivity Activity](https://go.microsoft.com/fwlink?LinkID=65004).

## Entering Condition and Action Expressions
 You enter expressions for the Condition and the Then and Else actions as text in their respective text boxes in the **Rule Set Editor** dialog box. You can type **this.** into the editor to reference fields, properties and methods used in the workflow, using an IntelliSense-type of menu. Or you can type a workflow member name directly. You can call static methods on referenced types by typing the class name followed by the method name.

 You can add logical operators to the condition, such as AND, OR, and NOT. You can also add predicates. A predicate is a binary operator and two operands. The binary operators supported are ==, >, \<, >=, and <=. Supported operands are constant value, arithmetic function, and scoped public members.

 You can specify the type for the comparison, and you can compare to **null** or an empty string. You can nest calls to members on a variable that contains a complex type, for example, `this.Address.State == "WA"`.

 Expressions support the following operators:

- Relational operators: ==, =, !=

- Comparison operators: <, \<=, >, >=

- Arithmetic operators: +, - , *, /, MOD

- Logical operators: AND, &&, OR, &#124;&#124;, NOT, !

- Bitwise operators: &, &#124;

  Expression operator precedence follows C# operator precedence rules.

  For more information about conditions, see [Using Conditions in Workflows](https://msdn.microsoft.com/541211f5-d382-4810-894f-71f00b34fa77).

### Halt and Update Functions
 **Then Actions:** and **Else Actions:** expressions support **Halt** and **Update** functions. To use the **Halt** function, type **Halt** into a **Then Action:** or **Else Action:** text box. The **Halt** action causes rule set execution to stop immediately, and control returns to the calling code. You use the **Update** function with forward chaining.

 An **Update** statement can be expressed in the editor in one of two forms; both forms are shown in the following example:

```
Update(this.Address.State)
Update("this/Address/State")
```

 For more information about using **Update** with forward chaining, see [Using the PolicyActivity Activity](https://go.microsoft.com/fwlink?LinkID=65004).

## See Also
 [PolicyActivity](https://go.microsoft.com/fwlink?LinkID=65019)
 [Select Rule Set Dialog Box (Legacy)](../workflow-designer/select-rule-set-dialog-box-legacy.md)
 [Using the PolicyActivity Activity](https://go.microsoft.com/fwlink?LinkID=65004)
 [Using Conditions in Workflows](https://go.microsoft.com/fwlink?LinkID=65009)