---
title: "Walkthrough: Change cached data in a workbook on a server"
description: Learn how to modify a dataset that is cached in a Microsoft Excel workbook without starting Excel by using the ServerDocument class.
titleSuffix: ""
ms.date: "08/14/2019"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "workbooks [Office development in Visual Studio], changing server data"
  - "datasets [Office development in Visual Studio], accessing on server"
  - "server-side data access [Office development in Visual Studio]"
  - "data [Office development in Visual Studio], accessing on server"
  - "documents [Office development in Visual Studio], server-side data access"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Change cached data in a workbook on a server

  This walkthrough demonstrates how to modify a dataset that is cached in a Microsoft Office Excel workbook without starting Excel by using the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class.

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

 This walkthrough illustrates the following tasks:

- Defining a dataset that contains data from the AdventureWorksLT database.

- Creating instances of the dataset in an Excel workbook project and a console application project.

- Creating a <xref:Microsoft.Office.Tools.Excel.ListObject> that is bound to the dataset in the workbook, and populating the <xref:Microsoft.Office.Tools.Excel.ListObject> with data when the workbook is opened.

- Adding the dataset in the workbook to the data cache.

- Modifying a column of data in the cached dataset by running code in the console application, without starting Excel.

  Although this walkthrough assumes that you are running the code on your development computer, the code demonstrated by this walkthrough can be used on a server that does not have Excel installed.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

-  Excel 2010 .

