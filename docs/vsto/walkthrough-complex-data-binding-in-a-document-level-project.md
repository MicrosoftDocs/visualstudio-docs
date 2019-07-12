---
title: "Walkthrough: Complex data binding in a document-level project"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "data [Office development in Visual Studio], binding data"
  - "complex data [Office development in Visual Studio]"
  - "multiple column data binding [Office development in Visual Studio]"
  - "data binding [Office development in Visual Studio], multiple columns"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Walkthrough: Complex data binding in a document-level project
  This walkthrough demonstrates the basics of complex data binding in a document-level project. You can bind multiple cells in a Microsoft Office Excel worksheet to fields in the Northwind SQL Server database.

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

 This walkthrough illustrates the following tasks:

- Adding a data source to your workbook project.

- Adding data-bound controls to a worksheet.

- Saving data changes back to the database.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- [!INCLUDE[Excel_15_short](../vsto/includes/excel-15-short-md.md)] or [!INCLUDE[Excel_14_short](../vsto/includes/excel-14-short-md.md)].

- Access to a server with the Northwind SQL Server sample database.

- Permissions to read from and write to the SQL Server database.

## Create a new project
 The first step is to create an Excel workbook project.

### To create a new project

1. Create an Excel workbook project with the name **My Complex Data Binding**. In the wizard, select **Create a new document**.

     For more information, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the new Excel workbook in the designer and adds the **My Complex Data Binding** project to **Solution Explorer**.

## Create the data source
 Use the **Data Sources** window to add a typed dataset to your project.

### To create the data source

1. If the **Data Sources** window is not visible, display it by, on the menu bar, choosing **View** > **Other Windows** > **Data Sources**.

2. Choose **Add New Data Source** to start the **Data Source Configuration Wizard**.

3. Select **Database** and then click **Next**.

4. Select a data connection to the Northwind sample SQL Server database, or add a new connection by using the **New Connection** button.

5. After a connection has been selected or created, click **Next**.

6. Clear the option to save the connection if it is selected, and then click **Next**.

7. Expand the **Tables** node in the **Database objects** window.

8. Select the check box next to the **Employees** table.

9. Click **Finish**.

   The wizard adds the **Employees** table to the **Data Sources** window. It also adds a typed dataset to your project that is visible in **Solution Explorer**.

## Add controls to the worksheet
 A worksheet will display the **Employees** table when the workbook is opened. Users will be able to make changes to the data and then save those changes back to the database by clicking a button.

 To bind the worksheet to the table automatically, you can add a <xref:Microsoft.Office.Tools.Excel.ListObject> control to the worksheet from the **Data Sources** window. To give the user the option to save changes, add a <xref:System.Windows.Forms.Button> control from the **Toolbox**.

#### To add a list object

1. Verify that the **My Complex Data Binding.xlsx** workbook is open in the Visual Studio designer, with **Sheet1** displayed.

2. Open the **Data Sources** window and select the **Employees** node.

3. Click the drop-down arrow that appears.

4. Select **ListObject** in the drop-down list.

5. Drag the **Employees** table to cell **A6**.

     A <xref:Microsoft.Office.Tools.Excel.ListObject> control named `EmployeesListObject` is created in cell **A6**. At the same time, a <xref:System.Windows.Forms.BindingSource> named `EmployeesBindingSource`, a table adapter, and a <xref:System.Data.DataSet> instance are added to the project. The control is bound to the <xref:System.Windows.Forms.BindingSource>, which in turn is bound to the <xref:System.Data.DataSet> instance.

### To add a button

1. From the **Common Controls** tab of the **Toolbox**, add a <xref:System.Windows.Forms.Button> control to cell **A4** of the worksheet.

   The next step is to add text to the button when the worksheet opens.

## Initialize the control
 Add text to the button in the <xref:Microsoft.Office.Tools.Excel.Worksheet.Startup> event handler.

### To initialize the control

