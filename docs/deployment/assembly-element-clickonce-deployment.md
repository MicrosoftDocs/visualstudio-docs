---
title: "&lt;assembly&gt; Element (ClickOnce Deployment) | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "urn:schemas-microsoft-com:asm.v2#assembly"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "<assembly> element [ClickOnce deployment manifest]"
ms.assetid: b8e3362a-f821-4696-b98d-571d4bbfe431
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# &lt;assembly&gt; element (ClickOnce deployment)
The top-level element for the deployment manifest.

## Syntax

```xml

      <assembly  
   manifestVersion
/>
```

## Elements and attributes
 The `assembly` element is the root element and is required. Its first contained element must be an `assemblyIdentity` element. The manifest elements must be in the following namespaces: `urn:schemas-microsoft-com:asm.v1`, `urn:schemas-microsoft-com:asm.v2`, and `http://www.w3.org/2000/09/xmldsig#`. Child elements of the assembly must also be in these namespaces, by inheritance or by tagging.

 The `assembly` element has the following attribute.

|Attribute|Description|
|---------------|-----------------|
|`manifestVersion`|Required. This attribute must be set to `1.0`.|

## Example
 The following code example illustrates an `assembly` element in a deployment manifest for an application deployed using [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)]. This code example is part of a larger example provided for the [ClickOnce Deployment Manifest](../deployment/clickonce-deployment-manifest.md) topic.

```xml
<asmv1:assembly
  xsi:schemaLocation="urn:schemas-microsoft-com:asm.v1 assembly.adaptive.xsd"
  manifestVersion="1.0"
  xmlns:asmv3="urn:schemas-microsoft-com:asm.v3"
  xmlns:dsig=http://www.w3.org/2000/09/xmldsig#
  xmlns:co.v1="urn:schemas-microsoft-com:clickonce.v1"
  xmlns:co.v2="urn:schemas-microsoft-com:clickonce.v2"
  xmlns="urn:schemas-microsoft-com:asm.v2"
  xmlns:asmv1="urn:schemas-microsoft-com:asm.v1"
  xmlns:asmv2="urn:schemas-microsoft-com:asm.v2"
  xmlns:xrml="urn:mpeg:mpeg21:2003:01-REL-R-NS"
  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
```

## See also
- [ClickOnce deployment manifest](../deployment/clickonce-deployment-manifest.md)
- [\<assembly> element](../deployment/assembly-element-clickonce-application.md)