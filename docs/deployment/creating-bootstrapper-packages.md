---
title: "Create bootstrapper packages"
description: Learn about the Setup program and how to use XML manifests that specify the metadata to manage the installation of ClickOnce components.
ms.date: "05/02/2018"
ms.topic: "conceptual"
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "deploying applications [Visual Studio], prerequisites"
  - "deploying applications [Visual Studio], custom prerequisites"
  - "prerequisites, custom"
  - "RedistList file"
  - "custom prerequisites"
  - "redistributables list"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Create bootstrapper packages

The Setup program is a generic installer that can be configured to detect and install redistributable components such as Windows Installer (*.msi*) files and executable programs. The installer is also known as a bootstrapper. It is programmed through a set of XML manifests that specify the metadata to manage the installation of the component.  Each redistributable component, or prerequisite, that appears in the **Prerequisites** dialog box for ClickOnce is a bootstrapper package. A bootstrapper package is a group of directories and files that contain manifest files that describe how the prerequisite should be installed.

The bootstrapper first detects whether any of the prerequisites are already installed. If prerequisites are not installed, first the bootstrapper shows the license agreements. Second, after the end user accepts the license agreements, the installation begins for the prerequisites. Otherwise, if all the prerequisites are detected, the bootstrapper just starts the application installer.

## Create custom bootstrapper packages
You can generate the bootstrapper manifests by using the XML Editor in Visual Studio. To see an example of creating a bootstrapper package, see [Walkthrough: Create a custom bootstrapper with a privacy prompt](../deployment/walkthrough-creating-a-custom-bootstrapper-to-show-a-privacy-prompt.md).

To create a bootstrapper package, you have to create a product manifest and, for each localized version of a component, a package manifest as well.

* The product manifest, *product.xml*, contains any language-neutral metadata for the package. This contains metadata common to all the localized versions of the redistributable component.  To create this file, see [How to: Create a Product Manifest](../deployment/how-to-create-a-product-manifest.md).

* The package manifest, *package.xml*, contains language-specific metadata; it typically contains localized error messages. A component must have at least one package manifest for each localized version of that component. To create this file, see [How to: Create a Package Manifest](../deployment/how-to-create-a-package-manifest.md).

After these files are created, put the product manifest file into a folder named for the custom bootstrapper. The package manifest file goes into a folder named for the locale. For example, if the package manifest file is for English redistribution, put the file into a folder called en. Repeat this process for each locale, such as ja for Japanese and de for German. The final custom bootstrapper package could have the following folder structure.

```
CustomBootstrapperPackage
  product.xml
  CustomBootstrapper.msi
  de
    eula.rtf
    package.xml
  en
    eula.rtf
    package.xml
  ja
    eula.rtf
    package.xml
```

Next, copy the redistributable files into the bootstrapper folder location. For more information, see [How to: Create a localized bootstrapper package](../deployment/how-to-create-a-localized-bootstrapper-package.md).

```
*\Program Files (x86)\Microsoft SDKs\ClickOnce Bootstrapper\Packages*
```

or

```
*<VS Install Path>\MSBuild\Microsoft\VisualStudio\BootstrapperPackages*
```

>[!NOTE]
>The path listed above under the Visual Studio install path works starting with the Visual Studio 2019 Update 7 release.

You can also find the bootstrapper folder location from the **Path** value in the following registry key:

```
*HKLM\Software\Microsoft\GenericBootstrapper*
```

On 64-bit systems, use the following registry key:

```
*HKLM\Software\Wow6432Node\Microsoft\GenericBootstrapper*
```

Each redistributable component appears in its own subfolder under the packages directory. The product manifest and redistributable files must be put into this subfolder. Localized versions of the component and package manifests must be put in subfolders named according to Culture Name.

After these files are copied into the bootstrapper folder, the bootstrapper package automatically appears in the Visual Studio **Prerequisites** dialog box. If your custom bootstrapper package does not appear, close and then reopen the **Prerequisites** dialog box. For more information, see [Prerequisites dialog box](/visualstudio/deployment/how-to-install-prerequisites-with-a-clickonce-application).

The following table shows the properties that are automatically populated by the bootstrapper.

|Property|Description|
|--------------|-----------------|
|ApplicationName|The name of the application.|
|ProcessorArchitecture|The processor and bits-per-word of the platform targeted by an executable. Values include the following:<br /><br /> -   Intel<br />-   IA64<br />-   AMD64|
|[VersionNT](/windows/desktop/Msi/versionnt)|The version number for the Windows operating systems. The syntax of the version is Major.Minor.ServicePack.|
|[VersionMSI](/windows/desktop/Msi/versionmsi)|The version of the Windows Installer assembly (msi.dll) to run during the installation.|
|[AdminUser](/windows/desktop/Msi/adminuser)|This property is set if the user has administrator privileges. Values are true or false.|
|InstallMode|The installation mode indicates where the component needs to be installed from. Values include the following:<br /><br /> -   HomeSite - prerequisites are installed from the vendor's Web site.<br />-   SpecificSite - prerequisites are installed from the location that you select.<br />-   SameSite - prerequisites are installed from the same location as the application.|

## Separate redistributables from application installations
You can prevent your redistributable files from being deployed in Setup projects. To do this, create a redistributable list in the RedistList folder in your .NET Framework directory:

`%ProgramFiles%\Microsoft.NET\RedistList`

The redistributable list is an XML file that you should name using the following format: *\<Company Name>.\<Component Name>.RedistList.xml*. So, for example, if the component is called DataWidgets made by Acme, use *Acme.DataWidgets.RedistList.xml*. An example of the redistributable list's contents might resemble this:

```xml
<?xml version="1.0" encoding="UTF-8"?>
<FileList Redist="Acme.DataWidgets" >
<File AssemblyName="Acme.DataGrid" Version="1.0.0.0" PublicKeyToken="b03f5f7f11d50a3a" Culture="neutral" ProcessorArchitecture="MSIL" InGAC="true" />
</FileList>
```

## Related content
- [How to: Install prerequisites with a ClickOnce application](../deployment/how-to-install-prerequisites-with-a-clickonce-application.md)
- [Prerequisites dialog box](/visualstudio/deployment/how-to-install-prerequisites-with-a-clickonce-application)
- [Product and package schema reference](../deployment/product-and-package-schema-reference.md)
- [Use the Visual Studio 2005 bootstrapper to kick-start your installation](/archive/msdn-magazine/2004/october/visual-studio-2005-bootstrapper-start-kick-your-installation)
