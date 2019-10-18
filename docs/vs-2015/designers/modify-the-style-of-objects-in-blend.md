---
title: "Modify the style of objects in Blend | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
ms.assetid: 31192d2c-5b84-41bc-94c0-898638c170bd
caps.latest.revision: 14
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Modify the style of objects in Blend
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The easiest way to customize an object is to set properties in the **Properties** pane.  
  
 If you want re-use settings or groups of settings, create a re-usable resource. This could be a *style*, *template*, or something simple like a custom color. You can also make a control appear differently based on its state. For example, a button turns green when the user clicks it.  
  
 **In this topic**:  
  
- [Brushes: Modify the appearance of an object](#Brushes)  
  
- [Styles and Templates: Create a consistent look and feel across controls](#Styles)  
  
- [Visual States: Change the appearance of a control based on its state](#Visual)  
  
- [Resources: Create colors, styles, and templates and reuse them later](#Resources)  
  
## <a name="Brushes"></a> Brushes: Modify the appearance of an object  
 Apply a brush to an object if you want to change its appearance.  
  
 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Brushes Editor](http://www.popscreen.com/v/6A4mO/Microsoft-Expression-Blend-The-Brushes-Editor).  
  
### Paint a repeating image or pattern on an object  
 Paint a repeating image or pattern on an object by using a *tile brush*.  
  
 To create a tile brush, you begin by creating an *image brush*, *drawing brush*, or *visual brush* resource.  
  
 Create an image brush by using an image. The following illustrations show the image brush, the image brush tiled, and the image brush flipped.  
  
 ![](../designers/media/81f84f56-906d-456b-8288-d77da1e01e31.png "81f84f56-906d-456b-8288-d77da1e01e31") ![](../designers/media/d3782ca8-64da-47a4-a095-c6cdd0fa47a2.png "d3782ca8-64da-47a4-a095-c6cdd0fa47a2") ![](../designers/media/38ae3691-f3f1-4a1e-82ca-c7fa164bf56e.png "38ae3691-f3f1-4a1e-82ca-c7fa164bf56e")  
  
 Create a drawing brush by using a vector drawing such as a path or shape. The following illustrations show the drawing brush, the drawing brush tiled, and the drawing brush flipped.  
  
 ![](../designers/media/197666ac-ef57-4c5c-9779-669e991a00a5.png "197666ac-ef57-4c5c-9779-669e991a00a5") ![](../designers/media/ba09cda3-4cee-40ba-b3d4-edc032158bdc.png "ba09cda3-4cee-40ba-b3d4-edc032158bdc") ![](../designers/media/15bf6021-620c-4490-9eae-086153d3f14f.png "15bf6021-620c-4490-9eae-086153d3f14f")  
  
 Create a visual brush from a control such as a button. The following illustrations show the visual brush, and the visual brush tiled.  
  
 ![](../designers/media/fb6c90e0-153c-48fe-b563-e601beac6227.png "fb6c90e0-153c-48fe-b563-e601beac6227") ![](../designers/media/e261b99f-7d8f-4d91-bc84-19c7beccc255.png "e261b99f-7d8f-4d91-bc84-19c7beccc255")  
  
 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Tile Brushes](http://www.popscreen.com/v/6A4iM/Microsoft-Expression-Blend-Tile-Brushes).  
  
## <a name="Styles"></a> Styles and Templates: Create a consistent look and feel across controls  
 You can design the appearance and behavior of a control one time and apply that design to other controls so that you don’t have to maintain them individually.  
  
 **Should you use a style?**: If you just want to set default properties (such as the color of a button), use a *style*. You can modify a control even after you’ve applied a style to it.  
  
 **Should you use a template?**: If you want to change the structure of a control, use a *template*. Imagine converting a graphic or logo to a button. You can’t modify a control after you’ve applied a template to it.  
  
### Create a template or style  
 There’s two ways to create a template. You can convert any object on your artboard to a control or you can base your template on an existing control.  
  
 To convert any object to a control template, select the object, and then on the **Tools** menu, choose **Make Into Control**.  
  
 If you want to base your template on an existing control, select an object on the artboard. Then, at the top of the artboard, choose the breadcrumb button, choose **Edit Template**, and then choose **Edit a Copy** or **Create Empty**.  
  
 ![](../designers/media/5ebdb33f-aad2-4c10-a328-5e8b04c56a36.png "5ebdb33f-aad2-4c10-a328-5e8b04c56a36")  
  
 To create a style, select the object, and then in the **Object** menu, choose **Edit Style**, and then choose **Edit a Copy** or **Create Empty**.  
  
- Choose **Edit a Copy** to start with the default style or template of the control.  
  
- Choose **Create Empty** to start from scratch.  
  
  The **Edit Current** option appears only if you edit a style or template that you’ve already created. It won’t appear for a control that is still using a default system template.  
  
  In the **Create Style Resource** dialog box, you can either name the style or template so that you can use it later, or you can apply the style or template to all controls of that type.  
  
  ![](../designers/media/4818ee6a-ce60-4b79-91c8-3b1871829eea.png "4818ee6a-ce60-4b79-91c8-3b1871829eea")  
  
> [!NOTE]
> You can’t create styles or templates for every type of control. If a control doesn’t support them, the breadcrumb button won’t appear above the artboard.  
>   
> To return to the editing scope of your main document, click **Return scope to** ![](../designers/media/55844eb3-ed98-4f20-aa66-a6f5b23eeb2b.png "55844eb3-ed98-4f20-aa66-a6f5b23eeb2b").  
>   
> ![](../designers/media/4a5612e1-7a28-4587-b870-0fe7112ec2ad.png "4a5612e1-7a28-4587-b870-0fe7112ec2ad")  
  
 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Create a style](https://www.youtube.com/watch?v=W8YdXDPeKdc).  
  
### Apply a style or template to a control  
 Right-click an object in the [Objects and Timeline](https://msdn.microsoft.com/135a5a5e-ec6d-4f38-8827-60e284cd5f57) panel, choose **Edit Template**, and then choose **Apply Resource**.  
  
 ![](../designers/media/dc12debc-7711-47d9-84ce-10322a384397.png "dc12debc-7711-47d9-84ce-10322a384397")  
  
### Restore the default style or template of a control  
 Select the control, and in the [Properties](https://msdn.microsoft.com/135a5a5e-ec6d-4f38-8827-60e284cd5f57) panel, locate the **Style** or **Template** property. Then, click **Advanced options** ![](../designers/media/12e06962-5d8a-480d-a837-e06b84c545bb.png "12e06962-5d8a-480d-a837-e06b84c545bb"), and then click **Reset** on the shortcut menu.  
  
## <a name="Visual"></a> Visual States: Change the appearance of a control based on its state  
 Controls can have different visual appearances based on user interactions. For example, you can make a button turn green when a user clicks it or you could run an animation. You shorten or lengthen the time between visual states by using transitions.  
  
 ![](../designers/media/a95c671a-5639-40b9-83db-1e6b214330d5.png "a95c671a-5639-40b9-83db-1e6b214330d5")  
  
 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Manage the state of your WPF controls](https://www.youtube.com/watch?v=m0PlkF5i6uw).  
  
## <a name="Resources"></a> Resources: Create colors, styles, and templates and reuse them later  
 You can convert just about anything in your project to a resource. A resource is just an object that you can reuse in different places in your application. For example, you can create a color one time, make it a resource, and then use that color on several objects. To change the color of all of those objects, just change the color resource.  
  
 ![](../designers/media/89203705-cf66-46e0-b153-52a23cd744f7.png "89203705-cf66-46e0-b153-52a23cd744f7") ![](../designers/media/6bff8b19-3cd5-41a0-bbf9-ff65532d5aae.png "6bff8b19-3cd5-41a0-bbf9-ff65532d5aae")  
  
 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [A brief touch on resources](http://www.popscreen.com/v/6A4k7/Microsoft-Expression-Blend-Brief-Touch-on-Resources).  
  
## See also  
 [Creating a UI by using Blend for Visual Studio](../designers/creating-a-ui-by-using-blend-for-visual-studio.md)
