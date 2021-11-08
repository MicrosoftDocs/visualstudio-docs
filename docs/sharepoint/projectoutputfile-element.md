---
title: "ProjectOutputFile Element | Microsoft Docs"
description: Get reference information about the ProjectOutputFile element, which represents output of a separate project in the SharePoint project item XML schema reference.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ProjectOutputFile element"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# ProjectOutputFile element
  Represents the output of a separate project to include with the project item when it is deployed to SharePoint.

## Syntax

```xml
<ProjectOutputFile ProjectId = "GUID of the project"
    ProjectPath = "Relative path of the project"
    Target = "Deployment path of the project output"
    Type = "Type of deployment for the project output" />
```

## Type
 **ProjectOutputFileType**

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|**ProjectId**|Required **xs:string** attribute.<br /><br /> The GUID of the dependent project that has the output you want to include. This corresponds to the **ProjectGuid** element in the dependent project file.|
|**ProjectPath**|Required **xs:string** attribute.<br /><br /> The relative path, including the project file name, of the dependent project that has the output you want to include. This path is relative to the root folder of the SharePoint project that contains the SharePoint project item.|
|**Target**|Optional **xs:string** attribute.<br /><br /> The path where the dependent project output is to be deployed on the SharePoint server, relative to the deployment root folder. The deployment root folder is determined by the deployment type specified by the **Type** attribute.<br /><br /> For more information, see the descriptions for the **Deployment Path** and **Deployment Root** properties of SharePoint project items in [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md).|
|**Type**|Required **xs:string** attribute.<br /><br /> The type of deployment to use for the output of the dependent project. For more information about the possible values, see the description for the **Deployment Type** property of SharePoint project items in [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md).|

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Files](../sharepoint/files-element.md)|Specifies the files to include with the SharePoint project item when it is deployed to SharePoint.|

## Remarks
 Use the **ProjectOutputFile** element to include the output of a project in the deployment of the SharePoint project item. You can specify a different project, or the same project that contains the project item. For more information, see [Provide packaging and deployment information in project items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md).

## Element information

|Property|Value|
|-|-|
|**Namespace**|http:\/\/schemas.microsoft.com/VisualStudio/<br>2010/SharePointTools/SharePointProjectItemModel|
|**Schema name**|SharePoint Project Item Schema|
|**Validation file**|ProjectItemModelSchema.xsd|
|**Can be empty**|No|

## See also
- [SharePoint project item schema reference](../sharepoint/sharepoint-project-item-schema-reference.md)
- [Provide packaging and deployment information in project items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md)
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
