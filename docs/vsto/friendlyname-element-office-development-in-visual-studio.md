---
description: "The friendlyName element of the vstov4 namespace stores the name that appears in the list of installed programs."
title: "&lt;friendlyName&gt; element (Office development in Visual Studio)"
titleSuffix: ""

ms.date: "02/02/2017"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application manifests [Office development in Visual Studio], <friendlyName> element"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# &lt;friendlyName&gt; element (Office development in Visual Studio)
  The `friendlyName` element of the `vstov4` namespace stores the name that appears in the list of installed programs.

## Syntax

```xml
<friendlyName>
</friendlyName>
```

## Elements and attributes
 The `friendlyName` element is in the `vstov4` namespace. The value appears in the list of installed programs on the computer, and in the COM VSTO Add-ins dialog box of Microsoft Office applications.

 The `friendlyName` element has no attributes or child elements.

## VSTO Add-in example

### Description
 The following code example illustrates the `friendlyName` element in an application-level solution deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstov4:friendlyName>
  ContosoOutlookAddIn
</vstov4:friendlyName>
```

## See also

- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
