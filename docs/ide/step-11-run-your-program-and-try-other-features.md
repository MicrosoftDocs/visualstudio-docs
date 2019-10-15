---
title: "Step 11: Run your picture viewer app and try other features"
ms.date: 09/11/2019
ms.assetid: 656614d0-4fe7-4a67-8edc-c10919377d09
ms.topic: tutorial
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
---
# Step 11: Run your picture viewer app and try other features

Your picture viewer app is finished and ready to run. You can run your app and set the background color of the <xref:System.Windows.Forms.PictureBox>. To learn more, try to improve the application by changing the color of the form, customizing the buttons and check box, and changing the properties of the form.

## How to run your app and set the background color

1. Choose **F5**, or on the menu bar, choose **Debug** > **Start Debugging**.

1. Before you open a picture, choose the **Set the background color** button. The **Color** dialog box opens.

     ![Color dialog box](../ide/media/express_colordialog.png)<br/>
***Color*** *dialog box*

1. Choose a color to set the PictureBox background color. Look closely at the `backgroundButton_Click()` (or, `BackgroundButton_Click()`) method to understand how it works.

    > [!NOTE]
    > You can load a picture from the Internet by pasting its URL into the **Open File** dialog box. Try to find an image with a transparent background, so your background color shows.

1. Choose the **Clear the picture** button to make sure it clears. Then, exit the app by choosing the **Close** button.

## Try other features

* Change the color of the form and the buttons by using the **BackColor** property.

* Customize your buttons and check box using the **Font** and **ForeColor** properties.

* Change your form's **FormBorderStyle** and **ControlBox** properties.

* Use your form's **AcceptButton** and **CancelButton** properties so that buttons are automatically chosen when the user chooses the **Enter** or **Esc** key. Make the app open the **Open File** dialog box when the user chooses **Enter** and close the box when the user chooses **Esc**.

## Next steps

To learn more, continue with the following tutorial:

> [!div class="nextstepaction"]
> [Tutorial 2: Create a timed math quiz](../ide/tutorial-2-create-a-timed-math-quiz.md)

To return to the previous tutorial step, see [Step 10: Write code for additional buttons and a check box](../ide/step-10-write-code-for-additional-buttons-and-a-check-box.md).

## See also

* [More C# tutorials](/visualstudio/get-started/csharp/)
* [More Visual Basic tutorials](/visualstudio/get-started/visual-basic/)
* [C++ tutorial](/cpp/get-started/tutorial-console-cpp)
