---
title: "XAML Designer options page | Microsoft Docs"
ms.custom: ""
ms.date: "03/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.ToolsOptionsPages.XAMLDesigner"
ms.assetid: ad3820b2-0d95-4807-a75c-c3467ed973a3
caps.latest.revision: 1
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "uwp"
---
# XAML Designer options page
Use the **XAML Designer** options page to specify how elements and attributes are formatted in your XAML documents. To open this page, choose the **Tools** menu and then choose **Options**. To access the **XAML Designer** property page, choose the **XAML Designer** node. Settings for the XAML Designer are applied when you open the document. So, if you make changes to the settings, you need to close and then reopen Visual Studio to see the changes.

> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md).  

## Enable XAML Designer
When selected, this setting enables the XAML Designer. The XAML Designer provides a visual work area for you to edit XAML documents. Certain functionality in Visual Studio, such as IntelliSense for resources and databinding, require the XAML Designer to be enabled.

The following settings apply only when XAML Designer is enabled. If you change this option, you will need to restart Visual Studio for the setting to take effect.

## Default document view
Use this setting to control whether Design view appears when XAML documents are loaded.

|||  
|-|-|  
|**Source View**|Specifies whether only XAML source appears in the XAML view. This is useful when  loading large documents.|  
|**Design View**|Specifies whether only a visual XAML Designer appears in the XAML view.|  
|**Split View**|Specifies whether both the visual XAML Designer and the XAML source appear next to one another in the XAML view (location based on the **Split Orientation** setting).|  

## Split Orientation
Use this setting to control when and how the XAML Designer appears when editing a XAML document. These settings apply only when **Default document view** is set to **Split View**.

|||  
|-|-|  
|**Vertical**|XAML source appears on the left side of the XAML view, and the XAML Designer appears on the other side.|  
|**Horizontal**|The XAML Designer appears on the top of the XAML view, and the XAML source appears below it.|  
|**Default**|The XAML document uses the split orientation recommended for the platform targeted by the document's project. For most platforms this is equivalent to **Horizontal**.|  

## Zoom by using
Use this setting to determine how zoom works when editing a XAML document.

|||  
|-|-|  
|**Mouse wheel**|Zoom in the XAML Designer by scrolling the mouse wheel.|  
|**Ctrl + mouse wheel**|Zoom in the XAML Designer by pressing the CTRL key while scrolling the mouse wheel.|  
|**Alt + mouse wheel**|Zoom in the XAML Designer by pressing the ALT key while scrolling the mouse wheel.|  

These settings determine Designer behavior when editing a XAML document.

|||  
|-|-|  
|**Automatically name interactive elements on creation**|Specifies whether a default name is provided for a new interactive element when you add one to the Designer.|  
|**Automatically insert layout properties on element creation**|Specifies whether layout properties are provided for a new element when you add one to the Designer.|  
|**Use quadrant based layout**|Specifies whether the currently selected control aligns to the nearest edges of the parent container. If this checkbox is cleared, control alignments do not change during a move or create operation.|  
|**Automatically populate toolbox items**|Specifies whether user controls and custom controls in the current solution are shown in the Toolbox automatically.|  

## Settings (Blend only)
Use these options to determine settings when editing XAML files using Blend.

|||  
|-|-|  
|**Zoom by using**|Zoom in the XAML Designer by scrolling the mouse wheel, or by pressing the CTRL or ALT key while scrolling the mouse wheel.|  
|**Type units**|Specifies whether measurements on the designer are based on points or pixels. Because Universal Windows Apps don't support points, units are automatically converted to pixels if **Points** is selected.|  

## Artboard (Blend only)
Use these settings to determine XAML Designer behavior when editing XAML documents in Blend.

### Snapping

|||  
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

|||  
|-|-|  
|**Render effects**|Specifies whether effects render when editing XAML files in the XAML Designer using Blend.|  
|**Zoom threshold**|Specifies the percentage of zoom in which effects render when the **Render effects** checkbox is selected. If you zoom beyond this setting, effects no longer render in the XAML Designer.|  

## See Also  
 [XAML in WPF](/dotnet/framework/wpf/advanced/xaml-in-wpf)   
 [How to: Change XAML View Settings](http://msdn.microsoft.com/en-us/aee87c79-ca01-4f84-8fb7-a9e47048ee47)   
 [XAML and Code Walkthroughs](http://msdn.microsoft.com/en-us/b3ff41a0-a2a3-4f61-b698-ac88ec8f799c)
