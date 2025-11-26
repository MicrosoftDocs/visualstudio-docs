---
title: Configure XAML Designer in Visual Studio
description: Learn to enable and customize XAML Designer options in Visual Studio to optimize your XAML editing experience.
ms.date: 11/26/2025
ms.topic: how-to
author: maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: general-ide
#customer intent: As a Visual Studio user, I want to enable and configure XAML Designer options so that I can work more efficiently with XAML documents.
---

# Configure XAML Designer options in Visual Studio

The XAML Designer in Visual Studio lets you visually edit XAML documents for WPF and UWP projects. By enabling and customizing Designer options, you can streamline your workflow and tailor the editing experience to your needs. This article guides you through enabling the Designer and configuring its key options.

## Prerequisites

- Visual Studio installed
- A XAML-based project (such as WPF or UWP)

## Enable the XAML Designer

Enable the XAML Designer to access visual editing features and advanced IntelliSense for XAML documents.

1. Start Visual Studio, and select **Tools > Options** from the main menu.

:::moniker range="visualstudio"

2. In the **Options** pane, expand the **All Settings** > **XAML Designer** > **General** section.

3. Select the **Enable XAML Designer** checkbox.

4. Restart Visual Studio for your changes to take effect.

:::moniker-end
:::moniker range="vs-2022"

2. In the **Options** dialog, expand the **XAML Designer** > **General** section.

:::moniker-end
:::moniker range="<=vs-2019"

2. In the **Options** dialog, expand your project type (WPF or UWP), and expand the **XAML Designer** > **General** section.

:::moniker-end

:::moniker range="<=vs-2022"

3. Select the **Enable XAML Designer** checkbox, and then select **OK**.

4. Restart Visual Studio for your changes to take effect.

:::moniker-end

## Set the default document view

Choose how XAML documents appear when opened, including the XAML source code, the visual design view of the code, or both.

:::moniker range="visualstudio"

1. Open the **Tools** > **Options** pane and expand the **All Settings** > **XAML Designer** > **General** section.

:::moniker-end
:::moniker range="vs-2022"

1. Open the **Tools** > **Options** dialog and expand the **XAML Designer** > **General** section.

:::moniker-end
:::moniker range="<=vs-2019"

1. Open the **Tools** > **Options** dialog, expand your project type (WPF or UWP), and expand the **XAML Designer** > **General** section.

:::moniker-end

2. Use the dropdown list and set the value of the **Default document view** setting:

   - **Source View**: Show only the XAML source code.
   - **Design View**: Show only the visual designer.
   - **Split View**: Show both the visual designer and source code side by side.

:::moniker range="<=vs-2022"

3. Select **OK**.

:::moniker-end

## Change split orientation

Adjust the layout of Split View to suit your workflow.

:::moniker range="visualstudio"

1. Open the **Tools** > **Options** pane and expand the **All Settings** > **XAML Designer** > **General** section.

:::moniker-end
:::moniker range="vs-2022"

1. Open the **Tools** > **Options** dialog and expand the **XAML Designer** > **General** section.

:::moniker-end
:::moniker range="<=vs-2019"

1. Open the **Tools** > **Options** dialog, expand your project type (WPF or UWP), and expand the **XAML Designer** > **General** section.

:::moniker-end

2. Use the dropdown list and set the value of the **Split orientation** setting:

   - **Vertical**: Show the source code in the left pane and the visual designer in the right pane.
   - **Horizontal**: Show the visual designer in the top pane and the source code in the bottom pane.
   - **Default**: Use the platform-recommended orientation.

:::moniker range="<=vs-2022"

3. Select **OK**.

:::moniker-end

## Configure zoom behavior

Set how you zoom in the XAML Designer for easier navigation.

:::moniker range="visualstudio"

1. Open the **Tools** > **Options** pane and expand the **All Settings** > **XAML Designer** > **General** section.

:::moniker-end
:::moniker range="vs-2022"

1. Open the **Tools** > **Options** dialog and expand the **XAML Designer** > **General** section.

:::moniker-end
:::moniker range="<=vs-2019"

1. Open the **Tools** > **Options** dialog, expand your project type (WPF or UWP), and expand the **XAML Designer** > **General** section.

:::moniker-end

2. Use the dropdown list and set the value of the **Zoom by using** setting:

   - **Mouse wheel**
   - **Ctrl + mouse wheel**
   - **Alt + mouse wheel**

:::moniker range="<=vs-2022"

3. Select **OK**.

:::moniker-end

