---
title: Visual Studio Container Tools Build Overview
author: ghogen
description: Overview of the Container Tools build process
ms.author: ghogen
ms.date: 06/06/2019
ms.technology: vs-azure
ms.topic: conceptual
---
# Container Tools Build Properties

You can customize your container projects by setting the properties that MSBuild uses to build your project.

The following table shows the MSBuild properties available for container projects.

| Property name | Description | Default value  |
|---------------|-------------|----------------|
| DockerfileFile | Describes the default Dockerfile that will be used to build/run the container for the project. This can be a path as well. | Dockerfile |
| DockerfileTag | The tag that will be used when building the Docker image. In debugging, a ":dev" is appended to the tag. | Assembly name after stripping non-alphanumeric characters with the following rules: <br/> If the resultant tag is all numeric, then "image" is inserted as a prefix (i.e. image2314) <br/> If the resultant tag is an empty string, then "image" is used as the tag |
| DockerContext | The default context used when building the Docker image. | The value is ".." for dotnet core projects and "." for .NET Framework projects |
| DockerTargetOS | The default target OS used when building the Docker image. | Linux |
| DockerImageLabels | The default set of labels applied to the Docker image. |com.microsoft.created-by=visual-studio;com.microsoft.visual-studio.project-name=$(MSBuildProjectName) |
| ContainerVsDbgPath | The path for VSDBG debugger. | `%USERPROFILE%\vsdbg\vs2017u5` |
| DockerfileBuildArguments | Additional arguments passed to the Docker build command. | Not applicable. |
| DockerfileRunArguments | Additional arguments passed to the Docker run command. | Not applicable. |
| DockerfileRunEnvironmentFiles | Semicolon-delimited list of environment files applied during Docker run. | Not applicable. |
| DockerfileRepository | The Docker image repository to which images are pushed. | Not applicable. |
| DockerfileFastModeStage | The Dockerfile stage (that is, target) to be used when building the image in debug mode. | First stage found in the Dockerfile (base) |
| DockerDebuggeeProgram | When debugging, the debugger will be instructed to launch this executable | For .NET Core projects: dotnet, ASP.NET .NET Framework projects: Not applicable (IIS is always used) |
| DockerDebuggeeArguments | When debugging, the debugger will be instructed to pass these arguments to the launched executable | Not applicable to ASP.NET .NET Framework projects |
| DockerDebuggeeWorkingDirectory | When debugging, the debugger will be instructed to use this path as the working directory | C:\app (Windows) or /app (Linux) |
| DockerDebuggeeKillProgram | This command will be used to kill the running process in a container | Not applicable to ASP.NET .NET Framework projects |

## Next steps

For information on MSBuild properties generally, see [MSBuild Properties](../msbuild/msbuild-properties.md).

## See also

[MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md).
