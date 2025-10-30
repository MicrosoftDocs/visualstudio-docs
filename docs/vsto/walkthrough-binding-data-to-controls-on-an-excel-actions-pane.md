---
title: "Walkthrough: Bind data to controls on an Excel actions pane"
description: Bind data to controls on an actions pane in Microsoft Excel. The controls demonstrate a master/detail relation between tables in a SQL Server database.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
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
# Walkthrough: Bind data to controls on an Excel actions pane

  This walkthrough demonstrates data binding to controls on an actions pane in Microsoft Office Excel. The controls demonstrate a master/detail relation between tables in a SQL Server database.

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

 This walkthrough illustrates the following tasks:

- Adding controls to a worksheet.

- Creating an actions pane control.

- Adding data-bound Windows Forms controls to an actions pane control.

- Showing the actions pane when the application opens.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

-  Excel 2013  or  Excel 2010 .

- Access to a server with the Northwind SQL Server sample database.

- Permissions to read from and write to the SQL Server database.

## Create the project
 The first step is to create an Excel Workbook project.

### To create a new project

1. Create an Excel Workbook project with the name **My Excel Actions Pane**. In the wizard, select **Create a new document**. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the new Excel workbook in the designer and adds the **My Excel Actions Pane** project to **Solution Explorer**.

## Add a new data source to the project

### To add a new data source to the project

1. If the **Data Sources** window isn't visible, display it by, on the menu bar, choosing **View** > **Other Windows** > **Data Sources**.

2. Choose **Add New Data Source** to start the **Data Source Configuration Wizard**.

3. Select **Database** and then click **Next**.

4. Select a data connection to the Northwind sample SQL Server database, or add a new connection by using the **New Connection** button.

5. Click **Next**.

6. Clear the option to save the connection if it's selected, and then click **Next**.

7. Expand the **Tables** node in the **Database objects** window.

8. Select the check box next to the **Suppliers** table.

9. Expand the **Products** table and select **ProductName**, **SupplierID**, **QuantityPerUnit**, and **UnitPrice**.

10. Click **Finish**.

    The wizard adds the **Suppliers** table and **Products** table to the **Data Sources** window. It also adds a typed dataset to your project that is visible in **Solution Explorer**.

## Add controls to the worksheet
 Next, add a <xref:Microsoft.Office.Tools.Excel.NamedRange> control and a <xref:Microsoft.Office.Tools.Excel.ListObject> control to the first worksheet.

### To add a NamedRange control and a ListObject control

1. Verify that the **My Excel Actions Pane.xlsx** workbook is open in the Visual Studio designer, with `Sheet1` displayed.

2. In the **Data Sources** window, expand the **Suppliers** table.

3. Click the drop-down arrow on the **Company Name** node, and then click **NamedRange**.

4. Drag **Company Name** from the **Data Sources** window to cell **A2** in `Sheet1`.

     A <xref:Microsoft.Office.Tools.Excel.NamedRange> control named `CompanyNameNamedRange` is created, and the text \<CompanyName> appears in cell **A2**. At the same time, a <xref:System.Windows.Forms.BindingSource> named `suppliersBindingSource`, a table adapter, and a <xref:System.Data.DataSet> are added to the project. The control is bound to the <xref:System.Windows.Forms.BindingSource>, which in turn is bound to the <xref:System.Data.DataSet> instance.

5. In the **Data Sources** window, scroll down past the columns that are under the **Suppliers** table. At the bottom of the list is the **Products** table; it's here because it's a child of the **Suppliers** table. Select this **Products** table, not the one that is at the same level as the **Suppliers** table, and then click the drop-down arrow that appears.

6. Click **ListObject** in the drop-down list, and then drag the **Products** table to cell **A6** in `Sheet1`.

     A <xref:Microsoft.Office.Tools.Excel.ListObject> control named `ProductNameListObject` is created in cell **A6**. At the same time, a <xref:System.Windows.Forms.BindingSource> named `productsBindingSource` and a table adapter are added to the project. The control is bound to the <xref:System.Windows.Forms.BindingSource>, which in turn is bound to the <xref:System.Data.DataSet> instance.

7. For C# only, select **suppliersBindingSource** on the component tray, and change the **Modifiers** property to **Internal** in the **Properties** window.

## Add controls to the actions pane
 Next, you need an actions pane control that has a combo box.

### To add an actions pane control

1. Select the **My Excel Actions Pane** project in **Solution Explorer**.

2. On the **Project** menu, click **Add New Item**.

3. In the **Add New Item** dialog box, select **Actions Pane Control**, name it **ActionsControl**, and click **Add**.

### To add data-bound Windows Forms controls to an actions pane control

1. From the **Common Controls** tabs of the **Toolbox**, drag a <xref:System.Windows.Forms.ComboBox> control to the actions pane control.

2. Change the **Size** property to **171, 21**.

3. Resize the user control to fit the combo box.

## Bind the control on the actions pane to data
 In this section, you'll set the data source of the <xref:System.Windows.Forms.ComboBox> to the same data source as the <xref:Microsoft.Office.Tools.Excel.NamedRange> control on the worksheet.

### To set data binding properties of the control

1. Right-click the actions pane control, and then click **View Code**.

2. Add the following code to the <xref:System.Windows.Forms.UserControl.Load> event of the actions pane control.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneExcelCS/ActionsControl.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneExcelVB/ActionsControl.vb" id="Snippet1":::
     ---

3. In C#, you must create an event handler for the `ActionsControl`. You can place this code in the `ActionsControl` constructor. For more information about creating event handlers, see [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md).

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneExcelCS/ActionsControl.cs" id="Snippet2":::

## Show the actions pane
 The actions pane isn't visible until you add the control at run time.

#### To show the actions pane

1. In **Solution Explorer**, right-click *ThisWorkbook.vb* or *ThisWorkbook.cs*, and then click **View Code**.

2. Create a new instance of the user control in the `ThisWorkbook` class.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneExcelCS/ThisWorkbook.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneExcelVB/ThisWorkbook.vb" id="Snippet3":::
     ---

3. In the <xref:Microsoft.Office.Tools.Excel.Workbook.Startup> event handler of `ThisWorkbook`, add the control to the actions pane.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneExcelCS/ThisWorkbook.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneExcelVB/ThisWorkbook.vb" id="Snippet4":::
     ---

## Test the application
 Now you can test your document to verify that the actions pane opens when the document is opened, and that the controls have a master/detail relation.

### To test your document

1. Press **F5** to run your project.

2. Confirm that the actions pane is visible.

3. Select a company in the list box. Verify that the company name is listed in the <xref:Microsoft.Office.Tools.Excel.NamedRange> control and that the product details are listed in the <xref:Microsoft.Office.Tools.Excel.ListObject> control.

4. Select various companies to verify the company name and product details change as appropriate.

## Next steps
 Here are some tasks that might come next:

- Binding data to controls in Word. For more information, see [Walkthrough: Bind data to controls on a Word actions pane](../vsto/walkthrough-binding-data-to-controls-on-a-word-actions-pane.md).

- Deploying the project. For more information, see [Deploy an Office solution by using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md).

## Related content
- [Actions pane overview](../vsto/actions-pane-overview.md)
- [How to: Manage control layout on actions panes](../vsto/how-to-manage-control-layout-on-actions-panes.md)
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
