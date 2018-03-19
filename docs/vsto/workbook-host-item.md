---
title: "Workbook Host Item | Microsoft Docs"
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
  - "Excel workbooks"
  - "Workbook host items"
  - "host items [Office development in Visual Studio], Workbook"
  - "workbooks, Excel"
  - "Workbook host items, events"
  - "workbooks"
  - "Excel [Office development in Visual Studio], workbooks"
  - "workbooks, events"
  - "events [Office development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Workbook Host Item
  The <xref:Microsoft.Office.Tools.Excel.Workbook> host item is a type that extends the <xref:Microsoft.Office.Interop.Excel.Workbook> type from the primary interop assembly for Excel. The <xref:Microsoft.Office.Tools.Excel.Workbook> host item provides all of the same properties, methods, and events as a <xref:Microsoft.Office.Interop.Excel.Workbook> object, but it also provides additional features.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
 In document-level projects, there is a default <xref:Microsoft.Office.Tools.Excel.Workbook> host item that represents the workbook in your project. In VSTO Add-in projects, you can generate <xref:Microsoft.Office.Tools.Excel.Workbook> host items at run time.  
  
## Understanding the Workbook Host Item in Document-Level Projects  
 To access the workbook in your project, use the `ThisWorkbook` class. The `ThisWorkbook` class gives you access to members of the <xref:Microsoft.Office.Tools.Excel.Workbook> host item to perform basic tasks in your customization, such as running code when the workbook is opened or closed. For more information, see [Programming Document-Level Customizations](../vsto/programming-document-level-customizations.md).  
  
 The `ThisWorkbook` class provides a location in which you can start writing code in your project. Because the class provides all of the same properties, methods, and events as the <xref:Microsoft.Office.Interop.Excel.Workbook> object in the primary interop assembly for Excel, you can also use `ThisWorkbook` to access the object model of Excel. For more information, see [Excel Object Model Overview](../vsto/excel-object-model-overview.md).  
  
 Double-click the **ThisWorkbook** project item in **Solution Explorer** to display the workbook designer and to view the properties and events of the workbook in the **Properties** window.  
  
### Limitations of the Workbook Host Item in Document-Level Projects  
 A document-level project can contain only one <xref:Microsoft.Office.Tools.Excel.Workbook> host item (that is, the `ThisWorkbook` class). You cannot add new <xref:Microsoft.Office.Tools.Excel.Workbook> host items to your project at design time, and you cannot create new <xref:Microsoft.Office.Tools.Excel.Workbook> host items at run time from a document-level customization.  
  
 If you create a new Excel workbook at run time, it will be of the type <xref:Microsoft.Office.Interop.Excel.Workbook>. Because it is not a host item, it cannot contain any host controls or Windows Forms controls. For more information about creating workbooks at run time, see [How to: Programmatically Create New Workbooks](../vsto/how-to-programmatically-create-new-workbooks.md).  
  
 The <xref:Microsoft.Office.Tools.Excel.Workbook> host item does not act as a container for host controls. Therefore, you cannot add any visible controls to the workbook, but you can add components, such as a <xref:System.Data.DataSet>, so that the components can be shared by all worksheets. In a document-level project, components available to the workbook can be found on the **Component** tab, **Data** tab, and **All Windows Forms** tab of the **Toolbox**.  
  
> [!NOTE]  
>  The Office development tools in Visual Studio do not support shared workbooks.  
  
## Understanding Workbook Host Items in VSTO Add-in projects  
 In VSTO Add-in projects, you can generate a <xref:Microsoft.Office.Tools.Excel.Workbook> host item at run time for any workbook that is open in Excel. To generate a <xref:Microsoft.Office.Tools.Excel.Workbook> host item, use the GetVstoObject method. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
## See Also  
 [Office Development Samples and Walkthroughs](../vsto/office-development-samples-and-walkthroughs.md)   
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [Worksheet Host Item](../vsto/worksheet-host-item.md)   
 [Automating Excel by Using Extended Objects](../vsto/automating-excel-by-using-extended-objects.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  