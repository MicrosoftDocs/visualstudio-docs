---
title: "Step 9: Review, comment, and test your code"
description: Learn how to add a comment to your code and test your app.
ms.custom: SEO-VS-2020
ms.date: 08/30/2019
ms.assetid: f26f79ba-c91b-4164-b87f-679a1b231c09
ms.topic: tutorial
dev_langs:
  - "CSharp"
  - "VB"
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
  - "multiple"
---
# Step 9: Review, comment, and test your code

You next add a comment to your code. A comment is a note that doesn't change the way the app behaves. It makes it easier for someone who is reading your code to understand what it does. Adding comments to your code is a good habit to get into.

In C#, two forward slashes (//) mark a line as a comment. In Visual Basic, a single quotation mark (') is used to mark a line as a comment. After you add a comment, you test your application. It's good practice to run and test your code frequently while you're working on your projects, so you can catch and fix any problems early, before the code gets more complicated. This is called *iterative testing*.

You just built something that works, and although it's not done yet, it can already load a picture. Before you add a comment to your code and test it, take time to review the code concepts, because you will use these concepts frequently:

- When you double-clicked the **Show a picture** button in **Windows Forms Designer**, the IDE automatically added a *method* to your program's code.

- Methods are how you organize your code: It's how your code is grouped together.

- Most of the time, a method does a small number of things in a specific order, like how your `showButton_Click()` (or `ShowButton_Click()`) method shows a dialog box and then loads a picture.

- A method is made up of code *statements*, or lines of code. Think of a method as a way to bundle code statements together.

- When a method is executed, or *called*, the statements in the method are executed in order, one after another, starting with the first one.

   The following is an example of a statement.

  ```csharp
  PictureBox1.Load(openFileDialog1.FileName);
  ```

  ```vb
  pictureBox1.Load(openFileDialog1.FileName)
  ```

   Statements are what make your programs do things. In C#, a statement always ends in a semicolon. In Visual Basic, the end of a line is the end of a statement. (No semicolon is needed in Visual Basic.) The preceding statement tells your <xref:System.Windows.Forms.PictureBox> control to load the file that the user selected with the **OpenFileDialog** component.

## To add comments

1. Add the following comment to your code.

     [!INCLUDE [devlang-control-csharp-vb](./includes/devlang-control-csharp-vb.md)]

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial1step9_10/cs/form1.cs" id="Snippet1":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial1step9_10/vb/form1.vb" id="Snippet1":::

    Your **showButton** button's <xref:System.Windows.Forms.Control.Click> event handler is now finished, and it works. You have started writing code, starting with an `if` statement. An `if` statement is how you tell your app, "Check this one thing, and if it's true, do these actions." In this case, you tell your app to open the **Open File** dialog box, and if the user selects a file and chooses the **OK** button, load that file in the **PictureBox**.

    > [!TIP]
    > The IDE is built to make it easy for you to write code, and *code snippets* are one way it does that. A snippet is a shortcut that gets expanded into a small block of code.
    >
    >  You can see all of the snippets available. On the menu bar, choose **Tools** > **Code Snippets Manager**. For C#, the `if` snippet is in **Visual C#** . For Visual Basic, the `if` snippets are in **Code Patterns** > **Conditionals and Loops**. You can use this manager to browse existing snippets or add your own snippets.
    >
    >  To activate a snippet when typing code, type it and choose the **Tab** key. Many snippets appear in the **IntelliSense** window, which is why you choose the **Tab** key twice: first to select the snippet from the **IntelliSense** window, and then to tell the IDE to use the snippet. (IntelliSense supports the `if` snippet, but not the `ifelse` snippet.)

1. Before you run your application, save your app by choosing the **Save All** toolbar button, which should look similar to the following screenshot.

     ![Save All toolbar button](../ide/media/express_iconsaveall.png)<br>
***Save All*** *button*

     Alternatively, to save your app, choose **File** > **Save All** from the menu bar (or press **Ctrl**+**Shift**+**S**). It's a best practice to save early and often.

     When it's running, your program should look like the following image.

     ![Picture Viewer](../ide/media/express_pictureviewerdonerun.png)<br>***Picture Viewer***

## To test your app

1. Choose the **F5** key or choose the **Start Debugging** toolbar button.

1. Choose the **Show a picture** button to run the code you just wrote. First, the app opens an **Open File** dialog box. Verify that your filters appear in the **Files of type** drop-down list at the bottom of the dialog box. Then navigate to a picture and open it. You can usually find sample pictures that ship with the Windows operating system in your *My Documents* folder, inside the *My Pictures\Sample Pictures* folder.

    > [!TIP]
    > If you don't see any images in the **Select a picture file** dialog box, be sure that the **All files (*.\*)** filter is selected in the drop-down list on the lower right side of the dialog box.

1. Load a picture, and it appears in your PictureBox. Then try resizing your form by dragging its borders. Because you have your PictureBox docked inside a TableLayoutPanel, which itself is docked inside the form, your picture area will resize itself so that it's as wide as the form, and fills the top 90 percent of the form. That's why you used the <xref:System.Windows.Forms.TableLayoutPanel> and <xref:System.Windows.Forms.FlowLayoutPanel> containers: They keep your form sized correctly when the user resizes it.

     Right now, larger pictures go beyond the borders of your picture viewer. In the next step, you'll add code to make pictures fit in the window.

## To continue or review

- To go to the next tutorial step, see **[Step 10: Write code for additional buttons and a check box](../ide/step-10-write-code-for-additional-buttons-and-a-check-box.md)**.

- To return to the previous tutorial step, see [Step 8: Write code for the show a picture button event handler](../ide/step-8-write-code-for-the-show-a-picture-button-event-handler.md).

## See also

* [Tutorial 2: Create a timed math quiz](tutorial-2-create-a-timed-math-quiz.md)
* [Tutorial 3: Create a matching game](tutorial-3-create-a-matching-game.md)
