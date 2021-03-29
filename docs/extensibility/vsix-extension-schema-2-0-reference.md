---
title: VSIX Extension Schema 2.0 Reference | Microsoft Docs
description: The VSIX extension schema 2.0 defines the file format for a VSIX deployment manifest file, which describes the contents of a VSIX package.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- vsix
- extension schema
ms.assetid: 0da81b98-f5e3-40d3-ba9a-94551378d0b4
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# VSIX extension schema 2.0 reference
A VSIX deployment manifest file describes the contents of a VSIX package. The file format is governed by a schema. Version 2.0 of this schema supports the adding of custom types and attributes.  The schema of the manifest is extensible. The manifest loader ignores XML elements and attributes that it doesn't understand.

> [!IMPORTANT]
> Visual Studio 2015 can load VSIX files in the Visual Studio 2010, Visual Studio 2012, or Visual Studio 2013 formats.

## Package manifest schema
 The root element of the manifest XML file is `<PackageManifest>`. It has a single attribute `Version`, which is the version of the manifest format. If major changes are made to the format, the version format is changed. This article describes manifest format version 2.0, which is specified in the manifest by setting the `Version` attribute to the value of Version="2.0".

### PackageManifest element
 Within the `<PackageManifest>` root element, you can use the following elements:

- `<Metadata>` - Metadata and advertising information about the package itself. Only one `Metadata` element is allowed in the manifest.

- `<Installation>` - This section defines the way this extension package can be installed, including the application SKUs that it can install into. Only a single `Installation` element is allowed in the manifest. A manifest must have an `Installation` element, or this package won't install into any SKU.

- `<Dependencies>` - An optional list of dependencies for this package are defined here.

- `<Assets>` - This section contains all of the assets contained within this package. Without this section, this package won't surface any content.

- `<AnyElement>*` - The manifest schema is flexible enough to allow any other elements. Any child elements not recognized by the manifest loader are exposed in the Extension Manager API as extra XmlElement objects. Using these child elements, VSIX extensions can define additional data in the manifest file that code running in Visual Studio can access at run time. See [Microsoft.VisualStudio.ExtensionManager.IExtension.AdditionalElements](/previous-versions/visualstudio/visual-studio-2013/hh265266(v=vs.120)).

### Metadata element
 This section is the metadata about the package, its identity, and advertising information. `<Metadata>` contains the following elements:

- `<Identity>` -  Defines identification information for this package and includes the following attributes:

  - `Id` - This attribute must be a unique ID for the package chosen by its author. The name should be qualified the same way CLR types are namespaced: Company.Product.Feature.Name. The `Id` attribute is limited to 100 characters.

  - `Version` - Defines the version of this package and its contents. This attribute follows the CLR assembly versioning format: Major.Minor.Build.Revision (1.2.40308.00). A package with a higher version number is considered updates to the package, and can be installed over the existing installed version.

  - `Language` - This attribute is the default language for the package and corresponds to the textual data in this manifest. This attribute follows the CLR locale code convention for resource assemblies, for example: en-us, en, fr-fr. You can specify `neutral` to declare a language-neutral extension that will run on any version of Visual Studio. The default value is `neutral`.

  - `Publisher` - This attribute identifies the publisher of this package, either a company or individual name. The `Publisher` attribute is limited to 100 characters.

- `<DisplayName>` - This element specifies the user-friendly package name that is displayed in the Extension Manager UI. The `DisplayName` content is limited to 50 characters.

- `<Description>` - This optional element is a short description of the package and its contents that is displayed in Extension Manager UI. The `Description` content can contain any text that you want, but it's limited to 1000 characters.

- `<MoreInfo>` - This optional element is a URL to a page online that contains a full description of this package. The protocol must be specified as http.

- `<License>` - This optional element is a relative path to a license file (.txt, .rtf) contained in the package.

- `<ReleaseNotes>` - This optional element is either a relative path to a release notes file contained in the package (.txt, .rtf) or else a URL to a website that displays the release notes.

- `<Icon>` - This optional element is a relative path to an image file (png, bmp, jpeg, ico) contained in the package. The icon image should be 32x32 pixels (or will be shrunk to that size) and appears in the listview UI. If no `Icon` element is specified, the UI uses a default.

- `<PreviewImage>` - This optional element is a relative path to an image file (png, bmp, jpeg) contained in the package. The preview image should be 200x200 pixels, and displayed in the details UI. If no `PreviewImage` element is specified, the UI uses a default.

- `<Tags>` - This optional element lists additional semicolon-delimited text tags that are used for search hints. The `Tags` element is limited to 100 characters.

