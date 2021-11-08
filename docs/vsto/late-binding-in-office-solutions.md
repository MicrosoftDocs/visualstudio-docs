---
title: "Late binding in Office solutions"
description: Learn how some types in object models within Microsoft Office applications provide functionality that is available through late-binding features.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "objects [Office development in Visual Studio], casting"
  - "types [Office development in Visual Studio], casting"
  - "automation [Office development in Visual Studio], casting objects"
  - "casting, object to specific type"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Late binding in Office solutions
  Some types in the object models of Office applications provide functionality that is available through late-binding features. For example, some methods and properties can return different types of objects depending on the context of the Office application, and some types can expose different methods or properties in different contexts.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

 Visual Basic projects where **Option Strict** is off and Visual C# projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)] can work directly with types that employ these late-binding features.

## Implicit and explicit casting of object return values
 Many methods and properties in the Microsoft Office primary interop assemblies (PIAs) return <xref:System.Object> values, because they can return several different types of objects. For example, the <xref:Microsoft.Office.Tools.Excel.Workbook.ActiveSheet%2A> property returns an <xref:System.Object> because its return value can be a <xref:Microsoft.Office.Interop.Excel.Worksheet> or <xref:Microsoft.Office.Interop.Excel.Chart> object, depending on what the active sheet is.

 When a method or property returns a <xref:System.Object>, you must explicitly convert (in Visual Basic) the object to the correct type in Visual Basic projects where **Option Strict** is on. You do not have to explicitly cast <xref:System.Object> return values in Visual Basic projects where **Option Strict** is off.

 In most cases, the reference documentation lists the possible types of the return value for a member that returns an <xref:System.Object>. Converting or casting the object enables IntelliSense for the object in the Code Editor.

 For information about conversion in Visual Basic, see [Implicit and explicit conversions &#40;Visual Basic&#41;](/dotnet/visual-basic/programming-guide/language-features/data-types/implicit-and-explicit-conversions) and [CType function &#40;Visual Basic&#41;](/dotnet/visual-basic/language-reference/functions/ctype-function).

### Examples
 The following code example demonstrates how to cast an object to a specific type in a Visual Basic project where **Option Strict** is on. In this type of project, you must explicitly cast the <xref:Microsoft.Office.Tools.Excel.WorksheetBase.Cells%2A> property to a <xref:Microsoft.Office.Interop.Excel.Range>. This example requires a document-level Excel project with a worksheet class named `Sheet1`.

  :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreProgrammingExcelVB/Sheet1.vb" id="Snippet9":::

 The following code example demonstrates how to implicitly cast an object to a specific type in a Visual Basic project where **Option Strict** is off or in a Visual C# project that targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)]. In these types of projects, the <xref:Microsoft.Office.Tools.Excel.WorksheetBase.Cells%2A> property is implicitly cast to a <xref:Microsoft.Office.Interop.Excel.Range>. This example requires a document-level Excel project with a worksheet class named `Sheet1`.

 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreProgrammingExcelVB/Sheet1.vb" id="Snippet10":::
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingExcelCS/Sheet1.cs" id="Snippet10":::

## Access members that are available only through late binding
 Some properties and methods in the Office PIAs are available only through late binding. In Visual Basic projects where **Option Strict** is off or in Visual C# projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)], you can use the late binding features in these languages to access late-bound members. In Visual Basic projects where **Option Strict** is on, you must use reflection to access these members.

### Examples
 The following code example demonstrates how to access late-bound members in a Visual Basic project where **Option Strict** is off or in a Visual C# project that targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)]. This example accesses the late-bound **Name** property of the **File Open** dialog box in Word. To use this example, run it from the `ThisDocument` or `ThisAddIn` class in a Word project.

 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet122":::
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet122":::

 The following code example demonstrates how to use reflection to accomplish the same task in a Visual Basic project where **Option Strict** is on.

 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet102":::

## See also
- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
- [Use Type dynamic &#40;C&#35; programming guide&#41;](/dotnet/csharp/programming-guide/types/using-type-dynamic)
- [Option Strict statement](/dotnet/visual-basic/language-reference/statements/option-strict-statement)
- [Reflection (C#)](/dotnet/csharp/programming-guide/concepts/reflection)
- [Reflection (Visual Basic)](/dotnet/visual-basic/programming-guide/concepts/reflection)
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
