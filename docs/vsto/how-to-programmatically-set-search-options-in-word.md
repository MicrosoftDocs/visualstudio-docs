---
title: "How to: Programmatically set search options in Word"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "settings, Word search options"
  - "documents [Office development in Visual Studio], search options"
  - "Word, searching options"
  - "searching, Word options"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically set search options in Word
  There are two ways to set search options for selections in Microsoft Office Word documents:

- Set individual properties of a <xref:Microsoft.Office.Interop.Word.Find> object.

- Use arguments of the <xref:Microsoft.Office.Interop.Word.Find.Execute%2A> method of a <xref:Microsoft.Office.Interop.Word.Find> object.

  [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## Use properties of a Find object
 The following code sets properties of a <xref:Microsoft.Office.Interop.Word.Find> object to search for text within the current selection. Notice that the search criteria, such as searching forward, wrapping, and text to search for, are properties of the <xref:Microsoft.Office.Interop.Word.Find> object.

 Setting each of the properties of the <xref:Microsoft.Office.Interop.Word.Find> object is not useful when you write C# code because you must specify the same properties as parameters in the <xref:Microsoft.Office.Interop.Word.Find.Execute%2A> method. Therefore this example contains only Visual Basic code.

### To set search options using a Find object

1. Set the properties of a <xref:Microsoft.Office.Interop.Word.Find> object to search forward through a selection for the text **find me**.

     [!code-vb[Trin_VstcoreWordAutomation#76](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#76)]

## Use Execute method arguments
 The following code uses the <xref:Microsoft.Office.Interop.Word.Find.Execute%2A> method of a <xref:Microsoft.Office.Interop.Word.Find> object to search for text within the current selection. Notice that the search criteria, such as searching forward, wrapping, and text to search for, are passed as parameters of the <xref:Microsoft.Office.Interop.Word.Find.Execute%2A> method.

### To set search options using Execute method arguments

1. Pass search criteria as parameters of the <xref:Microsoft.Office.Interop.Word.Find.Execute%2A> method to search forward through a selection for the text **find me**.

     [!code-vb[Trin_VstcoreWordAutomation#77](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#77)]
     [!code-csharp[Trin_VstcoreWordAutomation#77](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#77)]

## See also
- [How to: Programmatically search for and replace text in documents](../vsto/how-to-programmatically-search-for-and-replace-text-in-documents.md)
- [How to: Programmatically loop through found items in documents](../vsto/how-to-programmatically-loop-through-found-items-in-documents.md)
- [How to: Programmatically restore selections after searches](../vsto/how-to-programmatically-restore-selections-after-searches.md)
