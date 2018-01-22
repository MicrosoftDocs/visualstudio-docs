# Create a C# .NET Core service with VS Code

## Create an ASP.NET Core Web App
This example uses the `dotnet` CLI to quickly create an ASP.NET Core Web App in a folder named `webfrontend`.
```
dotnet new mvc --name webfrontend
```


## Initialize Code for Docker and Kubernetes Development
Open the `webfrontend` folder in VS Code - feel free to browse the structure of the web application.

Our next step is to containerize our application and create assets so we can deploy it to Kubernetes. Thankfully, this is easy to do with Connected Environment: open the **Command Palette** (`Command+Shift+P`) and select the command `Connected Environment: Generate Assets for Build and Debug`.

To be able to run our application as a service in Kubernetes, we'll need to  run our app in a container  and open the integrated terminal using the **View | Integrated Terminal** menu command.

In the Terminal window, type the following command.
