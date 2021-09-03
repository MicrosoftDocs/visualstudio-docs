---
title: "&lt;assemblyIdentity&gt; Element (ClickOnce Application) | Microsoft Docs"
description: The assemblyIdentity element is required in ClickOnce application. It contains no child elements and has attributes described in this article.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "urn:schemas-microsoft-com:asm.v2#assemblyIdentity"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "<assemblyIdentity> element [ClickOnce application manifest]"
ms.assetid: f48e9531-efac-4d11-8166-f63a5ece1ac5
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload:
  - "multiple"
---
# &lt;assemblyIdentity&gt; element (ClickOnce application)
Identifies the application deployed in a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment.

## Syntax

```xml

      <assemblyIdentity
   name
   version
   publicKeyToken
   processorArchitecture
   language
/>
```

## Elements and attributes
 The `assemblyIdentity` element is required. It contains no child elements and has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`Name`|Required. Identifies the name of the application.<br /><br /> If `Name` contains special characters, such as single or double quotes, the application may fail to activate.|
|`Version`|Required. Specifies the version number of the application in the following format: `major.minor.build.revision`|
|`publicKeyToken`|Optional. Specifies a 16-character hexadecimal string that represents the last 8 bytes of the `SHA-1` hash value of the public key under which the application or assembly is signed. The public key that is used to sign the catalog must be 2048 bits or greater.<br /><br /> Although signing an assembly is recommended but optional, this attribute is required. If an assembly is unsigned, you should copy a value from a self-signed assembly or use a "dummy" value of all zeros.|
|`processorArchitecture`|Required. Specifies the processor. The valid values are `msil` for all processors, `x86` for 32-bit Windows, `IA64` for 64-bit Windows, and `Itanium` for Intel 64-bit Itanium processors.|
|`language`|Required. Identifies the two part language codes (for example, `en-US`) of the assembly. This element is in the `asmv2` namespace. If unspecified, the default is `neutral`.|

## Examples

### Description
 The following code example illustrates an `assemblyIdentity` element in a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application manifest. This code example is part of a larger example provided in [ClickOnce Application Manifest](../deployment/clickonce-application-manifest.md).

### Code

```xml
<asmv1:assemblyIdentity
  name="My Application Deployment.exe"
  version="1.0.0.0"
  publicKeyToken="43cb1e8e7a352766"
  language="neutral"
  processorArchitecture="x86"
  type="win32" />
```

## See also
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
- [\<assemblyIdentity> element](../deployment/assemblyidentity-element-clickonce-deployment.md)