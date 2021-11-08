---
title: "&lt;Commands&gt; Element (Bootstrapper) | Microsoft Docs"
description: The Commands element implements tests in the elements underneath InstallChecks and declares the package to install if the ClickOnce bootstrapper test fails.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "<Commands> element [bootstrapper]"
ms.assetid: e61d5787-fe1f-4ebf-b0cf-0d7909be7ffb
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload:
  - "multiple"
---
# &lt;Commands&gt; element (bootstrapper)
The `Commands` element implements tests described by the elements underneath the `InstallChecks` element, and declares which package the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] bootstrapper should install if the test fails.

## Syntax

```xml
<Commands
    Reboot
>
    <Command
        PackageFile
        Arguments
        EstimatedInstallSeconds
        EstimatedDiskBytes
        EstimatedTempBytes
        Log
    >
        <InstallConditions>
            <BypassIf
                Property
                Compare
                Value
                Schedule
            />
            <FailIf
                Property
                Compare
                Value
                String
                Schedule
            />
        </InstallConditions>
        <ExitCodes>
            <ExitCode
                Value
                Result
                String
            />
        </ExitCodes>
    </Command>
</Commands>
```

## Elements and attributes
 The `Commands` element is required. The element has the following attribute.

|Attribute|Description|
|---------------|-----------------|
|`Reboot`|Optional. Determines whether the system should restart if any of the packages return a restart exit code. The following list shows the valid values:<br /><br /> `Defer`. The restart is deferred until some future time.<br /><br /> `Immediate`. Causes an immediate restart if one of the packages returned a restart exit code.<br /><br /> `None`. Causes any restart requests to be ignored.<br /><br /> The default is `Immediate`.|

## Command
 The `Command` element is a child element of the `Commands` element. A `Commands` element can have one or more `Command` elements. The element has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`PackageFile`|Required. The name of the package to install should one or more of the conditions specified by `InstallConditions` return false. The package must be defined in the same file by using a `PackageFile` element.|
|`Arguments`|Optional. A set of command line arguments to pass into the package file.|
|`EstimatedInstallSeconds`|Optional. The estimated time, in seconds, it will take to install the package. This value determines the size of the progress bar the bootstrapper displays to the user. The default is 0, in which case no time estimate is specified.|
|`EstimatedDiskBytes`|Optional. The estimated amount of disk space, in bytes, that the package will occupy after the installation is finished. This value is used in hard disk space requirements that the bootstrapper displays to the user. The default is 0, in which case the bootstrapper does not display any hard disk space requirements.|
|`EstimatedTempBytes`|Optional. The estimated amount of temporary disk space, in bytes, that the package will require.|
|`Log`|Optional. The path to the log file that the package generates, relative to the root directory of the package.|

## InstallConditions
 The `InstallConditions` element is a child of the `Command` element. Each `Command` element can have at most one `InstallConditions` element. If no `InstallConditions` element exists, the package specified by `Condition` will always run.

## BypassIf
 The `BypassIf` element is a child of the `InstallConditions` element, and describes a positive condition under which the command should not be executed. Each `InstallConditions` element can have zero or more `BypassIf` elements.

 `BypassIf` has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`Property`|Required. The name of the property to test. The property must previously have been defined by a child of the `InstallChecks` element. For more information, see [\<InstallChecks> Element](../deployment/installchecks-element-bootstrapper.md).|
|`Compare`|Required. The type of comparison to perform. The following list shows the valid values:<br /><br /> `ValueEqualTo`, `ValueNotEqualTo`, `ValueGreaterThan`, `ValueGreaterThanOrEqualTo`, `ValueLessThan`, `ValueLessThanOrEqualTo`, `VersionEqualTo`, `VersionNotEqualTo`, `VersionGreaterThan`, `VersionGreaterThanOrEqualTo`, `VersionLessThan`, `VersionLessThanOrEqualTo`, `ValueExists`, `ValueNotExists`|
|`Value`|Required. The value to compare with the property.|
|`Schedule`|Optional. The name of a `Schedule` tag that defines when this rule should be evaluated.|

## FailIf
 The `FailIf` element is a child of the `InstallConditions` element, and describes a positive condition under which the installation should stop. Each `InstallConditions` element can have zero or more `FailIf` elements.

 `FailIf` has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`Property`|Required. The name of the property to test. The property must previously have been defined by a child of the `InstallChecks` element. For more information, see [\<InstallChecks> Element](../deployment/installchecks-element-bootstrapper.md).|
|`Compare`|Required. The type of comparison to perform. The following list shows the valid values:<br /><br /> `ValueEqualTo`, `ValueNotEqualTo`, `ValueGreaterThan`, `ValueGreaterThanOrEqualTo`, `ValueLessThan`, `ValueLessThanOrEqualTo`, `VersionEqualTo`, `VersionNotEqualTo`, `VersionGreaterThan`, `VersionGreaterThanOrEqualTo`, `VersionLessThan`, `VersionLessThanOrEqualTo`, `ValueExists`, `ValueNotExists`|
|`Value`|Required. The value to compare with the property.|
|`String`|Optional. The text to display to the user upon failure.|
|`Schedule`|Optional. The name of a `Schedule` tag that defines when this rule should be evaluated.|

## ExitCodes
 The `ExitCodes` element is a child of the `Command` element. The `ExitCodes` element contains one or more `ExitCode` elements, which determine what the installation should do in response to an exit code from a package. There can be one optional `ExitCode` element underneath a `Command` element. `ExitCodes` has no attributes.

