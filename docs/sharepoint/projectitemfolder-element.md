---
title: "ProjectItemFolder Element | Microsoft Docs"
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
  - "ProjectItemFolder element"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# ProjectItemFolder Element
  Represents a mapped folder.  
  
## Syntax  
  
```  
<ProjectItemFolder Target = "Path of SharePoint folder the mapped folder corresponds to"  
    Type = "Type of deployment for the mapped folder" />  
```  
  
## Type  
 **ProjectItemFolderType**  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|**Target**|Required **xs:string** attribute.<br /><br /> The path of the folder in the SharePoint installation that the mapped folder corresponds to, relative to the deployment root folder. The deployment root folder is determined by the deployment type specified by the **Type** attribute.<br /><br /> For more information, see the descriptions for the **Deployment Path** and **Deployment Root** properties of SharePoint project items in [Developing SharePoint Solutions](../sharepoint/developing-sharepoint-solutions.md).|  
|**Type**|Required **xs:string** attribute.<br /><br /> The type of deployment for the mapped folder. For more information about the possible values, see the description for the **Deployment Type** property of SharePoint project items in [Developing SharePoint Solutions](../sharepoint/developing-sharepoint-solutions.md).|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ProjectItem](../sharepoint/projectitem-element.md)|Represents a SharePoint project item. This is the required root element of the .spdata file.|  
  
## Remarks  
 For more information about mapped folders, see [How to: Add and Remove Mapped Folders](../sharepoint/how-to-add-and-remove-mapped-folders.md).  
  
## Element Information  
  
|||  
|-|-|  
|**Namespace**|http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel|  
|**Schema name**|SharePoint Project Item Schema|  
|**Validation file**|ProjectItemModelSchema.xsd|  
|**Can be empty**|No|  
  
## See Also  
 [SharePoint Project Item Schema Reference](../sharepoint/sharepoint-project-item-schema-reference.md)   
 [How to: Add and Remove Mapped Folders](../sharepoint/how-to-add-and-remove-mapped-folders.md)  
  
  