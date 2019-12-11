---
title: "Step 9: Try Other Features | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: 1b0c5c80-e5a6-4f69-a4a4-0e89a82d4de0
caps.latest.revision: 13
author: jillre
ms.author: jillfra
manager: jillfra
---
# Step 9: Try Other Features
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To learn more, try changing icons and colors, adding a game timer, and adding sounds. To make the game more challenging, try making the board bigger and adjusting the timer.

### To try other features

- Replace the icons and colors with ones you choose.

    > [!TIP]
    > Try looking at the label's [Forecolor](https://msdn.microsoft.com/library/system.windows.forms.control.forecolor%28v=vs.110%29.aspx) property.

- Add a game timer that tracks how long it takes for the player to win.

    > [!TIP]
    > To do this, you can add a label to display the elapsed time on the form above the TableLayoutPanel, and add another timer to the form to track the time. Use code to start the timer when the player starts the game, and stop the timer after they match the last two icons.

- Add a sound when the player finds a match, another sound when the player uncovers two icons that don't match, and a third sound when the program hides the icons again.

    > [!TIP]
    > To play sounds, you can use the System.media namespace. See [Play Sounds in Windows Forms App (C# .NET)](https://www.youtube.com/watch?v=qOh4ooHg1UU&feature=youtu.be) or [How To Play Audio In Visual Basic](https://www.youtube.com/watch?v=-4oPDeQrtMs&feature=youtu.be) for more information.

- Make the game more difficult by making the board bigger.

    > [!TIP]
    > You'll need to do more than just add rows and columns to the TableLayoutPanel – you'll also need to consider the number of icons you create.

- Make the game more challenging by hiding the first icon if the player is too slow to respond and doesn't choose the second icon before a certain amount of time.

### To continue or review

- If you get stuck or have programming questions, try posting your question on one of the MSDN forums. See [Visual Basic Forum](https://social.msdn.microsoft.com/Forums/en-US/home) and [Visual C# Forum](https://social.msdn.microsoft.com/Forums/en-US/home).

- There are great, free video learning resources available to you. To learn more about programming in Visual Basic, see [Visual Basic Fundamentals: Development for Absolute Beginners](https://channel9.msdn.com/Series/Visual-Basic-Development-for-Absolute-Beginners). To learn more about programming in Visual C#, see [C# Fundamentals: Development for Absolute Beginners](https://channel9.msdn.com/Series/C-Sharp-Fundamentals-Development-for-Absolute-Beginners).

- To return to the previous tutorial step, see [Step 8: Add a Method to Verify Whether the Player Won](../ide/step-8-add-a-method-to-verify-whether-the-player-won.md).
