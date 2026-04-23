---
title: "Deploy, publish, & upgrade SharePoint solution packages"
description: Deploy, publish, and upgrade SharePoint solution packages. Customize the deployment process. Publish packages to a remote or local server.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: upgrade-and-migration-article
f1_keywords:
  - "VS.SharePointTools.Project.SharePointProjectPropertyTab"
  - "VS.SharePointTools.Project.Publishing"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "deploying [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, deploying"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Deploy, publish, and upgrade SharePoint solution packages

  After you develop a SharePoint solution in Visual Studio, you can either deploy its package (.wsp) file to a local SharePoint server or publish it to a remote or local SharePoint server. If you deploy the files, you can customize how the package files (.wsp) are deployed.

> [!NOTE]
> Currently, only sandboxed solutions can be published to remote SharePoint servers. For more information, see [Sandboxed solution considerations](../sharepoint/sandboxed-solution-considerations.md).

## Deploy, publish, and upgrade
 *Deploying* refers to copying a SharePoint solution file built from a SharePoint project in Visual Studio to a local host. In a deployed solution, you can configure the deployment steps, such as recycling the Internet Information Services (IIS) pool, activating the solution after deployment, and so forth. To deploy, use the **Deploy** command on the **Build** menu. For more information, see [How to: Edit a SharePoint deployment configuration](../sharepoint/how-to-edit-a-sharepoint-deployment-configuration.md) and [How to: Deploy and publish a SharePoint solution to a Local SharePoint site](../sharepoint/how-to-deploy-and-publish-a-sharepoint-solution-to-a-local-sharepoint-site.md).

 *Publishing* refers to uploading a sandboxed SharePoint solution file to a remote SharePoint site; that is, a site located on another system. You can also publish a SharePoint sandboxed solution file to a local SharePoint site, but regardless of whether the site published to is local or remote, you can't configure its deployment steps.

 *Upgrading* refers to updating an existing remotely or locally published SharePoint solution. After any changes are made to the SharePoint solution in Visual Studio, you change the solution's package file name, republish the solution, and then upgrade the solution after it successfully republishes. If you republish a locally published solution, you can overwrite the existing solution file.

## Deploy packages
 You can deploy package files to the SharePoint server on your development computer for testing and debugging. You can also create a package file that you can install on another computer by choosing the **Publish to File System** option button in the **Publish** dialog box. The package is created and copied to the specified local file path. To deploy a SharePoint solution to the local server, use the **Deploy** command on the **Build** menu. For more information, see [How to: Deploy and publish a SharePoint solution to a local SharePoint site](../sharepoint/how-to-deploy-and-publish-a-sharepoint-solution-to-a-local-sharepoint-site.md).

 To learn how to deploy a list definition, add an event receiver, and use the Feature Designer and Package Designer, see [Walkthrough: Deploy a project task list definition](../sharepoint/walkthrough-deploying-a-project-task-list-definition.md).

## Customize the deployment process
 The following table shows the two deployment configurations that you can use when you debug and deploy a SharePoint solution.

|Deployment configuration|Description|
|------------------------------|-----------------|
|Default|The default deployment configuration. The following deployment steps are performed:<br /><br /> 1.  Run pre-deployment command.<br />2.  Recycle IIS application pool.<br />3.  Retract solution.<br />4.  Add solution.<br />5.  Activate features.<br />6.  Run post-deployment command.<br /><br /> When a package is uninstalled, the following retraction steps are performed.<br /><br /> 1.  Recycle IIS application pool.<br />2.  Retract solution.|
|No activation|This deployment configuration runs the same steps as the Default configuration, but skips the activation step.|

 You can create your own deployment configurations to complete a single step or change the order of the steps in the deployment process. For more information, see [How to: Edit a SharePoint deployment configuration](../sharepoint/how-to-edit-a-sharepoint-deployment-configuration.md).

 You can also add commands to run before and after deployment. For more information, see [How to: Set SharePoint deployment commands](../sharepoint/how-to-set-sharepoint-deployment-commands.md).

## Publish packages to a remote or local server
 To publish a sandboxed SharePoint solution to a remote server, on the menu bar, choose **Build**, **Publish**, and then, in the **Publish** dialog box, choose the **Publish to SharePoint Site** option button, providing the remote server's URL, such as `https://someremoteserver.sharepoint.microsoftonline.com`.

 To publish a SharePoint solution to a local server, in the **Publish** dialog box, choose the **Publish to File System** option button, providing a local system path.

 After a solution successfully publishes to SharePoint, the solution appears in the **Solution Gallery** where you can activate it. For more information, see [How to: Deploy, publish, and upgrade SharePoint solutions on a remote server](../sharepoint/how-to-deploy-publish-and-upgrade-sharepoint-solutions-on-a-remote-server.md).

### Upgrade published packages
 If you make any changes to a SharePoint project in Visual Studio after it is published, the published package must be upgraded to include the changes. To upgrade successfully, a package must have a unique name. If a package with the same name is found on the SharePoint site - which can occur when you are updating an existing application - an error alerts you to the file name conflict and lets you rename the package. After being republished, the new package appears on the SharePoint site and can be upgraded. An upgraded package updates the solution by using data from the older package, and then activates the solution in SharePoint. For more information, see [How to: Deploy, publish, and upgrade SharePoint solutions on a remote server](../sharepoint/how-to-deploy-publish-and-upgrade-sharepoint-solutions-on-a-remote-server.md).

## Related content
- [Package and deploy SharePoint solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)
