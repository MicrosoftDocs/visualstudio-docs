---
title: XAML Designer options page
description: Learn how to use the General page in the XAML Designer section to specify how elements and attributes are formatted in your XAML documents.
ms.date: 03/02/2017
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.XAMLDesigner
- VS.ToolsOptionsPages.XAML_Designer.General
ms.custom: "ide-ref"
author:maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: general-ide
---
# XAML Designer options page

Use the **XAML Designer** options page to specify how elements and attributes are formatted in your XAML documents. To open this page, choose the **Tools** menu and then choose **Options**. To access the **XAML Designer** property page, choose the **XAML Designer** node. Settings for the XAML Designer are applied when you open the document. So, if you make changes to the settings, you need to close and then reopen Visual Studio to see the changes.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset settings](../personalizing-the-visual-studio-ide.md#reset-all-settings).

## Enable XAML Designer

When selected, this setting enables the XAML Designer. The XAML Designer provides a visual work area for you to edit XAML documents. Certain functionality in Visual Studio, such as IntelliSense for resources and databinding, require the XAML Designer to be enabled.

The following settings apply only when XAML Designer is enabled. If you change this option, you will need to restart Visual Studio for the setting to take effect.

## Default document view

Use this setting to control whether Design view appears when XAML documents are loaded.

|Name|Description|
|-|-|
|**Source View**|Specifies whether only XAML source appears in the XAML view. This is useful when  loading large documents.|
|**Design View**|Specifies whether only a visual XAML Designer appears in the XAML view.|
|**Split View**|Specifies whether both the visual XAML Designer and the XAML source appear next to one another in the XAML view (location based on the **Split Orientation** setting).|

## Split Orientation

Use this setting to control when and how the XAML Designer appears when editing a XAML document. These settings apply only when **Default document view** is set to **Split View**.

|Name|Description|
|-|-|
|**Vertical**|XAML source appears on the left side of the XAML view, and the XAML Designer appears on the other side.|
|**Horizontal**|The XAML Designer appears on the top of the XAML view, and the XAML source appears below it.|
|**Default**|The XAML document uses the split orientation recommended for the platform targeted by the document's project. For most platforms this is equivalent to **Horizontal**.|

## Zoom by using

Use this setting to determine how zoom works when editing a XAML document.

|Name|Description|
|-|-|
|**Mouse wheel**|Zoom in the XAML Designer by scrolling the mouse wheel.|
|**Ctrl + mouse wheel**|Zoom in the XAML Designer by pressing the **Ctrl** key while scrolling the mouse wheel.|
|**Alt + mouse wheel**|Zoom in the XAML Designer by pressing the **Alt** key while scrolling the mouse wheel.|

These settings determine Designer behavior when editing a XAML document.

## Default Zoom Setting

Use this setting to determine the default zoom value for viewing the XAML document.

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

|Name|Description|
|-|-|
|**Zoom by using**|Zoom in the XAML Designer by scrolling the mouse wheel, or by pressing the **Ctrl** or **Alt** key while scrolling the mouse wheel.|
|**Type units**|Specifies whether measurements on the designer are based on points or pixels. Because Universal Windows Apps don't support points, units are automatically converted to pixels if **Points** is selected.|

## Artboard (Blend only)

Use these settings to determine XAML Designer behavior when editing XAML documents in Blend.

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
