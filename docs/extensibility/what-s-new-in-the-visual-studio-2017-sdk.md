---
title: What&apos;s New in the Visual Studio 2017 SDK | Microsoft Docs
description: The Visual Studio SDK has new and updated features for Visual Studio 2017, including the updated VSIX version 3 format.
ms.custom: SEO-VS-2020
ms.date: 10/31/2017
ms.topic: conceptual
ms.assetid: 9efcf0a3-dbde-4cab-8ed3-425826a48b2e
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# What&#39;s New in the Visual Studio 2017 SDK

The Visual Studio SDK has the following new and updated features for Visual Studio 2017.

## VSIX v3 format

To support the new light-weight install of Visual Studio 2017, the VSIX extension manifest format has been updated to version 3 (VSIX v3).

The new format has support for:

* Explicitly declaring prerequisites to be detected and installed by the VSIXInstaller.
* Ngen assemblies on extension installation.
* Installing assets outside the usual extension root.

To learn about these changes, see the following topics:

* [Changes to extensibility for Visual Studio 2017](breaking-changes-2017.md)
* [Ngen support in VSIX v3](ngen-support.md)
* [Install outside the extensions folder](set-install-root.md)
* [Frequently asked questions for Visual Studio 2017 extensibility](faq-2017.yml)

## Migrate extensibility project to Visual Studio 2017

To learn how to update your extensibility projects and their VSIX manifests to Visual Studio 2017, see [How to: Migrate extensibility projects to Visual Studio 2017](how-to-migrate-extensibility-projects-to-visual-studio-2017.md).

## Custom project and item templates

Starting in Visual Studio 2017, scanning for custom project and item templates will no longer be performed. Instead, the extension must provide template manifest files that describe the install location of these templates. You can use Visual Studio 2017 to update your VSIX extensions. If you deploy your extension using an MSI, you must generate the template manifest files by hand. For more information, see [Upgrade custom project and item templates for Visual Studio 2017](../extensibility/upgrading-custom-project-and-item-templates-for-visual-studio-2017.md). The template manifest schema is documented in [Visual Studio template manifest schema reference](../extensibility/visual-studio-template-manifest-schema-reference.md).

## Updated extension performance guidelines

There is a new [How to: Diagnose extension performance](how-to-diagnose-extension-performance.md) article under [Manage VSPackages](managing-vspackages.md) to show how to detect and analyze extension impact on Visual Studio startup and solution load times.
