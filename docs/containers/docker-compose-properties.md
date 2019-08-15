---
title: Visual Studio Container Tools Docker Compose build settings
author: ghogen
description: Overview of the Container Tools build process
ms.author: ghogen
ms.date: 08/12/2019
ms.technology: vs-azure
ms.topic: conceptual
---
# Docker Compose build properties

In addition to the properties that control individual Docker projects, described in [Container Tools build properties](container-msbuild-properties.md), you can also customize how Visual Studio builds your Docker Compose projects by setting the Docker Compose properties that MSBuild uses to build your solution. You can also control how the Visual Studio debugger runs your Docker Compose apps by setting file labels in Docker Compose configuration files.

## How to set the MSBuild properties

To set the value of a property, edit the project file. For Docker Compose properties, this is the project file with the .dcproj extension, unless otherwise indicated in the table in the next section. For example, suppose you want to specify to launch the browser when you start debugging. You can set the `DockerLaunchAction` property in the .dcproj project file as follows.

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
|DockerComposeBuildArguments|dcproj|Specifies the extra parameters to pass to the `docker-compose build` command. For example, `--parallel --pull` |
|DockerComposeDownArguments|dcproj|Specifies the extra parameters to pass to the `docker-compose down` command. For example, `--timeout 500`|-|  
|DockerComposeProjectPath|csproj or vbproj|The relative path to the docker-compose project (dcproj) file. This is used when publishing the service project to find the associated image build settings stored in the docker-compose.yml file.|-|
|DockerComposeUpArguments|dcproj|Specifies the extra parameters to pass to the `docker-compose up` command. For example, `--timeout 500`|-|
|DockerLaunchAction| dcproj | Specifies the launch action to perform on F5 or Ctrl+F5.  Allowed values are None, LaunchBrowser, and LaunchWCFTestClient|None|
|DockerLaunchBrowser| dcproj | Indicates whether to launch the browser. Ignored if DockerLaunchAction is specified. | False |
|DockerServiceName| dcproj|If DockerLaunchAction or DockerLaunchBrowser are specified, then DockerServiceName is the name of the service that should be launched.  This is used to determine which of the potentially many projects that a docker-compose file can reference will be launched.|-|
|DockerServiceUrl| dcproj | The URL to use when launching the browser.  Valid replacement tokens are "{ServiceIPAddress}", "{ServicePort}", and "{Sheme}".  For example: {Scheme}://{ServiceIPAddress}:{ServicePort}|-|
|DockerTargetOS| dcproj | The target OS used when building the Docker image.|-|

> [!NOTE]
> DockerComposeBuildArguments, DockerComposeDownArguments, and DockerComposeUpArguments are new in Visual Studio 2019 version 16.3 Preview 3.

## Docker Compose file labels

You can also override certain settings by placing a file named *docker-compose.vs.debug.yml* (for **Debug** configuration) or *docker-compose.vs.release.yml* (for **Release** configuration) in the same directory as your *docker-compose.yml* file.  In this file, you can specify settings as follows:

```yml
services:
  webapplication1:
    labels:
      com.microsoft.visualstudio.debuggee.workingdirectory: "C:\\my_app_folder"
```

Use double quotes around the values, as in the preceding example, and use the backslash as an escape character for backslashes in paths.

|Label name|Description|
|----------|-----------|
|com.microsoft.visualstudio.debuggee.arguments|The arguments passed to the program when starting debugging. For .NET Core apps, this is typically a set of additional search paths for NuGet packages followed by the path to the project's output assembly.|
|com.microsoft.visualstudio.debuggee.killprogram|This command is used to stop the debuggee program that's running inside of the container (when necessary).|
|com.microsoft.visualstudio.debuggee.program|The program launched when starting debugging. For .NET Core apps, this is typically **dotnet**.|
|com.microsoft.visualstudio.debuggee.workingdirectory|The directory used as the starting directory when starting debugging. This is typically */app* for Linux containers, or *C:\app* for Windows containers.|

## Next steps

For information on MSBuild properties generally, see [MSBuild Properties](../msbuild/msbuild-properties.md).

## See also

[Container Tools build properties](container-msbuild-properties.md)

[Container Tools launch settings](container-launch-settings.md)

[MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md)