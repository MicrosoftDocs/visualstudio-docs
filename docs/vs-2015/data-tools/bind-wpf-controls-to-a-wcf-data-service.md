---
title: "Bind WPF controls to a WCF data service | Microsoft Docs"
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
ms.assetid: 8823537c-82f0-41f7-bf30-705f0e5e59fd
caps.latest.revision: 44
author: jillre
ms.author: jillfra
manager: jillfra
---
# Bind WPF controls to a WCF data service
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In this walkthrough, you will create a WPF application that contains data-bound controls. The controls are bound to customer records that are encapsulated in a [!INCLUDE[ss_data_service](../includes/ss-data-service-md.md)]. You will also add buttons that customers can use to view and update records.

 This walkthrough illustrates the following tasks:

- Creating an Entity Data Model that is generated from data in the AdventureWorksLT sample database.

- Creating a [!INCLUDE[ss_data_service](../includes/ss-data-service-md.md)] that exposes the data in the Entity Data Model to a WPF application.

- Creating a set of data-bound controls by dragging items from the **Data Sources** window to the WPF designer.

- Creating buttons that navigate forward and backward through customer records.

- Creating a button that saves changes to data in the controls to the [!INCLUDE[ss_data_service](../includes/ss-data-service-md.md)] and the underlying data source.

   [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]

