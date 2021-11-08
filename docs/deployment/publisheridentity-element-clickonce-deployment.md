---
title: "&lt;publisherIdentity&gt; Element (ClickOnce Deployment) | Microsoft Docs"
description: The publisherIdentity element contains information about the publisher that signed a deployment manifest. The element is required for signed manifests.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "publisherIdentity Element [ClickOnce deployment manifest], introduction"
  - "required element for signed manifests [ClickOnce], publisherIdentity Element"
  - "publisherIdentity Element [ClickOnce deployment manifest], syntax, elements, and attributes"
ms.assetid: 34c579db-d2f2-4b66-b9c8-47207f33d950
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload:
  - "multiple"
---
# &lt;publisherIdentity&gt; element (ClickOnce deployment)
Contains information about the publisher that signed this deployment manifest.

## Syntax

```xml
<publisherIdentity
   name
   issuerKeyHash
/>
```

## Elements and attributes
 The `publisherIdentity` element is required for signed manifests. The following table shows the attributes that the `publisherIdentity` element supports.

|Attribute|Description|
|---------------|-----------------|
|`name`|Required. Describes the identity of the party that published this application.|
|`issuerKeyHash`|Required. Contains the SHA-1 hash of the public key of the certificate issuer.|

#### Parameters

## Property value/return value

## Exceptions

## Remarks

## Requirements

## Subhead