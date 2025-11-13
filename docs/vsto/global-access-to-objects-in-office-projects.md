---
title: "Global access to objects in Office projects"
description: Learn how you can use the Globals class to access several different project items at run time from any code in the project.
ms.date: "02/02/2017"
ms.topic: article
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
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Global access to objects in Office projects

  When you create an Office project, Visual Studio automatically generates a class named `Globals` in the project. You can use the `Globals` class to access several different project items at run time from any code in the project.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

## How to use the Globals class
 `Globals` is a static class that keeps references to certain items in your project. By using the `Globals` class, you can access the following items from any code in the project at run time:

- The `ThisWorkbook` and `Sheet`*n* classes in an Excel workbook or template project. You can access these objects by using the `Globals.ThisWorkbook` and `Sheet`*n* properties.

- The `ThisDocument` class in a Word document or template project. You can access this object by using the `Globals.ThisDocument` property.

- The `ThisAddIn` class in a VSTO Add-in project. You can access this object by using the `Globals.ThisAddIn` property.

- All Ribbons in your project that you customized by using the Ribbon Designer. You can access the Ribbons by using the `Globals.Ribbons` property. For more information, see [Access the Ribbon at run time](../vsto/accessing-the-ribbon-at-run-time.md).

- All Outlook form regions in an Outlook VSTO Add-in project. You can access the form regions by using the `Globals.FormRegions` property. For more information, see [Access a form region at run time](../vsto/accessing-a-form-region-at-run-time.md).

- A factory object that enables you to create Ribbon controls, and host items at run time in projects that target the .NET Framework 4 or the .NET Framework 4.5. You can access this object by using the `Globals.Factory` property. This object is an instance of a class that implements one the following interfaces:

  - [Microsoft.Office.Tools.Factory](xref:Microsoft.Office.Tools.Factory)

  - [Microsoft.Office.Tools.Excel.Factory](xref:Microsoft.Office.Tools.Excel.Factory)

  - [Microsoft.Office.Tools.Outlook.Factory](xref:Microsoft.Office.Tools.Outlook.Factory)

  - [Microsoft.Office.Tools.Word.Factory](xref:Microsoft.Office.Tools.Word.Factory)

  For example, you can use the `Globals.Sheet1` property to insert text into a <xref:Microsoft.Office.Tools.Excel.NamedRange> control on `Sheet1` when a user clicks a button on the actions pane in a document-level project for Excel.

  ### [C#](#tab/csharp)
  :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingExcelCS/Sheet1.cs" id="Snippet1":::

  ### [VB](#tab/vb)
  :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreProgrammingExcelVB/Sheet1.vb" id="Snippet1":::
  ---

 Code that attempts to use the `Globals` class before the document or VSTO Add-in is initialized might throw a run time exception. For example, using `Globals` when declaring a class-level variable might fail because the `Globals` class might not be initialized with references to all of the host items before the declared object is instantiated.

> [!NOTE]
> The `Globals` class is never initialized at design time, but control instances are created by the designer. This means that if you create a user control that uses a property of the `Globals` class from inside a user control class, you must check whether the property returns **null** before you try to use the returned object.

## Related content
- [Access the Ribbon at run time](../vsto/accessing-the-ribbon-at-run-time.md)
- [Access a form region at run time](../vsto/accessing-a-form-region-at-run-time.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Document host item](../vsto/document-host-item.md)
- [Workbook host item](../vsto/workbook-host-item.md)
- [Worksheet host item](../vsto/worksheet-host-item.md)
- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)
