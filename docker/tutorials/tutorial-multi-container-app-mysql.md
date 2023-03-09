---
title: "Create multi-container apps with MySQL & Docker Compose"
description: In this tutorial, learn how to create multi-container apps with MySQL and Docker Compose. Use multiple containers to scale your project.
author: ghogen
ms.author: ghogen
ms.prod: vs-code
ms.topic: tutorial
ms.date: 03/04/2022
ms.custom: template-tutorial, contperf-fy22q3

# Under contractual obligation with Docker Inc. to provide this content. Contact is: nebuk89. Mike Morton has context on MSFT side, but has moved on to another role. 
---

# Tutorial: Create multi-container apps with MySQL and Docker Compose

In this tutorial, you'll learn how to create multi-container apps. This tutorial builds on the getting started tutorials, [Create and share a Docker app with Visual Studio Code](docker-tutorial.md).  In this advanced tutorial, you'll update your application to work as described in this diagram and learn how to:
> [!div class="checklist"]
> - Start MySQL.
> - Run your app with MySQL.
> - Create the compose file.
> - Run the application stack.

![Diagram shows two containers labeled Todo App and MySQL connected with a line.](media/multi-app-architecture.png)

Using multiple containers allows you to dedicate containers for specialized tasks.  Each container should do one thing and do it well.

Here are some reasons you might want to use multi-container apps:
- Separate containers you to manage APIs and front-ends differently than databases.
- Containers let you version and update versions in isolation.
- While you might use a container for the database locally, you may want to use a managed service for the database in production.
- Running multiple processes requires a process manager, which adds complexity to container startup/shutdown.




## Prerequisites

This tutorial continues the series of tutorials, starting with [Create and share a Docker app with Visual Studio Code](docker-tutorial.md).
Start with that one, which includes prerequisites.
Then do these tutorials:

- [Persist data and layer Docker app](tutorial-persist-data-layer-docker-app-with-vscode.md).
- [Deploy your Docker app to the Azure cloud](tutorial-deploy-docker-app-azure.md).

You also need the following items:

