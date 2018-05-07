---
title: "Workflow Designer - How to: Add a New Item to a Workflow Project (Legacy)"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
helpviewer_keywords:
  - "sequential workflows, adding to workflow projects"
  - "workflows, adding new items"
  - "state machine workflows, adding to workflow projects"
  - "activities, adding to workflow projects"
ms.assetid: 130cd83d-942d-437b-bbb5-8088ec0a6d79
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Add a New Item to a Workflow Project (Legacy)

After you have created a workflow project using the legacy Windows Workflow Designer provided by Visual Studio 2010 that targets either the .NET Framework version 3.5 or the WinFX, you can add Windows Workflow Foundation (WF) items and other familiar Visual Studio items to your project.

The following table lists the Windows Workflow Foundation items that you can add to a workflow project.

|Item|Description|
|----------|-----------------|
|Activity|An activity with the activity definition in a designer code file and user code in a separate code file.|
|Activity (with code separation)|An activity definition expressed as workflow markup and user code in a separate code file.|
|Sequential Workflow (code)|A sequential workflow with the workflow definition in a designer code file and user code in a separate code file.|
|Sequential Workflow (with code separation)|A sequential workflow with the workflow definition expressed as workflow markup and user code in a separate code file.|
|State Machine Workflow (code)|A state machine workflow with the workflow definition in a designer code file and user code in a separate code file.|
|State Machine Workflow (with code separation)|A state machine workflow with the workflow definition expressed as workflow markup and user code in a separate code file.|

## To add a new item to a workflow project

1.  On the **Project** menu, click **Add a New Item**.

     The **Add a New Item** dialog box opens.

2.  Select an item.

     The previous table lists the available Windows Workflow Foundation selections.

3.  Click **Add** to add the item to the workflow project.

## See also

- [Creating Legacy Workflow Projects](../workflow-designer/creating-legacy-workflow-projects.md)