---
title: "How to: Use a Resource File to Specify Localized Names, Properties, and Permissions | Microsoft Docs"
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
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Business Data Connectivity service [SharePoint development in Visual Studio], localize strings"
  - "BDC [SharePoint development in Visual Studio], localize strings"
  - "BDC [SharePoint development in Visual Studio], resource file"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], resource strings"
  - "BDC [SharePoint development in Visual Studio], properties"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], properties"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], resource file"
  - "BDC [SharePoint development in Visual Studio], resource strings"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Use a Resource File to Specify Localized Names, Properties, and Permissions
  By using a resource file, you can provide localized names, define properties, and apply permissions tor objects that are defined in a Business Data Connectivity (BDC) model. To specify this information, you add a **Business Data Connectivity Resource** item to a project that contains a **Business Data Connectivity Model** item. Then you specify names, properties and permissions by editing the XML for the resource file.  
  
### To add a BDC resource file to a SharePoint project  
  
1.  In **Solution Explorer**, expand the folder for the SharePoint project, and then choose the folder that contains the BDC model.  
  
2.  On the menu bar, choose **Project**, **Add New Item**.  
  
3.  Expand the **SharePoint** node, and then choose the **2010** node.  
  
4.  In the **Add New Item** dialog box, choose **Business Data Connectivity Resource Item**.  
  
5.  In the **Name** box, specify the name of the resource file, and then choose the **Add** button.  
  
     A resource file that has the .bdcr extension is added to the project and opened for editing.  
  
6.  Add XML to define the localized names, properties, and permissions that you want to apply the BDC model.  
  
     For information about how to define these elements, see [Model and Resource Files](http://go.microsoft.com/fwlink/?LinkID=169283).  
  
## See Also  
 [How to: Add an Existing BDC Model File to a SharePoint Project](../sharepoint/how-to-add-an-existing-bdc-model-file-to-a-sharepoint-project.md)   
 [Creating a Business Data Connectivity Model](../sharepoint/creating-a-business-data-connectivity-model.md)   
 [How to: Create a BDC Model](../sharepoint/how-to-create-a-bdc-model.md)   
 [How to: Include a Custom Assembly in a BDC Feature](../sharepoint/how-to-include-a-custom-assembly-in-a-bdc-feature.md)   
 [Integrating Business Data into SharePoint](../sharepoint/integrating-business-data-into-sharepoint.md)  
  
  