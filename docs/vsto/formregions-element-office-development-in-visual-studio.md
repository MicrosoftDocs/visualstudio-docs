---
title: "&lt;formRegions&gt; element (Office development in Visual Studio)"
titleSuffix: ""
ms.custom: "seodec18"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "formRegions element"
  - "<formRegions> element"
  - "application manifests [Office development in Visual Studio], <formRegions> element"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# &lt;formRegions&gt; element (Office development in Visual Studio)
  The `formRegions` element of the `vstov4` namespace contains the Microsoft Office Outlook form regions that are associated with a VSTO Add-in.

## Syntax

```xml
<formRegions>
  <formRegion>
  </formRegion>
</formRegions>
```

## Elements and attributes
 The `formRegions` element of the `vstov4` namespace contains all the `formRegion` elements for an Outlook VSTO Add-in. It is required only for Outlook VSTO Add-ins that include form regions.

 There can be only one `formRegions` element defined in an application manifest.

 The `formRegions` element has no attributes.

 The `formRegions` element has the following element.

### formRegion
 Required for Outlook VSTO Add-ins that include form regions. The `formRegion` element is defined in [&#60;formRegion&#62; element &#40;Office development in Visual Studio&#41;](../vsto/formregion-element-office-development-in-visual-studio.md).

## VSTO Add-in example

### Description
 The following code example illustrates a `formRegions` element in an application manifest for an application-level Office solution deployed using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstov4:formRegions>
  <vstov4:formRegion
      name="OutlookAddIn1.FormRegion1">
    <vstov4:messageClass name="IPM.Note" />
    <vstov4:messageClass name="IPM.Contact" />
    <vstov4:messageClass name="IPM.Appointment" />
  </vstov4:formRegion>
</vstov4:formRegions>
```

## See also

- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)