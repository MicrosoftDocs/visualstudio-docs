---
title: "How to: Deploy and Publish a SharePoint Solution to a Local SharePoint Site | Microsoft Docs"
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
  - "deploying [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, deploying"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Deploy and Publish a SharePoint Solution to a Local SharePoint Site
  You can deploy or publish SharePoint solutions to a local SharePoint server on your development computer. The deployment process copies the .wsp file to the SharePoint server, installs the solution, and then activates the features. The publishing process only copies the .wsp file to the SharePoint server and installs it. You must manually activate it to enable it in SharePoint.  
  
## To deploy a SharePoint solution to the local SharePoint server  
  
1.  In **Solution Explorer**, choose the project that you want to deploy.  
  
2.  On the menu bar, choose **Build**, **Deploy Solution**.  
  
     The .wsp file is created and installed on the local SharePoint server. Also, the features are activated.  
  
## To publish a SharePoint solution to a local SharePoint server  
  
1.  In **Solution Explorer**, open the shortcut menu for the SharePoint project that you want to publish and then choose **Publish**.  
  
2.  In the **Publish** dialog box, choose the **Publish to File System** option button.  
  
3.  In the **Target Location** text box, enter a local path, and then choose the **Publish** button.  
  
     The publishing progress appears in the Visual Studio **Output** window. When the process is finished, the solution (.wsp) file is installed on the local SharePoint server. However, it must still be activated to be used in SharePoint. If the solution file already exists, an error occurs and asks whether you want to overwrite the existing file. For information on upgrading the package, see the section on upgrading remote packages in [How to: Deploy, Publish, and Upgrade SharePoint Solutions on a Remote Server](../sharepoint/how-to-deploy-publish-and-upgrade-sharepoint-solutions-on-a-remote-server.md).  
  
## See Also  
 [How to: Deploy, Publish, and Upgrade SharePoint Solutions on a Remote Server](../sharepoint/how-to-deploy-publish-and-upgrade-sharepoint-solutions-on-a-remote-server.md)   
 [Creating SharePoint Solution Packages](../sharepoint/creating-sharepoint-solution-packages.md)   
 [How to: Customize a SharePoint Solution Package](../sharepoint/how-to-customize-a-sharepoint-solution-package.md)   
 [How to: Add and Remove Features and Items to a Package by Using the Package Designer](../sharepoint/how-to-add-and-remove-features-and-items-to-a-package-by-using-the-package-designer.md)  
  
  