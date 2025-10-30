---
title: "Walkthrough: Simple data binding in VSTO Add-in project"
description: Learn how you can add controls to a Microsoft Word document and bind the controls to data at run time.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "data [Office development in Visual Studio], binding data"
  - "data binding [Office development in Visual Studio], Word"
  - "data [Office development in Visual Studio], simple binding data"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Simple data binding in VSTO Add-in Project

You can bind data to host controls and Windows Forms controls in VSTO Add-in projects. This walkthrough demonstrates how to add controls to a Microsoft Office Word document and bind the controls to data at run time.

[!INCLUDE[appliesto_wdallapp](../vsto/includes/appliesto-wdallapp-md.md)]

This walkthrough illustrates the following tasks:

- Adding a <xref:Microsoft.Office.Tools.Word.ContentControl> to a document at run time.

- Creating a <xref:System.Windows.Forms.BindingSource> that connects the control to an instance of a dataset.

- Enabling the user to scroll through the records and view them in the control.

[!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites

You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

-  Word 2013  or  Word 2010 .

- Access to a running instance of SQL Server 2005 or SQL Server 2005 Express that has the `AdventureWorksLT` sample database attached to it. You can download the `AdventureWorksLT` database from the [SQL Server Samples GitHub repo](https://github.com/Microsoft/sql-server-samples/releases/tag/adventureworks). For more information about attaching a database, see the following topics:

  - To attach a database by using SQL Server Management Studio or SQL Server Management Studio Express, see [How to: Attach a database (SQL Server Management Studio)](/sql/relational-databases/databases/attach-a-database).

  - To attach a database by using the command line, see [How to: Attach a database file to SQL Server Express](/previous-versions/sql/).

## Create a new project

The first step is to create a Word VSTO Add-in project.

### To create a new project

1. Create a Word VSTO Add-in project with the name **Populating Documents from a Database**, using either Visual Basic or C#.

     For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the *ThisAddIn.vb* or *ThisAddIn.cs* file and adds the **Populating Documents from a Database** project to **Solution Explorer**.

2. If your project targets the .NET Framework 4 or the .NET Framework 4.5, add a reference to the *Microsoft.Office.Tools.Word.v4.0.Utilities.dll* assembly. This reference is required to programmatically add Windows Forms controls to the document later in this walkthrough.

## Create a data source

Use the **Data Sources** window to add a typed dataset to your project.

### To add a typed dataset to the project

1. If the **Data Sources** window is not visible, display it by, on the menu bar, choosing **View** > **Other Windows** > **Data Sources**.

2. Choose **Add New Data Source** to start the **Data Source Configuration Wizard**.

3. Click **Database**, and then click **Next**.

4. If you have an existing connection to the `AdventureWorksLT` database, choose this connection and click **Next**.

    Otherwise, click **New Connection**, and use the **Add Connection** dialog box to create the new connection. For more information, see [Add new connections](../data-tools/add-new-connections.md).

5. In the **Save the Connection String to the Application Configuration File** page, click **Next**.

6. In the **Choose Your Database Objects** page, expand **Tables** and select **Customer (SalesLT)**.

7. Click **Finish**.

    The *AdventureWorksLTDataSet.xsd* file is added to **Solution Explorer**. This file defines the following items:

   - A typed dataset named `AdventureWorksLTDataSet`. This dataset represents the contents of the **Customer (SalesLT)** table in the AdventureWorksLT database.

   - A TableAdapter named `CustomerTableAdapter`. This TableAdapter can be used to read and write data in the `AdventureWorksLTDataSet`. For more information, see [TableAdapter overview](../data-tools/fill-datasets-by-using-tableadapters.md#tableadapter-overview).

     You will use both of these objects later in this walkthrough.

## Create controls and binding controls to data

The interface for viewing database records in this walkthrough is basic, and it is created right inside the document. One <xref:Microsoft.Office.Tools.Word.ContentControl> displays a single database record at a time, and two <xref:Microsoft.Office.Tools.Word.Controls.Button> controls enable you to scroll back and forth through the records. The content control uses a <xref:System.Windows.Forms.BindingSource> to connect to the database.

For more information about binding controls to data, see [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md).

### To create the interface in the document

1. In the `ThisAddIn` class, declare the following controls to display and scroll through the `Customer` table of the `AdventureWorksLTDataSet` database.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_wordaddindatabase/ThisAddIn.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindatabase/ThisAddIn.vb" id="Snippet1":::
     ---

2. In the `ThisAddIn_Startup` method, add the following code to initialize the dataset, fill the dataset with information from the `AdventureWorksLTDataSet` database.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_wordaddindatabase/ThisAddIn.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindatabase/ThisAddIn.vb" id="Snippet2":::
     ---

3. Add the following code to the `ThisAddIn_Startup` method. This generates a host item that extends the document. For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_wordaddindatabase/ThisAddIn.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindatabase/ThisAddIn.vb" id="Snippet3":::
     ---

4. Define several ranges at the beginning of the document. These ranges identify where to insert text and place controls.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_wordaddindatabase/ThisAddIn.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindatabase/ThisAddIn.vb" id="Snippet4":::
     ---

5. Add the interface controls to the previously defined ranges.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_wordaddindatabase/ThisAddIn.cs" id="Snippet5":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindatabase/ThisAddIn.vb" id="Snippet5":::
     ---

6. Bind the content control to `AdventureWorksLTDataSet` by using the <xref:System.Windows.Forms.BindingSource>. For C# developers, add two event handlers for the <xref:Microsoft.Office.Tools.Word.Controls.Button> controls.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_wordaddindatabase/ThisAddIn.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindatabase/ThisAddIn.vb" id="Snippet6":::
     ---

7. Add the following code to navigate through the database records.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_wordaddindatabase/ThisAddIn.cs" id="Snippet7":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindatabase/ThisAddIn.vb" id="Snippet7":::
     ---

## Test the Add-in

When you open Word, the content control displays data from the `AdventureWorksLTDataSet` dataset. Scroll through the database records by clicking the **Next** and **Previous** buttons.

### To test the VSTO Add-in

1. Press **F5**.

     A content control named `customerContentControl` is created and populated with data. At the same time, a dataset object named `adventureWorksLTDataSet` and a <xref:System.Windows.Forms.BindingSource> named `customerBindingSource` are added to the project. The <xref:Microsoft.Office.Tools.Word.ContentControl> is bound to the <xref:System.Windows.Forms.BindingSource>, which in turn is bound to the dataset object.

2. Click the **Next** and **Previous** buttons to scroll through the database records.

## Related content

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
- [How to: Populate documents with data from objects](../vsto/how-to-populate-documents-with-data-from-objects.md)
- [How to: Update a data source with data from a host control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md)
- [Use local database files in Office solutions overview](../vsto/using-local-database-files-in-office-solutions-overview.md)
- [BindingSource component overview](/dotnet/framework/winforms/controls/bindingsource-component-overview)
