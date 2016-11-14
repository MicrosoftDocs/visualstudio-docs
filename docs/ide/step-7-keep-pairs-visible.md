---
title: "Step 7: Keep Pairs Visible | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 42e1d08c-7b2e-4efd-9f47-85d6206afe35
caps.latest.revision: 21
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Step 7: Keep Pairs Visible
The game works well, as long as the player only chooses pairs of icons that don't match. But consider what should happen when the player chooses a matching pair. Instead of making the icons disappear by turning on the timer (using the `Start()` method), the game should reset itself so that it's no longer keeping track of any labels using the `firstClicked` and `secondClicked` reference variables, without resetting the colors for the two labels that were chosen.  
  
### To keep pairs visible  
  
1.  Add the following `if` statement to the `label_Click()` event handler method, near the end of the code just above the statement where you start the timer. Take a close look at the code while adding it to the program. Consider how the code works.  
  
     [!code-cs[VbExpressTutorial4Step7#9](../ide/codesnippet/CSharp/step-7-keep-pairs-visible_1.cs)]
     [!code-vb[VbExpressTutorial4Step7#9](../ide/codesnippet/VisualBasic/step-7-keep-pairs-visible_1.vb)]  
  
     The first line of the `if` statement you just added checks whether the icon in the first label that the player chooses is the same as the icon in the second label. If the icons are identical, the program executes the three statements between the curly braces in C# or the three statements within the `if` statement in Visual Basic. The first two statements reset the `firstClicked` and `secondClicked` reference variables so that they no longer keep track of any of the labels. (You may recognize those two statements from the timer's Tick event handler.) The third statement is a `return` statement, which tells the program to skip the rest of the statements in the method without executing them.  
  
     If programming in Visual C#, you may have noticed that some of the code uses a single equal sign (`=`), while other statements use two equal signs (`==`). Consider why `=` is used in some places but `==` is used in other places.  
  
     This is a good example that shows the difference. Take a careful look at the code between the parentheses in the `if` statement.  
  
    ```vb#  
    firstClicked.Text = secondClicked.Text  
    ```  
  
    ```c#  
    firstClicked.Text == secondClicked.Text  
    ```  
  
     Then look closely at the first statement in the block of code after the `if` statement.  
  
    ```vb#  
    firstClicked = Nothing  
    ```  
  
    ```c#  
    firstClicked = null;  
    ```  
  
     The first of those two statements checks whether two icons are the same. Because two values are being compared, the Visual C# program uses the `==` equality operator. The second statement actually changes the value (called *assignment*), setting the `firstClicked` reference variable equal to `null` to reset it. That's why it uses the `=` assignment operator instead. Visual C# uses `=` to set values, and `==` to compare them. Visual Basic uses `=` for both variable assignment and comparison.  
  
2.  Save and run the program, and then start choosing icons on the form. If you choose a pair that doesn't match, the timer's Tick event triggers, and both icons disappear. If you choose a matching pair, the new `if` statement executes, and the return statement causes the method to skip the code that starts the timer, so the icons stay visible, as shown in the following picture.  
  
     ![Game that you create in this tutorial](../ide/media/express_finishedgame.png "Express_FinishedGame")  
Matching game with visible icon pairs  
  
### To continue or review  
  
-   To go to the next tutorial step, see [Step 8: Add a Method to Verify Whether the Player Won](../ide/step-8-add-a-method-to-verify-whether-the-player-won.md).  
  
-   To return to the previous tutorial step, see [Step 6: Add a Timer](../ide/step-6-add-a-timer.md).