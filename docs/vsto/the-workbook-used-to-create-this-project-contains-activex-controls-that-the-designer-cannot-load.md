---
title: "The workbook contains ActiveX controls that cannot be loaded"
description: Learn how you can resolve the error that occurs when a workbook contains ActiveX controls that can't be loaded.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "error-reference"
f1_keywords:
  - "VST.SelectDocWizard.ContainsActiveXControls"
dev_langs:
  - "VB"
  - "CSharp"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# The workbook contains ActiveX controls that cannot be loaded

  The error "The workbook used to create this project contains ActiveX controls that the designer cannot load" appears when you add a control to a Word document or an Excel worksheet programmatically, save the document or workbook, and then create a new document-level solution based on the document or workbook.

 Information that describes the managed type of the control is not saved along with the document or workbook. When you create a new solution based on that document or workbook, Visual Studio does not have enough information to load the control in the host item designer.

## To correct this error

1. Open the document or workbook.

2. Remove the controls that were added at run time. You can do this by selecting them in the document or workbook and pressing the **Delete** key.

3. Create a document-level solution based on the document or workbook.

## See also
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
