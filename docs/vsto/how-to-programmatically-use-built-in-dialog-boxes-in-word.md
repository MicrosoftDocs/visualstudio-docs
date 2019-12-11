---
title: "How to: Programmatically use built-in dialog boxes in Word"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Word [Office development in Visual Studio], dialog boxes"
  - "dialog boxes, Word"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically use built-in dialog boxes in Word
  When working with Microsoft Office Word, there are times when you need to display dialog boxes for user input. Although you can create your own, you might also want to take the approach of using the built-in dialog boxes in Word, which are exposed in the <xref:Microsoft.Office.Interop.Word.Dialogs> collection of the <xref:Microsoft.Office.Interop.Word.Application> object. This enables you to access over 200 of the built-in dialog boxes, which are represented as enumerations.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## Display dialog boxes
 To display a dialog box, use one of the values of the <xref:Microsoft.Office.Interop.Word.WdWordDialog> enumeration to create a <xref:Microsoft.Office.Interop.Word.Dialog> object that represents the dialog box you want to display. Then, call the <xref:Microsoft.Office.Interop.Word.Dialog.Show%2A> method of the <xref:Microsoft.Office.Interop.Word.Dialog> object.

 The following code example demonstrates how to display the **File Open** dialog box. To use this example, run it from the `ThisDocument` or `ThisAddIn` class in your project.

 [!code-vb[Trin_VstcoreWordAutomation#100](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#100)]
 [!code-csharp[Trin_VstcoreWordAutomation#100](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#100)]

### Access dialog box members that are available through late binding
 Some properties and methods of dialog boxes in Word are available only through late binding. In Visual Basic projects where **Option Strict** is on, you must use reflection to access these members. For more information, see [Late binding in Office solutions](../vsto/late-binding-in-office-solutions.md).

 The following code example demonstrates how to use the **Name** property of the **File Open** dialog box in Visual Basic projects where **Option Strict** is off or in Visual C# projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)]. To use this example, run it from the `ThisDocument` or `ThisAddIn` class in your project.

 [!code-vb[Trin_VstcoreWordAutomation#122](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#122)]
 [!code-csharp[Trin_VstcoreWordAutomation#122](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#122)]

 The following code example demonstrates how to use reflection to access the **Name** property of the **File Open** dialog box in Visual Basic projects where **Option Strict** is on. To use this example, run it from the `ThisDocument` or `ThisAddIn` class in your project.

 [!code-vb[Trin_VstcoreWordAutomation#102](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#102)]

## See also
- [How to: Programmatically use Word dialog boxes in hidden mode](../vsto/how-to-programmatically-use-word-dialog-boxes-in-hidden-mode.md)
- [Word object model overview](../vsto/word-object-model-overview.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
- [Option strict statement](/dotnet/visual-basic/language-reference/statements/option-strict-statement)
- [Reflection (C#)](/dotnet/csharp/programming-guide/concepts/reflection)
- [Reflection (Visual Basic)](/dotnet/visual-basic/programming-guide/concepts/reflection)
