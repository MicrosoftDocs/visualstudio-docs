---
title: Remote Testing in Visual Studio
description: Run remote tests in Visual Studio Test Explorer from remote containers, WSL2, or over SSH connections, and configure remote tests with a testenvironments.json file.
ms.date: 10/25/2023
ms.topic: how-to
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
monikerRange: '>= vs-2022'
---
# Remote Testing (experimental preview)

Remote testing enables developers to connect Visual Studio 2022 to remote environments for running and debugging tests. This functionality is useful for cross-platform developers who deploy code to multiple different target environments such as different Windows or Linux operating systems. For example, normally a developer pushes changes to a CI pipeline to get feedback from a test running on Linux. With the remote testing feature, you can run Linux tests right from Visual Studio by connecting the Test Explorer to a remote environment.

## Requirements

The following requirements apply to the experimental version of remote testing:

* You must be running Visual Studio 2022 Update 17.0 Preview 3 or later.

* Currently, the feature supports .NET and .NET Framework tests only.

   * If you're interested in remote testing support for other languages, you can [file a suggestion](../ide/suggest-a-feature.md) or **upvote** an existing suggestion. [Supporting C++ remote testing](https://developercommunity.visualstudio.com/t/run-c-unit-tests-on-linux-with-visual-studio/1403357).

* Currently, the feature supports Windows, Ubuntu, and Debian images on the remote environment. For .NET Framework, only remote Windows environments are supported.

* Currently, the bulk of the provisioning of the environment is left to the user's specification.

   The user must install the necessary dependencies in the target environment. For example, if your tests target .NET 6.0, you need to make sure the container has .NET 6.0 installed via your Dockerfile. There might be a prompt to install .NET Core on the remote environment, which is needed to run and discover tests remotely.

* Plan to monitor your connection status to the remote environment by using the **Output** > **Tests** pane.

   For example, if the container stops, a message appears in the **Output** > **Tests** pane. The feature might not detect all scenarios, so plan to check your output if it looks like the connection is lost. In particular, if the **Output** pane isn't set to "Test," you might not immediately see the message. If the connection is lost, you can use the environment drop-down in the Test Explorer to set the connection back to your local environment and then select the remote environment again to reconnect.

## Set up the remote testing environment

Environments are specified by using the *testenvironments.json* file in the root of your solution. The json file structure implements the following schema:

```json
{
    "version": "1", // value must be 1
    "environments": [
        { "name": "<unique name>", ... },
        ...
    ]
}
```

### Properties of an environment in testenvironments.json 

The *testenvironments.json* file has the following environment properties.

| Property | Type | Description |
| ---|---|---|
| `name` | string | User-friendly environment name that appears in Test Explorer. It must be unique within a *testEnvironments.json* file. |
| `localRoot` | string | **[Optional]** Path on the local machine (either absolute or relative to the solution directory), which is projected into the remote environment. If not specified, the default value is the repo root within the context of a git repo (on Visual Studio 2022 version 17.1 and later). Outside a git repo, the default value is the solution directory. |
| `type` | enum | Indicates the type of remote environment. The value can be either `docker`, `wsl`, or `ssh`. |
| `dockerImage` | string | Name of a Docker image to load in a Docker environment. <br/> This value is required if the environment `type` is `docker`. |
| `dockerFile` | string | Path to a Docker file, relative to the solution directory, to build an image and load in a Docker environment. <br/> This value is required if the environment `type` is `docker`. |
| `wslDistribution` | string | Name of the local WSL distribution in which to run the test environment. <br/> This value is required if the environment `type` is `wsl`. |
| `remoteUri` | string | A uri that specifies the connection to the remote machine. For example, `ssh://user@hostname:22`. <br/> This value is required if the environment `type` is `ssh`. |

> [!NOTE]
> You must specify either the `dockerImage` or `dockerFile` property, but not both properties.

### Local container connections

