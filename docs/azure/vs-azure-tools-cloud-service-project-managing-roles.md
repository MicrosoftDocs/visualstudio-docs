---
title: Managing roles in Azure Cloud Services (extended support)
description: Learn how to add and remove roles in Azure Cloud Services (extended support) with Visual Studio.
author: ghogen
manager: mijacobs
ms.subservice: azure-development
ms.topic: how-to
ms.date: 03/21/2017
ms.author: ghogen
---

# Managing roles in Azure Cloud Services (extended support) with Visual Studio

 [!INCLUDE [Cloud Services](./includes/cloud-services-legacy.md)]

After you have created your Azure cloud service (extended support), you can add new roles to it or remove existing roles from it. You can also import an existing project and convert it to a role. For example, you can import an ASP.NET web application and designate it as a web role.

## Prerequisites

- [!INCLUDE [prerequisites-azure-subscription](includes/prerequisites-azure-subscription.md)]

## Adding a role to an Azure Cloud Services (extended support)

The following steps guide you through adding a web or worker role to an Azure cloud service (extended support) project in Visual Studio.

1. Create or open an Azure cloud service (extended support) project in Visual Studio.

1. In **Solution Explorer**, expand the project node

1. Right-click the **Roles** node to display the context menu. From the context menu, select **Add**, then select an existing web role or worker role from the current solution, or create a web or worker role project. You can also select an appropriate project, such as an ASP.NET web application project, and associate it with a role project.

   ![Menu options to add a role to an Azure Cloud Services (extended support) project](./media/vs-azure-tools-cloud-service-project-managing-roles/add-role.png)

## Removing a role from an Azure cloud service (extended support)

The following steps guide you through removing a web or worker role from an Azure Cloud Services (extended support) project in Visual Studio.

1. Create or open an Azure cloud service (extended support) project in Visual Studio.

1. In **Solution Explorer**, expand the project node

1. Expand the **Roles** node.

1. Right-click the node you want to remove, and, from the context menu, select **Remove**.

   ![Menu options to add a role to an Azure cloud service (extended support)](./media/vs-azure-tools-cloud-service-project-managing-roles/remove-role.png)

## Related content

- [Configure the Roles for an Azure cloud service (extended support) with Visual Studio](vs-azure-tools-configure-roles-for-cloud-service.md)
