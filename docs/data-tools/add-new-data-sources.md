---
title: Add data sources in ADO.NET apps (.NET Framework)
description: Explore how to add .NET Framework data sources by using ADO.NET in Visual Studio and connect your application to information in a data store.
ms.date: 08/29/2024
ms.topic: how-to
f1_keywords:
- vs.datasource.datasourcefieldspicker
helpviewer_keywords:
- data [Visual Studio], data sources
- data sources
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools

#customer intent: As a developer, I want to add .NET Framework data sources with ADO.NET in Visual Studio, so I can connect data stores to my application.
---

# Add data sources in ADO.NET applications (.NET Framework)

When you work with .NET data tools in Visual Studio, you can add *data sources* (.NET objects) to connect your .NET application to information in data stores. The Visual Studio designers can consume the data source output to generate boilerplate code that binds the data to forms when you drag and drop database objects from the **Data Sources** window.

Examples of data sources include:

- A class in an Entity Framework model associated with some kind of database

- A dataset associated with some kind of database

- A class that represents a network service, such as a Windows Communication Foundation (WCF) data service or a REST service

- A class that represents a SharePoint service

- A class or collection in your solution

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

## Prerequisites

- An application that implements Windows Forms or Windows Presentation Format (WPF) objects that target .NET Framework. You can create this type of application by using a template in Visual Studio when your installation includes the **.NET Desktop development** workload. For more information, see [Modify Visual Studio workloads, components, and language packs](../install/modify-visual-studio.md).

   > [!IMPORTANT]
   > The features described in this article aren't supported for **.NET Core** development for WPF or Windows Forms.

- The application must use data-binding features: datasets, the Entity Framework, the Language Integrated Query (LINQ) to SQL, a WCF data service, or SharePoint.

   > [!TIP]
   > When the application doesn't use one or more of these components, the concept of a "data source" doesn't apply. In these scenarios, you can connect directly to the database by using [SqlCommand class](/dotnet/api/system.data.sqlclient.sqlcommand?view=netframework-4.8.1&preserve-view=true) objects.

## Work with data sources and Windows forms

You create and edit data sources for .NET Framework by using the **Data Source Configuration Wizard** in a Windows Forms or WPF application. You can create a data source from a database, a service, an object, or from a SharePoint list:

:::image type="content" source="./media/data-source-configuration-wizard.png" border="false" alt-text="Screenshot that shows the Data Source Configuration Wizard in Visual Studio.":::

After you create data sources, they're visible in the **Data Sources** window. When your project is open in Visual Studio, you can access this window by selecting **View** > **Other Windows** > **Data Sources**. You can also use the **Shift**+**Alt**+**D** keyboard shortcut.

In a Windows Forms project that targets **.NET Framework** (not .NET Core or .NET 5 or later), you can drag a data source from the **Data Sources** window onto a Windows form design surface or control. Some examples of how you can connect a data source with a form include:

- Drag a table to get a [BindingNavigator](/dotnet/desktop/winforms/controls/bindingnavigator-control-overview-windows-forms) and a [DataGridView](/dotnet/desktop/winforms/controls/datagridview-control-windows-forms) for the table.

- Drag a specific column to get a BindingNavigator with a [Label](/dotnet/desktop/winforms/controls/label-control-windows-forms) and [TextBox](/dotnet/desktop/winforms/controls/textbox-control-windows-forms) for the column.

- Drag all the table columns to get a complete data viewing form for the table.

These actions trigger Visual Studio to generate boilerplate code that displays the data from the data store. The following example shows a dataset dropped onto a Windows form. If you select **F5** on the application, the data from the underlying database appears in the form's controls.

:::moniker range=">=vs-2022"

:::image type="content" source="./media/vs-2022/data-sources-drag-operation.png" border="false" alt-text="Screenshot that shows how to drag a dataset onto a Windows form in Visual Studio 2022.":::

:::moniker-end
:::moniker range="<=vs-2019"

:::image type="content" source="./media/raddata-data-source-drag-operation.png" alt-text="Screenshot that shows how to drag a dataset onto a Windows form in Visual Studio 2019 and earlier.":::

:::moniker-end

## Create data source from database or database file