- [Docker Compose](https://docs.docker.com/compose/).

  Docker Desktop for Windows or Mac includes Docker Compose.
  Run this command to verify:

  ```bash
  docker-compose version
  ```

  If you use the Linux operating system, [Install Docker Compose](https://docs.docker.com/compose/install/).

As with the previous tutorials, you can accomplish most tasks from the VS Code **EXPLORER** view or the **DOCKER** view.
You can select **Terminal** > **New Terminal** to open a command-line window in VS Code.
You can also run commands in a Bash window.
Unless specified, any command labeled as **Bash** can run in a Bash window or the VS Code terminal.

## Start MySQL

Containers, by default, run in isolation.
They don't know anything about other processes or containers on the same computer.
To allow one container to talk to another, use networking.

If two containers are on the same network, they can talk to each other.
If they aren't, they can't.

There are two ways to put a container on a network: assign it at start or connect an existing container.
In this example, you create the network first and attach the MySQL container at startup.

1. Create the network by using this command.

   ```bash
   docker network create todo-app
   ```

1. Start a MySQL container and attach it the network.

    ```bash
    docker run -d 
        --network todo-app --network-alias mysql 
        -v todo-mysql-data:/var/lib/mysql 
        -e MYSQL_ROOT_PASSWORD=<your-password> 
        -e MYSQL_DATABASE=todos 
        mysql:5.7
    ```

   This command also defines environment variables.
   For more information, see [MySQL Docker Hub listing](https://hub.docker.com/_/mysql/).

   The command specifies a network alias, `mysql`.

1. Get your container ID by using the `docker ps` command.

1. To confirm you have the database up and running, connect to the database.

   ```bash
   docker exec -it <mysql-container-id> mysql -p
   ```

   Enter the password you used, above, when prompted.

1. In the MySQL shell, list the databases and verify you see the `todos` database.

   ```sql
   SHOW DATABASES;
   ```

   You should see the following output.

   ```output
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

## Run your app with MySQL

The todo app supports the setting of environment variables to specify MySQL connection settings.

- `MYSQL_HOST` The hostname for the MySQL server.
- `MYSQL_USER` The username to use for the connection.
- `MYSQL_PASSWORD` The password to use for the connection.
- `MYSQL_DB` The database to use once connected.

> [!WARNING]
> Using environment variables to set connection settings is acceptable for development.
> We recommend against this practice for running applications in production.
> For more information, see [Why you shouldn't use environment variables for secret data](https://diogomonica.com/2017/03/27/why-you-shouldnt-use-env-variables-for-secret-data/).
>
> A more secure mechanism is to use the secret support provided by your container orchestration framework.
> In most cases, these secrets are mounted as files in the running container.
>

This procedure starts your app and connects that container to your MySQL container.

1. Use the following docker run command.
   It specifies the environment variables above.

    ```bash
    docker run -dp 3000:3000 
      -w /app -v ${PWD}:/app 
      --network todo-app 
      -e MYSQL_HOST=mysql 
      -e MYSQL_USER=root 
      -e MYSQL_PASSWORD=<your-password> 
      -e MYSQL_DB=todos 
      node:12-alpine 
      sh -c "yarn install && yarn run dev"
    ```

1. In VS Code, in the Docker view, right-click the app container and select **View Logs**.
   To view the logs from the command line, use the `docker logs` command.

   The result includes a line that indicates that the app is connected to the MySQL database.

   ```output
   # Previous log messages omitted
   $ nodemon src/index.js
   [nodemon] 1.19.2
   [nodemon] to restart at any time, enter `rs`
   [nodemon] watching dir(s): *.*
   [nodemon] starting `node src/index.js`
   Connected to mysql db at host mysql
   Listening on port 3000
   ```

1. Enter `http://localhost:3000` into your browser.
   Add some items to your todo list.

1. Connect to the MySQL database, as you did in the previous section.
   Run this command to verify that the items are being written to the database.

   ```bash
   docker exec -ti <mysql-container-id> mysql -p todos
   ```

   And in the MySQL shell, run the following command.

   ```sql
   select * from todo_items;
   ```

   Your result will look like the following output.

   ```output
   +--------------------------------------+--------------------+-----------+
   | id                                   | name               | completed |
   +--------------------------------------+--------------------+-----------+
   | c906ff08-60e6-44e6-8f49-ed56a0853e85 | Do amazing things! |         0 |
   | 2912a79e-8486-4bc3-a4c5-460793a575ab | Be awesome!        |         0 |
   +--------------------------------------+--------------------+-----------+
   ```

At this point, you have an application that stores data in an external database.
That database runs in a separate container.
You learned about container networking.

## Create a Docker Compose file

Docker Compose helps define and share multi-container applications.
With Docker Compose, you can create a file to define the services.
With a single command, you can spin up everything or tear it all down.

You can define your application stack in a file and keep that file at the root of your project repo, under version control.
This approach enables others to contribute to your project.
They would only need to clone your repo.

1. At the root of the app project, create a file named `docker-compose.yml`.

1. In the compose file, start by defining the schema version.

   ```yaml
   version: "3.7"
   ```

   In most cases, it's best to use the latest supported version.
   For current schema versions and compatibility matrix, see [Compose file](https://docs.docker.com/compose/compose-file/).

1. Define the services, or containers, you want to run as part of your application.

    ```yaml hl_lines="3"
    version: "3.7"

    services:
    ```

   > [!TIP]
   > Indentation is significant in *.yml* files.
   > If you're editing in VS Code, Intellisense indicates errors.

1. Here's the command you used to your app container.
   You'll add this information to your *.yml* file.

   ```bash
   docker run -dp 3000:3000 
     -w /app -v ${PWD}:/app 
     --network todo-app 
     -e MYSQL_HOST=mysql 
     -e MYSQL_USER=root 
     -e MYSQL_PASSWORD=<your-password> 
     -e MYSQL_DB=todos 
     node:12-alpine 
     sh -c "yarn install && yarn run dev"
   ```

   Define the service entry and the image for the container.

   ```yaml
   version: "3.7"

   services:
     app:
       image: node:12-alpine
   ```

   You can pick any name for the service.
   The name automatically becomes a network alias, which is useful when defining the MySQL service.

1. Add the command.

    ```yaml
    version: "3.7"

    services:
      app:
        image: node:12-alpine
        command: sh -c "yarn install && yarn run dev"
    ```

1. Specify the ports for the service, which correspond to `-p 3000:3000` in the command above.

    ```yaml
    version: "3.7"

    services:
      app:
        image: node:12-alpine
        command: sh -c "yarn install && yarn run dev"
        ports:
          - 3000:3000
    ```

1. Specify the working directory and the volume mapping

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
    ```

   In Docker Compose volume definitions, you can use relative paths from the current directory.

1. Specify the environment variable definitions.

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
          MYSQL_PASSWORD: <your-password>
          MYSQL_DB: todos
    ```

1. Add the definitions for the MySQL service.
   Here's the command you used above:

   ```bash
   docker run -d 
     --network todo-app --network-alias mysql 
     -v todo-mysql-data:/var/lib/mysql 
     -e MYSQL_ROOT_PASSWORD=<your-password> 
     -e MYSQL_DATABASE=todos 
     mysql:5.7
   ```

   Define the new service and name it *mysql*.
   Add your text after the `app` definition, at the same level of indentation.

    ```yaml hl_lines="6 7"
    version: "3.7"

    services:
      app:
        # The app service definition
      mysql:
        image: mysql:5.7
    ```

   The service automatically gets the network alias.
   Specify the image to use.

1. Define the volume mapping.

   Specify the volume with a `volumes:` section at the same level as `services:`.
   Specify the volume mapping under the image.

    ```yaml
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

1. Specify the environment variables.

    ```yaml
    version: "3.7"

    services:
      app:
        # The app service definition
      mysql:
        image: mysql:5.7
        volumes:
          - todo-mysql-data:/var/lib/mysql
        environment: 
          MYSQL_ROOT_PASSWORD: <your-password>
          MYSQL_DATABASE: todos
    
    volumes:
      todo-mysql-data:
    ```

At this point, the complete `docker-compose.yml` looks like this:

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
      MYSQL_PASSWORD: <your-password>
      MYSQL_DB: todos

  mysql:
    image: mysql:5.7
    volumes:
      - todo-mysql-data:/var/lib/mysql
    environment: 
      MYSQL_ROOT_PASSWORD: <your-password>
      MYSQL_DATABASE: todos

volumes:
  todo-mysql-data:
```

## Run the application stack

Now that you have the `docker-compose.yml` file, try it.

1. Make sure no other copies of the app and database are running.
   In the Docker extension, right-click any running container and select **Remove**.
   Or, at the command line, use the command `docker rm` as in previous examples.

1. In the VS Code Explorer, right-click *docker-compose.yml* and select **Compose Up**.
   Or, at the command line, use this docker command.

   ```bash
   docker-compose up -d
   ```

   The `-d` parameter makes the command run in the background.

   You should see output like the following results.

   ```output
   Creating network "app_default" with the default driver
   Creating volume "app_todo-mysql-data" with default driver
   Creating app_app_1   ... done
   Creating app_mysql_1 ... done
   ```

   The volume was created as well as a network.
   By default, Docker Compose creates a network specifically for the application stack.

1. In the Docker extension, right-click the app container and select **View Logs**.
   To view the logs from the command line, use the `docker logs` command.

   ```output
   mysql_1  | 2019-10-03T03:07:16.083639Z 0 [Note] mysqld: ready for connections.
   mysql_1  | Version: '5.7.27'  socket: '/var/run/mysqld/mysqld.sock'  port: 3306  MySQL Community Server (GPL)
   app_1    | Connected to mysql db at host mysql
   app_1    | Listening on port 3000
   ```

   The logs from each of the services are interleaved into a single stream.
   With this behavior, you can watch for timing-related issues.

   The service name is displayed at the beginning of the line to help distinguish messages.
   To view logs for a specific service, add the service name to the end of the logs command.

1. At this point, you should be able to open your app.
   Enter `http://localhost:3000` into your browser.

When you're done with these containers, you can remove them all simply.

- In VS Code Explorer, right-click **docker-compose.yml** and select **Compose Down**.
- At the command line, run `docker-compose down`.

The containers stop.
The network is removed.

By default, named volumes in your compose file aren't removed.
If you want to remove the volumes, run `docker-compose down --volumes`.

## Clean up resources

The prerequisites you used in this tutorial series can be used for future Docker development.
There's no reason to delete or uninstall anything.

## Next steps

In this tutorial, you learned about multi-container apps and Docker Compose.
Docker Compose helps dramatically simplify the defining and sharing of multi-service applications.

Here are some resources that might be useful to you:

- [Docker Cloud Integration](https://github.com/docker/compose-cli)
- [Examples](https://github.com/docker/awesome-compose)
