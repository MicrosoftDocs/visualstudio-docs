---
title: "How to: Attach managed code extensions to documents"
description: Learn how you can attach a customization assembly to an existing Microsoft Office Word document or Microsoft Office Excel workbook. 
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "managed code extensions [Office development in Visual Studio], attaching"
  - "documents [Office development in Visual Studio], managed code extensions"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Attach managed code extensions to documents
  You can attach a customization assembly to an existing Microsoft Office Word document or Microsoft Office Excel workbook. The document or workbook can be in any file format that is supported by the Microsoft Office projects and development tools in Visual Studio. For more information, see [Architecture of document-level customizations](../vsto/architecture-of-document-level-customizations.md).

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

 To attach a customization to a Word or Excel document, use the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.AddCustomization%2A> method of the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class. Because the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class is designed to be run on a computer that does not have Microsoft Office installed, you can use this method in solutions that are not directly related to Microsoft Office development (such as a console or Windows Forms application).

> [!NOTE]
> The customization will fail to load if the code expects controls that the specified document does not have.

### To attach managed code extensions to a document

1. In a project that does not require Microsoft Office, such as a console application or Windows Forms project, add a reference to the *Microsoft.VisualStudio.Tools.Applications.ServerDocument.dll* and *Microsoft.VisualStudio.Tools.Applications.Runtime.dll* assemblies.

2. Add the following **Imports** or **using** statements to the top of your code file.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreDeploymentCS/Program.cs" id="Snippet4":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreDeploymentVB/Program.vb" id="Snippet4":::

3. Call the static <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.AddCustomization%2A> method.

     The following code example uses the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.AddCustomization%2A> overload. This overload takes the full path of the document and a <xref:System.Uri> that specifies the location of the deployment manifest for the customization you want to attach to the document. This example assumes that a Word document named **WordDocument1.docx** is on the desktop, and that the deployment manifest is located in a folder that is named **Publish** that is also on the desktop.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreDeploymentCS/Program.cs" id="Snippet3":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreDeploymentVB/Program.vb" id="Snippet3":::

4. Build the project and run the application on the computer where you want to attach the customization. The computer must have the Visual Studio 2010 Tools for Office Runtime installed.

## See also
- [Manage documents on a server by using the ServerDocument class](../vsto/managing-documents-on-a-server-by-using-the-serverdocument-class.md)
- [How to: Remove managed code extensions from documents](../vsto/how-to-remove-managed-code-extensions-from-documents.md)
- [Application and deployment manifests in Office solutions](../vsto/application-and-deployment-manifests-in-office-solutions.md)
