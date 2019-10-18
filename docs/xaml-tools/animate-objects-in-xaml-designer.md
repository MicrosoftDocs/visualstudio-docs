---
title: Animate objects in XAML Designer
titleSuffix: Blend for Visual Studio
ms.date: 07/31/2019
ms.topic: conceptual
ms.assetid: fb88fa26-e835-47f5-9771-2f279441c83c
author: jillre
ms.author: jillfra
manager: jillfra
---
# Animate objects in XAML Designer

Blend for Visual Studio lets you easily create short animations that move objects or fade them in and out, for example.

To create an animation, you need a *storyboard*. A storyboard contains one or more *timelines*. Set *keyframes* on a timeline to mark property changes. Then, when you run the animation, Blend for Visual Studio interpolates the property changes over the designated period of time. The result is a smooth transition. You can animate any property that belongs to an object, even nonvisual properties.

The following images shows a storyboard named **Storyboard1**. The timeline contains keyframes that mark the X and Y position of a rectangle. When this animation runs, the rectangle moves from one position to another smoothly.

![Storyboard for animation in Blend for Visual Studio](media/storyboard-timeline.png)

## Create an animation

1. To create a storyboard, select the **Storyboard Options** button in the **Objects and Timeline** window, and then select **New**.

   ![Add a storyboard in Blend for Visual Studio](media/new-storyboard.png)

2. In the **Create Storyboard Resource** dialog box, enter a name for the storyboard.

3. From the **Assets** panel in Design view, add a rectangle to the lower left-hand side of the page.

   ![Rectangle in Assets panel of XAML Designer](media/add-rectangle.PNG)

4. In the **Objects and Timeline** window, move the yellow time pointer to **3** seconds.

   ![Time indicator in timeline](media/timeline-indicator.PNG)

5. In the Design view for the page, drag the rectangle to the right-hand side of the page.

6. Press **Play** to watch the rectangle move from the left-hand side to the right-hand side of the page.

Play around with other changes to the rectangle at different points in time. For example, you can change the fill color or flip the orientation in the Properties window.

## See also

- [Create a UI by using Blend for Visual Studio](../xaml-tools/creating-a-ui-by-using-blend-for-visual-studio.md)