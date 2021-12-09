---
title: 'Step 5: Add controls to your form'
description: Learn how to add controls, such as a <xref:System.Windows.Forms.PictureBox> control and a <xref:System.Windows.Forms.CheckBox> control, to your form.
ms.custom: SEO-VS-2020
ms.date: 08/30/2019
ms.assetid: dc2746f4-0b5c-4674-9ef7-f40f94150f52
ms.topic: tutorial
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Step 5: Add controls to your form

In this step, you add controls, such as a <xref:System.Windows.Forms.PictureBox> control and a <xref:System.Windows.Forms.CheckBox> control, to your form. You then add <xref:System.Windows.Forms.Button> controls to your form.

## How to add controls to your form

1. Choose the **Toolbox** tab on the left side of the Visual Studio IDE (or press **Ctrl**+**Alt**+**X**), and then expand the **Common Controls** group. This shows the most common controls that you see on forms.

1. Double-click the **PictureBox** item to add a PictureBox control to your form. Because the TableLayoutPanel is docked to fill your form, the IDE adds the PictureBox control to the first empty cell (the upper left corner).

1. Choose the new **PictureBox** control to select it, and then choose the black triangle on the new PictureBox control to display its task list, as shown in the following screenshot.

    ![PictureBox tasks](../ide/media/express_pictureboxtasks.png)<br/>****PictureBox*** *tasks**

    > [!NOTE]
    > If you accidentally add the wrong type of control to your TableLayoutPanel, you can delete it. Right-click the control, and then choose **Delete** on its context menu. You can also remove controls from the form by using the menu bar. On the menu bar, choose **Edit** > **Undo**, or **Edit** > **Delete**.

1. In the **PictureBox Tasks** menu from the **PictureBox** control, choose the **Dock in parent container** link. This automatically sets the PictureBox **Dock** property to **Fill**. To see this, choose the **PictureBox** control to select it, go to the **Properties** window, and be sure that the **Dock** property is set to **Fill**.

1. Make the PictureBox span both columns by changing its **ColumnSpan** property. In the **PictureBox**, choose the **PictureBox** control and set its **ColumnSpan** property to **2**. Also, when the PictureBox is empty, you want to show an empty frame. Set its **BorderStyle** property to **Fixed3D**.

    > [!NOTE]
    > If you don't see a **ColumnSpan** property for your PictureBox, then it's likely that the PictureBox was added to the form rather than the TableLayoutPanel. To fix this, choose the **PictureBox**, delete it, choose the **TableLayoutPanel**, and then add a new PictureBox.

1. Choose the **TableLayoutPanel** on the form and then add a CheckBox control to the form. Double-click the **CheckBox** item in the **Toolbox** to add a new CheckBox control to the next free cell in your table. Because a PictureBox takes up the first two cells in the TableLayoutPanel, the CheckBox control is added to the lower-left cell. Choose the **Text** property and type in the word **Stretch**, as shown in the following image.

    ![TextBox control with Stretch property](../ide/media/express_pictureviewercheckbox.png)<br/>***TextBox*** *control with* ***Stretch*** *property*

1. Choose the **TableLayoutPanel** on the form, and then go to the **Containers** group in the **Toolbox** (where you got your TableLayoutPanel control) and double-click the **FlowLayoutPanel** item to add a new control to the last cell (bottom right). Then, dock the FlowLayoutPanel in the TableLayoutPanel. You can do so either by choosing **Dock in parent container** on the FlowLayoutPanel's black triangle task list, or by setting the FlowLayoutPanel's **Dock** property to **Fill**.

    > [!NOTE]
    > A <xref:System.Windows.Forms.FlowLayoutPanel> is a container that arranges other controls in a row, one after another. When you resize a FlowLayoutPanel, it lays out all of its controls in a single row, if it has room to do so. Otherwise, it arranges them in lines, one on top of the other. <br/><br/>Here, you'll use a FlowLayoutPanel to hold four buttons. If the buttons arrange one on top another when you add them, make sure that you select the FlowLayoutPanel before you add the buttons. <br/><br/>(Typically, each cell contains only one control. In this example, the lower-right cell of the TableLayoutPanel contains four button controls. Why?  Because the FlowLayoutPanel is a container control, which is a control in a cell that holds other controls.)

## To add buttons

1. Choose the new FlowLayoutPanel that you added. Go to **Common Controls** in the **Toolbox** and double-click the **Button** item to add a button control called **button1** to your FlowLayoutPanel. Repeat to add another button. The IDE determines that there's already a button called **button1** and calls the next one **button2**.

1. Typically, you add the other buttons by using the **Toolbox**. This time, choose **button2**, and then from the menu bar, choose **Edit** > **Copy** (or press **Ctrl**+**C**). Next, choose **Edit** > **Paste** from the menu bar (or press **Ctrl**+**V**) to paste a copy of your button. Now paste it again. Notice that the IDE adds **button3** and **button4** to the FlowLayoutPanel.

    > [!NOTE]
    > You can copy and paste any control. The IDE names and places the new controls in a logical manner. If you paste a control into a container, the IDE chooses the next logical space for placement.

1. Choose the first button and set its **Text** property to **Show a picture**. Then set the **Text** properties of the next three buttons to **Clear the picture**, **Set the background color**, and **Close**.

1. Let's size the buttons and arrange them so they align to the right side of the panel. Choose the **FlowLayoutPanel** and look at its **FlowDirection** property. Change it so it's set to **RightToLeft**.

   The buttons should align themselves to the right side of the cell, and reverse their order so that the **Show a picture** button is on the right.

    > [!NOTE]
    > If the buttons are still in the wrong order, you can drag the buttons around the FlowLayoutPanel to rearrange them in any order. You can choose a button and drag it left or right.

1. Choose the **Close** button to select it. Then, to choose the rest of the buttons at the same time, press and hold the **Ctrl** key and choose them, too.

   After you've selected all the buttons, go to the **Properties** window and scroll up to the **AutoSize** property. This property tells the button to automatically resize itself to fit all of its text. Set it to **True**.

   Your buttons should now be sized properly and be in the right order. (As long as all four buttons are selected, you can change all four **AutoSize** properties at the same time.) The following image shows the four buttons.

    ![Picture Viewer with four buttons](../ide/media/express_autosize.png)<br/>***Picture Viewer*** *with four buttons*

1. Now run your program again to see your changes.

   Notice that the buttons and the check box don't do anything yet&mdash;but they will, soon.

## To continue or review

* To go to the next tutorial step, see **[Step 6: Name your button controls](../ide/step-6-name-your-button-controls.md)**.

* To return to the previous tutorial step, see [Step 4: Lay out your form with a TableLayoutPanel control](../ide/step-4-lay-out-your-form-with-a-tablelayoutpanel-control.md).

## See also

* [Tutorial 2: Create a timed math quiz](tutorial-2-create-a-timed-math-quiz.md)
* [Tutorial 3: Create a matching game](tutorial-3-create-a-matching-game.md)
