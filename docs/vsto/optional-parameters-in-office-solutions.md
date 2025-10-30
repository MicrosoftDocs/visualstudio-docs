---
title: "Optional parameters in Office solutions"
description: Learn how you don't have to pass a value for optional parameters because the default values are automatically used for each missing parameter.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office applications [Office development in Visual Studio], optional parameters"
  - "Visual C# [Office development in Visual Studio], optional parameters"
  - "Visual Basic [Office development in Visual Studio], optional parameters"
  - "application development [Office development in Visual Studio], optional parameters"
  - "missing field [Office development in Visual Studio]"
  - "optional parameters [Office development in Visual Studio]"
  - "parameters [Office development in Visual Studio], optional"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Optional parameters in Office solutions

  Many of the methods in the object models of Microsoft Office applications accept optional parameters. If you use Visual Basic to develop an Office solution in Visual Studio, you do not have to pass a value for optional parameters because the default values are automatically used for each missing parameter. In most cases, you can also omit optional parameters in Visual C# projects. However, you cannot omit optional **ref** parameters of the `ThisDocument` class in document-level Word projects.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

 For more information about working with optional parameters in Visual C# and Visual Basic projects, see [Named and optional arguments &#40;C&#35; programming guide&#41;](/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments) and [Optional parameters &#40;Visual Basic&#41;](/dotnet/visual-basic/programming-guide/language-features/procedures/optional-parameters).

> [!NOTE]
> In earlier versions of Visual Studio, you must pass a value for every optional parameter in Visual C# projects. For convenience, these projects include a global variable named `missing` that you can pass to an optional parameter when you want to use the default value of the parameter. Visual C# projects for Office in Visual Studio still include the `missing` variable, but you typically do not need to use it when you develop Office solutions in Visual Studio 2013, except when you call methods with optional **ref** parameters in the `ThisDocument` class in document-level projects for Word.

## Example in Excel
 The <xref:Microsoft.Office.Tools.Excel.Worksheet.CheckSpelling%2A> method has many optional parameters. You can specify values for some parameters and accept the default value of others as shown in the following code example. This example requires a document-level project with a worksheet class named `Sheet1`.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/excelworkbook1/Sheet1.cs" id="Snippet1":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/excelworkbook1/Sheet1.vb" id="Snippet1":::
 ---

## Example in Word
 The <xref:Microsoft.Office.Interop.Word.Find.Execute%2A> method has many optional parameters. You can specify values for some parameters and accept the default value of others as shown in the following code example.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/worddocument1/ThisDocument.cs" id="Snippet1":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/worddocument1/ThisDocument.vb" id="Snippet1":::
 ---

## Use optional parameters of methods in the ThisDocument class in Visual C# document-level projects for Word
 The Word object model contains many methods with optional **ref** parameters that accept <xref:System.Object> values. However, you cannot omit optional **ref** parameters of methods of the generated `ThisDocument` class in Visual C# document-level projects for Word. Visual C# enables you to omit optional **ref** parameters only for methods of interfaces, not classes. For example, the following code example does not compile, because you cannot omit optional **ref** parameters of the <xref:Microsoft.Office.Tools.Word.DocumentBase.CheckSpelling%2A> method of the `ThisDocument` class.

 :::code language="csharp" source="../vsto/codesnippet/CSharp/worddocument1/ThisDocument.cs" id="Snippet3":::

 When you call methods of the `ThisDocument` class, follow these guidelines:

- To accept the default value of an optional **ref** parameter, pass the `missing` variable to the parameter. The `missing` variable is automatically defined in Visual C# Office projects and is assigned to the value <xref:System.Type.Missing> in the generated project code.

- To specify your own value for an optional **ref** parameter, declare an object that is assigned to the value that you want to specify, and then pass the object to the parameter.

  The following code example demonstrates how to call the <xref:Microsoft.Office.Tools.Word.DocumentBase.CheckSpelling%2A> method by specifying a value for the *ignoreUppercase* parameter and accepting the default value for the other parameters.

  :::code language="csharp" source="../vsto/codesnippet/CSharp/worddocument1/ThisDocument.cs" id="Snippet4":::

  If you want to write code that omits optional **ref** parameters of a method in the `ThisDocument` class, you can alternatively call the same method on the <xref:Microsoft.Office.Interop.Word.Document> object returned by the <xref:Microsoft.Office.Tools.Word.Document.InnerObject%2A> property, and omit the parameters from that method. You can do this because <xref:Microsoft.Office.Interop.Word.Document> is an interface, rather than a class.

  :::code language="csharp" source="../vsto/codesnippet/CSharp/worddocument1/ThisDocument.cs" id="Snippet5":::

  For more information about value and reference type parameters, see [Pass arguments by value and by reference &#40;Visual Basic&#41;](/dotnet/visual-basic/programming-guide/language-features/procedures/passing-arguments-by-value-and-by-reference) (for Visual Basic) and [Pass parameters &#40;C&#35; programming guide&#41;](/dotnet/csharp/programming-guide/classes-and-structs/passing-parameters).

## Related content
- [Develop Office solutions](../vsto/developing-office-solutions.md)
- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)
