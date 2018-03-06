---
title: "Global Access to Objects in Office Projects | Microsoft Docs"
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
  - "ThisDocument_Shutdown"
  - "ThisDocument_Startup"
  - "Globals class, object global access"
  - "worksheets [Office development in Visual Studio], global access"
  - "documents [Office development in Visual Studio], global access"
  - "event handlers [Office development in Visual Studio]"
  - "ThisWorkbook_Startup"
  - "application-level addins [Office development in Visual Studio]"
  - "addins [Office development in Visual Studio], events"
  - "workbooks [Office development in Visual Studio], global access"
  - "ThisWorkbook_Shutdown"
  - "document-level customizations [Office development in Visual Studio]"
  - "Startup event"
  - "Shutdown event"
  - "projects [Office development in Visual Studio], global access"
  - "Office documents [Office development in Visual Studio, global access"
  - "ThisAddin_Startup"
  - "events [Office development in Visual Studio]"
  - "ThisAddIn_Shutdown"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Global Access to Objects in Office Projects
  When you create an Office project, Visual Studio automatically generates a class named `Globals` in the project. You can use the `Globals` class to access several different project items at run time from any code in the project.  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
## How to Use the Globals Class  
 `Globals` is a static class that keeps references to certain items in your project. By using the `Globals` class, you can access the following items from any code in the project at run time:  
  
-   The `ThisWorkbook` and `Sheet`*n* classes in an Excel workbook or template project. You can access these objects by using the `Globals.ThisWorkbook` and `Sheet`*n* properties.  
  
-   The `ThisDocument` class in a Word document or template project. You can access this object by using the `Globals.ThisDocument` property.  
  
-   The `ThisAddIn` class in an VSTO Add-in project. You can access this object by using the `Globals.ThisAddIn` property.  
  
-   All Ribbons in your project that you customized by using the Ribbon Designer. You can access the Ribbons by using the `Globals.Ribbons` property. For more information, see [Accessing the Ribbon at Run Time](../vsto/accessing-the-ribbon-at-run-time.md).  
  
-   All Outlook form regions in an Outlook VSTO Add-in project. You can access the form regions by using the `Globals.FormRegions` property. For more information, see [Accessing a Form Region at Run Time](../vsto/accessing-a-form-region-at-run-time.md).  
  
-   A factory object that enables you to create Ribbon controls, and host items at run time in projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)]. You can access this object by using the `Globals.Factory` property. This object is an instance of a class that implements one the following interfaces:  
  
    -   <xref:Microsoft.Office.Tools.Factory>  
  
    -   <xref:Microsoft.Office.Tools.Excel.Factory>  
  
    -   <xref:Microsoft.Office.Tools.Outlook.Factory>  
  
    -   <xref:Microsoft.Office.Tools.Word.Factory>  
  
 For example, you can use the `Globals.Sheet1` property to insert text into a <xref:Microsoft.Office.Tools.Excel.NamedRange> control on `Sheet1` when a user clicks a button on the actions pane in a document-level project for Excel.  
  
 [!code-vb[Trin_VstcoreProgramming#1](../vsto/codesnippet/VisualBasic/Trin_VstcoreProgrammingExcelVB/Sheet1.vb#1)]
 [!code-csharp[Trin_VstcoreProgramming#1](../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingExcelCS/Sheet1.cs#1)]  
  
## Initializing the Globals Class  
 Code that attempts to use the `Globals` class before the document or VSTO Add-in is completely initialized might throw a run time exception. For example, using `Globals` when declaring a class-level variable might fail because the `Globals` class might not be initialized with references to all of the host items before the declared object is instantiated.  
  
> [!NOTE]  
>  The `Globals` class is never initialized at design time, but control instances are created by the designer. This means that if you create a user control that uses a property of the `Globals` class from inside a user control class, you must whether the property returns **null** before you try to use the returned object.  
  
## See Also  
 [Accessing the Ribbon at Run Time](../vsto/accessing-the-ribbon-at-run-time.md)   
 [Accessing a Form Region at Run Time](../vsto/accessing-a-form-region-at-run-time.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [Document Host Item](../vsto/document-host-item.md)   
 [Workbook Host Item](../vsto/workbook-host-item.md)   
 [Worksheet Host Item](../vsto/worksheet-host-item.md)   
 [Writing Code in Office Solutions](../vsto/writing-code-in-office-solutions.md)  
  
  