---
title: "Step 7: Keep Pairs Visible | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: 42e1d08c-7b2e-4efd-9f47-85d6206afe35
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: jillfra
---
# Step 7: Keep Pairs Visible
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The game works well, as long as the player only chooses pairs of icons that don't match. But consider what should happen when the player chooses a matching pair. Instead of making the icons disappear by turning on the timer (using the `Start()` method), the game should reset itself so that it's no longer keeping track of any labels using the `firstClicked` and `secondClicked` reference variables, without resetting the colors for the two labels that were chosen.

### To keep pairs visible

1. Add the following `if` statement to the `label_Click()` event handler method, near the end of the code just above the statement where you start the timer. Take a close look at the code while adding it to the program. Consider how the code works.

     [!code-csharp[VbExpressTutorial4Step7#9](../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial4step7/cs/form1.cs#9)]
     [!code-vb[VbExpressTutorial4Step7#9](../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial4step7/vb/form1.vb#9)]

     The first line of the `if` statement you just added checks whether the icon in the first label that the player chooses is the same as the icon in the second label. If the icons are identical, the program executes the three statements between the curly braces in C# or the three statements within the `if` statement in Visual Basic. The first two statements reset the `firstClicked` and `secondClicked` reference variables so that they no longer keep track of any of the labels. (You may recognize those two statements from the timer's Tick event handler.) The third statement is a `return` statement, which tells the program to skip the rest of the statements in the method without executing them.

     If programming in Visual C#, you may have noticed that some of the code uses a single equal sign (`=`), while other statements use two equal signs (`==`). Consider why `=` is used in some places but `==` is used in other places.

     This is a good example that shows the difference. Take a careful look at the code between the parentheses in the `if` statement.

    ```vb
    firstClicked.Text = secondClicked.Text
    ```

    ```csharp
    firstClicked.Text == secondClicked.Text
    ```

     Then look closely at the first statement in the block of code after the `if` statement.

    ```vb
    firstClicked = Nothing
    ```

    ```csharp
    firstClicked = null;
    ```

     The first of those two statements checks whether two icons are the same. Because two values are being compared, the Visual C# program uses the `==` equality operator. The second statement actually changes the value (called *assignment*), setting the `firstClicked` reference variable equal to `null` to reset it. That's why it uses the `=` assignment operator instead. Visual C# uses `=` to set values, and `==` to compare them. Visual Basic uses `=` for both variable assignment and comparison.

2. Save and run the program, and then start choosing icons on the form. If you choose a pair that doesn't match, the timer's Tick event triggers, and both icons disappear. If you choose a matching pair, the new `if` statement executes, and the return statement causes the method to skip the code that starts the timer, so the icons stay visible, as shown in the following picture.

     ![Game that you create in this tutorial](../ide/media/express-finishedgame.png "Express_FinishedGame")
Matching game with visible icon pairs

### To continue or review

- To go to the next tutorial step, see [Step 8: Add a Method to Verify Whether the Player Won](../ide/step-8-add-a-method-to-verify-whether-the-player-won.md).

- To return to the previous tutorial step, see [Step 6: Add a Timer](../ide/step-6-add-a-timer.md).
