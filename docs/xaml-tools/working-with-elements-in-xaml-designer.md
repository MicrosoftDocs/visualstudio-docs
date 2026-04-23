---
title: Working with elements in XAML Designer
description: Work with elements in the XAML Designer in Visual Studio or Blend for Visual Studio and add elements—controls, layouts, and shapes—to your app in XAML.
ms.date: 05/14/2018
ms.topic: how-to
author: maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: xaml-tools
---
# Work with elements in XAML Designer

You can add elements—controls, layouts, and shapes—to your app in XAML, in code, or by using XAML Designer. This topic describes how to work with elements in XAML Designer in Visual Studio or Blend for Visual Studio.

## Add an element to a layout

*Layout* is the process of sizing and positioning elements in a UI. To position visual elements, you must put them in a layout [Panel](xref:Windows.UI.Xaml.Controls.Panel). A `Panel` has a child property that is a collection of [FrameworkElement](xref:Windows.UI.Xaml.FrameworkElement) types. You can use various `Panel` child elements, such as [Canvas](xref:Windows.UI.Xaml.Controls.Canvas), [StackPanel](xref:Windows.UI.Xaml.Controls.StackPanel), and [Grid](xref:Windows.UI.Xaml.Controls.Grid), to serve as layout containers and to position and arrange the elements on a page.

By default, a `Grid` panel is used as the top-level layout container within a page or form. You can add layout panels, controls, or other elements within the top-level page layout.

To add an element to a layout in XAML Designer, do one of the following:

- Double-click an element in the **Toolbox** (or select an element in the Toolbox and press **Enter**).

- Drag an element from the **Toolbox** to the artboard.

- In the **Toolbox**, select one of the drawing tools (for example, [Ellipse](xref:Windows.UI.Xaml.Shapes.Ellipse) or [Rectangle](xref:Windows.UI.Xaml.Shapes.Rectangle)), and then draw an element in the active panel.

## Change the layering order of elements

When there are two elements on the artboard in XAML Designer, one element will appear in front of the other in the layering order. At the bottom of the list of elements, in the Document Outline window is the front-most element (except for when the **ZIndex** property for an element is set). When you insert an element into a page, form, or layout container, the element is automatically placed in front of other elements in the active container element. To change the order of elements, you can use the **Order** commands or drag the elements in the object tree in the Document Outline window.

To change the layering order, do one of the following:

- In the **Document Outline** window, drag the elements up or down to create the desired layering order.

- Right-click the element in the Document Outline window or the artboard for which you want to change the layering order, point to **Order**, and then click one of the following:

  - **Bring to Front** to bring the element all the way to the front of the order.

  - **Bring Forward** to bring the element forward one level in the order.

  - **Send Backward** to send the element back one level in the order.

  - **Send to Back** to send the element all the way to the back of the order.

- Change the **ZIndex** property in the **Layout** section in the Properties window. For overlapping elements, the **ZIndex** property takes precedence over the order of elements shown in the Document Outline window. An element that has a higher **ZIndex** value appears in front when elements overlap.

## Change the alignment of an element

You can align elements in the artboard by using menu commands or by dragging elements to snaplines.

A *snapline* is a visual cue that helps you align an element relative to other elements in the app.

To align two or more elements by using menu commands:

1. Select the elements that you want to align. You can select more than one element by pressing and holding the **Ctrl** key while you select the elements.

2. Select one of the following properties under **HorizontalAlignment** in the **Layout** section of the Properties window: **Left**, **Center**, **Right**, or **Stretch**.

3. Select one of the following properties under **VerticalAlignment** in the **Layout** section of the Properties window: **Top**, **Center**, **Bottom**, or **Stretch**.

To align two or more elements by using snaplines, in XAML Designer, in a layout that contains at least two elements, drag or resize one of the elements so that the edge is aligned with another element.

When the edges are aligned, an *alignment boundary* appears to indicate alignment. The alignment boundary is a red dashed line. Alignment boundaries appear only when **snapping to snaplines** is enabled. For an illustration of the artboard that shows an alignment boundary, see [Creating a UI by using XAML Designer](../xaml-tools/creating-a-ui-by-using-xaml-designer-in-visual-studio.md).

