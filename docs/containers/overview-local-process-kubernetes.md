---
title: "How Local Process with Kubernetes works"
ms.technology: vs-azure
ms.date: 06/02/2020
ms.topic: "conceptual"
description: "Describes the processes for using Local Process with Kubernetes to connect your development computer to your Kubernetes cluster"
keywords: "Local Process with Kubernetes, Docker, Kubernetes, Azure, containers"
monikerRange: ">=vs-2019"
manager: jillfra
author: ghogen
ms.author: ghogen
---

# How Local Process with Kubernetes works

Local Process with Kubernetes allows you to run and debug code on your development computer, while still connected to your Kubernetes cluster with the rest of your application or services. For example, if you have a large microservices architecture with many interdependent services and databases, replicating those dependencies on your development computer can be difficult. Additionally, building and deploying code to your Kubernetes cluster for each code change during inner-loop development can be slow, time consuming, and difficult to use with a debugger.

Local Process with Kubernetes avoids having to build and deploy your code to your cluster by instead creating a connection directly between your development computer and your cluster. Connecting your development computer to your cluster while debugging allows you to quickly test and develop your service in the context of the full application without creating any Docker or Kubernetes configuration.

Local Process with Kubernetes redirects traffic between your connected Kubernetes cluster and your development computer. This traffic redirection allows code on your development computer and services running in your Kubernetes cluster to communicate as if they are in the same Kubernetes cluster. Local Process with Kubernetes also provides a way to replicate environment variables and mounted volumes available to pods in your Kubernetes cluster in your development computer. Providing access to environment variables and mounted volumes on your development computer allows you to quickly work on your code without having replicate those dependencies manually.

> [!WARNING]
> Local Process for Kubernetes is intended for use in development and testing scenarios only. It is not intended or supported for use with production clusters or live services in active use.

## Using Local Process with Kubernetes

To use Local Process with Kubernetes in Visual Studio, you need [Visual Studio 2019][visual-studio] version 16.7 Preview 4 or greater running on Windows 10 with the *ASP.NET and web development* workload installed and the [Local Process Kubernetes Extension][lpk-extension] installed. When you use Local Process with Kubernetes to establish a connection to your Kubernetes cluster, you have the option of redirecting all traffic to and from an existing pod in the cluster to your development computer.

> [!NOTE]
> When using Local Process with Kubernetes, you are prompted for the name of the service to redirect to your development computer. This option is a convenient way to identify a pod for redirection. All redirection between your Kubernetes cluster and your development computer is for a pod.

When Local Process with Kubernetes establishes a connection to your cluster, it:

* Prompts you to configure the service to replace on your cluster, the port on your development computer to use for your code, and the launch task for your code as a one-time action.
* Replaces the container in the pod on the cluster with a remote agent container that redirects traffic to your development computer.
* Runs [kubectl port-forward][kubectl-port-forward] on your development computer to forward traffic from your development computer to the remote agent running in your cluster.
* Collects environment information from your cluster using the remote agent. This environment information includes environment variables, visible services, volume mounts, and secret mounts.
* Sets up the environment in Visual Studio so the service on your development computer can access the same variables as if it were running on the cluster.  
* Updates your hosts file to map services on your cluster to local IP addresses on your development computer. These hosts file entries allow code running on your development computer to make requests to other services running in your cluster. To update your hosts file, Local Process with Kubernetes will ask for administrator access on your development computer when connecting to your cluster.
* Starts running and debugging your code on your development computer. If necessary, Local Process with Kubernetes will free required ports on your development computer by stopping services or processes that are currently using those ports.

After you establish a connection to your cluster, you can run and debug code natively on your computer, without containerization, and the code can directly interact with the rest of your cluster. Any network traffic the remote agent receives is redirected to the local port specified during the connection so your natively running code can accept and process that traffic. The environment variables, volumes, and secrets from your cluster are made available to code running on your development computer. Also, due to the hosts file entries and port forwarding added to your developer computer by Local Process with Kubernetes, your code can send network traffic to services running on your cluster using the service names from your cluster, and that traffic gets forwarded to the services that are running in your cluster. Traffic is routed between your development computer and your cluster the entire time you're connected.

In addition, Local Process with Kubernetes provides a way to replicate environment variables and mounted files available to pods in your cluster on your development computer through the `KubernetesLocalProcessConfig.yaml` file. You can also use this file to create new environment variables and volume mounts.

## Additional configuration with KubernetesLocalProcessConfig.yaml

The `KubernetesLocalProcessConfig.yaml` file allows you to replicate environment variables and mounted files available to your pods in your cluster. For more information on the additional configuration options, see [Configure Local Process with Kubernetes][using-config-yaml].

## Using routing capabilities for developing in isolation

By default, Local Process with Kubernetes redirects all traffic for a service to your development computer. You also have the option to use routing capabilities to only redirect requests to a service originating from a subdomain to your development computer. These routing capabilities allow you to use Local Process with Kubernetes to develop in isolation and avoid disrupting other traffic in your cluster.

The following animation shows two developers working on the same cluster in isolation:

