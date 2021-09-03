---
title: "&lt;PackageFiles&gt; Element (Bootstrapper) | Microsoft Docs"
description: Learn about the PackageFiles element, which contains PackageFile elements that define the installation packages executed as a result of the Command element.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "<PackageFiles> element [bootstrapper]"
ms.assetid: 3ea252d7-18a3-47d8-af83-47feebcfe82b
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload:
  - "multiple"
---
# &lt;PackageFiles&gt; element (bootstrapper)
The `PackageFiles` element contains `PackageFile` elements, which define the installation packages executed as a result of the `Command` element.

## Syntax

```xml
<PackageFiles
    CopyAllPackageFiles
>
    <PackageFile
        Name
        HomeSite
        CopyOnBuild
        PublicKey
        Hash
    />
</PackageFiles>
```

## Elements and attributes
 The `PackageFiles` element has the following attribute.

|Attribute|Description|
|---------------|-----------------|
|`CopyAllPackageFiles`|Optional. If set to `false`, the installer will only download files referenced from the `Command` element. If set to `true`, all files will be downloaded.<br /><br /> If set to `IfNotHomesite`, the installer will behave the same as if `False` if `ComponentsLocation` is set to `HomeSite`, and otherwise will behave the same as if `True`. This setting can be useful to allow packages that are themselves bootstrappers to execute their own behavior in a HomeSite scenario.<br /><br /> The default is `true`.|

## PackageFile
 The `PackageFile` element is a child of the `PackageFiles` element. A `PackageFiles` element must have at least one `PackageFile` element.

 `PackageFile` has the following attributes.

| Attribute | Description |
|---------------| - |
| `Name` | Required. The name of the package file. This is the name that the `Command` element will reference when it defines the conditions under which a package installs. This value is also used as a key into the `Strings` table to retrieve the localized name that tools such as [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] will use to describe the package. |
| `HomeSite` | Optional. The location of the package on the remote server, if it is not included with the installer. |
| `CopyOnBuild` | Optional. Specifies whether the bootstrapper should copy the package file onto the disk at build time. The default is true. |
| `PublicKey` | The encrypted public key of the package's certificate signer. Required if `HomeSite` is used; otherwise, optional. |
| `Hash` | Optional. An SHA1 hash of the package file. This is used to verify the integrity of the file at install time. If the identical hash cannot be computed from the package file, the package will not be installed. |

## Example
 The following code example defines packages for the .NET Framework redistributable package and its dependencies, such as the Windows Installer.

```xml
<PackageFiles>
    <PackageFile Name="instmsia.exe" HomeSite="InstMsiAExe" PublicKey="3082010A0282010100AA99BD39A81827F42B3D0B4C3F7C772EA7CBB5D18C0DC23A74D793B5E0A04B3F595ECE454F9A7929F149CC1A47EE55C2083E1220F855F2EE5FD3E0CA96BC30DEFE58C82732D08554E8F09110BBF32BBE19E5039B0B861DF3B0398CB8FD0B1D3C7326AC572BCA29A215908215E277A34052038B9DC270BA1FE934F6F335924E5583F8DA30B620DE5706B55A4206DE59CBF2DFA6BD154771192523D2CB6F9B1979DF6A5BF176057929FCC356CA8F440885558ACBC80F464B55CB8C96774A87E8A94106C7FF0DE968576372C36957B443CF323A30DC1BE9D543262A79FE95DB226724C92FD034E3E6FB514986B83CD0255FD6EC9E036187A96840C7F8E203E6CF050203010001"/>
    <PackageFile Name="WindowsInstaller-KB884016-v2-x86.exe" HomeSite="Msi30Exe" PublicKey="3082010A0282010100B22D8709B55CDF5599EB5262E7D3F4E34571A932BF94F20EE90DADFE9DC7046A584E9CA4D1D84441FB647E0F65EEC817DA4DDBD9D650B40C565B6C16884BBF03EE504883EC4F88939A51E394197FFAB397A5CE606D9FDD4C9338BDCD345971E686CEE98399A096B8EAE0445B1342B93A484E5472F70896E400C482017643AF61C2DBFAE5C5F00213DDF835B40F0D5236467443B1A2CA9CDD7E99F1351177FB1526018ECFE0B804782A15FD72C66076910CE74FB218181B6989B4F12F211B66EACA91C7460DB91758715856866523D10232AE64A06FDA5295FDFBDD8D34F5C10C35A347D7E91B6AFA0F45B4E8321D7019BDD1F9E5641FEB8737EA6FD40D838FFD0203010001"/>
    <PackageFile Name="dotnetfx.exe" HomeSite="DotNetFXExe" PublicKey="3082010A0282010100B22D8709B55CDF5599EB5262E7D3F4E34571A932BF94F20EE90DADFE9DC7046A584E9CA4D1D84441FB647E0F65EEC817DA4DDBD9D650B40C565B6C16884BBF03EE504883EC4F88939A51E394197FFAB397A5CE606D9FDD4C9338BDCD345971E686CEE98399A096B8EAE0445B1342B93A484E5472F70896E400C482017643AF61C2DBFAE5C5F00213DDF835B40F0D5236467443B1A2CA9CDD7E99F1351177FB1526018ECFE0B804782A15FD72C66076910CE74FB218181B6989B4F12F211B66EACA91C7460DB91758715856866523D10232AE64A06FDA5295FDFBDD8D34F5C10C35A347D7E91B6AFA0F45B4E8321D7019BDD1F9E5641FEB8737EA6FD40D838FFD0203010001"/>
    <PackageFile Name="dotnetchk.exe"/>
</PackageFiles>
```

## See also
- [\<Product> element](../deployment/product-element-bootstrapper.md)
- [\<Package> element](../deployment/package-element-bootstrapper.md)
- [Product and package schema reference](../deployment/product-and-package-schema-reference.md)