---
title: Shipping Visual Studio Extensions
description: Learn how to publish and maintain your Visual Studio SDK extension, including working with .vsix files, publishing, localizing, and updating.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- VSIX deployment
- deployment, VSIX
- satellite DLLs, in VSIX packages
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Shipping Visual Studio Extensions

After you've finished developing your extension, you can install it on other machines, share it with your friends and coworkers, or publish it on the Visual Studio Marketplace. In this section we explain all the things you need to do in order to publish and maintain your extension: working with .vsix files, publishing, localizing, and updating.

## Working with VSIX Extensions
 You can create a VSIX extensions by creating a blank VSIX Project, and then adding different item templates to it. For more information, see [VSIX Project Template](../extensibility/vsix-project-template.md).

 You can use the VSIX format to package project templates, item templates, VSPackages, Managed Extensibility Framework (MEF) components, **Toolbox** controls, assemblies, and custom types (this includes custom Start Pages for Visual Studio 2017). The VSIX format uses file-based deployment. For more information about VSIX packages, see [Anatomy of a VSIX Package](../extensibility/anatomy-of-a-vsix-package.md).

 The VSIX format does not support the installation of code snippets. It also does not support certain other scenarios such as writing to the Global Assembly Cache (GAC) or to the system registry. If you need to write to the GAC or the registry in the installation, you must use the Windows Installer. For more information, see [Preparing Extensions for Windows Installer Deployment](../extensibility/preparing-extensions-for-windows-installer-deployment.md).

## Publishing your Extension to the Visual Studio Marketplace
 You can distribute your extension to other people simply by mailing them the .vsix file or putting in on a server. But the best way to get your code in the hands of a lot of people is to put it on the [Visual Studio Marketplace](https://marketplace.visualstudio.com/vs). Visual Studio Marketplace extensions are available to Visual Studio users through **Extensions and Updates**. For more information, see [Finding and Using Visual Studio Extensions](../ide/finding-and-using-visual-studio-extensions.md).

 For a full example that shows how to upload an extension to the Visual Studio Marketplace, see [Walkthrough: Publishing a Visual Studio Extension](../extensibility/walkthrough-publishing-a-visual-studio-extension.md).

## Private Galleries
 As you develop controls, templates, and tools, you can share them with your organization by posting them to a private gallery on your intranet. For more information, see [Private Galleries](../extensibility/private-galleries.md).

## Localizing your Extension
 If you're planning to release your extension in different locales, you should consider localizing it. For an explanation of what's involved, see [Localizing VSIX Packages](../extensibility/localizing-vsix-packages.md).

## Updating and Versioning your Extension
 After you've published your extension, there will come a time when you need to update it. To find out how to update an extension that has been published on the Visual Studio Marketplace, see [How to: Update an Extension](../extensibility/how-to-update-a-visual-studio-extension.md).

 You can set your extension to support multiple versions of Visual Studio. For more information, see [Supporting Multiple Versions of Visual Studio](../extensibility/supporting-multiple-versions-of-visual-studio.md).

## Related Topics

|Title|Description|
|-----------|-----------------|
|[Getting Started with the VSIX Project Template](../extensibility/getting-started-with-the-vsix-project-template.md)|Explains how to use the VSIX project template to install a custom project template.|
|[Anatomy of a VSIX Package](../extensibility/anatomy-of-a-vsix-package.md)|Describes the components of a VSIX package.|
|[VSIX Project Template](../extensibility/vsix-project-template.md)|Provides step-by-step instructions about how to package and publish an extension.|
|[Localizing VSIX Packages](../extensibility/localizing-vsix-packages.md)|Explains how to provide localized text for the installation process by using extension.vsixlangpack files.|
|[How to: Update an Extension](../extensibility/how-to-update-a-visual-studio-extension.md)|Describes how to update an extension on your system and how to deploy an update to an existing Visual Studio extension.|
|[How to: Add a Dependency to a VSIX Package](../extensibility/how-to-add-a-dependency-to-a-vsix-package.md)|Describes how to add references to VSIX deployment packages.|
|[Preparing Extensions for Windows Installer Deployment](../extensibility/preparing-extensions-for-windows-installer-deployment.md)|Explains how to deploy your extension with Windows Installer.|
|[Signing VSIX Packages](../extensibility/signing-vsix-packages.md)|Explains how to sign VSIX packages.|
|[Private Galleries](../extensibility/private-galleries.md)|Explains how to create private galleries for extensions.|
|[Supporting Multiple Versions of Visual Studio](../extensibility/supporting-multiple-versions-of-visual-studio.md)|Shows how to have your extension support multiple versions of Visual Studio.|
|[Locating Visual Studio](locating-visual-studio.md)|Describes how to locate Visual Studio instances for custom extension deployment.|
