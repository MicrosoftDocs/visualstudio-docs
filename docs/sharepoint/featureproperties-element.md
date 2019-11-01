---
title: "FeatureProperties Element | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "FeatureProperties element"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# FeatureProperties element
  A collection of property values that are included with a Feature when it is deployed to SharePoint. After a Feature is deployed, you can access the property values in your code.

## Syntax

```xml
<FeatureProperties>
  <FeatureProperty.../>
</FeatureProperties>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes
 None.

### Child elements

|Element|Description|
|-------------|-----------------|
|[FeatureProperty](../sharepoint/featureproperty-element.md)|Optional element.<br /><br /> Represents a custom property, in key/value format.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[ProjectItem](../sharepoint/projectitem-element.md)|Represents a SharePoint project item. This element the required root element of the `.spdata` file.|

## Remarks
 For more information about Feature properties, see [Provide packaging and deployment information in project items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md).

## Element information

|Element|Description|
|-------------|-----------------|
|**Namespace**|http:\/\/schemas.microsoft.com/VisualStudio/<br>2010/SharePointTools/SharePointProjectItemModel|
|**Schema name**|SharePoint Project Item Schema|
|**Validation file**|ProjectItemModelSchema.xsd|
|**Can be empty**|No|

## See also
- [SharePoint project item schema reference](../sharepoint/sharepoint-project-item-schema-reference.md)
- [Provide packaging and deployment information in project items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md)
