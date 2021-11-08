---
title: "Docker tutorial - Part 3: Update your app"
description: Describes how to update a Docker app.
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
# Update the app

As a small feature request, you've been asked by the product team to change the "empty text" when you don't have any todo list items. They would like to transition it to the following:

> You have no todo items yet! Add one above!

Pretty simple, right? Let's make the change.

## Update the source code

1. In the `src/static/js/app.js` file, update line 56 to use the new empty text.

    ```diff
    -                <p className="text-center">No items yet! Add one above!</p>
    +                <p className="text-center">You have no todo items yet! Add one above!</p>
    ```

1. Build the updated version of the image, using the same command you used before.

    ```bash
    docker build -t getting-started .
    ```

1. Start a new container using the updated code.

    ```bash
    docker run -dp 3000:3000 getting-started
    ```

**Uh oh!** You probably saw an error like this (the IDs will be different):

```bash
docker: Error response from daemon: driver failed programming external connectivity on endpoint laughing_burnell 
(bb242b2ca4d67eba76e79474fb36bb5125708ebdabd7f45c8eaf16caaabde9dd): Bind for 0.0.0.0:3000 failed: port is already allocated.
```

So, what happened? The new container couldn't start, because your old container is still running. The reason this is a problem is because that container is using the host's port 3000 and only one process on the machine (containers included) can listen to a specific port. To fix this, remove the old container.

## Replace the old container

To remove a container, it first needs to be stopped. Once it has stopped, it can be removed. You have two ways that you can remove the old container. Feel free to choose the path that you're most comfortable with.

### Remove a container using the CLI

1. Get the ID of the container by using the `docker ps` command.

    ```bash
    docker ps
    ```

1. Use the `docker stop` command to stop the container.

    ```bash
    # Swap out <the-container-id> with the ID from docker ps
    docker stop <the-container-id>
    ```

1. Once the container has stopped, you can remove it by using the `docker rm` command.

    ```bash
    docker rm <the-container-id>
    ```

> [!TIP]
> You can stop and remove a container in a single command by adding the "force" flag to the `docker rm` command. For example: `docker rm -f <the-container-id>`

### Remove a container using the Docker view

If you open the VS Code Extension, you can remove a container with two clicks! It's certainly much easier than having to look up the container ID and remove it.

1. With the extension opened, navigate to the container and right-click.

1. Click on the **Remove** option.

1. Confirm the removal and you're done!

![Docker view - removing a container](media/vs-removing-container.png)

### Start the updated app container

1. Now, start your updated app.

    ```bash
    docker run -dp 3000:3000 getting-started
    ```

1. Refresh your browser on `http://localhost:3000` and you should see your updated help text!

![Updated application with updated empty text](media/todo-list-updated-empty-text.png)

## Recap

While you were able to build an update, there were two things you might have noticed:

- All of the existing items in your todo list are gone! That's not a very good app! We'll talk about that
shortly.
- There were *a lot* of steps involved for such a small change. In an upcoming section, you'll learn about how to see code updates without needing to rebuild and start a new container every time you make a change.

Before learning about persistence, you'll quickly see how to share these images with others.

## Next steps

Continue with the tutorial!

> [!div class="nextstepaction"]
> [Sharing your app](share-your-app.md)
