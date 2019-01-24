---
title: "&lt;customHostSpecified&gt; element (Office development in Visual Studio)"
titleSuffix: ""
ms.custom: "seodec18"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application manifests [Office development in Visual Studio], <customHostSpecified> element"
  - "<customHostSpecified> element"
  - "customHostSpecified element"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# &lt;customHostSpecified&gt; element (Office development in Visual Studio)
  The `customHostSpecified` element indicates that this solution is not a stand-alone application. Office solutions contain components that are hosted inside Microsoft Office applications.

## Syntax

```xml
<customHostSpecified />
```

## Elements and attributes
 The `customHostSpecified` element is required for Office solutions. This element is in the `co.v1` namespace and specifies that this deployment contains a component that will be deployed inside of a custom host, and is not a stand-alone application.

 This element is a child of the first `<entrypoint>` element in the application manifest. There can be no other child elements in that `<entrypoint>` element or [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] will raise a validation error during installation.

 This element has no attributes and no child elements.

## Example
 The following code example illustrates the `customHostSpecified` element in an application manifest for an Office  solution. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

```xml
<entryPoint>
    <co.v1:customHostSpecified />
</entryPoint>
```

## See also

- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)