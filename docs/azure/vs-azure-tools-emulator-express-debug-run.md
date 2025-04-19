---
title: Run and debug Azure service locally with Emulator Express
description: Use Emulator Express to run and debug an Azure Cloud Services (extended support) on a local machine without running Visual Studio as an administrator.
author: mikejo5000
manager: mijacobs
ms.subservice: azure-development
ms.topic: how-to
ms.date: 03/06/2024
ms.author: mikejo
---

# Using Emulator Express to run and debug an Azure Cloud Services (extended support) on a local machine

 [!INCLUDE [Cloud Services](./includes/cloud-services-legacy.md)]

By using Emulator Express, you can test and debug a cloud service without running Visual Studio as an administrator. You can set your project settings to use either Emulator Express or the full emulator, depending on the requirements of your cloud service. For more information about the full emulator, see [Run an Azure Application in the Compute Emulator](/azure/storage/common/storage-use-emulator).

## Using Emulator Express in Visual Studio

When you create an Azure project, Emulator Express is automatically used. For existing projects that were created with an earlier version of the Azure SDK, use the following steps to select Emulator Express:

1. Create or open an Azure Cloud Services (extended support) project in Visual Studio.

1. In Solution Explorer, right-click the project, and, from the context menu, select **Properties**.

1. In the projects properties pages, select the **Web** tab.

    ![Properties for an Azure Cloud Services (extended support) project](./media/vs-azure-tools-emulator-express-debug-run/web-properties.png)

1. Under **Local Development Server**, select **Use Internet Information Services (IIS) Express option**.

1. Under **Emulator**, select **Use Emulator Express**.

1. To launch the Emulator Express, run the following command at a command prompt:

    `csrun.exe /useemulatorexpress`

## Emulator Express limitations

The following issues are known limitations of Emulator Express:

- Emulator Express is not compatible with IIS Web Server.
- Your cloud service can contain multiple roles, but each role is limited to one instance.
- You can't access port numbers below 1000. If you use an authentication provider that normally uses a port below 1000, you might need to change this value to a port number that's above 1000.
- Any limitations that apply to the Azure Compute Emulator also apply to Emulator Express. For example, you can't have more than 50 role instances per deployment. For more information about the Azure Compute Emulator, see [Run an Azure Application in the Compute Emulator](vs-azure-tools-performance-profiling-cloud-services.md).

## Related content

[Debugging Azure Cloud Services (extended support)](vs-azure-tools-debugging-cloud-services-overview.md)
