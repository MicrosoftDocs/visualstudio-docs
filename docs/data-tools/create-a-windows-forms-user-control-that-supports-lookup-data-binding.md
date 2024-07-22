---
title: Using lookup tables in data binding in .NET Framework Windows Forms
description: Learn to create a Windows Forms user control in .NET Framework application that supports lookup data binding, using the LookupBindingPropertiesAttribute class in Visual Studio.
ms.date: 11/04/2016
ms.topic: conceptual
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- data binding, user controls
- LookupBindingPropertiesAttribute class, examples
- user controls [Visual Basic], creating
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Create a .NET Framework Windows Forms user control that supports lookup data binding

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

When displaying data on Windows Forms, you can choose existing controls from the **Toolbox**, or you can author custom controls if your application requires functionality not available in the standard controls. This walkthrough shows how to create a control that implements the <xref:System.ComponentModel.LookupBindingPropertiesAttribute>. Controls that implement the <xref:System.ComponentModel.LookupBindingPropertiesAttribute> can contain three properties that can be bound to data. Such controls are similar to a <xref:System.Windows.Forms.ComboBox>.

For more information on control authoring, see [Developing Windows Forms controls at design time](/dotnet/framework/winforms/controls/developing-windows-forms-controls-at-design-time).

When authoring controls for use in data-binding scenarios, you need to implement one of the following data-binding attributes:

|Data-binding attribute usage|
| - |
|Implement the <xref:System.ComponentModel.DefaultBindingPropertyAttribute> on simple controls, like a <xref:System.Windows.Forms.TextBox>, that display a single column (or property) of data. For more information, see [Create a Windows Forms user control that supports simple data binding](../data-tools/create-a-windows-forms-user-control-that-supports-simple-data-binding.md).|
|Implement the <xref:System.ComponentModel.ComplexBindingPropertiesAttribute> on controls, like a <xref:System.Windows.Forms.DataGridView>, that display lists (or tables) of data. For more information, see [Create a Windows Forms user control that supports complex data binding](../data-tools/create-a-windows-forms-user-control-that-supports-complex-data-binding.md).|
|Implement the <xref:System.ComponentModel.LookupBindingPropertiesAttribute> on controls, like a <xref:System.Windows.Forms.ComboBox>, that display lists (or tables) of data, but also need to present a single column or property. (This process is described in this walkthrough page.)|

This walkthrough creates a lookup control that binds to data from two tables. This example uses the `Customers` and `Orders` tables from the Northwind sample database. The lookup control is bound to the `CustomerID` field from the `Orders` table. It uses this value to look up the `CompanyName` from the `Customers` table.

During this walkthrough, you'll learn how to:

- Create a new **Windows Forms App (.NET Framework)**.

- Add a new **User Control** to your project.

- Visually design the user control.

- Implement the `LookupBindingProperty` attribute.

- Create a dataset with the **Data Source Configuration** wizard.

- Set the **CustomerID** column on the **Orders** table, in the **Data Sources** window, to use the new control.

- Create a form to display data in the new control.

## Prerequisites

To complete this tutorial, you need the **.NET desktop development** and **Data storage and processing** workloads installed in Visual Studio. To install them, open **Visual Studio Installer** and choose **Modify** (or **More** > **Modify**) next to the version of Visual Studio you want to modify. See [Modify Visual Studio](../install/modify-visual-studio.md).

This walkthrough uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the **Visual Studio Installer**, you can install SQL Server Express LocalDB as part of the **Data storage and processing** workload, or as an individual component.

