---
title: "Grant trust to documents"
description: Learn how a document-level project has the same security requirements as application-level projects, like signing the manifests with a certificate or clicking the trust prompt.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "security [Office development in Visual Studio], trust"
  - "inclusion lists [Office development in Visual Studio], about inclusion lists"
  - "trust [Office development in Visual Studio], 2007 Office system"
  - "granting trust [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Grant trust to documents

  A document-level project has the same security requirements as application-level projects: signing the manifests with a certificate or clicking the trust prompt. In addition, the document or workbook must be located in a directory that is designated as a trusted location.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

## Trusted locations
 Applications in  Office 2013  and Office 2010 have Trust Centers where users can configure security and privacy settings, such as trusted locations. For Office solutions, the local computer is considered a trusted location. However, because of higher risk, there are certain directories that cannot ever be trusted, such as the temporary folders for the system, for each user, and for Internet Explorer.

 For more information about the Trust Center, see [Security and policies and settings in Office 2010](/previous-versions/office/office-2010/cc178946(v=office.14)). For more information about how to create, manage, remove, and configure trusted folders, see [Configure trusted locations and trusted publishers settings in the 2007 Office system](/previous-versions/office/office-2007-resource-kit/cc178948(v=office.12)) and [Create, remove, or change a trusted location for your files](https://support.office.com/article/Create-remove-or-change-a-trusted-location-for-your-files-f5151879-25ea-4998-80a5-4208b3540a62).

## Security considerations for Office solutions
 There are several security concerns when you consider which folders to add to the trusted locations:

- Local folders are considered to be more secure and are implicitly trusted. Remote locations such as file shares must be designated as trusted locations.

- When you add a directory to the trusted locations, this action grants full trust not only to Office solutions, but also to VBA and ActiveX code. For this reason, the root directory and the *My Documents* folders should not be designated as trusted.

- Although the document itself is trusted by using the trusted locations, additional permissions are needed to trust the customization. You can grant full trust to the customization by using signing the manifests with a certificate, clicking the trust prompt, or installing the Office solution to the *Program Files* directory.

- You can store the document or workbook of a document-level solution in the same directory as the assembly, or in a different directory. For example, the document could be located on a SharePoint server and the assembly could be located on a network file share. For more information, see [How to: Publish a document-level Office solution to a SharePoint server by using ClickOnce](/previous-versions/bb608595(v=vs.110)).

## Related content
- [Grant trust to Office solutions](../vsto/granting-trust-to-office-solutions.md)
- [Troubleshoot Office solution security](../vsto/troubleshooting-office-solution-security.md)
- [Secure Office solutions](../vsto/securing-office-solutions.md)
