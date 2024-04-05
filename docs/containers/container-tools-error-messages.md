---
title: Error codes for Visual Studio Container Tools
author: ghogen
description: Information and troubleshooting suggestions for the error codes and error messages used by Visual Studio Container Tools.
ms.author: ghogen
ms.date: 07/20/2022
ms.subservice: container-tools
ms.topic: error-reference
f1_keywords:
  - CTC1001
  - CTC1002
  - CTC1003
  - CTC1004
  - CTC1005
  - CTC1006
  - CTC1007
  - CTC1008
  - CTC1009
  - CTC1010
  - CTC1011
  - CTC1012
  - CTC1013
  - CTC1014
  - CTC1019
  - CTC1020
  - CTC1021
  - CTC1022
  - CTC1023
  - CTC1024
  - CTC1025
  - CTC1026
  - CTC1027
  - CTC1028
  - CTC1029
  - CTC1030
  - CTC1031
  - CTC1032
  - CTC1033
  - CTC1034
  - CTC1035
  - CTC1036
  - CTC1037
  - CTC1038
  - CTC1039
  - CTC1040
  - CTC1041
  - DTP1001
  - DTP1002
  - DTP1003
  - DTP1004
  - DT1001
  - DT1002
  - DT1003
  - DT1004
  - DT1005
  - DT1006
  - DT1007
  - DT1008
  - DT1009
  - DT1010
  - DT1011
  - DT1012
  - DT1013
  - DT1014
  - DT1015
  - DT1016
  - DT1017
  - DT1018
  - DT1019
  - CTP1001
  - CTP1002
  - CTP1003
  - CTP1004
  - CTP1005
  - CTP1006
  - CTP1007
  - CTP1008
  - CTP1009
---

# Container Tools error messages

This article lists the error codes used by Visual Studio Container Tools and, where possible, provides suggestions on how to resolve the issues.

## Container Tools error codes

