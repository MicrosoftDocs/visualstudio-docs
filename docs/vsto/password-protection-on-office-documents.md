---
title: "Password protection on Office documents"
description: Learn how to set a password on your Microsoft Word documents and Excel workbooks so that they can't be opened by unauthorized users.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "permissions [Office development in Visual Studio]"
  - "workbooks [Office development in Visual Studio], restricted permissions"
  - "passwords [Office development in Visual Studio], document protections"
  - "documents [Office development in Visual Studio], restricted permissions"
  - "Office documents [Office development in Visual Studio, restricted permissions"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Password protection on Office documents
  It is possible to set a password on your Microsoft Office Word documents and Microsoft Office Excel workbooks so that they cannot be opened by someone who does not know the password. This option is called **Password on Open**.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

 You can create document-level projects using existing documents and workbooks that have **Password on Open** enabled. The behavior in Visual Studio is different for Word and Excel documents that have **Password on Open** enabled.

 For information about enabling **Password on Open**, see Help in Word or Excel.

## Behavior of Excel and Word
 Every time you open an Excel workbook in Visual Studio that has **Password on Open** enabled, Excel prompts you for the password. When you build your solution you will be prompted for the password again, because the document is opened during build.

 The first time you open a Word document in Visual Studio that has **Password on Open** enabled, Word prompts you for the password. After you successfully enter the password, **Password on Open** is removed from the document and opening the document will no longer require a password. If you want the document in your solution to require a password before it can be opened, you must enable **Password on Open** after your final build and before you deploy the solution.

## See also
- [Document protection in document-level solutions](../vsto/document-protection-in-document-level-solutions.md)
- [Information rights management and managed code extensions overview](../vsto/information-rights-management-and-managed-code-extensions-overview.md)
- [How to: Permit code to run behind documents with restricted permissions](../vsto/how-to-permit-code-to-run-behind-documents-with-restricted-permissions.md)
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
