---
title: "Walkthrough: Bind data to controls on a Word actions pane"
description: Bind data to controls on an actions pane in Microsoft Word. The controls demonstrate a master/detail relation between tables in a SQL Server database.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "controls [Office development in Visual Studio], data binding"
  - "actions panes [Office development in Visual Studio], data binding"
  - "data binding [Office development in Visual Studio], smart documents"
  - "data binding [Office development in Visual Studio], actions panes"
  - "actions panes [Office development in Visual Studio], binding controls"
  - "smart documents [Office development in Visual Studio], data binding"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Bind data to controls on a Word actions pane

[!INCLUDE[actions-retirement-md](../vsto/includes/actions-retirement-md.md)]

  This walkthrough demonstrates data binding to controls on an actions pane in Word. The controls demonstrate a master/detail relation between tables in a SQL Server database.

 [!INCLUDE[appliesto_wdalldoc](../vsto/includes/appliesto-wdalldoc-md.md)]

 This walkthrough illustrates the following tasks:

- Creating an actions pane with Windows Forms controls that are bound to data.

- Using a master/detail relationship to display data in the controls.

- Show the actions pane when the application opens.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

-  Word 2013  or  Word 2010 .

- Access to a server with the Northwind SQL Server sample database.

- Permissions to read from and write to the SQL Server database.

## Create the project
 The first step is to create a Word Document project.

### To create a new project

1. Create a Word Document project with the name **My Word Actions Pane**. In the wizard, select **Create a new document**.

     For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the new Word document in the designer and adds the **My Word Actions Pane** project to **Solution Explorer**.

## Add controls to the actions pane
 For this walkthrough, you need an actions pane control that contains data-bound Windows Forms controls. Add a data source to the project, and then drag controls from the **Data Sources** window to the actions pane control.

### To add an actions pane control

1. Select the **My Word Actions Pane** project in **Solution Explorer**.

2. On the **Project** menu, click **Add New Item**.

3. In the **Add New Item** dialog box, select **Actions Pane Control**, name it **ActionsControl**, and then click **Add**.

### To add a data source to the project

1. If the **Data Sources** window is not visible, display it by, on the menu bar, choosing **View** > **Other Windows** > **Data Sources**.

   > [!NOTE]
   > If **Show Data Sources** is not available, click the Word document and then check again.

2. Click **Add New Data Source** to start the **Data Source Configuration Wizard**.

3. Select **Database** and then click **Next**.

4. Select a data connection to the Northwind sample SQL Server database, or add a new connection by using the **New Connection** button.

5. Click **Next**.

6. Clear the option to save the connection if it is selected, and then click **Next**.

7. Expand the **Tables** node in the **Database objects** window.

8. Select the check box next to the **Suppliers** and **Products** tables.

9. Click **Finish**.

   The wizard adds the **Suppliers** table and **Products** table to the **Data Sources** window. It also adds a typed dataset to your project that is visible in **Solution Explorer**.

### To add data-bound Windows Forms controls to an actions pane control

1. In the **Data Sources** window, expand the **Suppliers** table.

2. Click the drop-down arrow on the **Company Name** node, and select **ComboBox**.

3. Drag **CompanyName** from the **Data Sources** window to the actions pane control.

     A <xref:System.Windows.Forms.ComboBox> control is created on the actions pane control. At the same time, a <xref:System.Windows.Forms.BindingSource> named `SuppliersBindingSource`, a table adapter, and a <xref:System.Data.DataSet> are added to the project in the component tray.

4. Select `SuppliersBindingNavigator` in the **Component** tray and press **Delete**. You will not use the `SuppliersBindingNavigator` in this walkthrough.

    > [!NOTE]
    > Deleting the `SuppliersBindingNavigator` does not remove all of the code that was generated for it. You can remove this code.

5. Move the combo box so that it is under the label and change the **Size** property to **171, 21**.

6. In the **Data Sources** window, expand the **Products** table that is a child of the **Suppliers** table.

7. Click the drop-down arrow on the **ProductName** node, and select **ListBox**.

8. Drag **ProductName** to the actions pane control.

     A <xref:System.Windows.Forms.ListBox> control is created on the actions pane control. At the same time, a <xref:System.Windows.Forms.BindingSource> named `ProductBindingSource` and a table adapter are added to the project in the component tray.

9. Move the list box so that it is under the label and change the **Size** property to **171,95**.

10. Drag a <xref:System.Windows.Forms.Button> from the **Toolbox** onto the actions pane control and place it below the list box.