![Animated GIF illustrating isolation](media/local-process-kubernetes/lpk-graphic-isolated.gif)

When you enable working in isolation, Local Process with Kubernetes does the following in addition to connecting to your Kubernetes cluster:

* Verifies Kubernetes cluster does not have Azure Dev Spaces enabled.
* Replicates your chosen service in the cluster in the same namespace and adds a *routing.visualstudio.io/route-from=SERVICE_NAME* label and *routing.visualstudio.io/route-on-header=kubernetes-route-as: GENERATED_NAME* annotation.
* Configures and starts the routing manager in the same namespace on the Kubernetes cluster. The routing manager uses a label selector to look for the *routing.visualstudio.io/route-from=SERVICE_NAME* label and  *routing.visualstudio.io/route-on-header=kubernetes-route-as: GENERATED_NAME* annotation when configuring routing in your namespace.

If Local Process with Kubernetes detects that Azure Dev Spaces is enabled on your Kubernetes cluster, you are prompted to disable Azure Dev Spaces before you can use Local Process with Kubernetes.

The routing manager does the following when it starts up:
* Duplicates all ingresses found in the namespace using the *GENERATED_NAME* for the subdomain. 
* Creates an envoy pod for each service associated with duplicated ingresses with the *GENERATED_NAME* subdomain.
* Creates an additional envoy pod for the service you are working on in isolation. This allows requests with the subdomain to be routed to your development computer.
* Configures routing rules for each envoy pod to handle routing for services with the subdomain.

When a request with the *GENERATED_NAME* subdomain is received on the cluster, a *kubernetes-route-as=GENERATED_NAME* header is added to the to the request. The envoy pods handle routing that request to the appropriate service in the cluster. If the request is routed to the service that is being worked on in isolation, that request is redirected to your development computer by the remote agent.

When a request without the *GENERATED_NAME* subdomain is received on the cluster, no header is added to the request. The envoy pods handle routing that request to the appropriate service in the cluster. If the request is routed to the service that is being replaced, that request is instead routed to the original service instead of the remote agent.

> [!IMPORTANT]
> Each service on your cluster must forward the *kubernetes-route-as=GENERATED_NAME* header when making additional requests. For example, when *serviceA* receives a request, it then makes a request to *serviceB* before return a response. In this example, *serviceA* needs to forward the *kubernetes-route-as=GENERATED_NAME* header in its request to *serviceB*. Some languages, such as [ASP.NET][asp-net-header], may have methods for handling header propagation.

When you disconnect from your cluster, by default, Local Process with Kubernetes will remove all the envoy pods and the duplicate service. 

> [NOTE]
> The routing manager deployment and service will remain running in your namespace. To remove the deployment and service run the following commands for your namespace.
>
> ```azurecli
> kubectl delete deployment routingmanager-deployment -n NAMESPACE
> kubectl delete service routingmanager-service -n NAMESPACE
> ```

## Diagnostics and logging

When using Local Process with Kubernetes to connect to your cluster, diagnostic logs from your cluster are logged to your development computer's [temporary directory][azds-tmp-dir].

## Limitations

Local Process with Kubernetes has the following limitations:

* Local Process with Kubernetes redirects traffic for a single service to your development computer. You can't use Local Process with Kubernetes to redirect multiple services at the same time.
* A service must be backed by a single pod in order to connect to that service. You can't connect to a service with multiple pods, such as a service with replicas.
* A pod may only have a single container running in that pod for Local Process with Kubernetes to successfully connect. Local Process with Kubernetes can't connect to services with pods that have additional containers, such as sidecar containers injected by services meshes.
* Local Process with Kubernetes needs elevated permissions to run on your development computer in order to edit your hosts file.
* Local Process with Kubernetes can't be used on clusters with Azure Dev Spaces enabled.

### Local Process with Kubernetes and clusters with Azure Dev Spaces enabled

You can't use Local Process with Kubernetes on a cluster with Azure Dev Spaces enabled. If you would like to use Local Process with Kubernetes on a cluster with Azure Dev Spaces enabled, you must disable Azure Dev Spaces before connecting to your cluster.

## Next steps

To get started using Local Process with Kubernetes to connect to your local development computer to your cluster, see [Use Local Process with Kubernetes](local-process-kubernetes.md).

[asp-net-header]: https://www.nuget.org/packages/Microsoft.AspNetCore.HeaderPropagation/
[azds-cli]: /azure/dev-spaces/how-to/install-dev-spaces#install-the-client-side-tools
[azds-tmp-dir]: /azure/dev-spaces/troubleshooting#before-you-begin
[azure-cli]: /cli/azure/install-azure-cli?view=azure-cli-latest
[local-process-kubernetes-vs]: local-process-kubernetes.md
[kubectl-port-forward]: https://kubernetes.io/docs/reference/generated/kubectl/kubectl-commands#port-forward
[visual-studio]: https://visualstudio.microsoft.com/downloads/
[lpk-extension]: https://marketplace.visualstudio.com/items?itemName=ms-azuretools.mindaro
[using-config-yaml]: configure-local-process-with-kubernetes.md