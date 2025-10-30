---
title: "Automate Word by using extended objects"
description: Learn how you can use host items and host controls in your solutions when you develop Word solutions in Visual Studio.
ms.date: 02/02/2017
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Word [Office development in Visual Studio], automating"
  - "extended objects [Office development in Visual Studio], Word"
  - "automation [Office development in Visual Studio], Word"
  - "host items [Office development in Visual Studio], Word"
  - "automating Word"
  - "controls [Office development in Visual Studio], Word host controls"
  - "host controls, Word"
  - "host controls [Office development in Visual Studio], Word"
  - "Word [Office development in Visual Studio], host controls"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Automate Word by using extended objects

  When you develop Word solutions in Visual Studio, you can use *host items* and *host control*s in your solutions. These are objects that extend certain commonly used objects in the Word object model (that is, the object model that is exposed by the primary interop assembly for Word), such as the <xref:Microsoft.Office.Interop.Word.Document> and <xref:Microsoft.Office.Interop.Word.ContentControl> objects. The extended objects behave like the Word objects they are based on, but they add additional events and data binding capabilities to the objects.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

 Host items and host controls are available in both VSTO Add-ins and document-level customizations, although the context in which these can be used is different for each type of solution. For more information, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md).

## Document host item
 Word projects give you access to the <xref:Microsoft.Office.Tools.Word.Document> host item. The <xref:Microsoft.Office.Tools.Word.Document> host item acts as a container for other controls, including host controls and Windows Forms controls, and it maintains information about the controls on its surface. The <xref:Microsoft.Office.Tools.Word.Document> host item also provides most of the same members as the <xref:Microsoft.Office.Interop.Word.Document> class, which is the corresponding class in the object model of Word.

 For more information, see [Document host item](../vsto/document-host-item.md).

## Word host controls
 There are several host controls for Word that help you create, organize, and automate documents. Most of their functionality involves importing, presenting, and protecting data. These host controls provide events and data-binding capabilities that their counterparts in the native Word object model do not have.

 In document-level projects, you can add any host control to your document at design time, or you can add content controls and bookmark controls at run time. In VSTO Add-in projects, you can add content controls and bookmark controls to any open document at run time.

 For more information about the host controls you can use in Word projects, see the following topics:

- [Content controls](../vsto/content-controls.md)

- [Bookmark control](../vsto/bookmark-control.md)

- [XMLNode control](../vsto/xmlnode-control.md)

- [XMLNodes control](../vsto/xmlnodes-control.md)

## Related content
- [How to: Add content controls to Word documents](../vsto/how-to-add-content-controls-to-word-documents.md)
- [How to: Add Bookmark controls to Word documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md)
- [How to: Add XMLNode controls to Word documents](../vsto/how-to-add-xmlnode-controls-to-word-documents.md)
- [How to: Add XMLNodes controls to Word documents](../vsto/how-to-add-xmlnodes-controls-to-word-documents.md)
- [Walkthrough: Create a template by using content controls](../vsto/walkthrough-creating-a-template-by-using-content-controls.md)
- [Walkthrough: Bind content controls to custom XML parts](../vsto/walkthrough-binding-content-controls-to-custom-xml-parts.md)
- [Walkthrough: Create shortcut menus for bookmarks](/previous-versions/visualstudio/visual-studio-2017/vsto/walkthrough-creating-shortcut-menus-for-bookmarks)
- [Word solutions](../vsto/word-solutions.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
