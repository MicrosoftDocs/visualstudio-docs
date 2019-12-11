---
title: "ExtensionData Element | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ExtensionData element"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# ExtensionData element
  Represents a collection of custom data items that are associated with the SharePoint project item.

## Syntax

```xml
<ExtensionData>
  <ExtensionDataItem.../>
</ExtensionData>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes
 None.

### Child elements

|Element|Description|
|-------------|-----------------|
|[ExtensionDataItem](../sharepoint/extensiondataitem-element.md)|Optional element.<br /><br /> Represents a custom data item that is associated with the SharePoint project item, in key/value format. Both the key and value must be strings.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[ProjectItem](../sharepoint/projectitem-element.md)|Represents a SharePoint project item. This element the required root element of the `.spdata` file.|

## Remarks
 When you associate custom data with a SharePoint project item by using the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData%2A> property of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem> object, Visual Studio saves the data to the **ExtensionData** element in the `.spdata` file for the project item. For more information, see [Save data in extensions of the SharePoint project system](../sharepoint/saving-data-in-extensions-of-the-sharepoint-project-system.md).

## Element information

|||
|-|-|
|**Namespace**|http:\/\/schemas.microsoft.com/VisualStudio/<br>2010/SharePointTools/SharePointProjectItemModel|
|**Schema name**|SharePoint Project Item Schema|
|**Validation file**|ProjectItemModelSchema.xsd|
|**Can be empty**|No|

## See also
- [SharePoint project item schema reference](../sharepoint/sharepoint-project-item-schema-reference.md)
