---
title: "Tutorial: Multi-container apps with MySQL & Docker Compose"
description: Learn how to create multi-container apps with MySQL & Docker Compose.
author: ucheNkadiCode
ms.author: uchen
ms.prod: vs-code
ms.topic: tutorial
ms.date: 02/15/2022
ms.custom: template-tutorial

# Under contractual obligation with Docker Inc. to provide this content. Contact is: nebuk89. Mike Morton has context on MSFT side, but has moved on to another role. 
---

# Tutorial: Create multi-container apps with MySQL & Docker Compose

Up to this point, you've been working with single-container apps. But, you'll now add MySQL to the application stack. The following question often arises - "Where will MySQL run? Install it in the same container or run it separately?" In general, **each container should do one thing and do it well.** A few reasons:

- There's a good chance you'd have to scale APIs and front-ends differently than databases
- Separate containers let you version and update versions in isolation
- While you may use a container for the database locally, you may want to use a managed service for the database in production. You don't want to ship your database engine with your app then.
- Running multiple processes will require a process manager (the container only starts one process), which adds complexity to container startup/shutdown.

And there are more reasons. So, you will update your application to work like this:

![Todo App connected to MySQL container](media/multi-app-architecture.png)

In this tutorial, you learn how to:

> [!div class="checklist"]
> - Start MySQL
> - Connect to MySQL
> - Run your app with MySQL
> - Install Docker Compose
> - Create the compose file
> - Define the App Service
> - Run the application stack
> - See the app stack in the Docker extension
> - Tear it all down

## Prerequisites

This tutorial continues set of tutorials, starting with [Create and share a Docker app with Visual Studio Code](tutorial-docker-apps-with-vscode.md).
Start with that one, which includes prerequisites.
Then do this tutorial: [Persist data and layer Docker app](tutorial-persist-data-layer-docker-app-with-vscode.md).

## Start MySQL

Remember that containers, by default, run in isolation and don't know anything about other processes or containers on the same machine. So, how do you allow one container to talk to another? The answer is **networking**. Now, you don't have to be a network engineer (hooray!). Simply remember this rule...

> [!NOTE]
> If two containers are on the same network, they can talk to each other. If they aren't, they can't.


There are two ways to put a container on a network: assign it at start or connect an existing container. For now, you will create the network first and attach the MySQL container at startup.

1. Create the network.

    ```bash
    docker network create todo-app
    ```

1. Start a MySQL container and attach it the network. We're also going to define a few environment variables that the database will use to initialize the database (see the "Environment Variables" section in the [MySQL Docker Hub listing](https://hub.docker.com/_/mysql/)) (replace the ` \ ` characters with `` ` `` in Windows PowerShell).

    ```bash
    docker run -d \
        --network todo-app --network-alias mysql \
        -v todo-mysql-data:/var/lib/mysql \
        -e MYSQL_ROOT_PASSWORD=secret \
        -e MYSQL_DATABASE=todos \
        mysql:5.7
    ```

    You'll also see you specified the `--network-alias` flag. We'll come back to that in just a moment.

    > [!TIP]
    > You'll notice you're using a volume name `todo-mysql-data` here and mounting it at `/var/lib/mysql`, which is where MySQL stores its data. However, you never ran a `docker volume create` command. Docker recognizes that you want to use a named volume and creates one automatically for you.

1. To confirm you have the database up and running, connect to the database and verify it connects.

    ```bash
    docker exec -it <mysql-container-id> mysql -p
    ```

    When the password prompt comes up, type in **secret**. In the MySQL shell, list the databases and verify
    you see the `todos` database.

    ```cli
    mysql> SHOW DATABASES;
    ```

    You should see output that looks like this:

    ```plaintext
    +--------------------+
    | Database           |
    +--------------------+
    | information_schema |
    | mysql              |
    | performance_schema |
    | sys                |
    | todos              |
    +--------------------+
    5 rows in set (0.00 sec)
    ```

    Hooray! You have your `todos` database and it's ready for use!

## Connect to MySQL

