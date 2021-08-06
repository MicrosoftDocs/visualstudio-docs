---
title: "ExtensionDataItem Element | Microsoft Docs"
description: View reference information about the ExtensionDataItem element, which is an element in the SharePoint project item schema.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ExtensionDataItem element"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# ExtensionDataItem element
  A custom data item that is associated with the SharePoint project item, in key/value format. Both the key and value must be strings.

## Syntax

```xml
<ExtensionDataItem Key = "Key of the data item"
    Value = "Value of the data item" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|**Key**|Required **xs: string** attribute.<br /><br /> The key that is used to store and retrieve the data item.|
|**Value**|Required **xs:string** attribute.<br /><br /> The value of the data item.|

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[ExtensionData](../sharepoint/extensiondata-element.md)|Represents a collection of custom data items that are associated with the SharePoint project item.|

## Remarks
 When you associate custom data with a SharePoint project item by using the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData%2A> property of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem> object, Visual Studio saves the data to a new **ExtensionDataItem** element in the `.spdata` file for the project item. For more information, see [Save data in extensions of the SharePoint project system](../sharepoint/saving-data-in-extensions-of-the-sharepoint-project-system.md).

## Element information

|Property|Value|
|-|-|
|**Namespace**|http:\/\/schemas.microsoft.com/VisualStudio/<br>2010/SharePointTools/SharePointProjectItemModel|
|**Schema name**|SharePoint Project Item Schema|
|**Validation file**|ProjectItemModelSchema.xsd|
|**Can be empty**|No|

## See also
- [SharePoint project item schema reference](../sharepoint/sharepoint-project-item-schema-reference.md)
