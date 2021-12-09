---
title: "Docker tutorial - Part 2: Build and run the todo list sample app"
description: Overview of the todo list sample app that runs in Node.js.
ms.date: "08/06/2021"
author: nebuk89
ms.author: ghogen
manager: jmartens
ms.technology: vs-docker
ms.custom: "contperf-fy22q1"

ms.topic: conceptual
ms.workload:
  - "azure"
---
# Build and run the todo sample app

>[!NOTE]
> This is a continuation of a tutorial that starts [here](docker-tutorial.md)

For the rest of this tutorial, you'll be working with a simple todo list manager that is running in Node.js. If you're not familiar with Node.js, don't worry! No real JavaScript experience is needed!

At this point, your development team is quite small and you're simply building an app to prove out your MVP (minimum viable product). You want to show how it works and what it's capable of doing without needing to think about how it will work for a large team, multiple developers, and so on.

![Todo List Manager Screenshot](media/todo-list-sample.png)

## Get the app

Before you can run the application, you need to get the application source code onto your machine. For real projects, you will typically clone the repo. But, for this tutorial, we have created a ZIP file containing the application.

1. If you're using Windows, make sure that you have Docker for Windows or Docker Community Edition installed on the local machine. See [Docker for Windows installation documentation](https://docs.docker.com/docker-for-windows/install/). The install process makes the ZIP file containing the sample available at the localhost address. For Mac, install [Docker Desktop for Mac](https://docs.docker.com/docker-for-mac/install/).

1. Download the source for the app from the [Docker](https://github.com/docker/getting-started) repo. You can download the ZIP file for the repo. To download the ZIP file, use the green **Code** button and choose **Download ZIP**. Open the ZIP file and Extract All to extract the source of the app from the *app* folder to a folder on your hard drive.

   ![Screenshot showing the green Code button and Download ZIP option](media/download-zip.png)

1. Once extracted, use your favorite code editor to open the project. If you're in need of an editor, you can use [Visual Studio Code](https://code.visualstudio.com/). You should see the `package.json` and two subdirectories (`src` and `spec`).

    ![Screenshot of Visual Studio Code opened with the app loaded](media/ide-screenshot.png)

## Building the app's container image

In order to build the application, you need to use a `Dockerfile`. A Dockerfile is simply a text-based script of instructions that is used to create a container image. If you've created Dockerfiles before, you might see a few flaws in the Dockerfile below. But, don't worry! We'll go over them.

1. Create a file named `Dockerfile` in the same folder as the file `package.json` with the following contents.

    ```dockerfile
    FROM node:12-alpine
    WORKDIR /app
    COPY . .
    RUN yarn install --production
    CMD ["node", "/app/src/index.js"]
    ```

    Please check that the file `Dockerfile` has no file extension like `.txt`. Some editors may append this file extension automatically and this would result in an error in the next step.

1. If you haven't already done so, open a terminal and go to the `app` directory with the `Dockerfile`. Now build the container image using the `docker build` command.

    ```bash
    docker build -t getting-started .
    ```

    Alternatively, you can also right-click on the Dockerfile and choose **Build Image...** and then specify the tag at the prompt.

    This command used the Dockerfile to build a new container image. You might have noticed that a lot of "layers" were downloaded. This is because you instructed the builder that you wanted to start from the `node:12-alpine` image. But, since you didn't have that on your machine, that image needed to be downloaded.

    After the image was downloaded, you copied in your application and used `yarn` to install your application's dependencies. The `CMD` directive specifies the default command to run when starting a container from this image.

    Finally, the `-t` flag tags your image. Think of this simply as a human-readable name for the final image. Since you named the image `getting-started`, you can refer to that image when you run a container.

    The `.` at the end of the `docker build` command tells that Docker should look for the `Dockerfile` in the current directory.

## Starting an app container

Now that you have an image, run the application! To do so, use the `docker run` command (remember that from earlier?).

1. Start your container using the `docker run` command and specify the name of the image you just created:

    ```bash
    docker run -dp 3000:3000 getting-started
    ```

    Remember the `-d` and `-p` flags? You're running the new container in "detached" mode (in the background) and creating a mapping between the host's port 3000 to the container's port 3000. Without the port mapping, you wouldn't be able to access the application.

1. After a few seconds, open your web browser to `http://localhost:3000`.
    You should see the app!

    ![Empty Todo List](media/todo-list-empty.png)

1. Go ahead and add an item or two and see that it works as you expect. You can mark items as complete and remove items. Your frontend is successfully storing items in the backend! Pretty quick and easy, huh?

At this point, you should have a running todo list manager with a few items, all built by you! Now, let's make a few changes and learn about managing your containers.

If you take a quick look at the VS Code extension, you should see your two containers running now (this tutorial and your freshly launched app container)!

![Docker Extension  with tutorial and app containers running](media/vs-two-containers.png)

## Recap

In this short section, you learned the very basics about building a container image and created a Dockerfile to do so. Once you built an image, you started the container and saw the running app!

Next, you're going to make a modification to the app and learn how to update the running application with a new image. Along the way, you'll learn a few other useful commands.

## Next steps

Continue with the tutorial!

> [!div class="nextstepaction"]
> [Updating your app](update-your-app.md)
