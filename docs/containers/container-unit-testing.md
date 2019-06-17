---
title: Unit test a containerized app
author: ghogen
description: Run unit tests with every build for a Docker project in Visual Studio
ms.author: ghogen
ms.date: 06/17/2019
ms.technology: vs-azure
ms.topic: conceptual
---
# How to: Run unit tests for a containerized app

You can run unit tests with every build of your containerized project by modifying your Dockerfile.

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
- Install [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019)
- Unit tests set up to run using [dotnet test](/dotnet/core/tools/dotnet-test)
- Install the [Containers window extension](https://aka.ms/vscontainerspreview)

## Add unit tests to the Dockerfile

Visual Studio does some special performance optimizations that you should know about before modifying the Dockerfile. When building the **Debug** configuration, Visual Studio builds projects on the local machine, and copies the results to the container. This means that only the first stage of the multistage Dockerfile is actually executed as specified in the Dockerfile. For more information, see [Container Tools build process for Visual Studio](container-build.md).

To add unit tests to a multistage Dockerfile, add a `unit-test` stage to the Dockerfile between the `build` and `publish` stages.

```
FROM build AS unit-test
RUN dotnet unit-test --logger:trx
```

Visual Studio only runs the first stage in **Debug** configuration, so the `unit-test` stage is only run in the **Release** configuration. But even in **Release** configuration, the log results won't be included in the final image, because the final image is built from the `base` stage, not from the `unit-test` stage. If you want to run the tests to produce an image that you can access to view the logs, you can do so from the command line as follows:

```cmd
docker build --target:unit-test
```

## Next steps

You can then use the [Containers window](view-and-diagnose-containers.md) (if you have the extension installed) to view the test logs.  

To view your test logs, use **Ctrl**+**Q** and search for **Containers** to open the **Containers** window. In the **Containers** window, find your container, open the **Files** tab, look for your test results (.trx) file in the container's filesystem, and open it to view the results in Visual Studio.

