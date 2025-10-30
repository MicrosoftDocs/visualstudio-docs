---
description: "The document element of the vstov4 namespace stores customization-specific information for document-level customizations."
title: "&lt;document&gt; element (Office development in Visual Studio)"
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "document element"
  - "application manifests [Office development in Visual Studio], <document> element"
  - "<document> element"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# &lt;document&gt; element (Office development in Visual Studio)

  The `document` element of the `vstov4` namespace stores customization-specific information for document-level customizations.

## Syntax

```xml
<document solutionId />
```

## Elements and attributes
 Required only for document-level customizations. The `document` element is in the `vstov4` namespace. The `document` element has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`solutionId`|Required. The GUID used by the Visual Studio Tools for Office runtime to uniquely identify a document-level solution. This value is stored as the _AssemblyLocation custom document property. For more information, see [Custom document properties overview](../vsto/custom-document-properties-overview.md).|

 `document` has no child elements.

## Document-level customization example

### Description
 The following code example illustrates the `document` element in a document-level Office solution deployed by using ClickOnce. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstov4:document
  solutionId="73e" />
```

## Related content

- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
