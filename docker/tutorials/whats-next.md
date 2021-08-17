---
title: "Docker tutorial - What's next"
description: Describes options for extending Docker apps with orchestration, using Cloud Native Computing Foundation projects.
ms.date: "08/06/2021"
author: nebuk89
ms.author: ghogen
manager: jmartens
ms.technology: vs-docker
ms.custom: "contperf-fy22q1"

ms.topic: conceptual
ms.workload:
  - "azure"
---
# What's next

Although you're done with your tutorial, there's still a LOT more to learn about containers!
You're not going to go deep-dive here, but here are a few other areas to look at next!

## Container orchestration

Running containers in production is tough. You don't want to log into a machine and simply run a
`docker run` or `docker-compose up`. Why not? Well, what happens if the containers die? How do you
scale across several machines? Container orchestration solves this problem. Tools like Kubernetes,
Swarm, Nomad, and AKS all help solve this problem, all in slightly different ways.

The general idea is that you have "managers" who receive **expected state**. This state might be
"I want to run two instances of my web app and expose port 80." The managers then look at all of the
machines in the cluster and delegate work to "worker" nodes. The managers watch for changes (such as
a container quitting) and then work to make **actual state** reflect the expected state.

## Cloud Native Computing Foundation projects

The CNCF is a vendor-neutral home for various open-source projects, including Kubernetes, Prometheus, 
Envoy, Linkerd, NATS, and more! You can view the [graduated and incubated projects here](https://www.cncf.io/projects/)
and the entire [CNCF Landscape here](https://landscape.cncf.io/). There are a LOT of projects to help
solve problems around monitoring, logging, security, image registries, messaging, and more!

So, if you're new to the container landscape and cloud-native application development, welcome! Please
connect to the community, ask questions, and keep learning! We're excited to have you!

## Working with Docker in VS Code

Learn more about using the VS Code Docker extension:

- [VS Code Docker Extension overview](https://code.visualstudio.com/docs/containers/overview)
- [Get started with Node.js](https://code.visualstudio.com/docs/containers/quickstart-node)
- [Get started with Python](https://code.visualstudio.com/docs/containers/quickstart-python)
- [Get started with .NET Core](https://code.visualstudio.com/docs/containers/quickstart-aspnet-core)
- [Debug containerized apps](https://code.visualstudio.com/docs/containers/debug-common)
