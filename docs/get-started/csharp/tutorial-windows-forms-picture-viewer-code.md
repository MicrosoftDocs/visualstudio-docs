---
title: "Tutorial: Add code to the picture viewer Windows Forms app"
description: Learn how to add C# or VB code to support the UI controls for a picture box, checkbox, and button in a picture viewer WinForms application (.NET Framework) with Visual Studio.
dev_langs:
  - "CSharp"
  - "VB"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
ms.topic: tutorial
ms.date: 09/19/2024
ms.custom: vs-acquisition
#customer intent: As a developer, I want to learn how to add C# or VB code to my WinForms project to take actions when a user selects a control.
---
# Tutorial: Add code to the picture viewer Windows Forms App (.NET Framework)

In this series of three tutorials, you create a Windows Forms application that loads a picture and displays it.
The Visual Studio Integrated Design Environment (IDE) provides the tools you need to create the app.

Controls use C# or Visual Basic code to take the actions associated with them.

In this third tutorial, you learn how to:

> [!div class="checklist"]
> - Add event handlers for your controls
> - Write code to open a dialog box
> - Write code for the other controls
> - Run your application

To create a new Windows Forms App with .NET, follow the tutorial [Create a Windows Forms app with .NET](/dotnet/desktop/winforms/get-started/create-app-visual-studio/). See the [Desktop Guide on Windows Forms .NET](/dotnet/desktop/winforms/overview/) to learn more.

## Prerequisites

- This tutorial builds on the previous tutorials, [Create a picture viewer application](tutorial-windows-forms-picture-viewer-layout.md) and [Add UI controls to the picture viewer](tutorial-windows-forms-picture-viewer-controls.md).
Complete them first and start with the project that you created for those tutorials.

## Add event handlers for your controls

In this section, add *event handlers* for the controls that you added in the second tutorial, [Add controls to a picture viewer application](tutorial-windows-forms-picture-viewer-code.md).
Your application calls an event handler when an action takes place, such as selecting a button.

1. Open Visual Studio. Your Picture Viewer project appears under **Open recent**.

1. In the **Windows Forms Designer**, double-click the **Show a picture** button.
   You can instead select the **Show a picture** button on the form, and then press **Enter**.

   The Visual Studio IDE opens a tab in the main window. For C#, the tab is named **Form1.cs**. If you're using Visual Basic, the tab is named **Form1.vb**.

   This tab displays the code file behind the form.

   :::image type="content" source="../media/tutorial-windows-forms-picture-viewer-code/show-picture-button-code.png" alt-text="Screenshot shows the Form1.cs tab with Visual C sharp code.":::

   > [!NOTE]
   > Your Form1.vb tab might display **showButton** as **ShowButton**.

1. Focus on this part of the code.

   ### [C#](#tab/csharp)
   ```csharp
   private void showButton_Click(object sender, EventArgs e)
   {
   }
   ```

   ### [VB](#tab/vb)
   ```vb
   Private Sub showButton_Click() Handles showButton.Click

   End Sub
   ```
   ---

1. Choose the **Windows Forms Designer** tab again, and then double-click the **Clear the picture** button to open its code.
   Repeat for the remaining two buttons.
   Each time, the Visual Studio IDE adds a new method to the form's code file.

1. Double-click the CheckBox control in **Windows Forms Designer** to add a `checkBox1_CheckedChanged()` method.
   When you select or clear the check box, it calls this method.

   The following snippet shows the new code that you see in the code editor.

   ### [C#](#tab/csharp)

   :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial1step6/cs/form1.cs" id="Snippet2":::

   ### [VB](#tab/vb)

   :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial1step6/vb/form1.vb" id="Snippet2":::
   ---

Methods, including event handlers, can have any name that you want.
When you add an event handler with the IDE, it creates a name based on the control's name and the event being handled.

