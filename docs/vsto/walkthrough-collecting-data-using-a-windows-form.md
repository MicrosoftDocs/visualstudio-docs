---
title: "Walkthrough: Collect data using a Windows Form"
description: Open a Windows Form from a document-level customization for Microsoft Excel, collect information from the user, and write that information into a worksheet cell.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "data [Office development in Visual Studio], Windows Forms"
  - "Windows Forms [Office development in Visual Studio], collecting data"
  - "forms [Office development in Visual Studio], walkthroughs"
  - "worksheets [Office development in Visual Studio], collecting data"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Collect data by using a Windows Form

  This walkthrough demonstrates how to open a Windows Form from a document-level customization for Microsoft Office Excel, collect information from the user, and write that information into a worksheet cell.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

 Although this walkthrough uses a document-level project for Excel specifically, the concepts demonstrated by the walkthrough are applicable to other Office projects.

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

-  Excel 2013  or  Excel 2010 .

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Create a new project
 The first step is to create an Excel Workbook project.

### To create a new project

1. Create an Excel Workbook project with the name **WinFormInput**, and select **Create a new document** in the wizard. For more information, see [How to: create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the new Excel workbook in the designer and adds the **WinFormInput** project to **Solution Explorer**.

## Add a NamedRange control to the worksheet

### To add a named range to Sheet1

1. Select cell **A1** on `Sheet1`.

2. In the **Name** box, type **formInput**.

     The **Name** box is located to the left of the formula bar, just above column **A** of the worksheet.

3. Press **Enter**.

     A <xref:Microsoft.Office.Tools.Excel.NamedRange> control is added to cell **A1**. There is no visible indication on the worksheet, but **formInput** appears in the **Name** box (just above the worksheet on the left side) and in the **Properties** window when cell **A1** is selected.

## Add a Windows Form to the project
 Create a Windows Form to prompt the user for information.

### To add a Windows Form

1. Select the project **WinFormInput** in **Solution Explorer**.

2. On the **Project** menu, click **Add Windows Form**.

3. Name the form **GetInputString.vb** or **GetInputString.cs**, and then click **Add**.

    The new form opens in the designer.

4. Add a <xref:System.Windows.Forms.TextBox> and a <xref:System.Windows.Forms.Button> to the form.

5. Select the button, find the property **Text** in the **Properties** window, and change the text to **OK**.

   Next, add code to `ThisWorkbook.vb` or `ThisWorkbook.cs` to collect the user's information.

## Display the Windows Form and collecting information
 Create an instance of the `GetInputString` Windows Form and display it, and then write the user's information into a cell in the worksheet.

#### To display the form and collect information

1. Right-click **ThisWorkbook.vb** or **ThisWorkbook.cs** in **Solution Explorer**, and then click **View Code**.

2. In the <xref:Microsoft.Office.Tools.Excel.Workbook.Open> event handler of `ThisWorkbook`, add the following code to declare a variable for the form `GetInputString` and then show the form.

   > [!NOTE]
   > In C#, you must add an event handler as shown in the <xref:Microsoft.Office.Tools.Excel.Workbook.Startup> event below. For information about creating event handlers, see [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md).

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/WinFormInputCS/ThisWorkbook.cs" id="Snippet1":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/WinFormInput/ThisWorkbook.vb" id="Snippet1":::
    ---

3. Create a method called `WriteStringToCell` that writes text to a named range. This method is called from the form, and the user's input is passed to the <xref:Microsoft.Office.Tools.Excel.NamedRange> control, `formInput`, on cell **A1**.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/WinFormInputCS/ThisWorkbook.cs" id="Snippet2":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/WinFormInput/ThisWorkbook.vb" id="Snippet2":::
    ---

   Next, add code to the form to handle the button's click event.

## Send information to the worksheet

### To send information to the worksheet

1. Right-click **GetInputString** in **Solution Explorer**, and then click **View Designer**.

2. Double-click the button to open the code file with the button's <xref:System.Windows.Forms.Control.Click> event handler added.

3. Add code to the event handler to take the input from the text box, send it to the function `WriteStringToCell`, and then close the form.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/WinFormInputCS/GetInputString.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/WinFormInput/GetInputString.vb" id="Snippet3":::
     ---

## Test
 You can now run the project. The Windows Form appears, and your input appears in the worksheet.

### To test your workbook

1. Press **F5** to run your project.

2. Confirm that the Windows Form appears.

3. Type **Hello World** in the text box, and then click **OK**.

4. Confirm that **Hello World** appears in cell **A1** of the worksheet.

## Next steps
 This walkthrough shows the basics of showing a Windows Form and passing data to a worksheet. Other tasks you may want to perform include:

- Use Windows Forms controls on an Excel workbook or a Word document. For more information, see [Windows Forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md).

- Modify the user interface of a Microsoft Office application from a document-level customization or a VSTO Add-in. For more information, see [Office UI customization](../vsto/office-ui-customization.md).

## Related content
- [Develop Office solutions](../vsto/developing-office-solutions.md)
- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Program document-level customizations](../vsto/programming-document-level-customizations.md)
- [Walkthroughs using Word](../vsto/walkthroughs-using-word.md)
- [Walkthroughs using Excel](../vsto/walkthroughs-using-excel.md)
