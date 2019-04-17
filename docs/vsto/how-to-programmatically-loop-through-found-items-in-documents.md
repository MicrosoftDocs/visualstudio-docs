---
title: "How to: Programmatically loop through found items in documents"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "loops, through found items in documents"
  - "documents [Office development in Visual Studio], searching"
  - "text [Office development in Visual Studio], searching in documents"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically loop through found items in documents
  The <xref:Microsoft.Office.Interop.Word.Find> class has a <xref:Microsoft.Office.Interop.Word.Find.Found%2A> property, which returns **true** whenever a searched-for item is found. You can loop through all instances found in a <xref:Microsoft.Office.Interop.Word.Range> using the <xref:Microsoft.Office.Interop.Word.Find.Execute%2A> method.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## To loop through found items

1. Declare a <xref:Microsoft.Office.Interop.Word.Range> object.

    The following code example can be used in a document-level customization.

    [!code-vb[Trin_VstcoreWordAutomation#79](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#79)]
    [!code-csharp[Trin_VstcoreWordAutomation#79](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#79)]

    The following code example can be used in a VSTO Add-in. This example uses the active document.

    [!code-vb[Trin_VstcoreWordAutomationAddIn#79](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#79)]
    [!code-csharp[Trin_VstcoreWordAutomationAddIn#79](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#79)]

2. Use the <xref:Microsoft.Office.Interop.Word.Find.Found%2A> property in a loop to search for all occurrences of the string in the document, and increment an integer variable by 1 each time the string is found.

    [!code-vb[Trin_VstcoreWordAutomation#80](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#80)]
    [!code-csharp[Trin_VstcoreWordAutomation#80](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#80)]

3. Display the number of times the string was found in a message box.

    [!code-vb[Trin_VstcoreWordAutomation#81](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#81)]
    [!code-csharp[Trin_VstcoreWordAutomation#81](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#81)]

   The following examples show the complete method.

## Document-level customization example

### To loop through items in a document-level customization

1. The following example shows the complete code for a document-level customization. To use this code, run it from the `ThisDocument` class in your project.

     [!code-vb[Trin_VstcoreWordAutomation#78](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#78)]
     [!code-csharp[Trin_VstcoreWordAutomation#78](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#78)]

## VSTO Add-in example

### To loop through items in a VSTO Add-in

1. The following example shows the complete code for a VSTO Add-in. To use this code, run it from the `ThisAddIn` class in your project.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#78](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#78)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#78](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#78)]

## See also
- [How to: Programmatically search for and replace rext in documents](../vsto/how-to-programmatically-search-for-and-replace-text-in-documents.md)
- [How to: Programmatically set search options in Word](../vsto/how-to-programmatically-set-search-options-in-word.md)
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)
- [How to: Programmatically restore selections after searches](../vsto/how-to-programmatically-restore-selections-after-searches.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
