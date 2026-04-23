---
title: "Create Visual Studio Tools for Office Add-ins: Microsoft Excel"
description: Create a VSTO add-in for the Microsoft Office Excel with features that are available to the application itself, regardless of which Excel workbooks are open.
ms.date: "08/14/2019"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application-level add-ins [Office development in Visual Studio], creating your first project"
  - "Office development in Visual Studio, creating your first project"
  - "add-ins [Office development in Visual Studio], creating your first project"
  - "Excel [Office development in Visual Studio], creating your first project"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Create your first VSTO Add-in for Excel

  This introductory walkthrough shows you how to create an application-level Add-in for Microsoft Office Excel. The features that you create in this kind of solution are available to the application itself, regardless of which workbooks are open.

 [!INCLUDE[appliesto_xlallapp](../vsto/includes/appliesto-xlallapp-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

 This walkthrough illustrates the following tasks:

- Creating an Excel VSTO Add-in project for Excel.

- Writing code that uses the object model of Excel to add text to a workbook when it is saved.

- Building and running the project to test it.

- Cleaning up the completed project so that the VSTO Add-in no longer runs automatically on your development computer.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

-  Excel 2013  or  Excel 2010 .

## Create the project

#### To create a new Excel VSTO Add-in project in Visual Studio

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then click **Project**.

3. In the templates pane, expand **Visual C#** or **Visual Basic**, and then expand **Office/SharePoint**.

4. Under the expanded **Office/SharePoint** node, select the **Office Add-ins** node.

5. In the list of project templates, select **Excel 2010 Add-in** or **Excel 2013 Add-in**.

6. In the **Name** box, type **FirstExcelAddIn**.

7. Click **OK**.

     Visual Studio creates the **FirstExcelAddIn** project and opens the ThisAddIn code file in the editor.

## Write code to add text to the saved workbook
 Next, add code to the ThisAddIn code file. The new code uses the object model of Excel to insert boilerplate text in the first row of the active worksheet. The active worksheet is the worksheet that is open when the user saves the workbook. By default, the ThisAddIn code file contains the following generated code:

- A partial definition of the `ThisAddIn` class. This class provides an entry point for your code and provides access to the object model of Excel. For more information, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md). The remainder of the `ThisAddIn` class is defined in a hidden code file that you should not modify.

- The `ThisAddIn_Startup` and `ThisAddIn_Shutdown` event handlers. These event handlers are called when Excel loads and unloads your VSTO Add-in. Use these event handlers to initialize your VSTO Add-in when it is loaded, and to clean up resources used by your Add-in when it is unloaded. For more information, see [Events in Office projects](../vsto/events-in-office-projects.md).

### To add a line of text to the saved workbook

1. In the ThisAddIn code file, add the following code to the `ThisAddIn` class. The new code defines an event handler for the <xref:Microsoft.Office.Interop.Excel.AppEvents_Event.WorkbookBeforeSave> event, which is raised when a workbook is saved.

    When the user saves a workbook, the event handler adds new text at the start of the active worksheet.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_ExcelAddInTutorial/ThisAddIn.cs" id="Snippet1":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_ExcelAddInTutorial/ThisAddIn.vb" id="Snippet1":::
    ---

2. If you are using C#, add the following required code to the `ThisAddIn_Startup` event handler. This code is used to connect the `Application_WorkbookBeforeSave` event handler with the <xref:Microsoft.Office.Interop.Excel.AppEvents_Event.WorkbookBeforeSave> event.

    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_ExcelAddInTutorial/ThisAddIn.cs" id="Snippet2":::

   To modify the workbook when it is saved, the previous code examples use the following objects:

- The `Application` field of the `ThisAddIn` class. The `Application` field returns a <xref:Microsoft.Office.Interop.Excel.Application> object, which represents the current instance of Excel.

- The `Wb` parameter of the event handler for the <xref:Microsoft.Office.Interop.Excel.AppEvents_Event.WorkbookBeforeSave> event. The `Wb` parameter is a <xref:Microsoft.Office.Interop.Excel.Workbook> object, which represents the saved workbook. For more information, see [Excel object model overview](../vsto/excel-object-model-overview.md).

## Test the project

### To test the project

1. Press **F5** to build and run your project.

     When you build the project, the code is compiled into an assembly that is included in the build output folder for the project. Visual Studio also creates a set of registry entries that enable Excel to discover and load the VSTO Add-in, and it configures the security settings on the development computer to enable the VSTO Add-in to run. For more information, see [Build Office solutions](../vsto/building-office-solutions.md).

2. In Excel, save the workbook.

3. Verify that the following text is added to the workbook.

     **This text was added by using code.**

4. Close Excel.

## Clean up the project
 When you finish developing a project, remove the VSTO Add-in assembly, registry entries, and security settings from your development computer. Otherwise, the VSTO Add-in will continue to run every time that you open Excel on your development computer.

### To clean up the completed project on your development computer

1. In Visual Studio, on the **Build** menu, click **Clean Solution**.

## Next steps
 Now that you have created a basic VSTO Add-in for Excel, you can learn more about how to develop VSTO Add-ins from these topics:

- General programming tasks that you can perform in VSTO Add-ins: [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md).

- Programming tasks that are specific to Excel VSTO Add-ins: [Excel solutions](../vsto/excel-solutions.md).

- Using the object model of Excel: [Excel object model overview](../vsto/excel-object-model-overview.md).

- Customizing the user interface (UI) of Excel, for example, by adding a custom tab to the Ribbon or creating your own custom task pane: [Office UI customization](../vsto/office-ui-customization.md).

- Building and debugging VSTO Add-ins for Excel: [Build Office solutions](../vsto/building-office-solutions.md).

- Deploying VSTO Add-ins for Excel: [Deploy an Office solution](../vsto/deploying-an-office-solution.md).

## Related content
- [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)
- [Excel solutions](../vsto/excel-solutions.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Excel object model overview](../vsto/excel-object-model-overview.md)
- [Office UI customization](../vsto/office-ui-customization.md)
- [Build Office solutions](../vsto/building-office-solutions.md)
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
- [Office project templates overview](../vsto/office-project-templates-overview.md)
