---
title: Bind WPF controls to an ADO.NET dataset (.NET Framework)
description: Create a WPF .NET Framework application in Visual Studio that contains data-bound controls, which are bound to product records that are encapsulated in an ADO.NET dataset.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- WPF, data binding in Visual Studio
- WPF data binding [Visual Studio], walkthroughs
- WPF Designer, data binding
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Bind WPF controls to a dataset in .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

In this walkthrough, you create a WPF application that contains data-bound controls. The controls are bound to product records that are encapsulated in a dataset. You also add buttons to browse through products and save changes to product records.

This walkthrough illustrates the following tasks:

- Creating a WPF application and a dataset that is generated from data in the AdventureWorksLT sample database.

- Creating a set of data-bound controls by dragging a data table from the **Data Sources** window to a window in the WPF Designer.

- Creating buttons that navigate forward and backward through product records.

- Creating a button that saves changes that users make to the product records to the data table and the underlying data source.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

## Prerequisites

You need the following components to complete this walkthrough:

- To complete this tutorial, you need the **.NET desktop development** and **Data storage and processing** workloads installed in Visual Studio. To install them, open **Visual Studio Installer** and choose **Modify** (or **More** > **Modify**) next to the version of Visual Studio you want to modify. See [Modify Visual Studio](../install/modify-visual-studio.md).

- Access to a running instance of SQL Server or SQL Server Express that has the AdventureWorks Light (AdventureWorksLT) sample database attached to it. To download the database, see [AdventureWorks sample databases](/sql/samples/adventureworks-install-configure?tabs=ssms).

Prior knowledge of the following concepts is also helpful, but not required to complete the walkthrough:

- Datasets and TableAdapters. For more information, see [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md) and [TableAdapters](../data-tools/create-and-configure-tableadapters.md).

- WPF data binding. For more information, see [Data Binding Overview](/dotnet/desktop-wpf/data/data-binding-overview).

## Create the project

Create a new WPF project to display product records.

1. Open Visual Studio.

2. On the start window, choose **Create a new project**.

3. Search for the C# **WPF App** project template and follow the steps to create the project, naming the project **AdventureWorksProductsEditor**.

   Visual Studio creates the AdventureWorksProductsEditor project.

## Create a dataset for the application

Before you can create data-bound controls, you must define a data model for your application and add it to the **Data Sources** window. In this walkthrough, you create a dataset to use as the data model.

1. On the **Data** menu, click **Show Data Sources**.

   The **Data Sources** window opens.

2. In the **Data Sources** window, click **Add New Data Source**.

   The **Data Source Configuration** wizard opens.

3. On the **Choose a Data Source Type** page, select **Database**, and then select **Next**.

4. On the **Choose a Database Model** page, select **Dataset**, and then select **Next**.

5. On the **Choose Your Data Connection** page, select one of the following options:

   - If a data connection to the AdventureWorksLT sample database is available in the dropdown list, select it, and then select **Next**.

   - Click **New Connection**, and create a connection to the AdventureWorksLT database.

6. On the **Save the Connection String to the Application Configure File** page, select the **Yes, save the connection as** checkbox, and then select **Next**.

7. On the **Choose Your Database Objects** page, expand **Tables**, and then select the **Product (SalesLT)** table.

8. Click **Finish**.

   Visual Studio adds a new `AdventureWorksLTDataSet.xsd` file to the project, and it adds a corresponding **AdventureWorksLTDataSet** item to the **Data Sources** window. The `AdventureWorksLTDataSet.xsd` file defines a typed dataset named `AdventureWorksLTDataSet` and a TableAdapter named `ProductTableAdapter`. Later in this walkthrough, you will use the `ProductTableAdapter` to fill the dataset with data and save changes back to the database.

9. Build the project.

## Edit the default fill method of the TableAdapter

To fill the dataset with data, use the `Fill` method of the `ProductTableAdapter`. By default, the `Fill` method fills the `ProductDataTable` in the `AdventureWorksLTDataSet` with all rows of data from the Product table. You can modify this method to return only a subset of the rows. For this walkthrough, modify the `Fill` method to return only rows for products that have photos.

1. In **Solution Explorer**, double-click the *AdventureWorksLTDataSet.xsd* file.

     The Dataset designer opens.

2. In the designer, right-click the **Fill**, **GetData()** query and select **Configure**.

     The **TableAdapter Configuration** wizard opens.

3. In the **Enter a SQL Statement** page, add the following `WHERE` clause after the `SELECT` statement in the text box.

    ```sql
    WHERE ThumbnailPhotoFileName <> 'no_image_available_small.gif'
    ```

4. Click **Finish**.

## Define the user interface

Add several buttons to the window by modifying the XAML in the WPF Designer. Later in this walkthrough, you will add code that enables users to scroll through and save changes to products records by using these buttons.

1. In **Solution Explorer**, double-click *MainWindow.xaml*.

    The window opens in the **WPF Designer**.

