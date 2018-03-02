---
title: "How to: Populate Worksheets with Data from a Database | Microsoft Docs"
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
  - "worksheets [Office development in Visual Studio], populating"
  - "databases [Office development in Visual Studio], populating worksheets"
  - "data [Office development in Visual Studio], adding to worksheets"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Populate Worksheets with Data from a Database
  You can access data in document-level Office projects in the same way that you access data in Windows Forms projects. You use the same tools and code to bring the data into your solution, and you can even use Windows Forms controls to display the data. In addition, you can take advantage of controls called host controls, which are native objects in Microsoft Office Excel that have been enhanced with events and data-binding capability. For more information, see [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md).  
  
 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]  
  
 The following example shows how to add data-bound controls in document-level projects using a designer. For an example of how to add data-bound controls in application-level projects at run time, see [Walkthrough: Complex Data Binding in VSTO add-in Project](../vsto/walkthrough-complex-data-binding-in-vsto-add-in-project.md).  
  
 ![link to video](../vsto/media/playvideo.gif "link to video") For a related video demonstration, see [How Do I: Transfer Data Into an Excel Worksheet?](http://go.microsoft.com/fwlink/?LinkID=130277), and [How Do I: Consume Database Data in Excel?](http://go.microsoft.com/fwlink/?LinkID=130287).  
  
## Adding a Data-Bound Control to a Worksheet at Design Time  
  
#### To populate a worksheet with data from a database  
  
1.  Open an Excel document-level project in Visual Studio, with the worksheet open in the designer.  
  
2.  Open the **Data Sources** window and create a data source for your project. For more information, see [Add new connections](../data-tools/add-new-connections.md).  
  
3.  Drag the field or table you want from the **Data Sources** window to your worksheet.  
  
 One of the following controls is created on the worksheet:  
  
-   If you drag a field, a <xref:Microsoft.Office.Tools.Excel.NamedRange> control is created on the worksheet. For more information, see [NamedRange Control](../vsto/namedrange-control.md).  
  
-   If you drag a table, a <xref:Microsoft.Office.Tools.Excel.ListObject> control is created on the worksheet. For more information, see [ListObject Control](../vsto/listobject-control.md).  
  
 You can add a different control by selecting the table or field in the **Data Sources** window and then choosing a different control from the drop-down list.  
  
## Objects in the Project  
 In addition to the control, the following data-related objects are automatically added to your project:  
  
-   A typed dataset that encapsulates the data tables that you connected to in the database. For more information, see [Dataset tools in Visual Studio](/visualstudio/data-tools/dataset-tools-in-visual-studio).  
  
-   A <xref:System.Windows.Forms.BindingSource> that connects the control to the typed dataset. For more information, see [BindingSource Component Overview](/dotnet/framework/winforms/controls/bindingsource-component-overview).  
  
-   A TableAdapter that connects the typed dataset to the database. For more information, see [TableAdapter Overview](../data-tools/fill-datasets-by-using-tableadapters.md#tableadapter-overview).  
  
-   A TableAdapterManager, which is used to coordinate table adapters in the dataset to enable hierarchical updates. For more information, see [Hierarchical Update](../data-tools/hierarchical-update.md) and [TableAdapterManager Reference](../data-tools/fill-datasets-by-using-tableadapters.md#tableadaptermanager-reference).  
  
 When you run the project, the control displays the first record in the data source. You can use the <xref:System.Windows.Forms.BindingSource> to enable users to scroll through the records.  
  
#### To scroll through the records  
  
-   Use <xref:System.Windows.Forms.BindingSource> methods such as <xref:System.Windows.Forms.BindingSource.MoveNext%2A> and <xref:System.Windows.Forms.BindingSource.MovePrevious%2A>.  
  
 For information about how to send updates to the typed dataset and the database, see [How to: Update a Data Source with Data from a Host Control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md).  
  
## See Also  
 [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md)   
 [Add new data sources](/visualstudio/data-tools/add-new-data-sources)   
 [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [How to: Populate Documents with Data from Objects](../vsto/how-to-populate-documents-with-data-from-objects.md)   
 [How to: Populate Documents with Data from a Database](../vsto/how-to-populate-documents-with-data-from-a-database.md)   
 [How to: Populate Documents with Data from Services](../vsto/how-to-populate-documents-with-data-from-services.md)   
 [How to: Update a Data Source with Data from a Host Control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md)   
 [How Do I: Transfer Data Into an Excel Worksheet](http://go.microsoft.com/fwlink/?LinkID=130277)   
 [How Do I: Consume Database Data in Excel?](http://go.microsoft.com/fwlink/?LinkID=130287)  
  
  