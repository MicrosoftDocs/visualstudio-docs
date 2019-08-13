---
title: Visual Studio Container Tools build settings
author: ghogen
description: Overview of the Container Tools build process
ms.author: ghogen
ms.date: 06/06/2019
ms.technology: vs-azure
ms.topic: conceptual
---
# Container Tools build properties

You can customize how Visual Studio builds your container projects by setting the properties that MSBuild uses to build your project. For example, you can change the name of the Dockerfile, specify tags and labels for your images, provide additional arguments passed to Docker commands, and control whether Visual Studio does certain performance optimizations such as building outside of the container environment. You can also set debugging properties such as the name of the executable to launch, and the command line arguments to provide.

To set the value of a property, edit the project file. For example, suppose your Dockerfile is named *MyDockerfile*. You can set the `DockerfileFile` property in the project file as follows.

```xml
<PropertyGroup>
   <DockerfileFile>MyDockerfile</DockerfileFile>
</PropertyGroup>
```

You can add the property setting to an existing `PropertyGroup` element, or if there isn't one, create a new `PropertyGroup` element.

The following table shows the MSBuild properties available for container projects.

| Property name | Description | Default value  |
|---------------|-------------|----------------|
| DockerfileFile | Describes the default Dockerfile that will be used to build/run the container for the project. This can be a path as well. | Dockerfile |
| DockerfileTag | The tag that will be used when building the Docker image. In debugging, a ":dev" is appended to the tag. | Assembly name after stripping non-alphanumeric characters with the following rules: <br/> If the resultant tag is all numeric, then "image" is inserted as a prefix (for example, image2314) <br/> If the resultant tag is an empty string, then "image" is used as the tag. |
| DockerContext | The default context used when building the Docker image. | Set by Visual Studio. |
| ContainerDevelopmentMode | Controls whether "build-on-host" optimization ("Fast Mode" debugging) is enabled.  Allowed values are **Fast** and **Regular**. | Fast |
| DockerDefaultTargetOS | The default target operating system used when building the Docker image. | Set by Visual Studio. |
| DockerImageLabels | The default set of labels applied to the Docker image. | com.microsoft.created-by=visual-studio;com.microsoft.visual-studio.project-name=$(MSBuildProjectName) |
| ContainerVsDbgPath | The path for VSDBG debugger. | `%USERPROFILE%\vsdbg\vs2017u5` |
| DockerfileBuildArguments | Additional arguments passed to the Docker build command. | Not applicable. |
| DockerfileRunArguments | Additional arguments passed to the Docker run command. | Not applicable. |
| DockerfileRunEnvironmentFiles | Semicolon-delimited list of environment files applied during Docker run. | Not applicable. |
| DockerfileFastModeStage | The Dockerfile stage (that is, target) to be used when building the image in debug mode. | First stage found in the Dockerfile (base) |
| DockerDebuggeeProgram | When debugging, the debugger is instructed to launch this executable. | For .NET Core projects: dotnet, ASP.NET .NET Framework projects: Not applicable (IIS is always used) |
| DockerDebuggeeArguments | When debugging, the debugger is instructed to pass these arguments to the launched executable. | Not applicable to ASP.NET .NET Framework projects |
| DockerDebuggeeWorkingDirectory | When debugging, the debugger is instructed to use this path as the working directory. | C:\app (Windows) or /app (Linux) |
| DockerDebuggeeKillProgram | This command is used to kill the running process in a container. | Not applicable to ASP.NET .NET Framework projects |

## Next steps

For information on MSBuild properties generally, see [MSBuild Properties](../msbuild/msbuild-properties.md).

## See also

[Docker Compose build properties](docker-compose-properties.md)

[Container Tools launch settings](container-launch-settings.md)

[MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md)
