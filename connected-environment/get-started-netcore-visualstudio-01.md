# Getting Started on Connected Environment with .NET Core and Visual Studio

> [!Note]
> **If you get stuck** at any time, see the [Troubleshooting](troubleshooting.md) section.

## Install the Connected Environment CLI
There is minimal "local machine" setup required with Connected Environment. Most of your development environment's configuration will be in the cloud, making it easily shareable with others.

1. Install [Git for Windows](https://git-scm.com/downloads), select the default install options. 
1. Download **kubectl.exe** from [this link](https://storage.googleapis.com/kubernetes-release/release/v1.9.0/bin/windows/amd64/kubectl.exe) and **save** it to a location on your PATH.
1. Download and run the [Connected Environment CLI Installer](https://aka.ms/get-vsce-windows). 


## Get Kubernetes Debugging Tools
While you can use the Connected Environment CLI as a standalone tool, rich features like **Kubernetes debugging** are available for .NET Core developers using **VS Code** or **Visual Studio**.

### Visual Studio debugging 
1. Install the latest version of [Visual Studio 2017](https://www.visualstudio.com/vs/)
1. In the VS installer, select these Workloads:
    * ASP.NET and web development
    * Azure development
    * .NET Core cross-platform development
1. Install the [Visual Studio extension for Connected Environment](https://aka.ms/get-vsce-visualstudio)


> [!div class="nextstepaction"]
> [Create an ASP.NET Web App](get-started-netcore-visualstudio-02.md)
