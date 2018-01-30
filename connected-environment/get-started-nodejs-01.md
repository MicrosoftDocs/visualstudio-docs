# Getting Started on Connected Environment with Node.js

> [!Note]
> **If you get stuck** at any time, see the [Troubleshooting](troubleshooting.md) section.

## Install the Connected Environment CLI
There is minimal "local machine" setup required with Connected Environment. Most of your development environment's configuration will be in the cloud, making it easily shareable with others.

### Install on Mac
Download and install the Connected Environment CLI:
```
curl -L https://aka.ms/get-vsce-mac | bash
```

### Install on Windows
1. Install [Git for Windows](https://git-scm.com/downloads), select the default install options. 
1. Download **kubectl.exe** from [this link](https://storage.googleapis.com/kubernetes-release/release/v1.9.0/bin/windows/amd64/kubectl.exe) and **save** it to a location on your PATH.
1. Download and run the [Connected Environment CLI Installer](https://aka.ms/get-vsce-windows). 

### Install on Linux
Coming soon...

## Kubernetes Debugging with VS Code
While you can use the Connected Environment CLI as a standalone tool, rich features like **Kubernetes debugging** are available for Node.js developers using VS Code.

1. If you don't have it, install [VS Code](https://code.visualstudio.com/Download)
1. Download the [VS Connected Environment extension](https://aka.ms/get-vsce-code)
1. Install the extension: 

```
code --install-extension path-to-downloaded-extension/vsce-0.1.0.vsix
```


We're now ready to create a Kubernetes-based development environment in Azure.

> [!div class="nextstepaction"]
> [Create a Dev Environment in Azure](get-started-nodejs-02.md)