2. Install the Northwind sample database by following these steps:

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (SQL Server Object Explorer is installed as part of the **Data storage and processing** workload in the Visual Studio Installer.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query**.

       A query editor window opens.

    2. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/main/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.

    3. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

       After a short time, the query finishes running and the Northwind database is created.

## Create a Windows Forms app project

The first step is to create a **Windows Forms App (.NET Framework)** project.

1. In Visual Studio, on the **File** menu, select **New** > **Project**.

2. Expand either **Visual C#** or **Visual Basic** in the left-hand pane, then select **Windows Desktop**.

3. In the middle pane, select the **Windows Forms App** project type.

4. Name the project **LookupControlWalkthrough**, and then choose **OK**.

     The **LookupControlWalkthrough** project is created, and added to **Solution Explorer**.

## Add a user control to the project

This walkthrough creates a lookup control from a **User Control**, so add a **User Control** item to the **LookupControlWalkthrough** project.

1. From the **Project** menu, select **Add User Control**.

2. Type `LookupBox` in the **Name** area, and then select **Add**.

     The **LookupBox** control is added to **Solution Explorer**, and opens in the designer.

## Design the LookupBox control

To design the LookupBox control, drag a <xref:System.Windows.Forms.ComboBox> from the **Toolbox** onto the user control's design surface.

## Add the required data-binding attribute

For lookup controls that support data binding, you can implement the <xref:System.ComponentModel.LookupBindingPropertiesAttribute>.

1. Switch the **LookupBox** control to code view. (On the **View** menu, choose **Code**.)

2. Replace the code in the `LookupBox` with the following:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataDisplaying/CS/LookupBox.cs" id="Snippet5":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataDisplaying/VB/LookupBox.vb" id="Snippet5":::
     ---

3. From the **Build** menu, choose **Build Solution**.

## Create a data source from your database

This step creates a data source using the **Data Source Configuration** wizard, based on the `Customers` and `Orders` tables in the Northwind sample database.

1. To open the **Data Sources** window, on the **Data** menu, click **Show Data Sources**.

2. In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration** wizard.

3. Select **Database** on the **Choose a Data Source Type** page, and then select **Next**.

4. On the **Choose your Data Connection** page do one of the following:

    - If a data connection to the Northwind sample database is available in the dropdown list, select it.

    - Select **New Connection** to launch the **Add/Modify Connection** dialog box.

5. If your database requires a password, select the option to include sensitive data, and then select **Next**.

6. On the **Save connection string to the Application Configuration file** page, click **Next**.

7. On the **Choose your Database Objects** page, expand the **Tables** node.

8. Select the `Customers` and `Orders` tables, and then select **Finish**.

     The **NorthwindDataSet** is added to your project, and the `Customers` and `Orders` tables appear in the **Data Sources** window.

## Set the CustomerID column of the Orders table to use the LookupBox control

Within the **Data Sources** window, you can set the control to be created prior to dragging items onto your form.

1. Open **Form1** in the designer.

2. Expand the **Customers** node in the **Data Sources** window.

3. Expand the **Orders** node (the one in the **Customers** node below the **Fax** column).

4. Click the dropdown list arrow on the **Orders** node, and choose **Details** from the control list.

5. Click the dropdown list arrow on the **CustomerID** column (in the **Orders** node), and choose **Customize**.

6. Select the **LookupBox** from the list of **Associated Controls** in the **Data UI Customization Options** dialog box.

7. Click **OK**.

8. Click the dropdown list arrow on the **CustomerID** column, and choose **LookupBox**.

## Add controls to the form

You can create the data-bound controls by dragging items from the **Data Sources** window onto **Form1**.

To create data-bound controls on the Windows Form, drag the **Orders** node from the **Data Sources** window onto the Windows Form, and verify that the **LookupBox** control is used to display the data in the `CustomerID` column.

## Bind the control to look up CompanyName from the Customers table

To set up the lookup bindings, select the main **Customers** node in the **Data Sources** window, and drag it onto the combo box in the **CustomerIDLookupBox** on **Form1**.

This sets up the data binding to display the `CompanyName` from the `Customers` table, while maintaining the `CustomerID` value from the `Orders` table.

## Run the application

- Press **F5** to run the application.

- Navigate through some records, and verify that the `CompanyName` appears in the `LookupBox` control.

## Related content

- [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
