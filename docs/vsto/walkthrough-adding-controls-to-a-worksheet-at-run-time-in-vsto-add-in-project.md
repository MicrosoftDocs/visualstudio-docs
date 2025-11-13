---
title: "Add controls to worksheet at run time in VSTO add-in project"
description: Learn how to use the Ribbon to enable users to add a Button, a NamedRange, and a ListObject to a worksheet. 
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "add-ins [Office development in Visual Studio], adding controls"
  - "controls [Office development in Visual Studio], adding to worksheets at run time"
  - "application-level add-ins [Office development in Visual Studio], adding controls"
  - "worksheets, adding controls at run time"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Add controls to a worksheet at run time in VSTO add-in project

  You can add controls to any open worksheet by using an Excel VSTO Add-in. This walkthrough demonstrates how to use the Ribbon to enable users to add a <xref:Microsoft.Office.Tools.Excel.Controls.Button>, a <xref:Microsoft.Office.Tools.Excel.NamedRange>, and a <xref:Microsoft.Office.Tools.Excel.ListObject> to a worksheet. For information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

 **Applies to:** The information in this topic applies to VSTO Add-in projects for Excel. For more information, see [Features Available by Office Application and Project Type](../vsto/features-available-by-office-application-and-project-type.md).

 This walkthrough illustrates the following tasks:

- Providing a user interface (UI) to add controls to the worksheet.

- Adding controls to the worksheet.

- Removing controls from the worksheet.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- Excel

## Create a new Excel VSTO Add-in project
 Start by creating an Excel VSTO Add-in project.

### To create a new Excel VSTO Add-in project

1. In Visual Studio, create an Excel VSTO Add-in project with the name **ExcelDynamicControls**. For more information, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

2. Add a reference to the **Microsoft.Office.Tools.Excel.v4.0.Utilities.dll** assembly. This reference is required to programmatically add a Windows Forms control to a worksheet later in this walkthrough.

## Provide a UI to add controls to a worksheet
 Add a custom tab to the Excel Ribbon. Users can select check boxes on the tab to add controls to a worksheet.

#### To provide a UI to add controls to a worksheet

1. On the **Project** menu, click **Add New Item**.

2. In the **Add New Item** dialog box, select **Ribbon (Visual Designer)**, and then click **Add**.

     A file named **Ribbon1.cs** or **Ribbon1.vb** opens in the Ribbon Designer and displays a default tab and group.

3. From the **Office Ribbon Controls** tab of the **Toolbox**, drag a CheckBox control onto **group1**.

4. Click **CheckBox1** to select it.

5. In the **Properties** window, change the following properties.

    |Property|Value|
    |--------------|-----------|
    |**Name**|**Button**|
    |**Label**|**Button**|

6. Add a second check box to **group1**, and then change the following properties.

    |Property|Value|
    |--------------|-----------|
    |**Name**|**NamedRange**|
    |**Label**|**NamedRange**|

7. Add a third check box to **group1**, and then change the following properties.

    |Property|Value|
    |--------------|-----------|
    |**Name**|**ListObject**|
    |**Label**|**ListObject**|

## Add controls to the worksheet
 Managed controls can only be added to host items, which act as containers. Because VSTO Add-in projects work with any open workbook, the VSTO Add-in converts the worksheet into a host item, or gets an existing host item, before adding the control. Add code to the click event handlers of each control to generate a <xref:Microsoft.Office.Tools.Excel.Worksheet> host item that is based on the open worksheet. Then, add a <xref:Microsoft.Office.Tools.Excel.Controls.Button>, a <xref:Microsoft.Office.Tools.Excel.NamedRange>, and a <xref:Microsoft.Office.Tools.Excel.ListObject> at the current selection in the worksheet.

### To add controls to a worksheet

1. In the Ribbon Designer, double-click **Button**.

     The <xref:Microsoft.Office.Tools.Ribbon.RibbonCheckBox.Click> event handler of the **Button** check box opens in the Code Editor.

