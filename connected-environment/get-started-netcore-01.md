# Getting Started on Connected Environment with .NET Core

## Install the Connected Environment CLI
There is minimal "local machine" setup required with Connected Environment. Most of your development environment's configuration will be in the cloud, making it easily shareable with others.

### Install on Mac
Download and install the Connected Environment CLI:
```
curl -L https://aka.ms/get-vsce-mac > get-vsce-mac.sh
source ./get-vsce-mac-sh
```
<!-- ```
curl -L https://aka.ms/get-vsce-mac | bash
``` -->

### Install on Windows
1. Install [Git for Windows](https://git-scm.com/downloads), select the default install options. 
1. Download **kubectl.exe** from [this link](https://storage.googleapis.com/kubernetes-release/release/v1.9.0/bin/windows/amd64/kubectl.exe) and **save** it to a location on your PATH.
1. Download and run the [Connected Environment CLI Installer](https://aka.ms/get-vsce-windows). 

### Install on Linux
Coming soon...

## Get Kubernetes Debugging Tools
While you can use the Connected Environment CLI as a standalone tool, rich features like **Kubernetes debugging** are available for .NET Core developers using **VS Code** or **Visual Studio**.

Choose the development tool you'd like to use.


### VS Code (Mac, Windows, Linux)
1. If you don't have it, install [VS Code](https://code.visualstudio.com/Download)
1. Download the [VS Connected Environment extension](https://aka.ms/get-vsce-code)
1. Install the extension: 

```
code --install-extension path-to-downloaded-extension/vsce-0.1.0.vsix
```

### Visual Studio (Windows only)
1. Install the latest version of [Visual Studio 2017 Preview](https://www.visualstudio.com/vs/preview/)
1. In the VS installer, select these Workloads:
    * ASP.NET and web development
    * Azure development
    * .NET Core cross-platform development
1. Install the [Visual Studio extension for Connected Environment](https://aka.ms/get-vsce-visualstudio)


## Proceed based on your development tool

> [!div class="nextstepaction"]
> [I'm using VS Code / CLI](get-started-netcore-02.md)

> [!div class="nextstepaction"]
> [I'm using Visual Studio](get-started-netcore-visualstudio-02.md)
