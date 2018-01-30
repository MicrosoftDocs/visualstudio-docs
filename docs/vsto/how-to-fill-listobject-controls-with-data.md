---
title: "How to: Fill ListObject Controls with Data | Microsoft Docs"
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
  - "disconnecting from data sources"
  - "ListObject control, disconnecting from a data source"
  - "ListObject control, filling with data"
  - "data [Office development in Visual Studio], adding to worksheets"
  - "data binding, ListObject controls"
  - "worksheets, populating with data"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Fill ListObject Controls with Data
  You can use data binding as a way to quickly add data to your document. After binding data to a list object, you can disconnect the list object so it displays the data but is no longer bound to the data source.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
 ![link to video](../vsto/media/playvideo.gif "link to video") For a related video demonstration, see [How Do I: Create a List in Excel that is Connected to a SharePoint List?](http://go.microsoft.com/fwlink/?LinkID=130263).  
  
### To bind data to a ListObject control  
  
1.  Create a <xref:System.Data.DataTable> at the class level.  
  
     [!code-csharp[Trin_VstcoreHostControlsExcel#20](../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet4.cs#20)]
     [!code-vb[Trin_VstcoreHostControlsExcel#20](../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet4.vb#20)]  
  
2.  Add sample columns and data in the `Startup` event handler of the `Sheet1` class (in a document-level project) or `ThisAddIn` class (in an application-level project).  
  
     [!code-csharp[Trin_VstcoreHostControlsExcel#21](../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet4.cs#21)]
     [!code-vb[Trin_VstcoreHostControlsExcel#21](../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet4.vb#21)]  
  
3.  Call the <xref:Microsoft.Office.Tools.Excel.ListObject.SetDataBinding%2A> method and pass in the column names in the order they should appear. The order of the columns in the list object can differ from the order in which they appear in the <xref:System.Data.DataTable>.  
  
     [!code-csharp[Trin_VstcoreHostControlsExcel#22](../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet4.cs#22)]
     [!code-vb[Trin_VstcoreHostControlsExcel#22](../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet4.vb#22)]  
  
### To disconnect the ListObject control from the data source  
  
1.  Call the <xref:Microsoft.Office.Tools.Excel.ListObject.Disconnect%2A> method of `List1`.  
  
     [!code-csharp[Trin_VstcoreHostControlsExcel#23](../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet4.cs#23)]
     [!code-vb[Trin_VstcoreHostControlsExcel#23](../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet4.vb#23)]  
  
## Compiling the Code  
 This code example assumes you have an existing <xref:Microsoft.Office.Tools.Excel.ListObject> named `list1` on the worksheet in which this code appears.  
  
## See Also  
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Controls on Office Documents](../vsto/controls-on-office-documents.md)   
 [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md)   
 [How to: Map ListObject Columns to Data](../vsto/how-to-map-listobject-columns-to-data.md)   
 [Automating Excel by Using Extended Objects](../vsto/automating-excel-by-using-extended-objects.md)   
 [ListObject Control](../vsto/listobject-control.md)   
 [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md)   
 [How to: Populate Worksheets with Data from a Database](../vsto/how-to-populate-worksheets-with-data-from-a-database.md)   
 [How to: Populate Documents with Data from Services](../vsto/how-to-populate-documents-with-data-from-services.md)  
  
  