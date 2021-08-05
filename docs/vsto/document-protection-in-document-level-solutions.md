---
title: "Document protection in document-level solutions"
description: Learn how you can use the protection features of Microsoft Office Word and Microsoft Office Excel in document-level projects.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "restricted permissions [Office development in Visual Studio]"
  - "permissions [Office development in Visual Studio]"
  - "workbooks [Office development in Visual Studio], restricted permissions"
  - "Office documents [Office development in Visual Studio], restricted permissions"
  - "documents [Office development in Visual Studio], restricted permissions"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Document protection in document-level solutions
  You can use the protection features of Microsoft Office Word and Microsoft Office Excel in document-level projects. These features block unauthorized users from making changes to protected parts of a document.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

 Using Excel, you can turn protection on and off while the workbook is open in the designer. Using Word, you can turn protection on only outside of the designer. At run time, you can enable or disable protection programmatically for both Word and Excel.

 When document protection is enabled on a document that is open in the designer, all controls are removed from the **Toolbox** or are made unavailable, and you cannot drag anything from the **Data Sources** window to the document.

## ServerDocument and protected documents
 If a document is protected, the data cache cannot be accessed from outside of the document. You cannot use the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class to retrieve or manipulate data that is cached in a protected document, or use other methods of the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class.

## Word document protection in the designer
 If you add protection to a Word document or template while it is open in Visual Studio, you cannot start enforcing the protection in the designer. The document is in design mode while it is open in Visual Studio, and it must be in run mode before you can start enforcing protection.

 However, if you create a project that uses an existing Word document that has protection enabled, the document is protected while open in the designer. You cannot edit the protected parts of the document, but you can still write code in the Code Editor to automate the document. You also cannot build the project if protection is enabled while the document is open in Visual Studio.

 You can turn protection off while the document is open in the designer so that you can edit the document and build the project. You cannot turn off protection for the copy in the designer while you are debugging; the document that opens during debugging is a separate copy from the one open in the designer (the output copy is stored in the *\bin* directory for Visual Basic, and the *\bin\debug* directory for C#).

 You can enable protection on the copy of the document that opens in the designer by closing the project in Visual Studio, opening the copy of the document that is in the project directory, and turning on protection.

## Enforce Word document protection on build
 Visual Studio starts enforcing protection for Word documents and templates during the build process, so that protection is enabled when the document opens for debugging. The document is protected with an empty password.

 Protection is enabled during build so that if there is code in the document <xref:Microsoft.Office.Tools.Word.Document.Startup> event that might cause exceptions or change the behavior of the application, this code can be debugged correctly. If you enable protection after the document is opened, initialization code cannot be debugged or tested.

## Setting the password
 Visual Studio automatically enables protection, but provides no password by default. If you want the document protection to have a password, you must add it before you deploy your solution. Adding a password enables you to let authorized users remove protection from the document; without a password, protection cannot be easily removed. For details about setting a password, see Help in the specific Office application.

## See also
- [How to: Programmatically protect documents and parts of documents](../vsto/how-to-programmatically-protect-documents-and-parts-of-documents.md)
- [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md)
- [Information rights management and managed code extensions overview](../vsto/information-rights-management-and-managed-code-extensions-overview.md)
- [Password protection on Office documents](../vsto/password-protection-on-office-documents.md)
- [How to: Permit code to run behind documents with restricted permissions](../vsto/how-to-permit-code-to-run-behind-documents-with-restricted-permissions.md)
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
