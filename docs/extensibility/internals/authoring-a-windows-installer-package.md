---
title: Authoring a Windows Installer Package
description: Learn how to author a Windows Installer package for Visual Studio that consists of database tables containing file and registry data.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- .msi files, VSPackages
- msi files, VSPackages
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Author a Windows Installer package

Data drives the Windows Installer model. Rather than writing a procedural script to copy files and write registry entries, for example, you author rows and columns in database tables that contain file and registry data.

## Database entries
To install a VSPackage, a Windows Installer package must contain database entries to perform the following tasks:

- Search the system to locate the versions of Visual Studio your VSPackage supports (using Windows Installer tables that include AppSearch, CompLocator, RegLocator, DrLocator, and Signature).

- Cancel the installation if no supported version of Visual Studio is installed or if another system requirement of the VSPackage is not met (using the LaunchCondition table).

- Install the VSPackage and dependent files (using the directory, component, and file tables).

- Add appropriate information for the VSPackage to the registry (using the Registry table).

- Integrate the VSPackage in Visual Studio by calling **devenv.exe /setup** (using the CustomAction table).

For more information, see [Windows Installer](/windows/desktop/Msi/windows-installer-portal).

## Setup tools
A variety of third-party setup tools provide a development environment for Windows Installer packages. The following free tools are available:

- InstallShield limited edition

   You can get a limited version of InstallShield through the Visual Studio **New Project** dialog. Expand **Other Project Types** and then select **Setup and Deployment**. Select the InstallShield template.

- Windows Installer XML toolset

   The Windows Installer XML (WiX) toolset builds Windows Installer packages from XML source files. The WiX toolset is a Microsoft open-source project. You can download the source code and executables from [Wix toolset](https://sourceforge.net/projects/wix/).

   For commercial products that integrate into Visual Studio by using the Visual Studio SDK, see [Visual Studio Marketplace](https://marketplace.visualstudio.com/).

## Related content
- [Install VSPackages With Windows Installer](../../extensibility/internals/installing-vspackages-with-windows-installer.md)
