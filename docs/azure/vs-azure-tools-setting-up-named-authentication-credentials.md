---
title: Set up named authentication credentials
description: 'Learn how to provide credentials that Visual Studio can use to authenticate requests to Azure, so you can publish an application to Azure from Visual Studio or monitor an existing cloud service.'
author: ghogen
manager: jmartens
ms.technology: vs-azure
ms.topic: conceptual
ms.date: 11/11/2017
ms.author: ghogen
---
# Set up named authentication credentials

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

 [!INCLUDE [Cloud Services](./includes/cloud-services-legacy.md)]

To publish an application to Azure or to monitor an existing cloud service, Visual Studio requires credentials to authenticate requests to Azure, namely your Azure subscription ID and a valid X.509 v3 certificate with a key of at least 2048 bits. You provide these credentials through either of the following methods:

- In Visual Studio select **View > Server Explorer**, right-click the **Azure** node, select **Connect to Microsoft Azure Subscription**, and sign in.
- Create a subscription file (`.publishsettings`), which contains a public key for the certificate. The subscription file can contain credentials for more than one subscription, as described in this article.

Note: these credentials are different from credentials used to authenticate requests to Azure storage services.

## Create a subscription file

In Server Explorer, right-click the **Azure** node and select **Manage and Filter Subscriptions**. Then select the **Certificates** tab, and then do one of the following actions:

- Select **Import** to open the **Import Microsoft Azure Subscriptions** dialog box. Select the **Download subscription file** link, and in the browser save the downloaded file to a temporary location. Back in the dialog box, browse to the download location and then import it for use in authentication.
- Choose an active subscription and select **Edit**, which opens a dialog in which you edit an existing subscription for use in authentication.
- Select **New** to open the **New Subscription** dialog box and provide the required details. To upload the certificate to your cloud service are noted in the dialog, sign into the Azure portal, navigate to your cloud service, select **Settings > Management Certificates**, select **Upload**, then specify the path to the `.cer` file.

If you want to create a certificate yourself, you can refer to the instructions in [Create and upload a management certificate for Azure](/azure/cloud-services/cloud-services-certs-create) and then manually upload the certificate to the [Azure portal](https://portal.azure.com/).

## Related content

- [General overview of Web Apps](/azure/app-service/)
- [Deploy your app to Azure App Service](/azure/app-service/app-service-deploy-local-git)
- [Deploy WebJobs using Visual Studio](/azure/app-service/websites-dotnet-deploy-webjobs)
- [Create and deploy a cloud service](/azure/cloud-services/cloud-services-how-to-create-deploy-portal)
