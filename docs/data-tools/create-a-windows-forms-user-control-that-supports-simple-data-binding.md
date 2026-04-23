---
title: Create .NET Framework user controls that support simple data binding
description: Learn to create a Windows Forms user control that supports simple data binding in a .NET Framework application, using the DefaultBindingPropertyAttribute class in Visual Studio.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- custom controls [Visual Studio], Data Sources Window
- Data Sources Window, controls
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Create a .NET Framework Windows Forms user control that supports simple data binding

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

When displaying data on forms in Windows applications, you can choose existing controls from the **Toolbox**, or you can author custom controls if your application requires functionality that is not available in the standard controls. This walkthrough shows how to create a control that implements the <xref:System.ComponentModel.DefaultBindingPropertyAttribute>. Controls that implement the <xref:System.ComponentModel.DefaultBindingPropertyAttribute> can contain one property that can be bound to data. Such controls are similar to a <xref:System.Windows.Forms.TextBox> or <xref:System.Windows.Forms.CheckBox>.

For more information on control authoring, see [Developing Windows Forms Controls at Design Time](/dotnet/framework/winforms/controls/developing-windows-forms-controls-at-design-time).

When authoring controls for use in data-binding scenarios, you should implement one of the following data-binding attributes:

|Data-binding attribute usage|
| - |
|Implement the <xref:System.ComponentModel.DefaultBindingPropertyAttribute> on simple controls, like a <xref:System.Windows.Forms.TextBox>, that display a single column (or property) of data. (This process is described in this walkthrough page.)|
|Implement the <xref:System.ComponentModel.ComplexBindingPropertiesAttribute> on controls, like a <xref:System.Windows.Forms.DataGridView>, that display lists (or tables) of data. For more information, see [Create a Windows Forms user control that supports complex data binding](../data-tools/create-a-windows-forms-user-control-that-supports-complex-data-binding.md).|
|Implement the <xref:System.ComponentModel.LookupBindingPropertiesAttribute> on controls, like a <xref:System.Windows.Forms.ComboBox>, that display lists (or tables) of data but also need to present a single column or property. For more information, see [Create a Windows Forms user control that supports lookup data binding](../data-tools/create-a-windows-forms-user-control-that-supports-lookup-data-binding.md).|

This walkthrough creates a simple control that displays data from a single column in a table. This example uses the `Phone` column of the `Customers` table from the Northwind sample database. The simple user control displays customers' phone numbers in a standard phone-number format, by using a <xref:System.Windows.Forms.MaskedTextBox> and setting the mask to a phone number.

During this walkthrough, you will learn how to:

- Create a new **Windows Forms App (.NET Framework)**.

- Add a new **User Control** to your project.

- Visually design the user control.

- Implement the `DefaultBindingProperty` attribute.

- Create a dataset with the **Data Source Configuration** wizard.

- Set the **Phone** column in the **Data Sources** window to use the new control.

- Create a form to display data in the new control.

## Prerequisites

To complete this tutorial, you need the **.NET desktop development** and **Data storage and processing** workloads installed in Visual Studio. To install them, open **Visual Studio Installer** and choose **Modify** (or **More** > **Modify**) next to the version of Visual Studio you want to modify. See [Modify Visual Studio](../install/modify-visual-studio.md).

This walkthrough uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the **Visual Studio Installer**, you can install SQL Server Express LocalDB as part of the **Data storage and processing** workload, or as an individual component.

