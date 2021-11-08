---
title: "How to: Programmatically use Word dialog boxes in hidden mode"
description: Learn how you can use Visual Studio to programmatically use Microsoft Word dialog boxes in hidden mode.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "hidden dialog boxes"
  - "Word [Office development in Visual Studio], dialog boxes"
  - "dialog boxes, hidden mode in Word"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically use Word dialog boxes in hidden mode
  You can perform complex operations with one method call by invoking the built-in dialog boxes in Microsoft Office Word without displaying them to the user. You can do this by using the <xref:Microsoft.Office.Interop.Word.Dialog.Execute%2A> method of the <xref:Microsoft.Office.Interop.Word.Dialog> object without calling the <xref:Microsoft.Office.Interop.Word.Dialog.Display%2A> method.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## Examples
 The following code examples demonstrate how to use the **Page Setup** dialog box in hidden mode to set multiple page setup properties with no user input. The examples use a <xref:Microsoft.Office.Interop.Word.Dialog> object to configure a custom page size. The specific settings for page setup, such as the top margin, bottom margin, and so on, are available as late-bound properties of the <xref:Microsoft.Office.Interop.Word.Dialog> object. These properties are dynamically created by Word at run time.

 The following example demonstrates how to perform this task in Visual Basic projects where **Option Strict** is off and in Visual C# projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)]. In these projects, you can use late binding features in the Visual Basic and Visual C# compilers. To use this example, run it from the `ThisDocument` or `ThisAddIn` class in your project.

 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet123":::
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet123":::

 The following example demonstrates how to perform this task in Visual Basic projects where **Option Strict** is on. In these projects, you must use reflection to access the late-bound properties. To use this example, run it from the `ThisDocument` or `ThisAddIn` class in your project.

 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet104":::

## See also
- [How to: Programmatically use built-in dialog boxes in Word](../vsto/how-to-programmatically-use-built-in-dialog-boxes-in-word.md)
- [Word object model overview](../vsto/word-object-model-overview.md)
- [Late binding in Office solutions](../vsto/late-binding-in-office-solutions.md)
- [Reflection (C#)](/dotnet/csharp/programming-guide/concepts/reflection)
- [Reflection (Visual Basic)](/dotnet/visual-basic/programming-guide/concepts/reflection)
