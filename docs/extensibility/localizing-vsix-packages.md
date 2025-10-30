---
title: Localizing VSIX Packages
description: Learn how to localize a VSIX package by creating an Extension.vsixlangpack file for each target language and then putting them in the correct folder.
ms.date: 10/26/2017
ms.topic: how-to
helpviewer_keywords:
- localize package
- localize extension
- localized deployment
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Localizing VSIX Packages

You can localize a VSIX package by creating an *Extension.vsixlangpack* file for each target language and then putting them in the correct folder. When a localized package is installed, the localized name of the extension is displayed together with a localized description. If you supply a localized license file, or a URL that points to localized information, they are also displayed.

If the content your VSIX package includes a VSPackage that adds menu commands or other UI, see [Localize menu commands](../extensibility/localizing-menu-commands.md) for information about localizing the new UI elements.

## Directory structure

 When a user installs an extension, **Extensions and Updates** checks the top level of the VSIX package for a folder whose name matches the Visual Studio locale of the target computer. If **Extensions and Updates** finds a *.vsixlangpack* file in the folder, it substitutes the localized values in that file for the corresponding values in the *.vsixmanifest* file. These values are displayed when the extension is being installed. The following example shows the directory structure for a VSIX package that is localized into Spanish (es-ES) and French (fr-FR).

```text
.
├── MyExtension.dll
├── Extension.vsixmanifest
├── [Content_Types].xml
├── es-ES
│   └── Extension.vsixlangpack
└── fr-FR
    └── Extension.vsixlangpack
```

> [!NOTE]
> The VSIX-supported project templates in the Visual Studio SDK generate a VSIX manifest and name it *source.extension.vsixmanifest*. When Visual Studio builds the project, it copies the content of that file into Extension.VsixManifest in the VSIX package.

## The Extension.vsixlangpack file

The *Extension.vsixlangpack* file follows the [VSIX Language Pack schema 2.0](../extensibility/vsix-language-pack-schema-2-0-reference.md). This schema has a `PackageLanguagePackManifest`, which is immediately followed by a `Metadata` child element. The Metadata element can contain up to 6 child elements, `DisplayName`, `Description`, `MoreInfo`, `License`, `ReleaseNotes`, and `Icon`. These child elements correspond to the `DisplayName`, `Description`, `MoreInfo`, `License`, `ReleaseNotes`, and `Icon` child elements of the `Metadata` element of the *Extension.vsixmanifest* file.

When you create a vsixlangpack file, you must set the `Include in Vsix` property to `true`. Otherwise, the localized installation text will be ignored.

### To set the Include in Vsix property

1. In **Solution Explorer**, right-click the Extension.vsixlangpack file, and then click **Properties**.

2. In the **Property Grid**, click **Include in Vsix**, and set its value to `true`.

## Example

### Description

The following example shows relevant portions of an *Extension.vsixmanifest* file. The file also includes the corresponding *Extension.vsixlangpack* file for Spanish. The values from the language pack replace the values from the manifest if the Visual Studio locale of the target computer is set to Spanish.

### Code

- [*Extension.vsixmanifest*]

```xml
<?xml version="1.0" encoding="utf-8"?>
<PackageManifest ...>
  <Metadata ...>
    <DisplayName>Family Tree</DisplayName>
    <Description>This extension places a custom treeview control in the toolbox that is optimized for handling family tree information.</Description>
    <MoreInfo>http://www.contoso.com/products/FamilyTree.htm</MoreInfo>
    <License>Eula.rtf</License>
    <ReleaseNotes>ReleaseNotes.rtf</ReleaseNotes>
    <Icon>Icon.png</Icon>
  </Metadata>
  <Installation .../>
  <Dependencies .../>
  <Prerequisites .../>
  <Assets .../>
</PackageManifest>
```

- [*Extension.vsixlangpack*]

```xml
<?xml version="1.0" encoding="utf-8"?>
<PackageLanguagePackManifest Version="2.0.0" xmlns="http://schemas.microsoft.com/developer/vsx-schema/2011">
  <Metadata>
    <DisplayName>Arbol de Familia</DisplayName>
    <Description> Esta extensión pone control personalizado en la caja de herramientas por manejar información de familia.</Description>
    <MoreInfo> http://www.contoso.com/products/es/ArbolDeFamilia.htm</MoreInfo>
    <License>Eula.rtf</License>
    <ReleaseNotes>ReleaseNotes.rtf</ReleaseNotes>
    <Icon>Icon.png</Icon>
  </Metadata>
</PackageLanguagePackManifest>
```

## See also

|Title|Description|
|-----------|-----------------|
|[VSIX Language Pack schema 2.0 reference](vsix-language-pack-schema-2-0-reference.md)|A VSIX language pack describes the localization information of a .vsix deployment file.|
|[Anatomy of a VSIX package](../extensibility/anatomy-of-a-vsix-package.md)|Describes the structure and contents of a vsix package.|
|[Localize menu commands](../extensibility/localizing-menu-commands.md)|Shows how to localize other text resources in an extension.|