2. Install the Northwind sample database by following these steps:

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (SQL Server Object Explorer is installed as part of the **Data storage and processing** workload in the **Visual Studio Installer**.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query**.

       A query editor window opens.

    2. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/main/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.

    3. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

       After a short time, the query finishes running and the Northwind database is created.

## Create a Windows Forms Application

The first step is to create a **Windows Forms App (.NET Framework)**:

1. In Visual Studio, on the **File** menu, select **New** > **Project**.

2. Expand either **Visual C#** or **Visual Basic** in the left-hand pane, then select **Windows Desktop**.

3. In the middle pane, select the **Windows Forms App** project type.

4. Name the project **SimpleControlWalkthrough**, and then choose **OK**.

     The **SimpleControlWalkthrough** project is created, and added to **Solution Explorer**.

## Add a user control to the project

This walkthrough creates a simple data-bindable control from a **User Control**. Add a **User Control** item to the **SimpleControlWalkthrough** project:

1. From the **Project** menu, choose **Add User Control**.

2. Type **PhoneNumberBox** in the Name area, and click **Add**.

     The **PhoneNumberBox** control is added to **Solution Explorer**, and opens in the designer.

## Design the PhoneNumberBox control

This walkthrough expands upon the existing <xref:System.Windows.Forms.MaskedTextBox> to create the **PhoneNumberBox** control:

1. Drag a <xref:System.Windows.Forms.MaskedTextBox> from the **Toolbox** onto the user control's design surface.

2. Select the smart tag on the <xref:System.Windows.Forms.MaskedTextBox> you just dragged, and choose **Set Mask**.

3. Select **Phone number** in the **Input Mask** dialog box, and click **OK** to set the mask.

## Add the required data-binding attribute

For simple controls that support databinding, implement the <xref:System.ComponentModel.DefaultBindingPropertyAttribute>:

1. Switch the **PhoneNumberBox** control to code view. (On the **View** menu, choose **Code**.)

2. Replace the code in the **PhoneNumberBox** with the following:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataDisplaying/CS/PhoneNumberBox.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataDisplaying/VB/PhoneNumberBox.vb" id="Snippet3":::
     ---

3. From the **Build** menu, choose **Build Solution**.

## Create a data source from your database

This step uses the **Data Source Configuration** wizard to create a data source based on the `Customers` table in the Northwind sample database. You must have access to the Northwind sample database to create the connection. For information on setting up the Northwind sample database, see [How to: Install sample databases](../data-tools/installing-database-systems-tools-and-samples.md).

1. To open the **Data Sources** window, on the **Data** menu, click **Show Data Sources**.

2. In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration** wizard.

3. On the **Choose a Data Source Type** page, select **Database**, and then select **Next**.

4. On the **Choose your Data Connection** page, do one of the following:

    - If a data connection to the Northwind sample database is available in the dropdown list, select it.

    - Select **New Connection** to launch the **Add/Modify Connection** dialog box.

5. If your database requires a password, select the option to include sensitive data, and then select **Next**.

6. On the **Save connection string to the Application Configuration file** page, click **Next**.

7. On the **Choose your Database Objects** page, expand the **Tables** node.

8. Select the `Customers` table, and then select **Finish**.

     The **NorthwindDataSet** is added to your project, and the `Customers` table appears in the **Data Sources** window.

## Set the phone column to use the PhoneNumberBox control

Within the **Data Sources** window, you can set the control to be created prior to dragging items onto your form:

1. Open **Form1** in the designer.

2. Expand the **Customers** node in the **Data Sources** window.

3. Click the dropdown list arrow on the **Customers** node, and choose **Details** from the control list.

4. Click the dropdown list arrow on the **Phone** column, and choose **Customize**.

5. Select the **PhoneNumberBox** from the list of **Associated Controls** in the **Data UI Customization Options** dialog box.

6. Click the dropdown list arrow on the **Phone** column, and choose **PhoneNumberBox**.

## Add controls to the form

You can create the data-bound controls by dragging items from the **Data Sources** window onto the form.

To create data-bound controls on the form, drag the main **Customers** node from the **Data Sources** window onto the form, and verify that the **PhoneNumberBox** control is used to display the data in the **Phone** column.

Data-bound controls with descriptive labels appear on the form, along with a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), CustomersTableAdapter, <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.

## Run the application

Press **F5** to run the application.

## Next steps

Depending on your application requirements, there are several steps you might want to perform after creating a control that supports data binding. Some typical next steps include:

- Placing your custom controls in a control library so you can reuse them in other applications.

- Creating controls that support more complex data-binding scenarios. For more information, see [Create a Windows Forms user control that supports complex data binding](../data-tools/create-a-windows-forms-user-control-that-supports-complex-data-binding.md) and [Create a Windows Forms user control that supports lookup data binding](../data-tools/create-a-windows-forms-user-control-that-supports-lookup-data-binding.md).

## Related content

- [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
- [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md)
