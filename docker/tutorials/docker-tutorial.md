---
title: "Tutorial: Get started with Docker apps in Visual Studio Code"
description: In this tutorial, learn how to start using Docker with VS Code. Create and deploy apps to Azure.
author: ghogen
ms.author: ghogen
ms.prod: vs-code
ms.topic: tutorial 
ms.date: 03/04/2022
ms.custom: [template-tutorial, contperf-fy22q3]

# Under contractual obligation with Docker Inc. to provide this content. Contact is: nebuk89. Mike Morton has context on MSFT side, but has moved on to another role. 
---

# Tutorial: Create and share a Docker app with Visual Studio Code

This tutorial is the beginning of a three-part series introducing Docker using Visual Studio Code (VS Code).
You'll learn to create and run containers, persist data, and deploy your containerized application to Azure.

In this first tutorial, you'll learn to create and deploy Docker apps.
Then you can update and share your containerized app.

Containers are compact virtualized environments, like virtual machines, that provide a platform for building and running apps.
Containers don't require the size and overhead of a complete operating system.
[Docker](https://www.docker.com) is a third-party, industry standard container provider and container management system.

Docker Desktop runs on your computer and manages your local containers.
Development tools like Visual Studio and VS Code offer extensions that let you work with a local Docker Desktop service.
You can create containerized apps, deploy apps to containers, and debug apps running on your containers.

In this tutorial, you learn how to:

> [!div class="checklist"]
> - Create a container.
> - Build a container image.
> - Start an app container.
> - Update the code and replace the container.
> - Share your image.
> - Run the image on a new instance.

## Prerequisites

- [Visual Studio Code](https://code.visualstudio.com/download).
- [Docker VS Code Extension](https://code.visualstudio.com/docs/containers/overview).
- [Docker Desktop](https://docs.docker.com/desktop/).
- A [Docker Hub](https://hub.docker.com/signup) account. You can create an account for free.

The tutorial works with Windows 10 or later and Docker Desktop configured to use Linux containers.

## Create a container

A container is a process on your computer.
It's isolated from all other processes on the host computer.
That isolation uses kernel namespaces and control groups.

A container uses an isolated filesystem.
This custom filesystem is provided by a *container image*.
The image contains everything needed to run an application, such as all dependencies, configuration, scripts, and binaries.
The image also contains other configuration for the container, such as environment variables, a default command to run, and other metadata.

After you install the Docker extension for VS Code, you can work with containers in VS Code.
In addition to context menus in the Docker pane, you can select **Terminal** > **New Terminal** to open a command-line window.
You can also run commands in a Bash window.
Unless specified, any command labeled as **Bash** can run in a Bash window or the VS Code terminal.

1. Set Docker to Linux container mode. To switch to Linux containers, right-click on the Docker icon in the taskbar, and choose **Switch to Linux containers**.

1. In VS Code, select **Terminal** > **New Terminal**.

1. In the terminal window or a Bash window, run this command.

   ```bash
   docker run -d -p 80:80 docker/getting-started
   ```

   This command contains the following parameters:

   - `-d` Run the container in detached mode, in the background.
   - `-p 80:80` Map port 80 of the host to port 80 in the container.
   - `docker/getting-started` Specifies the image to use.

   > [!TIP]
   > You can combine single character flags to shorten the full command.
   > As an example, the command above could be written as:
   >
   > ```bash
   > docker run -dp 80:80 docker/getting-started
   > ```

1. In VS Code, select the Docker icon on the left to view the Docker extension.

   ![Screenshot shows the Docker extension with the docker/getting-started tutorial running.](media/vs-tutorial-docker-extension.png)

   The Docker VS Code Extension shows you the containers running on your computer.
   You can access container logs and manage container lifecycle, such as stop and remove.

   The container name, **modest_schockly** in this example, is randomly created.
   Yours will have a different name.

1. Right-click on **docker/getting-started** to open a context menu.
   Select **Open in Browser**.

   Instead, open a browser and enter `http://localhost/tutorial/`.

   You'll see a page, hosted locally, about DockerLabs.

1. Right-click on **docker/getting-started** to open a context menu.
   Select **Remove** to remove this container.

   To remove a container by using the command line, run this command to get its container ID:

   ```bash
   docker ps
   ```

   Then stop and remove the container:

   ```bash
   docker stop <container-id>
   docker rm <container-id>
   ```

1. Refresh your browser.
   The Getting Started page you saw a moment ago is gone.

## Build a container image for the app

This tutorial uses a simple Todo application.

![Screenshot shows the sample application with several items added and a text box and button to add new items.](media/todo-list-sample.png)

The app allows you to create work items and to mark them as completed or delete them.

In order to build the application, create a *Dockerfile*.
A Dockerfile is a text-based script of instructions that is used to create a container image.

1. Go to the [Docker Getting Started Tutorial](https://github.com/docker/getting-started) repo, and then select **Code** > **Download ZIP**.
   Extract the contents to a local folder.

   ![Screenshot shows part of the Github site, with the green Code button and Download ZIP option highlighted.](media/download-zip.png)

1. In VS Code, select **File** > **Open Folder**.
   Navigate to the *app* folder in the extracted project and open that folder.
   You should see a file called *package.json* and two folders called *src* and *spec*.

   ![Screenshot of Visual Studio Code showing the package.json file open with the app loaded.](media/ide-screenshot.png)

1. Create a file named *Dockerfile* in the same folder as the file *package.json* with the following contents.

   ```dockerfile
   FROM node:12-alpine
   RUN apk add --no-cache python2 g++ make
   WORKDIR /app
   COPY . .
   RUN yarn install --production
   CMD ["node", "/app/src/index.js"]
   ```

   > [!NOTE]
   > Be sure that the file has no file extension like `.txt`.

1. In the file explorer, on the left in VS Code, right-click the *Dockerfile* and then select **Build Image**.
   Enter *getting-started* as the tag for the image in the text entry box.

   The tag is a friendly name for the image.

   To create a container image from the command line, use the following command.

    ```bash
    docker build -t getting-started .
    ```

    > [!NOTE]
    > In an external Bash window, go to the `app` folder that has the *Dockerfile* to run this command.

You've used the *Dockerfile* to build a new container image.
You might have noticed that many "layers" were downloaded.
The *Dockerfile* starts from the `node:12-alpine` image.
Unless that is on your computer already, that image needed to be downloaded.

After the image was downloaded, the *Dockerfile* copies your application and uses `yarn` to install your application's dependencies.
The `CMD` value in the *Dockerfile* specifies the default command to run when starting a container from this image.

The `.` at the end of the `docker build` command tells that Docker should look for the *Dockerfile* in the current directory.

## Start your app container

Now that you have an image, you can run the application.

1. To start your container, use the following command.

   ```bash
   docker run -dp 3000:3000 getting-started
   ```

   The `-d` parameter indicates that you're running the container in detached mode, in the background.
   The `-p` value creates a mapping between the host port 3000 and the container port 3000.
   Without the port mapping, you wouldn't be able to access the application.

1. After a few seconds, in VS Code, in the Docker area, under **CONTAINERS**, right-click **getting-started** and select **Open in Browser**.
   You can instead open your web browser to `http://localhost:3000`.

   You should see the app running.

   ![Screenshot shows the sample app with no items and the text No items yet Add one above.](media/todo-list-empty.png)

1. Add an item or two and see that it works as you expect.
   You can mark items as complete and remove items.
   Your frontend is successfully storing items in the backend.

## Update the code and replace the container

At this point, you have a running todo list manager with a few items.
Now, let's make a few changes and learn about managing your containers.

1. In the `src/static/js/app.js` file, update line 56 to use this new text label:

   ```diff
   - <p className="text-center">No items yet! Add one above!</p>
   + <p className="text-center">You have no todo items yet! Add one above!</p>
   ```

    Save your change.

1. Stop and remove the current version of the container.
   More than one container can't use the same port.

   Right-click the **getting-started** container and select **Remove**.

   ![Screenshot shows the Docker extension with a container selected and a context menu with Remove selected.](media/vs-remove-container.png)

   Or, from the command line, use the following command to get the container ID.

   ```bash
   docker ps
   ```

   Then stop and remove the container:

   ```bash
   docker stop <container-id>
   docker rm <container-id>
   ```

1. Build the updated version of the image.
   In the file explorer, right-click *Dockerfile*, then select **Build Image**.

   Or, to build on the command line, use the same command you used before.

    ```bash
    docker build -t getting-started .
    ```

1. Start a new container that uses the updated code.

    ```bash
    docker run -dp 3000:3000 getting-started
    ```

1. Refresh your browser on `http://localhost:3000` to see your updated help text.

   ![Screenshot shows the sample application with the modified text, described above.](media/todo-list-updated-empty-text.png)

## Share your image

Now that you've built an image, you can share it.
To share Docker images, use a Docker registry.
The default registry is Docker Hub, which is where all of the images we've used have come from.

To push an image, first, you need to create a repo on Docker Hub.

1. Go to [Docker Hub](https://hub.docker.com) and sign in to your account.

1. Select **Create Repository**.

1. For the repo name, enter `getting-started`.
   Make sure that the **Visibility** is **Public**.

1. Select **Create**.

   On the right of the page, you'll see a section named **Docker commands**.
   This section gives an example command to run to push to this repo.

   ![Screenshot shows the Docker Hub page with a suggested Docker command.](media/push-command.png)

1. In the Docker view of VS Code, under **IMAGES**, right-click the image tag, and select **Push**.
   Select **Connect registry** and then **Docker Hub**.

   You'll need to enter your Docker Hub account, password, and a namespace.

To push to Docker Hub by using the command line, use this procedure.

1. Sign in to the Docker Hub:

   ```bash
   docker login -u <username>
   ```

1. Use the following command to give the *getting-started* image a new name.

    ```bash
    docker tag getting-started <username>/getting-started
    ```

1. Use the following command to push your container.

    ```bash
    docker push <username>/getting-started
    ```

## Run the image on a new instance

Now that your image has been built and pushed into a registry, try running the app on a brand new instance that has never seen this container image.
To run your app, use Play with Docker.

1. Open your browser to [Play with Docker](http://play-with-docker.com).

1. Sign in with your Docker Hub account.

1. Select **Start** and then select the **+ ADD NEW INSTANCE** link in the left side bar.
   After a few seconds, a terminal window opens in your browser.

   ![Screenshot shows the Play with Docker site with an add new instance link.](media/play-with-docker-add-new-instance.png)

1. In the terminal, start your app.

    ```bash
    docker run -dp 3000:3000 <username>/getting-started
    ```

    Play with Docker pulls down your image and starts it.

1. Select the **3000** badge, next to **OPEN PORT**.
   You should see the app with your modifications.

   If the **3000** badge doesn't show up, select **OPEN PORT** and enter 3000.

## Clean up resources

Keep everything that you've done so far to continue this series of tutorials.

## Next steps

You've completed this tutorial.
You've learned to create container images, run a containerized app, update your code, and run your image on a new instance.

Here are some resources that might be useful to you:

- [Docker Cloud Integration](https://github.com/docker/compose-cli)
- [Examples](https://github.com/docker/awesome-compose)

Next, try the next tutorial in this series:

> [!div class="nextstepaction"]
> [Persist data and layer a Docker app](tutorial-persist-data-layer-docker-app-with-vscode.md)
