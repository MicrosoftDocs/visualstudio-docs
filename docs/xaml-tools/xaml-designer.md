---
title: Configure XAML Designer in Visual Studio
description: Learn to enable and customize XAML Designer options in Visual Studio to optimize your XAML editing experience.
ms.date: 03/02/2025
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

1. Open Visual Studio.
2. Go to **Tools > Options**.
3. Expand **XAML Designer** under the relevant project type (WPF/UWP).
4. Check **Enable XAML Designer**.
5. Click **OK** and restart Visual Studio for changes to take effect.

## Set the default document view

Choose how XAML documents appear when opened: Source View, Design View, or Split View.

1. In Visual Studio, go to **Tools > Options > XAML Designer**.
2. Find the **Default document view** setting.
3. Select one:
	- **Source View**: Shows only XAML source code.
	- **Design View**: Shows only the visual Designer.
	- **Split View**: Shows both Designer and source side by side.
4. Click **OK** to apply.

## Change split orientation

Adjust the layout of Split View to suit your workflow.

1. In **Tools > Options > XAML Designer**, locate **Split Orientation**.
2. Choose one:
	- **Vertical**: Source on the left, Designer on the right.
	- **Horizontal**: Designer on top, source below.
	- **Default**: Uses platform-recommended orientation.
3. Click **OK** to save changes.

## Configure zoom behavior

Set how you zoom in the XAML Designer for easier navigation.

1. In **Tools > Options > XAML Designer**, find **Zoom by using**.
2. Select your preferred method:
	- **Mouse wheel**
	- **Ctrl + mouse wheel**
	- **Alt + mouse wheel**
3. Click **OK** to confirm.

---
For more information on resetting Visual Studio settings, see [Reset settings](../personalizing-the-visual-studio-ide.md#reset-all-settings).
## Default Zoom Setting

Use this setting to determine the default zoom value for viewing the XAML document.

Select **Tools > Options > XAML Designer** to access the **Default Zoom Setting** property.

|Name|Description|
|-|-|
|**Last Used**|Use the last used zoom value for all the XAML documents by default. When a XAML document is opened for the first time, then it will use "Fit All" setting for the first time only.|
|**Fit All**|Use this option to set the zoom value to "Fit All" for the XAML designer. When a XAML document is closed and reopened, then the last set value will persist for that session but for different sessions "Fit All" will be used by default.|

These settings determine Designer behavior when you edit a XAML document.

|Name|Description|
|-|-|
|**Automatically name interactive elements on creation**|Specifies whether a default name is provided for a new interactive element when you add one to the Designer.|
|**Automatically insert layout properties on element creation**|Specifies whether layout properties are provided for a new element when you add one to the Designer. Layout properties are those that impact the layout of a control, for example, Margin and VerticalAlignment. The following XAML shows how a Button is created with and without this option selected:<br />`<Button Content="Button" HorizontalAlignment="Left" Margin="245,56,0,0" Grid.Row="1" VerticalAlignment="Top" Width="75"/>`<br />`<Button Content="Button" Grid.Row="1"/>`|
|**Use quadrant based layout**|Specifies whether the currently selected control aligns to the nearest edges of the parent container. If this checkbox is cleared, control alignments do not change during a move or create operation.|
|**Automatically populate toolbox items**|Specifies whether user controls and custom controls in the current solution are shown in the Toolbox automatically.|

## Settings (Blend only)

Use these options to determine settings when editing XAML files using Blend.

Select **Tools > Options > XAML Designer** in Blend for Visual Studio to access Blend-specific properties.

|Name|Description|
|-|-|
|**Zoom by using**|Zoom in the XAML Designer by scrolling the mouse wheel, or by pressing the **Ctrl** or **Alt** key while scrolling the mouse wheel.|
|**Type units**|Specifies whether measurements on the designer are based on points or pixels. Because Universal Windows Apps don't support points, units are automatically converted to pixels if **Points** is selected.|

## Artboard (Blend only)

Use these settings to determine XAML Designer behavior when editing XAML documents in Blend.

Select **Tools > Options > XAML Designer** in Blend to access Artboard properties.

### Snapping

|Name|Description|
|-|-|
|**Show snap grid**|When this option is selected, gridlines appear in the designer to help you align controls. Controls added to the designer snap to these gridlines when the **Snap to gridlines** option is selected.|
|**Snap to gridlines**|When controls are added or moved around the designer, they snap to the gridlines.|
|**Gridline spacing**|Specifies the spacing between the gridlines in either pixels or points (as determined by the **Type units** setting).|
|**Snap to snaplines**|Specifies whether controls snap to snaplines.|
|**Default margin**|When **Snap to snaplines** is enabled, specifies the spacing between the control and the snaplines in either pixels or points (as determined by the **Type units** setting).|
|**Default padding**|When **Snap to snaplines** is enabled, specifies the extra spacing between the control and the snaplines in either pixels or points (as determined by the **Type units** setting).|

### Animation

Use this setting to determine whether a warning appears when dependent (non-accelerated) animations are enabled in Blend.

### Effects

Use these settings to determine whether effects are rendered when editing XAML files in the XAML Designer using Blend.

|Name|Description|
|-|-|
|**Render effects**|Specifies whether effects render when editing XAML files in the XAML Designer using Blend.|
|**Zoom threshold**|Specifies the percentage of zoom in which effects render when the **Render effects** checkbox is selected. If you zoom beyond this setting, effects no longer render in the XAML Designer.|

## See also

- [XAML in WPF](/dotnet/framework/wpf/advanced/xaml-in-wpf)
- [Walkthrough: My first WPF desktop application](/dotnet/framework/wpf/getting-started/walkthrough-my-first-wpf-desktop-application)
