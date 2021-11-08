---
title: "Deploy, publish, & upgrade SharePoint solutions remotely"
titleSuffix: ""
description: Deploy, publish, and upgrade sandboxed SharePoint solutions on a remote site or a local SharePoint site.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "remote deployment [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, remote deployment"
  - "deploying [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, deploying"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Deploy, publish, and upgrade SharePoint solutions on a remote server
  In addition to deploying SharePoint solutions to the local system, you can publish sandboxed SharePoint solutions to remote sites or local SharePoint sites. The remote publishing process copies the *.wsp* file to the SharePoint server, installs the solution, and then enables you to activate the solution. You can also upgrade a remote SharePoint solution installation after changes are made to it.

## To publish a sandboxed SharePoint solution to a remote SharePoint server

1. In **Solution Explorer**, open the shortcut menu for the sandboxed SharePoint project that you want to publish, and then choose **Publish**.

2. In the **Publish** dialog box, choose the **Publish to SharePoint Site** option button, and then enter a URL for an online publishing site, such as: `https://mytestsite.sharepoint.microsoftonline.com`.

3. Choose the **Open the Solution Gallery page in the browser after publishing** option button to view the list of solutions in the **Solution Gallery** page after publishing.

4. Choose the **Publish** button.

5. Sign in to the remote server if user authentication is required.

     The publishing progress appears in the Visual Studio **Output** window. When the process is finished, the solution (*.wsp*) file is installed on the remote SharePoint server. However, it must still be activated before it can be used in SharePoint.

6. On the **Solution Gallery** page, select the SharePoint application and then on the ribbon, choose the **Activate** button.

7. In the **Activate Solution** dialog box, on the ribbon, choose the **Activate** button again.

     The **Status** column on the **Solution Gallery** page indicates that the application is active.

## To upgrade a sandboxed SharePoint solution on a remote SharePoint server
 If a sandboxed SharePoint solution is already published on a remote server, the following process enables you to upgrade it after you make changes to the application in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

1. Rename the SharePoint package in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. To do this, in **Solution Explorer** open the package. It appears in the **Package Explorer**.

2. In **Package Explorer**, in the **Name** box, change the package name to a unique name.

3. Save the project.

4. In **Solution Explorer**, open the shortcut menu for the project, and then choose **Publish**.

5. In the **Publish** dialog box, choose the **Publish to SharePoint Site** option button, and then, if the URL for the remote server where the solution is saved is missing, enter it.

6. Choose the **Open the Solution Gallery page in the browser after publishing** option button to view the list of solutions in the **Solution Gallery** page after publishing.

7. Choose the **Publish** button.

8. Sign in to the remote server if user authentication is required.

     If you logged in to the remote server recently, authentication may not be required.

     If the older version of the application that has the same name still exists on the SharePoint server, you will get an error that a package with the same name already exists on the SharePoint server. You must rename the package to a unique name before publishing.

9. Choose the new application in SharePoint, and then, on the ribbon, choose the **Upgrade** button.

10. In the **Upgrade Solution** dialog box, on the ribbon, choose the **Upgrade** button again. The **Status** column on the **Solution Gallery** page should now indicate that the application is active.

     The old version of the solution is deactivated, the new version of the solution is upgraded with data maintained from the old solution, and the new solution is activated in SharePoint.

## See also
- [How to: Deploy and publish a SharePoint solution to a local SharePoint site](../sharepoint/how-to-deploy-and-publish-a-sharepoint-solution-to-a-local-sharepoint-site.md)
- [Create SharePoint solution packages](../sharepoint/creating-sharepoint-solution-packages.md)
- [How to: Customize a SharePoint solution package](../sharepoint/how-to-customize-a-sharepoint-solution-package.md)
- [How to: Add and remove features and items to a package by using the Package Designer](../sharepoint/how-to-add-and-remove-features-and-items-to-a-package-by-using-the-package-designer.md)
