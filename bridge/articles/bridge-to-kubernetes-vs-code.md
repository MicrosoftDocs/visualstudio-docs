---
ms.topic: quickstart
ms.author: ghogen
author: ghogen
manager: mijacobs
ms.subservice: bridge
title: Redirect traffic between Kubernetes cluster & local code (VS Code)
ms.date: 09/14/2023
description: Use Bridge to Kubernetes to redirect traffic between your Kubernetes cluster and code running on your development computer.
---

# Use Bridge to Kubernetes (VS Code)

[!INCLUDE [Bridge to Kubernetes deprecation note](./includes/deprecation.md)]

Bridge to Kubernetes allows you to run and debug code on your development computer, while still connected to your Kubernetes cluster with the rest of your application or services. In this guide, you will learn how to use Bridge to Kubernetes to redirect traffic between your Kubernetes cluster and code running on your development computer.

## Before you begin

This article assumes you already have your own cluster with a microservices architecture and you want to debug one of the pods in your cluster. If you want to learn how to use Bridge to Kubernetes with an existing sample application, see [Use Bridge to Kubernetes with a sample](bridge-to-kubernetes-sample.md). If you are using Azure Kubernetes service and want to use a more complex sample application, see [Bridge to Kubernetes (AKS)](bridge-to-kubernetes-aks.md).

### Prerequisites

* A Kubernetes cluster with an app that you want to debug.
* [Visual Studio Code][vs-code] running on macOS, Windows 10 or later, or Linux.

## Connect to your cluster and debug a service

There are a couple of different ways of starting the process of debugging with Bridge to Kubernetes. If you're starting from the open source Kubernetes extension, without Bridge to Kubernetes installed, go to [Install and use local tunnel debugging](#install-and-use-local-tunnel-debugging). If you already have Bridge to Kubernetes installed, continue with the following steps:

1. On your development computer, make sure your current context is set to the cluster and namespace in which your application is running.

1. Open the workspace for the app you want to debug in Visual Studio Code. In the Kubernetes extension view under **Clusters**, make sure your cluster and namespace are selected. Open the Command Palette (**CTRL**+**SHIFT**+**P** or **Cmd**+**Shift**+**P** on a Mac), and run the command **Bridge to Kubernetes: Configure** to start the configuration process.

1. Choose the Kubernetes service you want to redirect to your local version.

   ![Select the service to connect to](media/bridge-to-kubernetes-sample/select-service.png)

   All traffic in the Kubernetes cluster is redirected for your service to the version of your application running in your development computer. Bridge to Kubernetes also routes all outbound traffic from the application back to your Kubernetes cluster.

   > [!IMPORTANT]
   > You can only redirect services that have a single pod.

