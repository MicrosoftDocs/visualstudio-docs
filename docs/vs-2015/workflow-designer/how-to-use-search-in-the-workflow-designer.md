---
title: "How to: Use Search in the Workflow Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
ms.assetid: f42d3115-2ed2-4941-8f1e-92dac41c30fa
caps.latest.revision: 3
author: "steved0x"
ms.author: jillfra
manager: jillfra
---
# How to: Use Search in the Workflow Designer
To facilitate creating larger, more complex workflows, Search can be used in the Workflow Designer to find items by keyword. Note that the designer does not support Replace. Search will find the following in the designer:

## Quick Find
 Quick find will find the following in the designer:

- Properties of <xref:System.Activities.Activity> objects, <xref:System.Activities.Statements.FlowNode> objects, <xref:System.Activities.Statements.State> objects, transitions, and other custom flow-control items.

- Variables

- Arguments

- Expressions

#### Using Quick Find

1. With the workflow designer open, press **Ctrl+F**, or select **Edit**, **Find and Replace**, **Quick Find**.

2. Enter the search term into the **Find what** textbox and click **Find Next**.

3. The search term will be located in the current workflow. The following screenshot shows an activity display name being located in the designer.

     ![Search result in the Workflow Designer](../workflow-designer/media/designersearch.png "DesignerSearch")

## Find in files
 Using Find in Files will locate strings in workflow files, including XAML files.

#### Using Find in Files

1. In Visual Studio, press **Ctrl + Shift + F**, or select **Edit**, **Find and Replace**, **Find in Files**

2. Enter the search item into the **Find what** textbox and click **Find All**

3. The find result will be shown in the [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)]**Find Result** view. Double-clicking a result item will navigate to the activity which contains the match in workflow designer.