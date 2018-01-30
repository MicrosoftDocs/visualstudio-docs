---
title: "How to: Update a Data Source with Data from a Host Control | Microsoft Docs"
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
  - "documents [Office development in Visual Studio], data source updates"
  - "data [Office development in Visual Studio], updating a data source from a document"
  - "host controls [Office development in Visual Studio], data source updates"
  - "Office documents [Office development in Visual Studio, data sources"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Update a Data Source with Data from a Host Control
  You can bind a host control to a data source and update the data source with the changes that are made to the data in the control. There are two main steps in this process:  
  
1.  Update the in-memory data source with the modified data in the control. Typically, the in-memory data source is a <xref:System.Data.DataSet>, a <xref:System.Data.DataTable>, or some other data object.  
  
2.  Update the database with the changed data in the in-memory data source. This is applicable only if the data source is connected to a back-end database, such as a SQL Server or Microsoft Office Access database.  
  
 For more information about host controls and data binding, see [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md) and [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md).  
  
 [!INCLUDE[appliesto_controls](../vsto/includes/appliesto-controls-md.md)]  
  
## Updating the In-Memory Data Source  
 By default, host controls that enable simple data binding (such as content controls on a Word document or a named range control on an Excel worksheet) do not save data changes to the in-memory data source. That is, when an end user changes a value in a host control and then navigates away from the control, the new value in the control is not automatically saved to the data source.  
  
 To save the data to the data source, you can write code that updates the data source in response to a specific event at run time, or you can configure the control to automatically update the data source when the value in the control changes.  
  
 You do not need to save <xref:Microsoft.Office.Tools.Excel.ListObject> changes to the in-memory data source. When you bind a <xref:Microsoft.Office.Tools.Excel.ListObject> control to data, the <xref:Microsoft.Office.Tools.Excel.ListObject> control automatically saves changes to the in-memory data source without requiring additional code.  
  
#### To update the in-memory data source at run time  
  
