---
title: Authoring a Windows Installer Package | Microsoft Docs
description: Learn how to author a Windows Installer package for Visual Studio that consists of database tables containing file and registry data.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- .msi files, VSPackages
- msi files, VSPackages
ms.assetid: 0ce7c21d-0d3f-47fe-a0bb-eed506e32609
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Author a Windows Installer package
Data drives the Windows Installer model. Rather than writing a procedural script to copy files and write registry entries, for example, you author rows and columns in database tables that contain file and registry data.

## Database entries
To install a VSPackage, a Windows Installer package must contain database entries to perform the following tasks:

- Search the system to locate the versions of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] your VSPackage supports (using Windows Installer tables that include AppSearch, CompLocator, RegLocator, DrLocator, and Signature).

- Cancel the installation if no supported version of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] is installed or if another system requirement of the VSPackage is not met (using the LaunchCondition table).

- Install the VSPackage and dependent files (using the directory, component, and file tables).

- Add appropriate information for the VSPackage to the registry (using the Registry table).

- Integrate the VSPackage in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] by calling **devenv.exe /setup** (using the CustomAction table).

For more information, see [Windows Installer](/windows/desktop/Msi/windows-installer-portal).

## Setup tools
A variety of third-party setup tools provide a development environment for Windows Installer packages. The following free tools are available:

- InstallShield limited edition

   You can get a limited version of InstallShield through the Visual Studio **New Project** dialog. Expand **Other Project Types** and then select **Setup and Deployment**. Select the InstallShield template.

- Windows Installer XML toolset

   The Windows Installer XML (WiX) toolset builds Windows Installer packages from XML source files. The WiX toolset is a Microsoft open-source project. You can download the source code and executables from [Wix toolset](https://sourceforge.net/projects/wix/).

   For commercial products that integrate into [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] by using the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)], see [Visual Studio Marketplace](https://marketplace.visualstudio.com/).

## See also
- [Install VSPackages With Windows Installer](../../extensibility/internals/installing-vspackages-with-windows-installer.md)