- `<GettingStartedGuide>` - This optional element is either a relative path to an HTML file or a URL to a website that contains information about how to use the extension or content within this package. This guide is launched as part of an installation.

- `<AnyElement>*` - The manifest schema is flexible enough to allow any other elements. Any child elements that aren't recognized by the manifest loader are exposed as a list of XmlElement objects. Using these child elements, VSIX extensions can define additional data in the manifest file and enumerate them at run time.

### Installation element
 This section defines the way this package can be installed and the application SKUs that it can install into. This section contains the following attributes:

- `Experimental` - Set this attribute to true if you have an extension that is currently installed for all users, but you are developing an updated version on the same computer. For example, if you have installed MyExtension 1.0 for all users, but you want to debug MyExtension 2.0 on the same computer, set Experimental="true". This attribute is available in Visual Studio 2015 Update 1 and later.

- `Scope` - This attribute can take the value "Global" or "ProductExtension":

  - "Global" specifies that the installation is not scoped to a specific SKU. For example, this value is used when an Extension SDK is installed.

  - "ProductExtension" specifies that a traditional VSIX Extension (version 1.0) scoped to individual Visual Studio SKUs is installed. This is the default value.

- `AllUsers` - This optional attribute specifies whether this package will be installed for all users. By default, this attribute is false, which specifies that the package is per user. (When you set this value to true, the installing user must elevate to administrative privilege level to install the resulting VSIX.

- `InstalledByMsi` - This optional attribute specifies whether this package is installed by an MSI. Packages installed by an MSI are installed and managed by MSI (Programs and Features) and not by the Visual Studio Extension Manager.  By default, this attribute is false, which specifies that the package is not installed by an MSI.

- `SystemComponent` - This optional attribute specifies whether this package should be considered a system component. System components don't show in the Extension Manager UI and cannot be updated. By default, this attribute is false, which specifies that the package isn't a system component.

- `AnyAttribute*` - The `Installation` element accepts an open-ended set of attributes that will be exposed at run time as a name-value pair dictionary.

- `<InstallationTarget>` -This element controls the location where the VSIX installer installs the package. If the value of the `Scope` attribute is "ProductExtension" the package must target a SKU, which has installed a manifest file as part of its contents to advertise its availability to extensions. The `<InstallationTarget>` element has the following attributes when the `Scope` attribute has the explicit or default value "ProductExtension":

  - `Id` - This attribute identifies the package.  The attribute follows the namespace convention: Company.Product.Feature.Name. The `Id` attribute can contain only alphanumeric characters and is limited to 100 characters. Expected values:

    - Microsoft.VisualStudio.IntegratedShell

    - Microsoft.VisualStudio.Pro

    - Microsoft.VisualStudio.Premium

    - Microsoft.VisualStudio.Ultimate

    - Microsoft.VisualStudio.VWDExpress

    - Microsoft.VisualStudio.VPDExpress

    - Microsoft.VisualStudio.VSWinExpress

    - Microsoft.VisualStudio.VSLS

    - My.Shell.App

  - `Version` - This attribute specifies a version range with the minimum and maximum supported versions of this SKU. A package can detail the versions of the SKUs that it supports. The version range notation is [10.0 - 11.0], where

    - [ - minimum version inclusive.

    - ] - maximum version inclusive.

    - ( - minimum version exclusive.

    - ) - maximum version exclusive.

    - Single version # - only the specified version.

    > [!IMPORTANT]
    > Version 2.0 of the VSIX Schema was introduced in Visual Studio 2012. To use this schema you must have Visual Studio 2012 or later installed on the machine and use the VSIXInstaller.exe that is part of that product. You can target earlier versions of Visual Studio with a Visual Studio 2012 or later VSIXInstaller, but only by using the later versions of the installer.

    Visual Studio 2017 version numbers can be found at [Visual Studio build numbers and release dates](../install/visual-studio-build-numbers-and-release-dates.md).

    When expressing the version for Visual Studio 2017 releases, the minor version should always be **0**. For example, Visual Studio 2017 version 15.3.26730.0 should be expressed as [15.0.26730.0,16.0). This is only required for Visual Studio 2017 and later version numbers.

  - `AnyAttribute*` - The `<InstallationTarget>` element allows an open-ended set of attributes that is exposed at run time as a name-value pair dictionary.

### Dependencies element
 This element contains a list of dependencies that this package declares. If any dependencies are specified, those packages (identified by their `Id`) must have been installed before.

- `<Dependency>` element - This child element has the following attributes:

  - `Id` - This attribute must be a unique ID for the dependent package. This identity value must match the `<Metadata><Identity>Id` attribute of a package that this package is dependent on. The `Id` attribute follows the namespace convention: Company.Product.Feature.Name. The attribute can contain only alphanumeric characters and is limited to 100 characters.

  - `Version` - This attribute specifies a version range with the minimum and maximum supported versions of this SKU. A package can detail the versions of the SKUs that it supports. The version range notation is [12.0, 13.0], where:

    - [ - minimum version inclusive.

    - ] - maximum version inclusive.

    - ( - minimum version exclusive.

    - ) - maximum version exclusive.

    - Single version # - only the specified version.

  - `DisplayName` - This attribute is the display name of the dependent package, which is used in UI elements such as dialog boxes and error messages. The attribute is optional unless the dependent package is installed by MSI.

  - `Location` - This optional attribute specifies either the relative path within this VSIX to a nested VSIX package or a URL to the download location for the dependency. This attribute is used to help the user locate the prerequisite package.

  - `AnyAttribute*` - The `Dependency` element accepts an open-ended set of attributes that will be exposed at run time as a name-value pair dictionary.

### Assets element
 This element contains a list of `<Asset>` tags for each extension or content element surfaced by this package.

- `<Asset>` -  This element contains the following attributes and elements:

  - `Type` - Type of extension or content represented by this element. Each `<Asset>` element must have a single `Type`, but multiple `<Asset>` elements may have the same `Type`. This attribute should be represented as a fully qualified name, according to namespace conventions. The known types are:

    1. Microsoft.VisualStudio.VsPackage

    2. Microsoft.VisualStudio.MefComponent

    3. Microsoft.VisualStudio.ToolboxControl

    4. Microsoft.VisualStudio.Samples

    5. Microsoft.VisualStudio.ProjectTemplate

    6. Microsoft.VisualStudio.ItemTemplate

    7. Microsoft.VisualStudio.Assembly

       You can create your own types and give them unique names. At run time inside Visual Studio, your code can enumerate and access these custom types through the Extension Manager API.

  - `Path` - the relative path to the file or folder within the package that contains the asset.

  - `TargetVersion` - the version range to which the given asset applies. Used for shipping multiple versions of assets to different versions of Visual Studio. Requires Visual Studio 2017.3 or newer to have effect.

  - `AnyAttribute*` - An open-ended set of attributes that is exposed at run time as a name-value pair dictionary.

    `<AnyElement>*` - Any structured content is allowed between an `<Asset>` begin and end tag. All elements are exposed as a list of XmlElement objects. VSIX extensions can define structured type-specific metadata in the manifest file and enumerate them at run time.

### Sample manifest

```xml
<?xml version="1.0" encoding="utf-8"?>
<PackageManifest Version="2.0.0" xmlns="http://schemas.microsoft.com/developer/vsx-schema/2011" xmlns:d="http://schemas.microsoft.com/developer/vsx-schema-design/2011">
  <Metadata>
    <Identity Id="0000000-0000-0000-0000-000000000000" Version="1.0" Language="en-US" Publisher="Company" />
    <DisplayName>Test Package</DisplayName>
    <Description>Information about my package</Description>
    <MoreInfo>http://www.fabrikam.com/Extension1/</MoreInfo>
    <License>eula.rtf</License>
    <ReleaseNotes>notes.txt</ReleaseNotes>
    <Icon>Images\icon.png</Icon>
    <PreviewImage>Images\preview.png</PreviewImage>
  </Metadata>
  <Installation InstalledByMsi="false" AllUsers="false" SystemComponent="false" Scope="ProductExtension">
    <InstallationTarget Id="Microsoft.VisualStudio.Pro" Version="[11.0, 12.0]" />
  </Installation>
  <Dependencies>
    <Dependency Id="Microsoft.Framework.NDP" DisplayName="Microsoft .NET Framework" d:Source="Manual" Version="[4.5,)" />
    <Dependency Id="Microsoft.VisualStudio.MPF.12.0" DisplayName="Visual Studio MPF 12.0" d:Source="Installed" Version="[12.0]" />
  </Dependencies>
  <Assets>
    <Asset Type="Microsoft.VisualStudio.VsPackage" d:Source="Project" d:ProjectName="%CurrentProject%" Path="|%CurrentProject%;PkgdefProjectOutputGroup|" />
  </Assets>
</PackageManifest>
```

## See also

- [Ship Visual Studio extensions](../extensibility/shipping-visual-studio-extensions.md)
