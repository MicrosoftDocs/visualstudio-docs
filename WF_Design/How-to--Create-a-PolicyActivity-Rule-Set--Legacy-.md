---
title: "How to: Create a PolicyActivity Rule Set (Legacy)"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: f272489d-3342-4511-8b59-6a0fd7a42d70
caps.latest.revision: 4
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
# How to: Create a PolicyActivity Rule Set (Legacy)
This topic describes how to create a policy activity rule set using the legacy Windows Workflow Designer that targets the .NET Framework version 3.5 or the WinFX.  
  
 After you have dragged a **Policy** activity item from the **Toolbox** to the workflow design surface, you will want to select an existing rule or create a new rule set for the [PolicyActivity](http://go.microsoft.com/fwlink?LinkID=65019) activity. You select an existing rule set by using the [Select Rule Set Dialog Box (Legacy)](../WF_Design/Select-Rule-Set-Dialog-Box--Legacy-.md) and you create rule sets by using the [Rule Set Editor Dialog Box (Legacy)](../WF_Design/Rule-Set-Editor-Dialog-Box--Legacy-.md).  
  
> [!NOTE]
>  You can open the [Rule Set Editor Dialog Box (Legacy)](../WF_Design/Rule-Set-Editor-Dialog-Box--Legacy-.md) dialog box directly by double-clicking on a [PolicyActivity](http://go.microsoft.com/fwlink?LinkID=65019) activity that is on the workflow design surface.  
  
### To select or create a rule set for a PolicyActivity activity  
  
1.  Right-click the [PolicyActivity](http://go.microsoft.com/fwlink?LinkID=65019), and then click **Properties** to open the **Properties** window.  
  
2.  Click the **RuleSetReference** property.  
  
3.  Do one of the following:  
  
    -   Click the **RuleSetReference** ellipses **[…]**, and then select an existing rule set in the [Select Rule Set Dialog Box (Legacy)](../WF_Design/Select-Rule-Set-Dialog-Box--Legacy-.md). Then go to step 10.  
  
         -or-  
  
    -   Type a name for a rule set. Click the **RuleSetReference** ellipses **[…]**, and then select **Edit** in the [Select Rule Set Dialog Box (Legacy)](../WF_Design/Select-Rule-Set-Dialog-Box--Legacy-.md).  
  
         -or-  
  
    -   Type a name for a rule set. Expand the **RuleSetReference** property and select the ellipses **[…]** in the **RuleSet Definition** property.  
  
         The [Rule Set Editor Dialog Box (Legacy)](../WF_Design/Rule-Set-Editor-Dialog-Box--Legacy-.md) opens.  
  
4.  In the [Rule Set Editor Dialog Box (Legacy)](../WF_Design/Rule-Set-Editor-Dialog-Box--Legacy-.md), click **Add Rule** to add a new rule to the rule set.  
  
5.  Enter the **Name**, **Priority**, and **Reevaluation** properties, or keep the default values.  
  
6.  Enter the text for the **Condition**.  
  
7.  Enter the text for the **Then Actions** and the **Else Actions**.  
  
8.  Click **Add Rule** again to add another rule.  
  
9. When you are finished, click **OK**.  
  
## See Also  
 [PolicyActivity](http://go.microsoft.com/fwlink?LinkID=65019)   
 [Select Rule Set Dialog Box (Legacy)](../WF_Design/Select-Rule-Set-Dialog-Box--Legacy-.md)   
 [Rule Set Editor Dialog Box (Legacy)](../WF_Design/Rule-Set-Editor-Dialog-Box--Legacy-.md)   
 [Using the Policy Activity](http://go.microsoft.com/fwlink?LinkID=65004)   
 [Legacy Workflow Activities](../WF_Design/Legacy-Workflow-Activities.md)