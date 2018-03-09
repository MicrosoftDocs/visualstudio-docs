---
title: "ProjectItemFile Element | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "ProjectItemFile element"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# ProjectItemFile Element
  Represents a SharePoint file, such as Feature element file, to include with the project item when it is deployed to SharePoint.  
  
## Syntax  
  
```  
<ProjectItemFile Source = "Name of the file"  
    Target = "Deployment path of the file"  
    Type = "Type of deployment for the file" />  
```  
  
## Type  
 **ProjectItemFileType**  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|**Source**|Required **xs:string** attribute.<br /><br /> The name of the file to deploy with the project item.|  
|**Target**|Optional **xs:string** attribute.<br /><br /> The path where the file will be deployed on SharePoint, relative to the deployment root folder. The deployment root folder is determined by the deployment type specified by the **Type** attribute. If the **Target** attribute is not specified, the file will be deployed to a folder with the name specified in the **Source** attribute.<br /><br /> For more information, see the descriptions for the **Deployment Path** and **Deployment Root** properties of SharePoint project items in [Developing SharePoint Solutions](../sharepoint/developing-sharepoint-solutions.md).|  
|**Type**|Required **xs:string** attribute.<br /><br /> The type of deployment for the file. For more information about the possible values, see the description for the **Deployment Type** property of SharePoint project items in [Developing SharePoint Solutions](../sharepoint/developing-sharepoint-solutions.md).|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Files](../sharepoint/files-element.md)|Specifies the files to include with the SharePoint project item when it is deployed to SharePoint.|  
  
## Remarks  
 SharePoint files that are typically referenced in **ProjectItemFile** elements include Feature element files (Elements.xml), schema files for list definitions (Schema.xml), and Web Part definition files for Web Parts (.webpart).  
  
## Element Information  
  
|||  
|-|-|  
|**Namespace**|http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel|  
|**Schema name**|SharePoint Project Item Schema|  
|**Validation file**|ProjectItemModelSchema.xsd|  
|**Can be empty**|No|  
  
## See Also  
 [SharePoint Project Item Schema Reference](../sharepoint/sharepoint-project-item-schema-reference.md)  
  
  