# Getting Started on Connected Environment with .NET Core

Previous step: [Create an ASP.NET Core Web App](get-started-netcore-03.md)

In this section, we'll use VS Code to directly debug our containers running in Azure. To do this, we need to configure our code project so VS Code will communicate with our development environment in Azure.

## Initialize Debug Assets with the VS Code Extension
The VS Code extension for Connected Environment provides a helper command to set up debug configuration. 

Open the **Command Palette** (using the **View | Command Palette** menu), and use auto-complete to type and select this command: `Connected Environment: Generate Assets for Build and Debug`. This command adds debug configuration under the `.vscode` folder for Connected Environment.

![](media/debugconfiguration.png)

> [!Note]
> If you don't see any Connected Environment commands in the Command Palette, ensure you have [installed the VS Code extension for Connected Environment](get-started-netcore-01.md#get-kubernetes-debugging-tools).

## Select the VSCE Debug Configuration
1. To bring up the Debug view, click on the Debug icon in the **Activity Bar** on the side of VS Code.
1. Select **.NET Core Launch (VSCE)** as the active debug configuration.

Youv'e 

## Debug the Container in Kubernetes
