---
title: "&lt;compatibleFrameworks&gt; Element (ClickOnce Deployment) | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "<compatibleFrameworks> element [ClickOnce deployment manifest]"
ms.assetid: f6c3ee55-9e65-403d-8664-3ebde872c7d4
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# &lt;compatibleFrameworks&gt; element (ClickOnce deployment)
Identifies the versions of the .NET Framework where this application can install and run.

> [!NOTE]
> [*MageUI.exe*](/dotnet/framework/tools/mageui-exe-manifest-generation-and-editing-tool-graphical-client) does not support the `compatibleFrameworks` element when saving an application manifest that has already been signed with a certificate using [*MageUI.exe*](/dotnet/framework/tools/mageui-exe-manifest-generation-and-editing-tool-graphical-client). Instead, you must use [*Mage.exe*](/dotnet/framework/tools/mage-exe-manifest-generation-and-editing-tool).

## Syntax

```xml
<compatibleFrameworks
      SupportUrl> 
   <framework
      targetVersion
      profile
      supportedRuntime
   /> 
</ compatibleFrameworks>
```

## Elements and attributes
 The `compatibleFrameworks` element is required for deployment manifests that target the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] runtime provided by .NET Framework 4 or later. The `compatibleFrameworks` element contains one or more `framework` elements that specify the .NET Framework versions on which this application can run. The [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] runtime will run the application on the first available `framework` in this list.

 The following table lists the attribute that the `compatibleFrameworks` element supports.

|Attribute|Description|
|---------------|-----------------|
|`S` `upportUrl`|Optional. Specifies a URL where the preferred compatible .NET Framework version can be downloaded.|

## framework
 Required. The following table lists the attributes that the `framework` element supports.

|Attribute|Description|
|---------------|-----------------|
|`targetVersion`|Required. Specifies the version number of the target .NET Framework.|
|`profile`|Required. Specifies the profile of the target .NET Framework.|
|`supportedRuntime`|Required. Specifies the version number of the runtime associated with the target .NET Framework.|

## Remarks

## Example
 The following code example shows a `compatibleFrameworks` element in a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment manifest. This deployment can run on the [!INCLUDE[net_client_v40_long](../deployment/includes/net_client_v40_long_md.md)]. It can also run on the .NET Framework 4 because it is a superset of the [!INCLUDE[net_client_v40_long](../deployment/includes/net_client_v40_long_md.md)].

```xml
<compatibleFrameworks xmlns="urn:schemas-microsoft-com:clickonce.v2">
  <framework
      targetVersion="4.0"
      profile="Client"
      supportedRuntime="4.0.30319" />
</compatibleFrameworks>
```

## See also
- [ClickOnce deployment manifest](../deployment/clickonce-deployment-manifest.md)