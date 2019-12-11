---
title: "Organize objects into layout containers in XAML Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
ms.assetid: 29c80c38-0fa3-48d6-b3a8-3b864f482e44
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# Organize objects into layout containers in XAML Designer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Imagine where you’d like objects to appear on a page; objects such as images, buttons, and videos. Maybe you want them to appear in rows and columns, in a single line vertically or horizontally, or in fixed positions.

 After you’ve had a chance to think about how the page might appear, choose a layout panel. All pages start with one because you need something to add your objects to. By default, it’s a **Grid** but you can change that.

 Layout panels help you arrange objects on a page, but they do more than that. They help you design for different screen sizes and resolutions. When users run your app, everything in a layout panel resizes to match the screen real estate of their device. Of course, if you don’t want your layout to do that, you can override that behavior for a part of the layout, or the entire layout. You can use height and width properties to control that.

 This page describes layout panels and controls, and then directs you to short videos that help you get started with them.

> [!NOTE]
> Some of the videos may refer to Blend or Expression Blend, which use the same XAML designer as Visual Studio and Blend for Visual Studio.

## Layout panels
 Start your page by choosing one of these layout panels. Your page can have more than one. For example, you might start with a **Grid** layout panel, and then add a **StackPanel** to an area in the **Grid** so that you can arrange controls vertically in that element.

 The following layout panels are the most popularly used, but there are others. You can find them all in the **Assets** panel.

- [Grid](#Grid)

- [UniformGrid](#Uniform)

- [Canvas](#Canvas)

- [StackPanel](#Stack)

- [WrapPanel](#Wrap)

- [DockPanel](#Dock)

### <a name="Grid"></a> Grid
 Arrange objects into rows and columns.

 ![](../designers/media/98b234b2-ac3b-441f-9136-98375fee87b7.png "98b234b2-ac3b-441f-9136-98375fee87b7")

 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Using Grids](http://www.popscreen.com/v/6A4hj/Microsoft-Expression-Blend-Using-Grids)

### <a name="Uniform"></a> UniformGrid
 Arrange objects into equal, or uniform, grid regions. This panel is great for arranging a list of images.

 ![](../designers/media/928b9284-a7e8-4678-875a-656b80b78076.png "928b9284-a7e8-4678-875a-656b80b78076")

 (Available only for WPF projects)

 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Working with a UniformGrid](http://www.popscreen.com/v/6A4iq/Microsoft-Expression-Blend-Working-with-a-UniformGrid)

### <a name="Canvas"></a> Canvas
 Arrange objects any way you want. When users run your app, these elements will have fixed positions on the screen.

 ![](../designers/media/e1ae27f0-3a57-454e-b580-877dcea8836d.png "e1ae27f0-3a57-454e-b580-877dcea8836d")

 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Working with the canvas](http://www.popscreen.com/v/6A4hT/Microsoft-Expression-Blend-Working-with-the-Canvas)

### <a name="Stack"></a> StackPanel
 Arrange objects in a single line horizontally or vertically.

 ![](../designers/media/a85a7b57-b0a8-495e-b985-f0291e41d093.png "a85a7b57-b0a8-495e-b985-f0291e41d093")

 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Working with StackPanel and WrapPanel](http://www.popscreen.com/v/6A4i5/Microsoft-Expression-Blend-Using-the-StackPanel-and-WrapPanel)

### <a name="Wrap"></a> WrapPanel
 Arrange objects sequentially from left to right. When the panel runs out of room at the far-right edge, it *wraps* the content to the next line, and so on from left-to-right, top-to-bottom. You can also make the orientation of a wrap panel vertical so that objects flow from top-to-bottom, left-to-right.

 (Available only for WPF projects)

 ![](../designers/media/b1c415fb-9a32-4a18-aa0b-308fca994ac9.png "b1c415fb-9a32-4a18-aa0b-308fca994ac9")

 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Working with StackPanel and WrapPanel](http://www.popscreen.com/v/6A4i5/Microsoft-Expression-Blend-Using-the-StackPanel-and-WrapPanel)

### <a name="Dock"></a> DockPanel
 Arrange objects so that they stay, or *dock*, to one edge of the panel.

 (Available only for WPF projects)

 ![](../designers/media/72d46b58-9a49-4dd5-8af7-6843c0440226.png "72d46b58-9a49-4dd5-8af7-6843c0440226")

 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [WPF - DockPanel](https://www.youtube.com/watch?v=EBH_OIM-zPo)

## Layout controls
 You can add your objects to layout controls as well. They aren’t as feature-rich as a layout panel, but you might find them helpful for certain scenarios.

 The following layout controls are the most popularly used but there are others. You can find them all in the **Assets** panel.

- [Border](#Border)

- [Popup](#Popup)

- [ScrollViewer](#Scroll)

- [UniformGrid](#Uniform)

- [Viewbox](#View)

### <a name="Border"></a> Border
 Create a border, background, or both around an object. You can add only one object to a **Border**. If you want to apply a border or background for more than one object, add layout panel to the **Border**. Then, add objects to that panel or control.

 ![](../designers/media/e761238b-99fd-43c5-bbc4-57538b8289ff.png "e761238b-99fd-43c5-bbc4-57538b8289ff")

 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Working with Borders](http://www.popscreen.com/v/6A4hB/Microsoft-Expression-Blend-Working-with-Borders)

### <a name="Popup"></a> Popup
 Show information or options to users in a window. You can add only one object to a **Popup**. By default, a **Popup** contains a **Grid** but you can change that.

### <a name="Scroll"></a> ScrollViewer
 Enable uses to scroll down a page or area of a page. You can add only one object to a **ScrollViewer** so it makes a lot of sense to add a layout panel such as a **Grid** or **StackPanel**.

 ![](../designers/media/06b326d4-f23d-41a6-b26b-e1aff37572a7.png "06b326d4-f23d-41a6-b26b-e1aff37572a7")

### <a name="View"></a> Viewbox
 Scale objects much like you would with a zoom control. You can add only one object to a **Viewbox**. If you want to apply that effect to more than one object, add a layout panel to the **ViewBox**, and then add your controls to that layout panel.

 (Available only for WPF projects)

 ![](../designers/media/f5b13c66-d918-4141-8a16-bd8f8628687a.png "f5b13c66-d918-4141-8a16-bd8f8628687a")

## See Also
 [Working with elements in XAML Designer](../designers/working-with-elements-in-xaml-designer.md)
 [Creating a UI by using XAML Designer](../designers/creating-a-ui-by-using-xaml-designer-in-visual-studio.md)
