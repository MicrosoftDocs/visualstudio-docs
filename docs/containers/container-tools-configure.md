---
title: Configure Visual Studio Container Tools
description: Use Visual Studio Container Tools to control how Visual Studio works with Docker containers, including performance settings and resource usage.
author: ghogen
ms.author: ghogen
ms.topic: how-to
ms.date: 07/13/2023
ms.subservice: container-tools
f1_keywords:
 - VS.ToolsOptionsPages.Container_Tools.General
 - VS.ToolsOptionsPages.Container_Tools.Docker
 - VS.ToolsOptionsPages.Container_Tools.Containers_Tool_Window
 - VS.ToolsOptionsPages.Container_Tools.Settings
---

# Configure Visual Studio Container Tools

Using Visual Studio settings, you can control some aspects of how Visual Studio works with Docker containers, including settings that affect performance and resource usage when working with Docker containers.

## Container Tools settings

From the main menu, choose **Tools > Options**, and expand **Container Tools > Settings**. The container tools settings appear.

Container Tools **General** settings:

![Visual Studio Container Tools options, showing: Install Docker Desktop if needed, and Trust ASP.NET Core SSL certificate.](./media/configure-container-tools/tools-options-1.png)

Container Tools **Single Project** and **Docker Compose** settings:

:::moniker range="<=vs-2019"
![Visual Studio Container Tools options, showing: Kill containers on project close, Pull required Docker images on project open, and Run containers on project open.](./media/configure-container-tools/tools-options-2.png)
:::moniker-end
:::moniker range=">=vs-2022"
![Visual Studio Container Tools options, showing: Kill containers on project close, Pull required Docker images on project open, Run containers on project open, Run a service in containers to enable Azure Authentication, and Run a service in containers to enable Hot Reload.](./media/configure-container-tools/vs-2022/tools-options-2.png)
:::moniker-end

The following table might help you decide how to set these options.

The following table describes **General** settings:

| Name | Default Setting | Applies To | Description |
| -----|:---------------:|:----------:| ----------- |
| Install Docker Desktop if needed | Prompt Me | Single Project, Docker Compose | Choose whether you want to be prompted if Docker Desktop is not installed. |
| Trust ASP.NET Core SSL certificate | Prompt Me | ASP.NET Core 2.x projects | When set to **Prompt Me**, if the `localhost` SSL certificate is not trusted, Visual Studio will prompt every time you run an ASP.NET Core 2.x project. |

The following table describes **Single Project** and **Docker Compose** settings:

