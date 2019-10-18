---
title: "Save data with the TableAdapter DBDirect methods | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "TableAdapters, walkthroughs"
  - "data [Visual Studio], saving"
  - "saving data, walkthroughs"
  - "data [Visual Studio], TableAdapter"
ms.assetid: 74a6773b-37e1-4d96-a39c-63ee0abf49b1
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# Save data with the TableAdapter DBDirect methods
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This walkthrough provides detailed instructions for running SQL statements directly against a database by using the DBDirect methods of a TableAdapter. The DBDirect methods of a TableAdapter provide a fine level of control over your database updates. You can use them to run specific SQL statements and stored procedures by calling the individual `Insert`, `Update`, and `Delete` methods as needed by your application (as opposed to the overloaded `Update` method that performs the UPDATE, INSERT, and DELETE statements all in one call).

 During this walkthrough, you will learn how to:

- Create a new **Windows Application**.

- Create and configure a dataset with the [Data Source Configuration Wizard](https://msdn.microsoft.com/library/c4df7de5-5da0-4064-940c-761dd6d9e28f).

- Select the control to be created on the form when dragging items from the **Data Sources** window. For more information, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).

- Create a data-bound form by dragging items from the **Data Sources** window onto the form.

- Add methods to directly access the database and perform inserts, updates, and deletes..

## Prerequisites
 In order to complete this walkthrough, you will need:

- Access to the Northwind sample database.

## Create a Windows application
 The first step is to create a **Windows Application**.

#### To create the new Windows project

1. In Visual Studio, on the **File** menu, create a new **Project**.

2. Name the project **TableAdapterDbDirectMethodsWalkthrough**.

3. Select **Windows Application**, and then select **OK**. For more information, see [Client Applications](https://msdn.microsoft.com/library/2dfb50b7-5af2-4e12-9bbb-c5ade0e39a68).

     The **TableAdapterDbDirectMethodsWalkthrough** project is created and added to **Solution Explorer**.

## Create a data source from your database
 This step uses the **Data Source Configuration Wizard** to create a data source based on the `Region` table in the Northwind sample database. You must have access to the Northwind sample database to create the connection.

#### To create the data source

1. On the **Data** menu, select **Show Data Sources**.

2. In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration Wizard**.

3. On the **Choose a Data Source Type** screen, select **Database**, and then select **Next**.

4. On the **Choose your Data Connection** screen, do one of the following:

    - If a data connection to the Northwind sample database is available in the drop-down list, select it.

         -or-

    - Select **New Connection** to launch the **Add/Modify Connection** dialog box.

5. If your database requires a password, select the option to include sensitive data, and then select **Next**.

6. On the **Save connection string to the Application Configuration file** screen, select **Next**.

7. On the **Choose your Database Objects** screen, expand the **Tables** node.

8. Select the `Region` table, and then select **Finish**.

     The **NorthwindDataSet** is added to your project and the `Region` table appears in the **Data Sources** window.

## Addcontrols to the form to display the data
 Create the data-bound controls by dragging items from the **Data Sources** window onto your form.

#### To create data bound controls on the Windows form

- Drag the main **Region** node from the **Data Sources** window onto the form.

     A <xref:System.Windows.Forms.DataGridView> control and a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records appear on the form. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), RegionTableAdapter, <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.

#### To add buttons that will call the individual TableAdapter DbDirect methods

1. Drag three <xref:System.Windows.Forms.Button> controls from the **Toolbox** onto **Form1** (below the **RegionDataGridView**).

2. Set the following **Name** and **Text** properties on each button.

    |Name|Text|
    |----------|----------|
    |`InsertButton`|**Insert**|
    |`UpdateButton`|**Update**|
    |`DeleteButton`|**Delete**|

#### To add code to insert new records into the database

1. Select **InsertButton** to create an event handler for the click event and open your form in the code editor.

2. Replace the `InsertButton_Click` event handler with the following code:

     [!code-csharp[VbRaddataSaving#1](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form1.cs#1)]
     [!code-vb[VbRaddataSaving#1](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form1.vb#1)]

#### To add code to update records in the database

1. Double-click the **UpdateButton** to create an event handler for the click event and open your form in the code editor.

2. Replace the `UpdateButton_Click` event handler with the following code:

     [!code-csharp[VbRaddataSaving#2](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form1.cs#2)]
     [!code-vb[VbRaddataSaving#2](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form1.vb#2)]

#### To add code to delete records from the database

1. Select **DeleteButton** to create an event handler for the click event and open your form in the code editor.

2. Replace the `DeleteButton_Click` event handler with the following code:

     [!code-csharp[VbRaddataSaving#3](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form1.cs#3)]
     [!code-vb[VbRaddataSaving#3](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form1.vb#3)]

## Run the application

#### To run the application

- Select **F5** to run the application.

- Select the **Insert** button, and verify that the new record appears in the grid.

- Select the **Update** button, and verify that the record is updated in the grid.

- Select the **Delete** button, and verify that the record is removed from the grid.

## Next Steps
 Depending on your application requirements, there are several steps you might want to perform after creating a data-bound form. Some enhancements you could make to this walkthrough include:

- Adding search functionality to the form. For more information, see [How to: Add a Parameterized Query to a Windows Forms Application](https://msdn.microsoft.com/library/13db4ad3-56b9-4a0b-b3a5-6a4ff84d4416).

- Adding additional tables to the dataset by selecting **Configure DataSet with Wizard** from within the **Data Sources** window. You can add controls that display related data by dragging the related nodes onto the form.

## See Also
 [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
