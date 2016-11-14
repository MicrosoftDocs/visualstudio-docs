---
title: "Step 8: Customize the Quiz | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: dc8edb13-1b23-47d7-b859-8c6f7888c1a9
caps.latest.revision: 12
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Step 8: Customize the Quiz
In the last part of the tutorial, you'll explore some ways to customize the quiz and expand on what you've already learned. For example, think about how the program creates random division problems for which the answer is never a fraction. To learn more, turn the `timeLabel` control a different color, and give the quiz taker a hint.  
  
### To customize the quiz  
  
-   When only five seconds remain in a quiz, turn the **timeLabel** control red by setting its **BackColor** property (`timeLabel.BackColor = Color.Red;`). Reset the color when the quiz is over.  
  
-   Give the quiz taker a hint by playing a sound when the correct answer is entered into a NumericUpDown control. (You must write an event handler for each control's `ValueChanged()` event, which fires whenever the quiz taker changes the control's value.)  
  
### To continue or review  
  
-   To download a completed version of the quiz, see [Complete Math Quiz tutorial sample](http://code.msdn.microsoft.com/Complete-Math-Quiz-8581813c).  
  
-   To go to the next tutorial, see [Tutorial 3: Create a Matching Game](../ide/tutorial-3-create-a-matching-game.md).  
  
-   To return to the previous tutorial step, see [Step 7: Add Multiplication and Division Problems](../ide/step-7-add-multiplication-and-division-problems.md).