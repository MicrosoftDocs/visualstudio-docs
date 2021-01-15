---
title: Customize a codespace (Preview)
description: Learn more about how to customize a codespace.
ms.topic: how-to
ms.date: 09/21/2020
author: gregvanl
ms.author: gregvanl
manager: jillfra
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.workload:
- multiple
monikerRange: vs-2019
---

# How to customize a codespace (Preview)

GitHub Codespaces provide a full development environment in the cloud. For Windows-based development using Visual Studio 2019, the GitHub Codespaces default instances provide a great starting point but you can also customize the environment for your specific project.

## Installed software

Windows codespaces come with many frameworks and tools already installed so you can get started right away. The table below lists the applications and features available in all Windows codespace environments.

| App                                         | Path Alias | Version            |
|---------------------------------------------|------------|--------------------|
| .NET                                        | N/A        | 4.8                |
| .NET Core Runtime                           | dotnet     | 2.1, 3.1           |
| .NET Core SDK                               | dotnet     | 2.1, 3.1.3, 3.1.4  |
| Azure CLI                                   | az         | 2.5                |
| Chocolatey                                  | choco      | 0.10.15            |
| CMake                                       | cmake      | 3.17               |
| Git                                         | git        | 2.26               |
| Microsoft build                             | msbuild    | 16.7               |
| Microsoft SQL Server Express Edition 2019   | N/A        | 15.0               |
| Ninja                                       | ninja      | 1.8.2              |
| Node.js                                     | node       | 12.16              |
| NPM                                         | npm        | 6.14               |
| Python                                      | python     | 3.7                |
| VC Package Manager                          | vcpkg      | 2020.02            |
| Windows SDK                                 | N/A        | 10.0.18362         |

The list above is not exhaustive and excludes many tools that Visual Studio installs (for example IISExpress). A component may also have a different minor or patch version than the one stated above.

