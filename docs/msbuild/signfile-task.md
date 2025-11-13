---
title: "SignFile Task"
description: Learn how MSBuild uses the SignFile task to sign the specified file using the specified certificate.
ms.date: "9/5/2024"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#SignFile"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "MSBuild, SignFile task"
  - "SignFile task [MSBuild]"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# SignFile task

Signs the specified file using the specified certificate. SignFile is intended only for signing ClickOnce files. It is a wrapper for the `signtool.exe` tool and is not a general-purpose signing task.

## Parameters

 The following table describes the parameters of the `SignFile` task.

 Note that SHA-256 certificates are allowed only on machines that have .NET 4.5 and higher.

> [!WARNING]
> Starting in Visual Studio 2013 Update 3, this task has a new signature that allows you to specify the target framework version for the file. You are encouraged to use the new signature wherever possible, because the MSBuild process uses SHA-256 hashes only when the target framework is .NET 4.5 or higher. If the target framework is .NET 4.0 or below, the SHA-256 hash will not be used.

|Parameter|Description|
|---------------|-----------------|
|`CertificateThumbprint`|Required `String` parameter.<br /><br /> Specifies the certificate to use for signing. This certificate must be in the current user's personal store.|
|`SigningTarget`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the files to sign with the certificate, of type .exe or .dll.|
|`TimestampUrl`|Optional `String` parameter.<br /><br /> Specifies the URL of a time stamping server.|
|`TargetFrameworkVersion`|The version of the .NET Framework that is used for the target.|

## Remarks

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [Task base class](../msbuild/task-base-class.md).
 
SignFile requires either Visual Studio or a Windows 8.1 SDK to be installed, in order to find the `signtool.exe` tool on the path. It can't be used in CI/CD scenarios where only the build tools are installed.

## Example

 The following example uses the `SignFile` task to sign the files specified in the `FilesToSign` item collection with the certificate specified by the `CertificateThumbprint` property.

```xml
<Project>
    <ItemGroup>
        <FileToSign Include="File.exe" />
    </ItemGroup>
    <PropertyGroup>
        <Certificate>Cert.cer</Certificate>
    </PropertyGroup>
    <Target Name="Sign">
        <SignFile
            CertificateThumbprint="$(CERTIFICATE_THUMBPRINT)"
            SigningTarget="@(FileToSign)"
            TargetFrameworkVersion="v4.5" />
    </Target>
</Project>
```

> [!NOTE]
> The certificate thumbprint is the SHA-1 hash of the certificate. The example here assumes an environment variable `CERTIFICATE_THUMBPRINT` that contains the thumbprint. For more information, see [Obtain the SHA-1 hash of a trusted root CA certificate](/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/cc733076\(v\=ws.10\)). If you copy and paste the thumbprint from the certificate details, make sure you do not include the extra (3F) invisible character, which may prevent `SignFile` from finding the certificate.

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
- [Tasks](../msbuild/msbuild-tasks.md)
