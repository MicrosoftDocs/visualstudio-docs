---
title: "Walkthrough: Simple Data Binding in a Document-Level Project | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "data binding [Office development in Visual Studio], worksheet cell to Database field"
  - "worksheets [Office development in Visual Studio], binding worksheet cell to Database field"
  - "Database field [Office development in Visual Studio]"
  - "data [Office development in Visual Studio], binding data"
  - "simple data binding [Office development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Walkthrough: Simple Data Binding in a Document-Level Project
  This walkthrough demonstrates the basics of data binding in a document-level project. A single data field in a SQL Server database is bound to a named range in Microsoft Office Excel. The walkthrough also shows how to add controls that enable you to scroll through all the records in the table.  
  
 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   Creating a data source for an Excel project.  
  
-   Adding controls to a worksheet.  
  
-   Scrolling through database records.  
  
 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]  
  
-   [!INCLUDE[Excel_15_short](../vsto/includes/excel-15-short-md.md)] or [!INCLUDE[Excel_14_short](../vsto/includes/excel-14-short-md.md)].  
  
-   Access to a server with the Northwind SQL Server sample database.  
  
-   Permissions to read from and write to the SQL Server database.  
  
## Creating a New Project  
 In this step, you will create an Excel workbook project.  
  
#### To create a new project  
  
1.  Create an Excel workbook project with the name **My Simple Data Binding**, using either Visual Basic or C#. Make sure that **Create a new document** is selected. For more information, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).  
  
 Visual Studio opens the new Excel workbook in the designer and adds the **My Simple Data Binding** project to **Solution Explorer**.  
  
## Creating the Data Source  
 Use the **Data Sources** window to add a typed dataset to your project.  
  
#### To create the data source  
  
1.  If the **Data Sources** window is not visible, display it by, on the menu bar, choosing **View**, **Other Windows**, **Data Sources**.  
  
2.  Choose **Add New Data Source** to start the **Data Source Configuration Wizard**.  
  
3.  Select **Database** and then click **Next**.  
  
4.  Select a data connection to the Northwind sample SQL Server database, or add a new connection using the **New Connection** button.  
  
5.  After a connection has been selected or created, click **Next**.  
  
6.  Clear the option to save the connection if it is selected, and then click **Next**.  
  
7.  Expand the **Tables** node in the **Database objects** window.  
  
8.  Select the check box next to the **Customers** table.  
  
9. Click **Finish**.  
  
 The wizard adds the **Customers** table to the **Data Sources** window. It also adds a typed dataset to your project that is visible in **Solution Explorer**.  
  
## Adding Controls to the Worksheet  
 For this walkthrough, you need two named ranges and four buttons on the first worksheet. First, add the two named ranges from the **Data Sources** window so that they are automatically bound to the data source. Next, add the buttons from the **Toolbox**.  
  
#### To add two named ranges  
  
1.  Verify that the **My Simple Data Binding.xlsx** workbook is open in the Visual Studio designer, with **Sheet1** displayed.  
  
2.  Open the **Data Sources** window and expand the **Customers** node.  
  
3.  Select the **CompanyName** column, and then click the drop-down arrow that appears.  
  
4.  Select **NamedRange** in the drop-down list, and then drag the **CompanyName** column to cell **A1**.  
  
     A <xref:Microsoft.Office.Tools.Excel.NamedRange> control named `companyNameNamedRange` is created in cell **A1**. At the same time, a <xref:System.Windows.Forms.BindingSource> named `customersBindingSource`, a table adapter, and a <xref:System.Data.DataSet> instance are added to the project. The control is bound to the <xref:System.Windows.Forms.BindingSource>, which in turn is bound to the <xref:System.Data.DataSet> instance.  
  
5.  Select the **CustomerID** column in the **Data Sources** window, and then click the drop-down arrow that appears.  
  
6.  Click **NamedRange** in the drop-down list, and then drag the **CustomerID** column to cell **B1**.  
  
7.  Another <xref:Microsoft.Office.Tools.Excel.NamedRange> control named `customerIDNamedRange` is created in cell **B1**, and bound to the <xref:System.Windows.Forms.BindingSource>.  
  
#### To add four buttons  
  
1.  From the **Common Controls** tab of the **Toolbox**, add a <xref:System.Windows.Forms.Button> control to cell **A3** of the worksheet.  
  
     This button is named `Button1`.  
  
