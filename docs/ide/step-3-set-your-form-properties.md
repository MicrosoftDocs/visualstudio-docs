---
title: 'Step 3: Set your form properties'
description: Learn how to use the Properties window to change the way your form looks.
ms.custom: SEO-VS-2020
ms.date: 08/30/2019
ms.assetid: 634ef037-1525-48c8-ac7f-abf04be69376
ms.topic: tutorial
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Step 3: Set your form properties

Next, you use the **Properties** window to change the way your form looks.

## How to set your form properties

1. Be sure you're looking at **Windows Forms Designer**. In the Visual Studio integrated development environment (IDE), choose the **Form1.cs [Design]** tab (or the **Form1.vb [Design]** tab in Visual Basic).

1. Choose anywhere inside the form **Form1** to select it. Look at the **Properties** window, which should now be showing the properties for the form. Forms have various properties. For example, you can set the foreground and background color, title text that appears at the top of the form, size of the form, and other properties.

   > [!NOTE]
   > If the **Properties** window doesn't appear, stop your app by choosing the square **Stop Debugging** button on the toolbar, or just close the window. If the app is stopped and you still don't see the **Properties** window, on the menu bar, choose **View** > **Properties Window**.

1. After the form is selected, find the **Text** property in the **Properties** window. Depending on how the list is sorted, you might need to scroll down. Choose **Text**, type **Picture Viewer**, and then choose **Enter**.  Your form should now have the text **Picture Viewer** in its title bar, and the **Properties** window should look similar to the following screenshot.

    ![Properties window](../ide/media/express_edittextproperty.png)<br>
   ***Properties*** *window*

   > [!NOTE]
   > Properties can be ordered by a **Categorized** or **Alphabetical** view. You can switch between these two views by using the buttons on the **Properties** window. In this tutorial, it's easier to find properties through the **Alphabetical** view.

1. Go back to **Windows Forms Designer**. Choose the form's lower-right drag handle, which is the small white square in the lower-right of the form and appears as follows.

    ![Drag handle](../ide/media/express_bottomrt_drag.png)<br>
   *Drag handle*

    Drag the handle to resize the form so the form is wider and a bit taller.

1. Look at the **Properties** window, and notice that the **Size** property has changed. The **Size** property changes each time you resize the form. Try dragging the form's handle to resize it to a form size of approximately **550, 350** (no need to be exact), which should work well for this project. As an alternative, you can enter the values directly in the **Size** property and then choose the **Enter** key.

1. Run your app again. Remember, you can use any of the following methods to run your app.

   - Choose the **F5** key.

   - On the menu bar, choose **Debug** > **Start Debugging**.

   - On the toolbar, choose the **Start Debugging** button, which appears as follows.

      ![Start Debugging toolbar button](../ide/media/express_icondebug.png)<br>
     ***Start Debugging*** *toolbar button*

     Just like before, the IDE builds and runs your app, and a window appears.

1. Before going to the next step, stop your app, because the IDE won't let you change your app while it's running. Remember, you can use any of the following methods to stop your app.

   - On the toolbar, choose the **Stop Debugging** button.

   - On the menu bar, choose **Debug** > **Stop Debugging**.

   - Use your keyboard and press **Shift**+**F5**.

   - Choose the **X** button in the upper corner of the **Picture Viewer** window.

## Next steps

* To go to the next tutorial step, see **[Step 4: Lay out your form with a TableLayoutPanel control](../ide/step-4-lay-out-your-form-with-a-tablelayoutpanel-control.md)**.

* To return to the previous tutorial step, see [Step 2: Run your picture viewer app](../ide/step-2-run-your-program.md).

## See also

* [Tutorial 2: Create a timed math quiz](tutorial-2-create-a-timed-math-quiz.md)
* [Tutorial 3: Create a matching game](tutorial-3-create-a-matching-game.md)
