---
title: "Browse and Select a .NET Type Dialog Box (Legacy) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Workflow.ComponentModel.Design.TypeBrowserDialog.UI"
helpviewer_keywords:
  - "Browse and Select a .NET Type dialog box"
ms.assetid: 1e66c9bc-94b2-46e2-bedf-871752e5f917
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# Browse and Select a .NET Type Dialog Box (Legacy)
This topic describes how use the **Browse and Select a .NET Type** dialog box in the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)]. Use the legacy [!INCLUDE[wfd2](../includes/wfd2-md.md)] when you need to target either the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)].

 In the **Properties** window, when you select properties that take a .NET Framework type in a referenced assembly, an ellipses **[…]** appears at the end of the property's text box. Clicking the **[…]** opens the **Browse and Select a .NET Type** dialog box. In this dialog box, you can pick a type from a tree view of the referenced assemblies. For example, when you are using the Activity Designer, in the **Properties** window, click the **Base Class** ellipses **[…]** to select another base class for an activity from the Referenced Assemblies tree.

 The following table describes the user interface (UI) elements of the **Browse and Select a .NET Type** dialog box.

|UI Element|Description|
|----------------|-----------------|
|**Type Name:**|The name of the currently selected type.|
|**Type**|Left pane displays a tree view of the Referenced Assemblies. Right pane displays the types available for the selection from the Referenced Assembly selected in the left pane.|

## See Also
 [Using the Legacy Activity Designer](../workflow-designer/using-the-legacy-activity-designer.md)