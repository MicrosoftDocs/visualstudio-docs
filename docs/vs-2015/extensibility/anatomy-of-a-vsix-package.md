---
title: "Anatomy of a VSIX Package | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "visual studio extension"
  - "vsix"
  - "packages"
ms.assetid: 8b86d62f-c274-4e91-82e0-38cdb9a423d5
caps.latest.revision: 16
ms.author: gregvanl
manager: jillfra
---
# Anatomy of a VSIX Package
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A VSIX package is a .vsix file that contains one or more Visual Studio extensions, together with the metadata Visual Studio uses to classify and install the extensions. That metadata is contained in the VSIX manifest and the [Content_Types].xml file. A VSIX package may also contain one or more Extension.vsixlangpack files to provide localized setup text, and may contain additional VSIX packages to install dependencies.  
  
 The VSIX package format follows the Open Packaging Conventions (OPC) standard. The package contains binaries and supporting files, together with a [Content_Types].xml file and a .vsix manifest file. One VSIX package may contain the output of multiple projects, or even multiple packages that have their own manifests.  
  
> [!NOTE]
> The names of the files included in VSIX packages must not include spaces, nor characters that are reserved in Uniform Resource Identifiers (URI), as defined under [\[RFC2396\]](https://go.microsoft.com/fwlink/?LinkId=90339).  
  
## The VSIX Manifest  
 The VSIX manifest contains information about the extension to be installed, and follows the VSX Schema. For more information, see [VSIX Extension Schema 1.0 Reference](https://msdn.microsoft.com/76e410ec-b1fb-4652-ac98-4a4c52e09a2b). For an example VSIX manifest, see [PackageManifest Element (Root Element, VSX Schema)](https://msdn.microsoft.com/f8ae42ba-775a-4d2b-976a-f556e147f187).  
  
 The VSIX manifest must be named `extension.vsixmanifest` when it is included in a .vsix file.  
  
## The Content  
 A VSIX package may contain templates, toolbox items, VSPackages, or any other kind of extension that is supported by Visual Studio.  
  
## Language Packs  
 A VSIX package may contain once or more Extension.vsixlangpack files to provide localized text during installation. For more information, see [Localizing VSIX Packages](../extensibility/localizing-vsix-packages.md).  
  
## Dependencies and References  
 A VSIX package may contain other VSIX packages as references. Each of these other packages must include its own VSIX manifest.  
  
 If a user tries to install an extension that has dependencies, the installer verifies that the required assemblies are installed on the user system. If the required assemblies are not found, **Extensions and Updates** displays a list of the missing assemblies.  
  
 If the extension manifest includes one or more [Reference](https://msdn.microsoft.com/32c52934-e81e-4b53-8cb6-4df45ef7bfa8) elements, **Extensions and Updates** compares the manifest of each reference to the extensions that are installed on the system, and installs the referenced extension if it is not already installed. If an earlier version of a referenced extension is installed, the newer version replaces it.  
  
 If a project in a multi-project solution includes a reference to another project in the same solution, the VSIX package includes the dependencies of that project. You can override this behavior by clicking the reference for the internal project, and then, in the **Properties** window, setting the **Output Groups Included in VSIX** property to `BuiltProjectOutputGroup`.  
  
 To include satellite DLLs from referenced assemblies in the VSIX package, add `SatelliteDllsProjectOutputGroup` to the **Output Groups Included in VSIX** property.  
  
## Installation Location  
 During installation, **Extensions and Updates** looks for the contents of the VSIX package in a folder under %LocalAppData%\Microsoft\VisualStudio\14.0\Extensions.  
  
 By default, the installation applies only to the current user, because %LocalAppData% is a user-specific directory. However, if you set the [AllUsers](https://msdn.microsoft.com/ac817f50-3276-4ddb-b467-8bbb1432455b) element of the manifest to `True`, the extension will be installed under ..\\*VisualStudioInstallationFolder*\Common7\IDE\Extensions and will be available to all users of the computer.  
  
## [Content_Types].xml  
 The [Content_Types].xml file identifies the file types in the expanded .vsix file. Visual Studio uses this file during installation of the package but does not install the file itself. For more information about this file, see [The Structure of the Content_types\].xml File](../extensibility/the-structure-of-the-content-types-dot-xml-file.md).  
  
 A [Content_Types].xml file is required by the Open Packaging Conventions (OPC) standard. For more information about OPC, see [OPC: A New Standard For Packaging Your Data](https://go.microsoft.com/fwlink/?LinkID=148207) on the MSDN Web site.
