---
title: Deploy ASP.NET container app to Container Registry
description: Use Visual Studio Container Tools to deploy a containerized ASP.NET or ASP.NET Core web app to Azure Container Registry.
author: ghogen
manager: mijacobs
ms.devlang: dotnet
ms.topic: how-to
ms.subservice: container-tools
ms.date: 8/25/2025
ms.author: ghogen

#customer intent: As a developer, I want to use Visual Studio Container Tools, so I can deploy a containerized ASP.NET or ASP.NET Core web app to Azure Container Registry.
---

# Deploy an ASP.NET container to a container registry using Visual Studio

This tutorial walks you through using Visual Studio to publish your containerized application to an [Azure Container Registry](https://azure.microsoft.com/products/container-registry).

If you don't have an Azure subscription, create a [free account](https://azure.microsoft.com/pricing/purchase-options/azure-account?icid=dotnet?utm_source=acr-publish-doc&utm_medium=docs&utm_campaign=docs) before you begin.

## Prerequisites

::: moniker range="vs-2019"

- Install the latest version of [Visual Studio 2019](https://visualstudio.microsoft.com/vs/older-downloads/) with the "ASP.NET and web development" workload.

- Install [Docker Desktop for Windows](https://docs.docker.com/desktop/windows/install/).
::: moniker-end
::: moniker range="vs-2022"

- Install [Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the "ASP.NET and web development" workload.

- Install [Docker Desktop for Windows](https://docs.docker.com/desktop/windows/install/).
:::moniker-end

::: moniker range="visualstudio"

- Install [Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta). For Podman support, [Visual Studio (Insiders)](https://visualstudio.microsoft.com/insiders?cid=learn-onpage-download-cta) with the "ASP.NET and web development" workload.

- Install [Docker Desktop for Windows](https://docs.docker.com/desktop/windows/install/) or [Podman Desktop](https://podman-desktop.io/downloads).

:::moniker-end

## Create an ASP.NET Core web app

The following steps guide you through creating a basic ASP.NET Core app that you use in this tutorial. If you already have a project, you can skip this section.

::: moniker range="vs-2019"

[!INCLUDE [create-aspnet5-app](../azure/includes/vs-2019/create-aspnet5-app-2019.md)]

::: moniker-end
:::moniker range=">=vs-2022"

[!INCLUDE [create-aspnet5-app](../azure/includes/vs-2022/create-aspnet5-app-2022.md)]

::: moniker-end

## Publish your container to Azure Container Registry

::: moniker range="vs-2019"

1. Right-click your project in **Solution Explorer** and choose **Publish**. The **Publish** dialog opens.

1. On the **Target** tab, select **Docker Container Registry**, and then select **Next**.

   :::image type="content" source="media/container-tools/vs-2019/docker-container-registry.png" border="false" alt-text="Screenshot that shows the Publish dialog and how to choose Docker Container Registry.":::

1. On the **Specific target** tab, select **Azure Container Registry**, and then select **Next**.

1. On the **Container Registry** tab, select the **Create a new Azure Container Registry** option at the bottom:

   :::image type="content" source="media/container-tools/vs-2019/select-existing-or-create-new-azure-container-registry.png" border="false" alt-text="Screenshot of the Publish dialog that shows how to choose Create New Azure Container Registry.":::

1. On the **Azure Container Registry** page, enter your values for the new resource:

   | Setting      | Suggested value  | Description                                |
   | ------------ |  ------- | -------------------------------------------------- |
   | **DNS Prefix** | Globally unique name | Name that uniquely identifies your container registry. |
   | **Subscription** | Your subscription | The Azure subscription to use. |
   | **[Resource Group](/azure/azure-resource-manager/management/overview)**| Your resource group | Name of the resource group in which to create your container registry. Select **New** to create a new resource group. |
   | **[SKU](/azure/container-registry/container-registry-skus)** | "Standard" | Select the service tier of the container registry. |
   | **Registry Location** | A nearby location | Choose a location in a [region](https://azure.microsoft.com/explore/global-infrastructure/geographies/) close to you or close to other services that you expect to use the container registry. |

   :::image type="content" source="media/hosting-web-apps-in-docker/vs-azure-container-registry-provisioning-dialog-2019.png" border="false" alt-text="Screenshot that shows how to enter values in the dialog to create a new Azure Container Registry.":::

1. After you enter the resource values, select **Create**.

   Visual Studio validates the property values and creates the new container resource.
   When the process completes, Visual Studio returns to the **Publish** dialog and selects the new container in the list.

1. Select **Finish** to publish the new container.

::: moniker-end
::: moniker range=">=vs-2022"

1. Right-click your project in **Solution Explorer** and choose **Publish**. The **Publish** dialog opens.

1. On the **Target** tab, select **Docker Container Registry**, and then select **Next**.

   :::image type="content" source="media/container-tools/vs-2022/docker-container-registry.png" border="false" alt-text="Screenshot that shows the Publish dialog and how to choose Docker Container Registry.":::

1. On the **Specific target** tab, select **Azure Container Registry**, and then select **Next**.

1. On the **Registry** tab, select the **Create new** (+) option at the right:

   :::image type="content" source="media/container-tools/vs-2022/select-existing-or-create-new-azure-container-registry.png" border="false" alt-text="Screenshot of the Publish dialog that shows how to choose Create New Azure Container Registry.":::

1. Fill in your desired values in the **Azure Container Registry** screen.

   | Setting      | Suggested value  | Description                                |
   | ------------ |  ------- | -------------------------------------------------- |
   | **DNS Prefix** | Globally unique name | Name that uniquely identifies your container registry. |
   | **Subscription** | Your subscription | The Azure subscription to use. |
   | **[Resource Group](/azure/azure-resource-manager/management/overview)**| Your resource group | Name of the resource group in which to create your container registry. Select **New** to create a new resource group. |
   | **[SKU](/azure/container-registry/container-registry-skus)** | "Standard" | Select the service tier of the container registry. |
   | **Registry Location** | A nearby location | Choose a location in a [region](https://azure.microsoft.com/explore/global-infrastructure/geographies/) close to you or close to other services that you expect to use the container registry. |

   :::image type="content" source="media/container-tools/vs-2022/vs-azure-container-registry-provisioning-dialog.png" border="false" alt-text="Screenshot that shows how to enter values in the dialog to create a new Azure Container Registry.":::

1. After you enter the resource values, select **Create**.

   Visual Studio validates the property values and creates the new container resource.
   When the process completes, Visual Studio returns to the **Publish** dialog and selects the new container in the list.

1. Select **Finish** to publish the new container.

::: moniker-end

You can now pull the container from the registry to any host capable of running Docker images, such as [Azure Container Instances](/azure/container-instances/container-instances-tutorial-deploy-app).

## Related content

- [Quickstart: Deploy a container instance in Azure using the Azure CLI](/azure/container-instances/container-instances-quickstart)
