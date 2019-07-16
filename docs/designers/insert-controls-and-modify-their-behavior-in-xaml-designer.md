---
title: Insert controls and modify their behavior in XAML Designer
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: a80fff74-bf01-41c9-ab85-ada7a873c3a9
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "uwp"
---
# Insert controls and modify their behavior in XAML Designer

Controls enable users to interact with your app. You can use them to collect information and to perform actions such as animate an object or query a data source.

## Add controls to the artboard

You can drag controls from the **Assets** panel onto the **artboard**, and then modify them in the **Properties** window.

![Blend Assets tab controls](../designers/media/blend_assetsflipview_xaml.png)

### Make a control out of an image, shape, or path

You can make any object into a control.

![Blend Make Into Control dialog box](../designers/media/blend_makeintocontrol_xaml.png)

For example, imagine a picture of a television in the center of a page. You could make controls out of small images that look like television buttons. Then, users could click those buttons to change the channel.

This is possible because the buttons are now controls. With controls, you can respond to user interactions; in this case, when the user clicks a button.

To make a control, select an object. Then, on the **Tools** menu, click **Make Control**.

## Make controls do things

Controls can perform actions when users interact with them. For example, they can start an animation, update a data source, or play a video.

Use *triggers*, *behaviors*, and *events* to make controls do things.

### Triggers

A *trigger* changes a property or performs a task in response to an event or a change in another property. For example, you can change the color of a button when users hover over it.

![The Triggers panel](../designers/media/custom_button_blend_propertytriggerinfo.png)

### Behaviors

A *behavior* is a reusable package of code. It can do a bit more than change properties. It can perform actions such as query a data service. Blend comes with a small collection of behaviors, but you can add more. Drag a behavior onto any object in your artboard, and then customize the behavior by setting properties.

![FluidMoveBehavior in the Properties panel](../designers/media/b4_fluidmovebehaviorproperties_sample.png)

**Watch a video:** ![Play icon](../designers/media/bldadminconsoleinitialconfigicon.PNG) [Blend tips: Intro to using behaviors Part 1](http://www.bing.com/videos/search?q=Expression%20blend%20behaviors&qs=n&form=QBVR&pq=expression%20blend%20behavior&sc=4-25&sp=-1&sk=#view=detail&mid=CF0DD797ED84DE740904CF0DD797ED84DE740904).

### Events

For ultimate flexibility, handle an *event*. You'll have to write some code.