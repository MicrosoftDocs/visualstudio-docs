---
title: Add Azure Storage by using Connected Services | Microsoft Docs
description: Add Azure Storage to your app by using the Visual Studio Add Connected Services dialog box
author: ghogen
manager: jillfra
assetId: 521ec044-ad4b-4828-8864-01decde2e758
ms.custom: vs-azure
ms.workload: azure-vs
ms.topic: how-to
ms.date: 03/26/2017
ms.author: ghogen
---
# Adding Azure storage by using Visual Studio Connected Services

With Visual Studio, you can connect any of the following to Azure Storage by using the **Add Connected Services** dialog:

- C# cloud service
- .NET backend mobile service
- ASP.NET website or service
- ASP.NET Core service
- Azure WebJob service

The connected service functionality adds all the needed references and connection code to your project, and modifies your configuration files appropriately.

After completion, the **Add Connected Services** dialog automatically displays documentation detailing the steps required to start working with blob storage, queues, and tables.

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Connected services in Visual Studio for Mac](/visualstudio/mac/connected-services).

## Connect to Azure Storage using the Connected Services dialog

1. Open your project in Visual Studio

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, and select **Add Connected Service**.

    ![Add Azure connected service](./media/vs-azure-tools-connected-services-storage/IC796702.png)

1. In the **Connected Services** page, select **Cloud Storage with Azure Storage**.

    ![Add Azure Storage](./media/vs-azure-tools-connected-services-storage/add-azure-storage.png)

1. In the **Azure Storage** dialog, select an existing storage account, and select **Add**.

    If you need to create a storage account, go to the next step. Otherwise, skip to step 6.

    ![Add existing storage account to project](./media/vs-azure-tools-connected-services-storage/select-azure-storage-account.png)

1. To create a storage account:

   1. Select **Create a New Storage Account** at the bottom of the dialog.

   1. Fill out the **Create Storage Account** dialog, and select **Create**.

       ![New Azure storage account](./media/vs-azure-tools-connected-services-storage/create-storage-account.png)

   1. When the **Azure Storage** dialog is displayed, the new storage account appears in the list. Select the new storage account in the list, and select **Add**.

1. The storage connected service appears under the **Service References** node of your project.

## How your project is modified

When you finish the dialog, Visual Studio adds references and modifies certain configuration files. The specific changes depend on the project type:

- ASP.NET project - [What happened – ASP.NET Projects](/azure/visual-studio/vs-storage-aspnet-getting-started-blobs)
- ASP.NET Core project - [What happened – ASP.NET 5 Projects](/azure/visual-studio/vs-storage-aspnet5-getting-started-blobs)
- Cloud service project (web roles and worker roles) - [What happened – Cloud Service projects](/azure/visual-studio/vs-storage-cloud-services-getting-started-blobs)
- WebJob project - [What happened - WebJob projects](/azure/visual-studio/vs-storage-webjobs-what-happened)

## See also

- [MSDN Forum: Azure Storage](https://social.msdn.microsoft.com/forums/azure/home?forum=windowsazuredata)
- [Microsoft Azure Storage Team Blog](https://blogs.msdn.microsoft.com/windowsazurestorage/)
- [Azure Storage documentation](/azure/storage/)
- [Connected services (Visual Studio for Mac)](/visualstudio/mac/connected-services)