- Access to a running instance of Microsoft SQL Server or Microsoft SQL Server Express that has the AdventureWorksLT sample database attached to it. You can download the AdventureWorksLT database from the [SQL Server Samples GitHub repo](https://github.com/Microsoft/sql-server-samples/releases/tag/adventureworks). For more information about attaching a database, see the following topics:

  - To attach a database by using SQL Server Management Studio or SQL Server Management Studio Express, see [How to: Attach a database (SQL Server Management Studio)](/sql/relational-databases/databases/attach-a-database).

  - To attach a database by using the command line, see [How to: Attach a database file to SQL Server Express](/previous-versions/sql/).

## Create a class library project that defines a dataset
 To use the same dataset in an Excel workbook project and a console application, you must define the dataset in a separate assembly that is referenced by both of these projects. For this walkthrough, define the dataset in a class library project.

### To create the class library project

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then click **Project**.

3. In the templates pane, expand **Visual C#** or **Visual Basic**, and then click **Windows**.

4. In the list of project templates, select **Class Library**.

5. In the **Name** box, type **AdventureWorksDataSet**.

6. Click **Browse**, navigate to your *%UserProfile%\My Documents* (for Windows XP and earlier) or *%UserProfile%\Documents* (for Windows Vista) folder, and then click **Select Folder**.

7. In the **New Project** dialog box, ensure that the **Create directory for solution** check box is not selected.

8. Click **OK**.

     Visual Studio adds the **AdventureWorksDataSet** project to **Solution Explorer** and opens the **Class1.cs** or **Class1.vb** code file.

9. In **Solution Explorer**, right-click **Class1.cs** or **Class1.vb**, and then click **Delete**. You do not need this file for this walkthrough.

## Define a dataset in the class library project
 Define a typed dataset that contains data from the AdventureWorksLT database for SQL Server 2005. Later in this walkthrough, you will reference this dataset from an Excel workbook project and a console application project.

 The dataset is a *typed dataset* that represents the data in the Product table of the AdventureWorksLT database. For more information about typed datasets, see [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md).

### To define a typed dataset in the class library project

1. In **Solution Explorer**, click the **AdventureWorksDataSet** project.

2. If the **Data Sources** window is not visible, display it by, on the menu bar, choosing **View** > **Other Windows** > **Data Sources**.

3. Choose **Add New Data Source** to start the **Data Source Configuration Wizard**.

4. Click **Database**, and then click **Next**.

5. If you have an existing connection to the AdventureWorksLT database, choose this connection and click **Next**.

    Otherwise, click **New Connection**, and use the **Add Connection** dialog box to create the new connection. For more information, see [Add new connections](../data-tools/add-new-connections.md).

6. In the **Save the Connection String to the Application Configuration File** page, click **Next**.

7. In the **Choose Your Database Objects** page, expand **Tables** and select **Product (SalesLT)**.

8. Click **Finish**.

    The *AdventureWorksLTDataSet.xsd* file is added to the **AdventureWorksDataSet** project. This file defines the following items:

   - A typed dataset named `AdventureWorksLTDataSet`. This dataset represents the contents of the Product table in the AdventureWorksLT database.

   - A TableAdapter named `ProductTableAdapter`. This TableAdapter can be used to read and write data in the `AdventureWorksLTDataSet`. For more information, see [TableAdapter overview](../data-tools/fill-datasets-by-using-tableadapters.md#tableadapter-overview).

     You will use both of these objects later in this walkthrough.

9. In **Solution Explorer**, right-click **AdventureWorksDataSet** and click **Build**.

     Verify that the project builds without errors.

## Create an Excel workbook project
 Create an Excel workbook project for the interface to the data. Later in this walkthrough, you will create a <xref:Microsoft.Office.Tools.Excel.ListObject> that displays the data, and you will add an instance of the dataset to the data cache in the workbook.

### To create the Excel workbook project

1. In **Solution Explorer**, right-click the **AdventureWorksDataSet** solution, point to **Add**, and then click **New Project**.

2. In the templates pane, expand **Visual C#** or **Visual Basic**, and then expand **Office**.

3. Under the expanded **Office** node, select the **2010** node.

4. In the list of project templates, select the Excel Workbook project.

5. In the **Name** box, type **AdventureWorksReport**. Do not modify the location.

6. Click **OK**.

     The **Visual Studio Tools for Office Project Wizard** opens.

7. Ensure that **Create a new document** is selected, and click **OK**.

     Visual Studio opens the **AdventureWorksReport** workbook in the designer and adds the **AdventureWorksReport** project to **Solution Explorer**.

## Add the dataset to data sources in the Excel workbook project
 Before you can display the dataset in the Excel workbook, you must first add the dataset to data sources in the Excel workbook project.

### To add the dataset to the data sources in the Excel workbook project

1. In **Solution Explorer**, double-click **Sheet1.cs** or **Sheet1.vb** under the **AdventureWorksReport** project.

     The workbook opens in the designer.

2. On the **Data** menu, click **Add New Data Source**.

     The **Data Source Configuration Wizard** opens.

3. Click **Object**, and then click **Next**.

4. In the **Select the Object You Wish to Bind to** page, click **Add Reference**.

5. On the **Projects** tab, click **AdventureWorksDataSet** and then click **OK**.

6. Under the **AdventureWorksDataSet** namespace of the **AdventureWorksDataSet** assembly, click **AdventureWorksLTDataSet** and then click **Finish**.

     The **Data Sources** window opens, and **AdventureWorksLTDataSet** is added to the list of data sources.

## Create a ListObject that is bound to an instance of the dataset
 To display the dataset in the workbook, create a <xref:Microsoft.Office.Tools.Excel.ListObject> that is bound to an instance of the dataset. For more information about binding controls to data, see [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md).

### To create a ListObject that is bound to an instance of the dataset

1. In the **Data Sources** window, expand the **AdventureWorksLTDataSet** node under **AdventureWorksDataSet**.

2. Select the **Product** node, click the drop-down arrow that appears, and select **ListObject** in the drop-down list.

     If the drop-down arrow does not appear, confirm that the workbook is open in the designer.

3. Drag the **Product** table to cell A1.

     A <xref:Microsoft.Office.Tools.Excel.ListObject> control named `productListObject` is created on the worksheet, starting in cell A1. At the same time, a dataset object named `adventureWorksLTDataSet` and a <xref:System.Windows.Forms.BindingSource> named `productBindingSource` are added to the project. The <xref:Microsoft.Office.Tools.Excel.ListObject> is bound to the <xref:System.Windows.Forms.BindingSource>, which in turn is bound to the dataset object.

## Add the dataset to the data cache
 To enable code outside the Excel workbook project to access the dataset in the workbook, you must add the dataset to the data cache. For more information about the data cache, see [Cached data in document-level customizations](../vsto/cached-data-in-document-level-customizations.md) and [Cache data](../vsto/caching-data.md).

### To add the dataset to the data cache

1. In the designer, click **adventureWorksLTDataSet**.

2. In the **Properties** window, set the **Modifiers** property to **Public**.

3. Set the **CacheInDocument** property to **True**.

## Initialize the dataset in the workbook
 Before you can retrieve the data from the cached dataset by using the console application, you must first populate the cached dataset with data.

### To initialize the dataset in the workbook

1. In **Solution Explorer**, right-click the **Sheet1.cs** or **Sheet1.vb** file and click **View Code**.

2. Replace the `Sheet1_Startup` event handler with the following code. This code uses an instance of the `ProductTableAdapter` class that is defined in the **AdventureWorksDataSet** project to fill the cached dataset with data, if it is currently empty.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/AdventureWorksDataSet/AdventureWorksReport/Sheet1.cs" id="Snippet8":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/AdventureWorksDataSet/AdventureWorksReport/Sheet1.vb" id="Snippet8":::
     ---

## Checkpoint
 Build and run the Excel workbook project to ensure that it compiles and runs without errors. This operation also fills the cached dataset and saves the data in the workbook.

### To build and run the project

1. In **Solution Explorer**, right-click the **AdventureWorksReport** project, choose **Debug**, and then click **Start new instance**.

     The project is built, and the workbook opens in Excel. Verify the following:

    - The <xref:Microsoft.Office.Tools.Excel.ListObject> fills with data.

    - The value in the **ListPrice** column for the first row of the <xref:Microsoft.Office.Tools.Excel.ListObject> is 1431.5. Later in this walkthrough, you will use a console application to modify the values in the **ListPrice** column.

2. Save the workbook. Do not modify the file name or the location of the workbook.

3. Close Excel.

## Create a console application project
 Create a console application project to use to modify data in the cached dataset in the workbook.

### To create the console application project

1. In **Solution Explorer**, right-click the **AdventureWorksDataSet** solution, point to **Add**, and then click **New Project**.

2. In the **Project Types** pane, expand **Visual C#** or **Visual Basic**, and then click **Windows**.

3. In the **Templates** pane, select **Console Application**.

4. In the **Name** box, type **DataWriter**. Do not modify the location.

5. Click **OK**.

     Visual Studio adds the **DataWriter** project to **Solution Explorer** and opens the **Program.cs** or **Module1.vb** code file.

## Change data in the cached dataset by using the console application
 Use the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class in the console application to read the data into a local `AdventureWorksLTDataSet` object, modify this data, and then save it back to the cached dataset.

### To change data in the cached dataset

1. In **Solution Explorer**, right-click the **DataWriter** project and click **Add Reference**.

2. On the **.NET** tab, select **Microsoft.VisualStudio.Tools.Applications**.

3. Click **OK**.

4. In **Solution Explorer**, right-click the **DataWriter** project and click **Add Reference**.

5. On the **Projects** tab, select **AdventureWorksDataSet**, and click **OK**.

6. Open the *Program.cs* or *Module1.vb* file in the Code Editor.

7. Add the following **using** (for C#) or **Imports** (for Visual Basic) statement to the top of the code file.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/AdventureWorksDataSet/DataWriter/Program.cs" id="Snippet1":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/AdventureWorksDataSet/DataWriter/Module1.vb" id="Snippet1":::
    ---

8. Add the following code to the `Main` method. This code declares the following objects:

   - An instance of the `AdventureWorksLTDataSet` type that is defined in the **AdventureWorksDataSet** project.

   - The path to the AdventureWorksReport workbook in the build folder of the **AdventureWorksReport** project.

   - A <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> object to use to access the data cache in the workbook.

     > [!NOTE]
     > The following code assumes that you are using a workbook that has the *.xlsx* file extension. If the workbook in your project has a different file extension, modify the path as necessary.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/AdventureWorksDataSet/DataWriter/Program.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/AdventureWorksDataSet/DataWriter/Module1.vb" id="Snippet6":::
     ---

9. Add the following code to the `Main` method, after the code you added in the previous step. This code performs the following tasks:

   - It uses the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.CachedData%2A> property of the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class to access the cached dataset in the workbook.

   - It reads the data from the cached dataset into the local dataset.

   - It changes the `ListPrice` value of each product in the Product table of the dataset.

   - It saves the changes to the cached dataset in the workbook.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/AdventureWorksDataSet/DataWriter/Program.cs" id="Snippet7":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/AdventureWorksDataSet/DataWriter/Module1.vb" id="Snippet7":::
     ---

10. In **Solution Explorer**, right-click the **DataWriter** project, point to **Debug**, and then click **Start new instance**.

     The console application displays messages while it reads the cached dataset into the local dataset, modifies the product prices in the local dataset, and saves the new values to the cached dataset. Press **Enter** to close the application.

## Test the workbook
 When you open the workbook, the <xref:Microsoft.Office.Tools.Excel.ListObject> now displays the changes you made to the `ListPrice` column of data in the cached dataset.

### To test the workbook

1. Close the AdventureWorksReport workbook in the Visual Studio designer, if it is still open.

2. Open the AdventureWorksReport workbook that is in the build folder of the **AdventureWorksReport** project. By default, the build folder is in one of the following locations:

    - *%UserProfile%\My Documents\AdventureWorksReport\bin\Debug* (for Windows XP and earlier)

    - *%UserProfile%\Documents\AdventureWorksReport\bin\Debug* (for Windows Vista)

3. Verify that the value in the **ListPrice** column for the first row of the <xref:Microsoft.Office.Tools.Excel.ListObject> is now 1574.65.

4. Close the workbook.

## Related content

- [Walkthrough: Insert data into a workbook on a server](../vsto/walkthrough-inserting-data-into-a-workbook-on-a-server.md)
