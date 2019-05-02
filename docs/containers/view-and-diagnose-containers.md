---
title: View container logs and environment variables and access the filesystem.
description: Describes how to improve your ability to debug and diagnose your container-based apps in Visual Studio by using a tool window  to see what's going on inside the containers that host your app.
author: ghogen
ms.author: ghogen
ms.topic: conceptual
ms.date: 05/06/2019
ms.technology: vs-azure
monikerRange: vs-2019
---
# How to: View and diagnose containers in Visual Studio

You can view what's going on inside the containers that host your app by using the **Containers** window. If you're used to using the command prompt to run Docker commands to view and diagnose what's going on with your containers, this window provides a more convenient way to monitor your containers without leaving the VS IDE.

> [!NOTE]
> The Containers window is currently available as a Preview extension that you can [download](https://aka.ms/vscontainerspreview) for Visual Studio 2019.

## Prerequisities

- Install [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019) with the **Web Development**, **Azure Tools** workload, and/or **.NET Core cross-platform development** workload
- Install the [Containers window extension](https://aka.ms/vscontainerspreview).

## View information about your containers

To view your containers in Visual Studio, open the **Containers** window (from the main menu, that's **View** > **Other Windows** > **Containers**).  The **Containers** window appears.

![Screenshot of Environment tab in Containers window](media/view-and-diagnose-containers/container-environment-vars.png)

On the left side, you see the list of containers, where you can see the friendly name that Docker chose for your container. To the right, you see a pane with tabs for **Environment**, **Ports**, **Logs**, and **Files**.

> [!TIP]
> You can easily customize where the **Containers** tool window is docked in Visual Studio. See [Customizing window layouts in Visual Studio](/visualstudio/ide/customizing-window-layouts-in-visual-studio). By default, the **Containers** window is docked with the **Watch** window when the debugger is running.

## View environment variables

The environment variables shown here reflect the environment on the container. For your app's container, you can set these variables in the Dockerfile, in a .env file, or by using the -e option when you start a container using a Docker command.

![Screenshot of Environment tab in Containers window](media/view-and-diagnose-containers/container-environment-vars.png)

> [!NOTE]
> Any changes to the environment variables ... 

## View port mappings

On the **Ports** tab, you can check the port mappings that are in effect for your container.

![Screenshot of Ports tab in Containers window](media/view-and-diagnose-containers/container-ports.png)

## View logs

To view the output of your app running in the container, set the Configuration to **Release**, right-click on the Dockerfile in **Solution Explorer**, open a command prompt, and start the container by using the docker command:

```cmd
docker run -d --name <container-name> <image-repository:image-tag>
```

The `container-name` in the command can be anything of your choosing. The `image-repository` and `image-tag` values specify the image to use. For example, if the project is `LogIt`, and you used **Build Docker Image** to build the image, the repository name and tag are `logit:latest`. You can use the command `docker image list` to view available images and find the one you want.

![Screenshot of Logs tab in Containers window](media/view-and-diagnose-containers/containers-logs.jpg)

## View the filesystem

On the **Files** tab, you can view the container's filesystem, including the app folder that contains your project.

![Screenshot of Files tab in Containers window](media/view-and-diagnose-containers/container-filesystem.png)

To open files in Visual Studio, browse to the file and double-click it. Visual Studio opens files in read-only mode.

By viewing the folders and files in the container, you can investigate issues with your Dockerfile, your container images, and any other configuration that affects your container's file structure.

## Start, stop, and remove containers

By default, the **Containers** window shows all containers on the machine that Docker manages. You can use the toolbar buttons to start, stop, or remove (delete) a container you no longer want.  This list is dynamically updated as containers are created or removed.

## Next steps

Learn more about the Container Tools available in Visual Studio by reading the [Container Tools Overview](overview.md).

## See also

[Container Development in Visual Studio](/visualstudio/containers)

[Extensions Marketplace for Visual Studio](https://marketplace.visualstudio.com/)
