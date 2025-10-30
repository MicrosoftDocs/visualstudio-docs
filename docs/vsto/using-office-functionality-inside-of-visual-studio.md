---
title: "Use Office functionality inside of Visual Studio"
description: Learn how the document and the associated application from a document-level project are hosted inside Visual Studio so you can work directly with the document.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "security [Office development in Visual Studio], document protection"
  - "Office applications [Office development in Visual Studio]"
  - "Office functionality inside Visual Studio"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Use Office functionality inside of Visual Studio

  When you create a document-level project, the document and the associated application are hosted inside Visual Studio so you can design and work directly with the document. When you have a Microsoft Office application open in Visual Studio, it generally works as expected. However, some of the application's functionality is different or inaccessible.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

## Document protection
 Microsoft Office Word and Microsoft Office Excel offer document protection features that you can use in your projects. However, if document protection is enabled while the document is open in Visual Studio, it can prevent you from making some design changes. For more information, see [Document protection in document-level solutions](/previous-versions/visualstudio/visual-studio-2017/vsto/document-protection-in-document-level-solutions).

## Information rights management
 Information Rights Management (IRM) is available in Microsoft Office Word and Microsoft Office Excel. IRM can help you prevent unauthorized people from viewing or altering sensitive information. However, IRM can also prevent your code from running. For more information, see [Information rights management and managed code extensions overview](../vsto/information-rights-management-and-managed-code-extensions-overview.md).

## Password protection
 Microsoft Office Word documents and Microsoft Office Excel workbooks can be set so that they cannot be opened by someone who does not know the password. Password protection is handled differently in Word and Excel, and can affect your development process. For more information, see [Password protection on Office documents](../vsto/password-protection-on-office-documents.md).

## Related content
- [Document protection in document-level solutions](/previous-versions/visualstudio/visual-studio-2017/vsto/document-protection-in-document-level-solutions)
- [Information rights management and managed code extensions overview](../vsto/information-rights-management-and-managed-code-extensions-overview.md)
- [Password protection on Office documents](../vsto/password-protection-on-office-documents.md)
- [How to: Open Office solutions without running code](../vsto/how-to-open-office-solutions-without-running-code.md)
