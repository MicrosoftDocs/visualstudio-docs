---
title: "Permit code to run behind docs with restricted permissions"
description: Learn how you can permit code to run behind documents with restricted permissions by using Office development tools in Visual Studio.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Information Rights Management [Office development in Visual Studio]"
  - "permissions [Office development in Visual Studio]"
  - "IRM [Office development in Visual Studio]"
  - "code [Office development in Visual Studio], running behind restricted documents"
  - "documents [Office development in Visual Studio], restricted permissions"
  - "Office documents [Office development in Visual Studio, restricted permissions"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Permit code to run behind documents with restricted permissions
  You can use the Information Rights Management (IRM) feature of Microsoft Office to restrict permissions to a document or workbook. By default, the code behind a restricted Microsoft Office Word document or Microsoft Office Excel workbook is not permitted to run. You can change the default so that your managed code extensions can access the object model, and your solution will work.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

 You must be the author of the document or workbook or have Full Control access to be able to change the permission settings.

## To permit code to run behind documents with restricted permissions

1. Open the document or workbook in Word or Excel.

2. Click the **File** tab, point to **Prepare**, point to **Restrict Permission**, and then click **Restricted Access**.

   > [!NOTE]
   > On first use, you are prompted to install the Windows Rights Management client. After you install the client, you might need to repeat the steps.

3. In the **Permission** dialog box, select **Restrict permission to this document**, and then click **More Options**.

4. Under **Additional permissions for users**, select **Access content programmatically**.

   Word or Excel will permit programmatic access to the object model.

## See also
- [Information rights management and managed code extensions overview](../vsto/information-rights-management-and-managed-code-extensions-overview.md)
- [Document protection in document-level solutions](../vsto/document-protection-in-document-level-solutions.md)
- [Password protection on Office documents](../vsto/password-protection-on-office-documents.md)
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
- [Secure Office solutions](../vsto/securing-office-solutions.md)
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
