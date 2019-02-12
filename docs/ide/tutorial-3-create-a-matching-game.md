---
title: "Tutorial 3: Create a matching game"
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: 525815c8-2845-45e8-be96-100d1f144725
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
---
# Tutorial 3: Create a matching game

In this tutorial, you build a matching game, where the player must match pairs of hidden icons. You learn how to:

-   Store objects, such as icons, in a <xref:System.Collections.Generic.List%601> object.

-   Use a `foreach` loop in Visual C# or a `For Each` loop in Visual Basic to iterate through items in a list.

-   Keep track of a form's state by using reference variables.

-   Build an event handler to respond to events that you can use with multiple objects.

-   Make a timer that counts down and then fires an event exactly once after being started.

When you finish this tutorial, your program will look like the following picture:

![Game that you create in this tutorial](../ide/media/express_finishedgame.png)

## Tutorial links

To download a completed version of the sample, see [Complete matching game tutorial sample](https://code.msdn.microsoft.com/Complete-Matching-Game-4cffddba).

> [!NOTE]
> In this tutorial, both Visual C# and Visual Basic are covered, so focus on information specific to the programming language that you're using.

If you get stuck or have programming questions, try posting your question on one of the MSDN forums. See [Visual Basic forum](https://social.msdn.microsoft.com/Forums/vstudio/home?forum=vbgeneral) and [Visual C# forum](https://social.msdn.microsoft.com/Forums/vstudio/home?forum=csharpgeneral). Also, there are great, free video learning resources available to you. To learn more about programming in Visual Basic, see [Visual Basic fundamentals: Development for absolute beginners](https://channel9.msdn.com/Series/Visual-Basic-Development-for-Absolute-Beginners). To learn more about programming in Visual C#, see [C# fundamentals: Development for absolute beginners](https://channel9.msdn.com/Series/C-Sharp-Fundamentals-Development-for-Absolute-Beginners).

## Related topics

|Title|Description|
|-----------|-----------------|
|[Step 1: Create a project and add a table to your form](../ide/step-1-create-a-project-and-add-a-table-to-your-form.md)|Begin by creating the project and adding a `TableLayoutPanel` control to keep the controls aligned properly.|
|[Step 2: Add a random object and a list of icons](../ide/step-2-add-a-random-object-and-a-list-of-icons.md)|Add a `Random` object and a `List` object, to create a list of icons.|
|[Step 3: Assign a random icon to each label](../ide/step-3-assign-a-random-icon-to-each-label.md)|Assign the icons randomly to the `Label` controls, so that each game is different.|
|[Step 4: Add a click event handler to each label](../ide/step-4-add-a-click-event-handler-to-each-label.md)|Add a `Click` event handler that changes the color of the label that is clicked.|
|[Step 5: Add label references](../ide/step-5-add-label-references.md)|Add reference variables to keep track of which labels are clicked.|
|[Step 6: Add a timer](../ide/step-6-add-a-timer.md)|Add a timer to the form to keep track of the time that has passed in the game.|
|[Step 7: Keep pairs visible](../ide/step-7-keep-pairs-visible.md)|Keep pairs of icons visible, if a matching pair is selected.|
|[Step 8: Add a method to verify whether the player won](../ide/step-8-add-a-method-to-verify-whether-the-player-won.md)|Add a `CheckForWinner()` method to verify whether the player won.|
|[Step 9: Try other features](../ide/step-9-try-other-features.md)|Try other features, such as changing icons and colors, adding a grid, and adding sounds. Try making the board bigger and adjusting the timer.|
