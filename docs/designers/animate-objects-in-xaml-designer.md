---
title: Animate objects in XAML Designer
ms.date: 04/11/2018
ms.topic: conceptual
ms.assetid: fb88fa26-e835-47f5-9771-2f279441c83c
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "uwp"
---
# Animate objects in XAML Designer

You can create short animations that move objects, or fade them in and out.

To get started, create a *storyboard*. A storyboard contains one or more *timelines*. Set *keyframes* on a timeline to mark property changes. Then, when you run the animation, Blend interpolates the property changes over the designated period of time. The result is a smooth transition. You can animate any property that belongs to an object, even nonvisual properties.

The following illustration shows a storyboard named **MoveUp**. The timeline contains keyframes that mark the X and Y position of a rectangle. When this animation runs, the rectangle moves from one position to another smoothly.

![MoveUp storyboard in XAML designer](../designers/media/982f031a-74a3-414a-abc2-a0f41a741075.png)

## See also

- [Create a UI by using Blend for Visual Studio](../designers/creating-a-ui-by-using-blend-for-visual-studio.md)