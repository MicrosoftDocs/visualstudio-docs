---
title: Visual Studio Container Tools build properties
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

The following table shows the MSBuild properties available for container projects. The NuGet package version applies to [Microsoft.VisualStudio.Azure.Containers.Tools.Targets](https://www.nuget.org/packages/Microsoft.VisualStudio.Azure.Containers.Tools.Targets/).

| Property name | Description | Default value  | NuGet package version|
|---------------|-------------|----------------|----------------------|
| ContainerDevelopmentMode | Controls whether "build-on-host" optimization ("Fast Mode" debugging) is enabled.  Allowed values are **Fast** and **Regular**. | Fast |1.0.1872750 or newer|
| ContainerVsDbgPath | The path for VSDBG debugger. | `%USERPROFILE%\vsdbg\vs2017u5` |1.0.1985401 or newer|
| DockerDebuggeeArguments | When debugging, the debugger is instructed to pass these arguments to the launched executable. | Not applicable to ASP.NET .NET Framework projects |1.7.8 or newer|
| DockerDebuggeeProgram | When debugging, the debugger is instructed to launch this executable. | For .NET Core projects: dotnet, ASP.NET .NET Framework projects: Not applicable (IIS is always used) |1.7.8 or newer|
| DockerDebuggeeKillProgram | This command is used to kill the running process in a container. | Not applicable to ASP.NET .NET Framework projects |1.7.8 or newer|
| DockerDebuggeeWorkingDirectory | When debugging, the debugger is instructed to use this path as the working directory. | C:\app (Windows) or /app (Linux) |1.7.8 or newer|
| DockerDefaultTargetOS | The default target operating system used when building the Docker image. | Set by Visual Studio. |1.0.1985401 or newer|
| DockerImageLabels | The default set of labels applied to the Docker image. | com.microsoft.created-by=visual-studio;com.microsoft.visual-studio.project-name=$(MSBuildProjectName) |1.5.4 or newer|
| DockerFastModeProjectMountDirectory|In **Fast Mode**, this property controls where the project output directory is volume-mounted into the running container.|C:\app (Windows) or /app (Linux)|1.9.2 or newer|
| DockerfileBuildArguments | Additional arguments passed to the Docker build command. | Not applicable. |1.0.1872750 or newer|
| DockerfileContext | The default context used when building the Docker image. | Set by Visual Studio. |1.0.1872750 or newer|
| DockerfileFastModeStage | The Dockerfile stage (that is, target) to be used when building the image in debug mode. | First stage found in the Dockerfile (base) |
| DockerfileFile | Describes the default Dockerfile that will be used to build/run the container for the project. This can be a path as well. | Dockerfile |1.0.1872750 or newer|
| DockerfileRunArguments | Additional arguments passed to the Docker run command. | Not applicable. |1.0.1872750 or newer|
| DockerfileRunEnvironmentFiles | Semicolon-delimited list of environment files applied during Docker run. | Not applicable. |1.0.1872750 or newer|
| DockerfileTag | The tag that will be used when building the Docker image. In debugging, a ":dev" is appended to the tag. | Assembly name after stripping non-alphanumeric characters with the following rules: <br/> If the resultant tag is all numeric, then "image" is inserted as a prefix (for example, image2314) <br/> If the resultant tag is an empty string, then "image" is used as the tag. |1.0.1872750 or newer|

## Next steps

For information on MSBuild properties generally, see [MSBuild Properties](../msbuild/msbuild-properties.md).

## See also

[Docker Compose build properties](docker-compose-properties.md)

[Container Tools launch settings](container-launch-settings.md)

[MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md)
