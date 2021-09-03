---
title: "How to: Programmatically loop through found items in documents"
description: Learn how you can programmatically loop through found items in a Microsoft Word document by using Visual Studio.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "loops, through found items in documents"
  - "documents [Office development in Visual Studio], searching"
  - "text [Office development in Visual Studio], searching in documents"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically loop through found items in documents
  The <xref:Microsoft.Office.Interop.Word.Find> class has a <xref:Microsoft.Office.Interop.Word.Find.Found%2A> property, which returns **true** whenever a searched-for item is found. You can loop through all instances found in a <xref:Microsoft.Office.Interop.Word.Range> using the <xref:Microsoft.Office.Interop.Word.Find.Execute%2A> method.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## To loop through found items

1. Declare a <xref:Microsoft.Office.Interop.Word.Range> object.

    The following code example can be used in a document-level customization.

    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet79":::
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet79":::

    The following code example can be used in a VSTO Add-in. This example uses the active document.

    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet79":::
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet79":::

2. Use the <xref:Microsoft.Office.Interop.Word.Find.Found%2A> property in a loop to search for all occurrences of the string in the document, and increment an integer variable by 1 each time the string is found.

    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet80":::
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet80":::

3. Display the number of times the string was found in a message box.

    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet81":::
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet81":::

   The following examples show the complete method.

## Document-level customization example

### To loop through items in a document-level customization

1. The following example shows the complete code for a document-level customization. To use this code, run it from the `ThisDocument` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet78":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet78":::

## VSTO Add-in example

### To loop through items in a VSTO Add-in

1. The following example shows the complete code for a VSTO Add-in. To use this code, run it from the `ThisAddIn` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet78":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet78":::

## See also
- [How to: Programmatically search for and replace rext in documents](../vsto/how-to-programmatically-search-for-and-replace-text-in-documents.md)
- [How to: Programmatically set search options in Word](../vsto/how-to-programmatically-set-search-options-in-word.md)
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)
- [How to: Programmatically restore selections after searches](../vsto/how-to-programmatically-restore-selections-after-searches.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
