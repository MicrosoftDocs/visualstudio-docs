# Getting Started on Connected Environment with .NET Core

Previous step: [Install Tools](get-started-netcore-01.md)

## Sign in to Azure
We'll need to sign in to Azure to create our development environment. Type the following command in a terminal window:
```cmd
az login
```

> [!Note]
> If you don't have an Azure subscription, you can create a [free account](https://azure.microsoft.com/free).

### If you have multiple Azure subscriptions...
You can view your subscriptions by running: 
```cmd
az account list
```
Locate the  subscription which has `isDefault: true` in the JSON output.
If this isn't the subscription you want to use, you can change the default subscription:
```cmd
az account set --subscription <subscription ID>
```

## Create a Kubernetes Development Environment in Azure
With Connected Environment, you can create Kubernetes-based environments that are fully managed by Azure and optimized for development. The command creates an environment named `mydevenvironment` in `eastus`. You'll need to enter a unique environment name.
```cmd
vsce env create --name mydevenvironment --location eastus
```

Supported locations: `eastus`

> [!Note]
> This command takes about 6 minutes. You can continue the guide without waiting.


While we're waiting for the environment to be create, let's start developing code!

> [!div class="nextstepaction"]
> [Create a .NET Core container in Kubernetes](get-started-netcore-03.md)
