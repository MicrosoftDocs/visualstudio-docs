---
title: "SignFile Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#SignFile"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "MSBuild, SignFile task"
  - "SignFile task [MSBuild]"
ms.assetid: edef1819-ddeb-4e09-95de-fc7063ba9388
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# SignFile task

Signs the specified file using the specified certificate.

## Parameters

 The following table describes the parameters of the `SignFile` task.

 Note that SHA-256 certificates are allowed only on machines that have .NET 4.5 and higher.

> [!WARNING]
> Starting in Visual Studio 2013 Update 3, this task has a new signature that allows you to specify the target framework version for the file. You are encouraged to use the new signature wherever possible, because the MSBuild process uses SHA-256 hashes only when the target framework is .NET 4.5 or higher. If the target framework is .NET 4.0 or below, the SHA-256 hash will not be used.

|Parameter|Description|
|---------------|-----------------|
|`CertificateThumbprint`|Required `String` parameter.<br /><br /> Specifies the certificate to use for signing. This certificate must be in the current user's personal store.|
|`SigningTarget`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the files to sign with the certificate.|
|`TimestampUrl`|Optional `String` parameter.<br /><br /> Specifies the URL of a time stamping server.|
|`TargetFrameworkVersion`|The version of the .NET Framework that is used for the target.|

## Remarks

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [Task base class](../msbuild/task-base-class.md).

## Example

 The following example uses the `SignFile` task to sign the files specified in the `FilesToSign` item collection with the certificate specified by the `Certificate` property.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <ItemGroup>
        <FileToSign Include="File.exe" />
    </ItemGroup>
    <PropertyGroup>
        <Certificate>Cert.cer</Certificate>
    </PropertyGroup>
    <Target Name="Sign">
        <SignFile
            CertificateThumbprint="$(CertificateThumbprint)"
            SigningTarget="@(FileToSign)"
            TargetFrameworkVersion="v4.5" />
    </Target>
</Project>
```

> [!NOTE]
> The certificate thumbprint is the SHA-1 hash of the certificate. For more information, see [Obtain the SHA-1 hash of a trusted root CA certificate](/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/cc733076\(v\=ws.10\)). If you copy and paste the thumbprint from the certificate details, make sure you do not include the extra (3F) invisible character, which may prevent `SignFile` from finding the certificate.

## See also
- [Task reference](../msbuild/msbuild-task-reference.md)
- [Tasks](../msbuild/msbuild-tasks.md)