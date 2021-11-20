---
title: "Docker tutorial - Part 6: Use bind mounts"
description: Describes how to use bind mounts to control the mount point on the host.
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
# Use bind mounts

In the previous chapter, you learned about and used a **named volume** to persist the data in your database. Named volumes are great if you simply want to store data, as you don't have to worry about *where* the data is stored.

With **bind mounts**, you control the exact mountpoint on the host. You can use this to persist data, but is often used to provide additional data into containers. When working on an application, you can use a bind mount to mount source code into the container to let it see code changes, respond, and let you see the changes right away.

For Node-based applications, [nodemon](https://npmjs.com/package/nodemon) is a great tool to watch for file changes and then restart the application. There are equivalent tools in most other languages and frameworks.

## Quick volume type comparisons

Bind mounts and named volumes are the two main types of volumes that come with the Docker engine. However, additional volume drivers are available to support other uses cases ([SFTP](https://github.com/vieux/docker-volume-sshfs), [Ceph](https://ceph.com/geen-categorie/getting-started-with-the-docker-rbd-volume-plugin/), [NetApp](https://netappdvp.readthedocs.io/en/stable/), [S3](https://github.com/elementar/docker-s3-volume), and more).

| Property | Named Volumes | Bind Mounts |
| -------- | ------------- | ----------- |
| Host Location | Docker chooses | You control |
| Mount Example (using `-v`) | my-volume:/usr/local/data | /path/to/data:/usr/local/data |
| Populates new volume with container contents | Yes | No |
| Supports Volume Drivers | Yes | No |

## Start a dev-mode container

To run your container to support a development workflow, you'll do the following:

- Mount your source code into the container
- Install all dependencies, including the "dev" dependencies
- Start nodemon to watch for filesystem changes

1. Make sure you don't have any previous `getting-started` containers running.

1. In the `app` folder, run the following command (replace the ` \ ` characters with `` ` `` in Windows PowerShell). You'll learn what's going on afterwards:

    ```bash
    docker run -dp 3000:3000 -v ${PWD}:/app node:12-alpine sh -c "yarn install && yarn run dev"
    ```

    - `-dp 3000:3000` - same as before. Run in detached (background) mode and create a port mapping
    - `-v ${PWD}:/app"` - bind mount the current directory from the host in the container into the `/app` directory
    - `node:12-alpine` - the image to use. Note that this is the base image for your app from the Dockerfile
    - `sh -c "yarn install && yarn run dev"` - the command. We're starting a shell using `sh` (alpine doesn't have `bash`) and running `yarn install` to install *all* dependencies and then running `yarn run dev`. If you look in the `package.json`, we'll see that the `dev` script is starting `nodemon`.

1. You can watch the logs using `docker logs -f <container-id>`. You'll know you're ready to go when you see this:

    ```bash
    docker logs -f <container-id>
    $ nodemon src/index.js
    [nodemon] 1.19.2
    [nodemon] to restart at any time, enter `rs`
    [nodemon] watching dir(s): *.*
    [nodemon] starting `node src/index.js`
    Using sqlite database at /etc/todos/todo.db
    Listening on port 3000
    ```

    When you're done watching the logs, exit out by hitting `Ctrl`+`C`.

1. Now, make a change to the app. In the `src/static/js/app.js` file, change the **Add Item** button to simply say **Add**. This change will be on line 109.

    ```diff
    -                         {submitting ? 'Adding...' : 'Add Item'}
    +                         {submitting ? 'Adding...' : 'Add'}
    ```

1. Simply refresh the page (or open it) and you should see the change reflected in the browser almost immediately. It might take a few seconds for the Node server to restart, so if you get an error, just try refreshing after a few seconds.

    ![Screenshot of updated label for Add button](media/updated-add-button.png)

1. Feel free to make any other changes you'd like to make. When you're done, stop the container and build your new image using `docker build -t getting-started .`.

Using bind mounts is *very* common for local development setups. The advantage is that the dev machine doesn't need to have all of the build tools and environments installed. With a single `docker run` command, the dev environment is pulled and ready to go. You'll learn about Docker Compose in a future step, as this will help simplify your commands (you're already getting a lot of flags).

## Recap

At this point, you can persist your database and respond rapidly to the needs and demands of your investors and founders. Hooray! But, guess what? You received great news!

**Your project has been selected for future development!**

In order to prepare for production, you need to migrate your database from working in SQLite to something that can scale a little better. For simplicity, you'll keep with a relational database and switch your application to use MySQL. But, how should you run MySQL? How do you allow the containers to talk to each other? You'll learn about that next!

## Next steps

Continue with the tutorial!

> [!div class="nextstepaction"]
> [Multi-container apps](multi-container-apps.md)
