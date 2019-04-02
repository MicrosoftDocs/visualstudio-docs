---
title: Blend for Visual Studio feature tour
titleSuffix: ""
ms.date: 07/17/2017
ms.topic: conceptual
f1_keywords:
  - "Blend.Start.Dev12"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Blend for Visual Studio overview

Blend for Visual Studio helps you design XAML-based Windows and Web applications. It provides the same basic XAML design experience as Visual Studio and adds visual designers for advanced tasks such as animations and behaviors. For a comparison between Blend and Visual Studio, see [Design XAML in Visual Studio and Blend for Visual Studio](../designers/designing-xaml-in-visual-studio.md).

Blend for Visual Studio is a component of Visual Studio. To install Blend, in the **Visual Studio Installer** choose either the **Universal Windows Platform development** or **.NET desktop development** workload. Both of these workloads include the Blend for Visual Studio component.

![UWP workload components](media/installer-uwp.png)&nbsp;&nbsp;&nbsp;&nbsp;![.NET desktop development workload components](media/installer-dotnet-desktop.png)

If you're new to Blend for Visual Studio, take a moment to become familiar with the unique features of the workspace. This topic takes you on a quick tour.

> [!NOTE]
> To tour the shared design features such as the artboard, **Document Outline** window, and **Device** window, see [Creating a UI by using XAML Designer](../designers/creating-a-ui-by-using-xaml-designer-in-visual-studio.md).

## Tools panel

You can use the **Tools** panel in Blend for Visual Studio to create and modify objects in your application. The **Tools** panel appears on the left-hand side of the XAML designer when you have a *.xaml* file open.

You create the objects by selecting a tool and drawing on the artboard with your mouse.

![Tools panel in Blend for Visual Studio](../designers/media/blend5toolspanel.png)

> [!TIP]
> Some of the tools in the **Tools** panel have variations (shown as A through F in the illustration). To access these variations, right-click or click and hold on the tool.
>
> ![Shape tool variations in Blend for Visual Studio](media/rectangle-shape-tool-blend.png)

|||||
|-|-|-|-|
|![Selection tools](../designers/media/b1_1.png)|**Selection tools** Select objects and paths.<br /><br /> Use the **Direct Selection** tool to select nested objects and path segments.|![Callout A](../designers/media/b5_label_a.png)|**Gradient and brush tools**|
|![View tools](../designers/media/b1_2.png)|**View tools** Adjust the view of the artboard, such as for panning and zooming.|![Callout B](../designers/media/b5_label_b.png)|**Path tools**|
|![Brush tools](../designers/media/b1_3.png)|**Brush tools** Work with the visual attributes of an object, such as transforming a brush, painting an object, or selecting the attributes of one object to apply them to another object.|![Callout C](../designers/media/b5_label_c.png)|**Shape tools**|
|![Object tools](../designers/media/b1_4.png)|**Object tools** Draw the most common objects on the artboard, such as paths, shapes, layout panels, text, and controls.|![Callout D](../designers/media/b5_label_d.png)|**Layout panels**|
|![Asset tools](../designers/media/b1_5.png)|**Asset tools** Access the **Assets** panel and to show the most recently used asset from the library.|![Callout E](../designers/media/b5_label_e.png)|**Text controls**|
|||![Callout F](../designers/media/b5_label_f.png)|**Common controls**|

## Assets window

The **Assets** window contains all the available controls and is similar to the **Toolbox** in Visual Studio. In addition to controls, you'll find everything you can add to your artboard in the **Assets** window, including styles, media, behaviors, and effects. To open the **Assets** window, choose **View** > **Assets Window** or press **Ctrl**+**Alt**+**X**.

![Assets window in Blend for Visual Studio](../designers/media/blend5_assets_panel.png)

|||
|-|-|
|![](../designers/media/b1_1.png)|**Search box** Type in the **Search** box to filter the list of assets.|
|![Grid mode and list mode](../designers/media/b1_2.png)|**Grid mode and List mode** Switch between the **Grid mode** view and the **List mode** view of assets.|
|![Assets categories](../designers/media/b1_3.png)|**Assets categories** Click a category or subcategory to view the list of assets in that category.|
|![Styles](../designers/media/b1_4.png)|**Styles** Show all the styles that are contained in the resource dictionary.|
|![Description](../designers/media/b1_5.png)|**Description** View a description of the selected assets category or subcategory.|

## Objects and Timeline window

Use this window to organize the objects on your artboard and, if you want, to animate them. To open the **Objects and Timeline** window, choose **View** > **Objects and Timeline** or press **Ctrl**+**W**, **U**.

![Object and Timeline window in animation mode](../designers/media/b5_object_timeline_animation.png)

