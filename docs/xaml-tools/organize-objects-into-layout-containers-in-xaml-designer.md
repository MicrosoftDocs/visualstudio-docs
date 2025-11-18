---
title: Organize objects into layout containers
description: Explore the layout panels and controls in XAML Designer that are used to arrange objects on a page, such as Grid, Canvas, Border, and Viewbox.
ms.date: 07/17/2020
ms.topic: article
author: maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: xaml-tools
---
# Organize objects into layout containers in XAML Designer

This article describes layout panels and controls for XAML Designer.

Imagine where you'd like objects to appear on a page&mdash;objects such as images, buttons, and videos. Maybe you want them to appear in rows and columns, in a single line vertically or horizontally, or in fixed positions.

After you've had a chance to think about how the page might appear, choose a layout panel. All pages start with one because you need something to which you add your objects. By default it's a **Grid**, but you can change that.

Layout panels help you arrange objects on a page, but they do more than that. They help you design for different screen sizes and resolutions. When users run your app, everything in a layout panel resizes to match the screen real estate of their device. Of course, if you don't want your layout to do that, you can override that behavior for a part of the layout or the entire layout. You can use height and width properties to control that.

## Layout panels

Start your page by choosing one of these layout panels. Your page can have more than one. For example, you might start with a **Grid** layout panel, and then add a **StackPanel** to an area in the **Grid** so that you can arrange controls vertically in that element.

The following layout panels are the most popularly used, but there are others. You can find them all in **Toolbox** in Visual Studio or the **Assets** panel in Blend for Visual Studio.

### Grid

Arrange objects into rows and columns.

![Grid layout panel](../designers/media/98b234b2-ac3b-441f-9136-98375fee87b7.png)

### UniformGrid

Arrange objects into equal, or uniform, grid regions. This panel is great for arranging a list of images.

(Available only for WPF projects.)

![UniformGrid layout panel](../designers/media/928b9284-a7e8-4678-875a-656b80b78076.png)

### Canvas

Arrange objects any way you want. When users run your app, these elements will have fixed positions on the screen.

![Canvas layout panel](../designers/media/e1ae27f0-3a57-454e-b580-877dcea8836d.png)

### StackPanel

Arrange objects in a single line horizontally or vertically.

![StackPanel layout panel](../designers/media/a85a7b57-b0a8-495e-b985-f0291e41d093.png)

### WrapPanel

Arrange objects sequentially from left to right. When the panel runs out of room at the far-right edge, it *wraps* the content to the next line, and so on from left-to-right, top-to-bottom. You can also make the orientation of a wrap panel vertical so that objects flow from top-to-bottom, left-to-right.

(Available only for WPF projects.)

![WrapPanel layout panel](../designers/media/b1c415fb-9a32-4a18-aa0b-308fca994ac9.png)

### DockPanel

Arrange objects so that they stay, or *dock*, to one edge of the panel.

(Available only for WPF projects.)

![DockPanel layout panel](../designers/media/72d46b58-9a49-4dd5-8af7-6843c0440226.png)

**Watch a short video:** ![Play button](../designers/media/bldadminconsoleinitialconfigicon.PNG) [WPF - DockPanel](https://www.youtube.com/watch?v=EBH_OIM-zPo)

## Layout controls

You can add your objects to layout controls as well. They aren't as feature-rich as a layout panel, but you might find them helpful for certain scenarios.

The following layout controls are the most popular, but there are others. You can find them all in **Toolbox** in Visual Studio or the **Assets** panel in Blend for Visual Studio.

### Border

Create a border, background, or both around an object. You can add only one object to a **Border**. If you want to apply a border or background for more than one object, add a layout panel to the **Border**. Then, add objects to that panel or control.

![Border layout control](../designers/media/e761238b-99fd-43c5-bbc4-57538b8289ff.png)

### Popup

Show information or options to users in a window. You can add only one object to a **Popup**. By default, a **Popup** contains a **Grid**, but you can change that.

### ScrollViewer

Enable users to scroll down a page or area of a page. You can add only one object to a **ScrollViewer**, so it makes sense to add a layout panel such as a **Grid** or **StackPanel**.

![ScrollViewer layout control](../designers/media/06b326d4-f23d-41a6-b26b-e1aff37572a7.png)

### Viewbox

Scale objects much like you would with a zoom control. You can add only one object to a **Viewbox**. If you want to apply that effect to more than one object, add a layout panel to the **ViewBox**, and then add your controls to that layout panel.

![ViewBox layout control](../designers/media/f5b13c66-d918-4141-8a16-bd8f8628687a.png)

## Related content

- [Work with elements in XAML Designer](../xaml-tools/working-with-elements-in-xaml-designer.md)
- [Create a UI by using XAML Designer](../xaml-tools/creating-a-ui-by-using-xaml-designer-in-visual-studio.md)
