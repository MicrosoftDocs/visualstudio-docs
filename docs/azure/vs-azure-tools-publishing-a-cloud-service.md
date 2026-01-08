---
title: Publishing a Cloud Service using the Azure Tools
description: Learn about how to publish Azure Cloud Services (extended support) projects by using Visual Studio.
author: ghogen
manager: mijacobs
ms.subservice: azure-development
ms.topic: how-to
ms.date: 03/06/2024
ms.author: ghogen
---

# Publishing a cloud service using Visual Studio

 [!INCLUDE [Cloud Services](./includes/cloud-services-legacy.md)]

Visual Studio can publish an application directly to Azure, with support for both Staging and Production environments of a cloud service. When publishing, you select the deployment environment and a storage account that's used temporarily for the deployment package.


## Prerequisites

- Visual Studio (see [Visual Studio downloads](https://aka.ms/vs/download/?cid=learn-onpage-download-cta)) with the **Azure development** workload installed, and the Individual Component **.NET Framework project and item templates** installed. See [Modify Visual Studio](../install/modify-visual-studio.md).
- [!INCLUDE [prerequisites-azure-subscription](includes/prerequisites-azure-subscription.md)]

## Publish or package an Azure application from Visual Studio

When you publish your Azure application, you can do one of the following tasks:

- Create a service package: You can use this package and the service configuration file to publish your application to a deployment environment from the [Azure portal](https://portal.azure.com).

- Publish your Azure project from Visual Studio: To publish your application directly to Azure, you use the Publish Wizard. For information, see [Publish Azure Application Wizard](/previous-versions/visualstudio/visual-studio-2017/azure/vs-azure-tools-publish-azure-application-wizard).

### To create a service package from Visual Studio

1. When you are ready to publish your application, open Solution Explorer, open the shortcut menu for the Azure project that contains your roles, and choose Publish.

1. To create a service package only, follow these steps:

   1. On the shortcut menu for the Azure project, choose **Package**.

   1. In the **Package Azure Application** dialog box, choose the service configuration for which you want to create a package, and then choose the build configuration.

   1. (Optional) To turn on Remote Desktop for the cloud service after you publish it, select **Enable Remote Desktop for all Roles**, and then select **Settings** to configure Remote Desktop credentials. For more information, see [Enable Remote Desktop Connection for a Role in Azure Cloud Services using Visual Studio](/azure/cloud-services/cloud-services-role-enable-remote-desktop-visual-studio).

   1. To create the package, choose the **Package** link.

      File Explorer shows the file location of the newly created package. You can copy this location so that you can use it from the Azure portal.

   1. To publish this package to a deployment environment, you must use this location as the Package location when you create a cloud service and deploy this package to an environment with the Azure portal.

1. (Optional) To cancel the deployment process, on the shortcut menu for the line item in the activity log, choose **Cancel and remove**. This command stops the deployment process and deletes the deployment environment from Azure. To remove the environment after deployment, use the Azure portal.


## Include files in the service package

You might need to include specific files in your service package so that they are available on the virtual machine that is created for a role. For example, you might want to add an `.exe` or an `.msi` file that is used by a startup script to your service package. Or you might need to add an assembly that a web role or worker role project requires. To include files, they must be added to the solution for your Azure application.

1. To add an assembly to a service package, use the following steps:

   1. In **Solution Explorer**, open the project node for the project that is missing the referenced assembly.
   1. To add the assembly to the project, open the shortcut menu for the **References** folder and then choose **Add Reference**. The Add Reference dialog appears.
   1. Choose the reference that you want to add and then choose **OK**. The reference is added to the list under the **References** folder.
   1. Open the shortcut menu for the assembly that you added and choose **Properties**. The **Properties** window appears.

      To include this assembly in the service package, in the **Copy Local list**, select **True**.
1. In **Solution Explorer** open the project node for the project that is missing the referenced assembly.

1. To add the assembly to the project, open the shortcut menu for the **References** folder and then choose **Add Reference**. The **Add Reference** dialog appears.

1. Choose the reference that you want to add and then choose the **OK** button.

    The reference is added to the list under the **References** folder.

1. Open the shortcut menu for the assembly that you added and choose **Properties**. The Properties window appears.

1. To include this assembly in the service package, in the **Copy Local** list, choose **True**.

1. To include files in the service package that have been added to your web role project, open the shortcut menu for the file, and then choose **Properties**. From the **Properties** window, choose **Content** from the **Build Action** list box.

1. To include files in the service package that have been added to your worker role project, open the shortcut menu for the file, and then choose **Properties**. From the **Properties** window, choose **Copy if newer** from the **Copy to output directory** list box.

## Related content

To learn more about publishing to Azure from Visual Studio, see [Publish Azure Application Wizard](/previous-versions/visualstudio/visual-studio-2017/azure/vs-azure-tools-publish-azure-application-wizard).
