---
title: "How Bridge to Kubernetes works"
ms.technology: bridge
ms.custom: "contperf-fy22q1"
ms.date: 11/19/2020
ms.topic: "conceptual"
description: "Describes the processes for using Bridge to Kubernetes to connect your development computer to your Kubernetes cluster"
keywords: "Bridge to Kubernetes, Docker, Kubernetes, Azure, containers"
manager: jmartens
author: ghogen
ms.author: ghogen
---

# How Bridge to Kubernetes works

Bridge to Kubernetes allows you to run and debug code on your development computer, while still connected to your Kubernetes cluster with the rest of your application or services. For example, if you have a large microservices architecture with many interdependent services and databases, replicating those dependencies on your development computer can be difficult. Additionally, building and deploying code to your Kubernetes cluster for each code change during inner-loop development can be slow, time consuming, and difficult to use with a debugger.

Bridge to Kubernetes avoids having to build and deploy your code to your cluster by instead creating a connection directly between your development computer and your cluster. Connecting your development computer to your cluster while debugging allows you to quickly test and develop your service in the context of the full application without creating any Docker or Kubernetes configuration.

Bridge to Kubernetes redirects traffic between your connected Kubernetes cluster and your development computer. This traffic redirection allows code on your development computer and services running in your Kubernetes cluster to communicate as if they are in the same Kubernetes cluster. Bridge to Kubernetes also provides a way to replicate environment variables and mounted volumes available to pods in your Kubernetes cluster in your development computer. Providing access to environment variables and mounted volumes on your development computer allows you to quickly work on your code without having to replicate those dependencies manually.

In Visual Studio Code, Bridge to Kubernetes supports all languages as long as you can run them locally. In Visual Studio, Bridge to Kubernetes supports .NET Core; .NET Framework is not supported because it requires Windows nodes support, which Bridge to Kubernetes doesn't have.

> [!WARNING]
> Bridge to Kubernetes is intended for use in development and testing scenarios only. It is not intended or supported for use with production clusters or live services in active use.

