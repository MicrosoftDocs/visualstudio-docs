---
title: Accessing Azure Virtual Machines from Server Explorer
description: Get an overview of how to view create and manage Azure Virtual Machines (VMs) in Server Explorer in Visual Studio.
author: ghogen
manager: mijacobs
ms.subservice: azure-development
ms.topic: how-to
ms.date: 03/06/2024
ms.author: ghogen
monikerRange: "<=vs-2019"
---

# Accessing Azure Virtual Machines from Server Explorer

> [!IMPORTANT]
> The Azure node of Server Explorer has been retired in Visual Studio 2022. You can use the Azure Portal or continue to use the Azure node of Server Explorer in previous versions of Visual Studio.
>
> Also, [Microsoft Azure Storage Explorer](/azure/vs-azure-tools-storage-manage-with-storage-explorer) is a free, standalone app from Microsoft. You can use it to work visually with Azure Storage data on Windows, macOS, and Linux.
>
> For more information about Visual Studio 2022, see our [release notes](/visualstudio/releases/2022/release-notes/).

If you have virtual machines hosted by Azure, you can access them in Server Explorer. You must first sign in to your Azure subscription to view your mobile services. To sign in, open the shortcut menu for the Azure node in Server Explorer, and choose **Connect to Microsoft Azure**.

If you don't have an Azure account, activate your [Azure benefits for Visual Studio subscribers](/visualstudio/subscriptions/vs-azure-eligibility) or [sign up for a free trial](https://azure.microsoft.com/pricing/purchase-options/azure-account?cid=msft_learn).

1. In Cloud Explorer, choose a virtual machine, and then choose the F4 key to show its properties window.

    The following table shows what properties are available, but they are all read-only. To change them, use the [Azure portal](https://portal.azure.com).

   | Property | Description |
   | --- | --- |
   | DNS Name |The URL with the Internet address of the virtual machine. |
   | Environment |For a virtual machine, the value of this property is always Production. |
   | Name |The name of the virtual machine. |
   | Size |The size of the virtual machine, which reflects the amount of memory and disk space that's available. For more information, see [Virtual Machine Sizes](/azure/cloud-services/cloud-services-sizes-specs). |
   | Status |Values include Starting, Started, Stopping, Stopped, and Retrieving Status. If Retrieving Status appears, the current status is unknown. The values for this property differ from the values that are used on the [Azure portal](https://portal.azure.com). |
   | SubscriptionID |The subscription ID for your Azure account. You can show this information on the [Azure portal](https://portal.azure.com) by viewing the properties for a subscription. |
2. Choose an endpoint node, and then view the **Properties** window.
3. The following table describes the available properties of endpoints, but they are read-only. To add or edit the endpoints for a virtual machine, use the [Azure portal](https://portal.azure.com).

   | Property | Description |
   | --- | --- |
   | Name |An identifier for the endpoint. |
   | Private Port |The port for network access internal to your application. |
   | Protocol |The protocol that the transport layer for this endpoint uses, either TCP or UDP. |
   | Public Port |The port that's used for public access to your application. |
