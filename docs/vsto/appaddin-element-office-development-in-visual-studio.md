---
title: "&lt;appAddin&gt; element (Office development in Visual Studio)"
description: Learn how the appAddin element of the vstov4 namespace stores customization-specific information for VSTO Add-ins.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: 02/02/2017
ms.topic: reference
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application manifests [Office development in Visual Studio], <appAddin> element"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# &lt;appAddin&gt; element (Office development in Visual Studio)
  The **appAddin** element of the `vstov4` namespace stores customization-specific information for VSTO Add-ins.

## Syntax

```xml
<appAddin
  application
  loadBehavior
  keyName>
  <friendlyName>
  <description>
  <formRegions></formRegions>
</appAddin>
```

## Elements and attributes
 The **appAddin** element is required and is in the `vstov4` namespace. There is only one **appAddin** element defined in an application manifest.

 The **appAddin** element has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|**application**|Required. Identifies the Microsoft Office application. The value can be one of the following: Excel, InfoPath, Outlook, PowerPoint, Project, Visio, or Word.|
|**loadBehavior**|Optional. By default, the **loadBehavior** is enabled by setting this value to . For debugging, the VSTO Add-in can be disabled by setting the value to two. For more information, see the table titled LoadBehavior Values in [Registry entries for VSTO Add-ins](../vsto/registry-entries-for-vsto-add-ins.md).|
|**keyName**|Required. This value is the registry key name that will be used by the application to load the VSTO Add-in. For more information, see [Registry entries for VSTO Add-ins](../vsto/registry-entries-for-vsto-add-ins.md).|

 The **appAddin** element has the following child elements.

### friendlyName
 Optional. The **friendlyName** element is explained in [&#60;friendlyName&#62; element &#40;Office development in Visual Studio&#41;](../vsto/friendlyname-element-office-development-in-visual-studio.md).

### description
 Optional. The **description** element is explained in [&#60;description&#62; element &#40;Office development in Visual Studio&#41;](../vsto/description-element-office-development-in-visual-studio.md).

### formRegions
 Required only for Outlook VSTO Add-ins that include form regions. The **formRegions** element is explained in [&#60;formRegions&#62; element &#40;Office development in Visual Studio&#41;](../vsto/formregions-element-office-development-in-visual-studio.md).

## VSTO Add-in example

### Description
 The following code example illustrates **appAddin** elements in an Outlook solution deployed using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstov4:appAddIn
  application="Outlook"
  loadBehavior="3"
  keyName="ContosoOutlookAddIn">
  <vstov4:friendlyName>
    ContosoOutlookAddIn
  </vstov4:friendlyName>
  <vstov4:description>
    ContosoOutlookAddIn - Outlook VSTO Add-in
    created with Visual Studio Tools for Office
  </vstov4:description>
  <vstov4:formRegions>
    <vstov4:formRegion
        name="OutlookAddIn1.FormRegion1">
      <vstov4:messageClass name="IPM.Note" />
      <vstov4:messageClass name="IPM.Contact" />
      <vstov4:messageClass name="IPM.Appointment" />
    </vstov4:formRegion>
  </vstov4:formRegions>
</vstov4:appAddIn>
```

## See also

- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)