Specific details about the preinstalled frameworks and tooling are provided in the [Installed software specifics](#installed-software-specifics) section below.

## Modifications to a codespace
 
Once you create a codespace, any changes to that specific codespace are persisted while the codespace instance is available on GitHub Codespaces. You can clone additional repositories, install tools and application generators, and add other development assets and these modifications will be preserved even when the codespace is suspended. However if you delete a codespace, any modifications are gone.

> [!NOTE]
> If you delete a codespace, any changes to a local repository (pending or committed) in the codespace will be lost. Be sure to push repository changes to a remote location before deleting a codespace.

While connected to a codespace with Visual Studio, you can use the Visual Studio Terminal for running command-line tools. You can use either PowerShell or the Windows Command Prompt, both elevated under the local administrator account. To learn more about the Visual Studio terminal, see the [Visual Studio Terminal announcement blog](https://devblogs.microsoft.com/visualstudio/say-hello-to-the-new-visual-studio-terminal/).

## Customize a codespace

The real value of GitHub Codespaces comes when you can create unique, repeatable development environments in the cloud tailored for your own work as well as your team's. By building on a default GitHub Codespaces instance, you can customize what is installed and configured when you create a new codespace.

The next sections will describe two codespace configuration methods using *.devcontainer.json* and *.devinit.json* files. These files let you configure the installation frameworks and tools for a codespace and when added to your repository, anyone creating a codespace based on your repository will have the same remote development environment.

## Customize with devcontainer.json

When a codespace is created, GitHub Codespaces looks for a [*devcontainers.json*](https://code.visualstudio.com/docs/remote/devcontainerjson-reference) file in the root of your repository and uses the settings within to customize the codespace or the client instances connecting to it (browser-base editor, Visual Studio, or Visual Studio Code). Most the *devcontainer.json* settings apply to Linux-based codespaces or the two other clients but some are available for Windows codespaces and Visual Studio.

The *devcontainer.json* file can be placed in one of two places in a repository:

1. *{repository-root}/.devcontainer.json*
2. *{repository-root}/.devcontainer/devcontainer.json*

GitHub Codespaces support the following *devcontainer.json* properties. Setting Visual Studio Code specific properties is useful if you expect to connect to your codespace with the other clients in addition to Visual Studio. 

* `extensions` - An array of [Visual Studio Code Marketplace](https://marketplace.visualstudio.com/vscode) extensions that should be installed.
* `settings`  - A set of [Visual Studio Code settings](https://code.visualstudio.com/docs/getstarted/settings) to apply.
* `forwardPorts`- A port or array of ports that should be automatically forwarded locally when the codespace is running.
* `postCreateCommand` - A command string or list of command arguments to run after the codespace is created.

> [!NOTE]
> **devcontainer.json** files are also used to support Visual Studio Code [Remote Development](https://code.visualstudio.com/docs/remote/remote-overview), and have additional properties not covered in this document. These additional properties are safe to add to the file, but will be ignored by Codespaces. For more information, see the [devcontainer.json reference](https://code.visualstudio.com/docs/remote/devcontainerjson-reference) on code.visualstudio.com.

## Customize with devinit

[devinit](../../devinit/getting-started-with-devinit.md) is a command-line tool included in Windows codespaces that lets you install frameworks and tools into your environment. It can be run manually from a command prompt (`devinit run -t require-dotnetcoresdk`) but its real power comes from creating a custom [*.devinit.json* ](../../devinit/devinit-json.md) file to uniformly configure a codespace whenever you create one.

`devinit` includes a set of tools for installing specific items, such as SQL Server and the Azure CLI, and also running general package managers such as chocolatey, npm, and vcpkg. You can find the complete list of `devinit` tools in the [Available tools](../../devinit/devinit-tool-list.md) documentation.

### devinit.json

While you can run the `devinit` command line directly, we recommend creating [*devinit.json*](../../devinit/devinit-json.md) configuration files, which describe the set of `devinit` tools to run. 

For example, to install the [.NET Core SDK](/dotnet/core/sdk), a *.devinit.json* would look like:

```json
{
    "run": [
        {
            "comments": "We need the .NET Core SDK."
            "tool": "require-dotnetcoresdk"
        }
    ]
}
```

When you author a *.devinit.json* file in the root of your project, it will be used when you run `devinit init`. By default, `devinit.exe` looks for the file in the following locations:

1. *{current-directory}\\.devinit.json*
2. *{current-directory}\\.devinit\devinit.json*

### Running devinit when creating a codespace

You can instruct GitHub Codespaces to run `devinit` after a codespace is created by using the `postCreateCommand` property in a *devcontainers.json* file. As mentioned above, GitHub Codespaces will look for a *devcontainer.json* file in your cloned repository in order to customize the codespace or client instance and it will run any commands described in the `postCreateCommand` property.

By specifying `devinit init`, `devinit` will be run using your *devinit.json* configuration.

```json
{
  "postCreateCommand": "devinit init"
}
```

### An example

Here is a simple example installing the .NET Core Entity Framework command-line tool, `dotnet-ef`.

**devcontainer.json**

Contents of the *.devcontainer.json* file in the repo root. 

```json
{
  "postCreateCommand": "devinit init"
}
```

**devinit.json**

Contents of the *.devinit.json* file. This file needs to be in the same folder as *.devcontainer.json*.

```json
{
    "run": [
        {
            "comments": "Install the Entity Framework tools",
            "tool": "dotnet-toolinstall",
            "input": "dotnet-ef",
        }
     ]
}
```

You can find more `devinit` examples in the `devinit` [Samples list](../../devinit/sample-readme.md).

## Port forwarding

GitHub Codespaces provides access to the applications and services running in the remote environments by means of port forwarding. By default, no ports are forwarded for security concerns. However, you can specify certain ports to open in a codespace.

### Configure port forwarding

If there are one or more ports that should be forwarded by default for a given repository, that can be configured in *devcontainer.json* with the `forwardPorts` property.

* `forwardPorts` - A port or array of ports that should be automatically forwarded locally when the environment is running.

## Installed software specifics

### Microsoft SQL Server

Microsoft SQL Server 2019 Express Edition is available and running as a local service (localdb) in the Windows Codespace environment. The current user, which your app and the Visual Studio Terminal run as, has SQL administrator rights to the SQL server. To administer the server, you will need to use PowerShell in the Visual Studio Terminal or other command-line tools such as `dotnet-ef`. Currently SQL Server Management Studio and other remote administration tools are not available.

#### Example connection string

Below is an example of a connection string to connect to the local MS SQL server.

```csharp
"Server=(LocalDB);Integrated Security=true;"
```

### Azure CLI

The Azure CLI is installed in all Windows Codespace environments and is available on path as `az`.

#### Using Azure resources

If you are using an Azure Active Directory identity to authenticate your application against Azure resources, you will need to first sign in to Azure from the Visual Studio terminal. To sign in, use the Azure CLI `login` command with the device sign in flow (as shown in the example below). Once signed in, your application and terminal session should be able to use that identity.

```powershell
> az login --use-device-code
```

You can learn more on the `az login` command in the Azure CLI [documentation](/cli/azure/reference-index#az_login).

## See also

- [What is GitHub Codespaces?](codespaces-overview.md)
- [How to use Visual Studio with a codespace](use-visual-studio-with-codespaces.md)