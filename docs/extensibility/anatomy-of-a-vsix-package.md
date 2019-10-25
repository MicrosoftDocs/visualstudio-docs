---
title: "Anatomy of a VSIX Package | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "visual studio extension"
  - "vsix"
  - "packages"
ms.assetid: 8b86d62f-c274-4e91-82e0-38cdb9a423d5
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Anatomy of a VSIX package
A VSIX package is a *.vsix* file that contains one or more Visual Studio extensions, together with the metadata Visual Studio uses to classify and install the extensions. That metadata is contained in the VSIX manifest and the *[Content_Types].xml* file. A VSIX package may also contain one or more *Extension.vsixlangpack* files to provide localized setup text, and may contain additional VSIX packages to install dependencies.

 The VSIX package format follows the Open Packaging Conventions (OPC) standard. The package contains binaries and supporting files, together with a *[Content_Types].xml* file and a *.vsix* manifest file. One VSIX package may contain the output of multiple projects, or even multiple packages that have their own manifests.

> [!NOTE]
> The names of the files included in VSIX packages must not include spaces, nor characters that are reserved in Uniform Resource Identifiers (URI), as defined under [\[RFC2396\]](https://www.rfc-editor.org/rfc/rfc2396.txt).

## The VSIX manifest
 The VSIX manifest contains information about the extension to be installed, and follows the VSX Schema. For more information, see [VSIX extension schema 1.0 reference](https://msdn.microsoft.com/library/76e410ec-b1fb-4652-ac98-4a4c52e09a2b). For an example VSIX manifest, see [PackageManifest element (root element, VSX schema)](https://msdn.microsoft.com/library/f8ae42ba-775a-4d2b-976a-f556e147f187).

 The VSIX manifest must be named `extension.vsixmanifest` when it is included in a ^.vsix* file.

## The content
 A VSIX package may contain templates, toolbox items, VSPackages, or any other kind of extension that is supported by Visual Studio.

## Language packs
 A VSIX package may contain once or more *Extension.vsixlangpack* files to provide localized text during installation. For more information, see [Localizing VSIX packages](../extensibility/localizing-vsix-packages.md).

## Dependencies and references
 A VSIX package may contain other VSIX packages as references. Each of these other packages must include its own VSIX manifest.

 If a user tries to install an extension that has dependencies, the installer verifies that the required assemblies are installed on the user system. If the required assemblies are not found, **Extensions and Updates** displays a list of the missing assemblies.

 If the extension manifest includes one or more [Reference](/previous-versions/visualstudio/visual-studio-2010/dd393687(v=vs.100)) elements, **Extensions and Updates** compares the manifest of each reference to the extensions that are installed on the system, and installs the referenced extension if it is not already installed. If an earlier version of a referenced extension is installed, the newer version replaces it.

 If a project in a multi-project solution includes a reference to another project in the same solution, the VSIX package includes the dependencies of that project. You can override this behavior by clicking the reference for the internal project, and then, in the **Properties** window, setting the **Output Groups Included in VSIX** property to `BuiltProjectOutputGroup`.

 To include satellite DLLs from referenced assemblies in the VSIX package, add `SatelliteDllsProjectOutputGroup` to the **Output Groups Included in VSIX** property.

## Installation location
 During installation, **Extensions and Updates** looks for the contents of the VSIX package in a folder under *%LocalAppData%\Microsoft\VisualStudio\14.0\Extensions*.

 By default, the installation applies only to the current user, because *%LocalAppData%* is a user-specific directory. However, if you set the [AllUsers](https://msdn.microsoft.com/library/ac817f50-3276-4ddb-b467-8bbb1432455b) element of the manifest to `True`, the extension will be installed under <em>..\\</em>VisualStudioInstallationFolder<em>\Common7\IDE\Extensions</em> and will be available to all users of the computer.

## [Content_Types].xml
 The *[Content_Types].xml* file identifies the file types in the expanded *.vsix* file. Visual Studio uses this file during installation of the package but does not install the file itself. For more information about this file, see [The structure of the [Content_types].xml file](the-structure-of-the-content-types-dot-xml-file.md).

 A *[Content_Types].xml* file is required by the Open Packaging Conventions (OPC) standard. For more information about OPC, see [OPC: A new standard for packaging your data](https://blogs.msdn.microsoft.com/msdnmagazine/2007/08/08/opc-a-new-standard-for-packaging-your-data/) on the MSDN Web site.