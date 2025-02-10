---
title: Docker Compose build settings
author: ghogen
description: Learn how to edit the Docker Compose build properties to customize how Visual Studio builds and runs a Docker Compose application.
ms.author: ghogen
ms.date: 12/19/2024
ms.subservice: container-tools
ms.topic: reference
---

# Docker Compose build properties

In addition to the properties that control individual Docker projects, described in [Container Tools build properties](container-msbuild-properties.md), you can also customize how Visual Studio builds your Docker Compose projects by setting the Docker Compose properties that MSBuild uses to build your solution. You can also control how the Visual Studio debugger runs your Docker Compose apps by setting file labels in Docker Compose configuration files.

## How to set the MSBuild properties

To set the value of a property, edit the project file. For Docker Compose properties, this project file is the one with a `.dcproj` extension, unless otherwise indicated in the table in the next section. For example, suppose you want to specify to launch the browser when you start debugging. You can set the `DockerLaunchAction` property in the `.dcproj` project file as follows.

```xml
<PropertyGroup>
   <DockerLaunchAction>LaunchBrowser</DockerLaunchAction>
</PropertyGroup>
```

You can add the property setting to an existing `PropertyGroup` element, or if there isn't one, create a new `PropertyGroup` element.

## Docker Compose MSBuild properties

The following table shows the MSBuild properties available for Docker Compose projects (`.dcproj` files).

