---
title: "SafeControls Element | Microsoft Docs"
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
  - "SafeControls element"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# SafeControls Element
  Represents a collection of ASPX controls and Web Parts that are designated as secure for any user to access on any ASPX page on the SharePoint site.  
  
## Syntax  
  
```  
<SafeControls>  
  <SafeControl.../>  
</SafeControls>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[SafeControl](../sharepoint/safecontrol-element.md)|Optional element.<br /><br /> Represents an ASPX control or Web Part that is designated as secure for any user to access on any ASPX page on the SharePoint site.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ProjectItem](../sharepoint/projectitem-element.md)|Represents a SharePoint project item. This is the required root element of the .spdata file.|  
  
## Remarks  
 For more information about safe controls, see [Providing Packaging and Deployment Information in Project Items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md).  
  
## Element Information  
  
|||  
|-|-|  
|**Namespace**|http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel|  
|**Schema name**|SharePoint Project Item Schema|  
|**Validation file**|ProjectItemModelSchema.xsd|  
|**Can be empty**|No|  
  
## See Also  
 [SharePoint Project Item Schema Reference](../sharepoint/sharepoint-project-item-schema-reference.md)   
 [Providing Packaging and Deployment Information in Project Items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md)  
  
  