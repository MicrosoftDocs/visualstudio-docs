---
title: "&lt;description&gt; element (Office development in Visual Studio)"
description: Learn that the description element of the vstov4 namespace stores the description for the Office solution that appears in the COM add-ins dialog box.
titleSuffix: ""
ms.custom: "SEO-VS-2020"
ms.date: "02/02/2017"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "description element"
  - "<description> element"
  - "application manifests [Office development in Visual Studio], <description> element"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# &lt;description&gt; element (Office development in Visual Studio)
  The `description` element of the `vstov4` namespace stores the description for the Office solution that appears in the COM add-ins dialog box of Microsoft Office applications.

## Syntax

```xml
<description>
</description>
```

## Elements and attributes
 Optional. The `description` element is in the `vstov4` namespace. It contains the description of the add-in that appears in the COM add-ins dialog box of Microsoft Office applications.

 The `description` element has no attributes or elements.

## VSTO Add-in example

### Description
 The following code example illustrates the `description` element for an application-level solution deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstov4:description>
  ContosoOutlookAddIn - Outlook add-in
  created with Visual Studio Tools for Office
</vstov4:description>
```

## See also

- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)