11. Right-click the <xref:System.Windows.Forms.Button>, click **Properties** on the shortcut menu, and change the following properties.

    |Property|Value|
    |--------------|-----------|
    |**Name**|**Insert**|
    |**Text**|**Insert**|

12. Resize the user control to fit the controls.

## Set up the data source
 To set up the data source, add code to the <xref:System.Windows.Forms.UserControl.Load> event of the actions pane control to fill the control with data from the <xref:System.Data.DataTable>, and set the <xref:System.Windows.Forms.Binding.DataSource%2A> and <xref:System.Windows.Forms.BindingSource.DataMember%2A> properties for each control.

### To load the control with data

1. In the <xref:System.Windows.Forms.UserControl.Load> event handler of the `ActionsControl` class, add the following code.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ActionsControl.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ActionsControl.vb" id="Snippet1":::
     ---

2. In C#, you must attach the event handler to the <xref:System.Windows.Forms.UserControl.Load> event. You can place this code in the `ActionsControl` constructor, after the call to `InitializeComponent`. For more information about how to create event handlers, see [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md).

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ActionsControl.cs" id="Snippet33":::

### To set data binding properties of the controls

1. Select the `CompanyNameComboBox` control.

2. In the **Properties** window, click the button to the right of the **DataSource** property, and select **suppliersBindingSource**.

3. Click the button to the right of the **DisplayMember** property, and select **CompanyName**.

4. Expand the **DataBindings** property, click the button to the right of the **Text** property, and select **None**.

5. Select the `ProductNameListBox` control.

6. In the **Properties** window, click the button to the right of the **DataSource** property, and select **productsBindingSource**.

7. Click the button to the right of the **DisplayMember** property, and select **ProductName**.

8. Expand the **DataBindings** property, click the button to the right of the **SelectedValue** property, and select **None**.

## Add a method to insert data into a table
 The next task is to read the data from the bound controls and populate a table in your Word document. First, create a procedure for formatting the headings in the table, and then add the `AddData` method to create and format a Word table.

### To format the table headings

1. In the `ActionsControl` class, create a method to format the headings of the table.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ActionsControl.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ActionsControl.vb" id="Snippet2":::
     ---

### To create the table

1. In the `ActionsControl` class, write a method that will create a table if one does not already exist, and add data from the actions pane to the table.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ActionsControl.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ActionsControl.vb" id="Snippet3":::
     ---

### To insert text into a Word table

1. Add the following code to the <xref:System.Windows.Forms.Control.Click> event handler of the **Insert** button.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ActionsControl.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ActionsControl.vb" id="Snippet4":::
     ---

2. In C#, you must create an event handler for the <xref:System.Windows.Forms.Control.Click> event of the button.  You can place this code in the <xref:System.Windows.Forms.UserControl.Load> event handler of the `ActionsControl` class.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ActionsControl.cs" id="Snippet5":::

## Show the actions pane
 The actions pane becomes visible after controls are added to it.

### To show the actions pane

1. In **Solution Explorer**, right-click **ThisDocument.vb** or **ThisDocument.cs**, and then click **View Code** on the shortcut menu.

2. Create a new instance of the control at the top of the `ThisDocument` class so that it looks like the following example.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ThisDocument.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ThisDocument.vb" id="Snippet6":::
     ---

3. Add code to the <xref:Microsoft.Office.Tools.Word.Document.Startup> event handler of `ThisDocument` so that it looks like the following example.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ThisDocument.cs" id="Snippet7":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ThisDocument.vb" id="Snippet7":::
     ---

## Test the application
 Now you can test your document to verify that the actions pane appears when the document is opened. Test for the master/detail relationship in the controls on the actions pane, and make sure that data is populated in a Word table when the **Insert** button is clicked.

### To test your document

1. Press **F5** to run your project.

2. Confirm that the actions pane is visible.

3. Select a company in the combo box and verify that the items in the **Products** list box change.

4. Select a product, click **Insert** on the actions pane, and verify that the product details are added to the table in Word.

5. Insert additional products from various companies.

## Next steps
 This walkthrough shows the basics of binding data to controls on an actions pane in Word. Here are some tasks that might come next:

- Binding data to controls in Excel. For more information, see [Walkthrough: Bind data to controls on an Excel actions pane](../vsto/walkthrough-binding-data-to-controls-on-an-excel-actions-pane.md).

- Deploying the project. For more information, see [Deploy an Office solution by using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md).

## Related content
- [Actions pane overview](../vsto/actions-pane-overview.md)
- [How to: Add an actions pane to Word documents or Excel workbooks](../vsto/how-to-add-an-actions-pane-to-word-documents-or-excel-workbooks.md)
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