|||
|-|-|
|![Objects view](../designers/media/b1_1.png)|**Objects view** View a visual tree of a document. You can drill down to varying levels of detail. You can also add layers to further organize objects on the artboard. That way you can lock and hide them as a group.|
|![Record mode indicator](../designers/media/b1_2.png)|**Record mode indicator** See whether you're recording property changes in a timeline.|
|![Storyboard picker](../designers/media/b1_3.png)|**Storyboard picker** View a list of storyboards that you've created.|
|![Close storyboard](../designers/media/b1_4.png)|**Close storyboard** Close the current storyboard.|
|![Storyboard options](../designers/media/b1_5.png)|**Storyboard options** Create, duplicate, reverse, delete, rename, or close a storyboard.|
|![Playback controls](../designers/media/b1_6.png)|**Playback controls** Navigate through the timeline. You can also drag the playhead to navigate through (or *scrub*) the timeline.|
|![Return scope to](../designers/media/b1_7.png)|**Return scope to** Scope the objects view back to the previous root object or previous scope. You can do this only when you're modifying a style or template.|
|![Record a keyframe](../designers/media/b1_8.png)|**Record a keyframe** Record a snapshot of the properties of the selected object at the current point in time.|
|![Snapping options](../designers/media/b1_9.png)|**Snapping options** Set timeline snapping, snap resolution, and turn off timeline snapping.|
|![Show hide lock unlock](../designers/media/97fa60b9-0caf-4387-9225-b57510d32209.png)|**Show/hide**, **Lock/unlock** Show or hide the visibility and locking options for the objects view.|
|![Playhead position on the timeline](../designers/media/b1_11.png)|**Playhead position on the timeline** Show the current time in milliseconds. You can also enter a time value directly in this field to jump to a particular point in time. The precision depends on the snap resolution set in the **Snapping Options**.|
|![Playhead](../designers/media/b1_12.png)|**Playhead** Determine what point in time the animation is at. You can drag the playhead across the timeline to preview animation.|
|![Keyframes set on timelines](../designers/media/b1_13.png)|**Keyframes set on timelines** Change a property value at a specific point in time.|
|![Change order of objects](../designers/media/d839d12c-07a1-4127-a830-4a8e7069f4fe.png)|**Change order of objects** Set the display order of objects. Click this button to arrange objects in the structure view by Z order (front-to-back) or by markup order (the order in which they appear in **XAML** view).|
|![Timeline zoom](../designers/media/b1_15.png)|**Timeline zoom** Set the zoom resolution of the timeline. Zooming in lets you edit an animation with more detail, and zooming out shows more of an overview of what is happening over longer periods of time. If you zoom in but can't set a keyframe at the position in time that you want, verify that the snap resolution is set high enough.|
|![Callout 16](../designers/media/b5_label_16.png)|**Timeline composition area** View the timeline, and move keyframes around by dragging them or using their shortcut menus.|

## Properties window

Use this window to view and modify the properties of an object. You can also set them directly on the artboard. If you do, the property changes are reflected in the **Properties** window. To open the **Properties** window, choose **View** > **Properties Window**, or press **Ctrl**+**W**, **P**.

![Properties window in Blend for Visual Studio](../designers/media/blend5_properties_panel.png)

**Categories** Expand and collapse categories of properties. Click **Expand** ![Expand](../designers/media/6375953d-074c-421a-bbb3-6f5055b67b64.png) and **Collapse** ![Collapse](../designers/media/b5_collapse_button.png) to show or hide category details.

|||
|-|-|
|![Name and Type](../designers/media/b1_1.png)|**Name and Type** View the icon, name and type of the selected object.|
|![Arrange by](../designers/media/b1_2.png)|**Arrange by** Arrange properties alphabetically by name, source, or category.|
|![Brush properties](../designers/media/b1_3.png)|**Brush properties** Set the visual properties for brushes such as Fill brush, Stroke brush, and Foreground brush.|
|![Color editor](../designers/media/b1_4.png)|**Color editor** Use for solid color and gradient brushes.|
|![Color picker](../designers/media/b1_5.png)|**Color picker** Select a color.|
|![Color chips](../designers/media/b1_6.png)|**Color chips** View the initial color, current color, and last color|
|![Eyedroppers](../designers/media/b1_7.png)|**Eyedroppers** Use the color of any element on your screen. The **Color eyedropper** is available when the **Solid color brush** is selected. The **Gradient eyedropper** is available when the **Gradient brush** is selected.|
|![Properties and events](../designers/media/b1_8.png)|**Properties and Events** Set properties or choose events for a selected element.|
|![Search box](../designers/media/b1_9.png)|**Search box** Search for properties. Filter the properties that are displayed by typing in the **Search** box.|
|![Brush editor tabs](../designers/media/97fa60b9-0caf-4387-9225-b57510d32209.png)|**Brush editor tabs** Use to select a brush editor. You can choose **No brush**, **Solid Color brush**, **Gradient brush**, **Tile brush**, or **Brush resource**.|
|![Color resource](../designers/media/b1_11.png)|**Color resources** Apply the exact same color to different properties. The **Color Resources** tab includes **Local Resources** and **System Resources**.|
|![RGB color space](../designers/media/b1_12.png)|**RGB color space** Modify the color by adjusting the values for the **R**,  **G**, or **B** (red, green, blue) number editors.|
|![Alpha channel](../designers/media/b1_13.png)|**Alpha channel** Modify the Alpha value by using the number editor next to **A**.|
|![Convert color to resource](../designers/media/d839d12c-07a1-4127-a830-4a8e7069f4fe.png)|**Convert color to resource** Convert the selected color to a color resource. Color resources are available when you click the Color resources tab.|
|![](../designers/media/b1_15.png)|**Hex value** View the hexadecimal value of the color displayed.|
|![Callout 16](../designers/media/b5_label_16.png)|**Gradient slider** Appears only if a gradient brush is selected.|
|![Show advanced properties](../designers/media/d50027a1-6824-4ad8-8b4e-558b0756dcf8.png)|**Show advanced properties** View categories of properties that are less commonly used.|

## See also

- [Insert controls and modify their behavior](../designers/insert-controls-and-modify-their-behavior-in-xaml-designer.md)
- [Animate objects](../designers/animate-objects-in-xaml-designer.md)
- [Draw shapes and paths](../designers/draw-shapes-and-paths.md)
- [Designing XAML in Visual Studio and Blend for Visual Studio](../designers/designing-xaml-in-visual-studio.md)