For more information on resetting Visual Studio settings, see [Reset settings](../ide/personalizing-the-visual-studio-ide.md#reset-all-settings).

## Default Zoom setting

Use this setting to determine the default zoom value for viewing the XAML document.

:::moniker range="visualstudio"

1. Open the **Tools** > **Options** pane and expand the **All Settings** > **XAML Designer** > **General** section.

:::moniker-end
:::moniker range="vs-2022"

1. Open the **Tools** > **Options** dialog and expand the **XAML Designer** > **General** section.

:::moniker-end
:::moniker range="<=vs-2019"

1. Open the **Tools** > **Options** dialog, expand your project type (WPF or UWP), and expand the **XAML Designer** > **General** section.

:::moniker-end

2. Use the dropdown list and set the value of the **Default zoom setting** option:

   - **Last Used**: Use the last used zoom value for all the XAML documents by default. When a XAML document is opened for the first time, the "Fit All" setting is used for the first time only.
   - **Fit All**: Use this option to set the zoom value to "Fit All" for the XAML designer. When a XAML document is closed and reopened, the last set value persists for that session but for different sessions, "Fit All" is used by default.

:::moniker range="<=vs-2022"

3. Select **OK**.

:::moniker-end

## Editor settings

These settings determine the visual designer behavior when you edit a XAML document.

|Name|Description|
|-|-|
|**Automatically name interactive elements on creation**|Specifies whether a default name is provided for a new interactive element when you add one to the designer.|
|**Automatically insert layout properties on element creation**|Specifies whether layout properties are provided for a new element when you add one to the designer. Layout properties are those that affect the layout of a control, for example, Margin and VerticalAlignment. The following XAML shows how a Button is created with and without this option selected:<br />`<Button Content="Button" HorizontalAlignment="Left" Margin="245,56,0,0" Grid.Row="1" VerticalAlignment="Top" Width="75"/>`<br />`<Button Content="Button" Grid.Row="1"/>`|
|**Use quadrant based layout**|Specifies whether the currently selected control aligns to the nearest edges of the parent container. If this checkbox is cleared, control alignments don't change during a move or create operation.|
|**Automatically populate toolbox items**|Specifies whether user controls and custom controls in the current solution are shown in the Toolbox automatically.|
|**Automatically add sample data on element creation**|Specifies whether to automatically add sample data for the new interactive element when you add one to the designer.|
|**Enable designer quick actions**|Allows you to use keyboard quick actions to access features in the Toolbox.|

## Settings (Blend only)

Use these options to access unique settings when you edit XAML files by using Blend.

:::moniker range="visualstudio"

In Blend, open the **Tools** > **Options** pane and expand the **All Settings** > **XAML Designer** > **General** section.

:::moniker-end
:::moniker range="vs-2022"

In Blend, open the **Tools** > **Options** dialog and expand the **XAML Designer** > **General** section.

:::moniker-end
:::moniker range="<=vs-2019"

In Blend, open the **Tools** > **Options** dialog, expand your project type (WPF or UWP), and expand the **XAML Designer** > **General** section.

:::moniker-end

There's one Blend-specific property:

- **Type units**: Specifies whether measurements on the designer are based on points or pixels. Because Universal Windows Apps don't support points, units are automatically converted to pixels when you select **Points**.

## Artboard (Blend only)

Use these settings to determine XAML Designer behavior when you edit XAML documents in Blend.

:::moniker range="visualstudio"

In Blend, open the **Tools** > **Options** pane and expand the **All Settings** > **XAML Designer** > **Artboard** section.

:::moniker-end
:::moniker range="vs-2022"

In Blend, open the **Tools** > **Options** dialog and expand the **XAML Designer** > **Artboard** section.

:::moniker-end
:::moniker range="<=vs-2019"

In Blend, open the **Tools** > **Options** dialog, expand your project type (WPF or UWP), and expand the **XAML Designer** > **Artboard** section.

:::moniker-end

The following Artboard properties are available:

### Snapping

|Name|Description|
|-|-|
|**Show snap grid**|Specify whether gridlines appear in the designer to help you align controls. Controls added to the designer snap to these gridlines when the **Snap to gridlines** option is selected.|
|**Snap to gridlines**|When controls are added or moved around the designer, they snap to the gridlines.|
|**Gridline spacing**|Specifies the spacing between the gridlines in either pixels or points (as determined by the **Type units** setting).|
|**Snap to snaplines**|Specifies whether controls snap to snaplines.|
|**Default margin**|When **Snap to snaplines** is enabled, specifies the spacing between the control and the snaplines in either pixels or points (as determined by the **Type units** setting).|
|**Default padding**|When **Snap to snaplines** is enabled, specifies the extra spacing between the control and the snaplines in either pixels or points (as determined by the **Type units** setting).|

### Animation

Use the **Animation** setting to determine whether a warning appears when dependent (nonaccelerated) animations are enabled in Blend.

### Effects

Use the **Effects** settings to determine whether effects are rendered when editing XAML files in the XAML Designer when you work in Blend.

|Name|Description|
|-|-|
|**Render effects**|Specifies whether effects render when editing XAML files in the XAML Designer using Blend.|
|**Zoom threshold**|Specifies the percentage of zoom in which effects render when the **Render effects** checkbox is selected. If you zoom beyond this setting, effects no longer render in the XAML Designer.|

## See also

- [XAML in WPF](/dotnet/framework/wpf/advanced/xaml-in-wpf)
- [Walkthrough: My first WPF desktop application](/dotnet/framework/wpf/getting-started/walkthrough-my-first-wpf-desktop-application)