You can create a dataset or an Entity Framework model to use as a data source for a database or database file with the **Data Source Configuration Wizard**. If your configuration uses Entity Framework, first create your [Entity classes](#create-entity-framework-model-as-data-source), and then use the wizard to create data sources.

### Create dataset as data source

The **Data Source Configuration Wizard** provides the option to create a data source by connecting to a database. You can choose the database objects to use as the dataset for your application.

Follow these steps to create a dataset as a data source:

1. In Visual Studio, select **Project** > **Add New Data Source** to open the **Data Source Configuration Wizard**.

1. For the type of data source, select **Database**.

1. For the database model, select **Dataset**.

1. Follow the prompts to specify a new or existing database connection, or a database file.

1. Select the database objects to include in the dataset, and complete the wizard.

For detailed instructions to complete the wizard, see [Create and configure datasets in .NET Framework with Visual Studio](create-and-configure-datasets-in-visual-studio.md).

### Create Entity Framework model as data source

When your configuration uses Entity Framework, you first create your Entity classes and then use the **Data Source Configuration Wizard** to create the data source.

Follow these steps to create an Entity Framework model as a data source with the **Entity Data Model Wizard**:

1. Select **Project** > **Add New Item**. The **Add New Item** dialog opens.

1. In the dialog, select the **ADO.NET Entity Data Model** template, enter a name for the model instance, and select **Add**:

   :::image type="content" source="./media/raddata-new-entity-framework-model-project-item.png" border="false" alt-text="Screenshot that shows how to create a new ADO.NET Entity Data Model by using the Add New Item dialog.":::

   The **Entity Data Model Wizard** opens.

1. In the wizard, choose the method to generate the Entity Framework model:

   - **EF Designer from database**: Creates a model in the Entity Framework Designer based on an existing database. You can choose the database connection, settings for the model, and database objects to include in the model. The classes your application interacts with are generated from the model.

   - **Empty EF Designer model**: Creates an empty model in the Entity Framework Designer as a starting point for visually designing your model. Later, you can generate a database from your model. The classes your application interacts with are generated from the model.

   - **Empty Code First model**: Creates an empty [Code First](https://entityframeworkcore.com/approach-code-first) model as a starting point for designing your model by using code. Later, you can generate a database from your model.

   - **Code First from database**: Creates a Code First model based on an existing database. You can choose the database connection, settings for the model, and database objects to include in the model.

   :::image type="content" source="./media/raddata-entity-data-model-wizard.png" border="false" alt-text="Screenshot that shows the options for generating the new model in the Entity Data Model wizard.":::

   After you make your choice, select **Next** to continue in the wizard.

1. Add the model as the data source for your application, and complete the wizard.

   For detailed instructions to complete the wizard, see [Create Model Classes with the Entity Framework (C#)](/aspnet/mvc/overview/older-versions-1/models-data/creating-model-classes-with-the-entity-framework-cs).

1. After you generate classes for the model, you can create a data source from an object with the **Data Source Configuration Wizard**.

   - Select the tables (or individual columns), stored procedures, functions, and views from the model for use in the dataset.

      :::image type="content" source="./media/raddata-data-source-configuration-wizard-with-entity-classes.png" alt-text="Screenshot that shows the generated Entity classes for the model in the Data Source Configuration Wizard.":::

   For detailed instructions, see [Create data source from object](#create-data-source-from-object).

## Create data source from service

The **Data Source Configuration Wizard** supports creating a data source from a service. In this approach, Visual Studio adds a service reference to your project and creates proxy objects that correspond to objects returned by the service. When a service returns a dataset, the service is represented in your project as a dataset. If the service returns a specific type, the service is represented in your project as the returned type.

You can create a data source from the following types of services:

- [WCF Data Services](/dotnet/framework/data/wcf/wcf-data-services-overview)

- [WCF services](windows-communication-foundation-services-and-wcf-data-services-in-visual-studio.md)

- Web services

> [!NOTE]
> Items in the **Data Sources** window are dependent on the data returned by the service. Some services might not provide enough information for the **Data Source Configuration Wizard** to create bindable objects. After you complete the wizard, if the service returns an untyped dataset, no items appear in the **Data Sources** window. Untyped datasets don't provide a schema, so the wizard doesn't have enough information to create the data source.

Follow these steps to create a data source from a service:

1. In Visual Studio, select **Project** > **Add New Data Source** to open the **Data Source Configuration Wizard**.

1. For the type of data source, select **Service**.

   The **Add Service Reference** dialog opens. You can also access this dialog by right-clicking your project in **Solution Explorer** and selecting **Add service reference**.

For detailed instructions to complete the wizard, see [Create and configure datasets in .NET Framework with Visual Studio](create-and-configure-datasets-in-visual-studio.md).

## Create data source from object

The **Data Source Configuration Wizard** also lets you create a data source from any object that exposes one or more public properties.

All public properties of an object are visible in the **Data Sources** window. If you're using Entity Framework with a generated model, this window shows the entity classes that are the data sources for your application.

> [!NOTE]
> To support drag-and-drop data binding, objects that implement the <xref:System.ComponentModel.ITypedList> or <xref:System.ComponentModel.IListSource> interface must have a default constructor. Otherwise, Visual Studio can't instantiate the data-source object and shows an error when you drag the item to the design surface.

Follow these steps to create a data source from an object:

1. In Visual Studio, select **Project** > **Add New Data Source** to open the **Data Source Configuration Wizard**.

1. For the type of data source, select **Object**.

1. On the **Select the Data Objects** page, expand the nodes in the tree view to locate the objects that you want to bind to.

   The tree view contains nodes for your project and for assemblies and other projects referenced by your project.

   1. To bind to an object in an assembly or project that doesn't appear in the tree view, select **Add Reference**.

   1. Use the **Reference Manager** dialog to add a reference to the assembly or project. After you add the reference, Visual Studio adds the assembly or project to the tree view.

   > [!NOTE]
   > You might need to build the project that contains your objects before the objects appear in the tree view.

For detailed instructions to complete the wizard, see [Create and configure datasets in .NET Framework with Visual Studio](create-and-configure-datasets-in-visual-studio.md).

## Create data source from SharePoint list

You can also use the **Data Source Configuration Wizard** to crate a data source from a SharePoint list. SharePoint exposes data through WCF Data Services, so creating a SharePoint data source is the same as creating a data source from a service.

> [!NOTE]
> This approach requires the SharePoint SDK.

Follow these steps to create a data source from a SharePoint list:

1. In Visual Studio, select **Project** > **Add New Data Source** to open the **Data Source Configuration Wizard**.

1. For the type of data source, select **SharePoint**.

1. Use the **Add Service Reference** dialog to connect to the SharePoint data service by pointing to the SharePoint Server.

For detailed instructions to complete the wizard, see [Create and configure datasets in .NET Framework with Visual Studio](create-and-configure-datasets-in-visual-studio.md).

## Related content

- Explore [Visual Studio data tools for .NET](visual-studio-data-tools-for-dotnet.md)
- [Create and configure datasets in .NET Framework with Visual Studio](create-and-configure-datasets-in-visual-studio.md)
