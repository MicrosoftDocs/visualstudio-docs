---
title: Docker Compose build settings
author: ghogen
description: Learn how to edit the Docker Compose build properties to customize how Visual Studio builds and runs a Docker Compose application.
ms.custom: SEO-VS-2020
ms.author: ghogen
ms.date: 08/12/2019
ms.technology: vs-azure
ms.topic: reference
---
# Docker Compose build properties

In addition to the properties that control individual Docker projects, described in [Container Tools build properties](container-msbuild-properties.md), you can also customize how Visual Studio builds your Docker Compose projects by setting the Docker Compose properties that MSBuild uses to build your solution. You can also control how the Visual Studio debugger runs your Docker Compose apps by setting file labels in Docker Compose configuration files.

## How to set the MSBuild properties

To set the value of a property, edit the project file. For Docker Compose properties, this project file is the one with a .dcproj extension, unless otherwise indicated in the table in the next section. For example, suppose you want to specify to launch the browser when you start debugging. You can set the `DockerLaunchAction` property in the .dcproj project file as follows.

```xml
<PropertyGroup>
   <DockerLaunchAction>LaunchBrowser</DockerLaunchAction>
</PropertyGroup>
```

You can add the property setting to an existing `PropertyGroup` element, or if there isn't one, create a new `PropertyGroup` element.

## Docker Compose MSBuild properties

The following table shows the MSBuild properties available for Docker Compose projects.

| Property name | Location | Description | Default value  |
|---------------|----------|-------------|----------------|
|AdditionalComposeFilePaths|dcproj|Specifies additional compose files in a semicolon-delimited list to be sent out to docker-compose.exe for all commands. Relative paths from the docker-compose project file (dcproj) are allowed.|-|
|DockerComposeBaseFilePath|dcproj|Specifies the first part of the filenames of the docker-compose files, without the *.yml* extension. For example: <br>1.	DockerComposeBaseFilePath = null/undefined: use the base file path *docker-compose*, and files will be named *docker-compose.yml* and *docker-compose.override.yml*<br>2.	DockerComposeBaseFilePath = *mydockercompose*: files will be named *mydockercompose.yml* and *mydockercompose.override.yml*<br> 3.	DockerComposeBaseFilePath = *..\mydockercompose*: files will be up one level. |docker-compose|
|DockerComposeBuildArguments|dcproj|Specifies the extra parameters to pass to the `docker-compose build` command. For example, `--parallel --pull` |
|DockerComposeDownArguments|dcproj|Specifies the extra parameters to pass to the `docker-compose down` command. For example, `--timeout 500`|-|
|DockerComposeProjectName| dcproj | If specified, overrides the project name for a docker-compose project. | "dockercompose" + auto-generated hash |
|DockerComposeProjectPath|csproj or vbproj|The relative path to the docker-compose project (dcproj) file. Set this property when publishing the service project to find the associated image build settings stored in the docker-compose.yml file.|-|
|DockerComposeUpArguments|dcproj|Specifies the extra parameters to pass to the `docker-compose up` command. For example, `--timeout 500`|-|
|DockerDevelopmentMode|dcproj| Controls whether "build-on-host" optimization ("Fast Mode" debugging) is enabled.  Allowed values are **Fast** and **Regular**. | Fast |
|DockerLaunchAction| dcproj | Specifies the launch action to perform on F5 or Ctrl+F5.  Allowed values are None, LaunchBrowser, and LaunchWCFTestClient.|None|
|DockerLaunchBrowser| dcproj | Indicates whether to launch the browser. Ignored if DockerLaunchAction is specified. | False |
|DockerServiceName| dcproj|If DockerLaunchAction or DockerLaunchBrowser are specified, then DockerServiceName is the name of the service that should be launched.  Use this property to determine which of the potentially many projects that a docker-compose file can reference will be launched.|-|
|DockerServiceUrl| dcproj | The URL to use when launching the browser.  Valid replacement tokens are "{ServiceIPAddress}", "{ServicePort}", and "{Scheme}".  For example: {Scheme}://{ServiceIPAddress}:{ServicePort}|-|
|DockerTargetOS| dcproj | The target OS used when building the Docker image.|-|

## Example

If you change the location of the docker compose files, by setting `DockerComposeBaseFilePath` to a relative path, then you also need to make sure that the build context is changed so that it references the solution folder. For example, if your docker compose file is a folder called *DockerComposeFiles*, then docker compose file should set the build context to ".." or "../..", depending on where it is relative to the solution folder.

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

## Docker Compose override file

You can  override certain settings by placing a file named *docker-compose.vs.debug.yml* (for the **Debug** configuration) or *docker-compose.vs.release.yml* (for the **Release** configuration) in the same directory as your *docker-compose.yml* file. 

### Docker Compose file labels

 In this file, you can define override-specific labels as follows:

```yml
services:
  webapplication1:
    labels:
      com.microsoft.visualstudio.debuggee.workingdirectory: "C:\\my_app_folder"
```

Use double quotes around the values, as in the preceding example, and use the backslash as an escape character for backslashes in paths.

|Label name|Description|
|----------|-----------|
|com.microsoft.visualstudio.debuggee.arguments|The arguments passed to the program when starting debugging. For .NET Core apps, these arguments are typically additional search paths for NuGet packages followed by the path to the project's output assembly.|
|com.microsoft.visualstudio.debuggee.program|The program launched when starting debugging. For .NET Core apps, this setting is typically **dotnet**.|
|com.microsoft.visualstudio.debuggee.workingdirectory|The directory used as the starting directory when starting debugging. This setting is typically */app* for Linux containers, or *C:\app* for Windows containers.|
|com.microsoft.visualstudio.debuggee.killprogram|This command is used to stop the debuggee program that's running inside of the container (when necessary).|

### Customize the Docker build process

You can declare which stage to build in your Dockerfile by using the `target` setting in the `build` attribute. This override can be used in both the *docker-compose.vs.debug.yml* or *docker-compose.vs.release.yml* 

```yml
services:
  webapplication1:
    build: 
      target: customStage
    labels:
      ...
```

> **Note:** If you do not add a *docker-compose.vs.release.yml* or *docker-compose.vs.debug.yml* file, then Visual Studio generates one based on default settings.

### Customize the app startup process

You can run a command or custom script before launching your app by using the `entrypoint` setting, and making it dependent on the configuration. For example, if you need to set up a certificate only in **Fast** mode by running `update-ca-certificates`, but not in **Regular** mode, you could add the following code in **only** *docker-compose.vs.debug.yml*:

```yml
services:
  webapplication1:
    entrypoint: "sh -c 'update-ca-certificates && tail -f /dev/null'"
    labels:
      ...
```

> **Note:** If you do not add a *docker-compose.vs.release.yml* or *docker-compose.vs.debug.yml* file, then Visual Studio generates one based on default settings.

## Next steps

For information on MSBuild properties generally, see [MSBuild Properties](../msbuild/msbuild-properties.md).

## See also

[Container Tools build properties](container-msbuild-properties.md)

[Container Tools launch settings](container-launch-settings.md)

[MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md)
