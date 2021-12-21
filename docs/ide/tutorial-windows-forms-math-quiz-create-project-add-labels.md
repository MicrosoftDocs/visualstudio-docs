---
title: "Tutorial: Create a project and add labels to your form"
description: "In this tutorial, you'll create a C# or VB Windows Forms project for a math quiz application. You'll use the Visual Studio IDE to add labels to a form."
ms.custom: 
- vs-acquisition
- SEO-VS-2020
ms.date: 12/21/2021
ms.topic: tutorial
ms.assetid: f44e50be-a5f5-4d77-9cff-dd52374c3f74
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---

# Tutorial: Create a project and add labels to your form

In this series of four tutorials, you build a math quiz. The quiz taker tries to answer four random math problems within a specified time. The Visual Studio integrated development environment (IDE) provides the tools that you need to create the app. To learn more, see [Welcome to the Visual Studio IDE](../get-started/visual-studio-ide.md).

In this first tutorial, you learn how to:

> [!div class="checklist"]
> - Create a Visual Studio project that uses Windows Forms.
> - Add labels to a form to display the quiz problems.
> - Set properties for the labels.
> - Save and run your project.

## Prerequisites

You need Visual Studio to complete this tutorial. Visit the [Visual Studio downloads page](https://visualstudio.microsoft.com/vs/) for a free version.

## Create your Windows Forms project

When you create a math quiz, the first step is to create a Windows Forms App project.

::: moniker range="vs-2017"

1. Open Visual Studio.

1. On the menu bar, select **File** > **New** > **Project**.

1. On the left side of the **New Project** dialog box, select either **Visual C#** or **Visual Basic**, and then select **Windows Desktop**.

1. In the project templates list, select **Windows Forms App (.NET Framework)**. Name the new form *MathQuiz*, and then select **OK**.

   > [!NOTE]
   > If you don't see the **Windows Forms App (.NET Framework)** template, use Visual Studio Installer to install the **.NET desktop development** workload.
   >
   > :::image type="content" source="./media/tutorial-windows-forms-timed-math-quiz/install-dot-net-desktop-env.png" alt-text="Screenshot that shows the dot NET desktop development workload in Visual Studio Installer.":::
   >
   > For more information, see the [Install Visual Studio](../install/install-visual-studio.md) page.

::: moniker-end

::: moniker range=">=vs-2019"

1. Open Visual Studio.

1. On the start window, select **Create a new project**.

   :::image type="content" source="./media/tutorial-windows-forms-timed-math-quiz/create-new-project-dark-theme.png" alt-text="Screenshot that shows the Create a new project option in the Visual Studio start window.":::

1. On the **Create a new project** window, search for *Windows Forms*. Then select **Desktop** from the **Project type** list.

1. Select the **Windows Forms App (.NET Framework)** template for either C# or Visual Basic, and then select **Next**.

   :::image type="content" source="./media/tutorial-windows-forms-timed-math-quiz/create-project-windows-forms.png" alt-text="Screenshot that shows the Create a new project dialog box. The search box, the Project type list, and two templates are called out.":::

   > [!NOTE]
   > If you don't see the **Windows Forms App (.NET Framework)** template, you can install it from the **Create a new project** window. In the **Not finding what you're looking for?** message, select **Install more tools and features**.
   >
   > :::image type="content" source="./media/tutorial-windows-forms-timed-math-quiz/install-more-tools.png" alt-text="Screenshot that shows the Install more tools and features link from the Not finding what you're looking for message in the Create new project dialog box.":::
   >
   > Next, in Visual Studio Installer, select **.NET desktop development**.
   >
   > :::image type="content" source="./media/tutorial-windows-forms-timed-math-quiz/install-dot-net-desktop-env.png" alt-text="Screenshot that shows the dot NET desktop development workload in Visual Studio Installer.":::
   >
   > Select **Modify** in Visual Studio Installer. You might be prompted to save your work. Next, select **Continue** to install the workload.

1. In the **Configure your new project** window, name your project *MathQuiz*, and then select **Create**.

::: moniker-end

Visual Studio creates a solution for your app. A solution is a container for all the projects and files that your app needs.

<!-- Original material -->

## Set the form properties

After you select your template and name your file, Visual Studio opens a form for you. This section shows you how to change some of your form's properties such as the title, size, and border style.

1. In Visual Studio, choose the form (either *Form1.cs* or *Form1.vb*, depending on the programming language), and then change its **Text** property to **Math Quiz**.

     The **Properties** window contains properties for the form.

1. Change the size of the form to 500 pixels wide by 400 pixels tall.

     You can resize the form by dragging its edges until the correct size appears in the lower-left corner of the integrated development environment (IDE). As an alternative, you can change the values of the **Size** property.

1. Change the value of the **FormBorderStyle** property to **Fixed3D**, and set the **MaximizeBox** property to **False**.

     These values prevent quiz takers from resizing the form.

## To create the time remaining box

1. Add a <xref:System.Windows.Forms.Label> control from the **Toolbox**, and then set the value of its **(Name)** property to **timeLabel**.

     This label will become a box in the upper-right corner that shows the number of seconds that remain in the quiz.

2. Change the **AutoSize** property to **False** so that you can resize the box.

3. Change the **BorderStyle** property to **FixedSingle** to draw a line around the box.

4. Set the **Size** property to **200, 30**.

5. Move the label to the upper-right corner of the form, where blue spacer lines will appear.

     These lines help you align controls on the form.

6. In the **Properties** window, choose the **Text** property, and then choose the **Backspace** key to clear its value.

7. Choose the plus sign (**+**) next to the **Font** property, and then change the value of the **Size** property to **15.75**.

     You can change several font properties, as the following screenshot shows.

     ![Properties window showing font size](../ide/media/express_setfontsize.png)

8. Add another Label control from the **Toolbox**, and then set its font size to **15.75**.

9. Set the **Text** property to **Time Left**.

10. Move the label so that it lines up just to the left of the **timeLabel** label.

### To add controls for the addition problems

1. Add a Label control from the **Toolbox**, and then set its **Text** property to **?** (question mark).

2. Set the **AutoSize** property to **False**.

3. Set the **Size** property to **60, 50**.

4. Set the font size to **18**.

5. Set the **TextAlign** property to **MiddleCenter**.

6. Set the **Location** property to **50, 75** to position the control on the form.

7. Set the **(Name)** property to **plusLeftLabel**.

8. Choose the **plusLeftLabel** label, and then choose either the **Ctrl**+**C** keys or **Copy** on the **Edit** menu.

9. Paste the label three times by choosing either the **Ctrl**+**V** keys or **Paste** on the **Edit** menu.

10. Arrange the three new labels so that they are in a row to the right of the **plusLeftLabel** label.

     You can use the spacer lines to space them out and line them up.

11. Set the value of the second label's **Text** property to **+** (plus sign).

12. Set the value of the third label's **(Name)** property to **plusRightLabel**.

13. Set the value of the fourth label's **Text** property to **=** (equal sign).

14. Add a <xref:System.Windows.Forms.NumericUpDown> control from the **Toolbox**, set its font size to **18**, and set its width to **100**.

     You'll learn more about this kind of control later.

15. Line up the NumericUpDown control with the Label controls for the addition problem.

16. Change the value of the **(Name)** property for the NumericUpDown control to **sum**.

     You've created the first row, as shown in the following illustration.

     ![First row of math quiz](../ide/media/express_firstrow.png)

## To add controls for the subtraction, multiplication, and division problems

1. Copy all five controls for the addition problem (the four Label controls and the NumericUpDown control), and then paste them.

     The form contains five new controls, which are still selected.

2. Move all of the controls into place so that they line up below the addition controls.

     You can use the spacer lines to give enough distance between the two rows.

3. Change the value of the **Text** property for the second label to **-** (minus sign).

4. Name the first question-mark label **minusLeftLabel**.

5. Name the second question-mark label **minusRightLabel**.

6. Name the NumericUpDown control **difference**.

7. Paste the five controls two more times.

8. For the third row, name the first label **timesLeftLabel**, change the second label's **Text** property to **×** (multiplication sign), name the third label **timesRightLabel**, and name the NumericUpDown control **product**.

9. For the fourth row, name the first label **dividedLeftLabel**, change the second label's **Text** property to **÷** (division sign), name the third label **dividedRightLabel**, and name the NumericUpDown control **quotient**.

    > [!NOTE]
    > You can copy the multiplication sign × and the division sign ÷ from this tutorial and paste them onto the form.

## To add a start button and set the tab-index order

1. Add a <xref:System.Windows.Forms.Button> control from the **Toolbox**, and then set its **(Name)** property to **startButton**.

2. Set the **Text** property to **Start the quiz**.

3. Set the font size to **14**.

4. Set the **AutoSize** property to **True**, which causes the button to automatically resize to fit the text.

5. Center the button near the bottom of the form.

6. Set the value of the **TabIndex** property for the **startButton** control to **1**.

    > [!NOTE]
    > The **TabIndex** property sets the order of the controls when the quiz taker chooses the **Tab** key. To see how it works, open any dialog box (for example, on the menu bar, choose **File** > **Open**), and then choose the **Tab** key a few times. Watch how your cursor moves from control to control each time that you choose the **Tab** key. A programmer decided the order when creating that form.

7. Set the value of the **TabIndex** property for the NumericUpDown sum control to **2**, for the difference control to **3**, for the product control to **4**, and for the quotient control to **5**.

     The form should look similar to the following screenshot.

     ![Initial math quiz form](../ide/media/express_formlaidout.png)

8. To verify whether the **TabIndex** property works as you expect, save and run your program by choosing the **F5** key, or by choosing **Debug** > **Start Debugging** on the menu bar, and then choose the **Tab** key a few times.

## To continue or review

- To go to the next tutorial step, see **[Step 2: Create a random addition problem](../ide/step-2-create-a-random-addition-problem.md)**.

- To return to the overview topic, see [Tutorial 2: Create a timed math quiz](../ide/tutorial-2-create-a-timed-math-quiz.md).