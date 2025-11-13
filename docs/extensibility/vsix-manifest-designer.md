---
title: VSIX Manifest Designer
description: Learn how the VSIX Manifest Designer modifies a VSIX package manifest file, which sets the installation behavior for a Visual Studio extension.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VS.Sdk.VsixManifestEditor
helpviewer_keywords:
- vsixmanifest
- vsix manifest
- manifest designer
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# VSIX Manifest Designer

Modifies a VSIX package manifest file, which sets the installation behavior for a Visual Studio extension.

The **VSIX Manifest Designer** maps to the underlying VSIX schema. Every element in the schema can be set by using a corresponding control in the designer. For more information about the schema, see [VSIX Extension Schema 2.0 Reference](../extensibility/vsix-extension-schema-2-0-reference.md).

To open the **VSIX Manifest Designer**, locate a *source.extension.vsixmanifest* file in **Solution Explorer**, and open the file. If the file does not contain valid XML, the manifest designer won't open.

> [!NOTE]
> The *source.extension.vsixmanifest* file is output to *extension.vsixmanifest* when the package is built.

## UIElement list
The **VSIX Manifest Designer** contains four sections that correspond to these top-level elements of the schema:

- Metadata
- Install Targets
- Assets
- Dependencies

The heading area contains the following controls:

- **Product Name** describes the extension name.
- **Product ID** specifies the unique identification information for this package.
- **Author** specifies the name of the author of the extension.
- **Version** specifies the version number of the extension.

The **Metadata** tab contains the following controls:

- **Description** provides a text description of the extension, to be displayed in **Extension Manager**.
- **Language** specifies the default language for the package, which corresponds to the textual data in the manifest. The `Language` attribute follows the common language runtime (CLR) locale code convention for resource assemblies, for example, en-us, en, fr-fr. By default, the value is neutral, which means the package will run on any language version of Visual Studio.
- **License** specifies the text file that contains the user license, if one is present.
- **Icon** specifies the graphics file (*.png*, *.bmp*, *.jpeg*, *.ico*) that contains the icon to be displayed in **Extension Manager**, if an icon is present. The icon image must be 32x32 pixels or it is resized to those dimensions. If no icon is specified, **Extension Manager** uses a default icon.
- **Preview image** specifies the graphics file (*.png*, *.bmp*, *.jpeg*, *.ico*) that contains the preview image to be displayed in **Extension Manager**, if a preview image is present. The preview image must be 200x200 pixels. If no preview image is specified, **Extension Manager** uses a default image.
- **Tags** adds text tags to be used for search hints.
- **Release Notes** specifies a file (*.txt*, *.rtf*) that contains release notes. Also takes the URL of a website that displays the release notes.
- **Getting Started Guide** specifies a file (*.txt*, *.rtf*) that contains information about how to use the extension or the content in the VSIX package. This guide appears when the extension installation is complete. Also takes the URL of a website that displays the guide.
- **More Info URL** specifies the URL of a website that contains additional information about the product.

The **Install Targets** tab contains the following controls:

- **Type of install** lists **Visual Studio Extension** and **Extension SDK** as target installation types. The options differ, depending on the type that you choose.
  - **Visual Studio Extension** lists the **InstallationTarget** elements that describe how the package can be installed and into which Visual Studio products this extension can be installed. Each product is identified separately by name and a version or version range. Products can be added to the list, modified, and deleted. The name and the version of a product correspond to the **Id** and **Version** attributes of the associated **InstallationTarget** element.
    - **Version Range** is [12.0, 14.0] and uses the following notation:
      - `[` - minimum version inclusive
      - `]` - maximum version inclusive
      - `(` - minimum version exclusive
      - `)` - maximum version exclusive
      - Single version # - only the specified version

  - **Extension SDK** specifies a global installation that isn't scoped to a specific product and version. **Target Platform Identifier** is the platform, such as "Windows," that you're targeting. **Target Platform Version** is the version, such as 8.0, of your target platform. **SDK Name** and **SDK Version** are the name and the version number of the SDK, respectively.

- **This VSIX is installed for all users (requires elevation on install)**. If you select this check box, the extension is installed for all users; otherwise, it's installed only for the current user.

- **This VSIX is installed by Windows Installer**. If  you select this check box, the extension is installed by the Windows Installer (*.msi* file); otherwise, it's installed as a typical VSIX package (*.vsix* file).

The **Assets** tab contains the following controls:

- **List of assets** lists the Asset elements that describe the extension or content elements that this package surfaces. Each extension or content element is listed separately by source, type, and path. Extensions and content elements can be added to the list, modified, and deleted. The type and path of an extension or content element corresponds to the `Type` and `Path` attributes of the associated `Asset` element. The following types are known:
  - Microsoft.VisualStudio.Package
  - Microsoft.VisualStudio.MefComponent
  - Microsoft.VisualStudio.ToolboxControl
  - Microsoft.VisualStudio.Samples
  - Microsoft.VisualStudio.ProjectTemplate
  - Microsoft.VisualStudio.ItemTemplate
  - Microsoft.VisualStudio.Assembly
  - Microsoft.ExtensionSDK

   To add or edit an asset, you must specify the asset type, whether the asset is a project in the current solution or a file in the file system, and the name of the project. You can also specify the name of the folder in which to be embedded.

   You can also create your own types and give them unique names.

The **Dependencies** tab contains the following controls:

- **Name, Source, and Version Range** lists the Dependency elements of this package, which are other packages that this package depends on. If a dependency package is specified, it must be installed before this package is installed; otherwise, this package must install it.

   Dependency packages are specified by identifier, name, version range, source, and how the dependency is to be resolved. Each dependency package is listed separately by name, version, and source. Dependency packages can be added to the list, modified, and deleted.

   The identifier must match the `ID` attribute of the dependency package metadata. The source can be a project in the current solution, a currently installed extension, or a file. The **How is dependency resolved** setting can be the relative path of a nested package or the URL of the download location for the dependency. The ID, the version, and the resolution of the dependency package correspond to the `Id`, `Version`, and `Location` attributes of the associated `Dependency` element.

## See also
- [VSIX extension schema 2.0 reference](../extensibility/vsix-extension-schema-2-0-reference.md)
- [Anatomy of a VSIX package](../extensibility/anatomy-of-a-vsix-package.md)
