---
title: "Manage documents on a server by using the ServerDocument class"
description: Learn how you can use the ServerDocument class in the Visual Studio Tools for Office runtime to manage several aspects of document-level customizations.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], managing on server"
  - "Office documents [Office development in Visual Studio, managing on server"
  - "ServerDocument class, managing documents on server"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Manage documents on a server by using the ServerDocument class

  You can use the `ServerDocument` class in the  Visual Studio Tools for Office runtime  to manage several aspects of document-level customizations, even if Microsoft Office Word and Microsoft Office Excel are not installed. You can perform the following tasks:

- Access and modify data in the data cache of a document or workbook. For more information, see [Work with cached data in the document](#CachedData).

- Manage the customization assembly that is associated with a document. For more information, see [Manage the document customization](#CustomizationInfo).

  [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

## Understand the ServerDocument class
 The `ServerDocument` class is designed to be used on computers that do not have Office installed. Therefore, you typically use this class in applications that do not integrate with Office, such as Console projects or Windows Forms projects, rather than Office projects. Use the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class in the *Microsoft.VisualStudio.Tools.Applications.ServerDocument.dll* assembly.

 The `ServerDocument` class can be used to operate on document-level customizations that were created by using Visual Studio 2013.

 For more information about the Visual Studio 2010 Tools for Office Runtime and the Office extensions for the .NET Framework, see [Visual Studio Tools for Office runtime overview](../vsto/visual-studio-tools-for-office-runtime-overview.md).

> [!NOTE]
> If you have a legacy application that uses the `ServerDocument` class in the `Visual Studio Tools for Office` system (version 3.0 Runtime), the `Visual Studio Tools for Office` system (version 3.0 runtime) must be installed on computers that run the application. The `Visual Studio 2010 Tools for Office runtime` cannot run these applications.

## <a name="CachedData"></a> Work with cached data in the document
 The `ServerDocument` class provides members you can use to work with the data cache in customized documents. For more information about cached data, see [Cache data](../vsto/caching-data.md) and [Access data in documents on the server](../vsto/accessing-data-in-documents-on-the-server.md).

 The following table lists the members you can use to work with cached data.

|Task|Member to use|
|----------|-------------------|
|To determine whether a document has a data cache.|The <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.IsCacheEnabled%2A> method.|
|To access the cached data in a document.<br /><br /> For more information, see [Access data in documents on the server](../vsto/accessing-data-in-documents-on-the-server.md).|The <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.CachedData%2A> property.|

## <a name="CustomizationInfo"></a> Manage the document customization
 You can use members of the `ServerDocument` class to manage the customization assembly that is associated with a document. For example, you can programmatically remove the customization from a document so that the document is no longer part of a customization.

 The following table lists the members you can use to manage the customization assembly.

|Task|Member to use|
|----------|-------------------|
|To determine whether a document is part of a document-level customization.|The <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.GetCustomizationVersion%2A> method.|
|To programmatically attach a customization to a document at run time.<br /><br /> For more information, see [How to: Attach managed code extensions to documents](../vsto/how-to-attach-managed-code-extensions-to-documents.md)|One of the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.AddCustomization%2A> methods.|
|To programmatically remove a customization from a document at run time.<br /><br /> For more information, see [How to: Remove managed code Extensions from documents](../vsto/how-to-remove-managed-code-extensions-from-documents.md).|The <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.RemoveCustomization%2A> method.|
|To get the URL of the deployment manifest that is associated with the document.|The <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.DeploymentManifestUrl%2A> property.|

## Related content
- [How to: Attach managed code extensions to documents](../vsto/how-to-attach-managed-code-extensions-to-documents.md)
- [How to: Remove managed code extensions from documents](../vsto/how-to-remove-managed-code-extensions-from-documents.md)
- [Visual Studio Tools for Office runtime overview](../vsto/visual-studio-tools-for-office-runtime-overview.md)
- [Cache data](../vsto/caching-data.md)