-   Call the <xref:System.Windows.Forms.Binding.WriteValue%2A> method of the <xref:System.Windows.Forms.Binding> object that binds the control to the data source.  
  
     The following example saves changes made to a <xref:Microsoft.Office.Tools.Excel.NamedRange> control on an Excel worksheet to the data source. This example assumes that you have a <xref:Microsoft.Office.Tools.Excel.NamedRange> control named `namedRange1` with its <xref:Microsoft.Office.Tools.Excel.NamedRange.Value2%2A> property bound to a field in a data source.  
  
     [!code-csharp[Trin_VstcoreDataExcel#1](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs#1)]
     [!code-vb[Trin_VstcoreDataExcel#1](../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb#1)]  
  
### Automatically Updating the In-Memory Data Source  
 You can also configure a control so that it automatically updates the in-memory data source. In a document-level project, you can do this by using code or the designer. In an VSTO Add-in project, you must use code.  
  
##### To set a control to automatically update the in-memory data source by using code  
  
1.  Use the System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged mode of the <xref:System.Windows.Forms.Binding> object that binds the control to the data source. There are two options for updating the data source:  
  
    -   To update the data source when the control is validated, set this property to System.Windows.Forms.DataSourceUpdateMode.OnValidation.  
  
    -   To update the data source when the value of the data-bound property of the control changes, set this property to System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged.  
  
        > [!NOTE]  
        >  The System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged option does not apply to Word host controls, because Word does not offer document-change or control-change notifications. However, this option can be used for Windows Forms controls on Word documents.  
  
     The following example configures a <xref:Microsoft.Office.Tools.Excel.NamedRange> control to automatically update the data source when the value in the control changes. This example assumes that you have a <xref:Microsoft.Office.Tools.Excel.NamedRange> control named `namedRange1` with its <xref:Microsoft.Office.Tools.Excel.NamedRange.Value2%2A> property bound to a field in a data source.  
  
     [!code-csharp[Trin_VstcoreDataExcel#19](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs#19)]
     [!code-vb[Trin_VstcoreDataExcel#19](../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb#19)]  
  
##### To set a control to automatically update the in-memory data source by using the designer  
  
1.  In Visual Studio, open the Word document or Excel workbook in the designer.  
  
2.  Click the control that you want to automatically update the data source.  
  
3.  In the **Properties** window, expand the **(DataBindings)** property.  
  
4.  Next to the **(Advanced)** property, click the ellipsis button (![VisualStudioEllipsesButton screenshot](../vsto/media/vbellipsesbutton.png "VisualStudioEllipsesButton screenshot")).  
  
5.  In the **Formatting and Advanced Binding** dialog box, click the **Data Source Update Mode** drop-down list and select one of the following values:  
  
    -   To update the data source when the control is validated, select **OnValidation**.  
  
    -   To update the data source when the value of the data-bound property of the control changes, select **OnPropertyChanged**.  
  
        > [!NOTE]  
        >  The **OnPropertyChanged** option does not apply to Word host controls, because Word does not offer document-change or control-change notifications. However, this option can be used for Windows Forms controls on Word documents.  
  
6.  Close the **Formatting and Advanced Binding** dialog box.  
  
## Updating the Database  
 If the in-memory data source is associated with a database, you must update the database with the changes to the data source. For more information about updating a database, see [Save data back to the database](../data-tools/save-data-back-to-the-database.md)  and [Update data by using a TableAdapter](../data-tools/update-data-by-using-a-tableadapter.md) .  
  
#### To update the database  
  
1.  Call the <xref:System.Windows.Forms.BindingSource.EndEdit%2A> method of the <xref:System.Windows.Forms.BindingSource> for the control.  
  
     The <xref:System.Windows.Forms.BindingSource> is automatically generated when you add a data-bound control to a document or workbook at design time. The <xref:System.Windows.Forms.BindingSource> connects the control to the typed dataset in your project. For more information, see [BindingSource Component Overview](/dotnet/framework/winforms/controls/bindingsource-component-overview).  
  
     The following code example assumes that your project contains a <xref:System.Windows.Forms.BindingSource> named `customersBindingSource`.  
  
     [!code-csharp[Trin_VstcoreDataExcel#20](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs#20)]
     [!code-vb[Trin_VstcoreDataExcel#20](../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb#20)]  
  
2.  Call the `Update` method of the generated TableAdapter in your project.  
  
     The TableAdapter is automatically generated when you add a data-bound control to a document or workbook at design time. The TableAdapter connects the typed dataset in your project to the database. For more information, see [TableAdapter Overview](../data-tools/fill-datasets-by-using-tableadapters.md#tableadapter-overview).  
  
     The following code example assumes that you have a connection to the Customers table in the Northwind database, and that your project contains a TableAdapter named `customersTableAdapter` and a typed dataset named `northwindDataSet`.  
  
     [!code-csharp[Trin_VstcoreDataExcel#21](../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs#21)]
     [!code-vb[Trin_VstcoreDataExcel#21](../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb#21)]  
  
## See Also  
 [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md)   
 [Save data back to the database](../data-tools/save-data-back-to-the-database.md)    
 [Update data by using a TableAdapter](../data-tools/update-data-by-using-a-tableadapter.md)    
 [How to: Scroll Through Database Records in a Worksheet](../vsto/how-to-scroll-through-database-records-in-a-worksheet.md)   
 [How to: Populate Worksheets with Data from a Database](../vsto/how-to-populate-worksheets-with-data-from-a-database.md)   
 [How to: Populate Documents with Data from Objects](../vsto/how-to-populate-documents-with-data-from-objects.md)   
 [How to: Populate Documents with Data from a Database](../vsto/how-to-populate-documents-with-data-from-a-database.md)   
 [How to: Populate Documents with Data from Services](../vsto/how-to-populate-documents-with-data-from-services.md)  
  
  