| Code | Description | Notes | Fix |
| - | - | - | - |
| CTC1001 | Docker volume sharing is not enabled | This error happens when file sharing is not enabled. File sharing allows local directories on Windows to be shared with Linux containers. This is applicable only in Linux containers that are using Hyper-V mode. See [Docker Desktop for Windows user manual]() or [Docker Documentation]() for more details.  | Enable Docker file sharing. |
| CTC1002 | Docker Desktop is not installed |   | Install Docker Desktop. |
| CTC1003 | Docker Desktop is not running |   | Start Docker Desktop. |
| CTC1004 | Unable to get Docker server OS |   | Specify the default `targetOS` in the project file; for example, `<DockerDefaultTargetOS> Linux </DockerDefaultTargetOS>`). |
| CTC1005 | Docker Desktop's operating system mode does not match the project's target operating system |   | Switch the Docker Desktop operating system mode to match the project's target operating system. |
| CTC1006 | Docker Desktop is running but is in an error state and should be restarted. |   | Restart Docker Desktop and make sure Docker Desktop is functioning properly. |
| CTC1007 | Downloading `vsdbg` failed but an existing copy was found on disk | This is just a warning and the debugging will not fail. This warning happens when the latest version of `vsdbg` fails to download but an existing copy was found and being used. | No action needed from user. |
| CTC1008 | Downloading `vsdbg` failed and no existing copy was found on disk | **F5** failed to download `vsdbg.exe`. | Check your Internet connection. |
| CTC1009 | Drive-sharing credentials are possibly invalid |   | This might be caused by the Shared Drives credentials used by Docker Desktop being out of date. Try resetting the credentials in the **Shared Drives** page of the Docker Desktop settings, and then restarting Docker. |
| CTC1010 | The current user is not in the `docker-users` group |   | The current user is not in the `docker-users` group. Add yourself to the `docker-users` group and then log out and back in to Windows. |
| CTC1011 | Ports are in use | A container is trying to use a specific host port that is already in use. | Stop the previous container or other application that uses this port or update the application to use different port. |
| CTC1012 | Not used |   |   |
| CTC1013 | This current type is not supported or the dotnet core version is not supported   |   |   |
| CTC1014 | Error building dockerFile |   | Unable to build the Dockerfile. Correct the error in the Dockerfile and try again. |
| CTC1019 | Unused |   |   |
| CTC1020 | UnauthorizedAccessException thrown while trying to start the container |   |   |
| CTC1021 | SecurityException thrown while trying to start the container  |   |   |
| CTC1022 | Unused |   |   |
| CTC1023 | Either file or directory not found. | This could be either dockerfile, Docker context or project file not found. |   |
| CTC1024 | IOException thrown while trying to start the container  |   |   |
| CTC1025 | An error occurred while trying to pull a Docker image. |   | See the **Output** window for a more detailed error on why the `docker pull` command failed. |
| CTC1026 | Launch setting parsing error. | Unable to find the IISExpress settings or parsing failure while parsing the IISExpress setting in the *launchSettings.json* file.  | Make sure the IISExpress settings in *launchSettings.json* is valid. |
| CTC1027 | Error running the `dev-certs` tool. | An error occurred while running the `dev-certs` tool to trust the ASP.NET Core development certificate. | See the **Output** window for more detailed error. |
| CTC1028 | Invalid Launch URL | The application URL that will be launched when the debugging starts is invalid | Ensure the `launchUrl` specified in the Docker launch settings in *launchSettings.json* |
| CTC1029 | Docker execution failed | An error occurred while trying to run a command to start the application process inside the container. | See the **Output** window for more detailed error. |
| CTC1030 | Internal error | An unknown internal error occurred. | Please open a bug in [Visual Studio Feedback](). |
| CTC1031 | Unsupported OS |   | Likely using .NET Framework project in a Linux container. Switch to a Windows container and try again. |
| CTC1032 | Unused |   |   |
| CTC1033 | Unused |   |   |
| CTC1034 | Unused |   |   |
| CTC1035 | Docker Desktop download failed | Unable to download Docker Desktop installer (`.msi`) while trying to install Docker Desktop. | Check your Internet connection, and that no firewall is blocking the file download. |
| CTC1036 | Docker Desktop installation failed |   | Correct the error in the installer and manually install Docker Desktop. Or, reopen the solution and Visual Studio will try to install Docker Desktop again. |
| CTC1037 | Blazor Manifest file access error | Rewriting Blazor static web assets file failed when debugging the Blazor application. | See the **Output** window for more detailed error. |
| CTC1038 | The container is absent or not running at the time of debugging |   | See the **Output** window for more detail on why the container failed to start. |
| CTC1039 | The binaries of the program to debug are not found at expected location in the container. |   |   |
| CTC1040 | The debugged program exited with an unexpected exit code |   | Unable to start the application process. See the **Output** window for more details. |
| CTC1041 | Incomplete Docker Desktop installation. |   | Docker Desktop does not appear to have finished installing. Please try rebooting, and if the issue persists, try repairing your Docker Desktop installation. |

## Docker-compose-specific error codes

