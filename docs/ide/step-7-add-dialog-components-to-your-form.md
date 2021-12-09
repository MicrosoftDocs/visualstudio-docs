---
title: 'Step 7: Add Dialog components to your form'
description: Learn how to add a <xref:System.Windows.Forms.OpenFileDialog> dialog component and a <xref:System.Windows.Forms.ColorDialog> dialog component to your form.
ms.custom: SEO-VS-2020
ms.date: 08/30/2019
ms.assetid: ea98c55e-6213-4893-ba7b-f19d7f119527
ms.topic: tutorial
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Step 7: Add dialog components to your form

To enable your app to open picture files and choose a background color, in this step, you add an <xref:System.Windows.Forms.OpenFileDialog> component and a <xref:System.Windows.Forms.ColorDialog> component to your form.

A component is like a control in some ways. You use the **Toolbox** to add a component to your form, and you set its properties using the **Properties** window. But unlike a control, adding a component to your form doesn't add a visible item that the user can see on the form. Instead, it provides certain behaviors that you can trigger with code. It's a component that opens an **Open File** dialog box.

## To add dialog components to your form

1. Choose the **Windows Forms Designer** (**Form1.cs [Design]**), and then open the **Dialogs** group in the **Toolbox**.

    > [!NOTE]
    > The **Dialogs** group in the **Toolbox** has components that open many useful dialog boxes for you, which can be used for opening and saving files, browsing folders, and choosing fonts and colors. You use two dialog components in this project: OpenFileDialog and ColorDialog.

1. To add a component called **openFileDialog1** to your form, double-click **OpenFileDialog**. To add a component called **colorDialog1** to your form, double-click **ColorDialog** in the **Toolbox**. (You use that one in the next tutorial step.) You should see an area at the bottom of **Windows Forms Designer** (beneath the **Picture Viewer** form) that has an icon for each of the two dialog components that you added, as shown in the following image.

     ![Dialog components](../ide/media/express_dialogsadded.png)<br>***Dialog*** *components*

1. Choose the **openFileDialog1** icon in the area at the bottom of the **Windows Forms Designer**. Set two properties:

    - Set the **Filter** property to the following (you can copy and paste it):

        ```
        JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*
        ```

    - Set the **Title** property to the following: **Select a picture file**

         The **Filter** property settings specify the kinds of file types that will display in the **Select a picture** file dialog box.

    > [!TIP]
    > To see an example of the **Open File** dialog box in a different application, open **Notepad** or **Paint**, and on the menu bar, choose **File** > **Open**. Notice how there's a drop-down list next to the file name that lets you choose the file type. <br/><br/>You just used the **Filter** property in the **OpenFileDialog** component to set that up in your app. Also, notice how the **Title** and **Filter** properties are bold in the **Properties** window. The IDE does that to show you any properties that have been changed from their default values.

## Next steps

* To go to the next tutorial step, see **[Step 8: Write code for the show a picture button event handler](../ide/step-8-write-code-for-the-show-a-picture-button-event-handler.md)**.

* To return to the previous tutorial step, see [Step 6: Name your button controls](../ide/step-6-name-your-button-controls.md).

## See also

* [Tutorial 2: Create a timed math quiz](tutorial-2-create-a-timed-math-quiz.md)
* [Tutorial 3: Create a matching game](tutorial-3-create-a-matching-game.md)
