---
title: "Programmatically apply color to Excel ranges"
description: Apply a color to text within a range of cells by using a NamedRange control or a native Microsoft Office Excel range object.
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "formatting [Office development in Visual Studio]"
  - "color, Excel ranges"
  - "ranges, applying color"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Programmatically apply color to Excel ranges

  To apply a color to text within a range of cells, use a <xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Use a NamedRange control
 This example is for document-level customizations.

### To apply color to a NamedRange control

1. Create a <xref:Microsoft.Office.Tools.Excel.NamedRange> control at cell A1.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet65":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet65":::
     ---

2. Set the color of the text in the <xref:Microsoft.Office.Tools.Excel.NamedRange> control.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet66":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet66":::
     ---

## Use native Excel ranges

### To apply color to a native Excel range object

1. Create a range at cell A1 and then set the color of the text.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet67":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet67":::
     ---

## Related content
- [Work with ranges](../vsto/working-with-ranges.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [How to: Programmatically apply styles to ranges in workbooks](../vsto/how-to-programmatically-apply-styles-to-ranges-in-workbooks.md)
- [How to: Programmatically refer to worksheet ranges in code](../vsto/how-to-programmatically-refer-to-worksheet-ranges-in-code.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
