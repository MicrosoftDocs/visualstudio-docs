---
title: "Tutorial: persist data & layer Docker app - VS Code"
description: Learn how to persist data, use bind mounts, and layer (Yarn) your app with VS Code.
author: ucheNkadiCode
ms.author: uchen
ms.prod: vs-code
ms.topic: tutorial
ms.date: 02/15/2022
ms.custom: template-tutorial

# Under contractual obligation with Docker Inc. to provide this content. Contact is: nebuk89. Mike Morton has context on MSFT side, but has moved on to another role. 
---


# Tutorial: Persist data & layer Docker app - VS Code


In case you didn't notice, the todo list is being wiped clean every single time you launch the container. Why is this? Let's dive into how the container is working.


When a container runs, it uses the various layers from an image for its filesystem. Each container also gets its own "scratch space" to create, update, or remove files. Any changes won't be seen in another container, *even if* they are using the same image.



In this tutorial, you learn how to:

> [!div class="checklist"]
> -
> -
> -

## Prerequisites

This tutorial continues the previous tutorial, [Create and share a Docker app with Visual Studio Code](tutorial-docker-apps-with-vscode.md).
Start with that one, which includes prerequisites.

## Persist your data

To see this in action, you're going to start two containers and create a file in each.
What you'll see is that the files created in one container aren't available in another.

1. Start a `ubuntu` container that will create a file named `/data.txt` with a random number between 1 and 10000.

   ```bash
   docker run -d ubuntu bash -c "shuf -i 1-10000 -n 1 -o /data.txt && tail -f /dev/null"
   ```

   This command starts invokes two commands by using `&&`.
   The first portion picks a single random number and writes it to `/data.txt`.
   The second command is simply watching a file to keep the container running.

1. Validate you can see the output by using `exec` to get into the container. To do so, open the VS Code extension and on click on the **Attach Shell** option. This will use `exec` to open a shell in the container within the VS Code terminal.

   ![VS Code open CLI into ubuntu container](media/attach_shell.png)

   You will see a terminal that is running a shell in the Ubuntu container. Run the following command to see the content of the `/data.txt` file. Close this terminal afterwards again.

   ```bash
   cat /data.txt
   ```

   If you prefer the command line, you can use the `docker exec` command to do the same. You need to get the container's ID (use `docker ps` to get it) and get the content with the following command.

   ```bash
   docker exec <container-id> cat /data.txt
   ```

   You should see a random number!

1. Start another `ubuntu` container (the same image) and you'll see you don't have the same file.

   ```bash
   docker run -it ubuntu ls /
   ```

   And look! There's no `data.txt` file there! That's because it was written to the scratch space for only the first container.

1. Go ahead and remove the first container using the `docker rm -f` command.

In this section, you saw that each container starts from the image definition each time it starts. While containers can create, update, and delete files, those changes are lost when the container is removed and all changes are isolated to that container. With volumes, you can change all of this.