:::moniker range="<=vs-2019"
| Name | Default Setting | Applies To | Description |
| -----|:---------------:|:----------:| ----------- |
| Pull required Docker images on project open | True | Single Project, Docker Compose | For increased performance when loading projects, Visual Studio will start a Docker pull operation in the background so that when you're ready to run your code, the image is already downloaded or in the process of downloading. If you're just loading projects and browsing code, you can set to **False** to avoid downloading container images you don't need. |
| Pull updated Docker images on project open | .NET Core projects | Single Project, Docker Compose | When you open a project, check for updates to images and download if available. |
| Run containers on project open | True | Single Project, Docker Compose | Again for increased performance, Visual Studio creates a container ahead of time so that it's ready for when you build and run your container. If you want to control when your container is created, set to **False**. |
| Remove containers on project close | True | Single Project, Docker Compose | Set to **False** if you would like containers for your solution to be retained after closing the solution or closing Visual Studio. |
:::moniker-end
:::moniker range=">=vs-2022"
| Name | Default Setting | Applies To | Description |
| -----|:---------------:|:----------:| ----------- |
| Pull required Docker images on project open | True | Single Project, Docker Compose | For increased performance when loading projects, Visual Studio will start a Docker pull operation in the background so that when you're ready to run your code, the image is already downloaded or in the process of downloading. If you're just loading projects and browsing code, you can set to **False** to avoid downloading container images you don't need. |
| Pull updated Docker images on project open | .NET Core projects | Single Project, Docker Compose | When you open a project, check for updates to images and download if available. |
| Run containers on project open | True | Single Project, Docker Compose | Again for increased performance, Visual Studio creates a container ahead of time so that it's ready for when you build and run your container. If you want to control when your container is created, set to **False**. |
| Remove containers on project close | True | Single Project, Docker Compose | Set to **False** if you would like containers for your solution to be retained after closing the solution or closing Visual Studio. |
| Run a service in containers to enable Azure Authentication | True | Single Project, Docker Compose | Visual Studio version 17.6 or later runs a [token proxy](#configure-azure-authentication) service in the container that assists with Azure Authentication, so your apps can use Azure services during development. Set to `False` if you don't want this service to be installed and run.|
| Run a service in containers to enable Hot Reload | True | Single Project, Docker Compose | Set to `False` if you don't want this service to be installed and run. The Hot Reload service is available in Visual Studio 2022 version 17.7 and later and only supports running without debugging (**Ctrl**+**F5**).  |
:::moniker-end

The **Containers Tool Window** settings control the settings that apply to the **Containers** tool window, which shows information about Docker containers and images. See [Use the Containers window](view-and-diagnose-containers.md)

![Visual Studio Container Tools Options, showing the settings available for the Containers tool window](media/configure-container-tools/tools-options-3.png)

The following table describes the **Containers** window settings:

| Name | Default Setting | Description |
| -----|:---------------:| ----------- |
| Confirm before pruning containers | Always | Controls whether you are prompted when pruning unused containers. |
| Confirm before pruning images | Always | Controls whether you are prompted when pruning unused images. |
| Confirm before removing a container | Always | Controls whether you are prompted when removing a container. |
| Confirm before removing an image | Always | Controls whether you are prompted when removing an image. |
| Confirm before running large number of images | Always | Controls whether you are prompted before starting containers from more than 10 images at a time. |

> [!WARNING]
> If the `localhost` SSL certificate is not trusted, and you select the box to suppress prompting, then HTTPS web requests might fail at run time in your app or service. In that case, clear the **Do not prompt** checkbox, run your project, and indicate trust at the prompt.

:::moniker range=">=vs-2022"

## Configure Azure authentication

If your app uses Azure services, it needs the appropriate authentication credentials when it runs in a container in order to authenticate with Azure services. During development, you can usually use your own Azure credentials instead of the credentials the app uses in production, but those credentials are required in the container environment to be useful for the running containerized app.

Starting with Visual Studio 2022 version 17.6, in both single-container and Docker Compose projects, a [token](https://www.nuget.org/packages/Azure.Identity#readme-body-tab) proxy service is deployed and run in your containers that helps your apps and services authenticate in Azure. The feature requires [Azure Identity 1.9.0](https://www.nuget.org/packages/Azure.Identity/1.9.0#readme-body-tab) or later. With this service enabled, you can automatically use most Azure services without any additional configuration or setup within the container. Specifically, your code can use `DefaultAzureCredential` and `VisualStudioCredential` to authenticate with Azure services in the same way as outside of a container. See the [Azure Identity 1.9.0 README](https://www.nuget.org/packages/Azure.Identity/1.9.0#readme-body-tab).

To disable this feature, set the **Tools** > **Options** setting **Run a service in containers to enable Azure Authentication** (described earlier in this article) to `False`.

> [!CAUTION]
> There is a potential security concern if you use the token proxy and have enabled certain Container Tools diagnostic logs. When logging is enabled, authentication credentials could be logged as plain text. These logs are enabled by certain environment variables. For single container projects, the environment variable is `MS_VS_CONTAINERS_TOOLS_LOGGING_ENABLED`, which then logs in `%tmp%\Microsoft.VisualStudio.Containers.Tools`. For Docker Compose projects, it is `MS_VS_DOCKER_TOOLS_LOGGING_ENABLED`, which then logs in `%tmp%\Microsoft.VisualStudio.DockerCompose.Tools`.

:::moniker-end

## Related content

Read more about working with containers in Visual Studio in this [overview](overview.md).
