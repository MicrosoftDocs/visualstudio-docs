---
title: "How to: Scroll Through Database Records in a Worksheet | Microsoft Docs"
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
  - "databases [Office development in Visual Studio], scrolling records"
  - "records [Office development in Visual Studio], scrolling"
  - "data [Office development in Visual Studio], scrolling database records"
  - "worksheets [Office development in Visual Studio], scrolling records"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Scroll Through Database Records in a Worksheet
  The following procedure shows how to use the designer to display a single field from a database table in a Microsoft Office Excel worksheet, with controls that enable the end user to scroll through all the records.  
  
 You can use the designer only in document-level projects. However, you can also add controls and bind them to data programmatically at run time. For more information, see [Walkthrough: Simple Data Binding in VSTO add-in Project](../vsto/walkthrough-simple-data-binding-in-vsto-add-in-project.md).  
  
 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]  
  
### To scroll through database records in a worksheet  
  
1.  Open an Excel application project in Visual Studio.  
  
2.  Open the **Data Sources** window and create a data source from the database. For more information, see [Add new connections](../data-tools/add-new-connections.md).  
  
3.  Expand the table that contains the data that you want to show, and select the specific column.  
  
4.  Open the list of controls and select **NamedRange**.  
  
5.  Drag the <xref:Microsoft.Office.Tools.Excel.NamedRange> control onto the cell where you want the data to appear.  
  
6.  From the **Windows Forms** tab of the **Toolbox**, add a <xref:System.Windows.Forms.BindingNavigator> control to your worksheet, and set up the controls you want to use. For more information, see [BindingNavigator Control Overview &#40;Windows Forms&#41;](/dotnet/framework/winforms/controls/bindingnavigator-control-overview-windows-forms).  
  
## See Also  
 [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md)  
  
  