[Volumes](https://docs.docker.com/storage/volumes/) provide the ability to connect specific filesystem paths of the container back to the host machine. If a directory in the container is mounted, changes in that directory are also seen on the host machine. If you mount that same directory across container restarts, you'd see the same files.

There are two main types of volumes. you will eventually use both, but you will start with **named volumes**.

## Persist your Todo data

By default, the todo app stores its data in a [SQLite Database](https://www.sqlite.org/index.html) at `/etc/todos/todo.db`. If you're not familiar with SQLite, no worries! It's simply a relational database in which all of the data is stored in a single file. While this isn't the best for large-scale applications,
it works for small demos. We'll talk about switching this to an actual database engine later.

With the database being a single file, if you can persist that file on the host and make it available to the next container, it should be able to pick up where the last one left off. By creating a volume and attaching (often called "mounting") it to the directory the data is stored in, you can persist the data. As the container writes to the `todo.db` file, it's persisted to the host in the volume.

As mentioned, you're going to use a **named volume**. Think of a named volume as simply a bucket of data. Docker maintains the physical location on the disk and you only need to remember the name of the volume. Every time you use the volume, Docker will make sure the correct data is provided.

1. Create a volume by using the `docker volume create` command.

   ```bash
   docker volume create todo-db
   ```

1. Stop the todo app container once again in the Docker view (or with `docker rm -f <id>`), as it is still running without using the persistent volume.

1. Start the todo app container, but add the `-v` flag to specify a volume mount. you will use the named volume and mount it to `/etc/todos`, which will capture all files created at the path.

   ```bash
   docker run -dp 3000:3000 -v todo-db:/etc/todos getting-started
   ```

1. Once the container starts up, open the app and add a few items to your todo list.

   ![Items added to todo list](media/items-added.png)

1. Remove the container for the todo app. Use the Docker view or `docker ps` to get the ID and then `docker rm -f <id>` to remove it.

1. Start a new container using the same command from above.

1. Open the app. You should see your items still in your list!

1. Go ahead and remove the container when you're done checking out your list.

Hooray! You've now learned how to persist data!

> [!TIP]
> While named volumes and bind mounts (which we'll talk about in a minute) are the two main types of volumes supported by a default Docker engine installation, there are many volume driver plugins available to support NFS, SFTP, NetApp, and more! This will be especially important once you start running containers on multiple hosts in a clustered environment with Swarm, Kubernetes, and so on.

## Dive into your volume

A lot of people frequently ask "Where is Docker *actually* storing my data when I use a named volume?" If you want to know, you can use the `docker volume inspect` command.

```bash
docker volume inspect todo-db
[
    {
        "CreatedAt": "2019-09-26T02:18:36Z",
        "Driver": "local",
        "Labels": {},
        "Mountpoint": "/var/lib/docker/volumes/todo-db/_data",
        "Name": "todo-db",
        "Options": {},
        "Scope": "local"
    }
]
```

The `Mountpoint` is the actual location on the disk where the data is stored. Note that on most machines, you'll need to have root access to access this directory from the host. But, that's where it is!

> [!NOTE]
> **Accessing Volume data directly on Docker Desktop**
> While running in Docker Desktop, the Docker commands are actually running inside a small VM on your machine. If you wanted to look at the actual contents of the *Mountpoint* directory, you would need to first get inside of the VM. In WSL 2, this is inside a WSL 2 distro and can be accessed through the File Explorer.

At this point, you have a functioning application that can survive restarts! You can show it off to your investors and hope they can catch your vision!

However, you saw earlier that rebuilding images for every change takes quite a bit of time. There's got to be a better way to make changes, right? With bind mounts (which we hinted at earlier), there is a better way! Let's take a look at that now!

## Use bind mounts

MERGE INTO NEXT SECTION

In the previous section, you learned about and used a **named volume** to persist the data in your database. Named volumes are great if you simply want to store data, as you don't have to worry about *where* the data is stored.

With **bind mounts**, you control the exact mountpoint on the host. You can use this to persist data, but is often used to provide additional data into containers. When working on an application, you can use a bind mount to mount source code into the container to let it see code changes, respond, and let you see the changes right away.

For Node-based applications, [nodemon](https://npmjs.com/package/nodemon) is a great tool to watch for file changes and then restart the application. There are equivalent tools in most other languages and frameworks.

## Quick volume type comparisons

MERGE INTO FOLLOWING SECTION

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
   docker run -dp 3000:3000 -w /app -v ${PWD}:/app node:12-alpine sh -c "yarn install && yarn run dev"
   ```

   - `-dp 3000:3000` - same as before. Run in detached (background) mode and create a port mapping
   - `-w /app` - working directory inside the container
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


## Image layering & Yarn

Did you know that you can look at what makes up an image? Using the `docker image history` command, you can see the command that was used to create each layer within an image.

1. Use the `docker image history` command to see the layers in the `getting-started` image you created earlier in the tutorial.

   ```bash
   docker image history getting-started
   ```

   You should get output that looks something like this (dates/IDs may be different).

   ```plaintext
   IMAGE               CREATED             CREATED BY                                      SIZE                COMMENT
   a78a40cbf866        18 seconds ago      /bin/sh -c #(nop)  CMD ["node" "/app/src/ind…   0B                  
   f1d1808565d6        19 seconds ago      /bin/sh -c yarn install --production            85.4MB              
   a2c054d14948        36 seconds ago      /bin/sh -c #(nop) COPY dir:5dc710ad87c789593…   198kB               
   9577ae713121        37 seconds ago      /bin/sh -c #(nop) WORKDIR /app                  0B                  
   b95baba1cfdb        13 days ago         /bin/sh -c #(nop)  CMD ["node"]                 0B                  
   <missing>           13 days ago         /bin/sh -c #(nop)  ENTRYPOINT ["docker-entry…   0B                  
   <missing>           13 days ago         /bin/sh -c #(nop) COPY file:238737301d473041…   116B                
   <missing>           13 days ago         /bin/sh -c apk add --no-cache --virtual .bui…   5.35MB              
   <missing>           13 days ago         /bin/sh -c #(nop)  ENV YARN_VERSION=1.21.1      0B                  
   <missing>           13 days ago         /bin/sh -c addgroup -g 1000 node     && addu…   74.3MB              
   <missing>           13 days ago         /bin/sh -c #(nop)  ENV NODE_VERSION=12.14.1     0B                  
   <missing>           13 days ago         /bin/sh -c #(nop)  CMD ["/bin/sh"]              0B                  
   <missing>           13 days ago         /bin/sh -c #(nop) ADD file:e69d441d729412d24…   5.59MB   
   ```

   Each of the lines represents a layer in the image. The display here shows the base at the bottom with the newest layer at the top. Using this, you can also quickly see the size of each layer, helping diagnose large images.

1. You'll notice that several of the lines are truncated. If you add the `--no-trunc` flag, you'll get the full output (yes, you use a truncated flag to get untruncated output).

   ```bash
   docker image history --no-trunc getting-started
   ```

## Layer caching

Now that you've seen the layering in action, there's an important lesson to learn to help decrease build times for your container images.

> Once a layer changes, all downstream layers have to be recreated as well

Let's look at the Dockerfile you were using one more time...

```dockerfile
FROM node:12-alpine
WORKDIR /app
COPY . .
RUN yarn install --production
CMD ["node", "/app/src/index.js"]
```

Going back to the image history output, you see that each command in the Dockerfile becomes a new layer in the image. You might remember that when you made a change to the image, the yarn dependencies had to be reinstalled. Is there a way to fix this? It doesn't make much sense to ship around the same dependencies every time you build, right?

To fix this, you can restructure your Dockerfile to help support the caching of the dependencies. For Node-based applications, those dependencies are defined in the `package.json` file. So, what if you copied only that file in first, install the dependencies, and *then* copy in everything else? Then, you only recreate the yarn dependencies if there was a change to the `package.json`. Make sense?

1. Update the Dockerfile to copy in the `package.json` first, install dependencies, and then copy everything else in.

   ```dockerfile hl_lines="3 4 5"
   FROM node:12-alpine
   WORKDIR /app
   COPY package.json yarn.lock ./
   RUN yarn install --production
   COPY . .
   CMD ["node", "/app/src/index.js"]
   ```

1. Build a new image using `docker build`.

   ```bash
   docker build -t getting-started .
   ```

   You should see output like this...

   ```plaintext
   Sending build context to Docker daemon  219.1kB
   Step 1/6 : FROM node:12-alpine
   ---> b0dc3a5e5e9e
   Step 2/6 : WORKDIR /app
   ---> Using cache
   ---> 9577ae713121
   Step 3/6 : COPY package* yarn.lock ./
   ---> bd5306f49fc8
   Step 4/6 : RUN yarn install --production
   ---> Running in d53a06c9e4c2
   yarn install v1.17.3
   [1/4] Resolving packages...
   [2/4] Fetching packages...
   info fsevents@1.2.9: The platform "linux" is incompatible with this module.
   info "fsevents@1.2.9" is an optional dependency and failed compatibility check. Excluding it from installation.
   [3/4] Linking dependencies...
   [4/4] Building fresh packages...
   Done in 10.89s.
   Removing intermediate container d53a06c9e4c2
   ---> 4e68fbc2d704
   Step 5/6 : COPY . .
   ---> a239a11f68d8
   Step 6/6 : CMD ["node", "/app/src/index.js"]
   ---> Running in 49999f68df8f
   Removing intermediate container 49999f68df8f
   ---> e709c03bc597
   Successfully built e709c03bc597
   Successfully tagged getting-started:latest
   ```

   You'll see that all layers were rebuilt. Perfectly fine, since you changed the Dockerfile quite a bit.

1. Now, make a change to the `src/static/index.html` file (like change the `<title>` to say "The Awesome Todo App").

1. Build the Docker image now using `docker build` again. This time, your output should look a little different.

   ```plaintext hl_lines="5 8 11"
   Sending build context to Docker daemon  219.1kB
   Step 1/6 : FROM node:12-alpine
   ---> b0dc3a5e5e9e
   Step 2/6 : WORKDIR /app
   ---> Using cache
   ---> 9577ae713121
   Step 3/6 : COPY package* yarn.lock ./
   ---> Using cache
   ---> bd5306f49fc8
   Step 4/6 : RUN yarn install --production
   ---> Using cache
   ---> 4e68fbc2d704
   Step 5/6 : COPY . .
   ---> cccde25a3d9a
   Step 6/6 : CMD ["node", "/app/src/index.js"]
   ---> Running in 2be75662c150
   Removing intermediate container 2be75662c150
   ---> 458e5c6f080c
   Successfully built 458e5c6f080c
   Successfully tagged getting-started:latest
   ```

   First off, you should notice that the build was MUCH faster! And, you'll see that steps 1-4 all have `Using cache`.
   So, hooray! You're using the build cache.
   Pushing and pulling this image and updates to it will be much faster as well. Hooray!

## Multi-stage builds

While we're not going to dive into it too much in this tutorial, multi-stage builds are an incredibly powerful
tool to help use multiple stages to create an image. There are several advantages for them:

- Separate build-time dependencies from runtime dependencies
- Reduce overall image size by shipping *only* what your app needs to run

### Maven/Tomcat example

When building Java-based applications, a JDK is needed to compile the source code to Java bytecode. However,
that JDK isn't needed in production. Also, you might be using tools like Maven or Gradle to help build the app.
Those also aren't needed in your final image. Multi-stage builds help.

```dockerfile
FROM maven AS build
WORKDIR /app
COPY . .
RUN mvn package

FROM tomcat
COPY --from=build /app/target/file.war /usr/local/tomcat/webapps 
```

This example uses one stage (called `build`) to perform the actual Java build using Maven. The second stage (starting at `FROM tomcat`) copies in files from the `build` stage. The final image is only the last stage being created (which can be overridden using the `--target` flag).

### React example

When building React applications, you need a Node environment to compile the JS code (typically JSX), SASS stylesheets, and more into static HTML, JS, and CSS. If you aren't doing server-side rendering, you don't even need a Node environment for the production build. Why not ship the static resources in a static nginx container?

```dockerfile
FROM node:12 AS build
WORKDIR /app
COPY package* yarn.lock ./
RUN yarn install
COPY public ./public
COPY src ./src
RUN yarn run build

FROM nginx:alpine
COPY --from=build /app/build /usr/share/nginx/html
```

Here, you're using a `node:12` image to perform the build (maximizing layer caching) and then copying the output into an nginx container. Cool, huh?


## Clean up resources

Keep everything that you've done so far to continue this series of tutorials.

If you're not going to continue to use this application, delete
<resources> with the following steps:

1. From the left-hand menu...
1. ...click Delete, type...and then click Delete

## Next steps

Next, try the next tutorial in this series:

> [!div class="nextstepaction"]
> [Deploy your Docker app to the Azure cloud](tutorial-deploy-docker-app-azure.md)
