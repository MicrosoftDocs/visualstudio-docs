# Get Started with Connected Environment on Windows

## Install Tools
Several pre-requisites are required at this stage of the product (we're working on reducing these going forward).
1. Install [Git for Windows](https://git-scm.com/downloads), selecting all default options.
1. Install [VS Connected Environment CLI]() (the link points to an MSI). 
1. Install **kubectl** with the following command: `az acs kubernetes install-cli` - the command output will state the path to kubectl.exe, e.g. `C:\Program Files (x86)`.
1. Add **kubectl** to your system path with this PowerShell command (this example assumes kubectl was installed to C:\Program Files (x86), you may need to substitute accordingly): `[Environment]::SetEnvironmentVariable("Path", $env:Path + ";C:\Program Files (x86)", "User")`

Once you have completed the above steps, please **choose the development tool** you would like to use for building and debugging services in Kubernetes:

> [!div class="nextstepaction"]
> [VS Code & command-line](get-started-windows-vscode-02.md)

> [!div class="nextstepaction"]
> [Visual Studio](get-started-windows-visualstudio-02.md)
