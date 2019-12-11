---
title: Create a Windows Forms user control with data binding
ms.date: 11/04/2016
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "data binding, user controls"
  - "data binding, complex"
  - "user controls [Visual Studio], complex data binding"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Create a Windows Forms user control that supports complex data binding

When displaying data on forms in Windows applications, you can choose existing controls from the **Toolbox**. Or, you can author custom controls if your application requires functionality that is not available in the standard controls. This walkthrough shows how to create a control that implements the <xref:System.ComponentModel.ComplexBindingPropertiesAttribute>. Controls that implement the <xref:System.ComponentModel.ComplexBindingPropertiesAttribute> contain a `DataSource` and `DataMember` property that can be bound to data. Such controls are similar to a <xref:System.Windows.Forms.DataGridView> or <xref:System.Windows.Forms.ListBox>.

For more information on control authoring, see [Developing Windows Forms controls at design time](/dotnet/framework/winforms/controls/developing-windows-forms-controls-at-design-time).

When authoring controls for use in data-binding scenarios you need to implement one of the following data-binding attributes:

|Data-binding attribute usage|
| - |
|Implement the <xref:System.ComponentModel.DefaultBindingPropertyAttribute> on simple controls, like a <xref:System.Windows.Forms.TextBox>, that display a single column (or property) of data. For more information, see [Create a Windows Forms user control that supports simple data binding](../data-tools/create-a-windows-forms-user-control-that-supports-simple-data-binding.md).|
|Implement the <xref:System.ComponentModel.ComplexBindingPropertiesAttribute> on controls, like a <xref:System.Windows.Forms.DataGridView>, that display lists (or tables) of data. (This process is described in this walkthrough page.)|
|Implement the <xref:System.ComponentModel.LookupBindingPropertiesAttribute> on controls, like a <xref:System.Windows.Forms.ComboBox>, that display lists (or tables) of data but also need to present a single column or property. For more information, see [Create a Windows Forms user control that supports lookup data binding](../data-tools/create-a-windows-forms-user-control-that-supports-lookup-data-binding.md).|

This walkthrough creates a complex control that displays rows of data from a table. This example uses the `Customers` table from the Northwind sample database. The complex user control will display the customers table in a <xref:System.Windows.Forms.DataGridView> in the custom control.

During this walkthrough, you'll learn how to:

- Add a new **User Control** to your project.

- Visually design the user control.

- Implement the `ComplexBindingProperty` attribute.

- Create a dataset with the [Data Source Configuration Wizard](../data-tools/media/data-source-configuration-wizard.png).

- Set the **Customers** table in the [Data Sources window](add-new-data-sources.md#data-sources-window) to use the new complex control.

- Add the new control by dragging it from the **Data Sources** window onto **Form1**.

## Prerequisites

This walkthrough uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the **Visual Studio Installer**, you can install SQL Server Express LocalDB as part of the **Data storage and processing** workload, or as an individual component.

1. Install the Northwind sample database by following these steps:

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (SQL Server Object Explorer is installed as part of the **Data storage and processing** workload in the Visual Studio Installer.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query**.

       A query editor window opens.

    1. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/master/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.

    1. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

       After a short time, the query finishes running and the Northwind database is created.

## Create a Windows Forms app project

The first step is to create a **Windows Forms App** project for either C# or Visual Basic. Name the project **ComplexControlWalkthrough**.

## Add a user control to the project

Because this walkthrough creates a complex data-bindable control from a **User Control**, add a **User Control** item to the project:

1. From the **Project** menu, choose **Add User Control**.

1. Type **ComplexDataGridView** in the **Name** area, and then click **Add**.

    The **ComplexDataGridView** control is added to **Solution Explorer**, and opens in the designer.

## Design the ComplexDataGridView control

To add a <xref:System.Windows.Forms.DataGridView> to the user control, drag a <xref:System.Windows.Forms.DataGridView> from the **Toolbox** onto the user control's design surface.

## Add the required data-binding attribute

For complex controls that support data binding, you can implement the <xref:System.ComponentModel.ComplexBindingPropertiesAttribute>:

1. Switch the **ComplexDataGridView** control to code view. (On the **View** menu, select **Code**.)

1. Replace the code in the `ComplexDataGridView` with the following:

    [!code-csharp[VbRaddataDisplaying#4](../data-tools/codesnippet/CSharp/create-a-windows-forms-user-control-that-supports-complex-data-binding_1.cs)]
    [!code-vb[VbRaddataDisplaying#4](../data-tools/codesnippet/VisualBasic/create-a-windows-forms-user-control-that-supports-complex-data-binding_1.vb)]

1. From the **Build** menu, choose **Build Solution**.

## Create a data source from your database

Use the **Data Source Configuration** wizard to create a data source based on the `Customers` table in the Northwind sample database:

1. To open the **Data Sources** window, on the **Data** menu, click **Show Data Sources**.

2. In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration** wizard.

3. Select **Database** on the **Choose a Data Source Type** page, and then click **Next**.

4. On the **Choose your Data Connection** page do one of the following:

   - If a data connection to the Northwind sample database is available in the drop-down list, select it.

   - Select **New Connection** to launch the **Add/Modify Connection** dialog box.

5. If your database requires a password, select the option to include sensitive data, and then click **Next**.

6. On the **Save connection string to the Application Configuration file** page, click **Next**.

7. On the **Choose your Database Objects** page, expand the **Tables** node.

8. Select the `Customers` table, and then click **Finish**.

   The **NorthwindDataSet** is added to your project, and the `Customers` table appears in the **Data Sources** window.

## Set the Customers table to use the ComplexDataGridView control

Within the **Data Sources** window, you can set the control to be created prior to dragging items onto your form:

1. Open **Form1** in the designer.

1. Expand the **Customers** node in the **Data Sources** window.

1. Click the drop-down arrow on the **Customers** node, and choose **Customize**.

1. Select the **ComplexDataGridView** from the list of **Associated Controls** in the **Data UI Customization Options** dialog box.

1. Click the drop-down arrow on the `Customers` table, and choose **ComplexDataGridView** from the control list.

## Add controls to the form

You can create the data-bound controls by dragging items from the **Data Sources** window onto your form. Drag the main **Customers** node from the **Data Sources** window onto the form. Verify that the **ComplexDataGridView** control is used to display the table's data.

## Run the application

Press **F5** to run the application.

## Next steps

Depending on your application requirements, there are several steps you may want to perform after creating a control that supports databinding. Some typical next steps include:

- Placing your custom controls in a control library so you can reuse them in other applications.

- Creating controls that support lookup scenarios. For more information, see [Create a Windows Forms user control that supports lookup data binding](../data-tools/create-a-windows-forms-user-control-that-supports-lookup-data-binding.md).

## See also

- [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
- [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md)
- [Windows Forms Controls](/dotnet/framework/winforms/controls/index)