- Access to a running instance of SQL Server or SQL Server Express that has the AdventureWorksLT sample database attached to it. You can download the AdventureWorksLT database from the [CodePlex Web site](https://go.microsoft.com/fwlink/?linkid=87843).

  Prior knowledge of the following concepts is also helpful, but not required to complete the walkthrough:

- WCF Data Services. For more information, see [Overview](https://msdn.microsoft.com/library/7924cf94-c9a6-4015-afc9-f5d22b1743bb).

- Data models in [!INCLUDE[ssAstoria](../includes/ssastoria-md.md)].

- Entity Data Models and the ADO.NET Entity Framework. For more information, see [Entity Framework Overview](https://msdn.microsoft.com/library/a2166b3d-d8ba-4a0a-8552-6ba1e3eaaee0).

- Working with the WPF designer. For more information, see [WPF and Silverlight Designer Overview](https://msdn.microsoft.com/570b7a5c-0c86-4326-a371-c9b63378fc62).

- WPF data binding. For more information, see [Data Binding Overview](https://msdn.microsoft.com/library/c707c95f-7811-401d-956e-2fffd019a211).

## Create the service project
 Start this walkthrough by creating a project for a [!INCLUDE[ss_data_service](../includes/ss-data-service-md.md)].

#### To create the service project

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then click **Project**.

3. Expand **Visual C#** or **Visual Basic**, and then select **Web**.

4. Select the **ASP.NET Web Application** project template.

5. In the **Name** box, type `AdventureWorksService` and click **OK**.

     Visual Studio creates the `AdventureWorksService` project.

6. In **Solution Explorer**, right-click **Default.aspx** and select **Delete**. This file is not necessary in this walkthrough.

## Create an Entity Data Model for the service
 To expose data to an application by using a [!INCLUDE[ss_data_service](../includes/ss-data-service-md.md)], you must define a data model for the service. The [!INCLUDE[ss_data_service](../includes/ss-data-service-md.md)] supports two types of data models: Entity Data Models, and custom data models that are defined by using common language runtime (CLR) objects that implement the <xref:System.Linq.IQueryable%601> interface. In this walkthrough, you create an Entity Data Model for the data model.

#### To create an Entity Data Model

1. On the **Project** menu, click **Add New Item**.

2. In the Installed Templates list, click **Data**, and then select the **ADO.NET Entity Data Model** project item.

3. Change the name to `AdventureWorksModel.edmx`, and click **Add**.

     The **Entity Data Model** wizard opens.

4. On the **Choose Model Contents** page, click **Generate from database**, and click **Next**.

5. On the **Choose Your Data Connection** page, select one of the following options:

    - If a data connection to the AdventureWorksLT sample database is available in the drop-down list, select it.

    - Click **New Connection**, and create a connection to the AdventureWorksLT database.

6. On the **Choose Your Data Connection** page, make sure that the **Save entity connection settings in App.Config as** option is selected, and then click **Next**.

7. On the **Choose Your Database Objects** page, expand **Tables**, and then select the **SalesOrderHeader** table.

8. Click **Finish**.

## Create the service
 Create a [!INCLUDE[ss_data_service](../includes/ss-data-service-md.md)] to expose the data in the Entity Data Model to a WPF application.

#### To create the service

1. On the **Project** menu, select **Add New Item**.

2. In the Installed Templates list, click **Web**, and then select the **WCF Data Service** project item.

3. In the **Name** box, type `AdventureWorksService.svc`, and click **Add**.

     Visual Studio adds the `AdventureWorksService.svc` to the project.

## Configure the service
 You must configure the service to operate on the Entity Data Model that you created.

#### To configure the service

1. In the `AdventureWorks.svc` code file, replace the `AdventureWorksService` class declaration with the following code.

     [!code-csharp[Data_WPFWCF#1](../snippets/csharp/VS_Snippets_ProTools/data_wpfwcf/cs/adventureworksservice.svc.cs#1)]
     [!code-vb[Data_WPFWCF#1](../snippets/visualbasic/VS_Snippets_ProTools/data_wpfwcf/vb/adventureworksservice.svc.vb#1)]

     This code updates the `AdventureWorksService` class, so that it derives from a <xref:System.Data.Services.DataService%601> that operates on the `AdventureWorksLTEntities` object context class in your Entity Data Model. It also updates the `InitializeService` method to allow clients of the service full read/write access to the `SalesOrderHeader` entity.

2. Build the project, and verify that it builds without errors.

## Create the WPF client application
 To display the data from the [!INCLUDE[ss_data_service](../includes/ss-data-service-md.md)], create a new WPF application with a data source that is based on the service. Later in this walkthrough, you will add data-bound controls to the application.

#### To create the WPF client application

1. In **Solution Explorer**, right-click the solution node, click **Add**, and select **New Project**.

2. In the **New Project** dialog, expand **Visual C#** or **Visual Basic**, and then select **Windows**.

3. Select the **WPF Application** project template.

4. In the **Name** box, type `AdventureWorksSalesEditor`, and click **OK**.

     Visual Studio adds the `AdventureWorksSalesEditor` project to the solution.

5. On the **Data** menu, click **Show Data Sources**.

     The **Data Sources** window opens.

6. In the **Data Sources** window, click **Add New Data Source**.

     The **Data Source Configuration** wizard opens.

7. In the **Choose a Data Source Type** page of the wizard, select **Service**, and then click **Next**.

8. In the **Add Service Reference** dialog box, click **Discover**.

     Visual Studio searches the current solution for available services, and adds `AdventureWorksService.svc` to the list of available services in the **Services** box.

9. In the **Namespace** box, type `AdventureWorksService`.

10. In the **Services** box, click **AdventureWorksService.svc**, and then click **OK**.

     Visual Studio downloads the service information, and then returns to the **Data Source Configuration** wizard.

11. In the **Add Service Reference** page, click **Finish**.

     Visual Studio adds nodes that represent the data returned by the service to the **Data Sources** window.

## Define the user interface of the window
 Add several buttons to the window by modifying the XAML in the WPF designer. Later in this walkthrough, you will add code that enables users to view and update sales records by using these buttons.

#### To create the window layout

1. In **Solution Explorer**, double-click MainWindow.xaml.

     The window opens in the WPF designer.

2. In the [!INCLUDE[TLA#tla_titlexaml](../includes/tlasharptla-titlexaml-md.md)] view of the designer, add the following code between the `<Grid>` tags:

    ```
    <Grid.RowDefinitions>
        <RowDefinition Height="75" />
        <RowDefinition Height="525" />
    </Grid.RowDefinitions>
    <Button HorizontalAlignment="Left" Margin="22,20,0,24" Name="backButton" Width="75"><</Button>
    <Button HorizontalAlignment="Left" Margin="116,20,0,24" Name="nextButton" Width="75">></Button>
    <Button HorizontalAlignment="Right" Margin="0,21,46,24" Name="saveButton" Width="110">Save changes</Button>
    ```

3. Build the project.

## Create the data-bound controls
 Create controls that display customer records by dragging the `SalesOrderHeaders` node from the **Data Sources** window to the designer.

#### To create the data-bound controls

1. In the **Data Sources** window, click the drop-down menu for the **SalesOrderHeaders** node, and select **Details**.

2. Expand the **SalesOrderHeaders** node.

3. For this example, some fields will not be displayed, so click the drop-down menu next to the following nodes and select **None**:

   - **CreditCardApprovalCode**

   - **ModifiedDate**

   - **OnlineOrderFlag**

   - **RevisionNumber**

   - **rowguid**

     This action prevents Visual Studio from creating data-bound controls for these nodes in the next step. For this walkthrough, assume that the end user does not need to see this data.

4. From the **Data Sources** window, drag the **SalesOrderHeaders** node to the grid row under the row that contains the buttons.

    Visual Studio generates XAML and code that creates a set of controls that are bound to data in the **Product** table. For more information about the generated XAML and code, see [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio1.md).

5. In the designer, click the text box next to the **Customer ID** label.

6. In the **Properties** window, select the check box next to the **IsReadOnly** property.

7. Set the **IsReadOnly** property for each of the following text boxes:

   - **Purchase Order Number**

   - **Sales Order ID**

   - **Sales Order Number**

## Load the data from the service
 Use the service proxy object to load sales data from the service. Then assign the returned data to the data source for the <xref:System.Windows.Data.CollectionViewSource> in the WPF window.

#### To load the data from the service

1. In the designer, to create the `Window_Loaded` event handler, double-click the text that reads: **MainWindow**.

2. Replace the event handler with the following code. Make sure that you replace the *localhost* address in this code with the local host address on your development computer.

     [!code-csharp[Data_WPFWCF#2](../snippets/csharp/VS_Snippets_ProTools/data_wpfwcf/cs/adventureworkssaleseditor/mainwindow.xaml.cs#2)]
     [!code-vb[Data_WPFWCF#2](../snippets/visualbasic/VS_Snippets_ProTools/data_wpfwcf/vb/adventureworkssaleseditor/mainwindow.xaml.vb#2)]

## Navigatesales records
 Add code that enables users to scroll through sales records by using the **\<** and **>** buttons.

#### To enable users to navigate sales records

1. In the designer, double-click the **<** button on the window surface.

     Visual Studio opens the code-behind file, and creates a new `backButton_Click` event handler for the <xref:System.Windows.Controls.Primitives.ButtonBase.Click> event.

2. Add the following code to the generated `backButton_Click` event handler:

     [!code-csharp[Data_WPFWCF#3](../snippets/csharp/VS_Snippets_ProTools/data_wpfwcf/cs/adventureworkssaleseditor/mainwindow.xaml.cs#3)]
     [!code-vb[Data_WPFWCF#3](../snippets/visualbasic/VS_Snippets_ProTools/data_wpfwcf/vb/adventureworkssaleseditor/mainwindow.xaml.vb#3)]

3. Return to the designer, and double-click the **>** button.

     Visual Studio opens the code-behind file, and creates a new `nextButton_Click` event handler for the <xref:System.Windows.Controls.Primitives.ButtonBase.Click> event.

4. Add the following code to the generated `nextButton_Click` event handler:

     [!code-csharp[Data_WPFWCF#4](../snippets/csharp/VS_Snippets_ProTools/data_wpfwcf/cs/adventureworkssaleseditor/mainwindow.xaml.cs#4)]
     [!code-vb[Data_WPFWCF#4](../snippets/visualbasic/VS_Snippets_ProTools/data_wpfwcf/vb/adventureworkssaleseditor/mainwindow.xaml.vb#4)]

## Saving changes to sales records
 Add code that enables users to both view and save changes to sales records by using the **Save changes** button.

#### To add the ability to save changes to sales records

1. In the designer, double-click the **Save Changes** button.

     Visual Studio opens the code-behind file, and creates a new `saveButton_Click` event handler for the <xref:System.Windows.Controls.Primitives.ButtonBase.Click> event.

2. Add the following code to the `saveButton_Click` event handler.

     [!code-csharp[Data_WPFWCF#5](../snippets/csharp/VS_Snippets_ProTools/data_wpfwcf/cs/adventureworkssaleseditor/mainwindow.xaml.cs#5)]
     [!code-vb[Data_WPFWCF#5](../snippets/visualbasic/VS_Snippets_ProTools/data_wpfwcf/vb/adventureworkssaleseditor/mainwindow.xaml.vb#5)]

## Testing the application
 Build and run the application to verify that you can view and update customer records.

#### To test the application

1. On **Build** menu, click **Build Solution**. Verify that the solution builds without errors.

2. Press **Ctrl+F5**.

     Visual Studio starts the **AdventureWorksService** project, without debugging it.

3. In **Solution Explorer**, right-click the **AdventureWorksSalesEditor** project.

4. On the context menu, under **Debug**, click **Start new instance**.

     The application runs. Verify the following:

    - The text boxes display different fields of data from the first sales record, which has the sales order ID **71774**.

    - You can click the **>** or **<** buttons to navigate through other sales records.

5. In one of the sales records, type some text in the **Comment** box, and then click **Save changes**.

6. Close the application, and then start the application again from Visual Studio.

7. Navigate to the sales record that you changed, and verify that the change persists after you close and reopen the application.

8. Close the application.

## Next Steps
 After completing this walkthrough, you can perform the following related tasks:

- Learn how to use the **Data Sources** window in Visual Studio to bind WPF controls to other types of data sources. For more information, see [Bind WPF controls to a dataset](../data-tools/bind-wpf-controls-to-a-dataset.md).

- Learn how to use the **Data Sources** window in Visual Studio to display related data (that is, data in a parent-child relationship) in WPF controls. For more information, see [Walkthrough: Displaying Related Data in a WPF Application](../data-tools/walkthrough-displaying-related-data-in-a-wpf-application.md).

## See Also
 [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio1.md)
 [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio2.md)
 [Bind WPF controls to a dataset](../data-tools/bind-wpf-controls-to-a-dataset.md)
 [Overview](https://msdn.microsoft.com/library/7924cf94-c9a6-4015-afc9-f5d22b1743bb)
 [Entity Framework Overview](https://msdn.microsoft.com/library/a2166b3d-d8ba-4a0a-8552-6ba1e3eaaee0)
 [WPF and Silverlight Designer Overview](https://msdn.microsoft.com/570b7a5c-0c86-4326-a371-c9b63378fc62)
 [Data Binding Overview](https://msdn.microsoft.com/library/c707c95f-7811-401d-956e-2fffd019a211)
