---
title: Build a containerized Visual Studio project from the command line.
author: ghogen
description: Build a container project in Visual Studio using the command line, either with MSBuild.exe or using docker build, and learn how to enable detailed build logs.
ms.author: ghogen
ms.date: 09/17/2024
ms.subservice: container-tools
ms.topic: how-to
---

# Build a container project from the command line

If you want to build a container project with a Dockerfile outside of Visual Studio, you can use `docker build`, `MSBuild`, `dotnet build`, or `dotnet publish` to build from the command line.

:::moniker range=">=vs-2022"
If you're using the .NET SDK build type, you don't have a Dockerfile, so you can't use `docker build`; instead, use `MSBuild`, `dotnet build` or `dotnet publish` to build on the command line.
:::moniker-end

### Use Docker build

To build a containerized solution from the command line, you can usually use the command `docker build <context>` for each project in the solution. You provide the *build context* argument. The *build context* for a Dockerfile is the folder on the local machine that's used as the working folder to generate the image. For example, it's the folder that you copy files from when you copy to the container. In .NET Core projects, use the folder that contains the solution file (.sln). Expressed as a relative path, this argument is typically ".." for a Dockerfile in a project folder, and the solution file in its parent folder. For .NET Framework projects, the build context is the project folder, not the solution folder.

```cmd
docker build -f Dockerfile ..
```

## Enable detailed container tools logs

For diagnostic purposes, you can enable certain Container Tools logs. You can enable these logs by setting certain environment variables. For single container projects, the environment variable is `MS_VS_CONTAINERS_TOOLS_LOGGING_ENABLED`, which then logs in `%tmp%\Microsoft.VisualStudio.Containers.Tools`. For Docker Compose projects, it's `MS_VS_DOCKER_TOOLS_LOGGING_ENABLED`, which then logs in `%tmp%\Microsoft.VisualStudio.DockerCompose.Tools`.

:::moniker range=">=vs-2022"
> [!CAUTION]
> When logging is enabled and you're using a token proxy for Azure authentication, authentication credentials could be logged as plain text. See [Configure Azure authentication](container-tools-configure.md#configure-azure-authentication).
:::moniker-end

## MSBuild

::: moniker range=">=vs-2022"
> [!NOTE]
> This section describes how you can customize your Docker containers when you choose the Dockerfile container build type. If you are using the .NET SDK build type, the customization options are different, and the information in this article isn't applicable. Instead, see [Containerize a .NET app with dotnet publish](/dotnet/core/docker/publish-as-container?pivots=dotnet-8-0).
::: moniker-end

Dockerfiles created by Visual Studio for .NET Framework projects (and for .NET Core projects created with versions of Visual Studio prior to Visual Studio 2017 Update 4) aren't multistage Dockerfiles. The steps in these Dockerfiles don't compile your code. Instead, when Visual Studio builds a .NET Framework Dockerfile, it first compiles your project using MSBuild. When that succeeds, Visual Studio then builds the Dockerfile, which simply copies the build output from MSBuild into the resulting Docker image. Because the steps to compile your code aren't included in the Dockerfile, you can't build .NET Framework Dockerfiles using `docker build` from the command line. You should use MSBuild to build these projects.

To build an image for single Docker container project, you can use MSBuild with the `/t:ContainerBuild` command option. This command tells MSBuild to build the target `ContainerBuild` rather than the default target `Build`. For example:

```cmd
MSBuild MyProject.csproj /t:ContainerBuild /p:Configuration=Release
```

You see output similar to what you see in the **Output** window when you build your solution from the Visual Studio IDE. Always use `/p:Configuration=Release`, since in cases where Visual Studio uses the multistage build optimization, results when building the **Debug** configuration might not be as expected. See [Debugging](#debugging).

If you're using a Docker Compose project, use this command to build images:

```cmd
msbuild /p:SolutionPath=<solution-name>.sln /p:Configuration=Release docker-compose.dcproj
```

## Related content

- [MSBuild properties for container projects](container-msbuild-properties.md).
- [MSBuild](../msbuild/msbuild.md)
- [Dockerfile on Windows](/virtualization/windowscontainers/manage-docker/manage-windows-dockerfile)
- [Linux containers on Windows](/virtualization/windowscontainers/deploy-containers/linux-containers)
