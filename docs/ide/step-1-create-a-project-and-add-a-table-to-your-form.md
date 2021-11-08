---
title: 'Step 1: Create a project and add a table to your form'
description: Learn how to create the Matching Game project and add a table to your form.
ms.custom: SEO-VS-2020
ms.date: 10/15/2019
ms.topic: tutorial
ms.assetid: 1cac4ba4-f3cd-43bd-ad5d-50fc599234e8
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Step 1: Create a project and add a table to your form

The first step in creating a matching game is to create the project and add a table to your form. The table helps align the icons into an orderly 4x4 grid. You also set several properties to enhance the appearance of the game board.

## To create a project and add a table to your form

::: moniker range="vs-2017"

1. On the menu bar, choose **File** > **New** > **Project**.

1. Choose either **Visual C#** or **Visual Basic** on the left side of the **New Project** dialog box, and then choose **Windows Desktop**.

1. In the list of templates, choose the **Windows Forms App (.NET Framework)** template, name it *MatchingGame*, and then choose the **OK** button.

    A form that's named *Form1.cs* or *Form1.vb* appears, depending on the programming language that you chose.

   > [!NOTE]
   > If you don't see the **Windows Forms App (.NET Framework)** template, use the Visual Studio Installer to install the **.NET desktop development** workload.<br/><br/>![.NET desktop development workload in the Visual Studio Installer](../ide/media/dot-net-desktop-dev-workload.png)<br/><br/> For more information, see the [Install Visual Studio](../install/install-visual-studio.md) page.

::: moniker-end

::: moniker range=">=vs-2019"

1. On the start window, choose **Create a new project**.

   ![View the 'Create a new project' window](../get-started/media/vs-2019/create-new-project-dark-theme.png)

