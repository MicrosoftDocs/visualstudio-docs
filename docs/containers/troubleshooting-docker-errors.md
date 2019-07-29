---
title: Troubleshooting Docker client errors on Windows | Microsoft Docs
description: Troubleshoot problems you encounter when using Visual Studio to create and deploy web apps to Docker on Windows by using Visual Studio.
ms.technology: vs-azure
author: ghogen
manager: jillfra
ms.custom: seodec18
ms.assetid: 346f70b9-7b52-4688-a8e8-8f53869618d3
ms.devlang: dotnet
ms.topic: conceptual
ms.workload: multiple
ms.date: 10/13/2017
ms.author: ghogen
---
# Troubleshoot Visual Studio development with Docker

When you're working with Visual Studio Container Tools, you may encounter issues while building or debugging your application. Below are some common troubleshooting steps.

## Volume sharing is not enabled. Enable volume sharing in the Docker CE for Windows settings  (Linux containers only)

To resolve this issue:

1. Right-click **Docker for Windows** in the notification area, and then select **Settings**.
1. Select **Shared Drives** and share the system drive along with the drive where the project resides.

> [!NOTE]
> If files appear shared, you may still need to click the "Reset credentials..." link at the bottom of the dialog in order to re-enable volume sharing. To continue after you reset credentials, you might have to restart Visual Studio.

![shared drives](media/troubleshooting-docker-errors/shareddrives.png)

> [!TIP]
> Visual Studio versions later than Visual Studio 2017 version 15.6 prompt when **Shared Drives** aren't configured.

### Container type

When adding Docker support to a project, you choose either a Windows or a Linux container. The Docker host must be running the same container type. To change the container type in the running Docker instance, right-click the System Tray's Docker icon and choose **Switch to Windows containers...** or **Switch to Linux containers...**.

## Unable to start debugging

One reason could be related to having stale debugging components in your user profile folder. Execute the following commands to remove these folders so that the latest debugging components are downloaded on the next debug session.

- del %userprofile%\vsdbg
- del %userprofile%\onecoremsvsmon

## Errors specific to networking when debugging your application

Try executing the script downloadable from [Cleanup Container Host Networking](https://github.com/MicrosoftDocs/Virtualization-Documentation/tree/master/windows-server-container-tools/CleanupContainerHostNetworking),
which will refresh the network-related components on your host machine.

## Mounts denied

When using Docker for macOS, you might encounter an error referencing the folder /usr/local/share/dotnet/sdk/NuGetFallbackFolder. Add the folder to the File Sharing tab in Docker

## Docker users group

You might encounter the following error in Visual Studio when working with containers:

```
The current user must be in the 'docker-users' group to use Docker Desktop. 
Add yourself to the 'docker-users' group and then log out of Windows.
```

You must be a member of the 'docker-users' group in order to have permissions to work with Docker containers.  To add yourself to the group in Windows 10, follow these steps:

1. From the Start menu, open **Computer Management**.
1. Expand **Local Users and Groups**, and choose **Groups**.
1. Find the **docker-users** group, right-click and choose **Add to group**.
1. Add your user account or accounts.
1. Sign out and sign back in again for these changes to take effect.

You can also use the `net localgroup` command at the Administrator command prompt to add users to specific groups.

```cmd
net localgroup docker-users DOMAIN\username /add
```

In PowerShell, use the [Add-LocalGroupMember](/powershell/module/microsoft.powershell.localaccounts/add-localgroupmember) function.

## Microsoft/DockerTools GitHub repo

For any other issues you encounter, see  [Microsoft/DockerTools](https://github.com/microsoft/dockertools/issues) issues.