---
title: "ProjectItemFolder Element | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ProjectItemFolder element"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# ProjectItemFolder element
  Represents a mapped folder.

## Syntax

```xml
<ProjectItemFolder Target = "Path of SharePoint folder the mapped folder corresponds to"
    Type = "Type of deployment for the mapped folder" />
```

## Type
 **ProjectItemFolderType**

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|**Target**|Required **xs: string** attribute.<br /><br /> The path of the folder in the SharePoint installation that the mapped folder corresponds to, relative to the deployment root folder. The deployment root folder is determined by the deployment type specified by the **Type** attribute.<br /><br /> For more information, see the descriptions for the **Deployment Path** and **Deployment Root** properties of SharePoint project items in [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md).|
|**Type**|Required **xs:string** attribute.<br /><br /> The type of deployment for the mapped folder. For more information about the possible values, see the description for the **Deployment Type** property of SharePoint project items in [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md).|

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[ProjectItem](../sharepoint/projectitem-element.md)|Represents a SharePoint project item. This element is the required root element of the *.spdata* file.|

## Remarks
 For more information about mapped folders, see [How to: add and remove mapped folders](../sharepoint/how-to-add-and-remove-mapped-folders.md).

## Element information

|||
|-|-|
|**Namespace**|http:\/\/schemas.microsoft.com/VisualStudio/2010/<br>SharePointTools/SharePointProjectItemModel|
|**Schema name**|SharePoint Project Item Schema|
|**Validation file**|ProjectItemModelSchema.xsd|
|**Can be empty**|No|

## See also
- [SharePoint project item schema reference](../sharepoint/sharepoint-project-item-schema-reference.md)
- [How to: add and remove mapped folders](../sharepoint/how-to-add-and-remove-mapped-folders.md)
