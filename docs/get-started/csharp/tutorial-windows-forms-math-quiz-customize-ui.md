---
title: "Tutorial: Customize a Windows Forms app"
description: Customize a math quiz Windows Forms application and add event handlers to clear answer values in the Visual Studio integrated development environment (IDE).
ms.custom: vs-acquisition
dev_langs:
  - "CSharp"
  - "VB"
ms.date: 04/20/2023
ms.topic: tutorial
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Tutorial: Customize a math quiz WinForms app

In this series of four tutorials, you'll build a math quiz. The quiz contains four random math problems that a quiz taker tries to answer within a specified time.

This tutorial shows you how to enhance your quiz by clearing default values and by customizing the appearance of controls.

In this final tutorial, you learn how to:

> [!div class="checklist"]
> - Add event handlers to clear the default NumericUpDown control values.
> - Customize the quiz.

## Prerequisites

This tutorial builds on previous tutorials, starting with [Create a math quiz WinForms app](tutorial-windows-forms-math-quiz-create-project-add-controls.md). If you haven't completed those tutorials, go through them first.

## Add event handlers for the NumericUpDown controls

The quiz contains <xref:System.Windows.Forms.NumericUpDown> controls that quiz takers use to enter numbers. When you enter an answer, you either need to select the default value first or delete that value manually. By adding an <xref:System.Windows.Forms.Control.Enter> event handler, you can make it easier to enter answers. This code selects and clears the current value in each NumericUpDown control as soon as the quiz taker selects it and starts to enter a different value.

1. Select the first NumericUpDown control on the form. In the **Properties** dialog box, select the **Events** icon on the toolbar.

   :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/toolbar-events-icon.png" alt-text="Screenshot that shows the toolbar of the Properties dialog box. An icon that contains a lightning bolt is called out.":::

   The **Events** tab in **Properties** displays all the events that you can respond to for the item that you selected on the form. In this case, all the listed events pertain to the NumericUpDown control.

1. Select the **Enter** event, enter **answer_Enter**, and then select **Enter**.

   :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/enter-event.png" alt-text="Screenshot that shows the Properties dialog box with the Enter event selected. The method box contains answer_Enter.":::

   The code editor appears and displays the Enter event handler that you created for the **sum** NumericUpDown control.

1. In the method for the **answer_Enter** event handler, add the following code:

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step5_6/cs/form1.cs" id="Snippet11":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step5_6/vb/form1.vb" id="Snippet11":::
   ---

   In this code:

   - The first line declares the method. It includes a parameter that's named `sender`. In C#, the parameter is `object sender`. In Visual Basic, it's `sender As System.Object`. This parameter refers to the object whose event is firing, which is known as the sender. In this case, the sender object is the NumericUpDown control. 
   - The first line inside the method casts, or converts, the sender from a generic object to a NumericUpDown control. That line also assigns the name **answerBox** to the NumericUpDown control. All the NumericUpDown controls on the form will use this method, not just the addition problem's control.
   - The next line verifies whether **answerBox** was successfully cast as a NumericUpDown control.
   - The first line inside the `if` statement determines the length of the answer that's currently in the NumericUpDown control.
   - The second line inside the `if` statement uses the answer length to select the current value in the control.

   When the quiz taker selects the control, Visual Studio fires this event. This code selects the current answer. As soon as the quiz taker starts to enter a different answer, the current answer is cleared and replaced with the new answer.

1. In **Windows Forms Designer**, select the addition problem's NumericUpDown control again.

1. In the **Events** page of the **Properties** dialog box, find the **Click** event, and then select **answer_Enter** from the drop-down menu. This event handler is the one that you just added.

1. In **Windows Forms Designer**, select the subtraction problem's NumericUpDown control.

1. In the **Events** page of the **Properties** dialog box, find the **Enter** event, and then select **answer_Enter** from the drop-down menu. This event handler is the one that you just added. Repeat this step for the **Click** event.

1. Repeat the previous two steps for the multiplication and division NumericUpDown controls.

## Run your app

1. Save your program and run it.

1. Start a quiz, and select a NumericUpDown control. The existing value is automatically selected and then cleared when you start to enter a different value.

   :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/existing-value-selected.png" alt-text="Screenshot that shows the quiz app with four random math problems. The default answer to the first problem is selected.":::

## Customize your quiz

In this last part of the tutorial, you'll explore some ways to customize the quiz and expand on what you've learned.

### Change the color of a label

- Use the **BackColor** property of the **timeLabel** control to turn this label red when only five seconds remain in a quiz.

  ### [C#](#tab/csharp)
  ```csharp
  timeLabel.BackColor = Color.Red;
  ```

  ### [VB](#tab/vb)
  ```vb
  timeLabel.BackColor = Color.Red
  ```
  ---

- Reset the color when the quiz is over.

### Play a sound for a correct answer

Give the quiz taker a hint by playing a sound when the correct answer is entered into a <xref:System.Windows.Forms.NumericUpDown> control. To implement this functionality, write an event handler for each control's <xref:System.Windows.Forms.NumericUpDown.ValueChanged> event. This type of event fires whenever a quiz taker changes the control's value.

## Next steps

Congratulations! You've finished this series of tutorials. You've completed these programming and design tasks in the Visual Studio IDE:

- Created a Visual Studio project that uses Windows Forms
- Added labels, a button, and NumericUpDown controls
- Added a timer
- Set up event handlers for your controls
- Written C# or Visual Basic code to handle the events

Continue learning with another tutorial series on how to build a matching game.
> [!div class="nextstepaction"]
> [Tutorial 3: Create a matching game](tutorial-windows-forms-create-match-game.md)