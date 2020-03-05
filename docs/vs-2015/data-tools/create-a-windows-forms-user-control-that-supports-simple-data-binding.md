---
title: "Create a Windows Forms user control that supports simple data binding | Microsoft Docs"
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
  - "custom controls [Visual Studio], Data Sources Window"
  - "Data Sources Window, controls"
ms.assetid: b1488366-6dfb-454e-9751-f42fd3f3ddfb
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# Create a Windows Forms user control that supports simple data binding
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When displaying data on forms in Windows applications, you can choose existing controls from the **Toolbox**, or you can author custom controls if your application requires functionality that is not available in the standard controls. This walkthrough shows how to create a control that implements the <xref:System.ComponentModel.DefaultBindingPropertyAttribute>. Controls that implement the <xref:System.ComponentModel.DefaultBindingPropertyAttribute> can contain one property that can be bound to data. Such controls are similar to a <xref:System.Windows.Forms.TextBox> or <xref:System.Windows.Forms.CheckBox>.

 For more information on control authoring, see [Developing Windows Forms Controls at Design Time](https://msdn.microsoft.com/library/e5a8e088-7ec8-4fd9-bcb3-9078fd134829).

 When authoring controls for use in data-binding scenarios, you should implement one of the following data-binding attributes:

|Data-binding attribute usage|
|-----------------------------------|
|Implement the <xref:System.ComponentModel.DefaultBindingPropertyAttribute> on simple controls, like a <xref:System.Windows.Forms.TextBox>, that display a single column (or property) of data. (This process is described in this walkthrough page.)|
|Implement the <xref:System.ComponentModel.ComplexBindingPropertiesAttribute> on controls, like a <xref:System.Windows.Forms.DataGridView>, that display lists (or tables) of data. For more information, see [Create a Windows Forms user control that supports complex data binding](../data-tools/create-a-windows-forms-user-control-that-supports-complex-data-binding.md).|
|Implement the <xref:System.ComponentModel.LookupBindingPropertiesAttribute> on controls, like a <xref:System.Windows.Forms.ComboBox>, that display lists (or tables) of data but also need to present a single column or property. For more information, see [Create a Windows Forms user control that supports lookup data binding](../data-tools/create-a-windows-forms-user-control-that-supports-lookup-data-binding.md).|

 This walkthrough creates a simple control that displays data from a single column in a table. This example uses the `Phone` column of the `Customers` table from the Northwind sample database. The simple user control will display customers' phone numbers in a standard phone-number format, by using a <xref:System.Windows.Forms.MaskedTextBox> and setting the mask to a phone number.

 During this walkthrough, you will learn how to:

- Create a new **Windows Application**.

- Add a new **User Control** to your project.

- Visually design the user control.

- Implement the `DefaultBindingProperty` attribute.

- Create a dataset with the **Data Source Configuration** wizard.

- Set the **Phone** column in the **Data Sources** window to use the new control.

- Create a form to display data in the new control.

## Prerequisites
 In order to complete this walkthrough, you will need:

- Access to the Northwind sample database.

## Create a Windows Application
 The first step is to create a **Windows Application**.

#### To create the new Windows project

1. In Visual Studio, from the **File** menu, create a new **Project**.

2. Name the project **SimpleControlWalkthrough**.

3. Select **Windows Application** and click **OK**. For more information, see [Client Applications](https://msdn.microsoft.com/library/2dfb50b7-5af2-4e12-9bbb-c5ade0e39a68).

     The **SimpleControlWalkthrough** project is created, and added to **Solution Explorer**.

## Add a user control to the project
 This walkthrough creates a simple data-bindable control from a **User Control**, so add a **User Control** item to the **SimpleControlWalkthrough** project.

#### To add a user control to the project

1. From the **Project** menu, choose **Add User Control**.

2. Type `PhoneNumberBox` in the Name area, and click **Add**.

     The **PhoneNumberBox** control is added to **Solution Explorer**, and opens in the designer.

## Design the PhoneNumberBox control
 This walkthrough expands upon the existing <xref:System.Windows.Forms.MaskedTextBox> to create the `PhoneNumberBox` control.

#### To design the PhoneNumberBox control

1. Drag a <xref:System.Windows.Forms.MaskedTextBox> from the **Toolbox** onto the user control's design surface.

2. Select the smart tag on the <xref:System.Windows.Forms.MaskedTextBox> you just dragged, and choose **Set Mask**.

3. Select **Phone number** in the **Input Mask** dialog box, and click **OK** to set the mask.

## Add the required data-binding attribute
 For simple controls that support databinding, implement the <xref:System.ComponentModel.DefaultBindingPropertyAttribute>.

#### To implement the DefaultBindingProperty attribute

1. Switch the `PhoneNumberBox` control to code view. (On the **View** menu, choose **Code**.)

2. Replace the code in the `PhoneNumberBox` with the following:

     [!code-csharp[VbRaddataDisplaying#3](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataDisplaying/CS/PhoneNumberBox.cs#3)]
     [!code-vb[VbRaddataDisplaying#3](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataDisplaying/VB/PhoneNumberBox.vb#3)]

3. From the **Build** menu, choose **Build Solution**.

## Create a data source from your database
 This step uses the **Data Source Configuration** wizard to create a data source based on the `Customers` table in the Northwind sample database. You must have access to the Northwind sample database to create the connection.

#### To create the data source

1. On the **Data** menu, click **Show Data Sources**.

2. In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration** wizard.

3. On the **Choose a Data Source Type** page, select **Database**, and then click **Next**.

4. On the **Choose your Data Connection** page, do one of the following:

    - If a data connection to the Northwind sample database is available in the drop-down list, select it.

    - Select **New Connection** to launch the **Add/Modify Connection** dialog box.

5. If your database requires a password, select the option to include sensitive data, and then click **Next**.

6. On the **Save connection string to the Application Configuration file** page, click **Next**.

7. On the **Choose your Database Objects** page, expand the **Tables** node.

8. Select the `Customers` table, and then click **Finish**.

     The **NorthwindDataSet** is added to your project, and the `Customers` table appears in the **Data Sources** window.

## Set the phone column to use the PhoneNumberBox control
 Within the **Data Sources** window, you can set the control to be created prior to dragging items onto your form.

#### To set the phone column to bind to the PhoneNumberBox control

1. Open **Form1** in the designer.

2. Expand the **Customers** node in the **Data Sources** window.

3. Click the drop-down arrow on the **Customers** node, and choose **Details** from the control list.

4. Click the drop-down arrow on the **Phone** column, and choose **Customize**.

5. Select the **PhoneNumberBox** from the list of **Associated Controls** in the **Data UI Customization Options** dialog box.

6. Click the drop-down arrow on the **Phone** column, and choose **PhoneNumberBox**.

## Addcontrols to the form
 You can create the data-bound controls by dragging items from the **Data Sources** window onto the form.

#### To create data-bound controls on the form

- Drag the main **Customers** node from the **Data Sources** window onto the form, and verify that the `PhoneNumberBox` control is used to display the data in the `Phone` column.

     Data-bound controls with descriptive labels appear on the form, along with a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), CustomersTableAdapter, <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.

## Run the application

#### To run the application

- Press F5 to run the application.

## Next Steps
 Depending on your application requirements, there are several steps you may want to perform after creating a control that supports data binding. Some typical next steps include:

- Placing your custom controls in a control library so you can reuse them in other applications.

- Creating controls that support more complex data-binding scenarios. For more information, see [Create a Windows Forms user control that supports complex data binding](../data-tools/create-a-windows-forms-user-control-that-supports-complex-data-binding.md) and [Create a Windows Forms user control that supports lookup data binding](../data-tools/create-a-windows-forms-user-control-that-supports-lookup-data-binding.md).

## See Also
 [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
 [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md)