2. In the XAML view of the designer, add the following code between the `<Grid>` tags:

   ```xaml
   <Grid.RowDefinitions>
       <RowDefinition Height="75" />
       <RowDefinition Height="625" />
   </Grid.RowDefinitions>
   <Button HorizontalAlignment="Left" Margin="22,20,0,24" Name="backButton" Width="75">&lt;</Button>
   <Button HorizontalAlignment="Left" Margin="116,20,0,24" Name="nextButton" Width="75">&gt;</Button>
   <Button HorizontalAlignment="Right" Margin="0,21,46,24" Name="saveButton" Width="110">Save changes</Button>
   ```

3. Build the project.

## Create data-bound controls

Create controls that display customer records by dragging the `Product` table from the **Data Sources** window to the WPF Designer.

1. In the **Data Sources** window, click the dropdown list menu for the **Product** node and select **Details**.

2. Expand the **Product** node.

3. For this example, some fields will not be displayed, so click the dropdown list menu next to the following nodes and select **None**:

    - ProductCategoryID

    - ProductModelID

    - ThumbnailPhotoFileName

    - rowguid

    - ModifiedDate

4. Click the dropdown list menu next to the **ThumbNailPhoto** node and select **Image**.

    > [!NOTE]
    > By default, items in the **Data Sources** window that represent pictures have their default control set to **None**. This is because pictures are stored as byte arrays in databases, and byte arrays can contain anything from a simple array of bytes to the executable file of a large application.

5. From the **Data Sources** window, drag the **Product** node to the grid row under the row that contains the buttons.

     Visual Studio generates XAML that defines a set of controls that are bound to data in the **Products** table. It also generates code that loads the data. For more information about the generated XAML and code, see [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio.md).

6. In the designer, click the text box next to the **Product ID** label.

7. In the **Properties** window, select the checkbox next to the **IsReadOnly** property.

## Navigate product records

Add code that enables users to scroll through product records by using the **\<** and **>** buttons.

1. In the designer, double-click the **<** button on the window surface.

     Visual Studio opens the code-behind file, and creates a new `backButton_Click` event handler for the <xref:System.Windows.Controls.Primitives.ButtonBase.Click> event.

2. Modify the `Window_Loaded` event handler, so the `ProductViewSource`, `AdventureWorksLTDataSet`, and `AdventureWorksLTDataSetProductTableAdapter` are outside of the method and accessible to the entire form. Declare only these to be global to the form, and assign them within the `Window_Loaded` event handler similar to the following:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_ProTools/data_wpfdataset/cs/mainwindow.xaml.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_ProTools/data_wpfdataset/vb/mainwindow.xaml.vb" id="Snippet1":::
     ---

3. Add the following code to the `backButton_Click` event handler:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_ProTools/data_wpfdataset/cs/mainwindow.xaml.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_ProTools/data_wpfdataset/vb/mainwindow.xaml.vb" id="Snippet2":::
     ---

4. Return to the designer and double-click the **>** button.

5. Add the following code to the `nextButton_Click` event handler:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_ProTools/data_wpfdataset/cs/mainwindow.xaml.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_ProTools/data_wpfdataset/vb/mainwindow.xaml.vb" id="Snippet3":::
     ---

## Save changes to product records

Add code that enables users to save changes to product records by using the **Save changes** button.

1. In the designer, double-click the **Save changes** button.

     Visual Studio opens the code-behind file, and creates a new `saveButton_Click` event handler for the <xref:System.Windows.Controls.Primitives.ButtonBase.Click> event.

2. Add the following code to the `saveButton_Click` event handler:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_ProTools/data_wpfdataset/cs/mainwindow.xaml.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_ProTools/data_wpfdataset/vb/mainwindow.xaml.vb" id="Snippet4":::
     ---

    > [!NOTE]
    > This example uses the `Save` method of the `TableAdapter` to save the changes. This is appropriate in this walkthrough, because only one data table is being changed. If you need to save changes to multiple data tables, you can alternatively use the `UpdateAll` method of the `TableAdapterManager` that Visual Studio generates with your dataset. For more information, see [TableAdapters](../data-tools/create-and-configure-tableadapters.md).

## Test the application

Build and run the application. Verify that you can view and update product records.

1. Press **F5**.

     The application builds and runs. Verify the following:

    - The text boxes display data from the first product record that has a photo. This product has the product ID 713, and the name **Long-Sleeve Logo Jersey, S**.

    - You can click the **>** or **<** buttons to navigate through other product records.

2. In one of the product records, change the **Size** value, and then select **Save changes**.

3. Close the application, and then restart the application by pressing **F5** in Visual Studio.

4. Navigate to the product record you changed, and verify that the change persisted.

5. Close the application.

## Next steps

After completing this walkthrough, you might try the following related tasks:

- Learn how to use the **Data Sources** window in Visual Studio to bind WPF controls to other types of data sources. For more information, see [Bind WPF controls to a WCF data service](../data-tools/bind-wpf-controls-to-a-wcf-data-service.md).

- Learn how to use the **Data Sources** window in Visual Studio to display related data (that is, data in a parent-child relationship) in WPF controls. For more information, see [Walkthrough: Display related data in a WPF app](../data-tools/display-related-data-in-wpf-applications.md).

## Related content

- [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio.md)
- [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md)
- [Data Binding Overview](/dotnet/desktop-wpf/data/data-binding-overview)
