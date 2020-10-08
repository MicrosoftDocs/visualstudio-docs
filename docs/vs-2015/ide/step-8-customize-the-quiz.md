---
title: "Step 8: Customize the Quiz | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: dc8edb13-1b23-47d7-b859-8c6f7888c1a9
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: jillfra
---
# Step 8: Customize the Quiz
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In the last part of the tutorial, you'll explore some ways to customize the quiz and expand on what you've already learned. For example, think about how the program creates random division problems for which the answer is never a fraction. To learn more, turn the `timeLabel` control a different color, and give the quiz taker a hint.

### To customize the quiz

- When only five seconds remain in a quiz, turn the **timeLabel** control red by setting its **BackColor** property (`timeLabel.BackColor = Color.Red;`). Reset the color when the quiz is over.

- Give the quiz taker a hint by playing a sound when the correct answer is entered into a NumericUpDown control. (You must write an event handler for each control's `ValueChanged()` event, which fires whenever the quiz taker changes the control's value.)

### To continue or review

- To go to the next tutorial, see [Tutorial 3: Create a Matching Game](../ide/tutorial-3-create-a-matching-game.md).

- To return to the previous tutorial step, see [Step 7: Add Multiplication and Division Problems](../ide/step-7-add-multiplication-and-division-problems.md).
