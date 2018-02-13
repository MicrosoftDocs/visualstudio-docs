---
title: "Walkthrough: Binding Data to Controls on a Word Actions Pane | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Walkthrough: Binding Data to Controls on a Word Actions Pane
  This walkthrough demonstrates data binding to controls on an actions pane in Word. The controls demonstrate a master/detail relation between tables in a SQL Server database.  
  
 [!INCLUDE[appliesto_wdalldoc](../vsto/includes/appliesto-wdalldoc-md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   Creating an actions pane with Windows Forms controls that are bound to data.  
  
-   Using a master/detail relationship to display data in the controls.  
  
-   Show the actions pane when the application opens.  
  
> [!NOTE]  
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]  
  
-   [!INCLUDE[Word_15_short](../vsto/includes/word-15-short-md.md)] or [!INCLUDE[Word_14_short](../vsto/includes/word-14-short-md.md)].  
  
-   Access to a server with the Northwind SQL Server sample database.  
  
-   Permissions to read from and write to the SQL Server database.  
  
## Creating the Project  
 The first step is to create a Word Document project.  
  
#### To create a new project  
  
1.  Create a Word Document project with the name **My Word Actions Pane**. In the wizard, select **Create a new document**.  
  
     For more information, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).  
  
     Visual Studio opens the new Word document in the designer and adds the **My Word Actions Pane** project to **Solution Explorer**.  
  
## Adding Controls to the Actions Pane  
 For this walkthrough, you need an actions pane control that contains data-bound Windows Forms controls. Add a data source to the project, and then drag controls from the **Data Sources** window to the actions pane control.  
  
#### To add an actions pane control  
  
1.  Select the **My Word Actions Pane** project in **Solution Explorer**.  
  
2.  On the **Project** menu, click **Add New Item**.  
  
3.  In the **Add New Item** dialog box, select **Actions Pane Control**, name it **ActionsControl**, and then click **Add**.  
  
#### To add a data source to the project  
  
1.  If the **Data Sources** window is not visible, display it by, on the menu bar, choosing **View**, **Other Windows**, **Data Sources**.  
  
    > [!NOTE]  
    >  If **Show Data Sources** is not available, click the Word document and then check again.  
  
2.  Click **Add New Data Source** to start the **Data Source Configuration Wizard**.  
  
3.  Select **Database** and then click **Next**.  
  
4.  Select a data connection to the Northwind sample SQL Server database, or add a new connection by using the **New Connection** button.  
  
5.  Click **Next**.  
  
6.  Clear the option to save the connection if it is selected, and then click **Next**.  
  
7.  Expand the **Tables** node in the **Database objects** window.  
  
8.  Select the check box next to the **Suppliers** and **Products** tables.  
  
9. Click **Finish**.  
  
 The wizard adds the **Suppliers** table and **Products** table to the **Data Sources** window. It also adds a typed dataset to your project that is visible in **Solution Explorer**.  
  
#### To add data-bound Windows Forms controls to an actions pane control  
  
1.  In the **Data Sources** window, expand the **Suppliers** table.  
  
2.  Click the drop-down arrow on the **Company Name** node, and select **ComboBox**.  
  
3.  Drag **CompanyName** from the **Data Sources** window to the actions pane control.  
  
     A <xref:System.Windows.Forms.ComboBox> control is created on the actions pane control. At the same time, a <xref:System.Windows.Forms.BindingSource> named `SuppliersBindingSource`, a table adapter, and a <xref:System.Data.DataSet> are added to the project in the component tray.  
  
4.  Select `SuppliersBindingNavigator` in the **Component** tray and press DELETE. You will not use the `SuppliersBindingNavigator` in this walkthrough.  
  
    > [!NOTE]  
    >  Deleting the `SuppliersBindingNavigator` does not remove all of the code that was generated for it. You can remove this code.  
  
5.  Move the combo box so that it is under the label and change the **Size** property to **171, 21**.  
  
6.  In the **Data Sources** window, expand the **Products** table that is a child of the **Suppliers** table.  
  
7.  Click the drop-down arrow on the **ProductName** node, and select **ListBox**.  
  
8.  Drag **ProductName** to the actions pane control.  
  
     A <xref:System.Windows.Forms.ListBox> control is created on the actions pane control. At the same time, a <xref:System.Windows.Forms.BindingSource> named `ProductBindingSource` and a table adapter are added to the project in the component tray.  
  
9. Move the list box so that it is under the label and change the **Size** property to **171,95**.  
  
10. Drag a <xref:System.Windows.Forms.Button> from the **Toolbox** onto the actions pane control and place it below the list box.  
  
11. Right-click the <xref:System.Windows.Forms.Button>, click **Properties** on the shortcut menu, and change the following properties.  
  
    |Property|Value|  
    |--------------|-----------|  
    |**Name**|**Insert**|  
    |**Text**|**Insert**|  
  
12. Resize the user control to fit the controls.  
  
## Setting Up the Data Source  
 To set up the data source, add code to the <xref:System.Windows.Forms.UserControl.Load> event of the actions pane control to fill the control with data from the <xref:System.Data.DataTable>, and set the <xref:System.Windows.Forms.Binding.DataSource%2A> and <xref:System.Windows.Forms.BindingSource.DataMember%2A> properties for each control.  
  
#### To load the control with data  
  