Now that you know MySQL is up and running, let's use it! But, the question is... how? If you run another container on the same network, how do you find the container (remember each container has its own IP address)?

To figure it out, you're going to make use of the [nicolaka/netshoot](https://github.com/nicolaka/netshoot) container, which ships with a *lot* of tools that are useful for troubleshooting or debugging networking issues.

1. Start a new container using the `nicolaka/netshoot` image. Make sure to connect it to the same network.

    ```bash
    docker run -it --network todo-app nicolaka/netshoot
    ```

1. Inside the container, use the `dig` command, which is a useful DNS tool. Look up the IP address for the hostname `mysql`.

    ```bash
    dig mysql
    ```

    And you'll get an output like this...

    ```text
    ; <<>> DiG 9.14.1 <<>> mysql
    ;; global options: +cmd
    ;; Got answer:
    ;; ->>HEADER<<- opcode: QUERY, status: NOERROR, id: 32162
    ;; flags: qr rd ra; QUERY: 1, ANSWER: 1, AUTHORITY: 0, ADDITIONAL: 0

    ;; QUESTION SECTION:
    ;mysql.				IN	A

    ;; ANSWER SECTION:
    mysql.			600	IN	A	172.23.0.2

    ;; Query time: 0 msec
    ;; SERVER: 127.0.0.11#53(127.0.0.11)
    ;; WHEN: Tue Oct 01 23:47:24 UTC 2019
    ;; MSG SIZE  rcvd: 44
    ```

    In the "ANSWER SECTION," you will see an `A` record for `mysql` that resolves to `172.23.0.2` (your IP address will most likely have a different value). While `mysql` isn't normally a valid hostname, Docker was able to resolve it to the IP address of the container that had that network alias (remember the `--network-alias` flag you used earlier?).

    What this means is... your app only simply needs to connect to a host named `mysql` and it'll talk to the database! It doesn't get much simpler than that!

## Run your app with MySQL

The todo app supports the setting of a few environment variables to specify MySQL connection settings. They are:

- `MYSQL_HOST` - the hostname for the running MySQL server
- `MYSQL_USER` - the username to use for the connection
- `MYSQL_PASSWORD` - the password to use for the connection
- `MYSQL_DB` - the database to use once connected

