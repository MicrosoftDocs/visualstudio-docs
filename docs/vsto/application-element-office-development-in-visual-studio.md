---
title: "&lt;application&gt; element (Office development in Visual Studio)"
titleSuffix: ""
ms.date: 02/02/2017
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application manifests [Office development in Visual Studio], <application> element"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# &lt;application&gt; element (Office development in Visual Studio)
  The `application` element of the `vstav3` namespace wraps the description of Office solutions. The child elements are different for document-level customizations and VSTO Add-ins.

## Syntax for document-level customizations

```xml
<application>
  <customization
    id
    <document
      solutionId
    />
  </customization>
</application>
```

## Syntax for application-level add-ins

```xml
<application>
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
</application>
```

## Elements and attributes
 The `application` element of the `vstav3` namespace is the node that wraps all the customization-specific information that is contained in the `vstov4` namespace.

 The `application` element has no attributes.

 The `application` element has the following element.

### Customization
 The role of the `customization` element in the `vstov3` namespace is defined in [&#60;customization&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/customization-element-office-development-in-visual-studio.md).

## Document-level customization example

### Description
 The following code example illustrates an `application` element in a document-level Office solution deployed using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstav3:application>
  <vstov4:customizations
    xmlns:vstov4="urn:schemas-microsoft-com:vsto.v4">
    <vstov4:customization>
      <vstov4:document
        solutionId="73e" />
    </vstov4:customization>
  </vstov4:customizations>
</vstav3:application>
```

## VSTO Add-in example

### Description
 The following code example illustrates an `application` element in an application-level Office solution deployed using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstav3:application>
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
</vstav3:application>
```

## See also

- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)