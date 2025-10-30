---
title: "Custom XML parts overview"
description: Embed XML data in documents for some Microsoft Office applications to support creating and modifying the data as custom XML parts.
ms.date: "02/02/2017"
ms.topic: concept-article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "custom XML parts [Office development in Visual Studio], about"
  - "Office Open XML Formats [Office development in Visual Studio]"
  - "custom XML parts [Office development in Visual Studio]"
  - "embedding XML data in documents [Office development in Visual Studio]"
  - "XML parts [Office development in Visual Studio]"
  - "XML file formats [Office development in Visual Studio]"
  - "data [Office development in Visual Studio], custom XML parts"
  - "Office documents [Office development in Visual Studio, custom XML parts"
  - "XML [Office development in Visual Studio], custom XML parts"
  - "Word [Office development in Visual Studio], custom XML parts"
  - "Excel [Office development in Visual Studio], custom XML parts"
  - "documents [Office development in Visual Studio], custom XML parts"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Custom XML parts overview

  You can embed XML data in documents for some Microsoft Office applications. When you embed XML data in a document, the data is named a *custom XML part*.

 You can create and modify custom XML parts in a document by using a VSTO Add-in or document-level solution in Visual Studio. You do not need to start the Microsoft Office application to create and modify custom XML parts.

 **Applies to:** The information in this topic applies to document-level projects and VSTO Add-in projects for Excel, PowerPoint, and Word. For more information, see [Features available by Office application and project type](../vsto/features-available-by-office-application-and-project-type.md).

> [!NOTE]
> Visual Studio also enables you to cache data objects in document-level customizations. This feature is different from custom XML parts, although there are some similarities. For more information, see [Cached data in document-level customizations](../vsto/cached-data-in-document-level-customizations.md).

## Understand custom XML parts
 Custom XML parts were introduced in the 2007 Microsoft Office system, along with the Open XML Formats. These formats include new XML-based file formats for Excel, PowerPoint, and Word (such as *.xlsx*, *.pptx*, and *.docx*). Documents in these formats consist of XML files (also named *XML parts*) that are organized in folders in a ZIP archive. Most of the XML parts are built-in parts that help to define the structure and the state of the document. However, documents can also contain custom XML parts, which you can use to store arbitrary XML data in the documents.

 The XML file formats enable applications to work with documents in ways that are not possible with the older binary file formats (such as *.xls*, *.ppt*, and *.doc*). Any application that can read ZIP archives can examine and modify the contents of the documents, even if Microsoft Office is not installed.

 For more information about the structure of Open XML and custom XML parts, see the following articles:

- [Introducing the Office (2007) Open XML file formats](/previous-versions/office/developer/office-2007/aa338205(v=office.12))

- [How to: Manipulate Open XML formats documents](/previous-versions/office/developer/office-2007/aa982683(v=office.12))

- [Walkthrough: Word 2007 XML format](/previous-versions/office/developer/office-2007/bb266220(v=office.12))

- [Build Word 2007 documents using Open XML formats](/previous-versions/office/developer/office-2007/bb264572(v=office.12))

> [!NOTE]
> Excel, Word, and PowerPoint also enable you to use custom XML parts in documents that are saved in the binary file formats. However, if a document is saved in a binary format, you cannot add or modify custom XML parts without starting the Microsoft Office application.

## Create and modify custom XML parts
 You can create or modify custom XML parts when the document is open in the Office application, or when the document is closed—even if Microsoft Office is not installed.

### Modify XML parts while the Office application is running
 You can work with custom XML parts by using a document-level customization or a VSTO Add-in. If you are using a document-level customization, you will typically work with custom XML parts that are in the customized document. If you are using a VSTO Add-in, you can create or modify custom XML parts in any document that is open in the application.

 To create a custom XML part by using Visual Studio, add a new <xref:Microsoft.Office.Core.CustomXMLPart> to the <xref:Microsoft.Office.Core.CustomXMLParts> collection in the document. For more information, see the following topics:

- [How to: Add custom XML parts to document-level customizations](../vsto/how-to-add-custom-xml-parts-to-document-level-customizations.md)

- [How to: Add custom XML parts to documents by using VSTO Add-ins](../vsto/how-to-add-custom-xml-parts-to-documents-by-using-vsto-add-ins.md)

### Modify XML parts without starting the Office application
 You can add or modify a custom XML part without starting Excel, PowerPoint, or Word. This is useful if you want to work with XML data in a document on a computer that does not have Microsoft Office applications installed, such as a server.

 To add a custom XML part without starting Microsoft Office, use classes in the Open XML SDK. These classes are designed to provide access to Open XML content that is specific to Office documents. For example, to add a custom XML part to an Excel workbook, you use the <xref:DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer.AddNewPart%2A> method of a <xref:DocumentFormat.OpenXml.Packaging.WorkbookPart> object. For more information, see [Open XML SDK](/office/open-xml/open-xml-sdk).

## Bind custom XML parts to Word content controls
 You can bind content controls in a Word solution to elements in a custom XML part. When a content control is bound to a custom XML part, the data in the custom XML part is displayed in the user interface (UI) of the content control. If a user edits text in the control, the corresponding XML element is automatically updated. Similarly, if element values in the custom XML parts are changed, the content controls that are bound to the XML elements display the new data. For more information, see [Content controls](../vsto/content-controls.md).

## Related content
- [XML schemas and data in document-level customizations](../vsto/xml-schemas-and-data-in-document-level-customizations.md)
- [How to: Add custom XML parts to document-level customizations](../vsto/how-to-add-custom-xml-parts-to-document-level-customizations.md)
- [How to: Add custom XML parts to documents by using VSTO Add-ins](../vsto/how-to-add-custom-xml-parts-to-documents-by-using-vsto-add-ins.md)
- [Content controls](../vsto/content-controls.md)
- [Walkthrough: Bind content controls to custom XML parts](../vsto/walkthrough-binding-content-controls-to-custom-xml-parts.md)
