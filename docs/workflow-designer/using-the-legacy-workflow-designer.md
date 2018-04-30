---
title: "Using the Legacy Workflow Designer"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
helpviewer_keywords:
  - "Visual Studio 2005 Extensions for Windows Workflow Foundation, about"
ms.assetid: 7af53077-afd7-465f-9c1d-b387e9d4f216
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Using the Legacy Workflow Designer

The legacy Workflow Designer provided by Visual Studio 2010 can be used to target the .NET Framework version 3.5 or the WinFX.

It is accessed by selecting either the **.NET Framework 3.0** option or the **.NET Framework 3.5** option in the drop down list at the top of the **New Project** window. The default option in Visual Studio 2010 is **.NET Framework 4** which is used to create Windows Workflow Foundation (WF) applications that target the .NET Framework 4.

The Workflow Designer provides a way to graphically create Windows Workflow Foundation (WF) applications using the familiar Visual Studio user interface. Windows Workflow Foundation (WF) applications are composed of workflow process steps called activities. To create a workflow, compose activities on the design surface by dragging their respective activity designers from **Toolbox** onto the design surface.

The following table lists key features of Visual Studio for Windows Workflow Foundation.

|Feature|Description|
|-------------|-----------------|
|Activity Drag and Drop|Drag activities from the **Toolbox** onto the design surface to create a workflow.|
|Property Browser|The standard **Properties** window in Visual Studio is used to configure the properties of an activity.|
|Zoom|The binoculars **Zoom Level** icon is located below the vertical scroll bar on the right side of the design surface. Click the binoculars and select a zoom percentage to cause the workflow graphic to zoom in or out. You can also use the **Pan** icon magnifying glass cursor options to zoom in and out.|
|Pan|The **Pan** icon, a circle that contains four crossed arrows pointing in four directions, is located below the vertical scroll bar on the right side of the design surface just below the binoculars zoom icon. If you click the pan icon, a pop-up menu offers the following cursor options:<br /><br /> -   The **Zoom In** magnifying glass cursor lets you zoom in by clicking the design surface.<br />-   The **Zoom Out** magnifying glass cursor lets you zoom out by clicking the design surface.<br />-   The **Navigation Tool** hand cursor lets you "grab" and shift the view of a workflow in the design surface.<br />-   The **Default** arrow cursor lets you switch from the other cursors back to the default arrow cursor.|
|Auto Scrolling|If you have a large workflow, you might want to place an activity beyond the visible display of the design surface area. Visual Studio lets you drag an activity toward the edge of the design surface closest to where you want to put the activity. The design surface view automatically scrolls in that direction.|
|Smart Tags|Activities that are not completely configured or not validly configured are marked with an exclamation point icon. You can click the icon and see a drop-down list of configuration needs that exist on the activity. You can then use the **Properties** window to configure the activity appropriately. When all properties are valid for the activity, the exclamation point icon disappears.|

## See also

- [Developing Workflows](http://go.microsoft.com/fwlink?LinkID=65010)