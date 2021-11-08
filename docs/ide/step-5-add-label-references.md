---
title: "Step 5: Add label references"
description: Learn how to add label references to your form.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: tutorial
dev_langs:
  - "CSharp"
  - "VB"
ms.assetid: d418350c-0396-494e-8149-71fa61b395c5
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
  - "multiple"
---
# Step 5: Add label references
The program needs to track which Label controls the player chooses. Right now, the program shows all labels chosen by the player. But we're going to change that. After the first label is chosen, the program should show the label's icon. After the second label is chosen, the program should display both icons for a brief time, and then hide both icons again. Your program will now keep track of which Label control is chosen first and which is chosen second by using *reference variables*.

## To add label references

1. Add label references to your form by using the following code.

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial4step5/vb/form1.vb" id="Snippet5":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial4step5/cs/form1.cs" id="Snippet5":::

     > [!IMPORTANT]
     > Use the programming language control at the top right of this page to view either the C# code snippet or the Visual Basic code snippet.<br><br>![Programming language control for Docs.Microsoft.com](../ide/media/docs-programming-language-control.png)

     These reference variables look similar to the statements you used earlier to add objects (like <xref:System.Windows.Forms.Timer> objects, <xref:System.Collections.Generic.List%601> objects, and <xref:System.Random> objects) to your form. However, these statements don't cause two extra Label controls to appear on the form because there's no `new` keyword used in either of the two statements. Without the `new` keyword, no object is created. That's why `firstClicked` and `secondClicked` are called reference variables: They just keep track (or, refer to) Label objects.

     When a variable isn't keeping track of an object, it's set to a special reserved value: `null` in C# and `Nothing` in Visual Basic. So, when the program starts, both `firstClicked` and `secondClicked` are set to `null` or `Nothing`, which means that the variables aren't keeping track of anything.

2. Modify your <xref:System.Windows.Forms.Control.Click> event handler to use the new `firstClicked` reference variable. Remove the last statement in the `label_Click()` event handler method (`clickedLabel.ForeColor = Color.Black;`) and replace it with the `if` statement that follows. (Be sure you include the comment, and the whole `if` statement.)

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial4step5/vb/form1.vb" id="Snippet6":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial4step5/cs/form1.cs" id="Snippet6":::

3. Save and run your program. Choose one of the label controls, and its icon appears.

4. Choose the next label control, and notice that nothing happens. The program is already keeping track of the first label that the player chose, so `firstClicked` isn't equal to `null` in C# or `Nothing` in Visual Basic. When your `if` statement checks `firstClicked` to determine if it's equal to `null` or `Nothing`, it finds that it isn't, and it doesn't execute the statements in the `if` statement. So, only the first icon that's chosen turns black, and the other icons are invisible, as shown in the following image.

     ![Matching game showing one icon](../ide/media/express_tut4step5.png)<br/>
***Matching game*** *showing one icon*

     You'll fix this situation in the next step of the tutorial by adding a **Timer** control.

## To continue or review

- To go to the next tutorial step, see **[Step 6: Add a timer](../ide/step-6-add-a-timer.md)**.

- To return to the previous tutorial step, see [Step 4: Add a Click event handler to each label](../ide/step-4-add-a-click-event-handler-to-each-label.md).
