---
title: "Step 10: Write Code for Additional Buttons and a Check Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: 185cf370-ab39-4ac0-b6bc-601d5b95a4a2
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: jillfra
---
# Step 10: Write Code for Additional Buttons and a Check Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Now you're ready to complete the other four methods. You could copy and paste this code, but if you want to learn the most from this tutorial, type the code and use IntelliSense.

 This code adds functionality to the buttons you added earlier. Without this code, the buttons don't do anything. The buttons use code in their `Click` events (and the check box uses the `CheckChanged` event) to do different things when you activate the controls. For example, the `clearButton_Click` event, which activates when you choose the **Clear the picture** button, erases the current image by setting its `Image` property to `null` (or, `nothing`). Each event in the code includes comments that explain what the code does.

 ![link to video](../data-tools/media/playvideo.gif "PlayVideo")For a video version of this topic, see [Tutorial 1: Create a Picture Viewer in Visual Basic - Video 5](https://go.microsoft.com/fwlink/?LinkId=205216) or [Tutorial 1: Create a Picture Viewer in C# - Video 5](https://go.microsoft.com/fwlink/?LinkId=205206). These videos use an earlier version of Visual Studio, so there are slight differences in some menu commands and other user interface elements. However, the concepts and procedures work similarly in the current version of Visual Studio.

> [!NOTE]
> As a best practice: Always comment your code. Comments are information for a person to read, and it's worth the time to make your code understandable. Everything on a comment line is ignored by the program. In Visual C#, you comment a line by typing two forward slashes at the beginning (//), and in Visual Basic you comment a line by starting with a single quotation mark (').

### To write code for additional buttons and a check box

- Add the following code to your Form1 code file (Form1.cs or Form1.vb). Choose the **VB** tab to view Visual Basic code.

     [!code-csharp[VbExpressTutorial1Step9_10#2](../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial1step9_10/cs/form1.cs#2)]
     [!code-vb[VbExpressTutorial1Step9_10#2](../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial1step9_10/vb/form1.vb#2)]

### To continue or review

- To go to the next tutorial step, see [Step 11: Run Your Program and Try Other Features](../ide/step-11-run-your-program-and-try-other-features.md).

- To return to the previous tutorial step, see [Step 9: Review, Comment, and Test Your Code](../ide/step-9-review-comment-and-test-your-code.md).
