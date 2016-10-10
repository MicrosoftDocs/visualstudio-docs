---
title: "How to: Create a Declarative Rule Condition (Legacy)"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 804b6129-c433-408f-a424-46987967730c
caps.latest.revision: 5
manager: erikre
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Create a Declarative Rule Condition (Legacy)
This topic describes how to declare a rule condition using the legacy Windows Workflow Designer that targets the .NET Framework version 3.5 or the WinFX.  
  
 A condition statement evaluates to **True** or **False**. A declarative rule condition is a condition statement that is created by using the [Rule Condition Editor Dialog Box (Legacy)](../WF_Design/Rule-Condition-Editor-Dialog-Box--Legacy-.md) and stored as XML with the workflow. It can include predicates that compare workflow state and Boolean algebra that combines multiple predicates.  
  
 Declarative rule conditions are used in the following Windows Workflow Foundation out-of-box activities:  
  
-   [ConditionedActivityGroup](http://go.microsoft.com/fwlink?LinkID=65017)  
  
-   [IfElseBranchActivity](http://go.microsoft.com/fwlink?LinkID=65034)  
  
-   [ReplicatorActivity](http://go.microsoft.com/fwlink?LinkID=65039)  
  
-   [WhileActivity](http://go.microsoft.com/fwlink?LinkID=65049)  
  
-   [SequentialWorkflowActivity](http://go.microsoft.com/fwlink?LinkID=65040)  
  
-   [StateMachineWorkflowActivity](http://go.microsoft.com/fwlink?LinkID=65045)  
  
### To create a declarative rule condition using the Rule Condition Editor  
  
1.  In the activity's **Properties** window, click the **Condition** property or **UntilCondition** property, depending on the activity.  
  
2.  Select **Declarative Rule Condition** from the list for the property.  
  
3.  Expand the **Condition** or **UntilCondition** property.  
  
4.  Click the **ConditionName** property.  
  
5.  Click the **ConditionName** ellipses **[…]** to open the **Select Condition** dialog box.  
  
6.  Click **New Condition** to open the **Rule Condition Editor** dialog box.  
  
7.  Type the expression for the condition in the **Condition** text box.  
  
     For information about how to create condition expressions, see [Rule Condition Editor Dialog Box (Legacy)](../WF_Design/Rule-Condition-Editor-Dialog-Box--Legacy-.md).  
  
8.  When you are finished creating the condition expression, click **OK** to close the dialog box and create the rule condition with an assigned name.  
  
     The **Select Condition** dialog box opens.  
  
     For information about how to use the **Select Condition** dialog box, see [Select Condition Dialog Box (Legacy)](../WF_Design/Select-Condition-Dialog-Box--Legacy-.md).  
  
## See Also  
 [Legacy Workflow Activities](../WF_Design/Legacy-Workflow-Activities.md)   
 [Using the ConditionedActivityGroup](http://go.microsoft.com/fwlink?LinkID=65066)   
 [Using the IfElseBranchActivity Activity](http://go.microsoft.com/fwlink?LinkID=65075)   
 [Using the Replicator Activity](http://go.microsoft.com/fwlink?LinkID=65080)   
 [Using the While Activity](http://go.microsoft.com/fwlink?LinkID=65091)   
 [Rule Condition Editor Dialog Box (Legacy)](../WF_Design/Rule-Condition-Editor-Dialog-Box--Legacy-.md)   
 [Select Condition Dialog Box (Legacy)](../WF_Design/Select-Condition-Dialog-Box--Legacy-.md)   
 [Using Conditions in Workflows](http://go.microsoft.com/fwlink?LinkID=65009)