1. After you select your service, skip the next section and continue by following the steps in [Configure the debugger for local tunnel debugging with Bridge to Kubernetes](#configure-the-debugger-for-local-tunnel-debugging-with-bridge-to-kubernetes).

## Install and use local tunnel debugging

Follow these steps to start using local tunnel debugging when you have the open-source [Kubernetes extension](https://marketplace.visualstudio.com/items?itemName=ms-kubernetes-tools.vscode-kubernetes-tools) installed and have a Kubernetes cluster with services you want to debug. The steps in this section will take you through the installation of Bridge to Kubernetes and start the configuration process for local tunnel debugging.

> [!NOTE]
> The Kubernetes extension for VS Code provides an API entry point that allows extension authors to contribute other local tunnel solutions from the VS Code Marketplace. Bridge to Kubernetes is one possible implementation of the Local Tunnel Debug capability.

There are two ways of starting to use local tunnel debugging in VS Code. The first way is to open the Command Palette (**CTRL**+**SHIFT**+**P** or **Cmd**+**Shift**+**P** on a Mac) and type **Kubernetes: Debug (Local Tunnel)**.

![Screenshot showing Debug (Local Tunnel) command in VS Code](media/bridge-to-kubernetes-vs-code/debug-local-tunnel.png)

Alternatively, navigate to your Kubernetes cluster explorer. Open the active cluster's resources and locate a service or pod you wish to debug, then right-click on the service and select **Debug: Local Tunnel**.

At this point, if you don't have any VS Code extension installed that offers local debugging capabilities, you'll be redirected to the Marketplace to select an extension that provides local debugging. Select the **Bridge to Kubernetes** extension.

![Screenshot showing Debug Local Tunnel context menu in VS Code](media/bridge-to-kubernetes-vs-code/debug-local-tunnel-context-menu.png)

After the Bridge to Kubernetes extension is installed, the next time you choose **Debug: Local Tunnel**, you'll skip the installation step and proceed directly to the next step, [Configure the debugger for local tunnel debugging with Bridge to Kubernetes](#configure-the-debugger-for-local-tunnel-debugging-with-bridge-to-kubernetes).

## Configure the debugger for local tunnel debugging with Bridge to Kubernetes

The first step in configuring the debugger for local tunnel debugging is that you're prompted to enter the TCP port that your application uses to run locally:

![Enter the port number](media/bridge-to-kubernetes-sample/enter-port.png)

Choose a debug launch configuration that you normally use when running your application locally. If you don't have a launch configuration, you can either let Bridge to Kubernetes create one, or choose not to create one, in which case you have to start your application or service manually. Learn more at [Launch configurations](https://code.visualstudio.com/docs/editor/debugging#_launch-configurations).

![Choose the debugger launch configuration](media/bridge-to-kubernetes-vs-code/choose-launch.png)

You have the option of running isolated or not isolated. If you run isolated, only your requests are routed to your local process; other developers can use the cluster without being affected. If you don't run isolated, all traffic is redirected to your local process. For more information on this option, see [Using routing capabilities for developing in isolation][btk-overview-routing].

![Choose isolation](media/bridge-to-kubernetes-sample/isolation.png)

Select the **Debug** icon on the left and select the newly added Kubernetes launch configuration, such as **Launch via NPM with Kubernetes**, at the top. This launch configuration is created by Bridge to Kubernetes, if you choose that option.

![Choose debug launch profile](media/bridge-to-kubernetes-sample/debug-profile.png)

> [!NOTE]
> You will be prompted to allow the **EndpointManager** to run elevated and modify your hosts file.

Your development computer is connected when the VS Code Status bar turns orange and the Kubernetes extension shows you are connected.

![Debugging with Bridge to Kubernetes](media/bridge-to-kubernetes-sample/debugging.png)

Once your development computer is connected, traffic starts redirecting to your development computer for the service you are replacing.

> [!NOTE]
> On subsequent launches, you will not be prompted for the service name, port, launch task, or whether to run isolated. These values are saved in `.vscode/tasks.json`. To change these settings later, open the Command Palette (**CTRL**+**SHIFT**+**P** or **Cmd**+**Shift**+**P** on a Mac), and run the command **Bridge to Kubernetes: Configure**. You can open *.vscode/launch.json* and *.vscode/tasks.json* to see the specific configuration settings that Bridge to Kubernetes adds to your launch profile.
>
>If your cluster uses [gRPC C core](https://github.com/grpc/grpc/), an implementation of gRPC that uses [c-ares](https://github.com/c-ares/c-ares), an environment variable is added to your launch profile, GRPC_DNS_RESOLVER, with the value `native`. This variable specifies to use a workaround to avoid a 2-minute time delay when connecting. For more information, see this [gRPC issue](https://github.com/grpc/grpc/issues/18691).

## Set a break point

Set a breakpoint with **F9** or selecting **Run** then **Toggle Breakpoint**.

Navigate to the sample application by opening the public URL. When your code reaches the breakpoint, it should open in the debugger. To resume the service, hit **Ctrl+F5** or select **Run** then **Continue**. Return to your browser and verify you see a placeholder image for the bike.

### Update your application

When you make code changes locally, whether or not they are visible to others who are using the cluster depends on whether you are running isolated or not. If you're running isolated, you can make changes that don't affect other users.

Edit your code, save your changes, and press **Ctrl**+**Shift**+**F5** (**⇧⌘F5** on a Mac) or select **Run** then **Restart Debugging**. After you are reconnected, refresh your browser and validate your changes.

Select **Run** then **Stop Debugging** or press **Shift**+**F5** to stop the debugger.

> [!NOTE]
> By default, stopping the debugging task also disconnects your development computer from your Kubernetes cluster. You can change this behavior by searching for **Bridge to Kubernetes: Disconnect After Debugging** in the Visual Studio Code settings and removing the check next to **Disconnect automatically when debugging stops**. After updating this setting, your development computer will remain connected when you stop and start debugging. To disconnect your development computer from your cluster, click on the Bridge to Kubernetes extension on the status bar then choose **Disconnect current session**.

## Additional configuration

Bridge to Kubernetes can handle routing traffic and replicating environment variables without any additional configuration. If you need to download any files that are mounted to the container in your Kubernetes cluster, such as a ConfigMap file, you can create a `KubernetesLocalProcessConfig.yaml` to download those files to your development computer. For more information, see [Configure Bridge to Kubernetes][kubernetesLocalProcessConfig-yaml].

If you're using an AKS cluster that uses managed identity, a security feature provided by Microsoft Entra ID, see [Use managed identity with Bridge to Kubernetes](managed-identity.md) for information about how to configure Bridge to Kubernetes for this scenario.

## Using logging and diagnostics

Logging output is written to the **Bridge to Kubernetes** window after your development computer is connected to your Kubernetes cluster.

Click on the **Kubernetes** Status bar and choose **Show connection diagnostics information**. This command prints the current environment variables and DNS entries in the logging output.

Additionally, you can find the diagnostic logs in the `Bridge to Kubernetes` directory in your development computer's TEMP directory. On Windows 10, that's in `%TEMP%\Bridge to Kubernetes`. On a Mac, the TEMP directory can be found by running `echo $TMPDIR` from a terminal window. On Linux, it is `/tmp/Bridge to Kubernetes`.

## Running in isolation mode

With Bridge to Kubernetes, you can also set up an isolated version the services you're working on, meaning that others who are using the cluster won't be affected by your changes. This isolation mode is accomplished by routing your requests to your copy of each affected service, but routing all other traffic normally. To access the local endpoint URL for the isolated app, launch the debugger in isolation mode, open the Kubernetes menu on the status bar, and choose the endpoint entry. You can find more about how routing works in isolation mode at [How Bridge to Kubernetes Works][btk-overview-routing].

## Header propagation

To use Bridge to Kubernetes the way it is designed, you need to make sure to propagate the Bridge to Kubernetes header from incoming requests to any requests that your services make to other services in the cluster. All HTTP request APIs, regardless of language, provide some framework-specific way to do this. For example, for .NET code in C#, you can use code similar to the following:

```csharp
var request = new HttpRequestMessage();
request.RequestUri = new Uri("http://mywebapi/api/values/1");
if (this.Request.Headers.ContainsKey("kubernetes-route-as"))
{
    // Propagate the dev space routing header
    request.Headers.Add("kubernetes-route-as", this.Request.Headers["kubernetes-route-as"] as IEnumerable<string>);
}
var response = await client.SendAsync(request);
```

> [!NOTE]
> To avoid affecting code at every request, you can create a class that inherits from [System.Net.Http.DelegatingHandler](/dotnet/api/system.net.http.delegatinghandler) and override the `SendAsync` method with code similar to the preceding example. You can find code using this technique on the web; one example is [Properly Propagating "kubernetes-route-as" in Bridge to Kubernetes](https://blogs.u2u.be/lander/post/2020/11/25/properly-propagating-kubernetes-route-as-in-bridge-to-kubernetes).

For Node.js services, you can use code similar to the following, taken from the todo-app sample in the [Bridge to Kubernetes repo](https://github.com/hsubramanianaks/b2k-samples):

```js
    server.get("/api/stats", function (req, res) {
        var options = {
            host: process.env.STATS_API_HOST,
            path: '/stats',
            method: 'GET'
        };
        const val = req.get('kubernetes-route-as');
        if (val) {
            console.log('Forwarding kubernetes-route-as header value - %s', val);
            options.headers = {
                'kubernetes-route-as': val
            }
        }
        var req = http.request(options, function(statResponse) {
            res.setHeader('Content-Type', 'application/json');
            var responseString = '';
            //another chunk of data has been received, so append it to `responseString`
            statResponse.on('data', function (chunk) {
                responseString += chunk;
            });
            statResponse.on('end', function () {
                res.send(responseString);
            });
        });

        req.on('error', function(e) {
            console.log('problem with request: ' + e.message);
          });

          req.end();
    });
```

## Communicating with other services

When you communicate with another service in the same Kubernetes cluster, for example with an HTTP request, you typically use the hardcoded service name in the URL for the request, but that won't work in some scenarios, such as when using Remote SSH, WSL, and Codespaces. [This article](kubernetes-environment-variables.md) describes how to use the Kubernetes service environment variables to specify the connection URL for these scenarios.

## Troubleshooting

 If you get this error when activating the Bridge to Kubernetes extension:

"Failed to update dependencies: maximum number of retries exceeded"

 First, retry the activation using the button. If it repeatedly does not succeed, see [https://github.com/microsoft/mindaro/issues/32](https://github.com/microsoft/mindaro/issues/32).

When you are using Bridge to Kubernetes in a remote SSH session, if EndpointManager fails, the issue might be that Bridge to Kubernetes cannot modify the hosts file due to a permissions issue. To enable remote SSH or running as non-elevated user, you should update your code to use Kubernetes service environment variables, and configure VS Code to use them, as described in the [Service environment variables](kubernetes-environment-variables.md) topic.

## Next steps

Learn more about Bridge to Kubernetes at [How Bridge to Kubernetes works][btk-how-it-works].

If you need to debug multiple services at the same time in parallel, see [Debug multiple services at the same time](parallel-services.md).

[azure-kubernetes-service]: /azure/aks/kubernetes-walkthrough
[azds-cli]: /azure/dev-spaces/how-to/install-dev-spaces#install-the-client-side-tools
[azds-tmp-dir]: /azure/dev-spaces/troubleshooting#before-you-begin
[btk-vs-code]: https://marketplace.visualstudio.com/items?itemName=mindaro.mindaro
[azure-cli]: /cli/azure/install-azure-cli
[azure-cloud-shell]: /azure/cloud-shell/overview
[az-aks-get-credentials]: /cli/azure/aks#az-aks-get-credentials
[az-aks-vs-code]: https://marketplace.visualstudio.com/items?itemName=ms-kubernetes-tools.vscode-aks-tools
[preview-terms]: https://azure.microsoft.com/support/legal/preview-supplemental-terms/
[supported-regions]: https://azure.microsoft.com/global-infrastructure/services/?products=kubernetes-service
[troubleshooting]: /azure/dev-spaces/troubleshooting#fail-to-restore-original-configuration-of-deployment-on-cluster
[vs-code]: https://code.visualstudio.com/download
[kubernetesLocalProcessConfig-yaml]: configure-bridge-to-kubernetes.md
[btk-how-it-works]: overview-bridge-to-kubernetes.md
[btk-overview-routing]: overview-bridge-to-kubernetes.md#using-routing-capabilities-for-developing-in-isolation
