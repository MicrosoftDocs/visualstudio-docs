---
title: "Rule Condition Editor Dialog Box (Legacy) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Workflow.Activities.Rules.Design.RuleConditionDialog.UI"
helpviewer_keywords:
  - "Rule Condition dialog box"
ms.assetid: c7ca8be9-de31-4a64-939c-4d53a50d5e29
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# Rule Condition Editor Dialog Box (Legacy)
This topic describes how use the **Rule Condition Editor** dialog box in the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)]. Use the legacy [!INCLUDE[wfd2](../includes/wfd2-md.md)] when you need to target either the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)].

 You create and modify declarative rule conditions by using the **Rule Condition Editor** dialog box. These rule conditions are exposed as properties on the following Windows Workflow Foundation out-of-box activities:

- [ConditionedActivityGroup](https://go.microsoft.com/fwlink?LinkID=65017)

- [IfElseBranchActivity](https://go.microsoft.com/fwlink?LinkID=65034)

- [ReplicatorActivity](https://go.microsoft.com/fwlink?LinkID=65039)

- [WhileActivity](https://go.microsoft.com/fwlink?LinkID=65049)

- [SequentialWorkflowActivity](https://go.microsoft.com/fwlink?LinkID=65040)

- [StateMachineWorkflowActivity](https://go.microsoft.com/fwlink?LinkID=65045)

  You access the **Rule Condition Editor** dialog box by using the [Select Condition Dialog Box (Legacy)](../workflow-designer/select-condition-dialog-box-legacy.md).

  The following table describes the user interface (UI) elements of the **Rule Condition Editor** dialog box.

|UI Element|Description|
|----------------|-----------------|
|**Condition:**|Enter the expression for the rule condition.|
|**OK**|Click to save the rule condition.|

## Entering Condition Expressions
 Condition expressions are entered as text. You can type **this.** into the editor to reference fields, properties, and methods used in the workflow, using an IntelliSense-like menu. Or you can type a workflow member name directly. You can add logical operators to the condition, such as AND, OR, and NOT. You can also add predicates. A predicate is a binary operator and two operands. The binary operators supported are **==**, **>**, **\<**, **>=**, and **<=**. Supported operands are constant value, arithmetic function, and scoped public members.

 You can specify the type for the comparison, and you can compare to **null** or an empty string. You can make nested calls to members on a variable that contains a complex type, for example, `this.Address.State == "WA"`.

 The Rule Condition Editor supports the following operators:

- Relational operators: ==, =, !=

- Comparison operators: <, \<=, >, >=

- Arithmetic operators: +, - , *, /, MOD

- Logical operators: AND, &&, OR, &#124;&#124;, NOT, !

- Bitwise operators: &, &#124;

  Expression operator precedence follows C# operator precedence rules.

  The Rule Condition Editor supports the following numeric expressions:

  this.i == 1D (resolves to 1.0)

  this.i == 1E1 (resolves to 10.0)

  this.i == 1L (resolves as a long)

  this.i == 1M (resolves as a decimal)

  this.i == 1F (resolves as a single)

  this.i == 1U (resolves as an unsigned int)

  For more information about conditions, see [Using Conditions in Workflows](https://go.microsoft.com/fwlink?LinkID=65009).

## See Also
 [IfElseActivity](https://go.microsoft.com/fwlink?LinkID=65033)
 [ConditionedActivityGroup](https://go.microsoft.com/fwlink?LinkID=65017)
 [ReplicatorActivity](https://go.microsoft.com/fwlink?LinkID=65039)
 [WhileActivity](https://go.microsoft.com/fwlink?LinkID=65049)
 [Select Condition Dialog Box (Legacy)](../workflow-designer/select-condition-dialog-box-legacy.md)
 [Using Conditions in Workflows](https://go.microsoft.com/fwlink?LinkID=65009)
 [Legacy Designer for Windows Workflow Foundation UI Help](../workflow-designer/legacy-designer-for-windows-workflow-foundation-ui-help.md)