---
title: "Walkthrough: Program against events of a NamedRange control"
description: Learn how you can add a NamedRange control to a Microsoft Excel worksheet and program against its events by using Office development tools in Visual Studio.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ranges, programming against events"
  - "worksheets, changing cell values"
  - "NamedRange control, events"
  - "worksheets, events"
  - "worksheets, automating"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---

# Walkthrough: Program against events of a NamedRange control
  This walkthrough demonstrates how to add a <xref:Microsoft.Office.Tools.Excel.NamedRange> control to a Microsoft Office Excel worksheet and program against its events by using Office development tools in Visual Studio.

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

 During this walkthrough, you will learn how to:

- Add a <xref:Microsoft.Office.Tools.Excel.NamedRange> control to a worksheet.

- Program against <xref:Microsoft.Office.Tools.Excel.NamedRange> control events.

- Test your project.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- [!INCLUDE[Excel_15_short](../vsto/includes/excel-15-short-md.md)] or [!INCLUDE[Excel_14_short](../vsto/includes/excel-14-short-md.md)].

## Create the project
 In this step, you will create an Excel workbook project using Visual Studio.

### To create a new project

1. Create an Excel Workbook project with the name **My Named Range Events**. Make sure that **Create a new document** is selected. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the new Excel workbook in the designer and adds the **My Named Range Events** project to **Solution Explorer**.

## Add text and named ranges to the worksheet
 Because host controls are extended Office objects, you can add them to your document in the same manner you would add the native object. For example, you can add an Excel <xref:Microsoft.Office.Tools.Excel.NamedRange> control to a worksheet by opening the **Insert** menu, pointing to **Name**, and choosing **Define**. You can also add a <xref:Microsoft.Office.Tools.Excel.NamedRange> control by dragging it from the **Toolbox** onto the worksheet.

 In this step, you will add two named range controls to the worksheet using the **Toolbox**, and then add text to the worksheet.

### To add a range to your worksheet

1. Verify that the *My Named Range Events.xlsx* workbook is open in the Visual Studio designer, with `Sheet1` displayed.

2. From the **Excel Controls** tab of the Toolbox, drag a <xref:Microsoft.Office.Tools.Excel.NamedRange> control to cell **A1** in `Sheet1`.

     The **Add NamedRange Control** dialog box appears.

3. Verify that **$A$1** appears in the editable text box, and that cell **A1** is selected. If it is not, click cell **A1** to select it.

4. Click **OK**.

     Cell **A1** becomes a range named `namedRange1`. There is no visible indication on the worksheet, but `namedRange1` appears in the **Name** box (located just above the worksheet on the left side) when cell **A1** is selected.

5. Add another <xref:Microsoft.Office.Tools.Excel.NamedRange> control to cell **B3**.

6. Verify that **$B$3** appears in the editable text box, and that cell **B3** is selected. If it is not, click cell **B3** to select it.

7. Click **OK**.

     Cell **B3** becomes a range named `namedRange2`.

### To add text to your worksheet

1. In Cell **A1**, type the following text:

    **This is an example of a NamedRange control.**

2. In Cell **A3** (to the left of `namedRange2`), type the following text:

    **Events:**

   In the following sections, you will write code that inserts text into `namedRange2` and modifies properties of the `namedRange2` control in response to the <xref:Microsoft.Office.Tools.Excel.NamedRange.BeforeDoubleClick>, <xref:Microsoft.Office.Tools.Excel.NamedRange.Change>, and <xref:Microsoft.Office.Tools.Excel.NamedRange.SelectionChange> events of `namedRange1`.

## Add code to respond to the BeforeDoubleClick event

### To insert text into NamedRange2 based on the BeforeDoubleClick event

1. In **Solution Explorer**, right-click **Sheet1.vb** or **Sheet1.cs** and select **View Code**.

2. Add code so the `namedRange1_BeforeDoubleClick` event handler looks like the following:

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs" id="Snippet24":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb" id="Snippet24":::

3. In C#, you must add event handlers for the named range as shown in the <xref:Microsoft.Office.Tools.Excel.Worksheet.Startup> event below. For information on creating event handlers, see [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md).

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs" id="Snippet25":::

## Add code to respond to the Change event

### To insert text into namedRange2 based on the Change event

1. Add code so the `NamedRange1_Change` event handler looks like the following:

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs" id="Snippet26":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb" id="Snippet26":::

    > [!NOTE]
    > Because double-clicking a cell in an Excel range enters edit mode, a <xref:Microsoft.Office.Tools.Excel.NamedRange.Change> event occurs when the selection is moved outside of the range even if no changes to text occurred.

## Add code to respond to the SelectionChange event

### To insert text into namedRange2 based on the SelectionChange event

1. Add code so the **NamedRange1_SelectionChange** event handler looks like the following:

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs" id="Snippet27":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb" id="Snippet27":::

    > [!NOTE]
    > Because double-clicking a cell in an Excel range causes the selection to move into the range, a <xref:Microsoft.Office.Tools.Excel.NamedRange.SelectionChange> event occurs before the <xref:Microsoft.Office.Tools.Excel.NamedRange.BeforeDoubleClick> event occurs.

## Test the application
 Now you can test your workbook to verify that text describing the events of a <xref:Microsoft.Office.Tools.Excel.NamedRange> control is inserted into another named range when the events are raised.

### To test your document

1. Press **F5** to run your project.

2. Place your cursor in `namedRange1`, and verify that the text regarding the <xref:Microsoft.Office.Tools.Excel.NamedRange.SelectionChange> event is inserted and that a comment is inserted into the worksheet.

3. Double click inside `namedRange1`, and verify that the text regarding <xref:Microsoft.Office.Tools.Excel.NamedRange.BeforeDoubleClick> events is inserted with red italicized text in `namedRange2`.

4. Click outside of `namedRange1` and note that the change event occurs when exiting edit mode even though no change to the text was made.

5. Change the text within `namedRange1`.

6. Click outside of `namedRange1`, and verify that the text regarding <xref:Microsoft.Office.Tools.Excel.NamedRange.Change> event is inserted with blue text into `namedRange2`.

## Next steps
 This walkthrough shows the basics of programming against events of a <xref:Microsoft.Office.Tools.Excel.NamedRange> control. Here is a task that might come next:

- Deploying the project. For more information, see [Deploy an Office solution](../vsto/deploying-an-office-solution.md).

## See also
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [How to: Resize NamedRange controls](../vsto/how-to-resize-namedrange-controls.md)
- [How to: Add NamedRange controls to worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md)
