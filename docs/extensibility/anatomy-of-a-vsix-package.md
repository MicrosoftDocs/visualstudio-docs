---
title: What is a Visual Studio VSIX package file?
description: Explore the contents of a VSIX package file in Visual Studio, which contains one or more Visual Studio extensions and a metadata manifest file. 
ms.date: 02/02/2024
ms.topic: conceptual
helpviewer_keywords:
- visual studio extension
- vsix
- packages
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Anatomy of a VSIX package

A VSIX package is a `.vsix` file that contains one or more Visual Studio extensions, together with the metadata Visual Studio uses to classify and install the extensions. That metadata is contained in the VSIX manifest and the *[Content_Types].xml* file. A VSIX package may also contain one or more *Extension.vsixlangpack* files to provide localized setup text, and may contain additional VSIX packages to install dependencies.

 The VSIX package format follows the Open Packaging Conventions (OPC) standard. The package contains binaries and supporting files, together with a *[Content_Types].xml* file and a `.vsix` manifest file. One VSIX package may contain the output of multiple projects, or even multiple packages that have their own manifests.

> [!NOTE]
> The names of the files included in VSIX packages must not include spaces, nor characters that are reserved in Uniform Resource Identifiers (URI), as defined under [\[RFC2396\]](https://www.rfc-editor.org/rfc/rfc2396.txt).

## The VSIX manifest

The VSIX manifest contains information about the extension to be installed, and follows the VSIX Schema. For more information, see [VSIX extension schema 2.0 reference](vsix-extension-schema-2-0-reference.md).

 The VSIX manifest must be named `extension.vsixmanifest` when it's included in a `.vsix` file.

## The content

 A VSIX package may contain templates, toolbox items, VSPackages, or any other kind of extension that is supported by Visual Studio.

## Language packs

 A VSIX package may contain once or more *Extension.vsixlangpack* files to provide localized text during installation. For more information, see [Localizing VSIX packages](../extensibility/localizing-vsix-packages.md).

## Dependencies and references

 A VSIX package may contain other VSIX packages as references. Each of these other packages must include its own VSIX manifest.

 If a user tries to install an extension that has dependencies, the installer verifies that the required assemblies are installed on the user system. If the required assemblies aren't found, **Extensions and Updates** displays a list of the missing assemblies.

 If the extension manifest includes one or more [Dependency](vsix-extension-schema-2-0-reference.md#dependencies-element) elements, **Extensions and Updates** compares the manifest of each reference to the extensions that are installed on the system, and installs the referenced extension if it isn't already installed. If an earlier version of a referenced extension is installed, the newer version replaces it.

 If a project in a multi-project solution includes a reference to another project in the same solution, the VSIX package includes the dependencies of that project. You can override this behavior by selecting the reference for the internal project, and then, in the **Properties** window, setting the **Output Groups Included in VSIX** property to `BuiltProjectOutputGroup`.

 To include satellite DLLs from referenced assemblies in the VSIX package, add `SatelliteDllsProjectOutputGroup` to the **Output Groups Included in VSIX** property.

## Installation location

 During installation, **Extensions and Updates** looks for the contents of the VSIX package in a folder under `%LocalAppData%\Microsoft\VisualStudio\{version}\Extensions`.

 By default, the installation applies only to the current user, because *%LocalAppData%* is a user-specific directory. However, if you set the `AllUsers` element of the manifest to `True`, the extension will be installed under `..\{VisualStudioInstallationFolder}\Common7\IDE\Extensions` and will be available to all users of the computer.

## [Content_Types].xml

 The *[Content_Types].xml* file identifies the file types in the expanded `.vsix` file. Visual Studio uses this file during installation of the package but doesn't install the file itself. For more information about this file, see [The structure of the [Content_types].xml file](the-structure-of-the-content-types-dot-xml-file.md).

 A *[Content_Types].xml* file is required by the Open Packaging Conventions (OPC) standard. For more information about OPC, see [OPC: A new standard for packaging your data](/archive/blogs/msdnmagazine/opc-a-new-standard-for-packaging-your-data).
