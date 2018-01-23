# Getting Started on Connected Environment with .NET Core

Previous step: [Install Tools](get-started-netcore-01.md)

## Sign in to Azure
We'll need to sign in to Azure to create our development environment:
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

## Create a Kubernetes Development Environment in Azure
This command creates a Kubernetes-based environment that is Azure-managed and optimized for development.
```
vsce env create --name <environment name> --location <eastus or westeurope>
```

> [!Note]
> This command takes about 10 minutes, please be patient.


Now that we have a development environment, we can begin writing code!
> [!div class="nextstepaction"]
> [Create a .NET Core container in Kubernetes](get-started-netcore-03.md)
