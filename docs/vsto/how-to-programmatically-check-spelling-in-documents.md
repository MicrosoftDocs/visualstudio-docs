---
title: "How to: Programmatically check spelling in documents"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], checking spelling"
  - "spelling checker, documents"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically check spelling in documents
  To check the spelling in a document, use the <xref:Microsoft.Office.Interop.Word._Application.CheckSpelling%2A> method. This method returns a Boolean value that indicates whether the supplied parameter is spelled correctly.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## To check spelling and display results in a message box

1. Call the <xref:Microsoft.Office.Interop.Word._Application.CheckSpelling%2A> method and pass it a range of text to check for spelling errors. To use this code example, run it from the `ThisDocument` or `ThisAddIn` class in your project.

     [!code-vb[Trin_VstcoreWordAutomation#113](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#113)]
     [!code-csharp[Trin_VstcoreWordAutomation#113](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#113)]

## See also
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
