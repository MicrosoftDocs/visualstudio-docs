---
title: Build a containerized Visual Studio project from the command line
author: ghogen
description: Build a container project in Visual Studio using the command line, either with MSBuild.exe or using Docker build, and learn how to enable detailed build logs.
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

## Use Docker build

To build a containerized solution from the command line, you can usually use the command `docker build <context>` for each project in the solution. You provide the *build context* argument. The *build context* for a Dockerfile is the folder on the local machine that's used as the working folder to generate the image. For example, it's the folder that you copy files from when you copy to the container. In .NET Core projects, the default is to use the folder that contains the solution file (.sln or .slnx). Expressed as a relative path, this argument is typically ".." for a Dockerfile in a project folder, and the solution file in its parent folder.

```cmd
docker build -f Dockerfile ..
```

:::moniker range="<=vs-2022"
For .NET Framework projects, the default build context is the project folder, not the solution folder.

You can set the build context in the project file by setting the `DockerfileContext` property. For example,

```xml
<PropertyGroup>
   <DockerfileContext>contextfolder</DockerfileContext>
</PropertyGroup>
```

:::moniker-end

:::moniker range="visualstudio"

You can set the build context in the project file by setting the `ContainerContext` property. For example,

```xml
<PropertyGroup>
   <ContainerContext>contextfolder</ContainerContext>
</PropertyGroup>
```

:::moniker-end

Relative paths in the Dockerfile are relative to the build context, so if you change the context, be sure to update the relative paths accordingly.

:::moniker range=">=vs-2022"
With Visual Studio 17.11 and later, when you add Docker support to a project, you can specify a folder for the build context. If you want to change the build context, you could delete the Dockerfile (if it doesn't have other changes you want to keep), and rerun **Add Docker support**, this time specifying the new build context. The new Dockerfile will have relative paths updated to correspond to the new build context.
:::moniker-end

## Use MSBuild

::: moniker range=">=vs-2022"
> [!NOTE]
> This section describes how you can customize your Docker containers when you choose the Dockerfile container build type. If you are using the .NET SDK build type, the customization options are different, and the information in this article isn't applicable. Instead, see [Containerize a .NET app with dotnet publish](/dotnet/core/docker/publish-as-container?pivots=dotnet-8-0).
::: moniker-end

:::moniker range="vs-2022"

Dockerfiles created by Visual Studio for .NET Framework projects (and for .NET Core projects created with versions of Visual Studio prior to Visual Studio 2017 Update 4) aren't multistage Dockerfiles. The steps in these Dockerfiles don't compile your code. Instead, when Visual Studio builds a .NET Framework Dockerfile, it first compiles your project using MSBuild. When that succeeds, Visual Studio then builds the Dockerfile, which simply copies the build output from MSBuild into the resulting Docker image. Because the steps to compile your code aren't included in the Dockerfile, you can't build .NET Framework Dockerfiles using `docker build` from the command line. You should use MSBuild to build these projects.

:::moniker-end

To build an image for single Docker container project, you can use MSBuild with the `/t:ContainerBuild` command option. This command tells MSBuild to build the target `ContainerBuild` rather than the default target `Build`. For example:

```cmd
MSBuild MyProject.csproj /t:ContainerBuild /p:Configuration=Release
```

You see output similar to what you see in the **Output** window when you build your solution from the Visual Studio IDE. Always use `/p:Configuration=Release`, since in cases where Visual Studio uses the multistage build optimization, results when building the **Debug** configuration might not be as expected. See [Customize container images for debugging](container-debug-customization.md).

If you're using a Docker Compose project, use this command to build images:

```cmd
msbuild /p:SolutionPath=<solution-name>.sln /p:Configuration=Release docker-compose.dcproj
```

To view the MSBuild logs, see [Obtaining build logs with MSBuild](../msbuild/obtaining-build-logs-with-msbuild.md).

## Build from the command line

Visual Studio uses Fast Mode (if enabled) to produce a container image configured to work best for development and debugging, so we don't recommend copying the docker build commands from the Output window after a Fast Mode build. To build a standard image without nonstandard optimizations, you can right-click on the Dockerfile and choose the **Build Docker image** option.

Visual Studio uses the `dev` tag to designate images that it has specially prepared to optimize the startup time during debugging. However, these images shouldn't be used outside of the context of Visual Studio. This tag is an indication the images have nonstandard modifications and customizations, for example, to support Fast Mode debugging. See [Customize Docker containers in Visual Studio](container-build.md).

## Related content

- [MSBuild properties for container projects](container-msbuild-properties.md).
- [MSBuild](../msbuild/msbuild.md)