To connect to a container running locally, you must have [Docker Desktop](https://www.docker.com/products/docker-desktop) on your local machine. Optionally, [enable WSL2 integration](/windows/wsl/install-win10) for better performance.

For a Dockerfile, the environment can be specified in the *testEnvironments.json* file in the root of your solution. It uses the following properties:

```json
{
    "name": "<name>",
    "type": "docker",
    "dockerImage": "<docker image tag>",
}
```

The following example shows the *testenvironments.json* file for a local container image named `<mcr.microsoft.com/dotnet/sdk>`.

```json
{
    "version": "1",
    "environments": [
        {
            "name": "linux dotnet-sdk-5.0",
            "type": "docker",
            "dockerImage": "mcr.microsoft.com/dotnet/sdk"
        }
    ]
}
```

The following example shows a Dockerfile for running tests targeting .NET 5.0. The second line makes sure the debugger can connect and run in your container.

```dockerfile
FROM mcr.microsoft.com/dotnet/sdk:5.0

RUN wget https://aka.ms/getvsdbgsh && \
    sh getvsdbgsh -v latest  -l /vsdbg
```

The container must have a built image on your local machine. You can build a container with the command `docker build -t <docker image name> -f <path to Dockerfile> .` Be sure to include the period `.` at the end of the command.

The following example shows the use of the `dockerFile` property instead of the `dockerImage` property.

```json
{
    "version": "1",
    "environments": [
        {
            "name": "GitServiceUnix",
            "type": "docker",
            "dockerFile": "Dockerfile.test"
        }
    ]
}
```

### Local WSL2 connections

To remotely run tests on WSL2, you must [enable WSL2 integration](/windows/wsl/install-win10) on your local machine.

The environment can be specified in the *testEnvironments.json* file in the root of your solution by using the following schema. Replace the `<Ubuntu>` value of the `wslDistribution` property with your installation of the WSL2 Distribution.

```json
{
    "version": "1",
    "environments": [
        {
            "name": "WSL-Ubuntu",
            "type": "wsl",
            "wslDistribution": "Ubuntu"
        }
    ]
}
```

### SSH connections

You can add or remove SSH connections in **Tools > Options > Cross Platform > Connection Manager**. Select **Add** to enter the host name, port, and any credentials you need.

The environment can be specified in the *testEnvironments.json* file in the root of your solution by using the following schema. Replace the `<ssh://user@hostname:22>` value of the `remoteUri` property with your SSH value.

```json
{
    "version": "1",
    "environments": [
        {
            "name": "ssh-remote",
            "type": "ssh",
            "remoteUri": "ssh://user@hostname:22"
        }
    ]
}
```

#### Prerequisites for a remote Windows environment

Review the following prerequisites for a remote Windows environment.

1. Ensure [Windows Projected File System](/windows/win32/projfs/enabling-windows-projected-file-system) is enabled on the remote machine. You can run the following code from an admin PowerShell window to enable it:

   ```powershell
    Enable-WindowsOptionalFeature -Online -FeatureName Client-ProjFS -NoRestart
   ```

   Restart the environment as needed.

1. Ensure SSH is set up. You can review the steps at [Install OpenSSH](/windows-server/administration/openssh/openssh_install_firstuse#install-openssh-using-powershell). Start up the SSH server by running the following command from an admin PowerShell window:

   ```powershell
   Start-Service sshd
   ```

1. Ensure the appropriate .NET runtime required by your tests is installed. You can [download .NET for Windows](https://dotnet.microsoft.com/download).

1. Prepare the environment for debugging tests:

   1. Install the [Remote tools SKU](/visualstudio/debugger/remote-debugging?view=vs-2022&preserve-view=true) on the remote environment.

   1. Start up the remote debugger as an admin and ensure the Visual Studio user has permissions to connect.

#### Prerequisites for a remote Linux environment

Review the following prerequisites for a remote Linux environment.

1. Ensure ssh is configured and running.

1. Install `fuse3` by using a package manager.

1. Ensure the appropriate .NET runtime required by your tests is installed on the remote Linux environment.

## Use the Test Explorer to run and debug remote tests

Here's how you can use the Test Explorer to run and debug your remote environment tests.

* The active environment is selected via a drop-down in the Test Explorer tool bar. Currently, only one test environment can be active at a time.

  ![Remote testing environment drop down in Test Explorer](media/remote-test-drop-down.png)

* After you select an environment, tests are discovered and run in the new environment.

  ![Tests are discovered and executed in remote environments](media/remote-test-linux-discovery.png)

* You can now run your tests inside the remote and debug your tests in environments!

  ![View test results from remote environment in the test explorer](media/remote-test-linux-passing.png)

* Test Explorer can prompt you to install some missing environment prerequisites and attempt to install missing dependencies. However, the bulk of the provisioning of the remote environment is up to the user's specification.

## Related content

- [Debug unit tests with Test Explorer](../test/debug-unit-tests-with-test-explorer.md)
- [Run a unit test as a 64-bit process](../test/run-a-unit-test-as-a-64-bit-process.md)
- [Test Explorer FAQ](test-explorer-faq.md)