1. In **Solution Explorer**, right-click **Sheet1.vb** or **Sheet1.cs**, and then click **View Code** on the shortcut menu.

2. Add the following code to the `Sheet1_Startup` method to set the text for the b`utton`.

    [!code-csharp[Trin_VstcoreDataExcel#8](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet3.cs#8)]
    [!code-vb[Trin_VstcoreDataExcel#8](../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet3.vb#8)]

3. For C# only, add an event handler for the <xref:System.Windows.Forms.Control.Click> event to the `Sheet1_Startup` method.

    [!code-csharp[Trin_VstcoreDataExcel#9](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet3.cs#9)]

   Now add code to handle the <xref:System.Windows.Forms.Control.Click> event of the button.

## Save changes to the database
 Any changes have been made to the data exist only in the local dataset until they are explicitly saved back to the database.

### To save changes to the database

1. Add an event handler for the <xref:System.Windows.Forms.Control.Click> event of the `button`, and add the following code to commit all changes that have been made in the dataset back to the database.

     [!code-csharp[Trin_VstcoreDataExcel#10](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet3.cs#10)]
     [!code-vb[Trin_VstcoreDataExcel#10](../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet3.vb#10)]

## Test the application
 Now you can test your workbook to verify that the data appears as expected, and that you can manipulate the data in the list object.

### To test the data binding

- Press **F5**.

     Verify that when the workbook opens, the list object is filled with data from the **Employees** table.

### To modify data

1. Click cell **B7**, which should contain the name **Davolio**.

2. Type the name **Anderson**, and then press **Enter**.

### To modify a column header

1. Click the cell that contains the column header **LastName**.

2. Type **Last Name**, including a space between the two words, and then press **Enter**.

### To save data

1. Click **Save** on the worksheet.

2. Exit Excel. Click **No** when prompted to save the changes you made.

3. Press **F5** to run the project again.

     The list object is filled with data from the **Employees** table.

4. Notice that the name in cell **B7** is still **Anderson**, which is the data change that you made and saved back to the database. The column header **LastName** has changed back to its original form with no space, because the column header is not bound to the database and you did not save the changes you made to the worksheet.

### To add new rows

1. Select a cell inside the list object.

    A new row appears at the bottom of the list, with an asterisk (**\***) in the first cell of the new row.

2. Add the following information in the empty row.

   |EmployeeID|LastName|FirstName|Title|
   |----------------|--------------|---------------|-----------|
   |10|Ito|Shu|Sales Manager|

### To delete rows

- Right-click the number 16 (row 16) on the far left side of the worksheet, and then click **Delete**.

### To sort the rows in the List

1. Select a cell inside the list.

     Arrow buttons appear in each column header.

2. Click the arrow button in the **Last Name** column header.

3. Click **Sort Ascending**.

     The rows are sorted alphabetically by last names.

### To filter information

1. Select a cell inside the list.

2. Click the arrow button in the **Title** column header.

3. Click **Sales Representative**.

     The list shows only those rows that have **Sales Representative** in the **Title** column.

4. Click the arrow button in the **Title** column header again.

5. Click **(All)**.

     Filtering is removed and all the rows appear.

## Next steps
 This walkthrough shows the basics of binding a table in a database to a list object. Here are some tasks that might come next:

- Cache the data so that it can be used offline. For more information, see [How to: Cache data for use offline or on a server](../vsto/how-to-cache-data-for-use-offline-or-on-a-server.md).

- Deploy the solution. For more information, see [Deploy an Office solution](../vsto/deploying-an-office-solution.md).

- Create a master/detail relation between a field and a table. For more information, see [Walkthrough: Create a master detail relation using a cached dataset](../vsto/walkthrough-creating-a-master-detail-relation-using-a-cached-dataset.md).

## See also
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
- [Data in Office solutions](../vsto/data-in-office-solutions.md)
- [Walkthrough: Simple data binding in a document-level project](../vsto/walkthrough-simple-data-binding-in-a-document-level-project.md)
