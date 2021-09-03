---
title: "&lt;InstallChecks&gt; Element (Bootstrapper) | Microsoft Docs"
description: The InstallChecks element supports starting a variety of tests on the local computer to make sure that all prerequisites for an application have been installed.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "<InstallChecks> element [bootstrapper]"
ms.assetid: ad329c87-b0ad-4304-84de-ae9496514c42
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload:
  - "multiple"
---
# &lt;InstallChecks&gt; element (bootstrapper)
The `InstallChecks` element supports starting a variety of tests against the local computer to make sure that all of the appropriate prerequisites for an application have been installed.

## Syntax

```xml
<InstallChecks>
    <AssemblyCheck
        Property
        Name
        PublicKeyToken
        Version
        Language
        ProcessorArchitecture
    />
    <RegistryCheck
        Property
        Key
        Value
    />
    <ExternalCheck
        PackageFile
        Property
        Arguments
    />
    <FileCheck
        Property
        FileName
        SearchPath
        SpecialFolder
        SearchDepth
    />
    <MsiProductCheck
        Property
        Product
        Feature
    />
    <RegistryFileCheck
        Property
        Key
        Value
        FileName
        SearchDepth
    />
</InstallChecks>
```

## AssemblyCheck
 This element is an optional child element of `InstallChecks`. For each instance of `AssemblyCheck`, the bootstrapper will make sure that the assembly identified by the element exists in the global assembly cache (GAC). It contains no elements, and has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`Property`|Required. The name of the property to store the result. This property can be referenced from a test underneath the `InstallConditions` element, which is a child of the `Command` element. For more information, see [\<Commands> Element](../deployment/commands-element-bootstrapper.md).|
|`Name`|Required. The fully qualified name of the assembly to check.|
|`PublicKeyToken`|Required. The abbreviated form of the public key associated with this strongly named assembly. All assemblies stored in the GAC must have a name, a version, and a public key.|
|`Version`|Required. The version of the assembly.<br /><br /> The version number has the format \<*major version*>.\<*minor version*>.\<*build version*>.\<*revision version*>.|
|`Language`|Optional. The language of a localized assembly. Default is `neutral`.|
|`ProcessorArchitecture`|Optional. The computer processor targeted by this installation. Default is `msil`.|

## ExternalCheck
 This element is an optional child element of `InstallChecks`. For each instance of `ExternalCheck`, the bootstrapper will execute the named external program in a separate process, and store its exit code in the property indicated by `Property`. `ExternalCheck` is useful for implementing complex dependency checks, or when the only way to check for the existence of a component is to instantiate it.

 `ExternalCheck` contains no elements, and has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`Property`|Required. The name of the property to store the result. This property can be referenced from a test underneath the `InstallConditions` element, which is a child of the `Command` element. For more information, see [\<Commands> Element](../deployment/commands-element-bootstrapper.md).|
|`PackageFile`|Required. The external program to execute. The program must be part of the setup distribution package.|
|`Arguments`|Optional. Supplies command-line arguments to the executable named by `PackageFile`.|

## FileCheck
 This element is an optional child element of `InstallChecks`. For each instance of `FileCheck`, the bootstrapper will determine whether the named file exists, and return the version number of the file. If the file does not have a version number, the bootstrapper sets the property named by `Property` to 0. If the file does not exist, `Property` is not set to any value.

 `FileCheck` contains no elements, and has the following attributes.

