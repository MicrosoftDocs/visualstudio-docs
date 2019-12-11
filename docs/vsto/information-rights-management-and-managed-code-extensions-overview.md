---
title: "Information rights management & managed code extensions"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Information Rights Management [Office development in Visual Studio]"
  - "workbooks [Office development in Visual Studio], restricted permissions"
  - "IRM [Office development in Visual Studio]"
  - "documents [Office development in Visual Studio], restricted permissions"
  - "rights management [Office development in Visual Studio]"
  - "Office documents [Office development in Visual Studio, restricted permissions"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Information rights management and managed code extensions overview
  Microsoft Office Word and Microsoft Office Excel provide Information Rights Management (IRM), a feature that can help you prevent unauthorized people from viewing or altering sensitive information. For details about how Information Rights Management works, see Help in the specific Office application.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

## Run code behind documents with restricted permissions
 If your solution contains a document or workbook that uses IRM, by default, Word and Excel do not permit any code to run. If you are the author of the document or have Full Control access, you can change the default so that your solution works. For more information, see [How to: Permit code to run behind documents with restricted permissions](../vsto/how-to-permit-code-to-run-behind-documents-with-restricted-permissions.md).

 IRM prevents use of <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> to retrieve or manipulate data that is cached in the document.

## End users to restrict permissions to documents that use managed code extensions
 Anyone who has Full Control access to the document or workbook in your solution can use IRM to restrict permissions. For example, if an end user in the accounting department uses a solution that automatically populates a worksheet with data from a database, that user might want to allow Change access only to people in his or her department and Read access to others. When the user adds the restricted permissions, by default, the code behind the worksheet cannot run, and the worksheet will not be populated with data.

 To fix the problem, someone with Full Control access to the document or workbook must change the default permission settings to allow programmatic access to the object model. For more information, see [How to: Permit code to run behind documents with restricted permissions](../vsto/how-to-permit-code-to-run-behind-documents-with-restricted-permissions.md).

## See also
- [Document protection in document-level solutions](../vsto/document-protection-in-document-level-solutions.md)
- [Password protection on Office documents](../vsto/password-protection-on-office-documents.md)
- [Secure Office solutions](../vsto/securing-office-solutions.md)
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
