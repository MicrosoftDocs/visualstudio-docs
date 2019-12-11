---
title: "How to: Add custom XML parts to document-level customizations"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "document-level customizations [Office development in Visual Studio], custom XML parts"
  - "Office documents [Office development in Visual Studio, custom XML parts"
  - "Word [Office development in Visual Studio], custom XML parts"
  - "Excel [Office development in Visual Studio], custom XML parts"
  - "custom XML parts [Office development in Visual Studio], adding"
  - "documents [Office development in Visual Studio], custom XML parts"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Add custom XML parts to document-level customizations
  You can store XML data in a Microsoft Office Excel workbook or Microsoft Office Word document by creating a custom XML part in a document-level customization. For more information, see [Custom XML parts overview](../vsto/custom-xml-parts-overview.md).

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

> [!NOTE]
> Visual Studio does not provide document-level projects for Microsoft Office PowerPoint. For information about adding a custom XML part to a PowerPoint presentation by using a VSTO Add-in, see [How to: Add custom XML parts to documents by using VSTO Add-ins](../vsto/how-to-add-custom-xml-parts-to-documents-by-using-vsto-add-ins.md).

### To add a custom XML part to an Excel workbook

1. Add a new <xref:Microsoft.Office.Core.CustomXMLPart> object to the <xref:Microsoft.Office.Core.CustomXMLParts> collection in the workbook. The <xref:Microsoft.Office.Core.CustomXMLPart> contains the XML string that you want to store in the workbook.

     [!code-csharp[Trin_AddCustomXmlPartExcelDocLevel#1](../vsto/codesnippet/CSharp/Trin_AddCustomXmlPartExcelDocLevel/ThisWorkbook.cs#1)]
     [!code-vb[Trin_AddCustomXmlPartExcelDocLevel#1](../vsto/codesnippet/VisualBasic/Trin_AddCustomXmlPartExcelDocLevel/ThisWorkbook.vb#1)]

2. Add the `AddCustomXmlPartToWorkbook` method to the `ThisWorkbook` class in a document-level project for Excel.

3. Call the method from other code in your project. For example, to create the custom XML part when the user opens the workbook, call the method from the `ThisWorkbook_Startup` event handler.

### To add a custom XML part to a Word document

1. Add a new <xref:Microsoft.Office.Core.CustomXMLPart> object to the <xref:Microsoft.Office.Core.CustomXMLParts> collection in the document. The <xref:Microsoft.Office.Core.CustomXMLPart> contains the XML string that you want to store in the document.

     [!code-vb[Trin_AddCustomXmlPartWordDocLevel#1](../vsto/codesnippet/VisualBasic/Trin_AddCustomXmlPartWordDocLevel/ThisDocument.vb#1)]
     [!code-csharp[Trin_AddCustomXmlPartWordDocLevel#1](../vsto/codesnippet/CSharp/Trin_AddCustomXmlPartWordDocLevel/ThisDocument.cs#1)]

2. Add the `AddCustomXmlPartToDocument` method to the `ThisDocument` class in a document-level project for Word.

3. Call the method from other code in your project. For example, to create the custom XML part when the user opens the document, call the method from the `ThisDocument_Startup` event handler.

## Robust programming
 For simplicity, this example uses an XML string that is defined as a local variable in the method. Typically, you should obtain the XML from an external source, such as a file or a database.

## See also
- [Custom XML parts overview](../vsto/custom-xml-parts-overview.md)
- [How to: Add custom XML parts to documents by using VSTO Add-ins](../vsto/how-to-add-custom-xml-parts-to-documents-by-using-vsto-add-ins.md)
