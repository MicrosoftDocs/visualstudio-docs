---
title: "What&#39;s New in the Visual Studio 2017 SDK | Microsoft Docs"
ms.custom: ""
ms.date: "11/09/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9efcf0a3-dbde-4cab-8ed3-425826a48b2e
caps.latest.revision: 1
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
---
# What&#39;s New in the Visual Studio 2017 SDK

The Visual Studio SDK has the following new and updated features for Visual Studio 2017.

## VSIX v3 format

To support the new light-weight install of Visual Studio 2017, the VSIX extension manifest format has been updated to version 3 (VSIX v3).

The new format has support for:

* Explicitly declaring prerequisites to be detected and installed by the VSIXInstaller.
* Ngen'ing assemblies on extension installation.
* Installing assets outside the usual extension root.

To learn about these changes, see the following topics:

* [Changes to extensibility for 2017](breaking-changes-2017.md)
* [Ngen support in VSIX v3](ngen-support.md)
* [Installing outside the extensions folder](set-install-root.md)
* [Frequently Asked Questions for Visual Studio 2017 extensibility](faq-2017.md)

## Migrating extensibility project to Visual Studio 2017

To learn how to update your extensibility projects and their VSIX manifests to Visual Studio 2017, see [How to: Migrate Extensibility Projects to Visual Studio 2017](how-to-migrate-extensibility-projects-to-visual-studio-2017.md).

## Lightweight Solution Load (LSL)

Lightweight Solution Load is a new feature in VS 2017 which will significantly reduce solution load time, enabling you to be more productive more quickly. When LSL is enabled, Visual Studio will not fully load projects until you start working with them.

LSL may affect Visual Studio extensions. Extensions whose features depend on a project being fully loaded may not work or work incorrectly. See [Lightweight Solution Load](lightweight-solution-load-extension-impact.md) to learn whether your extension may be impacted and get guidance on updating your extension.

## Custom project and item templates

Starting in Visual Studio 2017, scanning for custom project and item templates will no longer be performed. Instead, the extension must provide template manifest files that describe the install location of these templates. You can use Visual Studio 2017 to update your VSIX extensions. If you deploy your extension using an MSI, you must generate the template manifest files by hand. For more information, see [Upgrading Custom Project and Item Templates for Visual Studio 2017](../extensibility/upgrading-custom-project-and-item-templates-for-visual-studio-2017.md). The template manifest schema is documented in [Visual Studio Template Manifest Schema Reference](../extensibility/visual-studio-template-manifest-schema-reference.md).

## Updated Extension Performance Guidelines

There is a new [How to: Diagnose extension performance](how-to-diagnose-extension-performance.md) topic under [Managing VSPackages](managing-vspackages.md) to show how to detect and analyze extension impact on Visual Studio startup and solution load times.
