---
title: "Custom XML Parts Overview | Microsoft Docs"
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
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Custom XML Parts Overview
  You can embed XML data in documents for some Microsoft Office applications. When you embed XML data in a document, the data is named a *custom XML part*.  
  
 You can create and modify custom XML parts in a document by using a VSTO Add-in or document-level solution in Visual Studio. You do not need to start the Microsoft Office application to create and modify custom XML parts.  
  
 **Applies to:** The information in this topic applies to document-level projects and VSTO Add-in projects for Excel, PowerPoint, and Word. For more information, see [Features Available by Office Application and Project Type](../vsto/features-available-by-office-application-and-project-type.md).  
  
> [!NOTE]  
>  Visual Studio also enables you to cache data objects in document-level customizations. This feature is different from custom XML parts, although there are some similarities. For more information, see [Cached Data in Document-Level Customizations](../vsto/cached-data-in-document-level-customizations.md).  
  
## Understanding Custom XML Parts  
 Custom XML parts were introduced in the 2007 Microsoft Office system, along with the Open XML Formats. These formats include new XML-based file formats for Excel, PowerPoint, and Word (such as .xlsx, .pptx, and .docx). Documents in these formats consist of XML files (also named *XML parts*) that are organized in folders in a ZIP archive. Most of the XML parts are built-in parts that help to define the structure and the state of the document. However, documents can also contain custom XML parts, which you can use to store arbitrary XML data in the documents.  
  
 The XML file formats enable applications to work with documents in ways that are not possible with the older binary file formats (such as .xls, .ppt, and .doc). Any application that can read ZIP archives can examine and modify the contents of the documents, even if Microsoft Office is not installed.  
  
 For more information about the structure of Open XML and custom XML parts, see the following articles:  
  
-   [Introducing the Office (2007) Open XML File Formats](http://msdn.microsoft.com/en-us/96018532-f62c-4da7-bbff-16b96a483fbf)  
  
-   [How to: Manipulate Open XML Formats Documents](http://msdn.microsoft.com/en-us/c989d4e2-053d-4e1f-83be-257c608b343f)  
  
-   [Walkthrough: Word 2007 XML Format](http://msdn.microsoft.com/en-us/fc1afcb2-27fb-4608-9f29-11b7bd23ea4a)  
  
-   [Building Word 2007 Documents Using Open XML Formats](http://msdn.microsoft.com/en-us/59a46f4e-5a5a-4dac-86e5-7dfd43330766)  
  
> [!NOTE]  
>  Excel, Word, and PowerPoint also enable you to use custom XML parts in documents that are saved in the binary file formats. However, if a document is saved in a binary format, you cannot add or modify custom XML parts without starting the Microsoft Office application.  
  
## Creating and Modifying Custom XML Parts  
 You can create or modify custom XML parts when the document is open in the Office application, or when the document is closed—even if Microsoft Office is not installed.  
  
### Modifying XML Parts While the Office Application Is Running  
 You can work with custom XML parts by using a document-level customization or an VSTO Add-in. If you are using a document-level customization, you will typically work with custom XML parts that are in the customized document. If you are using an VSTO Add-in, you can create or modify custom XML parts in any document that is open in the application.  
  
 To create a custom XML part by using Visual Studio, add a new <xref:Microsoft.Office.Core.CustomXMLPart> to the <xref:Microsoft.Office.Core.CustomXMLParts> collection in the document. For more information, see the following topics:  
  
-   [How to: Add Custom XML Parts to Document-Level Customizations](../vsto/how-to-add-custom-xml-parts-to-document-level-customizations.md)  
  
-   [How to: Add Custom XML Parts to Documents by Using VSTO Add-Ins](../vsto/how-to-add-custom-xml-parts-to-documents-by-using-vsto-add-ins.md)  
  
### Modifying XML Parts Without Starting the Office Application  
 You can add or modify a custom XML part without starting Excel, PowerPoint, or Word. This is useful if you want to work with XML data in a document on a computer that does not have Microsoft Office applications installed, such as a server.  
  
 To add a custom XML part without starting Microsoft Office, use classes in the Open XML SDK. These classes are designed to provide access to Open XML content that is specific to Office documents. For example, to add a custom XML part to an Excel workbook, you use the [AddNewPart\<T>](http://msdn.microsoft.com/en-us/47c348c0-77ab-a504-5097-bcd6a213921a) method of a [WorkbookPart](http://msdn.microsoft.com/en-us/d011e6f4-77dd-d02d-66ef-dc4a9e7b26f2) object. For more information, see [Open XML SDK 2.0](http://msdn.microsoft.com/en-us/f6a9ae68-7989-4208-97f5-3c945137a0ab).  
  
## Binding Custom XML Parts to Word Content Controls  
 You can bind content controls in a Word solution to elements in a custom XML part. When a content control is bound to a custom XML part, the data in the custom XML part is displayed in the user interface (UI) of the content control. If a user edits text in the control, the corresponding XML element is automatically updated. Similarly, if element values in the custom XML parts are changed, the content controls that are bound to the XML elements display the new data. For more information, see [Content Controls](../vsto/content-controls.md).  
  
## See Also  
 [XML Schemas and Data in Document-Level Customizations](../vsto/xml-schemas-and-data-in-document-level-customizations.md)   
 [How to: Add Custom XML Parts to Document-Level Customizations](../vsto/how-to-add-custom-xml-parts-to-document-level-customizations.md)   
 [How to: Add Custom XML Parts to Documents by Using VSTO Add-Ins](../vsto/how-to-add-custom-xml-parts-to-documents-by-using-vsto-add-ins.md)   
 [Content Controls](../vsto/content-controls.md)   
 [Walkthrough: Binding Content Controls to Custom XML Parts](../vsto/walkthrough-binding-content-controls-to-custom-xml-parts.md)  
  
  