> [!WARNING]
> **Setting Connection Settings via Environment Variables** While using environment variables to set connection settings is generally okay for development, it is highly discouraged when running applications in production. To understand why, see [Why you shouldn't use environment variables for secret data](https://diogomonica.com/2017/03/27/why-you-shouldnt-use-env-variables-for-secret-data/).
> A more secure mechanism is to use the secret support provided by your container orchestration framework. In most cases, these secrets are mounted as files in the running container. You'll see many apps (including the MySQL image and the todo app) also support env vars with a `_FILE` suffix to point to a file containing the file.
> As an example, setting the `MYSQL_PASSWORD_FILE` var will cause the app to use the contents of the referenced file as the connection password. Docker doesn't do anything to support these env vars. Your app will need to know to look for the variable and get the file contents.

With all of that explained, start your dev-ready container!

1. Specify each of the environment variables above, and connect the container to your app network (replace the ` \ ` characters with `` ` `` in Windows PowerShell).

    ```bash hl_lines="3 4 5 6 7"
    docker run -dp 3000:3000 \
      -w /app -v ${PWD}:/app \
      --network todo-app \
      -e MYSQL_HOST=mysql \
      -e MYSQL_USER=root \
      -e MYSQL_PASSWORD=secret \
      -e MYSQL_DB=todos \
      node:12-alpine \
      sh -c "yarn install && yarn run dev"
    ```

1. If you look at the logs for the container (`docker logs <container-id>`), you should see a message indicating it's using the MySQL database.

    ```plaintext hl_lines="7"
    # Previous log messages omitted
    $ nodemon src/index.js
    [nodemon] 1.19.2
    [nodemon] to restart at any time, enter `rs`
    [nodemon] watching dir(s): *.*
    [nodemon] starting `node src/index.js`
    Connected to mysql db at host mysql
    Listening on port 3000
    ```

1. Open the app in your browser and add a few items to your todo list.

1. Connect to the MySQL database and prove that the items are being written to the database. Remember, the password is **secret**.

    ```bash
    docker exec -ti <mysql-container-id> mysql -p todos
    ```

    And in the MySQL shell, run the following:

    ```plaintext
    mysql> select * from todo_items;
    +--------------------------------------+--------------------+-----------+
    | id                                   | name               | completed |
    +--------------------------------------+--------------------+-----------+
    | c906ff08-60e6-44e6-8f49-ed56a0853e85 | Do amazing things! |         0 |
    | 2912a79e-8486-4bc3-a4c5-460793a575ab | Be awesome!        |         0 |
    +--------------------------------------+--------------------+-----------+
    ```

    Obviously, your table will look different because it has your items. But, you should see them stored there!

If you take a quick look at the Docker extension, you'll see that you have two app containers running. But, there's no real indication that they're grouped together in a single app. You'll see how to make that better shortly!

![Docker Extension showing two ungrouped app containers](media/vs-multi-container-app.png)


At this point, you have an application that now stores its data in an external database running in a separate container. You learned a little bit about container networking and saw how service discovery can be performed using DNS.

But, there's a good chance you are starting to feel a little overwhelmed with everything you need to do to start up this application. You have to create a network, start containers, specify all of the environment variables, expose ports, and more! That's a lot to remember and it's certainly making things harder to pass along to someone else.

In the next section, we'll talk about Docker Compose. With Docker Compose, you can share your application stacks in a much easier way and let others spin them up with a single (and simple) command!

## Install Docker Compose

[Docker Compose](https://docs.docker.com/compose/) is a tool that was developed to help define and share multi-container applications. With Compose, you can create a YAML file to define the services and with a single command, can spin everything up or tear it all down.

The *big* advantage of using Compose is you can define your application stack in a file, keep it at the root of your project repo (it's now version controlled), and easily enable someone else to contribute to your project. Someone would only need to clone your repo and start the compose app. In fact, you might see quite a few projects on GitHub/GitLab doing exactly this now.

So, how do you get started?

If you installed Docker Desktop for either Windows or Mac, you already have Docker Compose! Play-with-Docker instances already have Docker Compose installed as well. If you are on a Linux machine, you will need to install Docker Compose using [the instructions here](https://docs.docker.com/compose/install/).

After installation, you should be able to run the following and see version information.

```bash
docker-compose version
```

## Create the compose file

1. At the root of the app project, create a file named `docker-compose.yml`.

1. In the compose file, we'll start off by defining the schema version. In most cases, it's best to use the latest supported version. You can look at the [Compose file reference](https://docs.docker.com/compose/compose-file/) for the current schema versions and the compatibility matrix.

    ```yaml
    version: "3.7"
    ```

1. Next, define the list of services (or containers) you want to run as part of your application.

    ```yaml hl_lines="3"
    version: "3.7"

    services:
    ```

And now, you'll start migrating a service at a time into the compose file.

## Define the App Service

To remember, this was the command you used to define your app container (replace the ` \ ` characters with `` ` `` in Windows PowerShell).

```bash
docker run -dp 3000:3000 \
  -w /app -v ${PWD}:/app \
  --network todo-app \
  -e MYSQL_HOST=mysql \
  -e MYSQL_USER=root \
  -e MYSQL_PASSWORD=secret \
  -e MYSQL_DB=todos \
  node:12-alpine \
  sh -c "yarn install && yarn run dev"
```

1. First, define the service entry and the image for the container. You can pick any name for the service. The name will automatically become a network alias, which will be useful when defining the MySQL service.

    ```yaml hl_lines="4 5"
    version: "3.7"

    services:
      app:
        image: node:12-alpine
    ```

1. Typically, you'll see the command close to the `image` definition, although there is no requirement on ordering. So, go ahead and move that into the file.

    ```yaml hl_lines="6"
    version: "3.7"

    services:
      app:
        image: node:12-alpine
        command: sh -c "yarn install && yarn run dev"
    ```

1. Migrate the `-p 3000:3000` part of the command by defining the `ports` for the service. You'll use the [short syntax](https://docs.docker.com/compose/compose-file/#short-syntax-1) here, but there is also a more verbose [long syntax](https://docs.docker.com/compose/compose-file/#long-syntax-1) available as well.

    ```yaml hl_lines="7 8"
    version: "3.7"

    services:
      app:
        image: node:12-alpine
        command: sh -c "yarn install && yarn run dev"
        ports:
          - 3000:3000
    ```

1. Next, migrate both the working directory (`-w /app`) and the volume mapping (`-v ${PWD}:/app`) by using the `working_dir` and `volumes` definitions. Volumes also has a [short](https://docs.docker.com/compose/compose-file/#short-syntax-3) and [long](https://docs.docker.com/compose/compose-file/#long-syntax-3) syntax.

   One advantage of Docker Compose volume definitions is you can use relative paths from the current directory.

    ```yaml hl_lines="9 10 11"
    version: "3.7"

    services:
      app:
        image: node:12-alpine
        command: sh -c "yarn install && yarn run dev"
        ports:
          - 3000:3000
        working_dir: /app
        volumes:
          - ./:/app
    ```

1. Finally, migrate the environment variable definitions using the `environment` key.

    ```yaml hl_lines="12 13 14 15 16"
    version: "3.7"

    services:
      app:
        image: node:12-alpine
        command: sh -c "yarn install && yarn run dev"
        ports:
          - 3000:3000
        working_dir: /app
        volumes:
          - ./:/app
        environment:
          MYSQL_HOST: mysql
          MYSQL_USER: root
          MYSQL_PASSWORD: secret
          MYSQL_DB: todos
    ```

### Define the MySQL service

Now, it's time to define the MySQL service. The command that you used for that container was the following (replace the ` \ ` characters with `` ` `` in Windows PowerShell):

```bash
docker run -d \
  --network todo-app --network-alias mysql \
  -v todo-mysql-data:/var/lib/mysql \
  -e MYSQL_ROOT_PASSWORD=secret \
  -e MYSQL_DATABASE=todos \
  mysql:5.7
```

1. First, define the new service and name it `mysql` so it automatically gets the network alias. Specify the image to use as well.

    ```yaml hl_lines="6 7"
    version: "3.7"

    services:
      app:
        # The app service definition
      mysql:
        image: mysql:5.7
    ```

1. Next, define the volume mapping. When you ran the container with `docker run`, the named volume was created automatically. However, that doesn't happen when running with Compose. You need to define the volume in the top-level `volumes:` section and then specify the mountpoint in the service config. By simply providing only the volume name, the default options are used. There are [many more options available](https://github.com/compose-spec/compose-spec/blob/master/spec.md#volumes-top-level-element) though.

    ```yaml hl_lines="8 9 10 11 12"
    version: "3.7"

    services:
      app:
        # The app service definition
      mysql:
        image: mysql:5.7
        volumes:
          - todo-mysql-data:/var/lib/mysql
    
    volumes:
      todo-mysql-data:
    ```

1. Finally, you only need to specify the environment variables.

    ```yaml hl_lines="10 11 12"
    version: "3.7"

    services:
      app:
        # The app service definition
      mysql:
        image: mysql:5.7
        volumes:
          - todo-mysql-data:/var/lib/mysql
        environment: 
          MYSQL_ROOT_PASSWORD: secret
          MYSQL_DATABASE: todos
    
    volumes:
      todo-mysql-data:
    ```

At this point, the complete `docker-compose.yml` should look like this:

```yaml
version: "3.7"

services:
  app:
    image: node:12-alpine
    command: sh -c "yarn install && yarn run dev"
    ports:
      - 3000:3000
    working_dir: /app
    volumes:
      - ./:/app
    environment:
      MYSQL_HOST: mysql
      MYSQL_USER: root
      MYSQL_PASSWORD: secret
      MYSQL_DB: todos

  mysql:
    image: mysql:5.7
    volumes:
      - todo-mysql-data:/var/lib/mysql
    environment: 
      MYSQL_ROOT_PASSWORD: secret
      MYSQL_DATABASE: todos

volumes:
  todo-mysql-data:
```

## Run the application stack

Now that you have the `docker-compose.yml` file, you can start it up!

1. First, make sure no other copies of the app and database are running (`docker ps` and `docker rm -f <ids>`).

1. Start up the application stack using the `docker-compose up` command. Add the `-d` flag to run everything in the background. Alternatively, you can right-click on your Compose file and select the **Compose Up** option for the VS Code side bar. 

    ```bash
    docker-compose up -d
    ```

    When you run this, you should see output like this:

    ```plaintext
    Creating network "app_default" with the default driver
    Creating volume "app_todo-mysql-data" with default driver
    Creating app_app_1   ... done
    Creating app_mysql_1 ... done
    ```

    You'll notice that the volume was created as well as a network! By default, Docker Compose automatically creates a network specifically for the application stack (which is why you didn't define one in the compose file).

1. Look at the logs using the `docker-compose logs -f` command. You'll see the logs from each of the services interleaved into a single stream. This is incredibly useful when you want to watch for timing-related issues. The `-f` flag "follows" the log, so will give you live output as it's generated.

    If you don't already, you'll see output that looks like this:

    ```plaintext
    mysql_1  | 2019-10-03T03:07:16.083639Z 0 [Note] mysqld: ready for connections.
    mysql_1  | Version: '5.7.27'  socket: '/var/run/mysqld/mysqld.sock'  port: 3306  MySQL Community Server (GPL)
    app_1    | Connected to mysql db at host mysql
    app_1    | Listening on port 3000
    ```

    The service name is displayed at the beginning of the line (often colored) to help distinguish messages. If you want to view the logs for a specific service, you can add the service name to the end of the logs command (for example, `docker-compose logs -f app`).

    > [!TIP]
    > **Waiting for the DB before starting the app**
    > When the app is starting up, it actually sits and waits for MySQL to be up and ready before trying to connect to it.Docker doesn't have any built-in support to wait for another container to be fully up, running, and ready before starting another container. For Node-based projects, you can use the [wait-port](https://github.com/dwmkerr/wait-port) dependency. Similar projects exist for other languages/frameworks.

1. At this point, you should be able to open your app and see it running. And hey! You're down to a single command!

## See the app stack in the Docker extension

If you look at the Docker extension, you can change the grouping options using the 'cog' and 'group by'. In this instance, you want to see containers grouped by Compose Project name:

![VS Extension with Compose](media/vs-app-project-collapsed.png)

If you twirl down the network, you will see the two containers you defined in the compose file.

![VS Extension with Compose expanded](media/vs-app-project-expanded.png)

## Tear it all down

When you're ready to tear it all down, simply run `docker-compose down`, or right-click on the application in the containers list in the VS Code Docker extension and select **Compose Down**. The containers will stop and the network will be removed.

> [!WARNING]
> **Removing Volumes**
> By default, named volumes in your compose file are NOT removed when running `docker-compose down`. If you want to remove the volumes, you will need to add the `--volumes` flag.

Once torn down, you can switch to another project, run `docker-compose up` and be ready to contribute to that project! It really doesn't get much simpler than that!



In this section, you learned about Docker Compose and how it helps dramatically simplify the defining and sharing of multi-service applications. You created a Compose file by translating the commands you were using into the appropriate compose format.

At this point, you're starting to wrap up the tutorial. However, there are a few best practices about image building to cover, as there is a big issue with the Dockerfile you've been using. So, let's take a look!


## Clean up resources

If you're not going to continue to use this application, delete
<resources> with the following steps:

1. From the left-hand menu...
1. ...click Delete, type...and then click Delete

<!-- 7. Next steps
Required: A single link in the blue box format. Point to the next logical tutorial 
in a series, or, if there are no other tutorials, to some other cool thing the 
customer can do. 
-->

## Next steps

Advance to the next article to learn how to create...
> [!div class="nextstepaction"]
> [Next steps button](contribute-how-to-mvc-tutorial.md)

<!--
Remove all the comments in this template before you sign-off or merge to the 
main branch.
-->