## Change an element's margins

The margins in XAML Designer determine the amount of empty space that is around an element on the artboard. For example, margins specify the amount of space between the outside edges of an element and the boundaries of a  `Grid` panel that contains the element. Margins also specify the amount of space between elements that are contained in a `StackPanel`.

To change an element's margins in the Properties window:

1. Select the element whose margins you want to change.

2. Under **Layout** in the Properties window, change the value (in pixels or device-independent units, which are approximately 1/96 inch) for any of the **Margin** properties (**Top**, **Left**, **Right**, or **Bottom**).

In the artboard, to change an element's margins relative to the element's layout container, click the *margin adorners* that appear around the element when the element is selected and is within a layout container. For an illustration that shows margin adorners, see [Creating a UI by using XAML Designer](../xaml-tools/creating-a-ui-by-using-xaml-designer-in-visual-studio.md).

If a margin adorner is open, vertically or horizontally, that margin isn't set. If a margin adorner is closed, that margin is set.

When you open a margin adorner and the opposite margin isn't set, the opposite margin is set to the correct value according to the location of the element in the artboard. For opposite margins, such as the **Left** and **Right** margins, at least one property is always set.

> [!IMPORTANT]
> Elements placed inside some layout containers, such as a [Canvas](xref:Windows.UI.Xaml.Controls.Canvas), don't have margin adorners. Elements placed inside a [StackPanel](xref:Windows.UI.Xaml.Controls.StackPanel) have margin adorners for either the left and right margins or the top and bottom margins, depending on the orientation of the `StackPanel`.

## Group and ungroup elements

Grouping two or more elements in XAML Designer creates a new layout container and places those elements within that container. Placing two or more elements together in a layout container enables you to easily select, move, and transform the group as if the elements in that group were one element. Grouping is also useful for identifying elements that are related to each other in some way, such as the buttons that make up a navigation element. When you ungroup elements, you are simply deleting the layout container that contained the elements.

To group elements into a new layout container:

1. Select the elements that you want to group. (To select multiple elements, press and hold the **Ctrl** key while you click them.)

2. Right-click the selected elements, point to **Group Into**, and then click the type of layout container in which you want the group to reside.

    > [!TIP]
    > If you select [Viewbox](xref:Windows.UI.Xaml.Controls.Viewbox), [Border](xref:Windows.UI.Xaml.Controls.Border), or [ScrollViewer](xref:Windows.UI.Xaml.Controls.ScrollViewer) to group your elements, the elements are placed in a new [Grid](xref:Windows.UI.Xaml.Controls.Grid) panel within the [Viewbox](xref:Windows.UI.Xaml.Controls.Viewbox), [Border](xref:Windows.UI.Xaml.Controls.Border), or [ScrollViewer](xref:Windows.UI.Xaml.Controls.ScrollViewer). If you ungroup elements in one of these layout containers, only the [Viewbox](xref:Windows.UI.Xaml.Controls.Viewbox), [Border](xref:Windows.UI.Xaml.Controls.Border), or [ScrollViewer](xref:Windows.UI.Xaml.Controls.ScrollViewer) is deleted, and the [Grid](xref:Windows.UI.Xaml.Controls.Grid) panel remains. To delete the `Grid` panel, ungroup the elements again.

To ungroup elements and delete the layout, right-click the group that you want to ungroup and click **Ungroup**. You can also group or ungroup elements by right-clicking selected items in the Document Outline window and clicking **Group Into** or **Ungroup**.

## Reset the element layout

You can restore default values for specific layout properties of an element by using the Layout Reset commands. By using this command, you can reset the margin, alignment, width, height, and size of an element, either individually or collectively.

To reset the element layout, right-click the element in the Document Outline window or the artboard, and then choose **Layout** > **Reset** *PropertyName*, where *PropertyName* is the property that you want to reset (or choose **Layout** > **Reset All** to reset all the layout properties for the element).

## Related content

- [Create a UI by using XAML Designer](../xaml-tools/creating-a-ui-by-using-xaml-designer-in-visual-studio.md)
