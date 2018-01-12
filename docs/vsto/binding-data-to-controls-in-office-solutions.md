---
title: "Binding Data to Controls in Office Solutions | Microsoft Docs"
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
  - "Office documents [Office development in Visual Studio], connecting to data"
  - "data, data binding"
  - "data binding"
  - "data binding, Office solutions"
  - "data binding, controls"
  - "Office applications [Office development in Visual Studio], data binding"
  - "controls, data binding"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Binding Data to Controls in Office Solutions
  You can bind Windows Forms controls and *host controls* on a Microsoft Office Word document or Microsoft Office Excel worksheet to a data source so the controls automatically display the data. You can bind data to controls in both application-level and document-level projects.  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
 Host controls extend objects that are in the Word and Excel object models, such as content controls in Word and named ranges in Excel. For more information, see [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md).  
  
 Both Windows Forms and host controls use the Windows Forms data binding model, which supports both *simple data binding* and *complex data binding* to data sources such as datasets and data tables. For complete information about the data binding model in Windows Forms, see [Data Binding and Windows Forms](/dotnet/framework/winforms/data-binding-and-windows-forms).  
  
 ![link to video](../vsto/media/playvideo.gif "link to video") For a related video demonstration, see [How Do I: Consume Database Data in Excel?](http://go.microsoft.com/fwlink/?LinkID=130287).  
  
## Simple Data Binding  
 Simple data binding exists when a control property is bound to a single data element, such as a value in a data table. For example, the <xref:Microsoft.Office.Tools.Excel.NamedRange> control has a <xref:Microsoft.Office.Tools.Excel.NamedRange.Value2%2A> property that can be bound to a field in a dataset. When the field in the dataset changes, the value in the named range also changes. All host controls, except for the <xref:Microsoft.Office.Tools.Word.XMLNodes> control, support simple data binding. The <xref:Microsoft.Office.Tools.Word.XMLNodes> control is a collection, and therefore it does not support data binding.  
  
 To perform simple data binding to a host control, add a <xref:System.Windows.Forms.Binding> to the DataBindings property of the control. A <xref:System.Windows.Forms.Binding> object represents the simple binding between a property value of the control and the value of a data element.  
  
 The following example demonstrates how to bind the <xref:Microsoft.Office.Tools.Excel.NamedRange.Value2%2A> property to a data element in a document-level project.  
  
 [!code-vb[Trin_BindableComponent#4](../vsto/codesnippet/VisualBasic/Trin_BindableComponent/Sheet1.vb#4)]
 [!code-csharp[Trin_BindableComponent#4](../vsto/codesnippet/CSharp/Trin_BindableComponent/Sheet1.cs#4)]  
  
 For walkthroughs that demonstrates simple data binding, see [Walkthrough: Simple Data Binding in a Document-Level Project](../vsto/walkthrough-simple-data-binding-in-a-document-level-project.md) for a document-level project and [Walkthrough: Simple Data Binding in VSTO add-in Project](../vsto/walkthrough-simple-data-binding-in-vsto-add-in-project.md) for an VSTO Add-in project.  
  
## Complex Data Binding  
 Complex data binding exists when a control property is bound to more than one data element, such as multiple columns in a data table. The <xref:Microsoft.Office.Tools.Excel.ListObject> control for Excel is the only host control that supports complex data binding. There are also many Windows Forms controls that support complex data binding, such as the <xref:System.Windows.Forms.DataGridView> control.  
  
 To perform complex data binding, set the DataSource property of the control to a data source object that is supported by complex data binding. For example, the <xref:Microsoft.Office.Tools.Excel.ListObject.DataSource%2A> property of the <xref:Microsoft.Office.Tools.Excel.ListObject> control can be bound to multiple columns in a data table. All of the data in the data table appears in the <xref:Microsoft.Office.Tools.Excel.ListObject> control, and as the data in the data table changes, the <xref:Microsoft.Office.Tools.Excel.ListObject> also changes. For a list of the data sources that you can use for complex data binding, see [Data Sources Supported by Windows Forms](/dotnet/framework/winforms/data-sources-supported-by-windows-forms).  
  
 The following code example creates a <xref:System.Data.DataSet> with two <xref:System.Data.DataTable> objects and populates one of the tables with data. The code then binds the <xref:Microsoft.Office.Tools.Excel.ListObject> to the table that contains data. This example is for an Excel document-level project.  
  
 [!code-csharp[Trin_ExcelListObject#18](../vsto/codesnippet/CSharp/Trin_ExcelListObject/Trin_ExcelListObject.cs#18)]
 [!code-vb[Trin_ExcelListObject#18](../vsto/codesnippet/VisualBasic/Trin_ExcelListObject/Sheet1.vb#18)]  
  
 For walkthroughs that demonstrate complex data binding, see [Walkthrough: Complex Data Binding in a Document-Level Project](../vsto/walkthrough-complex-data-binding-in-a-document-level-project.md) for a document-level project and [Walkthrough: Complex Data Binding in VSTO add-in Project](../vsto/walkthrough-complex-data-binding-in-vsto-add-in-project.md) for an VSTO Add-in project.  
  
## Displaying Data in Documents and Workbooks  
 In document-level projects, you can use the **Data Sources** window to add data-bound controls to your documents or workbooks easily, the same way you use it for Windows Forms. For more information about using the **Data Sources** window, see [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md) and [Add new data sources](../data-tools/add-new-data-sources.md).  
  
### Dragging Controls from the Data Sources Window  
 A control is created on the document when you drag an object onto it from the **Data Sources** window. The type of control that is created depends on whether you are binding a single column of data or multiple columns of data.  
  
 For Excel, a <xref:Microsoft.Office.Tools.Excel.NamedRange> control is created on the worksheet for each individual field, and a <xref:Microsoft.Office.Tools.Excel.ListObject> control is created for each data range that includes multiple rows and columns. You can change this default by selecting the table or field in the **Data Sources** window and then choosing a different control from the drop-down list.  
  
 A <xref:Microsoft.Office.Tools.Word.ContentControl> control is added to documents. The type of content control depends on the data type of the field that you selected.  
  
### Binding Data in Document-Level Projects at Design Time  
 The following topics show examples of binding data at design time:  
  
-   [How to: Populate Worksheets with Data from a Database](../vsto/how-to-populate-worksheets-with-data-from-a-database.md)  
  
-   [How to: Populate Documents with Data from a Database](../vsto/how-to-populate-documents-with-data-from-a-database.md)  
  
-   [How to: Populate Documents with Data from Objects](../vsto/how-to-populate-documents-with-data-from-objects.md)  
  
-   [How to: Populate Documents with Data from Services](../vsto/how-to-populate-documents-with-data-from-services.md)  
  
-   [How to: Scroll Through Database Records in a Worksheet](../vsto/how-to-scroll-through-database-records-in-a-worksheet.md)  
  
### Binding Data in VSTO Add-in projects  
 In VSTO Add-in projects, you can add controls only at run time. The following topics show examples of binding data at run time:  
  
-   [Walkthrough: Simple Data Binding in VSTO add-in Project](../vsto/walkthrough-simple-data-binding-in-vsto-add-in-project.md)  
  
-   [Walkthrough: Complex Data Binding in VSTO add-in Project](../vsto/walkthrough-complex-data-binding-in-vsto-add-in-project.md)  
  
## Updating Data That Is Bound to Host Controls  
 Data binding between a data source and a host control involves a two-way data update. In simple data binding, changes in the data source are reflected automatically in the host control, but changes in the host control require an explicit call to update the data source. The reason is that in some cases, changes in one data-bound field are not accepted unless they are accompanied by changes in another data-bound field. For example, you might have two fields, one for age and one for years of experience. Experience cannot exceed age. A user cannot update the age from 50 to 25 and then the experience from 30 to 10 unless he or she makes the changes at the same time. To solve this problem, fields with simple data binding are not updated until the updates are explicitly sent by code.  
  
 To update a data source from host controls that enable simple data binding, you must send updates to the in-memory data source (such as a <xref:System.Data.DataSet> or <xref:System.Data.DataTable>) and to the back-end database, if your solution uses one.  
  
 You do not need to explicitly update the in-memory data source when you perform complex data binding using the <xref:Microsoft.Office.Tools.Excel.ListObject> control. In that case, changes are automatically sent to the in-memory data source without additional code.  
  
 For more information, see [How to: Update a Data Source with Data from a Host Control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md).  
  
## See Also  
 [How Do I: Consume Database Data in Excel?](http://go.microsoft.com/fwlink/?LinkID=130287)   
 [Data Binding and Windows Forms](/dotnet/framework/winforms/data-binding-and-windows-forms)   
 [How to: Create a Simple-Bound Control on a Windows Form](/dotnet/framework/winforms/how-to-create-a-simple-bound-control-on-a-windows-form)   
 [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [Save data back to the database](../data-tools/save-data-back-to-the-database.md)    
 [Update data by using a TableAdapter](../data-tools/update-data-by-using-a-tableadapter.md)    
 [Caching Data](../vsto/caching-data.md)   
 [Data in Office Solutions](../vsto/data-in-office-solutions.md)  
  
  