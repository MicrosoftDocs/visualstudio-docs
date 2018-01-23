# Getting Started on Connected Environment with .NET Core

## Install the Connected Environment CLI
There is minimal "local machine" setup required with Connected Environment. Most of your development environment's configuration will be in the cloud, making it easily shareable with others.

### MacOS
Install the Connected Environment command-line tool:
```
curl -L https://aka.ms/get-vsce-mac | bash
```

### Windows
1. Install the [VS Connected Environment CLI](). 
1. Install [Git for Windows](https://git-scm.com/downloads), select the default install options.
1. Install **kubectl** with this command: `az acs kubernetes install-cli` - the command output will state the path to kubectl.exe, e.g. `C:\Program Files (x86)`. 

Ensure the location of **kubectl** is in your system path; you can use this PowerShell command (this example assumes it was installed in **C:\Program Files (x86)**): `[Environment]::SetEnvironmentVariable("Path", $env:Path + ";C:\Program Files (x86)", "User")`


### Linux
Coming soon...

## Rich Tooling Integration
While you can use the Connected Environment CLI as a standalone tool, rich features like **Kubernetes debugging** is available for .NET Core development in **VS Code** and **Visual Studio**.

Choose the development tool you'd like to use.


### VS Code (Mac, Windows, Linux)
1. Install [VS Code](https://code.visualstudio.com/Download)
1. Download the [VS Connected Environment extension](https://aka.ms/vsce-code)
1. Install the extension: 

```
code --install-extension path-to-downloaded-extension/vsce.0.0.1.vsix
```

### Visual Studio (Windows only)
1. Install the latest version of [Visual Studio 15](https://www.visualstudio.com/vs/preview/)
1. In the VS installer, select these Workloads:
    * ASP.NET and web development
    * Azure development
    * .NET Core cross-platform development
1. Install the [Visual Studio extension for Connected Environment](https://aka.ms/get-vsce-visualstudio)


## Proceed based on your Development tool

> [!div class="nextstepaction"]
> [I'm using VS Code / CLI](get-started-netcore-02.md)

> [!div class="nextstepaction"]
> [I'm using Visual Studio](get-started-netcore-visualstudio-02.md)
