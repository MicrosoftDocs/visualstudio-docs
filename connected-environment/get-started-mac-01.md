# Get Started with Connected Environment on Mac


## Install Tools
Install the Connected Environment command-line tool:
```
curl -L https://aka.ms/get-vsce-mac | bash
```

### VS Code Debugging
For a streamlined development and debugging experience for **Node.js and C#**:

1. Install [VS Code](https://code.visualstudio.com/Download)
1. Download the [VS Connected Environment extension](https://aka.ms/vsce-code)
1. Install the extension by running: 
```
code --install-extension path-to-downloaded-extension/vsce.0.0.1.vsix
```


## Sign in to Azure
We'll be running containers in a development environment in Azure, so let's sign in:
```
az login
```

> [!Note]
> If you don't have an Azure subscription, you can create a [free account](https://azure.microsoft.com/free).

### If you have multiple Azure subscriptions...
You can view your subscriptions by running: 
```
az account list
```
Locate the  subscription which has `isDefault: true` in the JSON output.
If this isn't the subscription you want to use, you can change the default subscription:
```
az account set --subscription <subscription ID>
```

## Create a Development Environment in Azure
This command creates a Kubernetes-based environment that is Azure-managed and optimized for development. This signficiantly reduces the "local machine" set up that you need to do, and we'll later see how it streamlines team development.
```
vsce env create --name <environment name> --location <eastus or westeurope>
```

> [!Note]
> This command takes about 10 minutes, please be patient.

## Next Steps
Next, we'll create and debug a service in our Connected Environment. Choose your language of choice:
> [!div class="nextstepaction"]
> [Create a Node.js service](get-started-mac-02-nodejs.md)

> [!div class="nextstepaction"]
> [Create a C# .NET Core service](get-started-mac-02-csharp.md)