## ExitCode
 The `ExitCode` element is a child of the `ExitCodes` element. The `ExitCode` element determines what the installation should do in response to an exit code from a package. `ExitCode` contains no child elements, and has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`Value`|Required. The exit code value to which this `ExitCode` element applies.|
|`Result`|Required. How the installation should react to this exit code. The following list shows the valid values:<br /><br /> `Success`. Flags the package as successfully installed.<br /><br /> `SuccessReboot`. Flags the package as successfully installed, and instructs the system to restart.<br /><br /> `Fail`. Flags the package as failed.<br /><br /> `FailReboot`. Flags the package as failed, and instructs the system to restart.|
|`String`|Optional. The value to display to the user in response to this exit code.|
|`FormatMessageFromSystem`|Optional. Determines whether to use the system-provided error message corresponding to the exit code, or use the value provided in `String`. Valid values are `true`, which means to use the system-provided error, and `false`, which means to use the string provided by `String`. The default is `false`. If this property is `false`, but `String` is not set, the system-provided error will be used.|

## Example
 The following code example defines commands for installing the .NET Framework 2.0.

```xml
<Commands Reboot="Immediate">
    <Command PackageFile="instmsia.exe"
             Arguments= ' /q /c:"msiinst /delayrebootq"'
             EstimatedInstallSeconds="20" >
        <InstallConditions>
           <BypassIf Property="VersionNT" Compare="ValueExists"/>
             BypassIf Property="VersionMsi" Compare="VersionGreaterThanOrEqualTo" Value="2.0"/>
        </InstallConditions>
        <ExitCodes>
            <ExitCode Value="0" Result="SuccessReboot"/>
            <ExitCode Value="1641" Result="SuccessReboot"/>
            <ExitCode Value="3010" Result="SuccessReboot"/>
            <DefaultExitCode Result="Fail" FormatMessageFromSystem="true" String="GeneralFailure" />
        </ExitCodes>
    </Command>
    <Command PackageFile="WindowsInstaller-KB884016-v2-x86.exe"
             Arguments= '/quiet /norestart'
             EstimatedInstallSeconds="20" >
      <InstallConditions>
          <BypassIf Property="Version9x" Compare="ValueExists"/>
          <BypassIf Property="VersionNT" Compare="VersionLessThan" Value="5.0.3"/>
          <BypassIf Property="VersionMsi" Compare="VersionGreaterThanOrEqualTo" Value="3.0"/>
          <FailIf Property="AdminUser" Compare="ValueEqualTo" Value="false" String="AdminRequired"/>
      </InstallConditions>
      <ExitCodes>
          <ExitCode Value="0" Result="Success"/>
          <ExitCode Value="1641" Result="SuccessReboot"/>
          <ExitCode Value="3010" Result="SuccessReboot"/>
          <DefaultExitCode Result="Fail" FormatMessageFromSystem="true" String="GeneralFailure" />
      </ExitCodes>
    </Command>
    <Command PackageFile="dotnetfx.exe"
         Arguments=' /q:a /c:"install /q /l"'
         EstimatedInstalledBytes="21000000"
         EstimatedInstallSeconds="300">

        <!-- These checks determine whether the package is to be installed -->
        <InstallConditions>
            <!-- Either of these properties indicates the .NET Framework is already installed -->
            <BypassIf Property="DotNetInstalled" Compare="ValueNotEqualTo" Value="0"/>

            <!-- Block install if user does not have adminpermissions -->
            <FailIf Property="AdminUser" Compare="ValueEqualTo" Value="false" String="AdminRequired"/>

            <!-- Block install on Windows 95 -->
            <FailIf Property="Version9X" Compare="VersionLessThan" Value="4.10" String="InvalidPlatformWin9x"/>

            <!-- Block install on Windows 2000 SP 2 or less -->
            <FailIf Property="VersionNT" Compare="VersionLessThan" Value="5.0.3" String="InvalidPlatformWinNT"/>

            <!-- Block install if Internet Explorer 5.01 or later is not present -->
            <FailIf Property="IEVersion" Compare="ValueNotExists" String="InvalidPlatformIE" />
            <FailIf Property="IEVersion" Compare="VersionLessThan" Value="5.01" String="InvalidPlatformIE" />

            <!-- Block install if the operating system does not support x86 -->
            <FailIf Property="ProcessorArchitecture" Compare="ValueNotEqualTo" Value="Intel" String="InvalidPlatformArchitecture" />
       </InstallConditions>

        <ExitCodes>
            <ExitCode Value="0" Result="Success"/>
            <ExitCode Value="3010" Result="SuccessReboot"/>
            <ExitCode Value="4097" Result="Fail" String="AdminRequired"/>
            <ExitCode Value="4098" Result="Fail" String="WindowsInstallerComponentFailure"/>
            <ExitCode Value="4099" Result="Fail" String="WindowsInstallerImproperInstall"/>
            <ExitCode Value="4101" Result="Fail" String="AnotherInstanceRunning"/>
            <ExitCode Value="4102" Result="Fail" String="OpenDatabaseFailure"/>
            <ExitCode Value="4113" Result="Fail" String="BetaNDPFailure"/>
            <DefaultExitCode Result="Fail" FormatMessageFromSystem="true" String="GeneralFailure" />
        </ExitCodes>

    </Command>
</Commands>
```

## See also
- [Product and package schema reference](../deployment/product-and-package-schema-reference.md)
- [\<InstallChecks> element](../deployment/installchecks-element-bootstrapper.md)