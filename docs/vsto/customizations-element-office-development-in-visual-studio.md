---
title: "&lt;customizations&gt; element (Office development in Visual Studio)"
description: Learn how the customizations element of the vstov4 namespace contains all the information about installing and loading each Office solution.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "<customizations> element"
  - "customizations element"
  - "application manifests [Office development in Visual Studio], <customizations> element"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# &lt;customizations&gt; element (Office development in Visual Studio)

  The `customizations` element of the `vstov4` namespace contains all the information about installing and loading each Office solution.

## Syntax for document-level customizations

```xml
<customizations>
  <customization
    id
    <document
      solutionId
    />
  </customization>
</customizations>
```

## Syntax for VSTO Add-ins

```xml
<customizations>
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
</customizations>
```

## Elements and attributes
 The `customizations` element contains specific information about each Office solution. This element must be in the following namespace: `vstov4=urn:schemas-microsoft-com:vsto.v4`. Child elements of the assembly must also be in this namespace.

 The `customizations` element has no attributes.

 The `customizations` element has the following child element.

### Customization
 Required. The `customization` element in the `vstov4` namespace is defined in [&#60;customization&#62; element &#40;Office development in Visual Studio&#41;](../vsto/customization-element-office-development-in-visual-studio.md).

## Example of a document-level customization

### Description
 The following code example illustrates the `customizations` element for a document-level customization.

> [!NOTE]
> This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstov4:customizations
  xmlns:vstov4="urn:schemas-microsoft-com:vsto.v4">
  <vstov4:customization>
    <vstov4:document
      solutionId="73e" />
  </vstov4:customization>
</vstov4:customizations>
```

## Example of a VSTO Add-in

### Description
 The following code example illustrates the `customizations` element for a VSTO Add-in. This is an Outlook VSTO Add-in that includes form regions. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstov4:customizations
  xmlns:vstov4="urn:schemas-microsoft-com:vsto.v4">
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
</vstov4:customizations>
```

## Related content

- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
