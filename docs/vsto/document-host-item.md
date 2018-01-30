---
title: "Document Host Item | Microsoft Docs"
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
  - "documents [Office development in Visual Studio]"
  - "documents [Office development in Visual Studio], document host items"
  - "document host items"
  - "Word [Office development in Visual Studio], Word documents"
  - "Word [Office development in Visual Studio]"
  - "Word documents"
  - "host items [Office development in Visual Studio], Document"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Document Host Item
  The <xref:Microsoft.Office.Tools.Word.Document> host item is a type that extends the <xref:Microsoft.Office.Interop.Word.Document> type from the primary interop assembly for Word. The <xref:Microsoft.Office.Tools.Word.Document> host item provides all of the same properties, methods, and events as a <xref:Microsoft.Office.Interop.Word.Document> object, but it also exposes additional events and acts as a container for host controls and Windows Forms controls.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
 In document-level projects, there is a default <xref:Microsoft.Office.Tools.Word.Document> host item that represents the document in your project. In VSTO Add-in projects, you can generate <xref:Microsoft.Office.Tools.Word.Document> host items at run time.  
  
## Understanding the Document Host Item in Document-Level Projects  
 To access the document in your project, use the `ThisDocument` class. When you create a document-level project, Visual Studio generates the `ThisDocument` class to serve as the communication link between Word and your customization code. The `ThisDocument` class gives you access to members of the <xref:Microsoft.Office.Tools.Word.Document> host item to perform basic tasks in your customization, such as running code when the document is opened or closed. You can also use the class to add controls to the document. By combining different sets of controls and writing code, you can bind the controls to data, collect information from the user, and respond to user actions. For more information, see [Programming Document-Level Customizations](../vsto/programming-document-level-customizations.md).  
  
 The `ThisDocument` class provides a location in which you can start writing code in your project. Because the class provides all of the same properties, methods, and events as the <xref:Microsoft.Office.Interop.Word.Document> object in the primary interop assembly for Word, you can also use `ThisDocument` to access the object model of Word. For more information, see [Word Object Model Overview](../vsto/word-object-model-overview.md).  
  
### Limitations of the Document Host Item in Document-Level Projects  
 A document-level project can contain only one <xref:Microsoft.Office.Tools.Word.Document> host item (that is, the `ThisDocument` class). You cannot add new <xref:Microsoft.Office.Tools.Word.Document> host items to your project at design time, and you cannot create new <xref:Microsoft.Office.Tools.Word.Document> host items at run time from a document-level customization.  
  
 If you create a new Word document at run time, it will be of the type <xref:Microsoft.Office.Interop.Word.Document>. Because it is not a host item, it cannot contain any host controls or Windows Forms controls. For more information about creating documents at run time, see [How to: Programmatically Create New Documents](../vsto/how-to-programmatically-create-new-documents.md).  
  
## Understanding Document Host Items in Application-Level Projects  
 In VSTO Add-in projects, you can generate a <xref:Microsoft.Office.Tools.Word.Document> host item at run time for any document that is open in Word. You can use the <xref:Microsoft.Office.Tools.Word.Document> host item to add controls to the associated document, or to handle events that are not available on <xref:Microsoft.Office.Interop.Word.Document> objects.  
  
 To generate a <xref:Microsoft.Office.Tools.Word.Document> host item, use the GetVstoObject method. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
## See Also  
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [Automating Word by Using Extended Objects](../vsto/automating-word-by-using-extended-objects.md)   
 [Word Object Model Overview](../vsto/word-object-model-overview.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)  
  
  