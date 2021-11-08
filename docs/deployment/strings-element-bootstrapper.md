---
title: "&lt;Strings&gt; Element (Bootstrapper) | Microsoft Docs"
description: The Strings element defines localized strings for product names, package names, and installation error messages.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "MSBuild.GenerateBootstrapper.NoStringsForCulture"
  - "MSBuild.GenerateBootstrapper.ProductCultureNotFound"
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "<Strings> element [bootstrapper]"
ms.assetid: d5ea3613-5fc9-4a11-bef3-46a01178bf60
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload:
  - "multiple"
---
# &lt;Strings&gt; element (bootstrapper)
Defines localized strings for product names, package names, and installation error messages.

## Syntax

```xml
<Strings>
    <String
        Name
    >
    </String>
</Strings>
```

## Elements and attributes
 The `Strings` element is a child of the `Package` element. It has no attributes.

## String
 The `String` element is a child of the `Strings` element. A `Strings` element may have one or more `String` elements.

 `String` has the following attribute.

|Attribute|Description|
|---------------|-----------------|
|`Name`|Required. The name of the string.|

## Example
 The following code example specifies all of the English strings for the .NET Framework installer.

```xml
<Strings>
    <String Name="DisplayName">.NET Framework 2.0</String>
    <String Name="Culture">en</String>
    <String Name="AdminRequired">Administrator permissions are required to install the .NET Framework 2.0. Contact your administrator.</String>
    <String Name="InvalidPlatformWin9x">Installation of the .NET Framework 2.0 is not supported on Windows 95. Contact your application vendor.</String>
    <String Name="InvalidPlatformWinNT">Installation of the .NET Framework 2.0 is not supported on Windows NT 4.0. Contact your application vendor.</String>
    <String Name="InvalidPlatformIE">Installation of the .NET Framework 2.0 requires Internet Explorer 5.01 or greater. Contact your application vendor.</String>
    <String Name="InvalidPlatformArchitecture">This version of the .NET Framework 2.0 is not supported on a 64-bit operating system. Contact your application vendor.</String>
    <String Name="WindowsInstallerImproperInstall">Due to an error with Windows Installer, the installation of the .NET Framework 2.0 cannot proceed.</String>
    <String Name="AnotherInstanceRunning">Another instance of setup is already running. The running instance must complete before this setup can proceed.</String>
    <String Name="BetaNDPFailure">A beta version of the .NET Framework was detected on the computer. Uninstall any previous beta versions of .NET Framework before continuing.</String>
    <String Name="GeneralFailure">A failure occurred attempting to install the .NET Framework 2.0.</String>
    <String Name="DotNetFXExe">http://go.microsoft.com/fwlink/?LinkId=37283</String>
    <String Name="InstMsiAExe">http://go.microsoft.com/fwlink/?LinkId=37285</String>
    <String Name="Msi30Exe">http://go.microsoft.com/fwlink/?LinkId=37287</String>
</Strings>
```

## See also
- [\<Package> element](../deployment/package-element-bootstrapper.md)