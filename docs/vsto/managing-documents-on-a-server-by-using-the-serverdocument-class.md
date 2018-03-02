---
title: "Managing Documents on a Server by Using the ServerDocument Class | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "documents [Office development in Visual Studio], managing on server"
  - "Office documents [Office development in Visual Studio, managing on server"
  - "ServerDocument class, managing documents on server"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Managing Documents on a Server by Using the ServerDocument Class
  You can use the ServerDocument class in the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] to manage several aspects of document-level customizations, even if Microsoft Office Word and Microsoft Office Excel are not installed. You can perform the following tasks:  
  
-   Access and modify data in the data cache of a document or workbook. For more information, see [Working With Cached Data in the Document](#CachedData).  
  
-   Manage the customization assembly that is associated with a document. For more information, see [Managing the Document Customization](#CustomizationInfo).  
  
 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]  
  
## Understanding the ServerDocument Class  
 The ServerDocument class is designed to be used on computers that do not have Office installed. Therefore, you typically use this class in applications that do not integrate with Office, such as Console projects or Windows Forms projects, rather than Office projects. Use the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class in the Microsoft.VisualStudio.Tools.Applications.ServerDocument.dll assembly.  
  
 The ServerDocument class can be used to operate on document-level customizations that were created by using [!INCLUDE[vs_dev12](../vsto/includes/vs-dev12-md.md)].  
  
 For more information about the Visual Studio 2010 Tools for Office Runtime and the Office extensions for the .NET Framework, see [Visual Studio Tools for Office Runtime Overview](../vsto/visual-studio-tools-for-office-runtime-overview.md).  
  
> [!NOTE]  
>  If you have a legacy application that uses the ServerDocument class in the Visual Studio Tools for Office system (version 3.0 Runtime), the Visual Studio Tools for Office system (version 3.0 Runtime) must be installed on computers that run the application. The Visual Studio 2010 Tools for Office Runtime cannot run these applications.  
  
##  <a name="CachedData"></a> Working With Cached Data in the Document  
 The ServerDocument class provides members you can use to work with the data cache in customized documents. For more information about cached data, see [Caching Data](../vsto/caching-data.md) and [Accessing Data in Documents on the Server](../vsto/accessing-data-in-documents-on-the-server.md).  
  
 The following table lists the members you can use to work with cached data.  
  
|Task|Member to use|  
|----------|-------------------|  
|To determine whether a document has a data cache.|The <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.IsCacheEnabled%2A> method.|  
|To access the cached data in a document.<br /><br /> For more information, see [Accessing Data in Documents on the Server](../vsto/accessing-data-in-documents-on-the-server.md).|The <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.CachedData%2A> property.|  
  
##  <a name="CustomizationInfo"></a> Managing the Document Customization  
 You can use members of the ServerDocument class to manage the customization assembly that is associated with a document. For example, you can programmatically remove the customization from a document so that the document is no longer part of a customization.  
  
 The following table lists the members you can use to manage the customization assembly.  
  
|Task|Member to use|  
|----------|-------------------|  
|To determine whether a document is part of a document-level customization.|The <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.GetCustomizationVersion%2A> method.|  
|To programmatically attach a customization to a document at run time.<br /><br /> For more information, see [How to: Attach Managed Code Extensions to Documents](../vsto/how-to-attach-managed-code-extensions-to-documents.md)|One of the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.AddCustomization%2A> methods.|  
|To programmatically remove a customization from a document at run time.<br /><br /> For more information, see [How to: Remove Managed Code Extensions from Documents](../vsto/how-to-remove-managed-code-extensions-from-documents.md).|The <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.RemoveCustomization%2A> method.|  
|To get the URL of the deployment manifest that is associated with the document.|The <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.DeploymentManifestUrl%2A> property.|  
  
## See Also  
 [How to: Attach Managed Code Extensions to Documents](../vsto/how-to-attach-managed-code-extensions-to-documents.md)   
 [How to: Remove Managed Code Extensions from Documents](../vsto/how-to-remove-managed-code-extensions-from-documents.md)   
 [Visual Studio Tools for Office Runtime Overview](../vsto/visual-studio-tools-for-office-runtime-overview.md)   
 [Caching Data](../vsto/caching-data.md)  
  