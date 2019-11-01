---
title: "Creating a UI by using Blend"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
f1_keywords:
  - "Blend.Start.Dev12"
ms.assetid: efd12263-cc2d-4081-a2bb-9a2cc17c442c
caps.latest.revision: 33
author: jillre
ms.author: jillfra
manager: jillfra
---
# Creating a UI by using Blend for Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Blend for Visual Studio helps you design XAML-based Windows desktop, web, [Windows Phone](https://msdn.microsoft.com/library/windowsphone/develop/jj683071.aspx), and [Windows Store](https://msdn.microsoft.com/library/windows/apps/jj129478.aspx) apps. It provides the same basic XAML design experience as Visual Studio and adds visual designers for advanced tasks such as animations and behaviors.

 Since Blend for Visual Studio is included as a part of Visual Studio, you don't need to download it. However, you need to select it in the Visual Studio installer for it to install on your system.

 If you’re new to Blend for Visual Studio, take a moment to become familiar with the unique features of the workspace. This topic takes you on a quick tour.

> [!NOTE]
> To tour the shared design features such as the artboard, Document Outline window, and Device window, see [Creating a UI by using XAML Designer](../designers/creating-a-ui-by-using-xaml-designer-in-visual-studio.md).

 **In this topic**:

- [Tour of the Tools panel](#Tools)

- [Tour of the Assets panel](#Assets)

- [Tour of the Objects and Timeline panel](#Objects)

- [Tour of the Properties panel](#Properties)

## <a name="Tools"></a> Tour of the Tools panel
 You can use the **Tools** panel in Blend for Visual Studio to create and modify objects in your application. You create the objects by selecting a tool and drawing on the artboard with your mouse.

 ![Tools panel](../designers/media/blend5toolspanel.png "Blend5Toolspanel")

|||||
|-|-|-|-|
|![](../designers/media/b1-1.png "B1_1")|**Selection tools** Select objects and paths.<br /><br /> Use the **Direct Selection** tool to select nested objects and path segments.|![Callout A](../designers/media/b5-label-a.png "b5_label_A")|**Gradient and brush tools**|
|![](../designers/media/b1-2.png "B1_2")|**View tools** Adjust the view of the artboard, such as for panning and zooming.|![Callout B](../designers/media/b5-label-b.png "b5_label_B")|**Path tools**|
|![](../designers/media/b1-3.png "B1_3")|**Brush tools** Work with the visual attributes of an object, such as transforming a brush, painting an object, or selecting the attributes of one object to apply them to another object.|![Callout C](../designers/media/b5-label-c.png "b5_label_C")|**Shape tools**|
|![](../designers/media/b1-4.png "B1_4")|**Object tools** Draw the most common objects on the artboard, such as paths, shapes, layout panels, text, and controls.|![Callout D](../designers/media/b5-label-d.png "b5_label_D")|**Layout panels**|
|![](../designers/media/b1-5.png "B1_5")|**Asset tools** Access the **Assets** panel and to show the most recently used asset from the library.|![Callout E](../designers/media/b5-label-e.png "b5_label_E")|**Text controls**|
|||![Callout F](../designers/media/b5-label-f.png "b5_label_F")|**Common controls**|

 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [The Toolbar](https://www.youtube.com/watch?v=VkdUJcvoo54&list=PLBDF977B2F1DAB358&index=4).

## <a name="Assets"></a> Tour of the Assets panel
 You can find all controls in the **Assets** panel, similar to the **Toolbox** in Visual Studio. In addition to controls, you’ll find everything you can add to your artboard in the **Assets** panel, including styles, media, behaviors, and effects.

 ![Assets panel](../designers/media/blend5-assets-panel.png "Blend5_Assets_panel")

|||
|-|-|
|![](../designers/media/b1-1.png "B1_1")|**Search box** Type in the **Search** box to filter the list of assets.|
|![](../designers/media/b1-2.png "B1_2")|**Grid mode and List mode** Switch between the **Grid mode** view and the **List mode** view of assets.|
|![](../designers/media/b1-3.png "B1_3")|**Assets categories** Click a category or subcategory to view the list of assets in that category.|
|![](../designers/media/b1-4.png "B1_4")|**Styles** Show all the styles that are contained in the resource dictionary.|
|![](../designers/media/b1-5.png "B1_5")|**Description** View a description of the selected assets category or subcategory.|

## <a name="Objects"></a> Tour of the Objects and Timeline panel
 Use this panel to organize the objects on your artboard and, if you want, to animate them.

 ![Object and Timeline panel in animation mode](../designers/media/b5-object-timeline-animation.png "b5_object_timeline_animation")

|||
|-|-|
|![](../designers/media/b1-1.png "B1_1")|**Objects view** View a visual tree of a document. You can drill down to varying levels of detail. You can also add layers to further organize objects on the artboard. That way you can lock and hide them as a group.|
|![](../designers/media/b1-2.png "B1_2")|**Record mode indicator** See whether you’re recording property changes in a timeline.|
|![](../designers/media/b1-3.png "B1_3")|**Storyboard picker** View a list of storyboards that you’ve created.|
|![](../designers/media/b1-4.png "B1_4")|**Close storyboard** Close the current storyboard.|
|![](../designers/media/b1-5.png "B1_5")|**Storyboard options** Create, duplicate, reverse, delete, rename, or close a storyboard.|
|![](../designers/media/b1-6.png "B1_6")|**Playback controls** Navigate through the timeline. You can also drag the playhead to navigate through (or *scrub*) the timeline.|
|![](../designers/media/b1-7.png "B1_7")|**Return scope to** Scope the objects view back to the previous root object or previous scope. You can do this only when you’re modifying a style or template.|
|![](../designers/media/b1-8.png "B1_8")|**Record a keyframe** Record a snapshot of the properties of the selected object at the current point in time.|
|![](../designers/media/b1-9.png "B1_9")|**Snapping options** Set timeline snapping, snap resolution, and turn off timeline snapping.|
|![](../designers/media/97fa60b9-0caf-4387-9225-b57510d32209.png "97fa60b9-0caf-4387-9225-b57510d32209")|**Show/hide**, **Lock/unlock** Show or hide the visibility and locking options for the objects view.|
|![](../designers/media/b1-11.png "B1_11")|**Playhead position on the timeline** Show the current time in milliseconds. You can also enter a time value directly in this field to jump to a particular point in time. The precision depends on the snap resolution set in the **Snapping Options**.|
|![](../designers/media/b1-12.png "B1_12")|**Playhead** Determine what point in time the animation is at. You can drag the playhead across the timeline to preview animation.|
|![](../designers/media/b1-13.png "B1_13")|**Keyframes set on timelines** Change a property value at a specific point in time.|
|![](../designers/media/d839d12c-07a1-4127-a830-4a8e7069f4fe.png "d839d12c-07a1-4127-a830-4a8e7069f4fe")|**Change order of objects** Set the display order of objects. Click this button to arrange objects in the structure view by Z order (front-to-back) or by markup order (the order in which they appear in **XAML** view).|
|![](../designers/media/b1-15.png "B1_15")|**Timeline zoom** Set the zoom resolution of the timeline. Zooming in lets you edit an animation with more detail, and zooming out shows more of an overview of what is happening over longer periods of time. If you zoom in but can't set a keyframe at the position in time that you want, verify that the snap resolution is set high enough.|
|![Callout 16](../designers/media/b5-label-16.png "b5_label_16")|**Timeline composition area** View the timeline, and move keyframes around by dragging them or using their shortcut menus.|

## <a name="Properties"></a> Tour of the Properties panel
 Use this panel to view and modify the properties of an object. You can also set them directly on the artboard. If you do, the property changes will be reflected in the **Properties** panel.

 ![Properties panel](../designers/media/blend5-properties-panel.png "Blend5_properties_panel")

 **Categories** Expand and collapse categories of properties. Click **Expand** ![](../designers/media/6375953d-074c-421a-bbb3-6f5055b67b64.png "6375953d-074c-421a-bbb3-6f5055b67b64") and **Collapse** ![Collapse](../designers/media/b5-collapse-button.png "b5_collapse_button") to show or hide category details.

|                                                                                                         |                                                                                                                                                                                                                                  |
|---------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                                 ![](../designers/media/b1-1.png "B1_1")                                 |                                                                              **Name and Type** View the icon, name and type of the selected object.                                                                              |
|                                 ![](../designers/media/b1-2.png "B1_2")                                 |                                                                          **Arrange by** Arrange properties alphabetically by name, source, or category.                                                                          |
|                                 ![](../designers/media/b1-3.png "B1_3")                                 |                                                        **Brush properties** Set the visual properties for brushes such as Fill brush, Stroke brush, and Foreground brush.                                                        |
|                                 ![](../designers/media/b1-4.png "B1_4")                                 |                                                                                    **Color editor** Use for solid color and gradient brushes.                                                                                    |
|                                 ![](../designers/media/b1-5.png "B1_5")                                 |                                                                                                 **Color picker** Select a color.                                                                                                 |
|                                 ![](../designers/media/b1-6.png "B1_6")                                 |                                                                              **Color chips** View the initial color, current color, and last color                                                                               |
|                                 ![](../designers/media/b1-7.png "B1_7")                                 | **Eyedroppers** Use the color of any element on your screen. The **Color eyedropper** is available when the **Solid color brush** is selected. The **Gradient eyedropper** is available when the **Gradient brush** is selected. |
|                                 ![](../designers/media/b1-8.png "B1_8")                                 |                                                                        **Properties and Events** Set properties or choose events for a selected element.                                                                         |
|                                 ![](../designers/media/b1-9.png "B1_9")                                 |                                                         **Search box** Search for properties. Filter the properties that are displayed by typing in the **Search** box.                                                          |
| ![](../designers/media/97fa60b9-0caf-4387-9225-b57510d32209.png "97fa60b9-0caf-4387-9225-b57510d32209") |                                **Brush editor tabs** Use to select a brush editor. You can choose **No brush**, **Solid Color brush**, **Gradient brush**, **Tile brush**, or **Brush resource**.                                |
|                                ![](../designers/media/b1-11.png "B1_11")                                |                                    **Color resources** Apply the exact same color to different properties. The **Color Resources** tab includes **Local Resources** and **System Resources**.                                    |
|                                ![](../designers/media/b1-12.png "B1_12")                                |                                                 **RGB color space** Modify the color by adjusting the values for the **R**,  **G**, or **B** (red, green, blue) number editors.                                                  |
|                                ![](../designers/media/b1-13.png "B1_13")                                |                                                                        **Alpha channel** Modify the Alpha value by using the number editor next to **A**.                                                                        |
| ![](../designers/media/d839d12c-07a1-4127-a830-4a8e7069f4fe.png "d839d12c-07a1-4127-a830-4a8e7069f4fe") |                                       **Convert color to resource** Convert the selected color to a color resource. Color resources are available when you click the Color resources tab.                                        |
|                                ![](../designers/media/b1-15.png "B1_15")                                |                                                                                 **Hex value** View the hexadecimal value of the color displayed.                                                                                 |
|                     ![Callout 16](../designers/media/b5-label-16.png "b5_label_16")                     |                                                                                **Gradient slider** Appears only if a gradient brush is selected.                                                                                 |
| ![](../designers/media/d50027a1-6824-4ad8-8b4e-558b0756dcf8.png "d50027a1-6824-4ad8-8b4e-558b0756dcf8") |                                                                     **Show advanced properties** View categories of properties that are less commonly used.                                                                      |

 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Properties panel](https://www.youtube.com/watch?v=HCqQfiobdag&list=PLBDF977B2F1DAB358&index=7).

## See Also
 [Insert controls and modify their behavior](../designers/insert-controls-and-modify-their-behavior-in-xaml-designer.md)
 [Animate objects](../designers/animate-objects-in-xaml-designer.md)
 [Draw shapes and paths](../designers/draw-shapes-and-paths.md)
 [Designing XAML in Visual Studio and Blend for Visual Studio](../designers/designing-xaml-in-visual-studio.md)
