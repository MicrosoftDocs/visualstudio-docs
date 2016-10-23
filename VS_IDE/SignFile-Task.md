---
title: "SignFile Task"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: edef1819-ddeb-4e09-95de-fc7063ba9388
caps.latest.revision: 19
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# SignFile Task
Signs the specified file using the specified certificate.  
  
## Parameters  
 The following table describes the parameters of the `SignFile` task.  
  
 Note that SHA-256 certificates are allowed only on machines that have .NET 4.5 and higher.  
  
> [!WARNING]
>  Starting in Visual Studio 2013 Update 3, this task has a new signature that allows you to specify the target framework version for the file. You are encouraged to use the new signature wherever possible, because the MSBuild process uses SHA-256 hashes only when the target framework is .NET 4.5 or higher. If the target framework is .NET 4.0 or below, the SHA-256 hash will not be used.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`CertificateThumbprint`|Required `String` parameter.<br /><br /> Specifies the certificate to use for signing. This certificate must be in the current user's personal store.|  
|`SigningTarget`|Required <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False> parameter.<br /><br /> Specifies the files to sign with the certificate.|  
|`TimestampUrl`|Optional `String` parameter.<br /><br /> Specifies the URL of a time stamping server.|  
|`TargetFrameworkVersion`|The version of the .NET Framework that is used for the target.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [Task Base Class](../VS_IDE/Task-Base-Class.md).  
  
## Example  
 The following example uses the `SignFile` task to sign the files specified in the `FilesToSign` item collection with the certificate specified by the `Certificate` property.  
  
```  
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
>  The certificate thumbprint is the SHA-1 hash of the certificate. For more information, see [Obtain the SHA-1 Hash of a Trusted Root CA Certificate](assetId:///dd641990-9a88-4228-a245-017797131a87).  
  
## Example  
 The following example uses the `Exec` task to sign the files specified in the `FilesToSign` item collection with the certificate specified by the `Certificate` property. You can use this to sign Windows Installer files during the build process.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <ItemGroup>  
        <FileToSign Include="File.msi" />  
    </ItemGroup>  
    <PropertyGroup>  
        <Certificate>Cert.cer</Certificate>  
    </PropertyGroup>  
    <Target Name="Sign">  
        <Exec Command="signtool.exe sign /f CertFile /p Password "@(FileToSign)" "/>  
        <SignFile  
            CertificateThumbprint="$(CertificateThumbprint)"  
            SigningTarget="@(FileToSign)"   
            TargetFrameworkVersion="v4.0" />  
    </Target>  
</Project>  
```  
  
## See Also  
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)   
 [Tasks](../VS_IDE/MSBuild-Tasks.md)