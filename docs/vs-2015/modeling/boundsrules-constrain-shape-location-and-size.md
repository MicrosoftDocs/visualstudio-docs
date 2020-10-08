---
title: "BoundsRules Constrain Shape Location and Size | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "Domain-Specific Language, events"
ms.assetid: 4d08e541-fc67-4e68-bf31-30d346aa2aa0
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: jillfra
---
# BoundsRules Constrain Shape Location and Size
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A *Bounds Rule* is a class that defines limits on the size and location of a shape. It provides a method that is called repeatedly while a user is dragging a shape or the corners or sides of a shape.

 The following example constrains a rectangular shape to be a bar of fixed size, either horizontal or vertical. When the user drags the corners or sides, the outline flips between the two permitted configurations of height and width.

 The bounds rule is a class derived from <xref:Microsoft.VisualStudio.Modeling.Diagrams.BoundsRules>. An instance of the rule is created in the shape:

```
using Microsoft.VisualStudio.Modeling.Diagrams; ...
public partial class BarShape
{
  /// <summary>
  /// Rule invoked when the user is resizing a shape.
  /// </summary>
  public override BoundsRules BoundsRules
  { get { return new BarBoundsRule(); } }
}
/// <summary>
/// Rule invoked when the user is changing a shape's outline.
/// Provides real-time mouse rubber-band feedback, so must work fast.
/// </summary>
public class BarBoundsRule: BoundsRules
{
  public override RectangleD GetCompliantBounds
     (ShapeElement shape, RectangleD proposedBounds)
  {
    double thickness = 0.1;
    if (proposedBounds.Height > proposedBounds.Width)
    {
      // There is a minimum width for a shape; the width
      // will actually be set to the lesser of
      // thickness and that minimum.
      return new RectangleD(proposedBounds.Location,
            new SizeD(thickness, proposedBounds.Height));
    }
    else
    {
      // There is a minimum height for a shape; the
      // height will actually be set to the lesser of
      // thickness and that minimum.
      return new RectangleD(proposedBounds.Location,
         new SizeD(proposedBounds.Width, thickness));
} } }
```

 Notice that both the location and size can be constrained if you want.

## See Also
 <xref:Microsoft.VisualStudio.Modeling.Diagrams.BoundsRules>
 [Responding to and Propagating Changes](../modeling/responding-to-and-propagating-changes.md)
