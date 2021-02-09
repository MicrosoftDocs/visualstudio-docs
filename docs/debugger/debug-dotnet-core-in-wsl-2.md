---
title: "Debug .NET Core apps in WSL 2"
description: Learn to run and debug your .NET Core apps in WSL 2 without leaving Visual Studio.
ms.date: "01/25/2021"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debugging, linux"
  - "debugging, wsl2"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
monikerRange: '>= vs-2019'
ms.workload:
  - "multiple"
---

# Debug .NET Core Apps in WSL 2 with Visual Studio

You can easily run and debug your .NET Core apps in Linux without leaving Visual Studio using WSL 2. If you are a cross-platform developer, you can use this method as a simple way to test more of your target environments.

For a Windows .NET user targeting Linux, WSL 2 lives in a sweet spot between production realism and productivity. In Visual Studio, you can already debug in a remote Linux environment using the [remote debugger](../debugger/remote-debugging-dotnet-core-linux-with-ssh.md), or with containers using the [Container Tools](../containers/overview.md). When production realism is your main concern, you should use one of those options. When an easy and fast inner-loop is more important, WSL 2 is a great option.

You don’t have to choose just one method! You can have a launch profile for Docker and WSL 2 in the same project and pick whichever is appropriate for a particular run. And once your app is deployed, you can always use the remote debugger to attach to it if there's an issue.

## Prerequisites

- Visual Studio 2019 v16.9 Preview 1 or later versions with the .NET Core Debugging with WSL 2 optional component.

  The optional component is included by default with the .NET Core cross-platform or the ASP.NET and web development workloads. You must install one or both of these workloads.

- Install [WSL 2](/windows/wsl/about).

- Install the [distribution](https://aka.ms/wslstore) of your choice.

## Start debugging with WSL 2

1. After you've installed the required components, open an ASP.NET Core web app or .NET Core console app in Visual Studio You’ll see a new Launch Profile named WSL 2:

   ![WSL 2 launch profile in the launch profile list](media/linux-wsl2-debugging-select-launch-profile.png)

1. Select this profile to add it to your *launchSettings.json*.

   Some of the key attributes in the file are shown in the following example.

    ```json
    "WSL 2": {
        "commandName": "WSL2",
        "launchBrowser": true,
        "launchUrl": "https://localhost:5001",
        "environmentVariables": {
            "ASPNETCORE_URLS": "https://localhost:5001;http://localhost:5000",
            "ASPNETCORE_ENVIRONMENT": "Development"
        },
        "distributionName": ""
    }
    ```

   Once you select the new profile, the extension checks that your WSL 2 distribution is configured to run .NET Core apps, and helps you install any missing dependencies. Once you've installed these dependencies, you are ready to debug in WSL 2.

1. Start debugging as normal, and your app will run in your default WSL 2 distribution.

   An easy way to verify that you're running in Linux is to check the value of `Environment.OSVersion`.

>[!NOTE]
> Only Ubuntu and Debian have been tested and are supported. Other distributions supported by .NET Core should work but require manually installing the [.NET Core Runtime](https://aka.ms/wsldotnet) and [Curl](https://curl.haxx.se/).

## Choose a specific distribution

By default, the WSL 2 launch profile uses the default distribution as set in *wsl.exe*. If you want your launch profile to target a specific distribution, regardless of that default, you can modify your launch profile. For example, if you're debugging a web app and want to test it on Ubuntu 20.04, your launch profile would look like:

```json
"WSL 2": {
    "commandName": "WSL2",
    "launchBrowser": true,
    "launchUrl": "https://localhost:5001",
    "environmentVariables": {
        "ASPNETCORE_URLS": "https://localhost:5001;http://localhost:5000",
        "ASPNETCORE_ENVIRONMENT": "Development"
    },
    "distributionName": "Ubuntu-20.04"
}
```

## Target multiple distributions

Going one step further, if you are working on an application that needs to run in multiple distributions and you want a quick way to test on each of them, you can have multiple launch profiles. For instance, if you need to test your console app on Debian, Ubuntu 18.04, and Ubuntu 20.04, you could use the following launch profiles:

```json
"WSL 2 : Debian": {
    "commandName": "WSL2",
    "distributionName": "Debian"
},
"WSL 2 : Ubuntu 18.04": {
    "commandName": "WSL2",
    "distributionName": "Ubuntu-18.04"
},
"WSL 2 : Ubuntu 20.04": {
    "commandName": "WSL2",
    "distributionName": "Ubuntu-20.04"
}
```

With these launch profiles, you can easily switch back and forth between your target distributions, all without leaving the comfort of Visual Studio.

![Multiple WSL 2 launch profiles in the launch profile list](media/linux-wsl2-debugging-switch-target-distribution.png)

## WSL settings in the launch profile

The following table shows the settings that are supported in the launch profile.

|Name|Default|Purpose|Supports Tokens?|
|-|-|-|-|
|executablePath|dotnet|The executable to run|Yes|
|commandLineArgs|The value of the MSBuild property TargetPath mapped to the WSL environment|Command line arguments passed to executablePath|Yes|
|workingDirectory|For console apps: {*OutDir*}</br>For web apps: {*ProjectDir*}|The working directory in which to start debugging|Yes|
|environmentVariables||Key Value pairs of environment variables to set for the debugged process.|Yes|
|setupScriptPath||Script to be run before debugging. Useful for running scripts like ~/.bash_profile.|Yes|
|distributionName||Name of the WSL distribution to use.|No|
|launchBrowser|false|Whether or not to launch a browser|No|
|launchUrl||Url to launch if launchBrowser is true|No|

Supported tokens:

{*ProjectDir*} - The path to the project directory

{*OutDir*} - The value of the MSBuild property `OutDir`

>[!NOTE]
> All paths are for WSL not Windows.
