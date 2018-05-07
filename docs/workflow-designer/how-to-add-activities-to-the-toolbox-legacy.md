---
title: "Workflow Designer - How to: Add Activities to the Toolbox (Legacy)"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
helpviewer_keywords:
  - "Toolbox, adding activities"
  - "activities, adding to Toolbox"
ms.assetid: b66ea29c-120b-40ba-8a61-c1c8240850fa
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Add Activities to the Toolbox (Legacy)

When building a workflow solution with the legacy Windows Workflow Designer that targets the .NET Framework version 3.5 or the WinFX, custom activities can be added to the workflow project and their designers placed in the **Toolbox** for easy access. You can also add activities directly to the **Toolbox** from a dynamic-link library (DLL).

## To add an activity to the Toolbox from a DLL

1.  Right-click the Toolbox window surface under **Windows Workflow**, and then click **Choose Items**.

2.  In the **Choose Toolbox Items** dialog box, click the **System.Activities Components** tab, and then click **Browse** from the lower right-hand side of the window.

3.  Select the DLL from the file directory that contains the implementation of the custom activity to add to the **Toolbox**, and then click **Open**.

4.  Click **OK** to finish adding the activity to the Toolbox.

## See also

- [Using the Legacy Activity Designer](../workflow-designer/using-the-legacy-activity-designer.md)
- [Legacy Workflow Activities](../workflow-designer/legacy-workflow-activities.md)