---
title: "Tutorial: Create a 'math quiz' Windows Forms App"
description: Create a C# or Visual Basic Windows Forms project for a math quiz application and use Visual Studio to add UI controls to a form.
ms.custom: vs-acquisition
ms.date: 06/18/2024
ms.topic: tutorial
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
# customer intent: As a developer, I want to learn how a Windows form project works in Visual Studio so that I can create such projects in the future.
---
# Tutorial: Create a math quiz WinForms app

In this series of four tutorials, you build a math quiz. The quiz contains four random math problems that a quiz taker tries to answer within a specified time.

The Visual Studio integrated development environment (IDE) provides the tools that you need to create the app. To learn more about this IDE, see [Welcome to the Visual Studio IDE](../visual-studio-ide.md).

In this first tutorial, you learn how to:

> [!div class="checklist"]
> - Create a Visual Studio project that uses Windows Forms.
> - Add labels, a button, and other controls to a form.
> - Set properties for the controls.
> - Save and run your project.

## Prerequisites

You need Visual Studio to complete this tutorial. Visit the [Visual Studio downloads page](https://visualstudio.microsoft.com/vs/) for a free version.

> [!NOTE]
> This tutorial requires the **Windows Forms App (.NET Framework)** project template. During installation, select the **.NET desktop development** workload:
>
> :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/install-dot-net-desktop-env.png" alt-text="Screenshot that shows the dot NET desktop development workload in Visual Studio Installer.":::
>
> If you already have Visual Studio installed and need to add it, from the menu, select **Tools** > **Get Tools and Features**, or in the **Create a new project** window, select the **Install more tools and features** link.
>
> :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/install-more-tools.png" alt-text="Screenshot that shows the Install more tools and features link from the Not finding what you're looking for message in the Create new project dialog box.":::

## Create your Windows Forms project

When you create a math quiz, the first step is to create a Windows Forms App project.

::: moniker range="vs-2019"

1. Open Visual Studio.

1. On the start window, select **Create a new project**.

   :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/create-new-project-dark-theme-2019.png" alt-text="Screenshot that shows the Create a new project option in the Visual Studio start window.":::

1. In the **Create a new project** window, search for **Windows Forms**. Then select **Desktop** from the **Project type** list.

1. Select the **Windows Forms App (.NET Framework)** template for either C# or Visual Basic, and then select **Next**.

   :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/create-project-windows-forms.png" alt-text="Screenshot that shows the Create a new project dialog box with the search box, the Project type list, and two templates called out.":::

1. In the **Configure your new project** window, name your project **MathQuiz**, and then select **Create**.

::: moniker-end

::: moniker range=">=vs-2022"

1. Open Visual Studio.

1. On the start window, select **Create a new project**.

   :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/create-new-project-dark-theme.png" alt-text="Screenshot that shows the Create a new project option in the Visual Studio start window.":::

1. In the **Create a new project** window, search for **Windows Forms**. Then select **Desktop** from the **Project type** list.

1. Select the **Windows Forms App (.NET Framework)** template for either C# or Visual Basic, and then select **Next**.

   :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/create-project-windows-forms.png" alt-text="Screenshot that shows the Create a new project dialog box with the search box, the Project type list, and two templates called out.":::

1. In the **Configure your new project** window, name your project **MathQuiz**, and then select **Create**.

::: moniker-end

Visual Studio creates a solution for your app. A solution is a container for all the projects and files that your app needs.

## Set form properties

After you select your template and name your file, Visual Studio opens a form for you. This section shows you how to change some form properties.

1. In your project, select **Windows Forms Designer**. The designer tab is labeled **Form1.cs [Design]** for C# or **Form1.vb [Design]** for Visual Basic.

1. Select the form, **Form1**.

1. The **Properties** window now displays properties for the form. This window is usually in the lower right corner of Visual Studio. If you don't see **Properties**, select **View** > **Properties Window**.

1. Find the **Text** property in the **Properties** window. Depending on how the list is sorted, you might need to scroll down. Enter the value *Math Quiz* for the **Text** value, and then select **Enter**.

   Your form now has the text "Math Quiz" in its title bar.

   > [!NOTE]
   > You can display properties by category or alphabetically.
   > Use the buttons on the **Properties** window to switch back and forth.

1. Change the size of the form to 500 pixels wide by 400 pixels tall.

   You can resize the form by dragging its edges or drag handle until the correct size appears as the **Size** value in the **Properties** window. The drag handle is a small white square in the lower-right corner of the form. You can also resize the form by changing the values of the **Size** property.

1. Change the value of the **FormBorderStyle** property to **Fixed3D**, and set the **MaximizeBox** property to **False**.

     These values prevent quiz takers from resizing the form.

## Create the time remaining box

The math quiz contains a box in the upper-right corner. That box shows the number of seconds that remain in the quiz. This section shows you how to use a label for that box. You add code for the countdown timer in a later tutorial in this series.

1. On the left side of the Visual Studio IDE, select the **Toolbox** tab. If you don't see the toolbox, select **View** > **Toolbox** from the menu bar or **Ctrl**+**Alt**+**X**.

1. Select the <xref:System.Windows.Forms.Label> control in the **Toolbox**, and then drag it onto the form.

1. In the **Properties** box, set the following properties for the label:

   - Set the **(Name)** to *timeLabel*.
   - Change **AutoSize** to **False** so that you can resize the box.
   - Change the **BorderStyle** to **FixedSingle** to draw a line around the box.
   - Set the **Size** to *200, 30*.
   - Select the **Text** property, and then select the **Backspace** key to clear the **Text** value.
   - Select the plus sign (**+**) next to the **Font** property, and then set the **Size** to *15.75*.

1. Move the label to the upper-right corner of the form. When blue spacer lines appear, use them to position the control on the form.

1. Add another **Label** control from the **Toolbox**, and then set its font size to *15.75*.

1. Set this label's **Text** property to *Time Left*.

1. Move the label so that it lines up to the left of the **timeLabel** label.

   :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/time-remaining-box.png" alt-text="Screenshot that shows the Time Left and remaining time label with controls lined up next to each other in the upper-right corner of the form.":::

<!-- Original material -->

## Add controls for the addition problem

The first part of the quiz is an addition problem. This section shows you how to use labels to display that problem.

1. Add a **Label** control from the **Toolbox** to the form.

1. In the **Properties** box, set the following properties for the label:

   - Set the **Text** to *?* (question mark).
   - Set **AutoSize** to **False**.
   - Set the **Size** to *60, 50*.
   - Set the font size to *18*.
   - Set **TextAlign** to **MiddleCenter**.
   - Set the **Location** to *50, 75* to position the control on the form.
   - Set the **(Name)** to *plusLeftLabel*.

1. In the form, select the **plusLeftLabel** label that you created. Copy the label by selecting either **Edit** > **Copy** or **Ctrl**+**C**.

1. Paste the label into the form three times by selecting either **Edit** > **Paste** or **Ctrl**+**V** three times.

1. Arrange the three new labels so that they are in a row to the right of the **plusLeftLabel** label.

1. Set the second label's **Text** property to *+* (plus sign).

1. Set the third label's **(Name)** property to *plusRightLabel*.

1. Set the fourth label's **Text** property to *=* (equals sign).

1. Add a <xref:System.Windows.Forms.NumericUpDown> control from the **Toolbox** to the form. You learn more about this kind of control later.

1. In the **Properties** box, set the following properties for the **NumericUpDown** control:

   - Set the font size to *18*.
   - Under **MaximumSize**, set the width to *100*.
   - Set the **(Name)** to *sum*.

1. Line up the **NumericUpDown** control with the **Label** controls for the addition problem.

   :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/addition-problem.png" alt-text="Screenshot that shows the first row of the math quiz, with labels visible and a control with arrow keys that displays a zero.":::

## Add controls for the subtraction, multiplication, and division problems

Next, add labels to the form for the remaining math problems.

1. Copy the four **Label** controls and the **NumericUpDown** control that you created for the addition problem. Paste them into the form.

1. Move the new controls to line up below the addition controls.

1. In the **Properties** box, set the following properties for the new controls:

   - Set the **(Name)** of the first question-mark label to *minusLeftLabel*.
   - Set the **Text** of the second label to *-* (minus sign).
   - Set the **(Name)** of the second question-mark label to *minusRightLabel*.
   - Set the **(Name)** of the **NumericUpDown** control to *difference*.

1. Copy the addition controls, and paste them two more times into the form.

1. For the third row:

   - Set the **(Name)** of the first question-mark label to *timesLeftLabel*.
   - Set the **Text** of the second label to *×* (multiplication sign). You can copy the multiplication sign from this tutorial and paste it onto the form.
   - Set the **(Name)** of the second question-mark label to *timesRightLabel*.
   - Set the **(Name)** of the **NumericUpDown** control to *product*.

1. For the fourth row:

   - Set the **(Name)** of the first question-mark label to *dividedLeftLabel*.
   - Set the **Text** of the second label to *÷* (division sign). You can copy the division sign from this tutorial and paste it onto the form.
   - Set the **(Name)** of the second question-mark label to *dividedRightLabel*.
   - Set the **(Name)** of the **NumericUpDown** control to *quotient*.

:::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/all-math-problems.png" alt-text="Screenshot that shows a math quiz with four rows of problems, with labels and controls with arrow keys visible.":::

## Add a start button and set the tab-index order

This section shows you how to add a start button. You also specify the tabbing order of the controls. This ordering determines how the quiz taker moves from one control to the next by using the **Tab** key.

1. Add a <xref:System.Windows.Forms.Button> control from the **Toolbox** to the form.

1. In the **Properties** box, set the following properties of the button:

   - Set the **(Name)** to *startButton*.
   - Set the **Text** to *Start the quiz*.
   - Set the font size to *14*.
   - Set **AutoSize** to **True**, which causes the button to automatically resize to fit the text.
   - Set the **TabIndex** to *0*. This value makes the start button the first control to receive the focus.

1. Center the button near the bottom of the form.

   :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/math-problems-start-button.png" alt-text="Screenshot that shows a math quiz with four rows of problems and a start button.":::

1. In the **Properties** box, set the **TabIndex** property of each **NumericUpDown** control:

   - Set the **TabIndex** of the **sum** control to *1*.
   - Set the **TabIndex** of the **difference** control to *2*.
   - Set the **TabIndex** of the **product** control to *3*.
   - Set the **TabIndex** of the **quotient** control to *4*.

## Run your app

The math problems don't work yet on your quiz. But you can still run your app to check whether the **TabIndex** values function as you expect.

1. Use one of the following methods to save your app:

   - Select **Ctrl**+**Shift**+**S**.
   - On the menu bar, select **File** > **Save All**.
   - On the toolbar, select the **Save All** button.

1. Use one of the following methods to run your app:

   - Select **F5**.
   - On the menu bar, select **Debug** > **Start Debugging**.
   - On the toolbar, select the **Start** button.

1. Select the **Tab** key a few times to see how the focus moves from one control to the next.

## Next step

Advance to the next tutorial to add random math problems and an event handler to your math quiz.
> [!div class="nextstepaction"]
> [Tutorial part 2: Add math problems to a math quiz WinForms app](tutorial-windows-forms-math-quiz-add-math-problems.md)