---
title: Tutorial
description: Tutorial for devinit.
ms.date: 11/18/2020
ms.topic: reference
author: andysterland
ms.author: andster
manager: jmartens
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
# Tutorial

> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

In this tutorial, we'll explore setting up the [eShopOnWeb repository](https://github.com/andysterland/eShopOnWeb) with devinit and Codespaces. This tutorial assumes that devinit is already available, as described in the [getting started page](getting-started-with-devinit.md).

## Step 1: Determining setup steps

As mentioned in the [getting started page](getting-started-with-devinit.md), the first step is always to determine which dependencies and setup steps your project has. This will vary based on the specific project, but there are a few questions to consider:

- What runtimes or SDKs does your project depend on?
- Does your project require any packages (for example, from Chocolatey)?
- Does your setup process require any actions to be taken (for example, running a script)?
- Does your project have implicit dependencies on anything that is installed alongside Visual Studio?
  - If so, it's a good idea to include these in your devinit setup as well. That way, you can avoid coupling to the Visual Studio installation.

One of the best ways to determine this information is by exploring the manual setup steps you currently have for your repository. For eShopOnWeb, there are a few things we need to handle:

- Installing the latest version of the .NET Core SDK
- Installing the latest version of the .NET Entity Framework Core Tools CLI
- Installing SQL Server 2019 Express
- Using the .NET Entity Framework CLI to update the local database to the latest migration

Next, we'll explore how to accomplish all of this in the context of devinit.

## Step 2: The .devinit.json

First, we'll want to construct a [.devinit.json file](devinit-json.md) and place it in the root of our repository. This file will include a series of steps that will be executed later as part of a `devinit init` command. To determine what should be included in the `.devinit.json` file, we can take our list of setup steps and compare to the list of [devinit tools](devinit-tool-list.md). Let's do that now with the setup steps from above.

| Step                                                              | Can devinit handle this for us?                                                                        |
| :---------------------------------------------------------------- | :----------------------------------------------------------------------------------------------------  |
| Install latest .NET Core SDK                                      | **Yes**! We can use the [`require-dotnetcoresdk` tool](tool-require-dotnetcoresdk.md)                  |
| Install .NET Entity Framework Core Tools CLI                      | **Yes**! We can use the [`dotnet-toolinstall` tool](tool-dotnet-toolinstall.md)                        |
| Install SQL Server 2019 Express                                   | **Yes**! We can use the [`choco-install` tool](tool-choco-install.md)                                  |
| Update local database using .NET Entity Framework                 | **No**, but we still accomplish this by combining devinit with a script!                               |

Now that we've figured that out, let's start with a basic `.devinit.json`. We'll include a reference to the [`.devinit.json` schema](https://json.schemastore.org/devinit.schema-2.0), and an empty `run` section:

```json
{
  "$schema": "https://json.schemastore.org/devinit.schema-2.0",
  "run": []
}
```

Now let's add some tools!

First, we'll add [`require-dotnetcoresdk`](tool-require-dotnetcoresdk.md). From that tool's documentation, we can see that the default behavior is to install the latest SDK version. That's exactly what we want, so let's add it to our `.devinit.json`:

```json
{
  "$schema": "https://json.schemastore.org/devinit.schema-2.0",
  "run": [
    {
      "comments": "Install the latest version of the .NET Core SDK.",
      "tool": "require-dotnetcoresdk"
    }
  ]
}
```

Second, we'll add [`dotnet-toolinstall`](tool-dotnet-toolinstall.md) to install the `dotnet-ef` tool globally. From the documentation, we see that we can use the `input` field to specify the tool name, and the `additionalOptions` field to specify the global scope:

```json
{
  "run": [
    {
      "comments": "Install the latest version of the .NET Core SDK.",
      "tool": "require-dotnetcoresdk"
    },
    {
      "comments": "Install latest version of the .NET Entity Framework Core Tools CLI.",
      "tool": "dotnet-toolinstall",
      "input": "dotnet-ef",
      "additionalOptions": "--global"
    }
  ]
}
```

Last, we'll add [`choco-install`](tool-choco-install.md) to install the `sql-server-express` package.

```json
{
  "run": [
    {
      "comments": "Install the latest version of the .NET Core SDK.",
      "tool": "require-dotnetcoresdk"
    },
    {
      "comments": "Install latest version of the .NET Entity Framework Core Tools CLI.",
      "tool": "dotnet-toolinstall",
      "input": "dotnet-ef",
      "additionalOptions": "--global"
    },
    {
      "comments": "Install SQL Server 2019 Express",
      "tool": "choco-install",
      "input": "sql-server-express"
    }
  ]
}
```

Now that our `.devinit.json` is complete, we can work on a setup script that will take care of running devinit and updating the local database.

## Step 3: The setup script

To handle both running devinit and updating the local database, we'll create a script that executes the needed commands. Let's create an empty PowerShell script in our repository root, named `PostCloneSetup.ps1`. First, we'll add a call to `devinit init`:

```powershell
devinit init
```

When executed, `devinit init` will run all of the tools defined in the `run` section of our `.devinit.json`.

Last, we want to invoke `dotnet ef database update` for updating the local database:

```powershell
devinit init
dotnet ef database update -c catalogcontext -p src\Infrastructure\Infrastructure.csproj -s src\Web\Web.csproj
dotnet ef database update -c appidentitydbcontext -p src\Infrastructure\Infrastructure.csproj -s src\Web\Web.csproj
```

Now that our setup script is complete, we need to add a `.devcontainer.json` file which will execute it during codespace setup.

## Step 4: The .devcontainer.json

To ensure that our setup script is run during the creation of our codespace, we'll use a `.devcontainer.json` file. Similarly to the other files, this should be placed in the repository root.

In the `.devcontainer.json` file, we just need to call our setup script as part of the `postCreateCommand`. This will be executed as part of the codespace creation process:

```json
{
  "postCreateCommand": "Powershell.exe -ExecutionPolicy unrestricted -File .\\PostCloneSetup.ps1"
}
```

And that's it!

## Step 5: Trying it out

Now that our setup steps are in place, let's try this out in a live codespace using the [real repo](https://github.com/andysterland/eShopOnWeb).

First, we'll create a codespace using Visual Studio:

:::image type="content" source="media/eshoponweb-github-codespaces-prompt.png" alt-text="Creating a codespace":::

Once the codespace creation has started, we can watch the progress of our setup process in `C:\.vsonline\.vsoshared\vmTerminal.dat`:

:::image type="content" source="media/eshoponweb-watching-progress.png" alt-text="Watching setup progress":::

Once it's complete, let's run the app via `Web.csproj` to make sure everything is working correctly:

:::image type="content" source="media/eshoponweb-csproj.png" alt-text="Running the project":::

After the app builds and starts, we can see the shop in our web browser:

:::image type="content" source="media/eshoponweb-live.png" alt-text="Viewing the site":::

So, our setup process worked correctly and we're now ready to develop in the eShopOnWeb project!
