## Initialize Debug Assets with the VS Code Extension
We first need to configure our code project so VS Code will communicate with our development environment in Azure. The VS Code extension for Connected Environment provides a helper command to set up debug configuration. 

Open the **Command Palette** (using the **View | Command Palette** menu), and use auto-complete to type and select this command: `Connected Environment: Generate Assets for Build and Debug`. 

This adds debug configuration for Connected Environment under the `.vscode` folder.

![](../media/vsce-command-palette.png)