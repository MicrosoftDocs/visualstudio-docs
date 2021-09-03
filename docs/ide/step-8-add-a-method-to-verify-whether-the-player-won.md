---
title: "Step 8: Add a method to verify whether the player won"
description: Learn how to add a method to determine if the player won.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: tutorial
dev_langs: 
  - "CSharp"
  - "VB"
ms.assetid: 6e317f6e-ba4c-4306-8924-300b0c2f65c6
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
  - "multiple"
---
# Step 8: Add a method to verify whether the player won
You've created a fun game, but it needs an additional item to finish it. The game should end when the player wins, so you need to add a `CheckForWinner()` method to verify whether the player won.

## To add a method to verify whether the player won

1. Add a `CheckForWinner()` method to the bottom of your code, below the `timer1_Tick()` event handler, as shown in the following code.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial4step8/cs/form1.cs" id="Snippet10":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial4step8/vb/form1.vb" id="Snippet10":::

      > [!IMPORTANT]
      > Use the programming language control at the top right of this page to view either the C# code snippet or the Visual Basic code snippet.<br><br>![Programming language control for Docs.Microsoft.com](../ide/media/docs-programming-language-control.png)     

     The method uses another `foreach` loop in C# or `For Each` loop in Visual Basic to go through each label in the <xref:System.Windows.Forms.TableLayoutPanel>. It uses the equality operator (`==` in C# and `=` in Visual Basic) to check each label's icon color to verify whether it matches the background. If the colors match, the icon remains invisible, and the player hasn't matched all of the icons remaining. In that case, the program uses a `return` statement to skip the rest of the method. If the loop gets through all of the labels without executing the `return` statement, that means that all of the icons on the form were matched. The program shows a MessageBox to congratulate the player on winning, and then calls the form's `Close()` method to end the game.

2. Next, have the label's <xref:System.Windows.Forms.Control.Click> event handler call the new `CheckForWinner()` method. Be sure that your program checks for a winner immediately after it shows the second icon that the player chooses. Look for the line where you set the second chosen icon's color, and then call the `CheckForWinner()` method right after that, as shown in the following code.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial4step8/cs/form1.cs" id="Snippet11":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial4step8/vb/form1.vb" id="Snippet11":::

3. Save and run the program. Play the game and match all of the icons. When you win, the program displays a congratulatory **MessageBox** (as shown in the following screenshot), and then closes the box.

     ![Matching game with MessageBox](../ide/media/express_tut4step8.png)<br/>
***Matching game*** *with* ***MessageBox***

## To continue or review

- To go to the next tutorial step, see **[Step 9: Try other features](../ide/step-9-try-other-features.md)**.

- To return to the previous tutorial step, see [Step 7: Keep pairs visible](../ide/step-7-keep-pairs-visible.md).
