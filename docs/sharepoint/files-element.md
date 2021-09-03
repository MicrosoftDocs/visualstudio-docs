---
title: "Files Element | Microsoft Docs"
description: View reference information about the Files element, which is an element in the SharePoint project item schema.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Files element"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Files element
  Specifies the files to deploy with the SharePoint project item, such as Feature element files and the output of dependent non-SharePoint projects.

## Syntax

```xml
<Files>
  <ProjectItemFile.../>
  <ProjectOutputFile.../>
</Files>
```

## Type
 **FileCollectionType**

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes
 None.

### Child elements

|Element|Description|
|-------------|-----------------|
|[ProjectItemFile](../sharepoint/projectitemfile-element.md)|Optional **ProjectItemFileType** element.<br /><br /> Represents a SharePoint file, such as Feature element file, to include with the project item when it is deployed to SharePoint.|
|[ProjectOutputFile](../sharepoint/projectoutputfile-element.md)|Optional **ProjectOutputFileType** element.<br /><br /> Represents the output of a project to include with the project item when it is deployed to SharePoint.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[ProjectItem](../sharepoint/projectitem-element.md)|Represents a SharePoint project item. This element the required root element of the `.spdata` file.|

## Element information

|Property|Value|
|-|-|
|**Namespace**|http:\/\/schemas.microsoft.com/VisualStudio/<br>2010/SharePointTools/SharePointProjectItemModel|
|**Schema name**|SharePoint Project Item Schema|
|**Validation file**|ProjectItemModelSchema.xsd|
|**Can be empty**|No|

## See also
- [SharePoint project item schema reference](../sharepoint/sharepoint-project-item-schema-reference.md)