Information about the currently supported features and a future roadmap for Bridge to Kubernetes may be found at [Bridge to Kubernetes roadmap](https://github.com/microsoft/mindaro/projects/1).

## Using Bridge to Kubernetes

To use Bridge to Kubernetes in Visual Studio, you need VS Code with the [Bridge to Kubernetes extension](https://aka.ms/bridge-to-k8s-vsc-extension) installed, or [Visual Studio 2019][visual-studio] version 16.7 Preview 4 or greater running on Windows 10 with the *ASP.NET and web development* workload installed and the [Bridge to Kubernetes Extension][btk-extension] installed. When you use Bridge to Kubernetes to establish a connection to your Kubernetes cluster, you have the option of redirecting all traffic to and from an existing pod in the cluster to your development computer.

> [!NOTE]
> When using Bridge to Kubernetes, you are prompted for the name of the service to redirect to your development computer. This option is a convenient way to identify a pod for redirection. All redirection between your Kubernetes cluster and your development computer is for a pod.

When Bridge to Kubernetes establishes a connection to your cluster, it:

* Prompts you to configure the service to replace on your cluster, the port on your development computer to use for your code, and the launch task for your code as a one-time action.
* Replaces the container in the pod on the cluster with a remote agent container that redirects traffic to your development computer.
* Runs [kubectl port-forward][kubectl-port-forward] on your development computer to forward traffic from your development computer to the remote agent running in your cluster.
* Collects environment information from your cluster using the remote agent. This environment information includes environment variables, visible services, volume mounts, and secret mounts.
* Sets up the environment in Visual Studio so the service on your development computer can access the same variables as if it were running on the cluster.
* Updates your hosts file to map services on your cluster to local IP addresses on your development computer. These hosts file entries allow code running on your development computer to make requests to other services running in your cluster. To update your hosts file, Bridge to Kubernetes will ask for administrator access on your development computer when connecting to your cluster.
* Starts running and debugging your code on your development computer. If necessary, Bridge to Kubernetes will free required ports on your development computer by stopping services or processes that are currently using those ports.

After you establish a connection to your cluster, you can run and debug code natively on your computer, without containerization, and the code can directly interact with the rest of your cluster. Any network traffic the remote agent receives is redirected to the local port specified during the connection so your natively running code can accept and process that traffic. The environment variables, volumes, and secrets from your cluster are made available to code running on your development computer. Also, due to the hosts file entries and port forwarding added to your developer computer by Bridge to Kubernetes, your code can send network traffic to services running on your cluster using the service names from your cluster, and that traffic gets forwarded to the services that are running in your cluster. Traffic is routed between your development computer and your cluster the entire time you're connected.

In addition, Bridge to Kubernetes provides a way to replicate environment variables and mounted files available to pods in your cluster on your development computer through the `KubernetesLocalProcessConfig.yaml` file. You can also use this file to create new environment variables and volume mounts.

> [!NOTE]
> For the duration of the connection to the cluster (plus an additional 15 minutes), Bridge to Kubernetes runs a process called *EndpointManager* with admin permissions on your local computer.

> [!NOTE]
> You can debug in parallel, with multiple services, but you need to launch as many instances of Visual Studio as services you want to debug. Make sure that your services listen on different ports locally, and then configure and debug them separately. Isolation is not supported in this scenario.

## Additional configuration with KubernetesLocalProcessConfig.yaml

The `KubernetesLocalProcessConfig.yaml` file allows you to replicate environment variables and mounted files available to your pods in your cluster. When using Visual Studio for Bridge to Kubernetes development, the KubernetesLocalConfig.yaml file must be located in the same directory as the project file for the service you are redirecting. For more information on the additional configuration options, see [Configure Bridge to Kubernetes][using-config-yaml].

## Using routing capabilities for developing in isolation

By default, Bridge to Kubernetes redirects all traffic for a service to your development computer. You also have the option to use routing capabilities to only redirect requests to a service originating from a subdomain to your development computer. These routing capabilities allow you to use Bridge to Kubernetes to develop in isolation and avoid disrupting other traffic in your cluster.

The following animation shows two developers working on the same cluster in isolation:

![Animated GIF illustrating isolation](media/bridge-to-kubernetes/btk-graphic-isolated.gif)

When you enable working in isolation, Bridge to Kubernetes does the following in addition to connecting to your Kubernetes cluster:

* Verifies Kubernetes cluster does not have Azure Dev Spaces enabled.
* Replicates your chosen service in the cluster in the same namespace and adds a *routing.visualstudio.io/route-from=SERVICE_NAME* label and *routing.visualstudio.io/route-on-header=kubernetes-route-as=GENERATED_NAME* annotation.
* Configures and starts the routing manager in the same namespace on the Kubernetes cluster. The routing manager uses a label selector to look for the *routing.visualstudio.io/route-from=SERVICE_NAME* label and  *routing.visualstudio.io/route-on-header=kubernetes-route-as=GENERATED_NAME* annotation when configuring routing in your namespace.

If Bridge to Kubernetes detects that Azure Dev Spaces is enabled on your Kubernetes cluster, you are prompted to disable Azure Dev Spaces before you can use Bridge to Kubernetes.

The routing manager does the following when it starts up:

* Duplicates all ingresses (including load balancer ingresses) found in the namespace using the *GENERATED_NAME* for the subdomain.
* Creates an envoy pod for each service associated with duplicated ingresses with the *GENERATED_NAME* subdomain.
* Creates an additional envoy pod for the service you are working on in isolation. This allows requests with the subdomain to be routed to your development computer.
* Configures routing rules for each envoy pod to handle routing for services with the subdomain.

The following diagram shows a Kubernetes cluster before Bridge to Kubernetes connects to your cluster:

![Diagram of cluster without Bridge to Kubernetes](media/bridge-to-kubernetes/kubernetes-cluster.svg)

The following diagram shows the same cluster with Bridge to Kubernetes enabled in isolation mode. Here, you can see the duplicate service and the envoy pods that support routing in isolation.

![Diagram of cluster with Bridge to Kubernetes enabled](media/bridge-to-kubernetes/kubernetes-cluster-dev-computer.svg)

When a request with the *GENERATED_NAME* subdomain is received on the cluster, a *kubernetes-route-as=GENERATED_NAME* header is added to the request. The envoy pods handle routing that request to the appropriate service in the cluster. If the request is routed to the service that is being worked on in isolation, that request is redirected to your development computer by the remote agent.

When a request without the *GENERATED_NAME* subdomain is received on the cluster, no header is added to the request. The envoy pods handle routing that request to the appropriate service in the cluster. If the request is routed to the service that is being replaced, that request is instead routed to the original service instead of the remote agent.

> [!IMPORTANT]
> Each service on your cluster must forward the *kubernetes-route-as=GENERATED_NAME* header when making additional requests. For example, when *serviceA* receives a request, it then makes a request to *serviceB* before return a response. In this example, *serviceA* needs to forward the *kubernetes-route-as=GENERATED_NAME* header in its request to *serviceB*. Some languages, such as [ASP.NET][asp-net-header], may have methods for handling header propagation.

When you disconnect from your cluster, by default, Bridge to Kubernetes will remove all the envoy pods and the duplicate service.

> [!NOTE]
> The routing manager deployment and service will remain running in your namespace. To remove the deployment and service run the following commands for your namespace.
>
> ```azurecli
> kubectl delete deployment routingmanager-deployment -n NAMESPACE
> kubectl delete service routingmanager-service -n NAMESPACE
> ```

## Diagnostics and logging

When using Bridge to Kubernetes to connect to your cluster, diagnostic logs from your cluster are logged to your development computer's *TEMP* directory in the *Bridge to Kubernetes* folder.

## RBAC authorization

Kubernetes provides Role-based Access Control (RBAC) to manage permissions for users and groups. For information, see the [Kubernetes documentation](https://kubernetes.io/docs/reference/access-authn-authz/rbac/) You can set the permissions for an RBAC-enabled cluster by creating a YAML file and using `kubectl` to apply it to the cluster. 

To set permissions on the cluster, create or modify a YAML file such as *permissions.yml* like the following, using your own namespace for `<namespace>` and the subjects (users and groups) that need access.

```yml
kind: RoleBinding
apiVersion: rbac.authorization.k8s.io/v1
metadata:
  name: bridgetokubernetes-<namespace>
  namespace: development
subjects:
  - kind: User
    name: jane.w6wn8.k8s.ginger.eu-central-1.aws.gigantic.io
    apiGroup: rbac.authorization.k8s.io
  - kind: Group
    name: dev-admin
    apiGroup: rbac.authorization.k8s.io
roleRef:
  kind: ClusterRole
  name: admin
  apiGroup: rbac.authorization.k8s.io
```

Apply the permissions by using the command:

```cmd
kubectl -n <namespace> apply -f <yaml file name>
```

## Limitations

Bridge to Kubernetes has the following limitations:

* A pod may only have a single container running in that pod for Bridge to Kubernetes to successfully connect.
* Currently, Bridge to Kubernetes pods must be Linux containers. Windows containers are not supported.
* Bridge to Kubernetes needs elevated permissions to run on your development computer in order to edit your hosts file.
* Bridge to Kubernetes can't be used on clusters with Azure Dev Spaces enabled.

### Bridge to Kubernetes and clusters with Azure Dev Spaces enabled

You can't use Bridge to Kubernetes on a cluster with Azure Dev Spaces enabled. If you would like to use Bridge to Kubernetes on a cluster with Azure Dev Spaces enabled, you must disable Azure Dev Spaces before connecting to your cluster.

## Next steps

To get started using Bridge to Kubernetes to connect to your local development computer to your cluster, see [Use Bridge to Kubernetes (VS)](bridge-to-kubernetes-vs.md) or [Use Bridge to Kubernetes (VS Code)](bridge-to-kubernetes-vs-code.md).

[asp-net-header]: https://www.nuget.org/packages/Microsoft.AspNetCore.HeaderPropagation/
[azds-cli]: /azure/dev-spaces/how-to/install-dev-spaces#install-the-client-side-tools
[azds-tmp-dir]: /azure/dev-spaces/troubleshooting#before-you-begin
[azure-cli]: /cli/azure/install-azure-cli?view=azure-cli-latest&preserve-view=true
[bridge-to-kubernetes-vs]: bridge-to-kubernetes.md
[kubectl-port-forward]: https://kubernetes.io/docs/reference/generated/kubectl/kubectl-commands#port-forward
[visual-studio]: https://visualstudio.microsoft.com/downloads/
[btk-extension]: https://marketplace.visualstudio.com/items?itemName=ms-azuretools.mindaro
[using-config-yaml]: configure-bridge-to-kubernetes.md
