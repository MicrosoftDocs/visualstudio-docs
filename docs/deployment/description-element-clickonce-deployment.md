---
title: "&lt;description&gt; Element (ClickOnce Deployment) | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "urn:schemas-microsoft-com:asm.v2#description"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "<description> element [ClickOnce deployment manifest]"
ms.assetid: 18f6919e-a3ab-4942-a57d-167fabfac44e
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# &lt;description&gt; element (ClickOnce deployment)
Identifies application information used to create a shell presence and an **Add or Remove Programs** item in Control Panel.

## Syntax

```xml

      <description 
   publisher 
   product
   suiteName
   supportUrl
/>
```

## Elements and attributes
 The `description` element is required and is in the `urn:schemas-microsoft-com:asm.v1` namespace. It contains no child elements and has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`publisher`|Required. Identifies the company name used for icon placement in the Windows **Start** menu and the **Add or Remove Programs** item in Control Panel, when the deployment is configured for install.|
|`product`|Required. Identifies the full product name. Used as the title for the icon installed in the Windows **Start** menu.|
|`suiteName`|Optional. Identifies a subfolder within the `publisher` folder in the Windows **Start** menu.|
|`supportUrl`|Optional. Specifies a support URL that is shown in the **Add or Remove Programs** item in Control Panel. A shortcut to this URL is also created for application support in the Windows **Start** menu, when the deployment is configured for installation.|

## Remarks
 The description element is required in all deployment configurations.

## Example
 The following code example illustrates a `description` element in a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment manifest. This code example is part of a larger example provided for the [ClickOnce Deployment Manifest](../deployment/clickonce-deployment-manifest.md) topic.

```xml
<description
  asmv2:publisher="My Company Name"
  asmv2:product="My Application"
  xmlns="urn:schemas-microsoft-com:asm.v1" />
```

## See also
- [ClickOnce deployment manifest](../deployment/clickonce-deployment-manifest.md)