1. On the **Create a new project** window, enter or type *Windows Forms* in the search box. Next, choose **Desktop** from the **Project type** list.

   After you apply the **Project type** filter, choose the **Windows Forms App (.NET Framework)** template for either C# or Visual Basic, and then choose **Next**.

   ![Choose the either the C# or Visual Basic template for the Windows Forms App (.NET Framework)](./media/create-new-project-search-winforms-filtered.png)

   > [!NOTE]
   > If you do not see the **Windows Forms App (.NET Framework)** template, you can install it from the **Create a new project** window. In the **Not finding what you're looking for?** message, choose the **Install more tools and features** link.
   >
   > ![The 'Install more tools and features' link from the 'Not finding what you're looking for' message in the 'Create new project' window](../get-started/media/vs-2019/not-finding-what-looking-for.png)
   >
   > Next, in the Visual Studio Installer, choose the **.NET desktop development** workload.
   >
   > ![.NET Core workload in the Visual Studio Installer](../ide/media/install-dot-net-desktop-env.png)
   >
   > After that, choose the **Modify** button in the Visual Studio Installer. You might be prompted to save your work; if so, do so. Next, choose **Continue** to install the workload.

1. In the **Configure your new project** window, type or enter *MatchingGame* in the **Project name** box. Then, choose **Create**.

::: moniker-end

## To set properties for a form

1. In the **Properties** window, set the following form properties.

   1. Change the form's **Text** property from **Form1** to **Matching Game**. This text appears at the top of the game window.

   2. Set the size of the form to 550 pixels wide by 550 tall. You can do this either by setting the **Size** property to **550, 550**, or by dragging the corner of the form until you see the correct size in the lower-right corner of the integrated development environment (IDE).

2. Display the toolbox by choosing the **Toolbox** tab on the left side of the IDE.

3. Drag a <xref:System.Windows.Forms.TableLayoutPanel> control from the **Containers** category in the toolbox, and then set the following properties for it.

   1. Set the **BackColor** property to **CornflowerBlue**. To do this, open the **BackColor** dialog box by choosing the drop-down arrow next to the **BackColor** property in the **Properties** window.  Then, choose the **Web** tab in the **BackColor** dialog box to view a list of available color names.

      > [!NOTE]
      > The colors are not in alphabetical order, and **CornflowerBlue** is near the bottom of the list.

   2. Set the **Dock** property to **Fill** by choosing the drop-down button next to the property and choosing the large middle button. This spreads the table out so that it covers the entire form.

   3. Set the **CellBorderStyle** property to **Inset**. This provides visual borders between each cell on the board.

   4. Choose the triangle button in the upper-right corner of the TableLayoutPanel to display its task menu.

   5. On the task menu, choose **Add Row** twice to add two more rows, and then choose **Add Column** twice to add two more columns.

   6. On the task menu, choose **Edit Rows and Columns** to open the **Column and Row Styles** window. Choose each of the columns, choose the **Percent** option button, and then set each column's width to 25 percent of the total width. Then select **Rows** from the drop-down box at the top of the window, and set each row's height to 25 percent. When you're done, choose the **OK** button.

      Your TableLayoutPanel should now be a 4x4 grid, with sixteen equally sized square cells. These rows and columns are where the icon images will appear later.

4. Be certain that the TableLayoutPanel is selected in the form editor. To verify this, you should see **tableLayoutPanel1** at the top of the **Properties** window. If it is not selected, choose the TableLayoutPanel on the form, or choose it in the dropdown control at the top of the **Properties** window.

    While the TableLayoutPanel is selected, open the toolbox and add a <xref:System.Windows.Forms.Label> control (located in the **Common Controls** category) to the upper-left cell of the TableLayoutPanel. The label control should now be selected in the IDE. Set the following properties for it.

   1. Be sure that the label's **BackColor** property is set to **CornflowerBlue**.

   2. Set the **AutoSize** property to **False**.

   3. Set the **Dock** property to **Fill**.

   4. Set the **TextAlign** property to **MiddleCenter** by choosing the drop-down button next to the property, and then choosing the middle button. This ensures the icon appears in the middle of the cell.

   5. Choose the **Font** property. An ellipsis (**...**) button should appear.

   6. Choose the ellipsis button, and set the **Font** value to **Webdings**, the **Font Style** to **Bold**, and the **Size** to **48**.

   7. Set the **Text** property of the label to the letter **c**.

        The upper-left cell in the TableLayoutPanel should now contain a black box centered on a blue background.

       > [!NOTE]
       > The Webdings font is a font of icons that ships with the Windows operating system. In your matching game, the player needs to match pairs of icons, so you use this font to display the icons to match. Instead of putting **c** in the **Text** property, try entering different letters to see what icons are displayed. An exclamation point is a spider, an uppercase N is an eye, and a comma is a chili pepper.

5. Choose your Label control and copy it to the next cell in the TableLayoutPanel. (Choose the **Ctrl**+**C** keys, or on the menu bar, choose **Edit** > **Copy**.) Then paste it. (Choose the **Ctrl**+**V** keys, or on the menu bar, choose **Edit** > **Paste**.) A copy of the first Label appears in the second cell of the TableLayoutPanel. Paste it again, and another Label appears in the third cell. Keep pasting Label controls until all of the cells are filled.

   > [!NOTE]
   > If you paste too many times, the IDE adds a new row to the TableLayoutPanel so that it has a place to add your new Label control. You can undo it. To remove the new cell, choose the **Ctrl**+**Z** keys, or on the menu bar, choose **Edit** > **Undo**.

    Now your form is laid out. It should look similar to the following picture.

    ![Initial matching game form](../ide/media/express_tut4step1.png)<br/>*Initial matching game form*

## To continue or review

- To go to the next tutorial step, see [Step 2: Add a Random object and a list of icons](../ide/step-2-add-a-random-object-and-a-list-of-icons.md).

- To return to the overview topic, see [Tutorial 3: Create a matching game](../ide/tutorial-3-create-a-matching-game.md).
