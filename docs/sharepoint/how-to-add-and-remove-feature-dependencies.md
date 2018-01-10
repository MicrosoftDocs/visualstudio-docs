---
title: "How to: Add and Remove Feature Dependencies | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "MICROSOFT.VISUALSTUDIO.SHAREPOINT.DESIGNERS.CUSTOMDEPENDENCYWINDOW"
  - "VS.SHAREPOINTTOOLS.RAD.FEATUREDESIGNERDEPENDENCY"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, features"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Add and Remove Feature Dependencies
  Your SharePoint Feature may depend on other Features for functionality or data. In these cases, you can mark these other Features as dependencies for your Feature. This way, the SharePoint server ensures that dependent Features are activated before your Feature is activated.  
  
## Adding Dependencies  
 You can add other Features in your solution as dependencies. This way, you can make sure that required Features are installed and activated before your feature is installed.  
  
#### To add a dependency on a Feature in the solution  
  
1.  Open the Feature Designer, expand the **Feature Activation Dependencies** node, and then choose the **Add** button.  
  
2.  In the **Add Feature Activation Dependencies** dialog box, choose the **Add a dependency on features in the solution** option button, choose the title of the feature that you want to add as a dependency, and then choose the **Add** button.  
  
     You can add more than one feature by choosing multiple titles while choosing the Ctrl key.  
  
## Adding Custom Dependencies  
 You can add Features that are already deployed on a SharePoint server as a dependency. This way, the SharePoint activation process checks to make sure that all dependent Features are activated before your Feature is installed.  
  
#### To add a dependency by the Feature ID  
  
1.  Open the Feature Designer, expand the **Feature Activation Dependencies** node, and then choose the **Add** button.  
  
2.  In the **Add Feature Activation Dependencies** dialog box, choose the **Add a custom dependency** option button.  
  
3.  In the **Feature ID** text box, enter the GUID for the Feature that you want to mark as an activation dependency, and then choose the **Add** button.  
  
## Editing Custom Dependencies  
 You can edit custom dependencies that you added previously. However, dependent Features that are in your solution can only be removed, not edited.  
  
#### To change a dependency on a Feature in the solution  
  
1.  Open the Feature Designer, and then expand the **Feature Activation Dependencies** node.  
  
2.  Choose the name of the feature that you want to edit, and then choose the **Edit** button.  
  
3.  In the **Edit Custom Feature Activation Dependency** dialog box, change the title, Feature ID, or description, and then choose the **Submit** button.  
  
## Removing Dependencies  
  
#### To remove a dependency on a Feature in the solution  
  
1.  In the Feature Designer, expand the **Feature Activation Dependencies** node, choose the name of the feature that you want to remove, and then choose the **Remove** button.  
  
## See Also  
 [Creating SharePoint Features](../sharepoint/creating-sharepoint-features.md)   
 [How to: Customize a SharePoint Feature](../sharepoint/how-to-customize-a-sharepoint-feature.md)   
 [How to: Add and Remove Items to SharePoint Features](../sharepoint/how-to-add-and-remove-items-to-sharepoint-features.md)  
  
  