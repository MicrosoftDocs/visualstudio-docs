---
title: Options, Windows Forms Designer, General
description: Learn how to use the General page to set preferences for the grids and other features of the Windows Forms Designer in Visual Studio.
ms.date: 07/07/2022
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.WindowsFormsDesigner.General
helpviewer_keywords:
- Windows Forms Designer options
- Options dialog box, Windows Forms Designer
ms.custom: "ide-ref"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Options dialog box: Windows Forms Designer

The Windows Forms Designer options page lets you set preferences for the grids and other features of the Windows Forms Designer in Visual Studio. Open the **Options** dialog box from the **Tools** menu.

## .NET Core

::: moniker range=">=vs-2022"

**Connection timeout (sec)**\
Controls the Windows Forms out-of-process designer connection timeout, as measured in seconds. The minimum value is 120 seconds.

::: moniker-end

**Logging Level**\
Controls the logging level for the Windows Forms out-of-process designer. The options include None, Informational, Warnings, Errors, and Verbose.

## Code Generation Settings

**Optimized Code Generation**\
Enables optimized code generation. Some controls may not be compatible with this mode. For this change to take effect, Visual Studio must be closed and reopened.

## High-DPI Support

**DPI Scaling Notifications**\
Show a message in Windows Form Designer that can restart Visual Studio with 100% scaling. 

## Layout Settings

**Default Grid Cell Size**\
Sets the spacing, in pixels, between horizontal and vertical gridlines on the designer. The default size is 8, 8. The maximum size is 200, 200.

**Layout Mode**\
Specifies the alignment system to use for layout. You can choose either SnapToGrid or Snaplines.

**Show Grid**\
Specifies whether designers display the sizing grid. By default, the grid is on.

**Snap to Grid**\
Determines whether designers will snap objects and controls to the grid. In other words, the resizing and movement of elements on the designer are constrained to the GridSize increment when this feature is turned on. Having SnapToGrid turned on makes it easier to line up the various aspects of the user interface precisely but limits the freedom with which one can place controls. By default, SnapToGrid is turned on.

## Object Bound Smart Tag Settings

**Automatically Open Smart Tags**\
Determines whether controls and components display smart tags. Not all controls and components support smart tags.

## Refactoring

**Enable Refactoring on Rename**\
When set to `true`, a rename refactoring operation is performed when you rename a component from the Properties window or Document Outline window.

## Toolbox

**Automatically Populate Toolbox**\
Determines whether the Toolbox window is automatically populated with components and controls built by the project.
