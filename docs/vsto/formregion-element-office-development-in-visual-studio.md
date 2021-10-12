---
description: "The formRegion element of the vstov4 namespace identifies a Microsoft Office Outlook form region that is associated with a VSTO Add-in."
title: "&lt;formRegion&gt; element (Office development in Visual Studio)"
titleSuffix: ""

ms.date: "02/02/2017"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application manifests [Office development in Visual Studio], <formRegion> element"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# &lt;formRegion&gt; element (Office development in Visual Studio)
  The `formRegion` element of the `vstov4` namespace identifies a Microsoft Office Outlook form region that is associated with a VSTO Add-in.

## Syntax

```xml
<formRegion
  name>
  <messageClass
    name/>
</formRegion>
```

## Elements and attributes
 The `formRegion` element of the `vstov4` namespace identifies a form region that is associated with an Outlook VSTO Add-in. It is required only for Outlook VSTO Add-ins that include form regions.

 There can be multiple `formRegion` elements defined inside a `formRegions` element for a single VSTO Add-in.

 The `formRegion` element has the following attribute.

|Attribute|Description|
|---------------|-----------------|
|`name`|Required. Identifies the form region name.|

 The `formRegion` element has the following child elements.

### messageClass
 The `messageClass` element identifies the Outlook form that is associated with the form region.

 The `messageClass` element has the following attribute.

|Attribute|Description|
|---------------|-----------------|
|`name`|Required. Identifies the form that is associated with the form region.|

## Example
 The following code example illustrates a `formRegion` element in an application manifest for an Outlook VSTO Add-in deployed using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. There are three message classes associated with this one form region. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

```xml
<vstov4:formRegion
    name="OutlookAddIn1.FormRegion1">
  <vstov4:messageClass name="IPM.Note" />
  <vstov4:messageClass name="IPM.Contact" />
  <vstov4:messageClass name="IPM.Appointment" />
</vstov4:formRegion>
```

## See also

- [Create Outlook form regions](../vsto/creating-outlook-form-regions.md)
- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
