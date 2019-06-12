---
title: "&lt;customization&gt; element (Office development in Visual Studio)"
titleSuffix: ""
ms.custom: "seodec18"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application manifests [Office development in Visual Studio], <customization> element"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# &lt;customization&gt; element (Office development in Visual Studio)
  The `customization` element of the `vstov4` namespace describes a specific Office solution. The child elements are different for document-level customizations and VSTO Add-ins.

## Syntax for document-level customizations

```xml
<customization
  id
  <document
    solutionId
  />
</customization>
```

## Syntax for VSTO Add-ins

```xml
<customization
  id
  <appAddin
    application
    loadBehavior
    keyName>
  <friendlyName></friendlyName>
  <description></description>
  <formRegions></formRegions>
</customization>
```

## Elements and attributes
 The `customization` element contains customization-specific information. This element must be in the following namespace: `vstov4=urn:schemas-microsoft-com:vsto.v4`. There is one `customization` element for each Office solution. For example, if you deploy three Office solutions in a multi-project deployment, there are three `customization` elements in the application manifest.

 Child elements of the assembly must also be in this namespace.

 The `customization` element has the following attribute.

|Attribute|Description|
|---------------|-----------------|
|`id`|Required for multi-project deployment. The `id` element uniquely identifies an Office solution.|

### Document-Level customizations
 The `customization` element has the following child element.

#### document
 The `document` element in the `vstov4` namespace is defined in [&#60;document&#62; element &#40;Office development in Visual Studio&#41;](../vsto/document-element-office-development-in-visual-studio.md).

### VSTO Add-ins
 The `customization` element has the following child element.

#### appAddin
 The `appAddin` element in the `vstov4` namespace is defined in [&#60;appAddin&#62; element &#40;Office development in Visual Studio&#41;](../vsto/appaddin-element-office-development-in-visual-studio.md).

## Example of a document-level customization

### Description
 The following code example illustrates the `customization` element for a document-level customization. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstov4:customization>
  <vstov4:document
    solutionId="73e" />
</vstov4:customization>
```

## Example of a VSTO Add-in

### Description
 The following code example illustrates the `customization` element for a VSTO Add-in. This is an Outlook VSTO Add-in that includes form regions. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstov4:customization>
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
</vstov4:customization>
```

## See also

- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)