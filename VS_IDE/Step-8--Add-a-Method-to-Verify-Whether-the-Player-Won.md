---
title: "Step 8: Add a Method to Verify Whether the Player Won"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6e317f6e-ba4c-4306-8924-300b0c2f65c6
caps.latest.revision: 17
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Step 8: Add a Method to Verify Whether the Player Won
You've created a fun game, but it needs an additional item to finish it. The game should end when the player wins, so you need to add a `CheckForWinner()` method to verify whether the player won.  
  
### To add a method to verify whether the player won  
  
1.  Add a `CheckForWinner()` method to the bottom of your code, below the `timer1_Tick()` event handler, as shown in the following code.  
  
     [!CODE [VbExpressTutorial4Step8#10](../CodeSnippet/VS_Snippets_VBCSharp/vbexpresstutorial4step8#10)]  
  
     The method uses another `foreach` loop in Visual C# or `For Each` loop in Visual Basic to go through each label in the TableLayoutPanel. It uses the equality operator (`==` in Visual C# and `=` in Visual Basic) to check each label's icon color to verify whether it matches the background. If the colors match, the icon remains invisible, and the player hasn't matched all of the icons remaining. In that case, the program uses a `return` statement to skip the rest of the method. If the loop gets through all of the labels without executing the `return` statement, that means that all of the icons on the form were matched. The program shows a MessageBox to congratulate the player on winning, and then calls the form's `Close()` method to end the game.  
  
2.  Next, have the label's Click event handler call the new `CheckForWinner()` method. Be sure that your program checks for a winner immediately after it shows the second icon that the player chooses. Look for the line where you set the second chosen icon's color, and then call the `CheckForWinner()` method right after that, as shown in the following code.  
  
     [!CODE [VbExpressTutorial4Step8#11](../CodeSnippet/VS_Snippets_VBCSharp/vbexpresstutorial4step8#11)]  
  
3.  Save and run the program. Play the game and match all of the icons. When you win, the program displays a congratulatory MessageBox (as shown in the following picture), and then closes the box.  
  
     ![Matching game with MessageBox](../VS_IDE/media/Express_Tut4Step8.png "Express_Tut4Step8")  
Matching game with MessageBox  
  
### To continue or review  
  
-   To go to the next tutorial step, see [Step 9: Try Other Features](../VS_IDE/Step-9--Try-Other-Features.md).  
  
-   To return to the previous tutorial step, see [Step 7: Keep Pairs Visible](../VS_IDE/Step-7--Keep-Pairs-Visible.md).