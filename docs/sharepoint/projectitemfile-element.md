---
title: "ProjectItemFile Element | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ProjectItemFile element"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# ProjectItemFile element
  Represents a SharePoint file, such as Feature element file, to include with the project item when it is deployed to SharePoint.

## Syntax

```xml
<ProjectItemFile Source = "Name of the file"
    Target = "Deployment path of the file"
    Type = "Type of deployment for the file" />
```

## Type
 **ProjectItemFileType**

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|**Source**|Required **xs:string** attribute.<br /><br /> The name of the file to deploy with the project item.|
|**Target**|Optional **xs:string** attribute.<br /><br /> The path where the file will be deployed on SharePoint, relative to the deployment root folder. The deployment root folder is determined by the deployment type specified by the **Type** attribute. If the **Target** attribute is not specified, the file will be deployed to a folder with the name specified in the **Source** attribute.<br /><br /> For more information, see the descriptions for the **Deployment Path** and **Deployment Root** properties of SharePoint project items in [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md).|
|**Type**|Required **xs:string** attribute.<br /><br /> The type of deployment for the file. For more information about the possible values, see the description for the **Deployment Type** property of SharePoint project items in [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md).|

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Files](../sharepoint/files-element.md)|Specifies the files to include with the SharePoint project item when it is deployed to SharePoint.|

## Remarks
 SharePoint files that are typically referenced in **ProjectItemFile** elements include Feature element files (*Elements.xml*), schema files for list definitions (*Schema.xml*), and Web Part definition files for Web Parts (*.webpart*).

## Element information

|||
|-|-|
|**Namespace**|http:\/\/schemas.microsoft.com/VisualStudio/<br>2010/SharePointTools/SharePointProjectItemModel|
|**Schema name**|SharePoint Project Item Schema|
|**Validation file**|ProjectItemModelSchema.xsd|
|**Can be empty**|No|

## See also
- [SharePoint project item schema reference](../sharepoint/sharepoint-project-item-schema-reference.md)
