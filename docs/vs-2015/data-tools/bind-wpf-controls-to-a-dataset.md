---
title: "Bind WPF controls to a dataset | Microsoft Docs"
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
  - "WPF, data binding in Visual Studio"
  - "WPF data binding [Visual Studio], walkthroughs"
  - "WPF Designer, data binding"
ms.assetid: 177420b9-568b-4dad-9d16-1b0e98a24d71
caps.latest.revision: 35
author: jillre
ms.author: jillfra
manager: jillfra
---
# Bind WPF controls to a dataset
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In this walkthrough, you will create a WPF application that contains data-bound controls. The controls are bound to product records that are encapsulated in a dataset. You will also add buttons to browse through products and save changes to product records.

 This walkthrough illustrates the following tasks:

- Creating a WPF application and a dataset that is generated from data in the AdventureWorksLT sample database.

- Creating a set of data-bound controls by dragging a data table from the **Data Sources** window to a window in the WPF Designer.

- Creating buttons that navigate forward and backward through product records.

- Creating a button that saves changes that users make to the product records to the data table and the underlying data source.

   [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]

- Access to a running instance of SQL Server or SQL Server Express that has the AdventureWorksLT sample database attached to it. You can download the AdventureWorksLT database from the [CodePlex Web site](https://go.microsoft.com/fwlink/?linkid=87843).

  Prior knowledge of the following concepts is also helpful, but not required to complete the walkthrough:

- Datasets and TableAdapters. For more information, see [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md).

- Working with the WPF Designer. For more information, see [WPF and Silverlight Designer Overview](https://msdn.microsoft.com/570b7a5c-0c86-4326-a371-c9b63378fc62).

- WPF data binding. For more information, see [Data Binding Overview](https://msdn.microsoft.com/library/c707c95f-7811-401d-956e-2fffd019a211).

## Create the project
 Create a new WPF project. The project will display product records.

#### To create the project

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then click **Project**.

3. Expand **Visual Basic** or **Visual C#**, and then select **Windows**.

4. Select the **WPF Application** project template.

5. In the **Name** box, type `AdventureWorksProductsEditor` and click **OK**.

     Visual Studio creates the `AdventureWorksProductsEditor` project.

## Create a dataset for the application
 Before you can create data-bound controls, you must define a data model for your application and add it to the **Data Sources** window. In this walkthrough, you create a dataset to use as the data model.

#### To create a dataset

1. On the **Data** menu, click **Show Data Sources**.

     The **Data Sources** window opens.

2. In the **Data Sources** window, click **Add New Data Source**.

     The **Data Source Configuration** wizard opens.

3. On the **Choose a Data Source Type** page, select **Database**, and then click **Next**.

4. On the **Choose a Database Model** page, select **Dataset**, and then click **Next**.

5. On the **Choose Your Data Connection** page, select one of the following options:

    - If a data connection to the AdventureWorksLT sample database is available in the drop-down list, select it and then click **Next**.

    - Click **New Connection**, and create a connection to the AdventureWorksLT database.

6. On the **Save the Connection String to the Application Configure File** page, select the **Yes, save the connection as** check box, and then click **Next**.

7. On the **Choose Your Database Objects** page, expand **Tables**, and then select the **Product (SalesLT)** table.

8. Click **Finish**.

     Visual Studio adds a new AdventureWorksLTDataSet.xsd file to the project, and it adds a corresponding **AdventureWorksLTDataSet** item to the **Data Sources** window. The AdventureWorksLTDataSet.xsd file defines a typed dataset named `AdventureWorksLTDataSet` and a TableAdapter named `ProductTableAdapter`. Later in this walkthrough, you will use the `ProductTableAdapter` to fill the dataset with data and save changes back to the database.

9. Build the project.

## Edit the default fill method of the TableAdapter
 To fill the dataset with data, use the `Fill` method of the `ProductTableAdapter`. By default, the `Fill` method fills the `ProductDataTable` in the `AdventureWorksLTDataSet` with all rows of data from the Product table. You can modify this method to return only a subset of the rows. For this walkthrough, modify the `Fill` method to return only rows for products that have photos.

#### To load product rows that have photos

1. In **Solution Explorer**, double-click the AdventureWorksLTDataSet.xsd file.

     The Dataset designer opens.

2. In the designer, right-click the **Fill,GetData()** query and select **Configure**.

     The **TableAdapter Configuration** wizard opens.

3. In the **Enter a SQL Statement** page, add the following WHERE clause after the `SELECT` statement in the text box.

    ```
    WHERE ThumbnailPhotoFileName <> 'no_image_available_small.gif'
    ```

4. Click **Finish**.

## Define the user interface
 Add several buttons to the window by modifying the XAML in the WPF Designer. Later in this walkthrough, you will add code that enables users to scroll through and save changes to products records by using these buttons.

#### To define the user interface of the window

1. In **Solution Explorer**, double-click MainWindow.xaml.

     The window opens in the WPF Designer.

2. In the [!INCLUDE[TLA#tla_titlexaml](../includes/tlasharptla-titlexaml-md.md)] view of the designer, add the following code between the `<Grid>` tags:

    ```
    <Grid.RowDefinitions>
        <RowDefinition Height="75" />
        <RowDefinition Height="625" />
    </Grid.RowDefinitions>
    <Button HorizontalAlignment="Left" Margin="22,20,0,24" Name="backButton" Width="75"><</Button>
    <Button HorizontalAlignment="Left" Margin="116,20,0,24" Name="nextButton" Width="75">></Button>
    <Button HorizontalAlignment="Right" Margin="0,21,46,24" Name="saveButton" Width="110">Save changes</Button>
    ```

3. Build the project.

## Createdata-bound controls
 Create controls that display customer records by dragging the `Product` table from the **Data Sources** window to the WPF Designer.

#### To create data-bound controls

1. In the **Data Sources** window, click the drop-down menu for the **Product** node and select **Details**.

2. Expand the **Product** node.

3. For this example, some fields will not be displayed, so click the drop-down menu next to the following nodes and select **None**:

    - ProductCategoryID

    - ProductModelID

    - ThumbnailPhotoFileName

    - rowguid

    - ModifiedDate

4. Click the drop-down menu next to the **ThumbNailPhoto** node and select **Image**.

    > [!NOTE]
    > By default, items in the **Data Sources** window that represent pictures have their default control set to **None**. This is because pictures are stored as byte arrays in databases, and byte arrays can contain anything from a simple array of bytes to the executable file of a large application.

5. From the **Data Sources** window, drag the **Product** node to the grid row under the row that contains the buttons.

     Visual Studio generates XAML that defines a set of controls that are bound to data in the **Products** table. It also generates code that loads the data. For more information about the generated XAML and code, see [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio1.md).

6. In the designer, click the text box next to the **Product ID** label.

7. In the **Properties** window, select the check box next to the **IsReadOnly** property.

## Navigating product records
 Add code that enables users to scroll through product records by using the **\<** and **>** buttons.

#### To enable users to navigate product records

1. In the designer, double-click the **<** button on the window surface.

     Visual Studio opens the code-behind file, and creates a new `backButton_Click` event handler for the <xref:System.Windows.Controls.Primitives.ButtonBase.Click> event.

2. Modify the `Window_Loaded` event handler, so the `ProductViewSource`, `AdventureWorksLTDataSet`, and `AdventureWorksLTDataSetProductTableAdapter` are outside of the method and accessible to the entire form. Declare only these to be global to the form, and assign them within the `Window_Loaded` event handler similar to the following:

     [!code-csharp[Data_WPFDATASET#1](../snippets/csharp/VS_Snippets_ProTools/data_wpfdataset/cs/mainwindow.xaml.cs#1)]
     [!code-vb[Data_WPFDATASET#1](../snippets/visualbasic/VS_Snippets_ProTools/data_wpfdataset/vb/mainwindow.xaml.vb#1)]

3. Add the following code to the `backButton_Click` event handler:

     [!code-csharp[Data_WPFDATASET#2](../snippets/csharp/VS_Snippets_ProTools/data_wpfdataset/cs/mainwindow.xaml.cs#2)]
     [!code-vb[Data_WPFDATASET#2](../snippets/visualbasic/VS_Snippets_ProTools/data_wpfdataset/vb/mainwindow.xaml.vb#2)]

4. Return to the designer and double-click the **>** button.

5. Add the following code to the `nextButton_Click` event handler:

     [!code-csharp[Data_WPFDATASET#3](../snippets/csharp/VS_Snippets_ProTools/data_wpfdataset/cs/mainwindow.xaml.cs#3)]
     [!code-vb[Data_WPFDATASET#3](../snippets/visualbasic/VS_Snippets_ProTools/data_wpfdataset/vb/mainwindow.xaml.vb#3)]

## Savechanges to product records
 Add code that enables users to save changes to product records by using the **Save changes** button.

#### To add the ability to save changes to product records

1. In the designer, double-click the **Save changes** button.

     Visual Studio opens the code-behind file, and creates a new `saveButton_Click` event handler for the <xref:System.Windows.Controls.Primitives.ButtonBase.Click> event.

2. Add the following code to the `saveButton_Click` event handler:

     [!code-csharp[Data_WPFDATASET#4](../snippets/csharp/VS_Snippets_ProTools/data_wpfdataset/cs/mainwindow.xaml.cs#4)]
     [!code-vb[Data_WPFDATASET#4](../snippets/visualbasic/VS_Snippets_ProTools/data_wpfdataset/vb/mainwindow.xaml.vb#4)]

    > [!NOTE]
    > This example uses the `Save` method of the `TableAdapter` to save the changes. This is appropriate in this walkthrough, because only one data table is being changed. If you need to save changes to multiple data tables, you can alternatively use the `UpdateAll` method of the `TableAdapterManager` that Visual Studio generates with your dataset. For more information, see [TableAdapterManager Overview](https://msdn.microsoft.com/library/33076d42-6b41-491a-ac11-6c6339aea650).

## Test the application
 Build and run the application. Verify that you can view and update product records.

#### To test the application

1. Press **F5**.

     The application builds and runs. Verify the following:

    - The text boxes display data from the first product record that has a photo. This product has the product ID 713, and the name **Long-Sleeve Logo Jersey, S**.

    - You can click the **>** or **<** buttons to navigate through other product records.

2. In one of the product records, change the **Size** value, and then click **Save changes**.

3. Close the application, and then restart the application by pressing **F5** in Visual Studio.

4. Navigate to the product record you changed, and verify that the change persisted.

5. Close the application.

## Next Steps
 After completing this walkthrough, you can perform the following related tasks:

- Learn how to use the **Data Sources** window in Visual Studio to bind WPF controls to other types of data sources. For more information, see [Bind WPF controls to a WCF data service](../data-tools/bind-wpf-controls-to-a-wcf-data-service.md).

- Learn how to use the **Data Sources** window in Visual Studio to display related data (that is, data in a parent-child relationship) in WPF controls. For more information, see [Walkthrough: Displaying Related Data in a WPF Application](../data-tools/walkthrough-displaying-related-data-in-a-wpf-application.md).

## See Also
 [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio1.md)
 [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio2.md)
 [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md)
 [WPF and Silverlight Designer Overview](https://msdn.microsoft.com/570b7a5c-0c86-4326-a371-c9b63378fc62)
 [Data Binding Overview](https://msdn.microsoft.com/library/c707c95f-7811-401d-956e-2fffd019a211)
