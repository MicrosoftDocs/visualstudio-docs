---
title: "&lt;postActionData&gt; element (Office development)"
description: "The postActionData element of the vstav3 namespace specifies the data associated with any post-deployment action that runs after Office solutions are installed."
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "<postActionData> element"
  - "application manifests [Office development in Visual Studio], <postActionData> element"
  - "postActionData element"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# &lt;postActionData&gt; element (Office development)
  The `postActionData` element of the `vstav3` namespace specifies the data associated with any post-deployment action that runs after Office solutions are installed.

## Syntax

```xml
<postActionData>
</postActionData>
```

## Elements and attributes
 The `postActionData` element is optional and is in the `vstav3` namespace. There is one `postActionData` element defined in an application manifest for each post-deployment action.

 The `postActions` element has no attributes.

 `postActions` has no child elements.

## Post-deployment action example

### Description
 The following code example illustrates the `postAction` element in an application manifest for an Office solution deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstav3:postActionData>
  data in any format
</vstav3:postActionData>
```

## See also

- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
