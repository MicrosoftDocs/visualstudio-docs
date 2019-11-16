---
title: Visual Studio Container Tools on Windows
description: Get to know the tools available in Visual Studio for working with Docker
author: ghogen
ms.author: ghogen
ms.topic: overview
ms.date: 03/20/2019
ms.technology: vs-azure
---
# Container Tools in Visual Studio

The tools included in Visual Studio for developing with containers are easy to use, and greatly simplify building, debugging, and deployment for containerized applications. You can work with a container for a single project, or use container orchestration with Docker Compose, Service Fabric, or Kubernetes to work with multiple services in containers.

::: moniker range="vs-2017"

## Prerequisites

* [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
* [Visual Studio 2017](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) with the **Web Development**, **Azure Tools** workload, and/or **.NET Core cross-platform development** workload installed
* To publish to Azure Container Registry, an Azure subscription. [Sign up for a free trial](https://azure.microsoft.com/offers/ms-azr-0044p/).

## Docker support in Visual Studio

Docker support is available for ASP.NET projects, ASP.NET Core projects, and .NET Core and .NET Framework console projects.

The support for Docker in Visual Studio has changed over a number of releases in response to customer needs. There are two levels of Docker support you can add to a project, and the supported options vary by the type of project and the version of Visual Studio. With some supported project types, if you just want a container for a single project, without using orchestration, you can do that by adding Docker support.  The next level is container orchestration support, which adds appropriate support files for the particular orchestrator you choose.  

With Visual Studio 2017, you can use Docker Compose and Service Fabric as container orchestration services.  You can also use Kubernetes if you install the [Visual Studio Tools for Kubernetes](https://aka.ms/get-vsk8stools).

> [!NOTE]
> If you are using a version of Visual Studio 2017 prior to 15.8, or you are using the .NET Framework project template (not .NET Core), when you add Docker support, orchestration support using Docker Compose is added automatically. Container orchestration support, via Docker Compose, is added automatically in Visual Studio 2017 versions 15.0 to 15.7 and for .NET Framework projects.

::: moniker-end

::: moniker range=">=vs-2019"

## Prerequisites

* [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads) with the **Web Development**, **Azure Tools** workload, and/or **.NET Core cross-platform development** workload installed
* [.NET Core 2.2 Development Tools](https://dotnet.microsoft.com/download/dotnet-core/2.2) for development with .NET Core 2.2
* To publish to Azure Container Registry, an Azure subscription. [Sign up for a free trial](https://azure.microsoft.com/offers/ms-azr-0044p/).

## Docker support in Visual Studio

Docker support is available for ASP.NET projects, ASP.NET Core projects, and .NET Core and .NET Framework console projects.

The support for Docker in Visual Studio has changed over a number of releases in response to customer needs. There are two levels of Docker support you can add to a project, and the supported options vary by the type of project and the version of Visual Studio. With some supported project types, if you just want a container for a single project, without using orchestration, you can do that by adding Docker support.  The next level is container orchestration support, which adds appropriate support files for the particular orchestrator you choose.  

With Visual Studio 2019, you can use Docker Compose, Kubernetes, and Service Fabric as container orchestration services.

> [!NOTE]
> If you are using the full .NET Framework console project template, when you add Docker support, support for orchestration using Docker Compose is added automatically.

In Visual Studio 2019 version 16.4 and later, the **Containers** window is available, which lets you view running containers, browse available images, view environment variables, logs, and port mappings, inspect the filesystem, attach a debugger, or open a terminal window inside the container environment. See [View and diagnose containers and images in Visual Studio](view-and-diagnose-containers.md).

::: moniker-end

### Adding Docker support

You can enable Docker support during project creation by selecting **Enable Docker Support** when creating a new project, as shown in the following screenshot:

::: moniker range="vs-2017"
![Enable Docker Support for new ASP.NET Core web app in Visual Studio](./media/overview/enable-docker-support-visual-studio.png)
::: moniker-end
::: moniker range=">=vs-2019"
![Enable Docker Support for new ASP.NET Core web app in Visual Studio](./media/overview/vs-2019/enable-docker-support-visual-studio.png)
::: moniker-end

> [!NOTE]
> For .NET Framework projects (not .NET Core), only Windows containers are available.

You can add Docker support to an existing project by selecting **Add** > **Docker Support** in **Solution Explorer**. The **Add > Docker Support** and **Add > Container Orchestrator Support** commands are located on the right-click menu (or context menu) of the project node for an ASP.NET Core project in **Solution Explorer**, as shown in the following screenshot:

![Add Docker Support menu option in Visual Studio](./media/overview/add-docker-support-menu.png)

When you add or enable Docker support, Visual Studio adds the following to the project:

- a *Dockerfile* file
- a .dockerignore file
- a NuGet package reference to the Microsoft.VisualStudio.Azure.Containers.Tools.Targets

::: moniker range=">=vs-2019"
The solution looks like this once you add Docker support:

![Screenshot of solution explorer with Dockerfile and .dockerignore file](media/overview/vs-2019/dockerfile-dockerignore.png)
::: moniker-end

::: moniker range="vs-2017"
> [!NOTE]
> When you enable Docker support during project creation for a ASP.NET project (.NET Framework, not a .NET Core project) as shown in the following screenshot, container orchestration support is also added.

![Enable Docker compose support for an ASP.NET project](media/overview/enable-docker-compose-support.png)
::: moniker-end

## Docker Compose support

When you want to compose a multi-container solution using Docker Compose, add container orchestration support to your projects. This lets you run and debug a group of containers (a whole solution or group of projects) at the same time if they're defined in the same *docker-compose.yml* file.

To add container orchestration support using Docker Compose, right-click on the solution or project node in **Solution Explorer**, and choose **Add > Container Orchestration Support**. Then choose **Docker Compose** to manage the containers.

After you add container orchestration support to your project, you see a *Dockerfile* added to the project (if there wasn't one there already) and a **docker-compose** folder added to the solution in **Solution Explorer**, as shown here:

![Docker files in Solution Explorer in Visual Studio](media/overview/docker-support-solution-explorer.png)

If *docker-compose.yml* already exists, Visual Studio just adds the required lines of configuration code to it.

Repeat the process with the other projects that you want to control using Docker Compose.

## Kubernetes support

::: moniker range="vs-2017"
To add Kubernetes support, install the [Visual Studio Tools for Kubernetes](https://aka.ms/get-vsk8stools).
::: moniker-end

With Kubernetes support, you can enable a connection between your local project and a Kubernetes cluster running in [Azure Kubernetes Service (AKS)](/azure/aks), and thereby modify and debug your services running in AKS using Visual Studio.  This service is provided by [Azure Dev Spaces](/azure/dev-spaces/quickstart-netcore-visualstudio). Azure Dev Spaces also lets you set up separate branches of your Kubernetes services called *dev spaces* for development purposes, so you can efficiently isolate production services from working versions in development, and keep distinct modifications cleanly separated from each other.

To add Kubernetes support to your projects, choose **Kubernetes/Helm** when you add container orchestration support. Several files are added to your project, including *azds.yaml*, which configures Azure Dev Spaces, and Helm charts which describe the structure of your Kubernetes services.

## Service Fabric support

With Service Fabric tools in Visual Studio, you can develop and debug for Azure Service Fabric, run and debug locally, and deploy to Azure.

::: moniker range="vs-2017"
Visual Studio 2017 version 15.9 and later with the Azure development workload installed supports developing containerized microservices using Windows containers and Service Fabric orchestration.
::: moniker-end
::: moniker range=">=vs-2019"
Visual Studio 2019 supports developing containerized microservices using Windows containers and Service Fabric orchestration.
::: moniker-end

For a detailed tutorial, see
[Tutorial: Deploy a .NET application in a Windows container to Azure Service Fabric](/azure/service-fabric/service-fabric-host-app-in-a-container).

For more information on Azure Service Fabric, see [Service Fabric](/azure/service-fabric).

## Continuous delivery and continuous integration (CI/CD)

Visual Studio integrates readily with Azure Pipelines for automated and continuous integration and delivery of changes to your service code and configuration. To get started, see [Create your first pipeline](/azure/devops/pipelines/create-first-pipeline?view=azure-devops&tabs=tfs-2018-2).

For Service Fabric, see [Tutorial: Deploy your ASP.NET Core app to Azure Service Fabric by using Azure DevOps Projects](/azure/devops-project/azure-devops-project-service-fabric).

For Kubernetes, see [Deploy a Docker container app to Azure Kubernetes Service](/azure/devops/pipelines/apps/cd/deploy-aks?view=azure-devops).

## Next steps

For further details on the services implementation and use of Visual Studio tools for working with containers, read the following articles:

[Debugging apps in a local Docker container](edit-and-refresh.md)

[Deploy an ASP.NET container to a container registry using Visual Studio](hosting-web-apps-in-docker.md)
