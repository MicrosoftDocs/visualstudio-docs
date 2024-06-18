---
title: Use Azure Cloud Services (extended support)
description: Create and deploy Azure Cloud Services (extended support) by using Azure Resource Manager with Visual Studio on Windows.
author: ghogen
manager: mijacobs
f1_keywords:
 - AzureTools.Publish.UI
ms.subservice: azure-development
ms.topic: how-to
ms.date: 01/25/2021
ms.author: ghogen
monikerRange: ">=vs-2019"
---

# Create and deploy Cloud Services (extended support) in Visual Studio

 [!INCLUDE [Cloud Services](./includes/cloud-services-legacy.md)]

Starting with [Visual Studio 2019 version 16.9](https://visualstudio.microsoft.com/vs/), you can work with cloud services by using Azure Resource Manager templates (ARM templates). Azure Cloud Services (extended support) greatly simplifies and modernizes maintenance and management of Azure resources. You can publish an existing cloud service to Cloud Services (extended support). For information on this Azure service, see the [Cloud Services (extended support) documentation](/azure/cloud-services-extended-support/overview).

## Publish to Cloud Services (extended support)

When you publish your existing Azure Cloud Services project to Azure Cloud Services (extended support), you still retain the capability to publish to a classic instance of Azure Cloud Services. In Visual Studio 2019 version 16.9 or later, classic cloud service projects have a special version of the **Publish** command: **Publish (extended support)**. This command appears on the shortcut menu in Solution Explorer.

There are some differences when you publish to Cloud Services (extended support). For example, you aren't asked to select to publish to either **Staging** or **Production**, because these deployment slots aren't part of the extended support publishing model. Instead, with Cloud Services (extended support), you can set up multiple deployments, and you can swap deployments in the Azure portal. Although Visual Studio tooling allows for setting this in version 16.9, the swap feature won't be available until a later release of Cloud Services (extended support) and might result in a failure during deployment in the preview.

Before publishing an instance of classic Azure Cloud Services to Azure Cloud Services (extended support), check the storage accounts your project uses and make sure they're Storage V1 or Storage V2 accounts. The classic storage account types fail with an error message during deployment. Be sure to check the storage account that Azure Diagnostics uses. To check the Diagnostics storage account, see [Set up diagnostics for Azure Cloud Services and virtual machines](vs-azure-tools-diagnostics-for-cloud-services-and-virtual-machines.md). If your service uses a classic storage account, you can upgrade it; see [Upgrade to a general-purpose v2 storage account](/azure/storage/common/storage-account-upgrade?tabs=azure-portal). For general information on types of storage accounts, see [Storage account overview](/azure/storage/common/storage-account-overview).

:::moniker range="vs-2022"
> [!NOTE]
> If you are targeting .NET 4.8 with Visual Studio 2022, be sure to open the *ServiceConfiguration.Cloud.cscfg* file and check the value of the `osFamily` attribute on the `ServiceConfiguration` element when you publish your Cloud Services (extended support) deployment. For a .NET 4.8 project, use the value `osFamily="7"`.
:::moniker-end

### To publish a classic Azure Cloud Services project to Cloud Services (extended support)

1. In your Azure Cloud Services (classic) project, right-click the project node and choose **Publish (extended support)...**.

   ![Screenshot that shows selecting Publish (extended support) on the menu.](./media/cloud-services-extended-support/publish-commands-on-menu.png)

   The **Publish** wizard opens.

   ![Screenshot that shows the Microsoft Azure Publish Sign-in pane.](./media/cloud-services-extended-support/publish-step1.png)

1. For **Account**, select an account, or select **Add an account** in the account dropdown list.

1. For **Choose your subscription**, select a subscription to use for your deployment.

1. Select **Next** to move to the **Settings** pane.

   ![Screenshot that shows settings on the Common Settings pane.](./media/cloud-services-extended-support/publish-settings.png)

1. On **Common Settings**, in the dropdown list, either select an existing instance of Cloud Services (extended support) or select **Create new**, and then create one. The datacenter displays in parentheses for each instance of Cloud Services (extended support). We recommend that the datacenter location for Cloud Services (extended support) be the same as the datacenter location of your storage account.

   If you choose to create a new service, the **Create Cloud Service (extended support)** dialog appears. Specify the location and resource group to use for your Cloud Services (extended support) deployment.

   ![Screenshot that shows the Create a Cloud Services (extended support) deployment pane.](./media/cloud-services-extended-support/extended-support-dialog.png)

1. For **Build configuration**, select either **Debug** or **Release**.

1. For **Service configuration**, select either **Cloud** or **Local**.

1. For **Storage account**, select the storage account to use for this deployment, or select **Create new** to create a storage account. The region appears in parentheses for each storage account. We recommend that the datacenter location for the storage account is the same as the datacenter location for the cloud service (as set on **Common Settings**).

   The Azure Storage account stores the package for the application deployment.

1. For **Key Vault**, specify the key vault that contains the secrets for your Cloud Services (extended support) deployment. A key vault is enabled if remote desktop is enabled or if certificates are added to the configuration.

1. For **Enable Remote Desktop for all roles**, select this option if you want to be able to remotely connect to the service. You're asked to enter credentials.

   ![Screenshot that shows remote desktop settings.](./media/cloud-services-extended-support/remote-desktop-configuration.png)

1. Select **Next** to move to the **Diagnostics settings** pane.

   ![Screenshot that shows Diagnostics settings.](./media/cloud-services-extended-support/diagnostics-settings.png)

   You can use Azure Diagnostics to troubleshoot an instance of Cloud Services (extended support). For information about using Diagnostics, see [Configure Diagnostics for Azure Cloud Services and Azure Virtual Machines](./vs-azure-tools-diagnostics-for-cloud-services-and-virtual-machines.md). For information about Application Insights, see [What is Application Insights?](/azure/application-insights/app-insights-overview).

1. Select **Next** to move to the **Summary** pane.

   ![Screenshot that shows the Summary pane.](./media/cloud-services-extended-support/publish-summary.png)

1. For **Target profile**, you can choose to create a publishing profile from the settings you selected. For example, you might create one profile for a test environment and another profile for production. To save this profile, select the **Save** icon. The wizard creates the profile and saves it in the Visual Studio project. To modify the profile name, open the **Target profile** list, and then select **Manage**.

   > [!NOTE]
   > The publishing profile appears in Solution Explorer in Visual Studio, and the profile settings are written to a file that has an *.azurePubxml* extension. Settings are saved as attributes of XML tags.

1. After you configure all the settings for your project deployment, select **Publish** at the bottom of the dialog. You can monitor the process status in the activity log output window in Visual Studio. Select the **Open in portal** link to view the activity log in the Azure portal.

Congratulations! You published your Cloud Services (extended support) project to Azure. To publish again by using the same settings, you can reuse the publishing profile, or repeat these steps to create a new publishing profile. The ARM template and parameters that are used for the deployment are saved in the *bin/\<configuration\>/Publish* folder.

## Clean up Azure resources

To clean up the Azure resources you created by following this article, in the [Azure portal](https://portal.azure.com), select **Resource groups**. Find and open the resource group that you used to create an instance of Cloud Services (extended support), and then select **Delete resource group**.

## Related content

- Set up continuous integration (CI) by using the **Configure** button on the **Publish** pane. For more information, see the [Azure Pipelines documentation](/azure/devops/pipelines/?view=azure-devops&preserve-view=true).
- Review [frequently asked questions](/azure/cloud-services-extended-support/faq) for Cloud Services (extended support).
