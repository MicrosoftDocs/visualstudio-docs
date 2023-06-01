---
title: Visual Studio Container Tools build properties
author: ghogen
description: Learn how to edit the Container Tools build properties to customize how Visual Studio builds and runs a container project.
ms.author: ghogen
ms.date: 06/06/2019
ms.technology: vs-container-tools
ms.topic: reference
---
# Container Tools build properties

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

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
| DockerfileBuildArguments | Additional arguments passed to the [Docker build](https://docs.docker.com/engine/reference/commandline/build/) command. | Not applicable. |1.0.1872750 or newer|
| DockerfileContext | The default context used when building the Docker image, as a path relative to the Dockerfile. | Set by Visual Studio when Docker support is added to a project. In .NET Framework projects, set to "." (the project folder), and in .NET Core projects, it is set to the relative path to the solution folder (usually ".."). |1.0.1872750 or newer|
| DockerfileFastModeStage | The Dockerfile stage (that is, target) to be used when building the image in debug mode. | First stage found in the Dockerfile (base) |
| DockerfileFile | Describes the default Dockerfile that will be used to build/run the container for the project. This can be a path as well. | Dockerfile |1.0.1872750 or newer|
| DockerfileRunArguments | Additional arguments passed to the [Docker run](https://docs.docker.com/engine/reference/commandline/run/) command. | Not applicable. |1.0.1872750 or newer|
| DockerfileRunEnvironmentFiles | Semicolon-delimited list of environment files applied during Docker run. | Not applicable. |1.0.1872750 or newer|
| DockerfileTag | The tag that will be used when building the Docker image. In debugging, a ":dev" is appended to the tag. | Assembly name after stripping non-alphanumeric characters with the following rules: <br/> If the resultant tag is all numeric, then "image" is inserted as a prefix (for example, image2314) <br/> If the resultant tag is an empty string, then "image" is used as the tag. |1.0.1872750 or newer|

## Example

The following project file shows examples of some of these settings.

```xml
 <Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>netcoreapp3.1</TargetFramework>
    <UserSecretsId>feae72bf-2368-4487-b6c6-546c19338cb1</UserSecretsId>
    <DockerDefaultTargetOS>Linux</DockerDefaultTargetOS>
    <!-- In CI/CD scenarios, you might need to change the context. By default, Visual Studio uses the
         folder above the Dockerfile. The path is relative to the Dockerfile, so here the context is
         set to the same folder as the Dockerfile. -->
    <DockerfileContext>.</DockerfileContext>
    <!-- Set `docker run` arguments to mount a volume -->
    <DockerfileRunArguments>-v $(MSBuildProjectDirectory)/host-folder:/container-folder:ro</DockerfileRunArguments>
    <!-- Set `docker build` arguments to add a custom tag -->
    <DockerfileBuildArguments>-t contoso/front-end:v2.0</DockerfileBuildArguments>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.VisualStudio.Azure.Containers.Tools.Targets" Version="1.10.6" />
  </ItemGroup>

</Project>
```

> [!NOTE]
> The Docker context, which you can set by providing a value for `DockerfileContext`, is usually different in Visual Studio for projects targeting .NET Core (including .NET 5 and later) from what `docker build` uses when you run it from the command line. The departure from the behavior of `docker build` is necessary to ensure that build artifacts at the solution level can be included.
>
> When you call `docker build`, you always specify a build context, and you can optionally specify a path to the Dockerfile. The default is that the Dockerfile is in the root of the context, but you can use the `-f` flag to specify an alternate location. For example, you can build with `docker build -f Dockerfile ..` from the project directory, or `docker build -f ProjectName/Dockerfile .` from the solution directory.

## Next steps

For information on MSBuild properties generally, see [MSBuild Properties](../msbuild/msbuild-properties.md).

## See also

[Docker Compose build properties](docker-compose-properties.md)

[Container Tools launch settings](container-launch-settings.md)

[MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md)
