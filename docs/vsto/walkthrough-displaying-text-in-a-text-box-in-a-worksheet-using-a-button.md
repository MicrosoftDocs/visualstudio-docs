---
title: "Display text in text box in worksheet using button"
description: Learn the basics of using buttons and text boxes on Microsoft Excel worksheets. Also create Excel projects using Office development tools in Visual Studio.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "text [Office development in Visual Studio], displaying worksheets"
  - "worksheets, displaying text"
  - "text boxes, displaying text in worksheets"
  - "text [Office development in Visual Studio], text boxes"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Display text in a text box in a worksheet using a button

  This walkthrough shows the basics of using buttons and text boxes on Microsoft Office Excel worksheets, and how to create Excel projects using Office development tools in Visual Studio. To see the result as a completed sample, see the Excel Controls Sample at [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md).

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

 During this walkthrough, you will learn how to:

- Add controls to a worksheet.

- Populate a text box when a button is clicked.

- Test your project.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

-  Excel 2013  or  Excel 2010 .

## Create the project
 In this step, you will create an Excel Workbook project using Visual Studio.

### To create a new project

1. Create an Excel Workbook project with the name **My Excel Button**. Make sure that **Create a new document** is selected. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the new Excel workbook in the designer and adds the **My Excel Button** project to **Solution Explorer**.

## Add controls to the worksheet
 For this walkthrough, you will need a button and a text box on the first worksheet.

### To add a button and a text box

1. Verify that the **My Excel Button.xlsx** workbook is open in the Visual Studio designer, with `Sheet1` displayed.

2. From the **Common Controls** tab of the Toolbox, drag a <xref:Microsoft.Office.Tools.Excel.Controls.TextBox> to `Sheet1`.

3. From the **View** menu, select **Properties Window**.

4. Be sure that **TextBox1** is visible in the **Properties** window drop-down box and change the **Name** property of the text box to **displayText**.

5. Drag a **Button** control onto `Sheet1` and change the following properties:

   |Property|Value|
   |--------------|-----------|
   |**Name**|**insertText**|
   |**Text**|**Insert Text**|

   Now write the code to run when the button is clicked.

## Populate the text box when the button is clicked
 Each time the user clicks the button, **Hello World!** is appended to the text box.

### To write to the text box when the button is clicked

1. In **Solution Explorer**, right-click **Sheet1**, and then click **View Code** on the shortcut menu.

2. Add the following code to the <xref:System.Windows.Forms.Control.Click> event handler of the button:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/Sheet1.cs" id="Snippet11":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/my excel chart/Sheet1.vb" id="Snippet11":::
     ---

3. In C#, you must add an event handler to the <xref:Microsoft.Office.Tools.Excel.Worksheet.Startup> event as shown below. For information on creating event handlers, see [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md).

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/Sheet1.cs" id="Snippet12":::

## Test the application
 You can now test your workbook to make sure that the message **Hello World!** appears in the text box when you click the button.

### To test your workbook

1. Press **F5** to run your project.

2. Click the button.

3. Confirm that **Hello World!** appears in the text box.

## Next steps
 This walkthrough shows the basics of using buttons and text boxes on Excel worksheets. Here are some tasks that might come next:

- Deploying the project. For more information, see [Deploy an Office solution](../vsto/deploying-an-office-solution.md).

- Using check boxes to change formatting. 

## Related content
- [How to: Add Windows Forms controls to Office documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md)
- [Walkthroughs using Excel](../vsto/walkthroughs-using-excel.md)
- [Limitations of Windows Forms controls on Office documents](../vsto/limitations-of-windows-forms-controls-on-office-documents.md)