| Code | Description | Notes | Fix |
| - | - | - | - |
| DTP1001 | Host port not found | In the Docker Compose project, the Service URL specifies the token `{ServicePort}`, but the container doesn't have any corresponding host port. | Ensure the container is started with a host port for the right URL scheme (`http` or `https`). |
| DTP1002 | Container not found | When debugging the Docker Compose project, the container was not started or container exited. | See the **Output** window for more detail on why the container is failed to start. |
| DTP1003 | No service found while debugging the Docker Compose project. |   | Ensure that the Docker Compose document has one or more dotnet service defined. |
| DTP1004 | Docker Compose scaffolding error |   | Try adding Docker Compose support again. |
| DT1001 | Debugging failed due to an error running Docker Compose command. | See the **Output** window for more detail on this error. |
| DT1002 | Invalid target OS | Unknown Dockerfile target OS specified in `DockerDefaultTargetOS` property. | Supported values are 'Windows' and 'Linux'. |
| DT1003 | An unexpected error while trying to execute a command. |   | See the **Output** window for more detail on this error. |
| DT1004 | Error in Docker Compose file |   | Check all Docker Compose documents and make sure they are valid. |
| DT1005 | Docker Compose command execution failure |   | See the **Output** window for more detail on this error. |
| DT1006 | The compose profile name used in the active launch profile is not found in the Docker Compose document. | For example, if the active launch profile is using compose profile called `p2` as shown here:<br/><br/>`"Docker Compose": {`<br/>&nbsp;&nbsp;`"commandName": "DockerCompose",`<br/>&nbsp;&nbsp;`"commandVersion": "1.0",`</br>&nbsp;&nbsp;`"composeProfile": {`</br>&nbsp;&nbsp;&nbsp;&nbsp;`"includes": [ `<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`"p2"`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`]`<br/>&nbsp;&nbsp;`}`<br/>`}`<br/><br/>but *docker-compose.yml* didn't define the profile `p2`, then you will see this error. | Update the launch profile to use the right compose profile or use the **Manage Docker Compose Launch Settings** dialog to update the launch settings. |
| DT1007 | Invalid service name in the active launch profile that uses compose profile. | For example, if the active launch profile is using compose profile `p1` and defines the service list for the compose profile `p1` as shown here:<br/><br/>`"Docker Compose": {`<br/>&nbsp;&nbsp;`"commandName": "DockerCompose",`<br/>&nbsp;&nbsp;`"commandVersion": "1.0",`<br/>&nbsp;&nbsp;`"composeProfile": {`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`"includes": [`<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`"p1"`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`],`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`"serviceActions": {`<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`"webapp2": "StartWithoutDebugging"`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`}`<br/>&nbsp;&nbsp;`}`<br/>`}`<br/>but *docker-compose.yml* doesn't define the service `webapp2`, then you see this error. | Update the launch profile to use the right service name or use the **Manage Docker Compose Launch Settings** dialog to update the launch settings. |
| DT1008 | Invalid service action in the active launch profile that uses compose profile. | For example, if the active launch profile is using compose profile `p1` and defines the wrong action (`wrongActionname`) for a service (`webapplication`).<br/>`"Docker Compose": {`&nbsp;&nbsp;`"commandName": "DockerCompose",`<br/>&nbsp;&nbsp;`"commandVersion": "1.0",`<br/>&nbsp;&nbsp;`"composeProfile": {`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`"includes": [`<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`"p1"`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`],`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`"serviceActions": {`<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`"webapp": "wrongActionname"`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`}`<br/>&nbsp;&nbsp;`}`<br/>`}`<br/>| Correct the service action to `StartWithoutDebugging`, which is the only valid action for service that uses a compose profile. |
| DT1009 | Active launch profile is using both `composeProfile` and `serviceActions`. | A Visual Studio launch profile can be defined either using compose profiles or picking and choosing a service list without using a compose profile; it can't be created using both. So if an active launch profile uses both as shown below, then you see this error.<br/>`"Docker Compose": {`<br/>&nbsp;&nbsp;`"commandName": "DockerCompose",`<br/>&nbsp;&nbsp;`"commandVersion": "1.0",`<br/>&nbsp;&nbsp;`"composeProfile": {`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`"includes": [`<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`"p1"`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`]`<br/>&nbsp;&nbsp;`},`<br/>&nbsp;&nbsp;`"serviceActions": {`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`"webapp": "StartWithoutDebugging"`<br/>&nbsp;&nbsp;`}`<br/>`}`| Use either `composeProfile` or `serviceActions` or use the **Manage Docker Compose Launch Settings** dialog to update the launch settings.|
| DT1010 | Invalid service name in the active launch profile | For example, if the active launch profile defines the `serviceActions` as shown here:<br/>`"Docker Compose": {`<br/>&nbsp;&nbsp;`"commandName": "DockerCompose",`<br/>&nbsp;&nbsp;`"commandVersion": "1.0",`<br/>&nbsp;&nbsp;`"serviceActions": {`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`"redis1": "StartWithoutDebugging",`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`"webapp8": "StartWithoutDebugging"`<br/>&nbsp;&nbsp;`}`<br/>`}`<br/>But the `docker-compose.yml` didn't define the service `redis1`, then you will see this error. | Update the launch profile to use the right service name or use the **Manage Docker Compose Launch Settings** dialog to update the launch settings. |
| DT1011 | Invalid service action in the active launch profile. | For example, if the active launch profile uses the wrong service action (`wrongAction`) as shown below, then you will see this error.<br/>`"Docker Compose": {`<br/>&nbsp;&nbsp;`"commandName": "DockerCompose",`<br/>&nbsp;&nbsp;`"commandVersion": "1.0",`<br/>&nbsp;&nbsp;`"serviceActions": {`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`"webapplication8": "wrongAction"`<br/>&nbsp;&nbsp;`}`<br/>`}`<br/>| Correct the service action to one of `DoNotStart`, `StartDebugging`, or `StartWithoutDebugging`. Or use **Manage Docker Compose Launch Settings** dialog to update the launch settings. |
| DT1012 | Invalid launch profile. Both `composeProfile` and `serviceActions` are missing. | A Visual Studio launch profile can be defined either using compose profiles or by picking and choosing a service list without using a compose profile. But the active launch profile is defined with none of them. | Use the **Manage Docker Compose Launch Settings** dialog to update the launch settings. |
| DT1013 | The active launch profile is not found |   | Ensure the active launch profile is defined in *launchSettings.json*. |
| DT1014 | Invalid profile version. | For example, if the active launch profile defines an unknown command version (10.0):<br/>`"Docker Compose":`<br/>&nbsp;&nbsp;`"commandName": "DockerCompose",`<br/>&nbsp;&nbsp;`"commandVersion": "10.0",`<br/>&nbsp;&nbsp;`"serviceActions": {`<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`"webapp8": "StartDebugging",`<br/>&nbsp;&nbsp;&nbsp;&nbsp;`"redis": "StartWithoutDebugging"`<br/>&nbsp;&nbsp;`}`<br/>`}`<br/>| Please see the error message for the supported `commandVersion`, or use the **Manage Docker Compose Launch Settings** dialog to update the launch settings. |
| DT1015 | Unsupported old profile version. |   | The profile version is no longer supported by the current Visual Studio. Please upgrade the profile to the latest supported version using the **Manage Docker Compose Launch Settings** dialog to update the launch settings. |
| DT1016 | Using profile from newer version of Visual Studio |   | The profile version is higher than the current supported version. Please upgrade the Visual Studio to the latest version. |
| DT1017 | Using profile from newer version of Visual Studio, but will continue to work | This is a warning message | The profile version is higher than the current supported version, but still compatible with the current version of Visual Studio, but might be missing some features. |
| DT1018 | Using old profile version, but compatible. | This is a warning message | The profile version is lower than the latest version, but still compatible. Some of the newer features might not work. Consider upgrading to the latest version of Visual Studio. |
| DT1019 | Unsupported compose v2 | You are using older version of Docker Compose v2 that doesn't support the compose profile. | Upgrade Docker Compose to the latest version. |

## Single-project-specific error codes

| Code | Description | Notes | Fix |
| - | - | - | - |
| CTP1001 | Unused | | |
| CTP1002 | Unused |   |   |
| CTP1003 | The container is absent or not running at the time of debugging |   | See the **Output** window for more detail on why the container is failed to start. |
| CTP1004 | Docker scaffolding error |   | Try adding Docker support again. |
| CTP1005 | Invalid target OS |   | Unknown Dockerfile target OS specified in `DockerDefaultTargetOS` property. Supported values are 'Windows' and 'Linux'. |
| CTP1006 | Failed to stop the application within the container. | This is just a warning. | Make sure the application is not in use. |
| CTP1007 | Unused |   |   |
| CTP1008 | Unused |   |   |
| CTP1009 | Failed to download Azure Functions CLI |   | See the **Output** window for more detail. |
