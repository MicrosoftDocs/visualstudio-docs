---
title: "How to: Programmatically open text files as workbooks"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "workbooks, opening text files as"
  - "text [Office development in Visual Studio], text files"
  - "text files, opening as workbooks"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically open text files as workbooks
  You can open a text file as a workbook. You must pass in the name of the text file you want to open. You can specify several optional parameters, such as which row number to start parsing on and the column format of the data in the file.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Example
 [!code-csharp[Trin_VstcoreExcelAutomation#80](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#80)]
 [!code-vb[Trin_VstcoreExcelAutomation#80](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#80)]

## Compile the code
 This example requires the following components:

- A comma-delimited text file named `Test.txt` that contains at least three lines of text.

- The text file `Test.txt` to be stored on drive C.

## See also
- [Work with workbooks](../vsto/working-with-workbooks.md)
- [How to: Programmatically open workbooks](../vsto/how-to-programmatically-open-workbooks.md)
- [How to: Programmatically create new workbooks](../vsto/how-to-programmatically-create-new-workbooks.md)
- [How to: Programmatically save workbooks](../vsto/how-to-programmatically-save-workbooks.md)
- [How to: Programmatically close workbooks](../vsto/how-to-programmatically-close-workbooks.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
