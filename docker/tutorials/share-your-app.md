---
title: "Docker tutorial - Part 2: Share your app"
description: Describes how to share Docker images using the Docker Hub registry.
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
# Share your app

Now that we've built an image, let's share it! To share Docker images, you have to use a Docker registry. The default registry is Docker Hub and is where all of the images we've used have come from.

## Create a repo

To push an image, first, you need to create a repo on Docker Hub.

1. Go to [Docker Hub](https://hub.docker.com/signup/msftedge?utm_source=msftedge) and log in if you need to.

1. Click the **Create Repository** button.

1. For the repo name, use `getting-started`. Make sure the Visibility is `Public`.

1. Click the **Create** button!

If you look on the right-side of the page, you'll see a section named **Docker commands**. This gives an example command that you will need to run to push to this repo.

![Docker command with push example](media/push-command.png)

## Push the image

1. In the command line, try running the push command you see on Docker Hub. Note that your command will be using your namespace, not "docker".

    ```plaintext
    $ docker push docker/getting-started
    The push refers to repository [docker.io/docker/getting-started]
    An image does not exist locally with the tag: docker/getting-started
    ```

    Why did it fail? The push command was looking for an image named docker/getting-started, but didn't find one. If you run `docker image ls`, you won't see one either.

    To fix this, you need to "tag" your existing image we've built to give it another name.

1. Sign in to the Docker Hub using the command `docker login -u <username>`.

1. Use the `docker tag` command to give the `getting-started` image a new name. Be sure to swap out `<username>` with your Docker ID.

    ```bash
    docker tag getting-started <username>/getting-started
    ```

1. Now try your push command again. If you're copying the value from Docker Hub, you can drop the `tagname` portion, as you didn't add a tag to the image name. If you don't specify a tag, Docker will use a tag called `latest`.

    ```bash
    docker push <username>/getting-started
    ```

    Instead of the command line, you can also right-click on the image tag in the **Images** section of the Docker view, and choose **Push...**, then choose **Connect registry...** and then **Docker Hub**.

## Run the image on a new instance

Now that your image has been built and pushed into a registry, try running the app on a brand new instance that has never seen this container image! To do this, you will use Play with Docker.

1. Open your browser to [Play with Docker](http://play-with-docker.com).

1. Sign in with your Docker Hub account.

1. Once you're logged in, click on the "+ ADD NEW INSTANCE" link in the left side bar. (If you don't see it, make your browser a little wider.) After a few seconds, a terminal window will be opened in your browser.

    ![Play with Docker add new instance](media/pwd-add-new-instance.png)

1. In the terminal, start your freshly pushed app.

    ```bash
    docker run -dp 3000:3000 <username>/getting-started
    ```

    You should see the image get pulled down and eventually start up!

1. Click on the 3000 badge when it comes up and you should see the app with your modifications! Hooray! If the 3000 badge doesn't show up, you can click on the **Open Port** button and type in 3000.

## Recap

In this section, you learned how to share images by pushing them to a registry. You then went to a brand new instance and were able to run the freshly pushed image. This is quite common in CI pipelines, where the pipeline will create the image and push it to a registry and then the production environment
can use the latest version of the image.

Now that you've that figured out, recall that at the end of the last section, when you restarted the app, you lost all of your todo list items. That's obviously not a great user experience, so you'll learn next how you can persist the data across restarts!

## Next steps

Continue with the tutorial!

> [!div class="nextstepaction"]
> [Persisting your database](persist-your-data.md)
