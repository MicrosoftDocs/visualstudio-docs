---
title: "How to: Add a New Item to a Workflow Project (Legacy) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
helpviewer_keywords:
  - "sequential workflows, adding to workflow projects"
  - "workflows, adding new items"
  - "state machine workflows, adding to workflow projects"
  - "activities, adding to workflow projects"
ms.assetid: 130cd83d-942d-437b-bbb5-8088ec0a6d79
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Add a New Item to a Workflow Project (Legacy)
After you have created a workflow project using the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)] provided by [!INCLUDE[vs2010](../includes/vs2010-md.md)] that targets either the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)], you can add [!INCLUDE[wf](../includes/wf-md.md)] items and other familiar [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] items to your project.

 The following table lists the [!INCLUDE[wf2](../includes/wf2-md.md)] items that you can add to a workflow project.

|Item|Description|
|----------|-----------------|
|Activity|An activity with the activity definition in a designer code file and user code in a separate code file.|
|Activity (with code separation)|An activity definition expressed as workflow markup and user code in a separate code file.|
|Sequential Workflow (code)|A sequential workflow with the workflow definition in a designer code file and user code in a separate code file.|
|Sequential Workflow (with code separation)|A sequential workflow with the workflow definition expressed as workflow markup and user code in a separate code file.|
|State Machine Workflow (code)|A state machine workflow with the workflow definition in a designer code file and user code in a separate code file.|
|State Machine Workflow (with code separation)|A state machine workflow with the workflow definition expressed as workflow markup and user code in a separate code file.|

### To add a new item to a workflow project

1. On the **Project** menu, click **Add a New Item**.

     The **Add a New Item** dialog box opens.

2. Select an item.

     The previous table lists the available Windows Workflow Foundation selections.

3. Click **Add** to add the item to the workflow project.

## See Also
 [Creating Legacy Workflow Projects](../workflow-designer/creating-legacy-workflow-projects.md)