| Attribute | Description |
|-----------------| - |
| `Property` | Required. The name of the property to store the result. This property can be referenced from a test underneath the `InstallConditions` element, which is a child of the `Command` element. For more information, see [\<Commands> Element](../deployment/commands-element-bootstrapper.md). |
| `FileName` | Required. The name of the file to find. |
| `SearchPath` | Required. The disk or folder in which to look for the file. This must be a relative path if `SpecialFolder` is assigned; otherwise, it must be an absolute path. |
| `SpecialFolder` | Optional. A folder that has special significance either to Windows or to [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)]. The default is to interpret `SearchPath` as an absolute path. Valid values include the following:<br /><br /> `AppDataFolder`. The application data folder for this [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application; specific to the current user.<br /><br /> `CommonAppDataFolder`. The application data folder used by all users.<br /><br /> `CommonFilesFolder`. The Common Files folder for the current user.<br /><br /> `LocalDataAppFolder`. The data folder for non-roaming applications.<br /><br /> `ProgramFilesFolder`. The standard Program Files folder for 32-bit applications.<br /><br /> `StartUpFolder`. The folder that contains all applications launched at system startup.<br /><br /> `SystemFolder`. The folder that contains 32-bit system DLLs.<br /><br /> `WindowsFolder`. The folder that contains the Windows system installation.<br /><br /> `WindowsVolume`. The drive or partition that contains the Windows system installation. |
| `SearchDepth` | Optional. The depth at which to search sub-folders for the named file. The search is depth-first. The default is 0, which restricts the search to the top-level folder specified by `SpecialFolder` and **SearchPath**. |

## MsiProductCheck
 This element is an optional child element of `InstallChecks`. For each instance of `MsiProductCheck`, the bootstrapper checks to see whether the specified Microsoft Windows Installer installation has run until it is completed. The property value is set depending on the state of that installed product. A positive value indicates the product is installed, 0 or -1 indicates it is not installed. (Please see the Windows Installer SDK function MsiQueryFeatureState for more information.) . If Windows Installer is not installed on the computer, `Property` is not set.

 `MsiProductCheck` contains no elements, and has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`Property`|Required. The name of the property to store the result. This property can be referenced from a test underneath the `InstallConditions` element, which is a child of the `Command` element. For more information, see [\<Commands> Element](../deployment/commands-element-bootstrapper.md).|
|`Product`|Required. The GUID for the installed product.|
|`Feature`|Optional. The GUID for a specific feature of the installed application.|

## RegistryCheck
 This element is an optional child element of `InstallChecks`. For each instance of `RegistryCheck`, the bootstrapper checks to see whether the specified registry key exists, or whether it has the indicated value.

 `RegistryCheck` contains no elements, and has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`Property`|Required. The name of the property to store the result. This property can be referenced from a test underneath the `InstallConditions` element, which is a child of the `Command` element. For more information, see [\<Commands> Element](../deployment/commands-element-bootstrapper.md).|
|`Key`|Required. The name of the registry key.|
|`Value`|Optional. The name of the registry value to retrieve. The default is to return the text of the default value. `Value` must be either a String or a DWORD.|

## RegistryFileCheck
 This element is an optional child element of `InstallChecks`. For each instance of `RegistryFileCheck`, the bootstrapper retrieves the version of the specified file, first attempting to retrieve the path to the file from the specified registry key. This is particularly useful if you want to look up a file in a directory specified as a value in the registry.

 `RegistryFileCheck` contains no elements, and has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`Property`|Required. The name of the property to store the result. This property can be referenced from a test underneath the `InstallConditions` element, which is a child of the `Command` element. For more information, see [\<Commands> Element](../deployment/commands-element-bootstrapper.md).|
|`Key`|Required. The name of the registry key. Its value is interpreted as the path to a file, unless the `File` attribute is set. If this key does not exist, `Property` is not set.|
|`Value`|Optional. The name of the registry value to retrieve. The default is to return the text of the default value. `Value` must be a String.|
|`FileName`|Optional. The name of a file. If specified, the value obtained from the registry key is assumed to be a directory path, and this name is appended to it. If not specified, the value returned from the registry is assumed to be the full path to a file.|
|`SearchDepth`|Optional. The depth at which to search sub-folders for the named file. The search is depth-first. The default is 0, which restricts the search to the top-level folder specified by the registry key's value.|

## Remarks
 While the elements underneath `InstallChecks` define the tests to run, they do not execute them. To execute the tests, you must create `Command` elements underneath the `Commands` element.

## Example
 The following code example demonstrates the `InstallChecks` element as it is used in the product file for the .NET Framework.

```xml
<InstallChecks>
    <ExternalCheck Property="DotNetInstalled" PackageFile="dotnetchk.exe" />
    <RegistryCheck Property="IEVersion" Key="HKLM\Software\Microsoft\Internet Explorer" Value="Version" />
</InstallChecks>
```

## InstallConditions
 When `InstallChecks` are evaluated, they produce properties. The properties are then used by `InstallConditions` to determine whether a package should install, bypass, or fail. The following table lists the `InstallConditions`:

|Condition|Description|
|-|-|
|`FailIf`|If any `FailIf` condition evaluates to true, the package will fail. The rest of the conditions will not be evaluated.|
|`BypassIf`|If any `BypassIf` condition evaluates to true, the package will be bypassed. The rest of the conditions will not be evaluated.|

## Predefined properties
 The following table lists the `BypassIf` and `FailIf` elements:

|Property|Notes|Possible Values|
|--------------|-----------|---------------------|
|`Version9X`|Version number of a Windows 9X operating system.|4.10 = Windows 98|
|`VersionNT`|Version number of a Windows NT-based operating system.|Major.Minor.ServicePack<br /><br /> 5.0 = Windows 2000<br /><br /> 5.1.0 = Windows XP<br /><br /> 5.1.2 = Windows XP Professional SP2<br /><br /> 5.2.0 = Windows Server 2003|
|`VersionNT64`|Version number of a 64-bit Windows NT-based operating system.|Same as mentioned earlier.|
|`VersionMsi`|Version number of the Windows Installer service.|2.0 = Windows Installer 2.0|
|`AdminUser`|Specifies whether a user has administrator privileges on a Windows NT-based operating system.|0 = no administrator privileges<br /><br /> 1 = administrator privileges|

 For example, to block installation on a computer running Windows 95, use code such as the following:

```xml
    <!-- Block install on Windows 95 -->
    <FailIf Property="Version9X" Compare="VersionLessThan" Value="4.10" String="InvalidPlatform"/>
```

 To skip running install checks if a FailIf or BypassIf condition is met, use the BeforeInstallChecks attribute.  For example:

```xml
    <!-- Block install and do not evaluate install checks if user does not have admin privileges -->
    <FailIf Property="AdminUser" Compare="ValueEqualTo" Value="false" String="AdminRequired" BeforeInstallChecks="true"/>
```

>[!NOTE]
>The `BeforeInstallChecks` attribute is supported starting with the Visual Studio 2019 Update 9 release.

## See also
- [\<Commands> element](../deployment/commands-element-bootstrapper.md)
- [Product and package schema reference](../deployment/product-and-package-schema-reference.md)