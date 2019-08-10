---
title: Windows Forms Designer tutorial
ms.date: 08/09/2019
ms.topic: conceptual
helpviewer_keywords:
  - "Windows Forms Designer, get started"
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Walkthrough: Get started with Windows Forms Designer

The Windows Forms Designer provides many tools for building Windows Forms applications. This article illustrates how to build an application using the various tools provided by the designer. Tasks illustrated in this walkthrough include:

- Creating a Windows Forms project.
- Arranging controls using snaplines.
- Accomplishing designer tasks using smart tags.
- Setting margins and padding for your controls.
- Arranging controls using a [TableLayoutPanel]()) control.
- Partitioning your control’s layout by using a [SplitContainer]() control.
- Navigating your layout with the Document Outline window.
- Positioning controls with the size and location information display.
- Setting property values using the Properties window.

When you're finished, you'll have a custom control that has been assembled using many of the layout features available in the Windows Forms Designer. This control implements the user interface (UI) for a simple calculator. The following screen shot shows the general layout of the calculator control.

Calculator UI

![Guided Tour Calculator UI](images/9ew6tzdt.TourCalulator(en-us,VS.100).gif)

## Create the custom control project

The first step is to create the DemoCalculator control project.

1. On the **File** menu, point to **New**, and then click **Project** to open the **New Project** dialog box.

2. From the list of Visual Basic or Visual C\# projects in the **Windows** category, select the **Windows Forms Control Library** project template.

3. In the **Name** box, type DemoCalculatorLib and then click **OK**.

4. In Solution Explorer, right-click **UserControl1.vb** or **UserControl1.cs**, and then click **Rename**.

5. Change the file name to DemoCalculator.vb or DemoCalculator.cs. Click the **Yes** button when you are asked if you want to rename all references to the code element "UserControl1".

   The Windows Forms Designer currently shows the designer surface for the DemoCalculator control. In this view, you can graphically design the appearance of your control by selecting controls and components from the Toolbox and placing them on the designer surface. For more information on custom controls, see [Varieties of Custom Controls](ms171725\(v=vs.100\).md).

## Design the control layout

The DemoCalculator control contains several Windows Forms controls. In this procedure, you will arrange the controls using some of the rapid application development (RAD) features of the Windows Forms Designer.

1. In the Windows Forms Designer, change the DemoCalculator control to a larger size by clicking the sizing handle in the lower-right corner and dragging it down and to the right. In the lower-right corner of Visual Studio, find the size and location information for controls. Set the size of the control to a width of 500 and a height of 400 by watching the size information as you resize the control.

