---
title: 'Lay out your form with a TableLayoutPanel control'
description: Lay out your form with a TableLayoutPanel control in the create a picture viewer tutorial. 
ms.date: 08/30/2019
ms.custom: SEO-VS-2020
ms.assetid: 61acde79-e115-4bad-bb06-1fbe37717a3e
ms.topic: tutorial
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Step 4: Lay out your form with a TableLayoutPanel control

In this step, you add a <xref:System.Windows.Forms.TableLayoutPanel> control to your form. The TableLayoutPanel helps properly align controls in the form that you'll add later.

## How to lay out your form with a TableLayoutPanel control

1. On the left side of the Visual Studio IDE, choose the **Toolbox** tab. (Alternatively, choose **View** > **Toolbox** from the menu bar, or press **Ctrl**+**Alt**+**X**.)

1. Choose the small triangle symbol next to the **Containers** group to open it, as shown in the following screenshot.

     ![Containers group](../ide/media/express_toolbox.png)<br>
***Containers*** *group*

1. You can add controls like buttons, check boxes, and labels to your form. Double-click the TableLayoutPanel control in the **Toolbox**. (Or, you can drag the control from the toolbox onto the form.) When you do this, the IDE adds a TableLayoutPanel control to your form, as shown in the following screenshot.

     ![TableLayoutPanel control](../ide/media/express_formtablelayout.png)<br>
***TableLayoutPanel*** *control*

    > [!NOTE]
    > After you add your TableLayoutPanel, if a window appears inside your form with the title **TableLayoutPanel Tasks**, choose anywhere inside the form to close it. You'll learn more about this window later in the tutorial.

     Notice how the **Toolbox** expands to cover your form when you choose its tab, and closes after you choose anywhere outside of it. That's the Auto Hide feature in the IDE. You can turn it on or off for any of the windows by choosing the pushpin icon in the upper-right corner of the window to toggle Auto Hide and lock it in place. The pushpin icon appears as follows.

     ![Pushpin icon](../ide/media/express_pushpintoolbox.png)<br>
***Pushpin*** *icon*

1. Be sure the TableLayoutPanel is selected by choosing it. You can verify what control is selected by looking at the drop-down list at the top of the **Properties** window, as shown in the following screenshot.

     ![Properties window showing TableLayoutPanel control](../ide/media/express_controlspropwin.png)<br>
***Properties*** *window showing* ***TableLayoutPanel*** *control*

1. Choose the **Alphabetical** button on the toolbar in the **Properties** window. This sorts the list of properties in the **Properties** window in alphabetical order, which makes it easier to locate properties in this tutorial.

1. The control selector is a drop-down list at the top of the **Properties** window. In this example, it shows that a control called `tableLayoutPanel1` is selected. You can select controls either by choosing an area in **Windows Forms Designer** or by choosing from the control selector.

   Now that the TableLayoutPanel is selected, find the **Dock** property and choose **Dock**, which should be set to **None**. Notice that a drop-down arrow appears next to the value. Choose the arrow, and then select the **Fill** button (the large button in the middle), as shown in the following screenshot.

     ![Properties window with Fill selected](../ide/media/express_docktable.png)<br>
***Properties*** *window with* ***Fill*** *selected*

     *Docking* in Visual Studio refers to when a window is attached to another window or area in the IDE. For example, the **Properties** window can be undocked&mdash;that is, unattached and free-floating within Visual Studio&mdash;or it can be docked against **Solution Explorer**.

1. After you set the TableLayoutPanel **Dock** property to **Fill**, notice that the panel fills the entire form. If you resize the form again, the TableLayoutPanel stays docked, and resizes itself to fit.

    > [!NOTE]
    > A TableLayoutPanel works like a table in Microsoft Office Word: It has rows and columns, and an individual cell can span multiple rows and columns. Each cell can hold one control (like a button, a check box, or a label). Your TableLayoutPanel should have a <xref:System.Windows.Forms.PictureBox> control spanning its entire top row, a <xref:System.Windows.Forms.CheckBox> control in its lower-left cell, and four <xref:System.Windows.Forms.Button> controls in its lower-right cell.

1. Currently, the TableLayoutPanel has two equal-size rows and two equal-size columns. Let's resize them so the top row and right column are both much bigger. In **Windows Forms Designer**, select the TableLayoutPanel. In the upper-right corner, there is a small black triangle button, which appears as follows.

     ![Triangle button](../ide/media/express_iconblacktriangle.gif)<br>
***Triangle*** *button*

     This button indicates that the control has tasks that help you set its properties automatically.

1. Choose the triangle to display the control's task list, as shown in the following screenshot.

     ![TableLayoutPanel tasks](../ide/media/express_tablepanel.png)<br>
***TableLayoutPanel*** *tasks*

1. Choose the **Edit Rows and Columns** task to display the **Column and Row Styles** window. Choose **Column1**, and set its size to 15 percent by being sure the **Percent** button is selected and entering **15** in the **Percent** box. (That's a <xref:System.Windows.Forms.NumericUpDown> control, which you'll use in a later tutorial.) Choose **Column2** and set it to 85 percent. Don't choose the **OK** button yet, because the window will close. (But if you do, you can reopen it by using the task list.)

     ![TableLayoutPanel column and row styles](../ide/media/vs_tablelayoutpanel_setup.png)<br>
***TableLayoutPanel*** *column and row styles*

1. From the **Show** drop-down list at the top of the **Column and Row Styles** window, choose **Rows**. Set **Row1** to 90 percent and **Row2** to 10 percent.

1. Choose the **OK** button. Your TableLayoutPanel should now have a large top row, a small bottom row, a small left column, and a large right column. (You can resize the rows and columns in the TableLayoutPanel by choosing **tableLayoutPanel1** in the form and then dragging its row and column borders.)

     ![Form1 with resized TableLayoutPanel](../ide/media/vs_formafterlayoutpanel.png)<br>
***Form1*** *(Picture Viewer) with resized* ***TableLayoutPanel***

## Next steps

* To go to the next tutorial step, see **[Step 5: Add controls to your form](../ide/step-5-add-controls-to-your-form.md)**.

* To return to the previous tutorial step, see [Step 3: Set your form properties](../ide/step-3-set-your-form-properties.md).

## See also

* [Tutorial 2: Create a timed math quiz](tutorial-2-create-a-timed-math-quiz.md)
* [Tutorial 3: Create a matching game](tutorial-3-create-a-matching-game.md)
