---
title: "Add custom XML parts to documents using VSTO Add-ins"
description: Learn how you can store XML data in the following types of documents by creating a custom XML part in a VSTO Add-in.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "add-ins [Office development in Visual Studio], custom XML parts"
  - "Office documents [Office development in Visual Studio, custom XML parts"
  - "Word [Office development in Visual Studio], custom XML parts"
  - "PowerPoint [Office development in Visual Studio], custom XML parts"
  - "Excel [Office development in Visual Studio], custom XML parts"
  - "custom XML parts [Office development in Visual Studio], adding"
  - "documents [Office development in Visual Studio], custom XML parts"
  - "application-level add-ins [Office development in Visual Studio], custom XML parts"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Add custom XML parts to documents by using VSTO Add-ins
  You can store XML data in the following types of documents by creating a custom XML part in a VSTO Add-in:

- A Microsoft Office Excel workbook.

- A Microsoft Office Word document.

- A Microsoft Office PowerPoint presentation.

  For more information, see [Custom XML parts overview](../vsto/custom-xml-parts-overview.md).

  **Applies to:** The information in this topic applies to application-level projects for Excel, PowerPoint, and Word. For more information, see [Features available by Office application and project type](../vsto/features-available-by-office-application-and-project-type.md).

## To add a custom XML part to an Excel workbook

1. Add a new <xref:Microsoft.Office.Core.CustomXMLPart> object to the <xref:Microsoft.Office.Interop.Excel._Workbook.CustomXMLParts%2A> collection in the workbook. The <xref:Microsoft.Office.Core.CustomXMLPart> contains the XML string that you want to store in the workbook.

     The following code example adds a custom XML part to a specified workbook.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_addcustomxmlpartexcelapplevel/ThisAddIn.vb" id="Snippet1":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_AddCustomXmlPartExcelAppLevel/ThisAddIn.cs" id="Snippet1":::

2. Add the `AddCustomXmlPartToWorkbook` method to the `ThisAddIn` class in a VSTO Add-in project for Excel.

3. Call the method from other code in your project. For example, to create the custom XML part when the user opens a workbook, call the method from an event handler for the <xref:Microsoft.Office.Interop.Excel.AppEvents_Event.WorkbookOpen> event.

## To add a custom XML part to a Word document

1. Add a new <xref:Microsoft.Office.Core.CustomXMLPart> object to the <xref:Microsoft.Office.Interop.Word._Document.CustomXMLParts%2A> collection in the document. The <xref:Microsoft.Office.Core.CustomXMLPart> contains the XML string that you want to store in the document.

     The following code example adds a custom XML part to a specified document.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_AddCustomXmlPartWordAppLevel/ThisAddIn.vb" id="Snippet1":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_AddCustomXmlPartWordAppLevel/ThisAddIn.cs" id="Snippet1":::

2. Add the `AddCustomXmlPartToDocument` method to the `ThisAddIn` class in a VSTO Add-in project for Word.

3. Call the method from other code in your project. For example, to create the custom XML part when the user opens a document, call the method from an event handler for the <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentOpen> event.

## To add a custom XML part to a PowerPoint presentation

1. Add a new <xref:Microsoft.Office.Core.CustomXMLPart> object to the [Microsoft.Office.Interop.PowerPoint._Presentation.CustomXMLParts](/previous-versions/office/developer/office-2010/ff760806%28v%3doffice.14%29) collection in the presentation. The <xref:Microsoft.Office.Core.CustomXMLPart> contains the XML string that you want to store in the presentation.

     The following code example adds a custom XML part to a specified presentation.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_AddCustomXmlPartPowerPointAppLevel/ThisAddIn.cs" id="Snippet1":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_AddCustomXmlPartPowerPointAppLevel/ThisAddIn.vb" id="Snippet1":::

2. Add the `AddCustomXmlPartToPresentation` method to the `ThisAddIn` class in a VSTO Add-in project for PowerPoint.

3. Call the method from other code in your project. For example, to create the custom XML part when the user opens a presentation, call the method from an event handler for the [Microsoft.Office.Interop.PowerPoint.EApplication_Event.AfterPresentationOpen](/previous-versions/office/developer/office-2010/ff762843(v=office.14)) event.

## Robust programming
 For simplicity, this example uses an XML string that is defined as a local variable in the method. Typically, you should obtain the XML from an external source, such as a file or a database.

## See also
- [Custom XML parts overview](../vsto/custom-xml-parts-overview.md)
- [How to: Add custom XML parts to document-level customizations](../vsto/how-to-add-custom-xml-parts-to-document-level-customizations.md)
