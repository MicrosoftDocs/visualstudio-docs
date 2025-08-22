---
title: Visual Studio Container Tools build properties
author: ghogen
description: Learn how to edit the Container Tools build properties to customize how Visual Studio builds and runs a container project.
ms.author: ghogen
ms.date: 05/21/2024
ms.subservice: container-tools
ms.topic: reference
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

::: moniker range=">=vs-2022"

## Properties for .NET SDK projects

This section describes the MSBuild properties that apply when you choose the .NET SDK container build type.

There is just one property, `EnableSdkContainerDebugging`, in the project file that is needed for .NET SDK containerized projects. It must be set to `True` for .NET SDK projects to enable debugging.

```xml
<PropertyGroup>
   <EnableSdkContainerDebugging>True</EnableSdkContainerDebugging>
</PropertyGroup>
```

## Properties for Dockerfile projects

This section describes the MSBuild properties that apply when you choose the Dockerfile container build type.
::: moniker-end

:::moniker range="<=vs-2022"

The following table shows the MSBuild properties available for Dockerfile projects. The NuGet package version applies to [Microsoft.VisualStudio.Azure.Containers.Tools.Targets](https://www.nuget.org/packages/Microsoft.VisualStudio.Azure.Containers.Tools.Targets/).

| Property name | Description | Default value  | NuGet package version|
|---------------|-------------|----------------|----------------------|
| ContainerDevelopmentMode | Controls whether "build-on-host" optimization ("Fast Mode" debugging) is enabled. Allowed values are **Fast** and **Regular**. | Fast |1.0.1872750 or newer|
| ContainerVsDbgPath | The path for VSDBG debugger. | `%USERPROFILE%\vsdbg\vs2017u5` |1.0.1985401 or newer|
| DockerDebuggeeArguments | When debugging, the debugger is instructed to pass these arguments to the launched executable. | Not applicable to ASP.NET .NET Framework projects |1.7.8 or newer|
| DockerDebuggeeProgram | When debugging, the debugger is instructed to launch this executable. | For .NET Core and .NET 5 and later projects: dotnet, ASP.NET .NET Framework projects: Not applicable (Internet Information Services (IIS) is always used) |1.7.8 or newer|
| DockerDebuggeeKillProgram | This command is used to kill the running process in a container. | Not applicable to ASP.NET .NET Framework projects |1.7.8 or newer|
| DockerDebuggeeWorkingDirectory | When debugging, the debugger is instructed to use this path as the working directory. | C:\app (Windows) or /app (Linux) |1.7.8 or newer|
| DockerDefaultTargetOS | The default target operating system used when building the Docker image. | Set by Visual Studio. |1.0.1985401 or newer|
| DockerImageLabels | The default set of labels applied to the Docker image. | com.microsoft.created-by=visual-studio;com.microsoft.visual-studio.project-name=$(MSBuildProjectName) |1.5.4 or newer|
| DockerFastModeProjectMountDirectory|In **Fast Mode**, this property controls where the project output directory is volume-mounted into the running container.|C:\app (Windows) or /app (Linux)|1.9.2 or newer|
| DockerfileBuildArguments | Additional arguments passed to the [Docker build](https://docs.docker.com/engine/reference/commandline/build/) command. | Not applicable. |1.0.1872750 or newer|
| DockerfileContext | The default context used when building the Docker image, as a path relative to the Dockerfile. | Set by Visual Studio when Docker support is added to a project. In .NET Framework projects, set to "." (the project folder), and in .NET Core and .NET 5 and later projects, it's set to the relative path to the solution folder (usually ".."). |1.0.1872750 or newer|
| DockerfileFastModeStage | The Dockerfile stage (that is, target) to be used when building the image in debug mode. | First stage found in the Dockerfile (usually base) |
| DockerfileFile | Describes the default Dockerfile to use to build/run the container for the project. This value can be a path. | Dockerfile |1.0.1872750 or newer|
| DockerfileRunArguments | Additional arguments passed to the [Docker run](https://docs.docker.com/engine/reference/commandline/run/) command. | Not applicable. |1.0.1872750 or newer|
| DockerfileRunEnvironmentFiles | Semicolon-delimited list of environment files applied during Docker run. | Not applicable. |1.0.1872750 or newer|
| DockerfileTag | The tag to use when building the Docker image. In debugging, a ":dev" is appended to the tag. | Assembly name after stripping nonalphanumeric characters with the following rules: <br/> If the resultant tag is all numeric, then "image" is inserted as a prefix (for example, image2314) <br/> If the resultant tag is an empty string, then "image" is used as the tag. |1.0.1872750 or newer|
:::moniker-end

:::moniker range="visualstudio"

The following table shows the MSBuild properties available for Dockerfile projects. The NuGet package version applies to [Microsoft.VisualStudio.Azure.Containers.Tools.Targets](https://www.nuget.org/packages/Microsoft.VisualStudio.Azure.Containers.Tools.Targets/).

Some of the properties and item lists in the following table are equivalent replacements for obsolete properties. In that case, the obsolete property that it replaces is also named. We recommend updating projects to use the currently supported properties. Support for obsolete properties might be removed in a future update of Visual Studio.

Some properties listed as obsolete are replaced by equivalent values in *launchsettings.json*, and one is replaced by MSBuild item list.

| Property name | Description | Default value  | Minimum NuGet package version|
|---------------|-------------|----------------|----------------------|
| `ContainerDevelopmentMode` | Controls whether "build-on-host" optimization ("Fast Mode" debugging) is enabled. Allowed values are **Fast** and **Regular**. | Fast |1.0.1872750|
| `ContainerVsDbgPath` | The path for VSDBG debugger. | `%USERPROFILE%\vsdbg\vs2017u5` |1.0.1985401|
| `ContainerImageLabels`<br/><br/>(replaces `DockerImageLabels`) | The default set of labels applied to the Docker image.<br/><br/>`ContainerImageLabel` is an MSBuild item list, not a property. | `com.microsoft.created-by=visual-studio;com.microsoft.visual-studio.project-name=$(MSBuildProjectName)` |1.23.0 for `ContainerImageLabels`<br/><br/>1.5.4 for `DockerImageLabels`|
| `ContainerFastModeProjectMountDirectory`<br/><br/>(replaces `DockerFastModeProjectMountDirectory`)|In **Fast Mode**, this property controls where the project output directory is volume-mounted into the running container.|C:\app (Windows) or /app (Linux)|1.23.0 for `ContainerFastModeProjectMountDirectory`<br/><br/>1.9.2 for `DockerFastModeProjectMountDirectory`|
| `ContainerBuildArguments`<br/><br/>(replaces `DockerfileBuildArguments`) | Additional arguments passed to the container build command. See [Docker build](https://docs.docker.com/engine/reference/commandline/build/) or [podman build](https://docs.podman.io/en/latest/markdown/podman-build.1.html). | Not applicable. |1.23.0 for `ContainerBuildArguements`<br/><br/>1.0.1872750 for `DockerfileBuildArguments`|
| `ContainerBuildContext`<br/><br/>(replaces `DockerfileContext`) | The default context used when building the Docker image, as a path relative to the Dockerfile. | Set by Visual Studio when Docker support is added to a project. In .NET Framework projects, set to "." (the project folder), and in .NET Core and .NET 5 and later projects, it's set to the relative path to the solution folder (usually ".."). |1.23.0 for `ContainerBuildContext`<br/><br/>1.0.1872750 for `DockerfileContext`|
| `ContainerFastModeStage`<br/><br/>(replaces `DockerfileFastModeStage`) | The Dockerfile stage (that is, target) to be used when building the image in debug mode. | First stage found in the Dockerfile (usually base) | |
| `ContainerIncludeDefaultImageLabels` (replaces: `DockerIncludeDefaultImageLabels`) | If true, include default image tags `com.microsoft.created-by=visual-studio` and `com.microsoft.visual-studio.project-name=$(MSBuildProjectName)`. | True | 1.23.0 for `ContainerIncludeDefaultImageLabels` |
| `ContainerLabelBuiltImages` (replaces `DockerLabelBuiltImages`)| Include labels on built images. If false, no labels are added, including user-defined labels. | True | 1.23.0 for `ContainerLabelBuiltImages` |
| `ContainerPath`<br/><br/>(replaces `DockerfileFile`) | Describes the default Dockerfile to use to build/run the container for the project. | Dockerfile |1.23.0 for `ContainerPath`<br/><br/>1.0.1872750 for ``ContainerPath`|
| `ContainerRepository`<br/><br/>(replaces `DockerRepository`) | The repository to use in the label, for example `webapplication1` in the label `webapplication1:dev`. | The assembly name. | 1.23.0 for `ContainerRepository` |
| `ContainerImageTag` or `ContainerImageTags`<br/><br/>(replaces `DockerfileTag`) | The tag to use when building the Docker image. In debugging, a ":dev" is appended to the tag. | Assembly name after stripping nonalphanumeric characters with the following rules: <br/> If the resultant tag is all numeric, then "image" is inserted as a prefix (for example, image2314) <br/> If the resultant tag is an empty string, then "image" is used as the tag. |1.23.0 for `ContainerImageTag`, `ContainerImageTags`<br/><br/>1.0.1872750 for `DockerfileTag`.|
| `DockerDebuggeeArguments`<br/><br/>(obsolete, use `commandLineArgs` in *launchsettings.json*) | When debugging, the debugger is instructed to pass these arguments to the launched executable. | - |1.7.8|
| `DockerDebuggeeProgram`<br/><br/>(obsolete, use `executablePath` in *launchsettings.json*) | When debugging, the debugger is instructed to launch this executable. | - |1.7.8|
| `DockerDebuggeeKillProgram` | This command is used to kill the running process in a container. | - |1.7.8|
| `DockerDebuggeeWorkingDirectory`<br/><br/>(obsolete; use `workingDirectory` in *launchsettings.json*) | When debugging, the debugger is instructed to use this path as the working directory. | C:\app (Windows) or /app (Linux) |1.7.8|
| DockerDefaultTargetOS | The default target operating system used when building the Docker image. | Set by Visual Studio. |1.0.1985401|
| `DockerfileRunArguments`<br/><br/>(obsolete, use `containerRunArguments` in *launchsettings.json*) | Additional arguments passed to the [Docker run](https://docs.docker.com/engine/reference/commandline/run/) command. | Not applicable. |1.0.1872750|
| `DockerfileRunEnvironmentFiles`<br/><br/>(obsolete, use `containerRunEnvironmentFiles` in *launchsettings.json*) | Semicolon-delimited list of environment files applied during Docker run. | Not applicable. |1.0.1872750|

:::moniker-end

## Example

The following project file shows examples of some of these settings.

:::moniker range="visualstudio"
```xml
 <Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <UserSecretsId>8c7ab9a5-d578-4c40-8b6d-54d174002229</UserSecretsId>
    <DockerDefaultTargetOS>Linux</DockerDefaultTargetOS>
    <!-- In CI/CD scenarios, you might need to change the context. By default, Visual Studio uses the
         folder above the Dockerfile. The path is relative to the Dockerfile, so here the context is
         set to the same folder as the Dockerfile. -->
    <ContainerContext>.</ContainerContext>
    <!-- Set `docker run` arguments to mount a volume -->
    <ContainerRunArguments>-v $(MSBuildProjectDirectory)/host-folder:/container-folder:ro</ContainerRunArguments>
    <!-- Set `docker build` arguments to add a custom tag -->
    <ContainerBuildArguments>-t contoso/front-end:v2.0</ContainerBuildArguments>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.VisualStudio.Azure.Containers.Tools.Targets" Version="1.20.1" />
  </ItemGroup>

</Project>
```

> [!NOTE]
> The build context, which you can set by providing a value for `ContainerContext` (or `DockerfileContext`), is usually different in Visual Studio for projects targeting .NET Core (including .NET 5 and later) from what `docker build` uses when you run it from the command line. The departure from the behavior of `docker build` is necessary to ensure that build artifacts at the solution level can be included.
>
> When you call `docker build`, you always specify a build context, and you can optionally specify a path to the Dockerfile. The default is that the Dockerfile is in the root of the context, but you can use the `-f` flag to specify an alternate location. For example, you can build with `docker build -f Dockerfile ..` from the project directory, or `docker build -f ProjectName/Dockerfile .` from the solution directory.
:::moniker-end
:::moniker range="<=vs-2022"
```xml
 <Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <UserSecretsId>8c7ab9a5-d578-4c40-8b6d-54d174002229</UserSecretsId>
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
    <PackageReference Include="Microsoft.VisualStudio.Azure.Containers.Tools.Targets" Version="1.20.1" />
  </ItemGroup>

</Project>
```

> [!NOTE]
> The Docker context, which you can set by providing a value for `DockerfileContext`, is usually different in Visual Studio for projects targeting .NET Core (including .NET 5 and later) from what `docker build` uses when you run it from the command line. The departure from the behavior of `docker build` is necessary to ensure that build artifacts at the solution level can be included.
>
> When you call `docker build`, you always specify a build context, and you can optionally specify a path to the Dockerfile. The default is that the Dockerfile is in the root of the context, but you can use the `-f` flag to specify an alternate location. For example, you can build with `docker build -f Dockerfile ..` from the project directory, or `docker build -f ProjectName/Dockerfile .` from the solution directory.
:::moniker-end

## Next steps

For information on MSBuild properties generally, see [MSBuild Properties](../msbuild/msbuild-properties.md).

## See also

[Docker Compose build properties](docker-compose-properties.md)

[Container Tools launch settings](container-launch-settings.md)

[MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md)
