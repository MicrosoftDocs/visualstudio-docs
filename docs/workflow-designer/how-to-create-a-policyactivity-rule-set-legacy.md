---
title: "Workflow Designer - How to: Create a PolicyActivity Rule Set (Legacy)"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
helpviewer_keywords:
  - "PolicyActivity activity, creating rule sets"
  - "Rule Set Editor dialog box"
  - "PolicyActivity activity, selecting rule sets"
  - "Select Rule Set dialog box"
  - "rule sets, creating for PolicyActivity"
ms.assetid: f272489d-3342-4511-8b59-6a0fd7a42d70
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Create a PolicyActivity Rule Set (Legacy)

This topic describes how to create a policy activity rule set using the legacy Windows Workflow Designer that targets the .NET Framework version 3.5 or the WinFX.

 After you have dragged a **Policy** activity item from the **Toolbox** to the workflow design surface, you will want to select an existing rule or create a new rule set for the [PolicyActivity](http://go.microsoft.com/fwlink?LinkID=65019) activity. You select an existing rule set by using the [Select Rule Set Dialog Box (Legacy)](../workflow-designer/select-rule-set-dialog-box-legacy.md) and you create rule sets by using the [Rule Set Editor Dialog Box (Legacy)](../workflow-designer/rule-set-editor-dialog-box-legacy.md).

> [!NOTE]
> You can open the [Rule Set Editor Dialog Box (Legacy)](../workflow-designer/rule-set-editor-dialog-box-legacy.md) dialog box directly by double-clicking on a [PolicyActivity](http://go.microsoft.com/fwlink?LinkID=65019) activity that is on the workflow design surface.

## To select or create a rule set for a PolicyActivity activity

1.  Right-click the [PolicyActivity](http://go.microsoft.com/fwlink?LinkID=65019), and then click **Properties** to open the **Properties** window.

2.  Click the **RuleSetReference** property.

3.  Do one of the following:

    -   Click the **RuleSetReference** ellipsis **[...]**, and then select an existing rule set in the [Select Rule Set Dialog Box (Legacy)](../workflow-designer/select-rule-set-dialog-box-legacy.md). Then go to step 10.

         -or-

    -   Type a name for a rule set. Click the **RuleSetReference** ellipsis **[...]**, and then select **Edit** in the [Select Rule Set Dialog Box (Legacy)](../workflow-designer/select-rule-set-dialog-box-legacy.md).

         -or-

    -   Type a name for a rule set. Expand the **RuleSetReference** property and select the ellipsis **[...]** in the **RuleSet Definition** property.

         The [Rule Set Editor Dialog Box (Legacy)](../workflow-designer/rule-set-editor-dialog-box-legacy.md) opens.

4.  In the [Rule Set Editor Dialog Box (Legacy)](../workflow-designer/rule-set-editor-dialog-box-legacy.md), click **Add Rule** to add a new rule to the rule set.

5.  Enter the **Name**, **Priority**, and **Reevaluation** properties, or keep the default values.

6.  Enter the text for the **Condition**.

7.  Enter the text for the **Then Actions** and the **Else Actions**.

8.  Click **Add Rule** again to add another rule.

9. When you are finished, click **OK**.

## See also

- [PolicyActivity](http://go.microsoft.com/fwlink?LinkID=65019)
- [Select Rule Set Dialog Box (Legacy)](../workflow-designer/select-rule-set-dialog-box-legacy.md)
- [Rule Set Editor Dialog Box (Legacy)](../workflow-designer/rule-set-editor-dialog-box-legacy.md)
- [Using the Policy Activity](http://go.microsoft.com/fwlink?LinkID=65004)
- [Legacy Workflow Activities](../workflow-designer/legacy-workflow-activities.md)