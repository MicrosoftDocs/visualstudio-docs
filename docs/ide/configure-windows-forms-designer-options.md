---
title: Configure Windows Forms Designer options in Visual Studio
description: Learn how to configure grid settings, layout modes, code generation, and other Windows Forms Designer preferences in Visual Studio.
ms.date: 02/09/2026
ms.topic: how-to
f1_keywords:
- VS.ToolsOptionsPages.WindowsFormsDesigner.General
helpviewer_keywords:
- Windows Forms Designer options
- Options dialog box, Windows Forms Designer
- grid settings, Windows Forms
- snap to grid
- layout mode
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
ms.custom: awp-ai
ms.ai-usage: ai-assisted
---
# Configure Windows Forms Designer options in Visual Studio

This article shows you how to configure the Windows Forms Designer settings in Visual Studio, including grid layout, code generation, High-DPI support, and other designer preferences.

## Prerequisites

- Visual Studio installed with a workload that includes Windows Forms development.
- A Windows Forms project open (to see the effects of these settings).

## Open the Windows Forms Designer options

::: moniker range="visualstudio"

1. Select **Tools** > **Options** from the menu bar.
1. Expand **All Settings** > **Windows Forms Designer**.
1. Select **General** to open the settings pane.

::: moniker-end
::: moniker range="<=vs-2022"

1. Select **Tools** > **Options** from the menu bar.
1. Expand **Windows Forms Designer**.
1. Select **General** to open the settings page.

::: moniker-end

## Configure .NET Core designer settings

These settings control the behavior of the Windows Forms out-of-process designer for .NET Core and .NET 5+ projects.

::: moniker range=">=vs-2022"

### Set the connection timeout

To change how long Visual Studio waits for the out-of-process designer to respond:

1. Open the Windows Forms Designer options.
1. Locate **Connection timeout (sec)**.
1. Set the value to the desired timeout in seconds. The minimum value is 120 seconds.

   Increase this value if you experience designer timeouts with large or complex forms.

::: moniker-end

### Set the logging level

To control how much diagnostic information the out-of-process designer logs:

1. Open the Windows Forms Designer options.
1. Locate **Logging Level**.
1. Select one of the following options from the dropdown:
   - **None** — No logging.
   - **Informational** — General information messages.
   - **Warnings** — Warning messages only.
   - **Errors** — Error messages only.
   - **Verbose** — All available diagnostic information.

   Use **Verbose** when troubleshooting designer issues.

## Configure layout and grid settings

These settings control how the designer grid appears and how controls align when you place them on a form.

### Set the grid cell size

To change the spacing between gridlines:

1. Open the Windows Forms Designer options.
1. Locate **Default Grid Cell Size**.
1. Enter the horizontal and vertical spacing in pixels. The default is 8, 8. The maximum is 200, 200.

### Set the layout mode

To choose how controls align in the designer:

1. Open the Windows Forms Designer options.
1. Locate **Layout Mode**.
1. Select one of the following options:
   - **SnapToGrid** — Controls snap to grid intersections when moved or resized.
   - **Snaplines** — Controls display alignment guides that help you align with other controls.

### Show or hide the grid

To toggle the visibility of the sizing grid:

1. Open the Windows Forms Designer options.
1. Select or clear the **Show Grid** checkbox.

   The grid is shown by default.

### Enable or disable snap to grid

To control whether controls snap to grid positions:

1. Open the Windows Forms Designer options.
1. Select or clear the **Snap to Grid** checkbox.

   When enabled, controls snap to grid increments when moved or resized, making it easier to align UI elements precisely. When disabled, you can place controls freely at any position.

## Configure High-DPI support

To enable notifications about DPI scaling issues in the designer:

1. Open the Windows Forms Designer options.
1. Select or clear the **DPI Scaling Notifications** checkbox.

   When enabled, the Windows Forms Designer displays a message offering to restart Visual Studio with 100% scaling if DPI issues are detected.

## Configure code generation and refactoring

These settings control how the designer generates and refactors code.

### Enable optimized code generation

To use optimized code generation for designer-generated code:

1. Open the Windows Forms Designer options.
1. Select or clear the **Optimized Code Generation** checkbox.
1. Close and reopen Visual Studio for the change to take effect.

   > [!NOTE]
   > Some controls may not be compatible with optimized code generation mode.

### Enable refactoring on rename

To automatically perform refactoring when you rename a component:

1. Open the Windows Forms Designer options.
1. Select or clear the **Enable Refactoring on Rename** checkbox.

   When enabled, renaming a component in the Properties window or Document Outline window triggers a rename refactoring operation that updates all references.

## Configure smart tags and Toolbox

These settings control smart tag behavior and Toolbox population.

### Enable automatic smart tags

To control whether controls display smart tags when selected:

1. Open the Windows Forms Designer options.
1. Select or clear the **Automatically Open Smart Tags** checkbox.

   > [!NOTE]
   > Not all controls and components support smart tags.

### Enable automatic Toolbox population

To automatically add project-built components to the Toolbox:

1. Open the Windows Forms Designer options.
1. Select or clear the **Automatically Populate Toolbox** checkbox.

   When enabled, custom components and controls built by your project appear automatically in the Toolbox window.

## Related content

- [Designing Windows Forms](/dotnet/desktop/winforms/controls/developing-windows-forms-controls-at-design-time)
- [Windows Forms Designer overview](/dotnet/desktop/winforms/controls/walkthrough-arranging-controls-on-windows-forms-using-a-tablelayoutpanel)
- [Tutorial: Create a Windows Forms app in Visual Studio](create-csharp-winform-visual-studio.md)
