---
title: "Walkthrough: Complex Data Binding in VSTO add-in Project | Microsoft Docs"
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
  - "data binding [Office development in Visual Studio], Excel"
  - "data [Office development in Visual Studio], binding data"
  - "complex data [Office development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Walkthrough: Complex Data Binding in VSTO add-in Project
  You can bind data to host controls and Windows Forms controls in VSTO Add-in projects. This walkthrough demonstrates how to add controls to a Microsoft Office Excel worksheet and bind the controls to data at run time.  
  
 [!INCLUDE[appliesto_xlallapp](../vsto/includes/appliesto-xlallapp-md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   Adding a <xref:Microsoft.Office.Tools.Excel.ListObject> control to a worksheet at run time.  
  
-   Creating a <xref:System.Windows.Forms.BindingSource> that connects the control to an instance of a dataset.  
  
 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]  
  
-   [!INCLUDE[Excel_15_short](../vsto/includes/excel-15-short-md.md)] or [!INCLUDE[Excel_14_short](../vsto/includes/excel-14-short-md.md)].  
  
-   Access to a running instance of SQL Server 2005 or SQL Server 2005 Express that has the `AdventureWorksLT` sample database attached to it. You can download the `AdventureWorksLT` database from the [CodePlex Web site](http://go.microsoft.com/fwlink/?LinkId=115611). For more information about attaching a database, see the following topics:  
  
    -   To attach a database by using SQL Server Management Studio or SQL Server Management Studio Express, see [How to: Attach a Database (SQL Server Management Studio)](http://msdn.microsoft.com/en-us/b4efb0ae-cfe6-4d81-a4b4-6e4916885caa).  
  
    -   To attach a database by using the command line, see [How to: Attach a Database File to SQL Server Express](http://msdn.microsoft.com/en-us/0f8e42b5-7a8c-4c30-8c98-7d2bdc8dcc68).  
  
## Creating a New Project  
 The first step is to create an Excel VSTO Add-in project.  
  
#### To create a new project  
  
1.  Create an Excel VSTO Add-in project with the name **Populating Worksheets from a Database**, using either Visual Basic or C#.  
  
     For more information, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).  
  
     Visual Studio opens the `ThisAddIn.vb` or `ThisAddIn.cs` file and adds the **Populating Worksheets from a Database** project to **Solution Explorer**.  
  
## Creating a Data Source  
 Use the **Data Sources** window to add a typed dataset to your project.  
  
#### To add a typed dataset to the project  
  
1.  If the **Data Sources** window is not visible, display it by, on the menu bar, choosing **View**, **Other Windows**, **Data Sources**.  
  
2.  Choose **Add New Data Source** to start the **Data Source Configuration Wizard**.  
  
3.  Click **Database**, and then click **Next**.  
  
4.  If you have an existing connection to the `AdventureWorksLT` database, choose this connection and click **Next**.  
  
     Otherwise, click **New Connection**, and use the **Add Connection** dialog box to create the new connection. For more information, see [Add new connections](../data-tools/add-new-connections.md).  
  
5.  In the **Save the Connection String to the Application Configuration File** page, click **Next**.  
  
6.  In the **Choose Your Database Objects** page, expand **Tables** and select **Address (SalesLT)**.  
  
7.  Click **Finish**.  
  
     The AdventureWorksLTDataSet.xsd file is added to **Solution Explorer**. This file defines the following items:  
  
    -   A typed dataset named `AdventureWorksLTDataSet`. This dataset represents the contents of the **Address (SalesLT)** table in the AdventureWorksLT database.  
  
    -   A TableAdapter named `AddressTableAdapter`. This TableAdapter can be used to read and write data in the `AdventureWorksLTDataSet`. For more information, see [TableAdapter Overview](../data-tools/fill-datasets-by-using-tableadapters.md#tableadapter-overview).  
  
     You will use both of these objects later in this walkthrough.  
  
## Creating Controls and Binding Controls to Data  
 For this walkthrough, the <xref:Microsoft.Office.Tools.Excel.ListObject> control displays all the data in the table you selected as soon as the user opens the workbook. The list object uses a <xref:System.Windows.Forms.BindingSource> to connect the control to the database.  
  
 For more information about binding controls to data, see [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md).  
  
#### To add the list object, dataset, and table adapter  
  
1.  In the `ThisAddIn` class, declare the following controls to display the `Address` table of the `AdventureWorksLTDataSet` dataset.  
  
     [!code-csharp[Trin_ExcelAddInDatabase#1](../vsto/codesnippet/CSharp/Trin_ExcelAddInDatabase_O12/ThisAddIn.cs#1)]
     [!code-vb[Trin_ExcelAddInDatabase#1](../vsto/codesnippet/VisualBasic/Trin_ExcelAddInDatabase_O12/ThisAddIn.vb#1)]  
  
2.  In the `ThisAddIn_Startup` method, add the following code to initialize the dataset and fill the dataset with information from the `AdventureWorksLTDataSet` dataset.  
  
     [!code-csharp[Trin_ExcelAddInDatabase#2](../vsto/codesnippet/CSharp/Trin_ExcelAddInDatabase_O12/ThisAddIn.cs#2)]
     [!code-vb[Trin_ExcelAddInDatabase#2](../vsto/codesnippet/VisualBasic/Trin_ExcelAddInDatabase_O12/ThisAddIn.vb#2)]  
  
3.  Add the following code to the `ThisAddIn_Startup` method. This generates a host item that extends the worksheet. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
     [!code-csharp[Trin_ExcelAddInDatabase#3](../vsto/codesnippet/CSharp/Trin_ExcelAddInDatabase_O12/ThisAddIn.cs#3)]
     [!code-vb[Trin_ExcelAddInDatabase#3](../vsto/codesnippet/VisualBasic/Trin_ExcelAddInDatabase_O12/ThisAddIn.vb#3)]  
  
4.  Create a range and add the <xref:Microsoft.Office.Tools.Excel.ListObject> control.  
  
     [!code-csharp[Trin_ExcelAddInDatabase#4](../vsto/codesnippet/CSharp/Trin_ExcelAddInDatabase_O12/ThisAddIn.cs#4)]
     [!code-vb[Trin_ExcelAddInDatabase#4](../vsto/codesnippet/VisualBasic/Trin_ExcelAddInDatabase_O12/ThisAddIn.vb#4)]  
  
5.  Bind the list object to `AdventureWorksLTDataSet` by using the <xref:System.Windows.Forms.BindingSource>. Pass in the names of the columns you want to bind to the list object.  
  
     [!code-csharp[Trin_ExcelAddInDatabase#5](../vsto/codesnippet/CSharp/Trin_ExcelAddInDatabase_O12/ThisAddIn.cs#5)]
     [!code-vb[Trin_ExcelAddInDatabase#5](../vsto/codesnippet/VisualBasic/Trin_ExcelAddInDatabase_O12/ThisAddIn.vb#5)]  
  
## Testing the Add-In  
 When you open Excel, the <xref:Microsoft.Office.Tools.Excel.ListObject> control displays the data from the `Address` table of the `AdventureWorksLTDataSet` dataset.  
  
#### To test the VSTO Add-in  
  
-   Press **F5**.  
  
     A <xref:Microsoft.Office.Tools.Excel.ListObject> control named `addressListObject` is created in the worksheet. At the same time, a dataset object named `adventureWorksLTDataSet` and a <xref:System.Windows.Forms.BindingSource> named `addressBindingSource` are added to the project. The <xref:Microsoft.Office.Tools.Excel.ListObject> is bound to the <xref:System.Windows.Forms.BindingSource>, which in turn is bound to the dataset object.  
  
## See Also  
 [Data in Office Solutions](../vsto/data-in-office-solutions.md)   
 [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md)   
 [How to: Populate Worksheets with Data from a Database](../vsto/how-to-populate-worksheets-with-data-from-a-database.md)   
 [How to: Populate Documents with Data from a Database](../vsto/how-to-populate-documents-with-data-from-a-database.md)   
 [How to: Populate Documents with Data from Services](../vsto/how-to-populate-documents-with-data-from-services.md)   
 [How to: Populate Documents with Data from Objects](../vsto/how-to-populate-documents-with-data-from-objects.md)   
 [How to: Scroll Through Database Records in a Worksheet](../vsto/how-to-scroll-through-database-records-in-a-worksheet.md)   
 [How to: Update a Data Source with Data from a Host Control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md)   
 [Walkthrough: Simple Data Binding in a Document-Level Project](../vsto/walkthrough-simple-data-binding-in-a-document-level-project.md)   
 [Walkthrough: Complex Data Binding in a Document-Level Project](../vsto/walkthrough-complex-data-binding-in-a-document-level-project.md)   
 [Using Local Database Files in Office Solutions Overview](../vsto/using-local-database-files-in-office-solutions-overview.md)   
 [Add new data sources](/visualstudio/data-tools/add-new-data-sources)   
 [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [Using Local Database Files in Office Solutions Overview](../vsto/using-local-database-files-in-office-solutions-overview.md)   
 [Connecting to Data in Windows Forms Applications](/visualstudio/data-tools/connecting-to-data-in-windows-forms-applications)   
 [BindingSource Component Overview](/dotnet/framework/winforms/controls/bindingsource-component-overview)  
  
  