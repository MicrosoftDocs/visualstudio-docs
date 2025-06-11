---
title: "VSIX Language Pack Schema 2.0 Reference"
description: The VSIX Language Pack schema provides localized installation information for VSIX packages. Version 2.0 supports additional localization elements.
ms.date: "10/26/2017"
ms.topic: "conceptual"
helpviewer_keywords:
  - "language pack"
  - "localize vsix"
  - "localize package"
  - "localize extension"
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# VSIX language pack schema 2.0 reference

The VSIX Language Pack schema provides localized installation information for VSIX packages. Version 2.0 of this schema supports additional localization elements.

## Language pack schema

The root element of the language pack file is `<PackageLanguagePackManifest>`, with an attribute of `Version`, which is the version of the language pack format. This article describes version 2.0 of the language pack format, which is specified in the manifest by setting the `Version` attribute to the value `Version="2.0.0"`. The root element contains exactly one child `<Metadata>` element.

### PackageLanguagePackManifest element

Within the `<PackageLanguagePackManifest>` element the following element must exist:

|Title|Description|
|-----------|-----------------|
|`<Metadata>`| The containing element for all localized package metadata

### Metadata element

Within the `<Metadata>` element you can have the following elements:

|Title|Description|
|-----------|-----------------|
|`<DisplayName>`|The localized name of the extension to be installed|
|`<Description>`|The localized description of the extension to be installed|
|`<License>`| A path to a localized version of the extension's license|
|`<MoreInfo>`| A link to localized information about the extension|
|`<ReleaseNotes>`| A path or link to a localized version of the release notes|
|`<Icon>`| A path to a localized version of the extensions icon|

### Sample manifest

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
|[Localizing VSIX packages](../extensibility/localizing-vsix-packages.md)|Shows how to provide localized installation support for a VSIX package.|
|[VSIX extension schema 2.0 reference](../extensibility/vsix-extension-schema-2-0-reference.md)|A VSIX manifest describes the contents of a *.vsix* deployment file. The deployment file enables you to install a Visual Studio extension by using the **Extensions and Updates** dialog box.|
|[Find and use Visual Studio extensions](../ide/finding-and-using-visual-studio-extensions.md)|Shows how to use the **Extensions and Updates** dialog box to install, remove, activate, and deactivate extensions.|
