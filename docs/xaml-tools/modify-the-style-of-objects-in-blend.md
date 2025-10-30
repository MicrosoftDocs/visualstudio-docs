---
title: Modify the style of objects
titleSuffix: Blend for Visual Studio
description: Modify the style of objects in Blend for Visual Studio by applying brushes, setting visual states, and applying reusable styles and templates.
ms.date: 11/04/2016
ms.topic: article
author: maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: xaml-tools
---
# Modify the style of objects in Blend for Visual Studio

The easiest way to customize an object is to set properties in the **Properties** pane.

If you want reuse settings or groups of settings, create a reusable resource. This could be a *style*, *template*, or something simple like a custom color. You can also make a control appear differently based on its state. For example, a button turns green when the user clicks it.

## Brushes: Modify the appearance of an object

Apply a brush to an object if you want to change its appearance.

### Paint a repeating image or pattern on an object

Paint a repeating image or pattern on an object by using a *tile brush*.

To create a tile brush, you begin by creating an *image brush*, *drawing brush*, or *visual brush* resource.

Create an image brush by using an image. The following illustrations show the image brush, the image brush tiled, and the image brush flipped.

![Image brush](../designers/media/81f84f56-906d-456b-8288-d77da1e01e31.png)

![mage brush tiled](../designers/media/d3782ca8-64da-47a4-a095-c6cdd0fa47a2.png)

![Image brush flipped](../designers/media/38ae3691-f3f1-4a1e-82ca-c7fa164bf56e.png)

Create a drawing brush by using a vector drawing such as a path or shape. The following illustrations show the drawing brush, the drawing brush tiled, and the drawing brush flipped.

![Drawing brush](../designers/media/197666ac-ef57-4c5c-9779-669e991a00a5.png)

![Drawing brush tiled](../designers/media/ba09cda3-4cee-40ba-b3d4-edc032158bdc.png)

![Drawing brush flipped](../designers/media/15bf6021-620c-4490-9eae-086153d3f14f.png)

Create a visual brush from a control such as a button. The following illustrations show the visual brush, and the visual brush tiled.

![Visual brush](../designers/media/fb6c90e0-153c-48fe-b563-e601beac6227.png)

![Visual brush tiled](../designers/media/e261b99f-7d8f-4d91-bc84-19c7beccc255.png)

## Styles and templates: Create a consistent look and feel across controls

You can design the appearance and behavior of a control one time and apply that design to other controls so that you don't have to maintain them individually.

**Should you use a style?**: If you just want to set default properties (such as the color of a button), use a *style*. You can modify a control even after you've applied a style to it.

**Should you use a template?**: If you want to change the structure of a control, use a *template*. Imagine converting a graphic or logo to a button. You can't modify a control after you've applied a template to it.

### Create a template or style

There're two ways to create a template. You can convert any object on your artboard to a control or you can base your template on an existing control.

To convert any object to a control template, select the object, and then on the **Tools** menu, choose **Make Into Control**.

If you want to base your template on an existing control, select an object on the artboard. Then, at the top of the artboard, choose the breadcrumb button, choose **Edit Template**, and then choose **Edit a Copy** or **Create Empty**.

![Edit Template menu](../designers/media/5ebdb33f-aad2-4c10-a328-5e8b04c56a36.png)

To create a style, select the object, and then in the **Object** menu, choose **Edit Style**, and then choose **Edit a Copy** or **Create Empty**.

- Choose **Edit a Copy** to start with the default style or template of the control.

- Choose **Create Empty** to start from scratch.

The **Edit Current** option appears only if you edit a style or template that you've already created. It won't appear for a control that is still using a default system template.

In the **Create Style Resource** dialog box, you can either name the style or template so that you can use it later, or you can apply the style or template to all controls of that type.

![Create Style Resource dialog box](../designers/media/4818ee6a-ce60-4b79-91c8-3b1871829eea.png)

> [!NOTE]
> You can't create styles or templates for every type of control. If a control doesn't support them, the breadcrumb button won't appear above the artboard.
> To return to the editing scope of your main document, click **Return scope to** ![Return scope to icon](../designers/media/55844eb3-ed98-4f20-aa66-a6f5b23eeb2b.png).

### Apply a style or template to a control

Right-click an object in the [Objects and Timeline](../xaml-tools/creating-a-ui-by-using-blend-for-visual-studio.md#objects-and-timeline-window) window, choose **Edit Template**, and then choose **Apply Resource**.

![Apply Resource menu](../designers/media/dc12debc-7711-47d9-84ce-10322a384397.png)

### Restore the default style or template of a control

Select the control, and in the **Properties**** window, locate the **Style** or **Template** property. Choose **Advanced options**, and then click **Reset** on the shortcut menu.

## Visual states

Visual states let you change the appearance of a control based on its state. Controls can have different visual appearances based on user interactions. For example, you can make a button turn green when a user clicks it, or you can run an animation. Shorten or lengthen the time between visual states by using transitions.

![Mouse over state](../designers/media/a95c671a-5639-40b9-83db-1e6b214330d5.png)

**Watch a short video:** ![Play button](../designers/media/bldadminconsoleinitialconfigicon.PNG) [Manage the state of your WPF controls](https://www.youtube.com/watch?v=m0PlkF5i6uw).

## Resources: Create colors, styles, and templates and reuse them later

You can convert just about anything in your project to a resource. A resource is just an object that you can reuse in different places in your application. For example, you can create a color one time, make it a resource, and then use that color on several objects. To change the color of all of those objects, just change the color resource.

![Convert color to resource button](../designers/media/89203705-cf66-46e0-b153-52a23cd744f7.png)

![Create Color Resource dialog box](../designers/media/6bff8b19-3cd5-41a0-bbf9-ff65532d5aae.png)

## Related content

- [Creating a UI by using Blend for Visual Studio](../xaml-tools/creating-a-ui-by-using-blend-for-visual-studio.md)
