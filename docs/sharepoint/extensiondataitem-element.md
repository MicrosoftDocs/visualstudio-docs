---
title: "ExtensionDataItem Element | Microsoft Docs"
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
  - "ExtensionDataItem element"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# ExtensionDataItem Element
  Represents a custom data item that is associated with the SharePoint project item, in key/value format. Both the key and value must be strings.  
  
## Syntax  
  
```  
<ExtensionDataItem Key = "Key of the data item"  
    Value = "Value of the data item" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|**Key**|Required **xs:string** attribute.<br /><br /> The key that is used to store and retrieve the data item.|  
|**Value**|Required **xs:string** attribute.<br /><br /> The value of the data item.|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ExtensionData](../sharepoint/extensiondata-element.md)|Represents a collection of custom data items that are associated with the SharePoint project item.|  
  
## Remarks  
 When you associate custom data with a SharePoint project item by using the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData%2A> property of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem> object, Visual Studio saves the data to a new **ExtensionDataItem** element in the .spdata file for the project item. For more information, see [Saving Data in Extensions of the SharePoint Project System](../sharepoint/saving-data-in-extensions-of-the-sharepoint-project-system.md).  
  
## Element Information  
  
|||  
|-|-|  
|**Namespace**|http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel|  
|**Schema name**|SharePoint Project Item Schema|  
|**Validation file**|ProjectItemModelSchema.xsd|  
|**Can be empty**|No|  
  
## See Also  
 [SharePoint Project Item Schema Reference](../sharepoint/sharepoint-project-item-schema-reference.md)  
  
  