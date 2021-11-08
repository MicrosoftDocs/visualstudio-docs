---
title: "Secure deployment"
description: Learn how you must provide evidence on which to base a trust decision by signing the solution with a certificate, or using the ClickOnce trust prompt key. 
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "deploying applications [Office development in Visual Studio], security"
  - "Office development in Visual Studio, security"
  - "Office applications [Office development in Visual Studio], security"
  - "ClickOnce deployment [Office development in Visual Studio], security"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Secure deployment
  When you create an Office solution, your development computer is updated automatically to allow the code in your project to run. However, when you deploy your solution, you must provide evidence on which to base a trust decision by signing the solution with a certificate, or using the [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] trust prompt key. For more information, see [Grant trust to Office solutions](../vsto/granting-trust-to-office-solutions.md).

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

 For document-level customizations, if you deploy the document to a network location, you must also add the document's location to the list of trusted locations in the Trust Center of the Office application. For more information about how to set document permissions on end-user computers, see [Grant trust to documents](../vsto/granting-trust-to-documents.md).

## Prevent Office solutions from running code
 Administrators can use the registry to prevent all Office solutions from running on a computer. When an Office solution that has managed code extensions is opened, the Visual Studio Tools for Office runtime checks whether an entry with the name `Disabled` exists under one of the following registry keys on the computer:

- **HKEY_CURRENT_USER\Software\Microsoft\VSTO**

- **HKEY_LOCAL_MACHINE\Software\Microsoft\VSTO**

  To prevent Office solutions from running code, create a `Disabled` entry under one or both of these registry keys, and specify one of the following data types and values for `Disabled`:

- A REG_SZ or REG_EXPAND_SZ that is set to any string other than "0" (zero).

- A REG_DWORD that is set to any value other than 0 (zero).

  To enable Office solutions to run code, set both of the `Disabled` entries to 0 (zero), or delete the registry entries.

## See also
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
- [Prepare computers to run or host Office solutions](/previous-versions/bb772092(v=vs.110))
- [Secure Office solutions](../vsto/securing-office-solutions.md)