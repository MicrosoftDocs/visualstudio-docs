---
title: "Workflow Designer - Theme Configuration Dialog Box (Legacy)"
ms.date: 11/04/2016
ms.topic: reference
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
f1_keywords:
  - "System.Workflow.ComponentModel.Design.ThemeConfigurationDialog.UI"
helpviewer_keywords:
  - "themes, configuring"
  - "Theme Configuration dialog box"
ms.assetid: 9e6d182a-c4d9-4e71-b2b9-02f675fc2b29
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Theme Configuration Dialog Box (Legacy)

This topic describes how use the **Theme Configuration** dialog box in the legacy Windows Workflow Designer. Use the legacy Workflow Designer when you need to target either the .NET Framework version 3.5 or the WinFX.

A theme defines the background and foreground colors, styles, icons, and other visual elements of a workflow. You can save themes for reuse by other workflows.

You create and edit themes by using the **Theme Configuration** dialog box. To open the dialog box, select **Create New Theme** on the **Workflow** menu, or right-click the workflow design surface and select **Create New Theme**.

The following table describes the user interface (UI) elements of the **Theme Configuration** dialog box.

|UI Element|Description|
|----------------|-----------------|
|**Theme Name:**|The name that identifies the theme in the [Themes, Workflow Designer, Options Dialog Box (Legacy)](../workflow-designer/themes-workflow-designer-options-dialog-box-legacy.md). A changeable name is generated for new themes.|
|**Theme Location:**|File name and path of the theme file. A changeable file name is generated for new themes based on the generated theme name. If you change the generated theme name, you might want to change the file name to match the theme name.|
|**...**|Click to select the location to save the workflow theme file, which uses a .wtm file name extension. The selected path will be seen in the **Theme Location** text box.|
|**Select Designer and Configure Properties:**|The left pane lists a tree view of the activities for which the theme can be customized. Select an activity in the tree view and the theme properties for the activity will be displayed in the properties pane, which is to the right of the tree view pane. Click a property to change its value.|
|**Preview**|Click to display a window to preview the effects of property changes.|

## See also

- [Themes, Workflow Designer, Options Dialog Box (Legacy)](../workflow-designer/themes-workflow-designer-options-dialog-box-legacy.md)
- [Legacy Designer for Windows Workflow Foundation UI Help](../workflow-designer/legacy-designer-for-windows-workflow-foundation-ui-help.md)