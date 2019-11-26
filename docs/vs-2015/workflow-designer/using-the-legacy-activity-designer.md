---
title: "Using the Legacy Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
helpviewer_keywords:
  - "activities, configuring"
  - "custom activities"
  - "Activity Designer"
  - "child activities, adding"
  - "activities, adding child"
  - "activities, creating custom"
ms.assetid: 2fea8a05-6e58-423d-94bf-a822b15ffb80
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# Using the Legacy Activity Designer
This topic describes how to use the activity designer in the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)]. Use the legacy designer when targeting the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)].

 The Activity Designer enables you to create your own custom activities.

## Creating a Custom Activity
 Follow these steps to create a custom activity using the Activity Designer:

1. On the **Project** menu, click **Add Activity**.

2. Select the **Activity** or **Activity (with code separation)** template.

   1. Use the **Activity** template to create an activity with the activity definition and the user code in same code file.

   2. Use the **Activity (with code separation)** template to create an activity with the activity definition expressed as workflow markup and the user code in a separate code file.

3. Type an activity name or keep the default name, and then click **Add**.

   You can also create a set of custom activities by creating a new project of type **Workflow Activity Library**. For more information about this project type, see [How to: Create a Workflow Activity Library (Legacy)](../workflow-designer/how-to-create-a-workflow-activity-library-legacy.md).

## Configuring an Activity
 While the Activity Designer is active, you can use the property browser to configure the properties listed in the following table.

|Property|Comments|
|--------------|--------------|
|**Name**|Name of the activity.|
|**Base Class**|Base class that the activity derives from. The default base class is [SequenceActivity](https://go.microsoft.com/fwlink?LinkID=65020). In the **Properties** window, click the **Base Class** ellipses **[…]** to select another base class in the [Browse and Select a .NET Type Dialog Box (Legacy)](../workflow-designer/browse-and-select-a-dotnet-type-dialog-box-legacy.md).|
|**Description**|User-defined description of the activity.|
|**Enabled**|Set to **True** by default to enable activity execution and validation. Set to **False** to disable activity execution and validation. For information about activity execution and validation, see [Developing Workflow Activities](https://go.microsoft.com/fwlink?LinkID=65024).|

## Adding Child Activities
 You can drag child activities from the Toolbox to the activity that you are designing. You can then configure each child activity using the property browser.

## See Also
 [Developing Workflow Activities](https://go.microsoft.com/fwlink?LinkID=65024)
 [Creating Custom Activities](https://go.microsoft.com/fwlink?LinkID=65021)
 [Legacy Workflow Activities](../workflow-designer/legacy-workflow-activities.md)
 [Custom Activities Samples](https://go.microsoft.com/fwlink?LinkID=65022)
 [How to: Create a Workflow Activity Library (Legacy)](../workflow-designer/how-to-create-a-workflow-activity-library-legacy.md)
 [Using the Legacy Workflow Designer](../workflow-designer/using-the-legacy-workflow-designer.md)