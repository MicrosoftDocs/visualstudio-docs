---
title: "FeatureProperty Element | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "FeatureProperty element"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# FeatureProperty element
  Represents a custom property that is included with a Feature when it is deployed to SharePoint. After a Feature is deployed, you can access the property in your code.

## Syntax

```xml
<FeatureProperty Key = "Key of the property value"
    Value = "Property value" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|**Key**|Required **xs:string** attribute.<br /><br /> The key that is used to store and retrieve the property value. Each property must have a key that is unique within the Feature.|
|**Value**|Required **xs:string** attribute.<br /><br /> The property value.|

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[FeatureProperties](../sharepoint/featureproperties-element.md)|Represents a collection of property values that are included with a Feature when it is deployed to SharePoint.|

## Remarks
 For more information about Feature properties, see [Providing package and deployment information in project items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md).

## Element information

|||
|-|-|
|**Namespace**|http:\/\/schemas.microsoft.com/VisualStudio/<br>2010/SharePointTools/SharePointProjectItemModel|
|**Schema name**|SharePoint Project Item Schema|
|**Validation file**|ProjectItemModelSchema.xsd|
|**Can be empty**|No|

## See also
- [SharePoint project item schema reference](../sharepoint/sharepoint-project-item-schema-reference.md)
- [Provide packaging and deployment information in project items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md)
