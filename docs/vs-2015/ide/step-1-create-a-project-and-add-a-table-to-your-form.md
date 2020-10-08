---
title: "Step 1: Create a Project and Add a Table to Your Form | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: 1cac4ba4-f3cd-43bd-ad5d-50fc599234e8
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# Step 1: Create a Project and Add a Table to Your Form
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The first step in creating a matching game is to create the project and add a table to your form. The table helps align the icons into an orderly 4x4 grid. You also set several properties to enhance the appearance of the game board.

### To create a project and add a table to your form

1. On the menu bar, choose **File**, **New**, **Project**.

2. If you’re not using Visual Studio Express, you need to select a programming language first. From the **Installed Templates** list, choose either **Visual C#** or **Visual Basic**.

3. In the list of project templates, choose **Windows Forms Application**, name the project **MatchingGame**, and then choose the **OK** button.

4. In the **Properties** window, set the following form properties.

   1. Change the form's **Text** property from **Form1** to **Matching Game**. This text appears at the top of the game window.

   2. Set the size of the form to 550 pixels wide by 550 tall. You can do this either by setting the **Size** property to **550, 550**, or by dragging the corner of the form until you see the correct size in the lower-right corner of the integrated development environment (IDE).

5. Display the toolbox by choosing the **Toolbox** tab on the left side of the IDE.

6. Drag a `TableLayoutPanel` control from the **Containers** category in the toolbox, and then set the following properties for it.

   1. Set the **BackColor** property to **CornflowerBlue**. To do this, open the **BackColor** dialog box by choosing the drop-down arrow next to the **BackColor** property in the **Properties** window.  Then, choose the **Web** tab in the **BackColor** dialog box to view a list of available color names.

      > [!NOTE]
      > The colors are not in alphabetical order, and CornflowerBlue is near the bottom of the list.

   2. Set the **Dock** property to **Fill** by choosing the drop-down button next to the property and choosing the large middle button. This spreads the table out so that it covers the entire form.

   3. Set the **CellBorderStyle** property to **Inset**. This provides visual borders between each cell on the board.

   4. Choose the triangle button in the upper-right corner of the TableLayoutPanel to display its task menu.

   5. On the task menu, choose **Add Row** twice to add two more rows, and then choose **Add Column** twice to add two more columns.

   6. On the task menu, choose **Edit Rows and Columns** to open the **Column and Row Styles** window. Choose each of the columns, choose the **Percent** option button, and then set each column's width to 25 percent of the total width. Then select **Rows** from the drop-down box at the top of the window, and set each row's height to 25 percent. When you're done, choose the **OK** button.

      Your TableLayoutPanel should now be a 4x4 grid, with sixteen equally sized square cells. These rows and columns are where the icon images will appear later.

7. Be certain that the TableLayoutPanel is selected in the form editor. To verify this, you should see **tableLayoutPanel1** at the top of the **Properties** window. If it is not selected, choose the TableLayoutPanel on the form, or choose it in the dropdown control at the top of the **Properties** window.

    While the TableLayoutPanel is selected, open the toolbox and add a **Label** control (located in the **Common Controls** category) to the upper-left cell of the TableLayoutPanel. The `Label` control should now be selected in the IDE. Set the following properties for it.

   1. Be sure that the label's **BackColor** property is set to **CornflowerBlue**.

   2. Set the **AutoSize** property to **False**.

   3. Set the **Dock** property to **Fill**.

   4. Set the **TextAlign** property to **MiddleCenter** by choosing the drop-down button next to the property, and then choosing the middle button. This ensures the icon appears in the middle of the cell.

   5. Choose the **Font** property. An ellipsis (…) button should appear.

   6. Choose the ellipsis button, and set the **Font** value to **Webdings**, the **Font Style** to **Bold**, and the **Size** to **72**.

   7. Set the **Text** property of the label to the letter **c**.

        The upper-left cell in the TableLayoutPanel should now contain a black box centered on a blue background.

       > [!NOTE]
       > The Webdings font is a font of icons that ships with the Windows operating system. In your matching game, the player needs to match pairs of icons, so you use this font to display the icons to match. Instead of putting **c** in the **Text** property, try entering different letters to see what icons are displayed. An exclamation point is a spider, an uppercase N is an eye, and a comma is a chili pepper.

8. Choose your label control and copy it to the next cell in the TableLayoutPanel. (Choose the Ctrl+C keys, or on the menu bar, choose **Edit**, **Copy**.) Then paste it. (Choose the Ctrl+V keys, or on the menu bar, choose **Edit**, **Paste**.) A copy of the first label appears in the second cell of the TableLayoutPanel. Paste it again, and another label appears in the third cell. Keep pasting `Label` controls until all of the cells are filled.

   > [!NOTE]
   > If you paste too many times, the IDE adds a new row to the TableLayoutPanel so that it has a place to add your new label control. You can undo it. To remove the new cell, choose the Ctrl+Z keys, or on the menu bar, choose **Edit**, **Undo**.

    Now your form is laid out. It should look like the following picture.

    ![Initial matching game form](../ide/media/express-tut4step1.png "Express_Tut4Step1")
   Initial matching game form

### To continue or review

- To go to the next tutorial step, see [Step 2: Add a Random Object and a List of Icons](../ide/step-2-add-a-random-object-and-a-list-of-icons.md).

- To return to the overview topic, see [Tutorial 3: Create a Matching Game](../ide/tutorial-3-create-a-matching-game.md).
