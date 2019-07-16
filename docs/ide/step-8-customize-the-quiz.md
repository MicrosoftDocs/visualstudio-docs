---
title: "Step 8: Customize the quiz"
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: dc8edb13-1b23-47d7-b859-8c6f7888c1a9
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
---
# Step 8: Customize the quiz
In the last part of the tutorial, you'll explore some ways to customize the quiz and expand on what you've already learned. For example, think about how the program creates random division problems for which the answer is never a fraction. To learn more, turn the `timeLabel` control a different color, and give the quiz taker a hint.

## To customize the quiz

- When only five seconds remain in a quiz, turn the **timeLabel** control red by setting its **BackColor** property (`timeLabel.BackColor = Color.Red;`). Reset the color when the quiz is over.

- Give the quiz taker a hint by playing a sound when the correct answer is entered into a <xref:System.Windows.Forms.NumericUpDown> control. (You must write an event handler for each control's <xref:System.Windows.Forms.NumericUpDown.ValueChanged> event, which fires whenever the quiz taker changes the control's value.)

## To continue or review

- To download a completed version of the quiz, see [Complete math quiz tutorial sample](https://code.msdn.microsoft.com/Complete-Math-Quiz-8581813c).

- To go to the next tutorial, see [Tutorial 3: Create a matching game](../ide/tutorial-3-create-a-matching-game.md).

- To return to the previous tutorial step, see [Step 7: Add multiplication and division problems](../ide/step-7-add-multiplication-and-division-problems.md).