2. Replace the `Button_Click` event handler with the following code.

     This code uses the `GetVstoObject` method to get a host item that represents the first worksheet in the workbook, and then adds a <xref:Microsoft.Office.Tools.Excel.Controls.Button> control to the currently selected cell.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/Ribbon1.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/Ribbon1.vb" id="Snippet2":::
     ---

3. In **Solution Explorer**, select *Ribbon1.cs* or *Ribbon1.vb*.

4. On the **View** menu, click **Designer**.

5. In the Ribbon Designer, double-click **NamedRange**.

6. Replace the `NamedRange_Click` event handler with the following code.

     This code uses the `GetVstoObject` method to get a host item that represents the first worksheet in the workbook, and then defines a <xref:Microsoft.Office.Tools.Excel.NamedRange> control for the currently selected cell or cells.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/Ribbon1.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/Ribbon1.vb" id="Snippet3":::
     ---

7. In the Ribbon Designer, double-click **ListObject**.

8. Replace the `ListObject_Click` event handler with the following code.

     This code uses the `GetVstoObject` method to get a host item that represents the first worksheet in the workbook, and then defines a <xref:Microsoft.Office.Tools.Excel.ListObject> for the currently selected cell or cells.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/Ribbon1.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/Ribbon1.vb" id="Snippet4":::
     ---

9. Add the following statements to the top of the Ribbon code file.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/Ribbon1.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/Ribbon1.vb" id="Snippet1":::
     ---

## Remove controls from the worksheet
 Controls are not persisted when the worksheet is saved and closed. You should programmatically remove all generated Windows Forms controls before the worksheet is saved, or only an outline of the control will appear when the workbook is opened again. Add code to the <xref:Microsoft.Office.Interop.Excel.AppEvents_Event.WorkbookBeforeSave> event that removes Windows Forms controls from the controls collection of the generated host item. For more information, see [Persist dynamic controls in Office documents](../vsto/persisting-dynamic-controls-in-office-documents.md).

### To remove controls from the worksheet

1. In **Solution Explorer**, select *ThisAddIn.cs* or *ThisAddIn.vb*.

2. On the **View** menu, click **Code**.

3. Add the following method to the `ThisAddIn` class. This code gets the first worksheet in the workbook and then uses the `HasVstoObject` method to check whether the worksheet has a generated worksheet object. If the generated worksheet object has controls, the code gets that worksheet object and iterates through the control collection, removing the controls.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/ThisAddIn.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/ThisAddIn.vb" id="Snippet6":::
     ---

4. In C#, you must create an event handler for the <xref:Microsoft.Office.Interop.Excel.AppEvents_Event.WorkbookBeforeSave> event. You can place this code in the `ThisAddIn_Startup` method. For more information about creating event handlers, see [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md). Replace the `ThisAddIn_Startup` method with the following code.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/ThisAddIn.cs" id="Snippet5":::

## Test the solution
 Add controls to a worksheet by selecting them from a custom tab on the ribbon. When you save the worksheet, these controls are removed.

### To test the solution.

1. Press **F5** to run your project.

2. Select any cell in Sheet1.

3. Click the **Add-Ins** tab.

4. In the **group1** group, click **Button**.

     A button appears in the selected cell.

5. Select a different cell in Sheet1.

6. In the **group1** group, click **NamedRange**.

     A named range is defined for the selected cell.

7. Select a series of cells in Sheet1.

8. In the **group1** group, click **ListObject**.

     A list object is added for the selected cells.

9. Save the worksheet.

     The controls that you added to Sheet1 no longer appear.

## Next steps
 You can learn more about controls in Excel VSTO Add-in projects from this topic:

- To learn about how to save controls to a worksheet, see the Excel VSTO Add-in Dynamic Controls Sample at [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md).

## Related content
- [Excel solutions](../vsto/excel-solutions.md)
- [Windows forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md)
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [ListObject control](../vsto/listobject-control.md)