1.  In the <xref:System.Windows.Forms.UserControl.Load> event handler of the `ActionsControl` class, add the following code.  
  
     [!code-vb[Trin_VstcoreActionsPaneWord#1](../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ActionsControl.vb#1)]
     [!code-csharp[Trin_VstcoreActionsPaneWord#1](../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ActionsControl.cs#1)]  
  
2.  In C#, you must attach the event handler to the <xref:System.Windows.Forms.UserControl.Load> event. You can place this code in the `ActionsControl` constructor, after the call to `InitializeComponent`. For more information about how to create event handlers, see [How to: Create Event Handlers in Office Projects](../vsto/how-to-create-event-handlers-in-office-projects.md).  
  
     [!code-csharp[Trin_VstcoreActionsPaneWord#33](../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ActionsControl.cs#33)]  
  
#### To set data binding properties of the controls  
  
1.  Select the `CompanyNameComboBox` control.  
  
2.  In the **Properties** window, click the button to the right of the **DataSource** property, and select **suppliersBindingSource**.  
  
3.  Click the button to the right of the **DisplayMember** property, and select **CompanyName**.  
  
4.  Expand the **DataBindings** property, click the button to the right of the **Text** property, and select **None**.  
  
5.  Select the `ProductNameListBox` control.  
  
6.  In the **Properties** window, click the button to the right of the **DataSource** property, and select **productsBindingSource**.  
  
7.  Click the button to the right of the **DisplayMember** property, and select **ProductName**.  
  
8.  Expand the **DataBindings** property, click the button to the right of the **SelectedValue** property, and select **None**.  
  
## Adding a Method to Insert Data into a Table  
 The next task is to read the data from the bound controls and populate a table in your Word document. First, create a procedure for formatting the headings in the table, and then add the `AddData` method to create and format a Word table.  
  
#### To format the table headings  
  
1.  In the `ActionsControl` class, create a method to format the headings of the table.  
  
     [!code-vb[Trin_VstcoreActionsPaneWord#2](../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ActionsControl.vb#2)]
     [!code-csharp[Trin_VstcoreActionsPaneWord#2](../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ActionsControl.cs#2)]  
  
#### To create the table  
  
1.  In the `ActionsControl` class, write a method that will create a table if one does not already exist, and add data from the actions pane to the table.  
  
     [!code-vb[Trin_VstcoreActionsPaneWord#3](../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ActionsControl.vb#3)]
     [!code-csharp[Trin_VstcoreActionsPaneWord#3](../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ActionsControl.cs#3)]  
  
#### To insert text into a Word table  
  
1.  Add the following code to the <xref:System.Windows.Forms.Control.Click> event handler of the **Insert** button.  
  
     [!code-vb[Trin_VstcoreActionsPaneWord#4](../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ActionsControl.vb#4)]
     [!code-csharp[Trin_VstcoreActionsPaneWord#4](../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ActionsControl.cs#4)]  
  
2.  In C#, you must create an event handler for the <xref:System.Windows.Forms.Control.Click> event of the button.  You can place this code in the <xref:System.Windows.Forms.UserControl.Load> event handler of the `ActionsControl` class.  
  
     [!code-csharp[Trin_VstcoreActionsPaneWord#5](../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ActionsControl.cs#5)]  
  
## Showing the Actions Pane  
 The actions pane becomes visible after controls are added to it.  
  
#### To show the actions pane  
  
1.  In **Solution Explorer**, right-click **ThisDocument.vb** or **ThisDocument.cs**, and then click **View Code** on the shortcut menu.  
  
2.  Create a new instance of the control at the top of the `ThisDocument` class so that it looks like the following example.  
  
     [!code-csharp[Trin_VstcoreActionsPaneWord#6](../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ThisDocument.cs#6)]
     [!code-vb[Trin_VstcoreActionsPaneWord#6](../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ThisDocument.vb#6)]  
  
3.  Add code to the <xref:Microsoft.Office.Tools.Word.Document.Startup> event handler of `ThisDocument` so that it looks like the following example.  
  
     [!code-csharp[Trin_VstcoreActionsPaneWord#7](../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ThisDocument.cs#7)]
     [!code-vb[Trin_VstcoreActionsPaneWord#7](../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ThisDocument.vb#7)]  
  
## Testing the Application  
 Now you can test your document to verify that the actions pane appears when the document is opened. Test for the master/detail relationship in the controls on the actions pane, and make sure that data is populated in a Word table when the **Insert** button is clicked.  
  
#### To test your document  
  
1.  Press F5 to run your project.  
  
2.  Confirm that the actions pane is visible.  
  
3.  Select a company in the combo box and verify that the items in the **Products** list box change.  
  
4.  Select a product, click **Insert** on the actions pane, and verify that the product details are added to the table in Word.  
  
5.  Insert additional products from various companies.  
  
## Next Steps  
 This walkthrough shows the basics of binding data to controls on an actions pane in Word. Here are some tasks that might come next:  
  
-   Binding data to controls in Excel. For more information, see [Walkthrough: Binding Data to Controls on an Excel Actions Pane](../vsto/walkthrough-binding-data-to-controls-on-an-excel-actions-pane.md).  
  
-   Deploying the project. For more information, see [Deploying an Office Solution by Using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md).  
  
## See Also  
 [Actions Pane Overview](../vsto/actions-pane-overview.md)   
 [How to: Add an Actions Pane to Word Documents or Excel Workbooks](../vsto/how-to-add-an-actions-pane-to-word-documents-or-excel-workbooks.md)   
 [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md)  
  
  