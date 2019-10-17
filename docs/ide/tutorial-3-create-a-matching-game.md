---
title: "Tutorial 3: Create a matching game"
ms.date: 10/16/2019
ms.assetid: 525815c8-2845-45e8-be96-100d1f144725
ms.topic: tutorial
ms.technology: vs-ide-general
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
---
# Tutorial 3: Create a matching game

In this tutorial, you build a matching game, where the player must match pairs of hidden icons.

> [!NOTE]
> This tutorial covers both C# and Visual Basic, so focus on the information that's specific to the programming language that you're using.

This tutorial walks you through the following tasks:

- Store objects, such as icons, in a <xref:System.Collections.Generic.List%601> object.

- Use a `foreach` loop in C# or a `For Each` loop in Visual Basic to iterate through items in a list.

- Keep track of a form's state by using reference variables.

- Build an event handler to respond to events that you can use with multiple objects.

- Make a timer that counts down and then fires an event exactly once after being started.

When you finish, your app should look similar to the following image:

![Game that you create in this tutorial](../ide/media/express_finishedgame.png)

## Tutorial links

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

There are also great, free video learning resources available to you. To learn more about programming in C#, see [C# fundamentals: Development for absolute beginners](https://channel9.msdn.com/Series/C-Sharp-Fundamentals-Development-for-Absolute-Beginners). To learn more about programming in Visual Basic, see [Visual Basic fundamentals: Development for absolute beginners](https://channel9.msdn.com/Series/Visual-Basic-Development-for-Absolute-Beginners).

## Next steps

To begin the tutorial, start with **[Step 1: Create a project and add a table to your form](../ide/step-1-create-a-project-and-add-a-table-to-your-form.md)**.

## See also

* [More C# tutorials](/visualstudio/get-started/csharp/)
* [Visual Basic tutorials](/visualstudio/get-started/visual-basic/)
* [C++ tutorials](/cpp/get-started/tutorial-console-cpp)
