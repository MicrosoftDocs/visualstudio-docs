---
title: "Step 8: Write code for the show a picture button event handler"
ms.date: 08/30/2019
ms.assetid: 07f4ec00-cda4-42f4-98bb-37edc7167de7
ms.topic: tutorial
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
dev_langs:
  - "CSharp"
  - "VB"
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
---
# Step 8: Write code for the show a picture button event handler

In this step, you make the **Show a picture** button work as follows:

- When a user chooses that button, the app opens an <xref:System.Windows.Forms.OpenFileDialog> box.

- If a user opens a picture file, the app shows that picture in the <xref:System.Windows.Forms.PictureBox>.

The IDE has a powerful tool called IntelliSense that helps you write code. As you type code, the IDE opens a box with suggested completions for partial words that you enter.

IntelliSense tries to determine what you want to do next, and automatically jumps to the last item you choose from the list. You can use the up or down arrows to move in the list, or you can keep typing letters to narrow the choices. When you see the choice you want, choose the **Tab** key to select it. Or, you can ignore the suggestions, if not needed.

## To write code for the show a picture button event handler

1. Go to **Windows Forms Designer** and double-click the **Show a picture** button. The IDE immediately goes to the code designer and moves your cursor so it's inside the `showButton_Click()` (alternatively, `ShowButton_Click()`) method that you added previously.

1. Type an `i` on the empty line between the two braces `{ }`. (In Visual Basic, type on the empty line between `Private Sub...` and `End Sub`.) An **IntelliSense** window opens, as shown in the following image.

    ![IntelliSense with Visual C&#35; code](../ide/media/express_ifintellisense.png)

    > [!NOTE]
    > Your code might not display event handlers in "camelCase" letters.

1. The **IntelliSense** window should highlight the word `if`. (If not, enter a lowercase `f`, and it will.) Notice how a *tooltip* box next to the **IntelliSense** window appears with the description, **Code snippet for if statement**. (In Visual Basic, the tooltip also states that this is a snippet, but with slightly different wording.) You want to use that snippet, so choose the **Tab** key to insert `if` into your code. Then choose the **Tab** key again to use the `if` snippet. (If you chose somewhere else and your **IntelliSense** window disappeared, backspace over the `i` and retype it, and the **IntelliSense** window opens again.)

    ![Visual C&#35; code](../ide/media/express_highlighttrue.png)

### Use IntelliSense to enter more code

Next, you use IntelliSense to enter more code to open an **Open File** dialog box. If the user chose the **OK** button, the PictureBox loads the file that the user selected. The following steps show how to enter the code, and although there are many steps, it's just a few keystrokes:

 1. Start with the selected text **true** in the snippet. Type `op` to overwrite it. (In Visual Basic, you start with an initial cap, so type `Op`.)

 1. The **IntelliSense** window opens and displays **openFileDialog1**. Choose the **Tab** key to select it. (In Visual Basic, it starts with an initial cap, so you see **OpenFileDialog1**. Ensure that **OpenFileDialog1** is selected.)

     To learn more about `OpenFileDialog`, see [OpenFileDialog](<xref:System.Windows.Forms.OpenFileDialog>).

 1. Type a period (`.`) (Many programmers call this a dot.) Because you typed a dot right after **openFileDialog1**, an **IntelliSense** window opens, filled in with all of the **OpenFileDialog** component's properties and methods. These are the same properties that appear in the **Properties** window when you choose it in **Windows Forms Designer**. You can also choose methods that tell the component to do things (like open a dialog box).

    > [!NOTE]
    > The **IntelliSense** window can show you both properties and methods. To determine what is being shown, look at the icon on the left side of each item in the **IntelliSense** window. You see an image of a block next to each method, and an image of a wrench (or spanner) next to each property. There's also a lightning bolt icon next to each event. <br><br>Here are the icons that appear:<br><br>![Method icon](../ide/media/express_iconmethod.png)<br>![Property icon](../ide/media/express_iconproperty.png)<br>![Event icon](../ide/media/express_iconevent.png)

 1. Start to type `ShowDialog` (capitalization is unimportant to IntelliSense). The `ShowDialog()` method will show the **Open File** dialog box. After the window has highlighted **ShowDialog**, choose the **Tab** key. You can also highlight "ShowDialog" and choose the **F1** key to get help for it.

    To learn more about the `ShowDialog()` method, see [ShowDialog Method](<xref:System.Windows.Forms.Form.ShowDialog%2A>).

 1. When you use a method on a control or a component (referred to as *calling a method*), you need to add parentheses. So enter opening and closing parentheses immediately after the "g" in `ShowDialog`: `()` It should now look like "openFileDialog1.ShowDialog()".

    > [!NOTE]
    > Methods are an important part of any app, and this tutorial has shown several ways to use methods. You can call a component's method to tell it to do something, like how you called the **OpenFileDialog** component's `ShowDialog()` method. You can create your own methods to make your app do things, like the one you're building now, called the `showButton_Click()` method, which opens a dialog box and a picture when a user chooses a button.

 1. For C#, add a space, and then add two equal signs (`==`). For Visual Basic, add a space, and then use a single equal sign (`=`). (C# and Visual Basic use different equality operators.)

 1. Add another space. As soon as you do, another **IntelliSense** window opens. Start to type `DialogResult` and choose the **Tab** key to add it.

    > [!NOTE]
    > When you write code to call a method, sometimes it returns a value. In this case, the **OpenFileDialog** component's <xref:System.Windows.Forms.CommonDialog.ShowDialog> method returns a <xref:System.Windows.Forms.DialogResult> value. DialogResult is a special value that tells you what happened in a dialog box. An **OpenFileDialog** component can result in the user choosing **OK** or **Cancel**, so its `ShowDialog()` method returns either `DialogResult.OK` or `DialogResult.Cancel`.

 1. Type a dot to open the DialogResult value **IntelliSense** window. Enter the letter `O` and choose the **Tab** key to insert **OK**.

    To learn more about DialogResult, see [DialogResult](<xref:System.Windows.Forms.DialogResult>).

    > [!NOTE]
    > The first line of code should be complete. For C#, it should be similar to the following.
    >
    >  `if (openFileDialog1.ShowDialog() == DialogResult.OK)`
    >
    >  For Visual Basic, it should be the following.
    >
    >  `If OpenFileDialog1.ShowDialog() = DialogResult.OK Then`

 1. Now add one more line of code. You can type it (or copy and paste it), but consider using IntelliSense to add it. The more familiar you are with IntelliSense, the more quickly you can write your own code. Your final `showButton_Click()` method should look similar to the following code.

    [!INCLUDE [devlang-control-csharp-vb](./includes/devlang-control-csharp-vb.md)]

    [!code-csharp[VbExpressTutorial1Step8#1](../ide/codesnippet/CSharp/step-8-write-code-for-the-show-a-picture-button-event-handler_1.cs)]

    [!code-vb[VbExpressTutorial1Step8#1](../ide/codesnippet/VisualBasic/step-8-write-code-for-the-show-a-picture-button-event-handler_1.vb)]

## Next steps

* To go to the next tutorial step, see **[Step 9: Review, comment, and test your code](../ide/step-9-review-comment-and-test-your-code.md)**.

* To return to the previous tutorial step, see [Step 7: Add dialog components to your form](../ide/step-7-add-dialog-components-to-your-form.md).

## See also

* [Tutorial 2: Create a timed math quiz](tutorial-2-create-a-timed-math-quiz.md)
* [Tutorial 3: Create a matching game](tutorial-3-create-a-matching-game.md)