2. In the Toolbox, click the **Containers** node to open it. Select the [SplitContainer](https://msdn.microsoft.com/en-us/library/hb802c99\(v=vs.100\)) control and drag it onto the designer surface.

    The [SplitContainer](https://msdn.microsoft.com/en-us/library/hb802c99\(v=vs.100\)) is placed on the DemoCalculator control's designer surface.

    > [!NOTE]
    > <P>The <A href="https://msdn.microsoft.com/en-us/library/hb802c99(v=vs.100)">SplitContainer</A> control sizes itself to the fit the size of the DemoCalculator control. Examine the Properties window to see the property settings for the <A href="https://msdn.microsoft.com/en-us/library/hb802c99(v=vs.100)">SplitContainer</A> control. Find the <A href="https://msdn.microsoft.com/en-us/library/77cb86s0(v=vs.100)">Dock</A> property. Its value is <A href="https://msdn.microsoft.com/en-us/library/bb462410(v=vs.100)">Fill</A>, which means the <A href="https://msdn.microsoft.com/en-us/library/hb802c99(v=vs.100)">SplitContainer</A> control will always size itself to the boundaries of the DemoCalculator control. Resize the DemoCalculator control to verify this behavior.</P>

3. In the Properties window, change the value of the [Dock](https://msdn.microsoft.com/en-us/library/77cb86s0\(v=vs.100\)) property to [None](https://msdn.microsoft.com/en-us/library/bb460467\(v=vs.100\)).

    The [SplitContainer](https://msdn.microsoft.com/en-us/library/hb802c99\(v=vs.100\)) control shrinks to its default size. Its size no longer follows the size of the DemoCalculator control.

4. Click the smart tag glyph (![Smart Tag Glyph](images/ms171567.VS_WinFormSmtTagGlyph(en-us,VS.100).gif "Smart Tag Glyph")) on the upper-right corner of the [SplitContainer](https://msdn.microsoft.com/en-us/library/hb802c99\(v=vs.100\)) control. Click **Dock in Parent Container** to set the [Dock](https://msdn.microsoft.com/en-us/library/77cb86s0\(v=vs.100\)) property to [Fill](https://msdn.microsoft.com/en-us/library/bb462410\(v=vs.100\)).

    The [SplitContainer](https://msdn.microsoft.com/en-us/library/hb802c99\(v=vs.100\)) control docks to the DemoCalculator control's boundaries.

    > [!NOTE]
    > <P>Several controls offer smart tags to facilitate design. For more information, see <A href="xhz359sc(v=vs.100).md">Walkthrough: Performing Common Tasks Using Smart Tags on Windows Forms Controls</A>.</P>

5. Click the vertical border between the panels and drag it to the right, so that most of the space in taken by the left panel.

    The [SplitContainer](https://msdn.microsoft.com/en-us/library/hb802c99\(v=vs.100\)) divides the DemoCalculator control into two panels, with a movable border separating them. The panel on the left will hold the calculator buttons and display, and the panel on the right will show a record of the arithmetic operations performed by the user.

6. In the Properties window, change the value of the [BorderStyle](https://msdn.microsoft.com/en-us/library/t0f1zat8\(v=vs.100\)) property to [Fixed3D](https://msdn.microsoft.com/en-us/library/bb506917\(v=vs.100\)).

7. In the Toolbox, click the **Common Controls** node to open it. Select the [ListView](https://msdn.microsoft.com/en-us/library/s2edxtd5\(v=vs.100\)) control and drag it into the right panel of the [SplitContainer](https://msdn.microsoft.com/en-us/library/hb802c99\(v=vs.100\)) control.

8. Click the [ListView](https://msdn.microsoft.com/en-us/library/s2edxtd5\(v=vs.100\)) control's smart tag glyph. In the smart tag panel, change the [View](https://msdn.microsoft.com/en-us/library/b8x9sd22\(v=vs.100\)) setting to [Details](https://msdn.microsoft.com/en-us/library/2zt7996a\(v=vs.100\)).

9. In the smart tag panel, click **Edit Columns**.

    The **ColumnHeader Collection Editor** dialog box opens.

10. In the **ColumnHeader Collection Editor** dialog box, click the **Add** button to add a column to the [ListView](https://msdn.microsoft.com/en-us/library/s2edxtd5\(v=vs.100\)) control. Change the value of the column's [Text](https://msdn.microsoft.com/en-us/library/1x029774\(v=vs.100\)) property to History. Click **OK** to create the column.

11. In the smart tag panel, click **Dock in Parent Container**, and then click the smart tag glyph to close the smart tag panel.

12. From the **Containers** node in the Toolbox, drag a [TableLayoutPanel](https://msdn.microsoft.com/en-us/library/2t82c7dk\(v=vs.100\)) control into the left panel of the [SplitContainer](https://msdn.microsoft.com/en-us/library/hb802c99\(v=vs.100\)) control.

    The [TableLayoutPanel](https://msdn.microsoft.com/en-us/library/2t82c7dk\(v=vs.100\)) control appears on the designer surface with its smart tag panel open. The [TableLayoutPanel](https://msdn.microsoft.com/en-us/library/2t82c7dk\(v=vs.100\)) control arranges its child controls in a grid. For more information, see [Walkthrough: Arranging Controls on Windows Forms Using a TableLayoutPanel](w4yc3e8c\(v=vs.100\).md). The [TableLayoutPanel](https://msdn.microsoft.com/en-us/library/2t82c7dk\(v=vs.100\)) control will hold the DemoCalculator control's display and buttons.

13. Click **Edit Rows and Columns** on the smart tag panel.

    The **Column and Row Styles** dialog box opens.

14. Click the **Add** button until five columns are displayed. Select all five columns, and then click the **Percent** option button in the **Size Type** box. Set the **Percent** value to 20. This sets each column to the same width.

15. In the **Show** drop-down box, click **Rows**.

16. Click the **Add** button until five rows are displayed. Select all five rows, and the click the **Percent** option button in the **Size Type** box. Set the **Percent** value to 20. This sets each row to the same height.

17. Click **OK** to accept your changes, and then click the smart tag glyph to close the smart tag panel.

18. In the Properties window, change the value of the [Dock](https://msdn.microsoft.com/en-us/library/77cb86s0\(v=vs.100\)) property to [Fill](https://msdn.microsoft.com/en-us/library/bb462410\(v=vs.100\)).

## Populate the control

Now that the layout of the control is set up, you can populate the DemoCalculator control with buttons and a display.

1. In the Toolbox, double-click the [TextBox](https://msdn.microsoft.com/en-us/library/48deaakc\(v=vs.100\)) control icon.

    A [TextBox](https://msdn.microsoft.com/en-us/library/48deaakc\(v=vs.100\)) control is placed in the first cell of the [TableLayoutPanel](https://msdn.microsoft.com/en-us/library/2t82c7dk\(v=vs.100\)) control.

2. In the Properties window, change the value of the [TextBox](https://msdn.microsoft.com/en-us/library/48deaakc\(v=vs.100\)) control's ColumnSpan property to 5.

    The [TextBox](https://msdn.microsoft.com/en-us/library/48deaakc\(v=vs.100\)) control moves to a position that is centered in its row.

3. Change the value of the [TextBox](https://msdn.microsoft.com/en-us/library/48deaakc\(v=vs.100\)) control's [Anchor](https://msdn.microsoft.com/en-us/library/swkhs12y\(v=vs.100\)) property to [Left](https://msdn.microsoft.com/en-us/library/hsy0z49d\(v=vs.100\)), [Right](https://msdn.microsoft.com/en-us/library/hsy0z49d\(v=vs.100\)).

    The [TextBox](https://msdn.microsoft.com/en-us/library/48deaakc\(v=vs.100\)) control expands horizontally to span all five columns.

4. Change the value of the [TextBox](https://msdn.microsoft.com/en-us/library/48deaakc\(v=vs.100\)) control's [TextAlign](https://msdn.microsoft.com/en-us/library/7z2x8yeh\(v=vs.100\)) property to [Right](https://msdn.microsoft.com/en-us/library/w4d1hwsw\(v=vs.100\)).

5. In the Properties window, expand the [Font](https://msdn.microsoft.com/en-us/library/z0hb3sb6\(v=vs.100\)) property node. Set [Size](https://msdn.microsoft.com/en-us/library/wzbx3sb2\(v=vs.100\)) to 14, and set [Bold](https://msdn.microsoft.com/en-us/library/13124h8t\(v=vs.100\)) to true for the [TextBox](https://msdn.microsoft.com/en-us/library/48deaakc\(v=vs.100\)) control.

6. Select the [TableLayoutPanel](https://msdn.microsoft.com/en-us/library/2t82c7dk\(v=vs.100\)) control.

7. In the Toolbox, double-click the [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) icon.

    A [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) control is placed in the next open cell of the [TableLayoutPanel](https://msdn.microsoft.com/en-us/library/2t82c7dk\(v=vs.100\)) control.

8. In the Toolbox, double-click the [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) icon four more times to populate the second row of the [TableLayoutPanel](https://msdn.microsoft.com/en-us/library/2t82c7dk\(v=vs.100\)) control.

9. Select all five [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) controls by clicking them while holding down the SHIFT key. Press CTRL+C to copy the [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) controls to the clipboard.

10. Press CTRL+V three times to paste copies of the [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) controls into the remaining rows of the [TableLayoutPanel](https://msdn.microsoft.com/en-us/library/2t82c7dk\(v=vs.100\)) control.

11. Select all 20 [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) controls by clicking them while holding down the SHIFT key.

12. In the Properties window, change the value of the [Dock](https://msdn.microsoft.com/en-us/library/77cb86s0\(v=vs.100\)) property to [Fill](https://msdn.microsoft.com/en-us/library/bb462410\(v=vs.100\)).

    All the [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) controls dock to fill their containing cells.

13. In the Properties window, expand the [Margin](https://msdn.microsoft.com/en-us/library/b4a1t3w8\(v=vs.100\)) property node. Set the value of [All](https://msdn.microsoft.com/en-us/library/s5f415a1\(v=vs.100\)) to 5.

    All the [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) controls are sized smaller to create a larger margin between them.

14. Select **button10** and **button20**, and then press DELETE to remove them from the layout.

15. Select **button5** and **button15**, and then change the value of their RowSpan property to 2. These will be the **Clear** and **=** buttons for the DemoCalculator control.

## Navigate the control by using the Document Outline window

When your control or form is populated with several controls, you may find it easier to navigate your layout with the **Document Outline** window.

1. On the **View** menu, point to **Other Windows**, and then click **Document Outline**.

    The **Document Outline** window shows a tree view of the DemoCalculator control and its constituent controls. Container controls like the [SplitContainer](https://msdn.microsoft.com/en-us/library/hb802c99\(v=vs.100\)) show their child controls as subnodes in the tree. You can also rename controls in place using the **Document Outline** window.

2. In the **Document Outline** window, right-click **button1**, and then click **Rename**. Change its name to sevenButton.

3. Using the **Document Outline** window, rename the [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) controls from the designer-generated name to the production name according to the following list:

      - button1 to sevenButton

      - button2 to eightButton

      - button3 to nineButton

      - button4 to divisionButton

      - button5 to clearButton

      - button6 to fourButton

      - button7 to fiveButton

      - button8 to sixButton

      - button9 to multiplicationButton

      - button11 to oneButton

      - button12 to twoButton

      - button13 to threeButton

      - button14 to subtractionButton

      - button15 to equalsButton

      - button16 to zeroButton

      - button17 to changeSignButton

      - button18 to decimalButton

      - button19 to additionButton

4. Using the **Document Outline** and Properties windows, change the [Text](https://msdn.microsoft.com/en-us/library/1x029774\(v=vs.100\)) property value for each [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) control name according to the following list:

      - Change the sevenButton control text property to 7

      - Change the eightButton control text property to 8

      - Change the nineButton control text property to 9

      - Change the divisionButton control text property to /

      - Change the clearButton control text property to Clear

      - Change the fourButton control text property to 4

      - Change the fiveButton control text property to 5

      - Change the sixButton control text property to 6

      - Change the multiplicationButton control text property to \*

      - Change the oneButton control text property to 1

      - Change the twoButton control text property to 2

      - Change the threeButton control text property to 3

      - Change the subtractionButton control text property to -

      - Change the equalsButton control text property to =

      - Change the zeroButton control text property to 0

      - Change the changeSignButton control text property to +/-

      - Change the decimalButton control text property to .

      - Change the additionButton control text property to +

5. On the designer surface, select all the [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) controls by clicking them while holding down the SHIFT key.

6. In the Properties window, expand the [Font](https://msdn.microsoft.com/en-us/library/z0hb3sb6\(v=vs.100\)) property node. Set [Size](https://msdn.microsoft.com/en-us/library/wzbx3sb2\(v=vs.100\)) to 14, and set [Bold](https://msdn.microsoft.com/en-us/library/13124h8t\(v=vs.100\)) to true for all the [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) controls.

    This completes the design of the DemoCalculator control. All that remains is to provide the calculator logic.

## Implement event handlers

The buttons on the DemoCalculator control have event handlers that can be used to implement much of the calculator logic. The Windows Forms Designer enables you to implement the stubs of all the event handlers for all the buttons with one double-click.

1. On the designer surface, select all the [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) controls by clicking them while holding down the SHIFT key.

2. Double-click one of the [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) controls.

    The Code Editor opens to the event handlers generated by the designer.

## Test the control

Because the DemoCalculator control inherits from the [UserControl](https://msdn.microsoft.com/en-us/library/97855yck\(v=vs.100\)) class, you can test its behavior with the **UserControl Test Container**. For more information, see [How to: Test the Run-Time Behavior of a UserControl](ms171738\(v=vs.100\).md).

1. Press **F5** to build and run the DemoCalculator control in the **UserControl Test Container**.

2. Click the border between the [SplitContainer](https://msdn.microsoft.com/en-us/library/hb802c99\(v=vs.100\)) panels and drag it left and right. The [TableLayoutPanel](https://msdn.microsoft.com/en-us/library/2t82c7dk\(v=vs.100\)) and all its child controls resize themselves to fit in the available space.

3. When you are done testing the control, click **Close**.

## Use the control on a form

The DemoCalculator control can be used in other composite controls or on a form. The following procedure describes how to use it.

### Create the project

The first step is to create the application project. You will use this project to build the application that shows your custom control.

1. On the **File** menu, point to **Add**, and then click **New Project** to open the **New Project** dialog box.

2. From the list of Visual Basic or Visual C\# projects, select the **Windows Forms Application** project template.

3. In the **Name** box, type DemoCalculatorTest and then click **OK**.

4. In Solution Explorer, right-click the **DemoCalculatorTest** project, and then click **Add Reference** to open the **Add Reference** dialog box.

5. Click the **Projects** tab, and then double-click your DemoCalculatorLib project to add the reference to the test project.

6. In Solution Explorer, right-click **DemoCalculatorTest**, and then click **Set as StartUp Project**.

7. In the Windows Forms Designer, increase the size of the form to about 700 x 500.

### Use the control in the form's layout

To use the DemoCalculator control in an application, you need to place it on a form.

1. In the Toolbox, expand the **DemoCalculatorLib Components** node.

2. Drag the **DemoCalculator** control from the Toolbox onto your form. Move the control to the upper-left corner of the form. When the control is close to the form's borders, you will see snaplines appear. These indicate the distance of the form's [Padding](https://msdn.microsoft.com/en-us/library/fyk4dfdy\(v=vs.100\)) property and the control's [Margin](https://msdn.microsoft.com/en-us/library/b4a1t3w8\(v=vs.100\)) property. Position the control at the location indicated by the snaplines.

    For more information, see [Walkthrough: Arranging Controls on Windows Forms Using Snaplines](t5b5kc41\(v=vs.100\).md).

3. Drag a [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) control from the Toolbox and drop it onto the form.

4. Move the [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) control around the DemoCalculator control and observe where the snaplines appear. You can align your controls precisely and easily using this feature. Delete the [Button](https://msdn.microsoft.com/en-us/library/031c58k4\(v=vs.100\)) control when you are finished.

5. Right-click the DemoCalculator control, and then click **Properties**.

6. Change the value of the [Dock](https://msdn.microsoft.com/en-us/library/77cb86s0\(v=vs.100\)) property to [Fill](https://msdn.microsoft.com/en-us/library/bb462410\(v=vs.100\)).

7. Select the form, and then expand the [Padding](https://msdn.microsoft.com/en-us/library/fyk4dfdy\(v=vs.100\)) property node. Change the value of **All** to 20.

    The size of the DemoCalculator control is reduced to accommodate the new [Padding](https://msdn.microsoft.com/en-us/library/fyk4dfdy\(v=vs.100\)) value of the form.

8. Resize the form by dragging the various sizing handles to different positions. Observe how the DemoCalculator control is resized to fit.

## Next steps

This walkthrough has shown how to construct the user interface for a simple calculator. You may want to extend its functionality by implementing the calculator logic. This may seem straightforward, but there are interesting complexities associated with the calculator's state transitions.