---
title: Windows Installer Basics
description: Learn about Windows Installer for use in installing a VSPackage, including organizing your VSPackage features into Windows Installer components.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- Windows Installer, VSPackages
- VSPackages, Windows Installer basics
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Windows Installer Basics

The Windows Installer installs and uninstalls applications or software products on a user's computer, performing these tasks in units called Windows Installer components (sometimes called WICs or just components). A GUID identifies each WIC, which is the basic unit of installation and reference counting for setups using Windows Installer.

 For comprehensive documentation of the Windows Installer, see the Platform SDK topic, [Windows Installer](/previous-versions/2kt85ked(v=vs.120)).

## Authoring a VSPackage
 Windows Installer uses installation packages, which contain information that Windows Installer needs to install, uninstall, or repair a product and to run the setup user interface (UI). Each installation package includes an .msi file, which contains an installation database, a summary information stream, and data streams for various parts of the installation. To use the installer, you must author an installation. Because the installer organizes installations around the concept of components and stores information about the installation in a relational database, the process of authoring an installation package broadly entails the following steps:

1. Plan your setup authoring to support your versioning and side-by-side strategies.

2. Identify the features to be presented to users.

3. Organize the VSPackage and dependencies into components.

4. Populate the installation database with information.

5. Validate the installation package.

   This documentation is concerned primarily with the first and third steps of the process. During these steps you organize your VSPackage features into WICs so you can frame your versioning and servicing strategy to account for subsequent versions of Visual Studio. The remaining three steps are covered in detail in Windows Installer documentation in the Platform SDK.

## Key Terms
 Following are definitions of key terms related to the Windows Installer technology.

 Resource
 Files, registry keys, shortcuts, or and so on that may be installed to a computer. These resources are grouped logically into Windows Installer components.

 Windows Installer component (WIC)
 The basic unit of installation representing a logical grouping of related resources that are installed and uninstalled as a unit. Windows Installer components are identified by a unique component ID, or GUID. Furthermore, Windows Installer maintains its reference counting at the WIC level. For maximum versioning flexibility, include no more than one primary resource, such as a DLL, in a given WIC. Note that after you identify and populate a WIC, give it a GUID, and deploy it, you cannot change its composition. For more information, see [Organizing Applications into Components](/windows/desktop/Msi/organizing-applications-into-components).

 Package (Redist package)
 A unit of deployment that consists of an .msi file and external source files to which this file might point. A package contains all the information that Windows Installer needs to run the UI and to install or uninstall the application.

 .msi File
 A COM-structured storage file containing the instructions and data required to install an application. Every package contains at least one .msi file. The .msi file contains the installer database, a summary information stream, and possibly one or more transforms and internal source files. Files to be installed can either be compressed into a cabinet and stored in a stream in the .msi file or stored, compressed, or uncompressed, outside the .msi file on the source medium. For more information, see [Windows Installer File Extensions](/windows/desktop/Msi/windows-installer-file-extensions).

## Windows Installer Rules Enforcement
 Two sets of rules determine the deployment of resources through your setup's components. One rule set is maintained by the Windows Installer itself, while you should enforce the second set as installation author.

> [!NOTE]
> Enforcement of Windows Installer rules occurs only if you run a validation of your .msi file. Nevertheless, you are cautioned to treat these rules as best practices. For more information, see [Validating an Installation Database](/windows/desktop/Msi/validating-an-installation-database) and [Package Validation](/windows/desktop/Msi/package-validation).

#### Installer-Enforced Rules

- All files in a given component must be installed to the same directory. Conversely, files installed to separate folders must belong to separate components.

- There can be only one key path per component. The key path is simply a file or registry key that represents the entire component.

#### Component-Provider Responsibilities

- Any two resources that might ship separately in subsequent versions should exist in separate components. Resources should be grouped into the same component only when you are certain that these resources will never ship separately. In fact, it is recommended that all primary resources (DLLs, for example) always exist in separate WICs. For more information, see [Defining Installer Components](/windows/desktop/Msi/defining-installer-components).

- No versioned resource should ever ship in more than one WIC.

## Related content
- [What Happens if the Component Rules Are Broken?](/windows/desktop/Msi/what-happens-if-the-component-rules-are-broken)
