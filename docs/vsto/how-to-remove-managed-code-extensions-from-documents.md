---
title: "How to: Remove managed code extensions from documents"
description: Programmatically remove the customization assembly from a document or workbook that is part of a document-level customization for Microsoft Word or Excel.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "managed code extensions [Office development in Visual Studio], removing"
  - "documents [Office development in Visual Studio], managed code extensions"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Remove managed code extensions from documents
  You can programmatically remove the customization assembly from a document or workbook that is part of a document-level customization for Microsoft Office Word or Microsoft Office Excel. Users can then open the documents and view the contents, but any custom user interface (UI) you add to the documents will not appear, and your code will not run.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

 You can remove the customization assembly by using one of the `RemoveCustomization` methods provided by the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)]. Which method you use depends on whether you want to remove the customization at run time (that is, by running code in the customization while the Word document or Excel workbook is open), or if you want to remove the customization from a closed document or a document that is on a server that does not have Microsoft Office installed.

## To remove the customization assembly at run time

1. In your customization code, call the <xref:Microsoft.Office.Tools.Word.Document.RemoveCustomization%2A> method (for Word) or the <xref:Microsoft.Office.Tools.Excel.Workbook.RemoveCustomization%2A> method (for Excel). This method should be called only after the customization is no longer needed.

     Where you call this method in your code depends on how your customization is used. For example, if customers use your customization's features until they are ready to send the document to other clients that only need to the document itself (not the customization), you can provide some UI that calls `RemoveCustomization` when the customer clicks it. Alternatively, if your customization populates the document with data when it is first opened, but the customization doesn't provide any other features that are accessed directly by customers, then you can call RemoveCustomization as soon as your customization finishes initializing the document.

## To remove the customization assembly from a closed document or a document on a server

1. In a project that does not require Microsoft Office, such as a console application or Windows Forms project, add a reference to the *Microsoft.VisualStudio.Tools.Applications.ServerDocument.dll* assembly.

2. Add the following **Imports** or **using** statement to the top of your code file.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreDeploymentCS/Program.cs" id="Snippet1":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreDeploymentVB/Program.vb" id="Snippet1":::

3. Call the static <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.RemoveCustomization%2A> method of the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class, and specify the solution document path for the parameter.

     The following code example assumes that you are removing the customization from a document named *WordDocument1.docx* that is on the desktop.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreDeploymentCS/Program.cs" id="Snippet2":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreDeploymentVB/Program.vb" id="Snippet2":::

4. Build the project and run the application on the computer where you want to remove the customization. The computer must have the Visual Studio 2010 Tools for Office runtime installed.

## See also
- [Manage documents on a server by using the ServerDocument class](../vsto/managing-documents-on-a-server-by-using-the-serverdocument-class.md)
- [How to: Attach Managed code extensions to documents](../vsto/how-to-attach-managed-code-extensions-to-documents.md)
