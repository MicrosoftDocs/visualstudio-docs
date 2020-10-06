---
title: Use Cloud Services Extended Support (Preview)
description: Learn now to create and deploy an Azure cloud service using Azure Resource Manager with Visual Studio
author: ghogen
manager: jillfra
ms.custom: vs-azure
ms.workload: azure-vs
ms.topic: how-to
ms.date: 10/5/2020
ms.author: ghogen
monikerRange: ">=vs-2019"
---
# Create and deploy a cloud service using extended support in Visual Studio (Preview)

Starting with Visual Studio 2019 version 16.9 Preview 1, you can work with cloud services using Azure Resource Manager (ARM), which greatly simplifies and modernizes maintenance and management of Azure resources. You can also convert an existing cloud service project to an extended support cloud service project.

## Create a project

Visual Studio provides a project template that lets you create an Azure cloud service with extended support, named **Azure cloud service (extended support)**. A cloud service is a simple general-purpose Azure service. Once the project has been created, Visual Studio enables you to configure, debug, and deploy the cloud service to Azure.

### To create an Azure cloud service (extended support) project in Visual Studio

This section walks you through creating an Azure cloud service project in Visual Studio with one or more web roles.

1. From the start window, choose **Create a new project**.

1. In the search box, type in *Cloud*, and then choose **Azure Cloud Service (extended support)**.

   ![New Azure cloud service with extended support](./media/cloud-services-extended-support/choose-project-template.png)

1. Give the project a name and choose **Create**.

   ![Give the project a name](./media/cloud-services-extended-support/configure-new-project.png)

1. In the **New Microsoft Azure Cloud Service** dialog, select the roles that you want to add, and choose the right arrow button to add them to your solution.

    ![Select new Azure cloud service roles](./media/cloud-services-extended-support/choose-roles.png)

1. To rename a role that you've added, hover on the role in the **New Microsoft Azure Cloud Service** dialog, and, from the context menu, select **Rename**. You can also rename a role within your solution (in the **Solution Explorer**) after it has been added.

    ![Rename Azure cloud service role](./media/vs-azure-tools-azure-project-create/new-cloud-service-rename.png)

The Visual Studio Azure project has associations to the role projects in the solution. The project also includes the *service definition file* and *service configuration file*:

- **Service definition file** - Defines the run-time settings for your application, including what roles are required, endpoints, and virtual machine size.
- **Service configuration file** - Configures how many instances of a role are run and the values of the settings defined for a role.

For more information about these files, see [Configure the Roles for an Azure cloud service with Visual Studio](vs-azure-tools-configure-roles-for-cloud-service.md).

## Convert an existing cloud service project to use extended support

...

## Publish a cloud service

1. Create or open an Azure cloud service project in Visual Studio.

1. In **Solution Explorer**, right-click the project, and, from the context menu, select **Publish**.

   ![Sign-in page](./media/cloud-services-extended-support/publish-step1.png)

1. **Account** - Select an account or select **Add an account** in the account dropdown list.

1. **Choose your subscription** - Choose the subscription to use for your deployment.

1. Choose **Next** to move to the **Settings** page.

   ![Common Settings](./media/cloud-services-extended-support/publish-settings.png)

1. **Cloud service** - Using the dropdown, either select an existing cloud service, or select **Create new**, and create a cloud service. The data center displays in parentheses for each cloud service. It is recommended that the data center location for the cloud service be the same as the data center location for the storage account.

   If you choose to create a new cloud service, you'll see the **Create Cloud Service (extended support)** dialog. Specify the location and resource group you want to use for the cloud service.

   ![Create a cloud service with extended support](./media/cloud-services-extended-support/extended-support-dialog.png)

1. **Build configuration** - Select either **Debug** or **Release**.

1. **Service configuration** - Select either **Cloud** or **Local**.

1. **Storage account** - Select the storage account to use for this deployment, or **Create new** to create a storage account. The region displays in parentheses for each storage account. It is recommended that the data center location for the storage account is the same as the data center location for the cloud service (Common Settings).

   The Azure storage account stores the package for the application deployment. After the application is deployed, the package is removed from the storage account.

1. **Key vault** - Specify the key vault that contains the secrets for this cloud service. This is enabled if remote desktop is enabled or certificates are added to the configuration.

1. **Enable Remote Desktop for all roles** - Select this option if you want to be able to remotely connect to the service. You'll be asked to specify credentials.

   ![Remote desktop settings](./media/cloud-services-extended-support/remote-desktop-configuration.png)

1. Choose **Next** to move to the **Diagnostics settings** page.

   ![Diagnostics settings](./media/cloud-services-extended-support/diagnostics-settings.png)

   Diagnostics enables you to troubleshoot an Azure cloud service (or Azure virtual machine). For information about diagnostics, see [Configuring Diagnostics for Azure Cloud Services and Virtual Machines](./vs-azure-tools-diagnostics-for-cloud-services-and-virtual-machines.md). For information about Application Insights, see [What is Application Insights?](/azure/application-insights/app-insights-overview).

1. Choose **Next** to move to the **Summary** page.

   ![Summary](./media/cloud-services-extended-support/publish-summary.png)

1. **Target profile** - You can choose to create a publishing profile from the settings that you have chosen. For example, you might create one profile for a test environment and another for production. To save this profile, choose the **Save** icon. The wizard creates the profile and saves it in the Visual Studio project. To modify the profile name, open the **Target profile** list, and then choose **Manage…**.

   > [!Note]
   > The publishing profile appears in Solution Explorer in Visual Studio, and the profile settings are written to a file with an .azurePubxml extension. Settings are saved as attributes of XML tags.

1. Once you configure all the settings for your project's deployment, select **Publish** at the bottom of the dialog. You can monitor the process status in the **Azure Activity Log** output window in Visual Studio.

In the extended support version of this process, two new files are added to your project in the *bin\<Configuration>* folder, *template.json* and *parameters.json*.

Congratulations! You've published your extended support cloud service project to Azure. To publish again with the same settings, you can reuse the publishing profile. Right-click the project node, and choose the **Publish** menu item, and then choose the **Publish** button. You can also edit, rename, delete, or create a new publishing profile using the links below the name of the profile.

![Publish succeeded](./media/cloud-services-extended-support/publish-succeeded.png)

## Next steps

Set up continuous intregration (CI) using the **Configure** button on the **Publish** screen. For more information, see [Azure Pipelines documentation](/azure/devops/pipelines/?view=azure-devops).