| Property name | Description |
|---------------|-------------|
|AdditionalComposeFilePaths|Specifies additional compose files in a semicolon-delimited list to be sent out to docker-compose.exe for all commands. Relative paths from the Docker Compose project file (dcproj) are allowed.|
|DependencyAwareStart|Enables a different way of launching the app that supports the Docker Compose properties [`depends_on`](https://docs.docker.com/reference/compose-file/services/#depends_on) and [`healthcheck`](https://docs.docker.com/reference/compose-file/services/#healthcheck), which control service startup order and health checks.<br/><br/>Requires Visual Studio 17.13 or later.<br/><br/>Default value: False |
|DockerComposeBaseFilePath|Specifies the first part of the filenames of the Docker Compose files, without the `.yml` extension. For example: <br>1. DockerComposeBaseFilePath = null/undefined: use the base file path `docker-compose`, and files will be named *docker-compose.yml* and *docker-compose.override.yml*.<br>2. DockerComposeBaseFilePath = *mydockercompose*: files will be named *mydockercompose.yml* and *mydockercompose.override.yml*.<br> 3. DockerComposeBaseFilePath = *..\mydockercompose*: files will be up one level.<br/><br/>Default value: `docker-compose`|
|DockerComposeBuildArguments|Specifies the extra parameters to pass to the `docker-compose build` command. For example, `--parallel --pull`. |
|DockerComposeDownArguments|Specifies the extra parameters to pass to the `docker-compose down` command. For example, `--timeout 500`.|
| DockerComposeEnvFilePath | The relative path to an .env file that's passed to `docker compose` commands via `--env-file`. See [Use the env_file attribute](https://docs.docker.com/compose/how-tos/environment-variables/set-environment-variables/#use-the-env_file-attribute).<br/><br/>Default value:  Empty |
|DockerComposeProjectName | If specified, overrides the project name for a Docker Compose project. <br/><br/>Default value:  "dockercompose" + auto-generated hash |
|DockerComposeProjectsToIgnore| Specifies projects to be ignored by Docker Compose tools during debug. This property can be used for any project. File paths can be specified one of two ways: <br> 1. Relative to dcproj. For example, `<DockerComposeProjectsToIgnore> path\to\AngularProject1.csproj </DockerComposeProjectsToIgnore>`. <br> 2. Absolute paths.<br> **Note**: The paths should be separated by the delimiter character `;`.|
|DockerComposeUpArguments|Specifies the extra parameters to pass to the `docker-compose up` command. For example, `--timeout 500`.|
|DockerDevelopmentMode | Controls whether the user project is built in the container. The allowed values of **Fast** or **Regular** control [which stages are built](https://aka.ms/containerfastmode) in a Dockerfile. The Debug configuration is Fast mode by default and Regular mode otherwise. <br/><br/>Default value:  Fast |
|DockerLaunchAction | Specifies the launch action to perform on F5 or Ctrl+F5. Allowed values are None, LaunchBrowser, and LaunchWCFTestClient.<br/><br/>Default value: None |
|DockerLaunchBrowser | Indicates whether to launch the browser. Ignored if DockerLaunchAction is specified. <br/><br/>Default value:  False |
|DockerServiceName| If DockerLaunchAction or DockerLaunchBrowser are specified, then DockerServiceName specifies which service referenced in the `docker-compose` file gets launched.|
|DockerServiceUrl | The URL to use when launching the browser. Valid replacement tokens are "{ServiceIPAddress}", "{ServicePort}", and "{Scheme}". For example: {Scheme}://{ServiceIPAddress}:{ServicePort}|
|DockerTargetOS | The target OS used when building the Docker image.|

In addition, the property `DockerComposeProjectPath` in a `.csproj` or `.vbproj` project file specifies the relative path to the Docker Compose project (`.dcproj`) file. Set this property when publishing the service project to find the associated image build settings stored in the *docker-compose.yml* file.

## Example

If you change the location of the `docker-compose` files, by setting `DockerComposeBaseFilePath` to a relative path, then you also need to make sure that the build context is changed so that it references the solution folder. For example, if your `docker-compose` file is a folder called *DockerComposeFiles*, then Docker Compose file should set the build context to ".." or "../..", depending on where it is relative to the solution folder.

```xml
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" Sdk="Microsoft.Docker.Sdk">
  <PropertyGroup Label="Globals">
    <ProjectVersion>2.1</ProjectVersion>
    <DockerTargetOS>Windows</DockerTargetOS>
    <ProjectGuid>154022c1-8014-4e9d-bd78-6ff46670ffa4</ProjectGuid>
    <DockerLaunchAction>LaunchBrowser</DockerLaunchAction>
    <DockerServiceUrl>{Scheme}://{ServiceIPAddress}{ServicePort}</DockerServiceUrl>
    <DockerServiceName>webapplication1</DockerServiceName>
    <DockerComposeBaseFilePath>DockerComposeFiles\mydockercompose</DockerComposeBaseFilePath>
    <AdditionalComposeFilePaths>AdditionalComposeFiles\myadditionalcompose.yml</AdditionalComposeFilePaths>
  </PropertyGroup>
  <ItemGroup>
    <None Include="DockerComposeFiles\mydockercompose.override.yml">
      <DependentUpon>DockerComposeFiles\mydockercompose.yml</DependentUpon>
    </None>
    <None Include="DockerComposeFiles\mydockercompose.yml" />
    <None Include=".dockerignore" />
  </ItemGroup>
</Project>
```

The *mydockercompose.yml* file should look like this, with the build context set to the relative path of the solution folder (in this case, `..`).

```yml
version: '3.4'

services:
  webapplication1:
    image: ${DOCKER_REGISTRY-}webapplication1
    build:
      context: ..
      dockerfile: WebApplication1\Dockerfile
```

> [!NOTE]
> DockerComposeBuildArguments, DockerComposeDownArguments, and DockerComposeUpArguments are new in Visual Studio 2019 version 16.3.

## Overriding Visual Studio's Docker Compose configuration

Typically *docker-compose.override.yml* is used to override certain settings in *docker-compose.yml*. Additionally, Visual Studio generates override files *docker-compose.vs.debug.g.yml* (for **Fast** mode) and *docker-compose.vs.release.g.yml* (for **Regular** mode) files with settings that are specific to running the application inside Visual Studio. You can override these Visual Studio settings by placing a file named *docker-compose.vs.debug.yml* (for **Fast** mode) or *docker-compose.vs.release.yml* (for **Regular** mode) in the same directory as your *docker-compose.yml* file. Right click the Docker Compose project and select **Open Folder in File Explorer** , then use **Add** > **Existing Item** to add the file to your Docker Compose project.

> [!TIP]
> To find out the default values for any of the Visual Studio settings, look in the intermediate output directory (for example, *obj/Docker*) for *docker-compose.vs.debug.g.yml* or *docker-compose.vs.release.g.yml*. These files are generated by Visual Studio and should not be modified.

### Docker Compose file labels

In *docker-compose.vs.debug.yml* or *docker-compose.vs.release.yml*, you can define override-specific labels as follows:

```yml
services:
  webapplication1:
    labels:
      com.microsoft.visualstudio.debuggee.workingdirectory: "C:\\my_app_folder"
```

Use double quotes around the values, as in the preceding example, and use the backslash as an escape character for backslashes in paths.

:::moniker range="<=vs-2019"
|Label name|Description|
|----------|-----------|
|com.microsoft.visualstudio.debuggee.program|The program launched when starting debugging. For .NET Core apps, this setting is typically **dotnet**.|
|com.microsoft.visualstudio.debuggee.arguments|The arguments passed to the program when starting debugging. For .NET Core apps, these arguments are typically additional search paths for NuGet packages followed by the path to the project's output assembly.|
|com.microsoft.visualstudio.debuggee.workingdirectory|The directory used as the starting directory when starting debugging. This setting is typically */app* for Linux containers, or *C:\app* for Windows containers.|
|com.microsoft.visualstudio.debuggee.killprogram|This command is used to stop the debuggee program that's running inside of the container (when necessary).|
:::moniker-end

:::moniker range=">=vs-2022"
|Label name|Description|
|----------|-----------|
|com.microsoft.visualstudio.debuggee.program|The program launched when starting debugging. For .NET Core apps, this setting is typically **dotnet**.|
|com.microsoft.visualstudio.debuggee.arguments|The arguments passed to the program when starting debugging. For .NET Core apps, these arguments are typically additional search paths for NuGet packages followed by the path to the project's output assembly.|
|com.microsoft.visualstudio.debuggee.workingdirectory|The directory used as the starting directory when starting debugging. This setting is typically */app* for Linux containers, or *C:\app* for Windows containers.|
|com.microsoft.visualstudio.debuggee.killprogram|This command is used to stop the debuggee program that's running inside of the container (when necessary).|
|com.microsoft.visualstudio.debuggee.noattach.program|The program launched when you use **Start without debugging** (**Ctrl**+**F5**) in an Azure functions project that runs in an [isolated process](/azure/azure-functions/dotnet-isolated-process-guide). Typically both **F5** and **Ctrl**+**F5** uses the same program, but if any project type like Azure Functions in an isolated process requires a different program than **F5**, then this will be used.|
|com.microsoft.visualstudio.debuggee.noattach.arguments|The arguments passed to the program when you use **Start without debugging** (**Ctrl**+**F5**) in an Azure functions project that runs in an isolated process.|
|com.microsoft.visual-studio.project-name|The name of the project, which helps Visual Studio find the project if the project is not in the same folder as the Dockerfile.|
:::moniker-end

### Customize the Docker build process

You can declare which stage to build in your Dockerfile by using the `target` setting in the `build` property. This override can be used in only the *docker-compose.vs.debug.yml* or *docker-compose.vs.release.yml*

```yml
services:
  webapplication1:
    build:
      target: customStage
    labels:
      ...
```

### Customize the app startup process

You can run a command or custom script before launching your app by using the `entrypoint` setting, and making it dependent on the `DockerDevelopmentMode`. For example, if you need to set up a certificate only in **Fast** mode by running `update-ca-certificates`, but not in **Regular** mode, you could add the following code in **only** *docker-compose.vs.debug.yml*:

```yml
services:
  webapplication1:
    entrypoint: "sh -c 'update-ca-certificates && tail -f /dev/null'"
    labels:
      ...
```

For more information, see [Container entry point](container-entry-point.md)

## Next steps

For information on MSBuild properties generally, see [MSBuild Properties](../msbuild/msbuild-properties.md).

## See also

[Container Tools build properties](container-msbuild-properties.md)

[Container Tools launch settings](container-launch-settings.md)

[Manage launch profiles for Docker Compose in Visual Studio](launch-profiles.md)

[MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md)