2.  Add three more buttons to the following cells in this order, so that the names are as shown:  
  
    |Cell|(Name)|  
    |----------|--------------|  
    |B3|Button2|  
    |C3|Button3|  
    |D3|Button4|  
  
 The next step is to add text to the buttons, and in C# add event handlers.  
  
## Initializing the Controls  
 Set the button text and add event handlers during the <xref:Microsoft.Office.Tools.Excel.Worksheet.Startup> event.  
  
#### To initialize the controls  
  
1.  In **Solution Explorer**, right-click **Sheet1.vb** or **Sheet1.cs**, and then click **View Code** on the shortcut menu.  
  
2.  Add the following code to the `Sheet1_Startup` method to set the text for each button.  
  
     [!code-csharp[Trin_VstcoreDataExcel#2](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs#2)]
     [!code-vb[Trin_VstcoreDataExcel#2](../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb#2)]  
  
3.  For C# only, add event handlers for the button click events to the `Sheet1_Startup` method.  
  
     [!code-csharp[Trin_VstcoreDataExcel#3](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs#3)]  
  
 Now add code to handle the <xref:System.Windows.Forms.Control.Click> events of the buttons so that the user can browse through the records.  
  
## Adding Code to Enable Scrolling Through the Records  
 Add code to the <xref:System.Windows.Forms.Control.Click> event handler of each button to move through the records.  
  
#### To move to the first record  
  
1.  Add an event handler for the <xref:System.Windows.Forms.Control.Click> event of the `Button1` button, and add the following code to move to the first record:  
  
     [!code-csharp[Trin_VstcoreDataExcel#4](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs#4)]
     [!code-vb[Trin_VstcoreDataExcel#4](../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb#4)]  
  
#### To move to the previous record  
  
1.  Add an event handler for the <xref:System.Windows.Forms.Control.Click> event of the `Button2` button, and add the following code to move the position back by one:  
  
     [!code-csharp[Trin_VstcoreDataExcel#5](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs#5)]
     [!code-vb[Trin_VstcoreDataExcel#5](../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb#5)]  
  
#### To move to the next record  
  
1.  Add an event handler for the <xref:System.Windows.Forms.Control.Click> event of the `Button3` button, and add the following code to advance the position by one:  
  
     [!code-csharp[Trin_VstcoreDataExcel#6](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs#6)]
     [!code-vb[Trin_VstcoreDataExcel#6](../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb#6)]  
  
#### To move to the last record  
  
1.  Add an event handler for the <xref:System.Windows.Forms.Control.Click> event of the `Button4` button, and add the following code to move to the last record:  
  
     [!code-csharp[Trin_VstcoreDataExcel#7](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs#7)]
     [!code-vb[Trin_VstcoreDataExcel#7](../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb#7)]  
  
## Testing the Application  
 Now you can test your workbook to make sure that you can browse through the records in the database.  
  
#### To test your workbook  
  
1.  Press F5 to run your project.  
  
2.  Confirm that the first record appears in cells **A1** and **B1**.  
  
3.  Click the **>** (`Button3`) button and confirm that the next record appears in cell **A1** and **B1**.  
  
4.  Click the other scroll buttons to confirm that the record changes as expected.  
  
## Next Steps  
 This walkthrough shows the basics of binding a named range to a field in a database. Here are some tasks that might come next:  
  
-   Cache the data so that it can be used offline. For more information, see [How to: Cache Data for Use Offline or on a Server](../vsto/how-to-cache-data-for-use-offline-or-on-a-server.md).  
  
-   Bind cells to multiple columns in a table, instead of to one field. For more information, see [Walkthrough: Complex Data Binding in a Document-Level Project](../vsto/walkthrough-complex-data-binding-in-a-document-level-project.md).  
  
-   Use a <xref:System.Windows.Forms.BindingNavigator> control to scroll through the records. For more information, see [How to: Navigate Data with the Windows Forms BindingNavigator Control](/dotnet/framework/winforms/controls/bindingnavigator-control-overview-windows-forms).  
  
## See Also  
 [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md)   
 [Data in Office Solutions](../vsto/data-in-office-solutions.md)   
 [Walkthrough: Complex Data Binding in a Document-Level Project](../vsto/walkthrough-complex-data-binding-in-a-document-level-project.md)  
  
  