---
title: 'Step 6: Name your button controls'
description: Learn how to name your button controls.
ms.custom: SEO-VS-2020
ms.date: 08/30/2016
ms.assetid: 56b3baa3-651e-4ad4-8942-e334c5c57158
ms.topic: tutorial
dev_langs:
- CSharp
- VB
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Step 6: Name your button controls

There's only one <xref:System.Windows.Forms.PictureBox> on your form. When you added it, the IDE automatically named it **pictureBox1**. There's only one <xref:System.Windows.Forms.CheckBox>, which is named **checkBox1**. Soon, you'll write some code, and that code will refer to the CheckBox and PictureBox. Because there's only one of each of these controls, you'll know what it means when you see **pictureBox1** or **checkBox1** in your code.

> [!TIP]
> In Visual Basic, the default first letter of any control name is initial cap, so the names are **PictureBox1**, **CheckBox1**, and so on.

There are four buttons on your form, and the IDE named them **button1**, **button2**, **button3**, and **button4**. By just looking at their current names, you don't know which button is the **Close** button and which one is the **Show a picture** button. That's why giving your button controls more informative names is helpful.

## To name your button controls

1. On the form, choose the **Close** button. (If you still have all the buttons selected, choose the **Esc** key to cancel the selection.) Scroll in the **Properties** window until you see the **(Name)** property. (The **(Name)** property is near the top when the properties are alphabetical.) Change the name to **closeButton**, as shown in the following screenshot.

    ![Properties window with closeButton name](../ide/media/express_setnameproperty.png)<br>***Properties*** *window with* ***closeButton*** *name*

    > [!NOTE]
    > Try changing the name of your button to **close Button**, with a space between the words "close" and "Button". When you do so, the IDE displays an error message: "Property value is not valid." Spaces (and a few other characters) are not allowed in control names.

1. Rename the other three buttons to **backgroundButton**, **clearButton**, and **showButton**.
You can verify the names by choosing the control selector drop-down list in the **Properties** window. The new button names appear.

1. Double-click the **Show a picture** button on the form. As an alternative, choose the **Show a picture** button on the form, and then press the **Enter** key. When you do, the IDE opens an additional tab in the main window named **Form1.cs**. (If you're using Visual Basic, the tab is named **Form1.vb**).

   This tab displays the code file behind the form, as shown in the following screenshot.

    ![Form1.cs tab with Visual C&#35; code](../ide/media/express_showbuttoncode.png)<br>
***Form1.cs*** *tab with C# code*

    > [!NOTE]
    > Your Form1.cs or Form1.vb tab might display **showButton** as **ShowButton** instead.

1. Focus on this part of the code.

    ```csharp
        private void ShowButton_Click(object sender, EventArgs e)
    {
    }
    ```

    ```vb
        Private Sub showButton_Click() Handles showButton.Click

    End Sub
    ```

   [!INCLUDE [devlang-control-csharp-vb](./includes/devlang-control-csharp-vb.md)]

   You're looking at code called `showButton_Click()` (alternatively, `ShowButton_Click()`). The IDE added this to the form's code when you opened the code file for the **showButton** button. At design-time, when you open the code file for a control in a form, code is generated for the control if it doesn't already exist. This code, known as a *method*, runs when you run your app and choose the control - in this case, the **Show a picture** button.

1. Choose the **Windows Forms Designer** tab again (**Form1.cs [Design]**), and then open the code file for the **Clear the picture** button to create a method for it in the form's code. Repeat this for the remaining two buttons. Each time, the IDE adds a new method to the form's code file.

1. To add one more method, open the code file for the **CheckBox** control in **Windows Forms Designer** to make the IDE add a `checkBox1_CheckedChanged()` method. That method is called whenever the user selects or clears the check box.

   > [!TIP]
   > When working on an app, you often move between the code editor and **Windows Forms Designer**. The IDE makes it easy to navigate in your project. Use **Solution Explorer** to open **Windows Forms Designer** by double-clicking *Form1.cs* in C# or *Form1.vb* in Visual Basic, or on the menu bar, choose **View** > **Designer**.

    The following shows the new code that you see in the code editor.

    :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial1step6/cs/form1.cs" id="Snippet2":::

    :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial1step6/vb/form1.vb" id="Snippet2":::

    > [!NOTE]
    > Your code might not display event handlers in "camelCase" letters.

    The five methods that you added are called *event handlers*, because your application calls them whenever an event (like a user choosing a button or selecting a box) happens.

    When you view the code for a control in the IDE at design time, Visual Studio adds an event handler method for the control if one isn't there. For example, when you double-click a button, the IDE adds an event handler for its <xref:System.Windows.Forms.Control.Click> event (which is called whenever the user chooses the button). When you double-click a check box, the IDE adds an event handler for its <xref:System.Windows.Forms.CheckBox.CheckedChanged> event (which is called whenever the user selects or clears the box).

    After you add an event handler for a control, you can return to it at any time from **Windows Forms Designer** by double-clicking the control, or on the menu bar, choosing **View** > **Code**.

    Names are important when you build programs, and methods (including event handlers) can have any name that you want. When you add an event handler with the IDE, it creates a name based on the control's name and the event being handled.

    For example, the Click event for a button named **showButton** is called the `showButton_Click()` (alternatively, `ShowButton_Click()`) event handler method. Also, opening and closing parentheses `()` are usually added after the method name to indicate that methods are being discussed.

    If you decide you want to change a code variable name, right-click the variable in the code and then choose **Refactor** > **Rename**. All instances of that variable in the code are renamed. For more information, see [Rename refactoring](../ide/reference/rename.md).

## Next steps

* To go to the next tutorial step, see **[Step 7: Add dialog components to your form](../ide/step-7-add-dialog-components-to-your-form.md)**.

* To return to the previous tutorial step, see [Step 5: Add controls to your form](../ide/step-5-add-controls-to-your-form.md).

## See also

* [Tutorial 2: Create a timed math quiz](tutorial-2-create-a-timed-math-quiz.md)
* [Tutorial 3: Create a matching game](tutorial-3-create-a-matching-game.md)
