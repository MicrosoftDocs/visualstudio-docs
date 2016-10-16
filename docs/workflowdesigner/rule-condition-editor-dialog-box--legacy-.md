---
title: "Rule Condition Editor Dialog Box (Legacy)"
ms.custom: na
ms.date: "10/02/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "System.Workflow.Activities.Rules.Design.RuleConditionDialog.UI"
helpviewer_keywords: 
  - "Rule Condition dialog box"
ms.assetid: c7ca8be9-de31-4a64-939c-4d53a50d5e29
caps.latest.revision: 6
ms.author: "erikre"
manager: "erikre"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Rule Condition Editor Dialog Box (Legacy)
This topic describes how use the **Rule Condition Editor** dialog box in the legacy [!INCLUDE[wfd1](../workflowdesigner/includes/wfd1_md.md)]. Use the legacy [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] when you need to target either the [!INCLUDE[netfx35_long](../workflowdesigner/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflowdesigner/includes/vstecwinfx_md.md)].  
  
 You create and modify declarative rule conditions by using the **Rule Condition Editor** dialog box. These rule conditions are exposed as properties on the following Windows Workflow Foundation out-of-box activities:  
  
-   [ConditionedActivityGroup](http://go.microsoft.com/fwlink?LinkID=65017)  
  
-   [IfElseBranchActivity](http://go.microsoft.com/fwlink?LinkID=65034)  
  
-   [ReplicatorActivity](http://go.microsoft.com/fwlink?LinkID=65039)  
  
-   [WhileActivity](http://go.microsoft.com/fwlink?LinkID=65049)  
  
-   [SequentialWorkflowActivity](http://go.microsoft.com/fwlink?LinkID=65040)  
  
-   [StateMachineWorkflowActivity](http://go.microsoft.com/fwlink?LinkID=65045)  
  
 You access the **Rule Condition Editor** dialog box by using the [Select Condition Dialog Box (Legacy)](../workflowdesigner/select-condition-dialog-box--legacy-.md).  
  
 The following table describes the user interface (UI) elements of the **Rule Condition Editor** dialog box.  
  
|UI Element|Description|  
|----------------|-----------------|  
|**Condition:**|Enter the expression for the rule condition.|  
|**OK**|Click to save the rule condition.|  
  
## Entering Condition Expressions  
 Condition expressions are entered as text. You can type **this.** into the editor to reference fields, properties, and methods used in the workflow, using an IntelliSense-like menu. Or you can type a workflow member name directly. You can add logical operators to the condition, such as AND, OR, and NOT. You can also add predicates. A predicate is a binary operator and two operands. The binary operators supported are **==**, **>**, **\<**, **>=**, and **<=**. Supported operands are constant value, arithmetic function, and scoped public members.  
  
 You can specify the type for the comparison, and you can compare to **null** or an empty string. You can make nested calls to members on a variable that contains a complex type, for example, `this.Address.State == "WA"`.  
  
 The Rule Condition Editor supports the following operators:  
  
-   Relational operators: ==, =, !=  
  
-   Comparison operators: <, \<=, >, >=  
  
-   Arithmetic operators: +, - , *, /, MOD  
  
-   Logical operators: AND, &&, OR, &#124;&#124;, NOT, !  
  
-   Bitwise operators: &, &#124;  
  
 Expression operator precedence follows C# operator precedence rules.  
  
 The Rule Condition Editor supports the following numeric expressions:  
  
 this.i == 1D (resolves to 1.0)  
  
 this.i == 1E1 (resolves to 10.0)  
  
 this.i == 1L (resolves as a long)  
  
 this.i == 1M (resolves as a decimal)  
  
 this.i == 1F (resolves as a single)  
  
 this.i == 1U (resolves as an unsigned int)  
  
 For more information about conditions, see [Using Conditions in Workflows](http://go.microsoft.com/fwlink?LinkID=65009).  
  
## See Also  
 [IfElseActivity](http://go.microsoft.com/fwlink?LinkID=65033)   
 [ConditionedActivityGroup](http://go.microsoft.com/fwlink?LinkID=65017)   
 [ReplicatorActivity](http://go.microsoft.com/fwlink?LinkID=65039)   
 [WhileActivity](http://go.microsoft.com/fwlink?LinkID=65049)   
 [Select Condition Dialog Box (Legacy)](../workflowdesigner/select-condition-dialog-box--legacy-.md)   
 [Using Conditions in Workflows](http://go.microsoft.com/fwlink?LinkID=65009)   
 [Legacy Designer for Windows Workflow Foundation UI Help](../workflowdesigner/legacy-designer-for-windows-workflow-foundation-ui-help.md)