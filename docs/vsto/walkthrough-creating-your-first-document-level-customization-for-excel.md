---
title: Create a document-level customization for Excel
description: Create a document-level customization for Microsoft Office Excel with features that are available only when a specific Excel workbook is open.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office development in Visual Studio, creating your first project"
  - "Excel [Office development in Visual Studio], creating your first project"
  - "document-level customizations [Office development in Visual Studio], creating your first project"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Create your first document-level customization for Excel

  This introductory walkthrough shows you how to create a document-level customization for Microsoft Office Excel. The features that you create in this kind of solution are available only when a specific workbook is open. You cannot use a document-level customization to make application-wide changes, for example, displaying a new Ribbon tab when any workbook is open.

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

 This walkthrough illustrates the following tasks:

- Creating an Excel workbook project.

- Adding text to a worksheet that is hosted in the Visual Studio designer.

- Writing code that uses the object model of Excel to add text to the customized worksheet when it is opened.

- Building and running the project to test it.

- Cleaning up the completed project to remove unnecessary build files and security settings from your development computer.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites

 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

-  Excel 2013  or  Excel 2010 .

## Create the project

### To create a new Excel workbook project in Visual Studio

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then click **Project**.

3. On the **Create a New Project** dialog select the **Excel VSTO Workbook** project.

     [!INCLUDE[new-project-dialog-search](../vsto/includes/new-project-dialog-search-md.md)]

4. Click **Next**.

5. Type **FirstWorkbookCustomization** in the **Name** box on the **Configure your new project** dialog and click **Create**.

6. Select **Create a new document** from the **Visual Studio Tools for Office Project Wizard**, and click **OK**.

   - Visual Studio creates the **FirstWorkbookCustomization** project, and adds the following files to the project.

   - *FirstWorkbookCustomization*.xlsx - Represents the Excel workbook in the project. Contains all the worksheets and charts.

   - Sheet1 (*.vb* file for Visual Basic or *.cs* file for Visual C#) - A worksheet that provides the design surface and the code for the first worksheet in the workbook. For more information, see [Worksheet host item](../vsto/worksheet-host-item.md).

   - Sheet2 (*.vb* file for Visual Basic or *.cs* file for Visual C#) - A worksheet that provides the design surface and the code for the second worksheet in the workbook.

   - Sheet3 (*.vb* file for Visual Basic or *.cs* file for Visual C#) - A worksheet that provides the design surface and the code for the third worksheet in the workbook.

   - ThisWorkbook (*.vb* file for Visual Basic or *.cs* file for Visual C#) - Contains the design surface and the code for workbook-level customizations. For more information, see [Workbook host item](../vsto/workbook-host-item.md).

     The Sheet1 code file is opened automatically in the designer.

## Close and reopen worksheets in the designer

 If you deliberately or accidentally close a workbook or a worksheet in the designer while you are developing your project, you can reopen it.

### To close and reopen a worksheet in the designer

1. Close the workbook by clicking the **Close** button (X) for the designer window.

2. In **Solution Explorer**, right-click the **Sheet1** code file, and click **View Designer**.

     \- or -

     In **Solution Explorer**, double-click the **Sheet1** code file.

## Add text to a worksheet in the designer

 You can design the user interface (UI) of your customization by modifying the worksheet that is open in the designer. For example, you can add text to cells, apply formulas, or add Excel controls. For more information about how to use the designer, see [Office projects in the Visual Studio environment](../vsto/office-projects-in-the-visual-studio-environment.md).

### To add text to a worksheet by using the designer

1. In the worksheet that is open in the designer, select cell **A1**, and then type the following text.

     **This text was added by using the designer.**

> [!WARNING]
> If you add this line of text to cell **A2**, it will be overwritten by other code in this example.

## Add text to a worksheet programmatically

 Next, add code to the Sheet1 code file. The new code uses the object model of Excel to add a second line of text to the workbook. By default, the Sheet1 code file contains the following generated code:

- A partial definition of the `Sheet1` class, which represents the programming model of the worksheet and provides access to the object model of Excel. For more information, [Worksheet host item](../vsto/worksheet-host-item.md) and [Word object model overview](../vsto/word-object-model-overview.md). The remainder of the `Sheet1` class is defined in a hidden code file that you should not modify.

- The `Sheet1_Startup` and `Sheet1_Shutdown` event handlers. These event handlers are called when Excel loads and unloads your customization. Use these event handlers to initialize your customization when it is loaded, and to clean up resources used by your customization when it is unloaded. For more information, see [Events in Office projects](../vsto/events-in-office-projects.md).

### To add a second line of text to the worksheet by using code

1. In **Solution Explorer**, right-click **Sheet1**, and then click **View Code**.

     The code file opens in Visual Studio.

2. Replace the `Sheet1_Startup` event handler with the following code. When Sheet1 is opened, this code adds a second line of text to the worksheet.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_ExcelWorkbookTutorial/Sheet1.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_ExcelWorkbookTutorial/Sheet1.vb" id="Snippet1":::
     ---

## Test the project

### To test your workbook

1. Press **F5** to build and run your project.

     When you build the project, the code is compiled into an assembly that is associated with the workbook. Visual Studio puts a copy of the workbook and the assembly in the build output folder for the project, and it configures the security settings on the development computer to enable the customization to run. For more information, see [Build Office solutions](../vsto/building-office-solutions.md).

2. In the workbook, verify that you see the following text.

     **This text was added by using the designer.**

     **This text was added by using code.**

3. Close the workbook.

## Clean up the project

 When you finish developing a project, you should remove the files in the build output folder and the security settings created by the build process.

### To clean up the completed project on your development computer

1. In Visual Studio, on the **Build** menu, click **Clean Solution**.

## Next steps

 Now that you have created a basic document-level customization for Excel, you can learn more about how to develop customizations from these topics:

- General programming tasks that you can perform in document-level customizations: [Program document-level customizations](../vsto/programming-document-level-customizations.md).

- Programming tasks that are specific to document-level customizations for Excel: [Excel solutions](../vsto/excel-solutions.md).

- Using the object model of Excel: [Excel object model overview](../vsto/excel-object-model-overview.md).

- Customizing the UI of Excel, for example, by adding a custom tab to the Ribbon or creating your own actions pane: [Office UI customization](../vsto/office-ui-customization.md).

- Using extended Excel objects provided by Office development tools in Visual Studio to perform tasks that are not possible by using the Excel object model (for example, hosting managed controls on documents and binding Excel controls to data by using the Windows Forms data binding model): [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md).

- Building and debugging document-level customizations for Excel: [Build Office solutions](../vsto/building-office-solutions.md).

- Deploying document-level customizations for Excel: [Deploy an Office solution](../vsto/deploying-an-office-solution.md).

## Related content

- [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)
- [Excel solutions](../vsto/excel-solutions.md)
- [Program document-level customizations](../vsto/programming-document-level-customizations.md)
- [Excel object model overview](../vsto/excel-object-model-overview.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Office UI customization](../vsto/office-ui-customization.md)
- [Build Office solutions](../vsto/building-office-solutions.md)
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
- [Office project templates overview](../vsto/office-project-templates-overview.md)
