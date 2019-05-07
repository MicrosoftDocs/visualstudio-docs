---
title: "Step 10: Write code for additional buttons and a check box"
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: 185cf370-ab39-4ac0-b6bc-601d5b95a4a2
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
---
# Step 10: Write code for additional buttons and a check box
Now you're ready to complete the other four methods. You could copy and paste this code, but if you want to learn the most from this tutorial, type the code and use IntelliSense.

 This code adds functionality to the buttons you added earlier. Without this code, the buttons don't do anything. The buttons use code in their <xref:System.Windows.Forms.Control.Click> events (and the check box uses the <xref:System.Windows.Forms.CheckBox.CheckedChanged> event) to do different things when you activate the controls. For example, the `clearButton_Click` event, which activates when you choose the **Clear the picture** button, erases the current image by setting its **Image** property to **null** (or, **nothing**). Each event in the code includes comments that explain what the code does.

 ![link to video](../data-tools/media/playvideo.gif)For a video version of this topic, see [Tutorial 1: Create a picture viewer in Visual Basic - Video 5](http://go.microsoft.com/fwlink/?LinkId=205216) or [Tutorial 1: Create a picture viewer in C# - Video 5](http://go.microsoft.com/fwlink/?LinkId=205206). These videos use an earlier version of Visual Studio, so there are slight differences in some menu commands and other user interface elements. However, the concepts and procedures work similarly in the current version of Visual Studio.

> [!NOTE]
> As a best practice: Always comment your code. Comments are information for a person to read, and it's worth the time to make your code understandable. Everything on a comment line is ignored by the program. In Visual C#, you comment a line by typing two forward slashes at the beginning (//), and in Visual Basic you comment a line by starting with a single quotation mark (').

## To write code for additional buttons and a check box

- Add the following code to your **Form1** code file (*Form1.cs* or *Form1.vb*). Choose the **VB** tab to view Visual Basic code.

     [!code-vb[VbExpressTutorial1Step9_10#2](../ide/codesnippet/VisualBasic/step-10-write-code-for-additional-buttons-and-a-check-box_1.vb)]
     [!code-csharp[VbExpressTutorial1Step9_10#2](../ide/codesnippet/CSharp/step-10-write-code-for-additional-buttons-and-a-check-box_1.cs)]

## To continue or review

- To go to the next tutorial step, see [Step 11: Run your program and try other features](../ide/step-11-run-your-program-and-try-other-features.md).

- To return to the previous tutorial step, see [Step 9: Review, comment, and test your code](../ide/step-9-review-comment-and-test-your-code.md).
