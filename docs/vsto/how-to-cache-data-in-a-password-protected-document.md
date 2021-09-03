---
title: "How to: Cache data in a password-protected document"
description: Learn that if you add data to the data cache in a document or workbook that is protected with a password, you can save changes to the cached data by overriding two methods in your project.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "data caching [Office development in Visual Studio], protected documents"
  - "datasets [Office development in Visual Studio], caching"
  - "data [Office development in Visual Studio], caching"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Cache data in a password-protected document
  If you add data to the data cache in a document or workbook that is protected with a password, changes to the cached data are not saved automatically. You can save changes to the cached data by overriding two methods in your project.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

## Caching in Word documents

### To cache data in a Word document that is protected with a password

1. In the `ThisDocument` class, mark a public field or property to be cached. For more information, see [Cache data](../vsto/caching-data.md).

2. Override the <xref:Microsoft.Office.Tools.Word.DocumentBase.UnprotectDocument%2A> method in the `ThisDocument` class and remove protection from the document.

     When the document is saved, the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] calls this method to give you an opportunity to unprotect the document. This enables changes to the cached data to be saved.

3. Override the <xref:Microsoft.Office.Tools.Word.DocumentBase.ProtectDocument%2A> method in the `ThisDocument` class and reapply protection to the document.

     After the document is saved, the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] calls this method to give you an opportunity to reapply protection to the document.

### Example
 The following code example demonstrates how to cache data in a Word document that is protected with a password. Before the code removes the protection in the <xref:Microsoft.Office.Tools.Word.DocumentBase.UnprotectDocument%2A> method, it saves the current <xref:Microsoft.Office.Tools.Word.Document.ProtectionType%2A> value, so that the same type of protection can be reapplied in the <xref:Microsoft.Office.Tools.Word.DocumentBase.ProtectDocument%2A> method.

 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_CachedDataProtectedDocument/ThisDocument.cs" id="Snippet1":::
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_CachedDataProtectedDocument/ThisDocument.vb" id="Snippet1":::

### Compile the code
 Add this code to the `ThisDocument` class in your project. This code assumes that the password is stored in a field named `securelyStoredPassword`.

## Cache in Excel workbooks
 In Excel projects, this procedure is necessary only when you protect the entire workbook with a password by using the <xref:Microsoft.Office.Tools.Excel.Workbook.Protect%2A> method. This procedure is not necessary if you protect only a specific worksheet with a password by using the <xref:Microsoft.Office.Tools.Excel.Worksheet.Protect%2A> method.

### To cache data in an Excel workbook that is protected with a password

1. In the `ThisWorkbook` class or one of the `Sheet`*n* classes, mark a public field or property to be cached. For more information, see [Cache data](../vsto/caching-data.md).

2. Override the <xref:Microsoft.Office.Tools.Excel.WorkbookBase.UnprotectDocument%2A> method in the `ThisWorkbook` class and remove protection from the workbook.

     When the workbook is saved, the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] calls this method to give you an opportunity to unprotect the workbook. This enables changes to the cached data to be saved.

3. Override the <xref:Microsoft.Office.Tools.Excel.WorkbookBase.ProtectDocument%2A> method in the `ThisWorkbook` class and reapply protection to the document.

     After the workbook is saved, the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] calls this method to give you an opportunity to reapply protection to the workbook.

### Example
 The following code example demonstrates how to cache data in an Excel workbook that is protected with a password. Before the code removes the protection in the <xref:Microsoft.Office.Tools.Excel.WorkbookBase.UnprotectDocument%2A> method, it saves the current <xref:Microsoft.Office.Tools.Excel.Workbook.ProtectStructure%2A> and <xref:Microsoft.Office.Tools.Excel.Workbook.ProtectWindows%2A> values, so that the same type of protection can be reapplied in the <xref:Microsoft.Office.Tools.Excel.WorkbookBase.ProtectDocument%2A> method.

 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_CachedDataProtectedWorkbook/ThisWorkbook.vb" id="Snippet1":::
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_CachedDataProtectedWorkbook/ThisWorkbook.cs" id="Snippet1":::

### Compile the code
 Add this code to the `ThisWorkbook` class in your project. This code assumes that the password is stored in a field named `securelyStoredPassword`.

## See also
- [Cache data](../vsto/caching-data.md)
- [How to: Cache data for use offline or on a server](../vsto/how-to-cache-data-for-use-offline-or-on-a-server.md)
- [How to: Programmatically cache a data source in an Office document](../vsto/how-to-programmatically-cache-a-data-source-in-an-office-document.md)
