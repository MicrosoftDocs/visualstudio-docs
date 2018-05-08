---
title: "Workflow Designer - Browse and Select a .NET Type Dialog Box (Legacy)"
ms.date: 11/04/2016
ms.topic: reference
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
f1_keywords:
  - "System.Workflow.ComponentModel.Design.TypeBrowserDialog.UI"
helpviewer_keywords:
  - "Browse and Select a .NET Type dialog box"
ms.assetid: 1e66c9bc-94b2-46e2-bedf-871752e5f917
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "dotnet"
---
# Browse and Select a .NET Type Dialog Box (Legacy)

This topic describes how use the **Browse and Select a .NET Type** dialog box in the legacy Windows Workflow Designer. Use the legacy Workflow Designer when you need to target either the .NET Framework version 3.5 or the WinFX.

 In the **Properties** window, when you select properties that take a .NET Framework type in a referenced assembly, an ellipsis **[...]** appears at the end of the property's text box. Clicking the **[...]** opens the **Browse and Select a .NET Type** dialog box. In this dialog box, you can pick a type from a tree view of the referenced assemblies. For example, when you are using the Activity Designer, in the **Properties** window, click the **Base Class** ellipsis **[...]** to select another base class for an activity from the Referenced Assemblies tree.

 The following table describes the user interface (UI) elements of the **Browse and Select a .NET Type** dialog box.

|UI Element|Description|
|----------------|-----------------|
|**Type Name:**|The name of the currently selected type.|
|**Type**|Left pane displays a tree view of the Referenced Assemblies. Right pane displays the types available for the selection from the Referenced Assembly selected in the left pane.|

## See also

- [Using the Legacy Activity Designer](../workflow-designer/using-the-legacy-activity-designer.md)