For example, the `Click` event for a button named **showButton** is called `showButton_Click()` or `ShowButton_Click()`.
If you want to change a code variable name, right-click the variable in the code and then choose **Refactor** > **Rename**. This action renames all instances of that variable in the code. For more information, see [Rename refactoring](../../ide/reference/rename.md).

## Write code to open a dialog box

The **Show a picture** button uses the OpenFileDialog component to display a picture file.
This procedure adds the code used to call that component.

The Visual Studio IDE offers a powerful tool called *IntelliSense*.
As you type, IntelliSense suggests possible code.

1. In **Windows Forms Designer**, double-click the **Show a picture** button.
   The IDE moves your cursor inside the `showButton_Click()` or `ShowButton_Click()` method.

1. Type an *i* on the empty line between the two braces `{ }`or between `Private Sub...` and `End Sub`.
   An **IntelliSense** window opens.

   :::image type="content" source="../media/tutorial-windows-forms-picture-viewer-code/intellisense-window.png" alt-text="Screenshot shows IntelliSense with Visual C sharp code.":::

1. The **IntelliSense** window should highlight the word `if`. Select the **Tab** key twice to insert the `if` snippet.

1. Select **true** and then type `op` to overwrite it for C# or `Op` for Visual Basic.

   :::image type="content" source="../media/tutorial-windows-forms-picture-viewer-code/show-button-handler-true-selected.png" alt-text="Screenshot shows the event handler for the show button with the value true selected.":::

   IntelliSense displays **openFileDialog1**.

1. Select **Tab** to add openFileDialog1.

1. Type a period (`.`) or *dot*, right after **openFileDialog1**.
   IntelliSense provides all of the **OpenFileDialog** component's properties and methods.
   Start to type `ShowDialog` and select **Tab**.
   The `ShowDialog()` method shows the **Open File** dialog box.

1. Add parentheses `()` immediately after the "g" in `ShowDialog`.
   Your code should be `openFileDialog1.ShowDialog()`.

1. For C#, add a space, and then add two equal signs (`==`). For Visual Basic, add a space, and then use a single equal sign (`=`).

1. Add another space. Use IntelliSense to enter *DialogResult*.

1. Type a dot to open the DialogResult value in the **IntelliSense** window. Enter the letter `O` and choose the **Tab** key to insert **OK**.

   > [!NOTE]
   > The first line of code should be complete. For C#, it should be similar to the following.
   >
   >  `if (openFileDialog1.ShowDialog() == DialogResult.OK)`
   >
   >  For Visual Basic, it should be the following.
   >
   >  `If OpenFileDialog1.ShowDialog() = DialogResult.OK Then`

1. Add the following line of code.

   ### [C#](#tab/csharp)
   ```csharp
   pictureBox1.Load(openFileDialog1.FileName);  
   ```

   ### [VB](#tab/vb)
   ```vb
   PictureBox1.Load(OpenFileDialog1.FileName)
   ```
   ---

   You can copy and paste or use IntelliSense to add it.
   Your final `showButton_Click()` method should look similar to the following code.

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial1step8/cs/form1.cs" id="Snippet1":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial1step8/vb/form1.vb" id="Snippet1":::
   ---

1. Add the following comment to your code.

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial1step9_10/cs/form1.cs" id="Snippet1":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial1step9_10/vb/form1.vb" id="Snippet1":::
   ---

   It's the best practice to always comment your code.
   Code comments make it easier to understand and maintain your code in the future.

## Write code for the other controls

If you run your application now, you can select **Show a picture**.
Picture Viewer opens the **Open File** dialog box, where you can select a picture to display.

In this section, add the code for the other event handlers.

1. In **Windows Forms Designer**, double-click the **Clear** the picture button.
   For C#, add the code in braces.
   For Visual Basic, add the code between `Private Sub` and `End Sub`.

   ### [C#](#tab/csharp)
   ```csharp
   private void clearButton_Click(object sender, EventArgs e)
   {
       // Clear the picture.
       pictureBox1.Image = null;
   }
   ```

   ### [VB](#tab/vb)
   ```vb
   Private Sub clearButton_Click() Handles clearButton.Click
       ' Clear the picture.
       PictureBox1.Image = Nothing
   End Sub   
   ```
   ---

