---
title: "Excel Solutions | Microsoft Docs"
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
  - "application-level add-ins [Office development in Visual Studio], Excel"
  - "Excel [Office development in Visual Studio], application-level add-ins"
  - "Office solutions [Office development in Visual Studio], Excel"
  - "solutions [Office development in Visual Studio], Excel"
  - "add-ins [Office development in Visual Studio], Excel"
  - "Excel [Office development in Visual Studio], about Excel solutions"
  - "Excel [Office development in Visual Studio]"
  - "documents [Office development in Visual Studio], Excel"
  - "Office documents [Office development in Visual Studio, Excel"
  - "projects [Office development in Visual Studio], Excel"
  - "Excel [Office development in Visual Studio], document-level customizations"
  - "user interfaces [Office development in Visual Studio], Excel"
  - "Office development in Visual Studio, Excel solutions"
  - "document-level customizations [Office development in Visual Studio], Excel"
  - "Office projects [Office development in Visual Studio], Excel"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Excel Solutions
  Visual Studio provides project templates you can use to create document-level customizations and VSTO Add-ins for Microsoft Office Excel. You can use these solutions to automate Excel, extend Excel features, and customize the Excel user interface (UI). For more information about the differences between document-level customizations and VSTO Add-ins, see [Office Solutions Development Overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
> [!NOTE]  
>  Interested in developing solutions that extend the Office experience across [multiple platforms](https://dev.office.com/add-in-availability)? Check out the new [Office Add-ins model](https://dev.office.com/docs/add-ins/overview/office-add-ins). Office Add-ins have a small footprint compared to VSTO add-ins and solutions, and you can build them by using almost any web programming technology, such as HTML5, JavaScript, CSS3, and XML.  
  
 This topic provides the following information:  
  
-   [Automating Excel](#automating).  
  
-   [Developing document-level customizations for Excel](#doclevel).  
  
-   [Developing VSTO Add-ins for Excel](#applevel).  
  
-   [Customizing the user interface of Excel](#UI).  
  
##  <a name="automating"></a> Automating Excel  
 The Excel object model exposes many types that you can use to automate Excel. For example, you can programmatically create charts, format worksheets, and set the values of ranges and cells. For more information, see [Excel Object Model Overview](../vsto/excel-object-model-overview.md).  
  
 When developing Excel solutions in Visual Studio, you can also use *host items* and *host controls* in your solutions. These are objects that extend certain commonly used objects in the Excel object model, such as the <xref:Microsoft.Office.Interop.Excel.Worksheet> and <xref:Microsoft.Office.Interop.Excel.Range> objects. The extended objects behave like the Excel objects they are based on, but they add additional events and data binding capabilities to the objects. For more information, see [Automating Excel by Using Extended Objects](../vsto/automating-excel-by-using-extended-objects.md).  
  
##  <a name="doclevel"></a> Developing Document-Level Customizations for Excel  
 A document-level customization for Microsoft Office Excel consists of an assembly that is associated with a specific workbook. The assembly typically extends the workbook by customizing the UI and by automating Excel. Unlike a VSTO Add-in, which is associated with Excel itself, functionality that you implement in a customization is available only when the associated workbook is open in Excel.  
  
 To create a document-level customization project for Excel, use the Excel Workbook or Excel Template project templates in the **New Project** dialog box of Visual Studio. For more information, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).  
  
 For more information about how document-level customizations work, see [Architecture of Document-Level Customizations](../vsto/architecture-of-document-level-customizations.md).  
  
### Excel Customization Programming Model  
 When you create a document-level project for Excel, Visual Studio generates several classes that are the foundation of your solution: `ThisWorkbook`, `Sheet1`, `Sheet2`, and `Sheet3`. These classes represent the workbook and worksheets that are associated with your solution, and they provide a starting point for writing your code.  
  
 For more information about these generated classes and other features you can use in a document-level project, see [Programming Document-Level Customizations](../vsto/programming-document-level-customizations.md).  
  
##  <a name="applevel"></a> Developing VSTO Add-ins for Excel  
 A VSTO Add-in for Microsoft Office Excel consists of an assembly that is loaded by Excel. The assembly typically extends Excel by customizing the UI and by automating Excel. Unlike a document-level customization, which is associated with a specific workbook, functionality that you implement in an VSTO Add-in is not restricted to any single workbook.  
  
 To create a VSTO Add-in project for Excel, use the Excel Workbook or Excel Template project templates in the **New Project** dialog box of Visual Studio. For more information, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).  
  
 For general information about how VSTO Add-ins work, see [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md).  
  
 ![link to video](../vsto/media/playvideo.gif "link to video") For a related video demonstration, see [How Do I: Automate PowerPoint from an Excel Add-in?](http://go.microsoft.com/fwlink/?LinkID=130300).  
  
### Excel Add-in Programming Model  
 When you create an Excel VSTO Add-in project, Visual Studio generates a class, called `ThisAddIn`, which is the foundation of your solution. This class provides a starting point for writing your code, and it also exposes the object model of Excel to your VSTO Add-in.  
  
 For more information about the `ThisAddIn` class and other Visual Studio features you can use in an VSTO Add-in, see [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md).  
  
##  <a name="UI"></a> Customizing the User Interface of Excel  
 There are several different ways to customize the user interface of Excel. Some options are available to all project types, and other options are available only to VSTO Add-ins or document-level customizations.  
  
### Options for All Project Types  
 The following table lists customization options that are available to both document-level customizations and VSTO Add-ins.  
  
|Task|For more information|  
|----------|--------------------------|  
|Customize the Ribbon.|[Ribbon Overview](../vsto/ribbon-overview.md)|  
|Add Windows Forms controls or extended Excel controls to a worksheet in the customized workbook for a document-level customization, or in any open workbook for a VSTO Add-in.|[How to: Add Windows Forms Controls to Office Documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md)<br /><br /> [How to: Add Chart Controls to Worksheets](../vsto/how-to-add-chart-controls-to-worksheets.md)<br /><br /> [How to: Add ListObject Controls to Worksheets](../vsto/how-to-add-listobject-controls-to-worksheets.md)<br /><br /> [How to: Add NamedRange Controls to Worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)|  
  
### Options for Document-Level Customizations  
 The following table lists customization options that are available only to document-level customizations.  
  
|Task|For more information|  
|----------|--------------------------|  
|Add an actions pane to the workbook.|[Actions Pane Overview](../vsto/actions-pane-overview.md)<br /><br /> [How to: Add an Actions Pane to Word Documents or Excel Workbooks](../vsto/how-to-add-an-actions-pane-to-word-documents-or-excel-workbooks.md)|  
|Add extended range controls that are mapped to XML nodes to a worksheet.|[How to: Add XMLMappedRange Controls to Worksheets](../vsto/how-to-add-xmlmappedrange-controls-to-worksheets.md)|  
  
### Options for VSTO Add-ins  
 The following table lists customization options that are available only to VSTO Add-ins.  
  
|Task|For more information|  
|----------|--------------------------|  
|Create a custom task pane.|[Custom Task Panes](../vsto/custom-task-panes.md)|  
  
### Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Excel Object Model Overview](../vsto/excel-object-model-overview.md)|Provides an overview of the main types provided by the Excel object model.|  
|[Automating Excel by Using Extended Objects](../vsto/automating-excel-by-using-extended-objects.md)|Provides information about extended objects (provided by the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)]) that you can use in Excel solutions.|  
|[Globalization and Localization of Excel Solutions](../vsto/globalization-and-localization-of-excel-solutions.md)|Contains information about special considerations for Excel solutions that will be run on computers that have non-English settings for Windows.|  
|[Windows Forms Controls on Office Documents Overview](../vsto/windows-forms-controls-on-office-documents-overview.md)|Describes how you can add Windows Forms controls to Excel worksheets.|  
|[Walkthrough: Creating Your First Document-Level Customization for Excel](../vsto/walkthrough-creating-your-first-document-level-customization-for-excel.md)|Demonstrates how to create a basic document-level customization for Excel.|  
|[Walkthrough: Creating Your First VSTO Add-in for Excel](../vsto/walkthrough-creating-your-first-vsto-add-in-for-excel.md)|Demonstrates how to create a basic VSTO Add-in for Excel.|  
|[Walkthrough: Adding Controls to a Worksheet at Run Time in VSTO add-in Project](../vsto/walkthrough-adding-controls-to-a-worksheet-at-run-time-in-vsto-add-in-project.md)|Demonstrates how to add a Windows Forms button, a <xref:Microsoft.Office.Tools.Excel.NamedRange>, and a <xref:Microsoft.Office.Tools.Excel.ListObject> to a worksheet at run time by using a VSTO Add-in.|
|[Understanding Coauthoring and Add-Ins](./understanding-coauthoring-and-addins.md)|Describes adjustments you might need to make to your solutions to accommodate coauthoring.|  
|[Excel 2010 in Office Development](http://go.microsoft.com/fwlink/?LinkId=199011)|Provides links to articles and reference documentation about developing Excel solutions. These are not specific to Office development using Visual Studio.|  
  
  