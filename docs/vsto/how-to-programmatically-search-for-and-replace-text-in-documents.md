---
title: "Find and replace text in documents programmatically"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], searching"
  - "text searches, replacing text"
  - "text searches, documents"
  - "text [Office development in Visual Studio], searching in documents"
  - "text [Office development in Visual Studio], text searches"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically search for and replace text in documents
  The <xref:Microsoft.Office.Interop.Word.Find> object is a member of both the <xref:Microsoft.Office.Interop.Word.Selection> and the <xref:Microsoft.Office.Interop.Word.Range> objects, and you can use either one to search for text in Microsoft Office Word documents. The replace command is an extension of the find command.

 Use a <xref:Microsoft.Office.Interop.Word.Find> object to loop through a Microsoft Office Word document and search for specific text, formatting, or style, and use the <xref:Microsoft.Office.Interop.Word.Find.Replacement%2A> property to replace any of the items found.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## Use a Selection object
 When you use a <xref:Microsoft.Office.Interop.Word.Selection> object to find text, any search criteria you specify are applied only against currently selected text. If the <xref:Microsoft.Office.Interop.Word.Selection> is an insertion point, then the document is searched. When the item is found that matches the search criteria, it is automatically selected.

 It is important to note that the <xref:Microsoft.Office.Interop.Word.Find> criteria are cumulative, which means that criteria are added to previous search criteria. Clear formatting from previous searches by using the <xref:Microsoft.Office.Interop.Word.Find.ClearFormatting%2A> method prior to the search.

### To find text using a Selection object

1. Assign a search string to a variable.

    [!code-vb[Trin_VstcoreWordAutomation#68](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#68)]
    [!code-csharp[Trin_VstcoreWordAutomation#68](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#68)]

2. Clear formatting from previous searches.

    [!code-vb[Trin_VstcoreWordAutomation#69](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#69)]
    [!code-csharp[Trin_VstcoreWordAutomation#69](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#69)]

3. Execute the search and display a message box with the results.

    [!code-vb[Trin_VstcoreWordAutomation#70](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#70)]
    [!code-csharp[Trin_VstcoreWordAutomation#70](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#70)]

   The following example shows the complete method.

   [!code-vb[Trin_VstcoreWordAutomation#67](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#67)]
   [!code-csharp[Trin_VstcoreWordAutomation#67](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#67)]

## Use a Range object
 Using a <xref:Microsoft.Office.Interop.Word.Range> object enables you to search for text without displaying anything in the user interface. The <xref:Microsoft.Office.Interop.Word.Find> object returns **True** if text is found that matches the search criteria, and **False** if it does not. It also redefines the <xref:Microsoft.Office.Interop.Word.Range> object to match the search criteria if the text is found.

### To find text using a Range object

1. Define a <xref:Microsoft.Office.Interop.Word.Range> object that consists of the second paragraph in the document.

    The following code example can be used in a document-level customization.

    [!code-vb[Trin_VstcoreWordAutomation#72](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#72)]
    [!code-csharp[Trin_VstcoreWordAutomation#72](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#72)]

    The following code example can be used in a VSTO Add-in. This example uses the active document.

    [!code-vb[Trin_VstcoreWordAutomationAddIn#72](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#72)]
    [!code-csharp[Trin_VstcoreWordAutomationAddIn#72](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#72)]

2. Using the <xref:Microsoft.Office.Interop.Word.Range.Find%2A> property of the <xref:Microsoft.Office.Interop.Word.Range> object, first clear any existing formatting options, and then search for the string **find me**.

    [!code-vb[Trin_VstcoreWordAutomation#73](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#73)]
    [!code-csharp[Trin_VstcoreWordAutomation#73](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#73)]

3. Display the results of the search in a message box, and select the <xref:Microsoft.Office.Interop.Word.Range> to make it visible.

    [!code-vb[Trin_VstcoreWordAutomation#74](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#74)]
    [!code-csharp[Trin_VstcoreWordAutomation#74](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#74)]

    If the search fails, the second paragraph is selected; if it succeeds, the search criteria are displayed.

   The following example shows the complete code for a document-level customization. To use this example, run the code from the `ThisDocument` class in your project.

   [!code-vb[Trin_VstcoreWordAutomation#71](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#71)]
   [!code-csharp[Trin_VstcoreWordAutomation#71](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#71)]

   The following example shows the complete code for a VSTO Add-in. To use this example, run the code from the `ThisAddIn` class in your project.

   [!code-vb[Trin_VstcoreWordAutomationAddIn#71](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#71)]
   [!code-csharp[Trin_VstcoreWordAutomationAddIn#71](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#71)]

## Search for and replace text in documents
 The following code searches the current selection and replaces all of the occurrences of the string **find me** with the string **Found**.

### To search for and replace text in documents

1. Add the following example code to the `ThisDocument` or `ThisAddIn` class in your project.

     [!code-vb[Trin_VstcoreWordAutomation#75](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#75)]
     [!code-csharp[Trin_VstcoreWordAutomation#75](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#75)]

     The <xref:Microsoft.Office.Interop.Word.Find> class has a <xref:Microsoft.Office.Interop.Word.Find.ClearFormatting%2A> method, and the <xref:Microsoft.Office.Interop.Word.Replacement> class also has its own <xref:Microsoft.Office.Interop.Word.Replacement.ClearFormatting%2A> method. When you are performing find-and-replace operations, you must use the ClearFormatting method of both objects. If you use it only on the <xref:Microsoft.Office.Interop.Word.Find> object, you might get unanticipated results in the replacement text.

2. Use the <xref:Microsoft.Office.Interop.Word.Find.Execute%2A> method of the <xref:Microsoft.Office.Interop.Word.Find> object to replace each found item. To specify which items to replace, use the *Replace* parameter. This parameter can be one of the following <xref:Microsoft.Office.Interop.Word.WdReplace> values:

    - <xref:Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll> replaces all found items.

    - <xref:Microsoft.Office.Interop.Word.WdReplace.wdReplaceNone> replaces none of the found items.

    - <xref:Microsoft.Office.Interop.Word.WdReplace.wdReplaceOne> replaces the first found item.

## See also
- [How to: Programmatically set search options in Word](../vsto/how-to-programmatically-set-search-options-in-word.md)
- [How to: Programmatically loop through found items in documents](../vsto/how-to-programmatically-loop-through-found-items-in-documents.md)
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)
- [How to: Programmatically restore selections after searches](../vsto/how-to-programmatically-restore-selections-after-searches.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
