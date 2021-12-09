---
title: "Upgrade and migrate Office solutions"
description: You must upgrade the project to use it in current versions of Visual Studio if you have an Office project that was created in an earlier version of Visual Studio.
ms.custom: SEO-VS-2020
ms.date: "08/14/2019"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office applications [Office development in Visual Studio], upgrading"
  - "Office projects [Office development in Visual Studio], upgrading"
  - "upgrading applications [Office development in Visual Studio]"
  - "upgrading Office solutions in Visual Studio"
  - "migrating Office solutions in Visual Studio"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Upgrade and migrate Office solutions
  If you have a Microsoft Office project that was created in an earlier version of Visual Studio, you must upgrade the project to use it in current versions of Visual Studio. To upgrade a Microsoft Office project, open it in a version of Visual Studio that includes the Microsoft Office developer tools. For more information about the versions of Visual Studio that include the Microsoft Office developer tools, see [Configure a computer to develop Office solutions](../vsto/configuring-a-computer-to-develop-office-solutions.md).

[!include[Add-ins note](includes/addinsnote.md)]

> [!NOTE]
> Visual Studio cannot upgrade InfoPath form template projects that were created by using previous versions of Visual Studio. These types of projects are not supported in the current release of Visual Studio.

## Changes to upgraded projects
 When you upgrade a Microsoft Office project, Visual Studio modifies the project to target the following items:

- The Visual Studio 2010 Tools for Office runtime. For more information, see [Visual Studio Tools for Office runtime overview](../vsto/visual-studio-tools-for-office-runtime-overview.md).

- The current assembly references.

- A version of the .NET Framework that is supported by the project type (When you upgrade to Visual Studio 2013 only).

- A version of Microsoft Office that is supported by the project type (When you upgrade to Visual Studio 2013 only).

## Assembly references
 Visual Studio upgrades the following assembly references in the project:

- Microsoft Office primary interop assemblies (PIAs).

- Assemblies in the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)]. For more information about these assemblies, see [Visual Studio Tools for Office runtime overview](../vsto/visual-studio-tools-for-office-runtime-overview.md).

- New or updated versions of dependent assemblies.

## Targeted .NET Framework
 When you upgrade a project to Visual Studio 2013, Visual Studio modifies the project to target either the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)] or the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)]. The version of the .NET framework targeted by the project depends on what version of Office is installed on your computer. If [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)] is installed, Visual Studio modifies the project to target the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)]. Otherwise, Visual Studio modifies the project to target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)].

> [!NOTE]
> You might need to perform some additional steps to run a retargeted solution on development and end-user computers, and your project will no longer compile if it uses certain features. For more information, see [Migrate Office solutions to the .NET Framework 4 or later](../vsto/migrating-office-solutions-to-the-dotnet-framework-4-or-later.md).

 If you target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later in an Office project, you can use some features that are not available when you target the .NET Framework 3.5. For more information, see [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md).

## Targeted Office application
 When you upgrade an Office project to Visual Studio 2013, Visual Studio modifies the project to target a version of the Microsoft Office that is supported by the project type, such as a document-level customization project or VSTO Add-in project.

 Office projects in Visual Studio 2013 can target [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)] and [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)] applications. Visual Studio modifies the project to target the latest version of office that you have installed. If none of these versions of Office are installed, Visual Studio does not upgrade the project.

> [!NOTE]
> If you upgrade a VSTO Add-in project to target [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)] or later, make sure that the `ThisAddIn_Startup` event handler of the VSTO Add-in doesn't contain code that accesses a document in the application. For more information, see [Access a document when the Office application starts](../vsto/programming-vsto-add-ins.md#AccessingDocuments).

 For document-level customizations, [!INCLUDE[vs_current_short](../sharepoint/includes/vs-current-short-md.md)] converts documents in a project that have a binary format, such as documents that have an *.xls* or *.doc* extension, to the Office Open XML format. For more information about Open XML, see [Introduction to new file name extensions and Open XML formats](https://support.office.com/en-nz/article/Introduction-to-new-file-name-extensions-eca81dcb-5626-4e5b-8362-524d13ae4ec1).

> [!NOTE]
> Smart tags are deprecated in Excel 2010 and Word 2010. Therefore, if your solution uses smart tags, you must remove them before you can test and debug it in Visual Studio 2013 or Visual Studio 2015.

## Upgrade Microsoft Office 2003 projects
 There are some additional considerations for upgrading document-level customizations and VSTO Add-ins that target Microsoft Office 2003.

### Document-level projects
 If the document in the project contains Windows Forms controls, you must also have the Visual Studio 2005 Tools for Office Second Edition Runtime installed before you upgrade the project. If this version of the runtime is not installed on the development computer before you upgrade the project, the upgraded project might contain compile or run time errors. After you finish upgrading the project, you can uninstall the Visual Studio 2005 Tools for Office Second Edition Runtime from the development computer if it is not being used by any other Office solutions. This version of the runtime is available as a redistributable package from the Microsoft Download Center at Microsoft Visual Studio 2005 Tools for Office Second Edition Runtime (VSTO 2005 SE) (x86).

### VSTO Add-in projects
 If the solution file for your original project included a Setup or InstallShield Limited Edition project that was configured to install the VSTO Add-in, Visual Studio upgrades the project, but it does not make any further changes to the project. If you want to keep using a Windows Installer file to deploy your VSTO Add-in, you must modify the Setup or InstallShield Limited Edition project to install new pre-requisites such as the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)], the Visual Studio 2010 Tools for Office Runtime, and optionally the primary interop assemblies referenced by your VSTO Add-in. For more information, see [Deploy an Office solution by using Windows Installer](../vsto/deploying-a-vsto-solution-by-using-windows-installer.md).

 If you want to use ClickOnce to deploy your VSTO Add-in, you can delete the Setup or InstallShield Limited Edition project entirely. For more information about deploying VSTO Add-ins by using ClickOnce, see [Deploy an Office solution](../vsto/deploying-an-office-solution.md).

## See also
- [How to: Upgrade Office solutions](/previous-versions/4bez6837(v=vs.140))
- [Migrate Office solutions to the .NET Framework 4 or later](../vsto/migrating-office-solutions-to-the-dotnet-framework-4-or-later.md)
- [Project Upgrade, Options dialog box](../vsto/project-upgrade-options-dialog-box.md)