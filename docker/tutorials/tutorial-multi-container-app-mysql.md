---
title: Build multi-container apps (MySQL, Docker Compose)
description: Complete a tutorial to create multi-container applications with MySQL and Docker Compose and use the containers to scale your project in Visual Studio.
author: ghogen
ms.author: ghogen
ms.service: vs-code
ms.topic: tutorial
ms.date: 08/29/2024
# Under agreement with Docker Inc. to provide this content. Contact is: nebuk89. Mike Morton has context on MSFT side, but has moved on to another role. 

#customer intent: As a developer, I want to create multi-container applications with MySQL and Docker Compose, so I can use the containers to scale my project in Visual Studio.
---

# Tutorial: Create multi-container apps with MySQL and Docker Compose

This article describes how to create multi-container apps with [MySQL](https://dev.mysql.com/) and [Docker Compose](https://docs.docker.com/compose/). An app with multiple containers allows you to dedicate containers for specialized tasks, so each container can focus on a single task. There are many advantages to using multi-container apps:

- Separate containers allow you to manage APIs and front-end resources differently than databases.
- Multiple containers let you version and update versions in isolation.
- Local databases can be maintained in containers and managed services used for databases in production.
- Multi-container apps are more efficient than running multiple processes with a process manager, which adds complexity to container startup/shutdown.

In this tutorial, you:

> [!div class="checklist"]
> - Start MySQL
> - Run your multi-container app with MySQL
> - Create a Docker Compose file for your app
> - Run the application stack with Docker Compose

## Prerequisites

- This article is part of a tutorial series. The procedures build on an established example that requires [Docker Desktop](https://docs.docker.com/desktop/) for Linux containers.

   The recommended approach is to complete the first tutorial, [Create a container app](docker-tutorial.md), including satisfying the prerequisites, and also the tutorial, [Persist data in your app](tutorial-persist-data-layer-docker-app-with-vscode.md). After you work through these tutorials, continue with the procedures described in this article.

- The example in this article uses [Docker Compose](https://docs.docker.com/compose/).

   # [Windows](#tab/windows)

   Docker Desktop for Windows includes Docker Compose.

   Run the following command to verify your Docker installation:

   ```bash
   docker-compose version
   ```

   # [Linux](#tab/linux)

   For Linux, follow the instructions to [install Docker Compose](https://docs.docker.com/compose/install/).

   ---

### Visual Studio Code

This tutorial series describes procedures for Visual Studio Code (VS Code). Review the following considerations for working in this environment:

- Use the left menu to switch between the **CONTAINER EXPLORER** or the **EXPLORER** (file and folder) view:

   :::image type="content" source="./media/vs-code-docker-explorer-views.png" border="false" alt-text="Screenshot that shows the Container Explorer and file/folder Explorer view in Visual Studio Code.":::

- Open a command-line window in VS Code by selecting **Terminal** > **New Terminal**. You can also use the **Ctrl**+**Shift**+**`** (back tick) keyboard shortcut.

- Unless otherwise specified, run commands in a Bash window. Most commands labeled for `Bash` run in a Bash window or in the VS Code command-line window.

## Start MySQL database management system

By default, containers run in isolation. A container isn't aware of other processes or other containers on the same computer.

To enable communication between containers, they need to attach to the same network. Multiple containers on the same network can share data and process information with each other.

There are two ways to attach a container to a network. You can attach a container to a network during creation, or attach an existing container to a network at a later time.

In this example, you create the network and attach the MySQL container at startup.

1. Create a network named `todo-app`:

   ```bash
   docker network create todo-app
   ```

1. Start a MySQL container named `todo-mysql-data` and attach it to the `todo-app` network. The command creates a network alias `mysql` for the MySQL database `todos`.

   When you run the command, enter your MySQL root password for the `<your-password>` placeholder.

   ```bash
   docker run -d 
       --network todo-app --network-alias mysql 
       -v todo-mysql-data:/var/lib/mysql 
       -e MYSQL_ROOT_PASSWORD=<your-password> 
       -e MYSQL_DB=todos 
       mysql:5.7
   ```

   This command also defines the `MYSQL_ROOT_PASSWORD` and `MYSQL_DB` environment variables. For more information, see [MySQL Docker Hub listing](https://hub.docker.com/_/mysql/).

   > [!WARNING]
   > This tutorial illustrates password credentials to authenticate with a MySQL database, which is not the most secure method. Refer to the [MySQL documentation](https://dev.mysql.com/doc/) to learn about more secure methods of authentication.

1. Get your container ID for use in the next step.

   ```bash
   docker ps
   ```

1. Confirm you can connect to the container on the `mysql` network.

   When you run the command, enter your container ID for the `<mysql-container-id>` placeholder.

   ```bash
   docker exec -it <mysql-container-id> mysql -p
   ```

   At the prompt, enter the password you supplied when you created the `todo-mysql-data` container.

1. In the MySQL shell, list the databases and verify you see the `todos` database.

   ```sql
   SHOW DATABASES;
   ```

   You should see the following output:

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

1. To end the connection and return to the command-line prompt, enter **exit**.

## Run your app with MySQL

The `todo` app supports setting certain environment variables to specify your MySQL connection settings. The following table lists the supported variables, and the values used in the example presented in this section.

| Variable name | Example value | Description |
| --- | :---: | --- |
| `MYSQL_HOST` | `mysql` | The host name for the MySQL server. |
| `MYSQL_USER` | `root` | The username to use for the connection. |
| `MYSQL_PASSWORD` | `<your-password>` | The password to use for the connection. In this example, substitute your root password for the `<your-password>` placeholder. |
| `MYSQL_DB` | `todos` | The name of the database to use after the connection is established. |

> [!WARNING]
> Using environment variables to set connection settings is acceptable for development, but this practice isn't recommended for running applications in production. For more information, see [Why you shouldn't use environment variables for secret data](https://diogomonica.com/2017/03/27/why-you-shouldnt-use-env-variables-for-secret-data/).
>
> A more secure mechanism is to use the secret support provided by your container orchestration framework. In most cases, these secrets are mounted as files in the running container.

In the following example, you start your app and connect your app container to your MySQL container.

1. Run the following `docker` command. Notice how the command specifies the environment variables described earlier.

   When you run the command, remember to enter your MySQL root password for the `<your-password>` placeholder.

   ```bash
   docker run -dp 3000:3000 
     -w /app -v ${PWD}:/app 
     --network todo-app 
     -e MYSQL_HOST=mysql 
     -e MYSQL_USER=root 
     -e MYSQL_PASSWORD=<your-password> 
     -e MYSQL_DB=todos 
     node:20-alpine 
     sh -c "yarn install && yarn run dev"
   ```

1. In the VS Code editor, open the Container Explorer, right-click your app container, and select **View Logs**.

   You can also view the logs from the command line by using the `docker logs` command.

1. Review the log output. Notice the line that indicates the app is connected to the MySQL database: `Connected to mysql db at host mysql`.

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

1. In your internet browser, go to your running application: `http://localhost:3000`.

1. In your running application, add some items to your todo list.

1. Connect to the MySQL container database on the `mysql` network so you can check the database.

   When you run the command, enter your container ID for the `<mysql-container-id>` placeholder.

   ```bash
   docker exec -ti <mysql-container-id> mysql -p todos
   ```

   At the prompt, enter the password you supplied when you created the `todo-mysql-data` container.

1. In the MySQL shell, verify that the `todo_items` you added are written to the `todos` database.

   ```sql
   use todos;
   select * from todo_items;
   ```

   You should see output similar to the following example:

   ```output
   +--------------------------------------+--------------------+-----------+
   | id                                   | name               | completed |
   +--------------------------------------+--------------------+-----------+
   | c906ff08-60e6-44e6-8f49-ed56a0853e85 | Do amazing things! |         0 |
   | 2912a79e-8486-4bc3-a4c5-460793a575ab | Be awesome!        |         0 |
   +--------------------------------------+--------------------+-----------+
   ```

You now have an application that stores data in an external database running in a separate container. This procedure demonstrates how you can enable communication between containers by using networking.

## Create Docker Compose file

Docker Compose helps you define and share multi-container applications. A Docker Compose file can specify all your required services, so you can start or end all related processes with a single command. You can define your application stack in a Docker Compose file at the root of your project repo, and maintain your configuration under version control. This approach allows others to contribute to your project when they clone your repo.

In the following example, you configure a Docker Compose file for your multi-container application `todo`.

1. At the root of your `todo` app project, create a Docker Compose file named *docker-compose.yml*.

   > [!NOTE]
   > By default, the YAML schema version is set to the most recent version. When you run your app, if your schema version is obsolete, you receive a warning message. To review current schema versions and a compatibility matrix, see [Overview (Compose file)](https://docs.docker.com/reference/compose-file/).

1. In the *docker-compose.yml* file, add the following elements. Specify your app `name` and start the list of `services` (or containers) that you want to run as part of your application. 

   ```yaml
   name: todo
   
   services:
   ```

   The list of services is unique for your app. Examples include `app`, `web`, `db`, `proxy`, and so on. You extend the definition for the `services` element in a later step.

   > [!TIP]
   > Indentation is significant in *.yml* files. If you're editing in VS Code, Intellisense indicates any errors in the format or syntax.

1. Add the following code to your *docker-compose.yml* file after the `services` section. 

   ```bash
   docker run -dp 3000:3000 
     -w /app -v ${PWD}:/app 
     --network todo-app 
     -e MYSQL_HOST=mysql 
     -e MYSQL_USER=root 
     -e MYSQL_PASSWORD=<your-password> 
     -e MYSQL_DB=todos 
     node:20-alpine 
     sh -c "yarn install && yarn run dev"
   ```

   Remember to enter your MySQL root password for the `<your-password>` placeholder. You used this same command earlier to [run your app container with MySQL](#run-your-app-with-mysql).

1. Return to the `services` definition in the *docker-compose.yml* file. Extend the definition by adding an entry to define the `app` service element, which includes the image for the container.

   ```yaml
   services:
     app:
       image: node:20-alpine
   ```

   You can pick any name for the service. The name automatically becomes a network alias, which is useful when you define the MySQL service.

1. Extend the `app` element definition to specify a `command` to execute.

   ```yaml
     app:
       image: node:20-alpine
       command: sh -c "yarn install && yarn run dev"
   ```

1. Define the `ports` to use with the `app` service. Notice these ports correspond to the `-p 3000:3000` argument for the command used to run the app with MySQL.

   ```yaml
     app:
       image: node:20-alpine
       command: sh -c "yarn install && yarn run dev"
       ports:
         - 3000:3000
   ```

1. Identify the working directory `working_dir` for the `app` service and also the mapped `volumes`.

   ```yaml
     app:
       image: node:20-alpine
       command: sh -c "yarn install && yarn run dev"
       ports:
         - 3000:3000
       working_dir: /app
       volumes:
         - ./:/app
   ```

   When you define Docker Compose volumes, you can use relative paths based on the current directory.

1. Specify `environment` variable definitions to use when you execute commands for the `app` service.

   ```yaml
     app:
       image: node:20-alpine
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

   Remember to enter your MySQL root password for the `<your-password>` placeholder. 

1. Add the definition for the MySQL service `mysql` after the `app` service definition. Specify the element names and values as shown and with the same indentation.

   ```yaml
   services:
     app:
       ...
     mysql:
       image: mysql:5.7
   ```

   The `mysql` service definition corresponds to the command you used earlier to [start MySQL](#start-mysql-database-management-system). When you define the service, it automatically receives the network alias.

1. Identify the mapped `volumes` for the `mysql` service.

   ```yaml
   services:
     app:
       ...
     mysql:
       image: mysql:5.7
       volumes:
         - todo-mysql-data:/var/lib/mysql
   ```

1. Specify `environment` variable definitions to use when you execute commands for the `mysql` service.

   ```yaml
   services:
     app:
       ...
     mysql:
       image: mysql:5.7
       volumes:
         - todo-mysql-data:/var/lib/mysql
       environment: 
         MYSQL_ROOT_PASSWORD: <your-password>
         MYSQL_DB: todos
   ```

   Remember to enter your MySQL root password for the `<your-password>` placeholder. 

1. Define volume mapping for the entire app. Add a `volumes:` section after the `services:` section and with the same indentation.

   ```yaml
   services:
      ...
   
   volumes:
     todo-mysql-data:
   ```

1. Confirm your completed *docker-compose.yml* file looks like the following example. You should see your MySQL root password for the `<your-password>` placeholder. 

   ```yaml
   name: todo

   services:
     app:
       image: node:20-alpine
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
         MYSQL_DB: todos

   volumes:
     todo-mysql-data:
   ```

## Run the application stack with Docker Compose

Now you can try running your *docker-compose.yml* file.

1. Stop any running instances of your application and database.

   # [Visual Studio Code](#tab/visual-studio-code)

   Follow these steps in VS Code:

   1. Open the **CONTAINER EXPLORER** (Container Tools extension).
   
   1. For each running container, right-click the container and select **Remove**.

   # [Command Line](#tab/command-line)
   
   Run the following commands in a command-line window or terminal:

   1. Get the list of running containers and their identifiers `<container-id>`:

      ```bash
      docker ps
      ```

   1. Stop and remove each running container:

      ```bash
      docker stop <container-id>
      docker rm <container-id>
      ```
   ---

1. Start your multi-container app and all services.

   # [Visual Studio Code](#tab/visual-studio-code)

   Follow these steps in VS Code:

   1. Open the **EXPLORER** (file and folder) view.
   
   1. Right-click the *docker-compose.yml* file and select **Compose Up**.

   # [Command Line](#tab/command-line)
   
   Run the following command with the `-d` argument, which executes the command as a background process:

   ```bash
   docker-compose up -d
   ```
   ---

   You should see output similar to the following example:

   ```output
   [+] Building 0.0s (0/0)
   [+] Running 2/2
   ✔ Container app-app-1    Started  0.9s 
   ✔ Container app-mysql-1  Running
   ```

   This operation creates the mapped volume for the app and the network. By default, Docker Compose creates a network specifically for the application stack.

1. Review the logs for the running container.

   # [Visual Studio Code](#tab/visual-studio-code)

   Follow these steps in VS Code:

   1. Open the **CONTAINER EXPLORER** (Container Tools extension).
   
   1. Right-click the app container and select **View Logs**.

   # [Command Line](#tab/command-line)
   
   Run the following command:

   ```bash
   docker logs
   ```

   You can view logs for a specific service by adding the service name, such as `app` to the end of the `logs` command:

   ```bash
   docker logs <service-name>
   ```
   ---

   You should see output similar to the following example:

   ```output
   mysql_1  | 2019-10-03T03:07:16.083639Z 0 [Note] mysqld: ready for connections.
   mysql_1  | Version: '5.7.27'  socket: '/var/run/mysqld/mysqld.sock'  port: 3306  MySQL Community Server (GPL)
   app_1    | Connected to mysql db at host mysql
   app_1    | Listening on port 3000
   ```

   The logs show the service name and instance number, such as `app_1` at the start of each line. This format helps you to distinguish messages by service and instance. The logs from each service are interleaved into a single stream. This approach enables you to watch for timing-related issues.

1. You can now go to your running application in your internet browser: `http://localhost:3000`.

## Stop Docker Compose and running containers

When you're done with the app and containers, you can remove them.

# [Visual Studio Code](#tab/visual-studio-code)

Follow these steps in VS Code:

1. Open the **EXPLORER** (file and folder) view.
   
1. Right-click the *docker-compose.yml* file and select **Compose Down**.

# [Command Line](#tab/command-line)
   
Run the following command to stop the running app and containers:

```bash
docker-compose down
```
---

This operation stops all running containers and removes the network.

By default, named volumes in your compose file aren't removed. If you want to remove these volumes, you can use the `docker-compose down --volumes` command.

## Clean up resources

If you applied the [Prerequisites](#prerequisites) components in this tutorial series to your installation, you can reuse the configuration for future Docker development. It's not essential to delete or uninstall any component.

## Related content

- [Docker Cloud Integration](https://github.com/docker/compose-cli)
- [Examples](https://github.com/docker/awesome-compose)