1. Double-click the **Set the background color** button and add the code.

   ### [C#](#tab/csharp)
   ```csharp
   private void backgroundButton_Click(object sender, EventArgs e)
   {
       // Show the color dialog box. If the user clicks OK, change the
       // PictureBox control's background to the color the user chose.
       if (colorDialog1.ShowDialog() == DialogResult.OK)
           pictureBox1.BackColor = colorDialog1.Color;
   }
   ```

   ### [VB](#tab/vb)
   ```vb
   Private Sub backgroundButton_Click() Handles backgroundButton.Click
       ' Show the color dialog box. If the user clicks OK, change the
       ' PictureBox control's background to the color the user chose.
       If ColorDialog1.ShowDialog() = DialogResult.OK Then
           PictureBox1.BackColor = ColorDialog1.Color
       End If
   End Sub
   ```
   ---

1. Double-click the **Close** button and add the code.

   ### [C#](#tab/csharp)
   ```csharp
   private void closeButton_Click(object sender, EventArgs e)
   {
       // Close the form.
       this.Close();
   }

   ```

   ### [VB](#tab/vb)
   ```vb
   Private Sub closeButton_Click() Handles closeButton.Click
       ' Close the form.
       Close()
   End Sub  
   ```
   ---

1. Double-click the **Stretch** checkbox and add the code.

   ### [C#](#tab/csharp)
   ```csharp
   private void checkBox1_CheckedChanged(object sender, EventArgs e)
   {
       // If the user selects the Stretch check box, 
       // change the PictureBox's
       // SizeMode property to "Stretch". If the user clears 
       // the check box, change it to "Normal".
       if (checkBox1.Checked)
           pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
       else
           pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
   }
   ```

   ### [VB](#tab/vb)
   ```vb
   Private Sub CheckBox1_CheckedChanged() Handles CheckBox1.CheckedChanged
       ' If the user selects the Stretch check box, change 
       ' the PictureBox's SizeMode property to "Stretch". If the user 
       ' clears the check box, change it to "Normal".
       If CheckBox1.Checked Then
           PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
       Else
           PictureBox1.SizeMode = PictureBoxSizeMode.Normal
       End If
   End Sub   
   ```
   ---

## Run your application

You can run your application at any time while you're writing it.
After you add the code in the previous section, the Picture Viewer is complete.
As in the previous tutorials, use one of the following methods to run your application:

- Select the **F5** key.
- On the menu bar, select **Debug** > **Start Debugging**.
- On the toolbar, select the **Start** button.

A window with the title **Picture Viewer** appears.
Test all the controls.

1. Select the **Set the background color** button. The **Color** dialog box opens.

   :::image type="content" source="../media/tutorial-windows-forms-picture-viewer-code/color-dialog-box.png" alt-text="Screenshot shows your app with the Color dialog box.":::

1. Choose a color to set the background color.

1. Select **Show a picture** to display a picture.

   :::image type="content" source="../media/tutorial-windows-forms-picture-viewer-code/run-picture-viewer.png" alt-text="Screenshot shows the Picture Viewer app with a picture displayed.":::

1. Select and unselect **Stretch**.

1. Select the **Clear the picture** button to make sure the display clears.

1. Select **Close** to exit the app.

Congratulations!
You completed this series of tutorials.
You accomplished these programming and design tasks in the Visual Studio IDE:

- Created a Visual Studio project that uses Windows Forms
- Added layout for the picture viewing application
- Added buttons and a checkbox
- Added dialog boxes
- Added event handlers for your controls
- Written C# or Visual Basic code to handle the events

## Next step

Continue learning with another tutorial series on how to create a timed math quiz.
> [!div class="nextstepaction"]
> [Tutorial 2: Create a timed math quiz](tutorial-windows-forms-math-quiz-create-project-add-controls.md)
