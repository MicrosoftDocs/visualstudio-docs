---
title: "Use Search in the Workflow Designer"
description: Learn how to search within the Workflow Designer to find items by keyword so you can facilitate creating larger, more complex workflows.
ms.date: 11/04/2016
ms.topic: how-to
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Use Search in the Workflow Designer

To facilitate creating larger, more complex workflows, you can search within the Workflow Designer to find items by keyword. Note that the designer does not support Replace.

## Quick Find

Quick find finds the following in the designer:

- Properties of <xref:System.Activities.Activity> objects, <xref:System.Activities.Statements.FlowNode> objects, <xref:System.Activities.Statements.State> objects, transitions, and other custom flow-control items.

- Variables

- Arguments

- Expressions

### Use Quick Find

1. With the workflow designer open, press **Ctrl+F**, or select **Edit** > **Find and Replace** > **Quick Find**.

2. Enter the search term into the **Find what** textbox and click **Find Next**.

3. The search term is located in the current workflow. The following image shows an activity display name being located in the designer:

   ![Search result in the Workflow Designer](../workflow-designer/media/designersearch.png)

## Find in files

Find in Files locates strings in workflow files, including XAML files.

### Use Find in Files

1. In Visual Studio, press **Ctrl**+**Shift**+**F**, or select **Edit** > **Find and Replace** > **Find in Files**.

2. Enter the search item into the **Find what** textbox and click **Find All**.

3. The find result is shown in the **Find Result** view. Double-clicking a result item navigates to the activity that contains the match in workflow designer.