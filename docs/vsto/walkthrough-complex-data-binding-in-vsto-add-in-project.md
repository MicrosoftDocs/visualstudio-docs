---
title: "Walkthrough: Complex data binding in VSTO Add-in project"
description: Learn how to add controls to a Microsoft Excel worksheet and bind the controls to data at run time.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "data binding [Office development in Visual Studio], Excel"
  - "data [Office development in Visual Studio], binding data"
  - "complex data [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Walkthrough: Complex data binding in VSTO Add-in project
  You can bind data to host controls and Windows Forms controls in VSTO Add-in projects. This walkthrough demonstrates how to add controls to a Microsoft Office Excel worksheet and bind the controls to data at run time.

 [!INCLUDE[appliesto_xlallapp](../vsto/includes/appliesto-xlallapp-md.md)]

 This walkthrough illustrates the following tasks:

- Adding a <xref:Microsoft.Office.Tools.Excel.ListObject> control to a worksheet at run time.

- Creating a <xref:System.Windows.Forms.BindingSource> that connects the control to an instance of a dataset.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- [!INCLUDE[Excel_15_short](../vsto/includes/excel-15-short-md.md)] or [!INCLUDE[Excel_14_short](../vsto/includes/excel-14-short-md.md)].

- Access to a running instance of SQL Server 2005 or SQL Server 2005 Express that has the `AdventureWorksLT` sample database attached to it. You can download the `AdventureWorksLT` database from the [SQL Server Samples GitHub repo](https://github.com/Microsoft/sql-server-samples/releases/tag/adventureworks). For more information about attaching a database, see the following topics:

  - To attach a database by using SQL Server Management Studio or SQL Server Management Studio Express, see [How to: Attach a database (SQL Server Management Studio)](/sql/relational-databases/databases/attach-a-database).

  - To attach a database by using the command line, see [How to: Attach a database file to SQL Server Express](/previous-versions/sql/).

## Create a new project
 The first step is to create an Excel VSTO Add-in project.

### To create a new project

1. Create an Excel VSTO Add-in project with the name **Populating Worksheets from a Database**, using either Visual Basic or C#.

     For more information, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the `ThisAddIn.vb` or `ThisAddIn.cs` file and adds the **Populating Worksheets from a Database** project to **Solution Explorer**.

## Create a data source
 Use the **Data Sources** window to add a typed dataset to your project.

### To add a typed dataset to the project

1. If the **Data Sources** window is not visible, display it by, on the menu bar, choosing **View** > **Other Windows** > **Data Sources**.

2. Choose **Add New Data Source** to start the **Data Source Configuration Wizard**.

3. Click **Database**, and then click **Next**.

4. If you have an existing connection to the `AdventureWorksLT` database, choose this connection and click **Next**.

    Otherwise, click **New Connection**, and use the **Add Connection** dialog box to create the new connection. For more information, see [Add new connections](../data-tools/add-new-connections.md).

5. In the **Save the Connection String to the Application Configuration File** page, click **Next**.

6. In the **Choose Your Database Objects** page, expand **Tables** and select **Address (SalesLT)**.

7. Click **Finish**.

    The *AdventureWorksLTDataSet.xsd* file is added to **Solution Explorer**. This file defines the following items:

   - A typed dataset named `AdventureWorksLTDataSet`. This dataset represents the contents of the **Address (SalesLT)** table in the AdventureWorksLT database.

   - A TableAdapter named `AddressTableAdapter`. This TableAdapter can be used to read and write data in the `AdventureWorksLTDataSet`. For more information, see [TableAdapter overview](../data-tools/fill-datasets-by-using-tableadapters.md#tableadapter-overview).

     You will use both of these objects later in this walkthrough.

## Create controls and bind controls to data
 For this walkthrough, the <xref:Microsoft.Office.Tools.Excel.ListObject> control displays all the data in the table you selected as soon as the user opens the workbook. The list object uses a <xref:System.Windows.Forms.BindingSource> to connect the control to the database.

 For more information about binding controls to data, see [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md).

### To add the list object, dataset, and table adapter

1. In the `ThisAddIn` class, declare the following controls to display the `Address` table of the `AdventureWorksLTDataSet` dataset.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_ExcelAddInDatabase_O12/ThisAddIn.cs" id="Snippet1":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_ExcelAddInDatabase_O12/ThisAddIn.vb" id="Snippet1":::

2. In the `ThisAddIn_Startup` method, add the following code to initialize the dataset and fill the dataset with information from the `AdventureWorksLTDataSet` dataset.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_ExcelAddInDatabase_O12/ThisAddIn.cs" id="Snippet2":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_ExcelAddInDatabase_O12/ThisAddIn.vb" id="Snippet2":::

3. Add the following code to the `ThisAddIn_Startup` method. This generates a host item that extends the worksheet. For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_ExcelAddInDatabase_O12/ThisAddIn.cs" id="Snippet3":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_ExcelAddInDatabase_O12/ThisAddIn.vb" id="Snippet3":::

4. Create a range and add the <xref:Microsoft.Office.Tools.Excel.ListObject> control.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_ExcelAddInDatabase_O12/ThisAddIn.cs" id="Snippet4":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_ExcelAddInDatabase_O12/ThisAddIn.vb" id="Snippet4":::

5. Bind the list object to `AdventureWorksLTDataSet` by using the <xref:System.Windows.Forms.BindingSource>. Pass in the names of the columns you want to bind to the list object.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_ExcelAddInDatabase_O12/ThisAddIn.cs" id="Snippet5":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_ExcelAddInDatabase_O12/ThisAddIn.vb" id="Snippet5":::

## Test the Add-in
 When you open Excel, the <xref:Microsoft.Office.Tools.Excel.ListObject> control displays the data from the `Address` table of the `AdventureWorksLTDataSet` dataset.

### To test the VSTO Add-in

- Press **F5**.

     A <xref:Microsoft.Office.Tools.Excel.ListObject> control named `addressListObject` is created in the worksheet. At the same time, a dataset object named `adventureWorksLTDataSet` and a <xref:System.Windows.Forms.BindingSource> named `addressBindingSource` are added to the project. The <xref:Microsoft.Office.Tools.Excel.ListObject> is bound to the <xref:System.Windows.Forms.BindingSource>, which in turn is bound to the dataset object.

## See also

- [Data in Office solutions](../vsto/data-in-office-solutions.md)
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
- [How to: Populate worksheets with data from a database](../vsto/how-to-populate-worksheets-with-data-from-a-database.md)
- [How to: Populate documents with data from a database](../vsto/how-to-populate-documents-with-data-from-a-database.md)
- [How to: Populate documents with data from services](../vsto/how-to-populate-documents-with-data-from-services.md)
- [How to: Populate documents with data from objects](../vsto/how-to-populate-documents-with-data-from-objects.md)
- [How to: Scroll through database records in a worksheet](../vsto/how-to-scroll-through-database-records-in-a-worksheet.md)
- [How to: Update a data source with data from a host control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md)
- [Walkthrough: Simple data binding in a document-level project](../vsto/walkthrough-simple-data-binding-in-a-document-level-project.md)
- [Walkthrough: Complex data binding in a document-level project](../vsto/walkthrough-complex-data-binding-in-a-document-level-project.md)
- [Use local database files in Office solutions overview](../vsto/using-local-database-files-in-office-solutions-overview.md)
- [Add new data sources](../data-tools/add-new-data-sources.md)
- [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
- [Use local database files in Office solutions overview](../vsto/using-local-database-files-in-office-solutions-overview.md)
- [BindingSource component overview](/dotnet/framework/winforms/controls/bindingsource-component-overview)
