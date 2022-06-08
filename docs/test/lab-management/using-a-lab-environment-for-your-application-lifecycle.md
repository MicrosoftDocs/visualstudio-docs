---
title: Use a lab environment for devops
description: Learn about lab environments and how to use the cloud with Azure Pipelines or Team Foundation Server Build and Release.
ms.custom: SEO-VS-2020
ms.date: 05/02/2017
ms.topic: how-to
helpviewer_keywords:
  - lab environment, test lab
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
ms.workload:
  - multiple
author: mikejo5000
---
# Use a lab environment for your devops

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

A lab environment is a collection of virtual and physical machines that you can use to develop and test applications. A lab environment can contain multiple roles needed to test multi-tiered applications, such as workstations, web servers, and database servers. In addition, you can use a build-deploy-test workflow with your lab environment to automate the process of building, deploying, and running automated tests on your application.

* **Use a test plan to run automated tests** - You can run a collection of automated tests, called a *test plan*, and view the progress.

* **Use a build-deploy-test workflow** - You can use a build-deploy-test workflow to test multi-tiered applications automatically. A typical example is a workflow that starts a build, deploys the build files onto the appropriate machines in a lab environment, and then performs automated tests. In addition, you can schedule your workflow to run at specific intervals.

* **Collect diagnostic data from all machines, even during manual testing** - You can collect diagnostic data from multiple machines simultaneously. For example, during a single test run, you can collect IntelliTrace, test impact, and other forms of data from a web server, a database server, and a client.

Here are examples of common lab environment topologies:

| Topology | Description |
|---|---|
|![Server only topology](../media/topology_backend.png)| This lab environment has a *server topology*, which is often used to run manual tests on server applications, and which allows testers to use their own client machines to verify bugs in the environment. In a backend topology, your lab environment contains only servers. When you use this type of topology, you typically connect to the servers in the lab environment using a client machine that is not part the environment.|
|![Cloud lab environment](../media/topology_cloud.png)| This lab environment provides similar capabilities and features as the _server topology_, but removes the requirement for physical or virtual machines running in a local environment; which can reduce setup time, simplify maintenance, and minimize cost. Setting up multiple websites and virtual machines, together with custom networking,  is quick and easy in a cloud environment such as Microsoft Azure.|
|![Client-server lab environment](../media/topology_clientserver.png)| This lab environment has a *client-server topology*, which is often used to test an application that has server and client components. In a client/server topology, all of the client and server machines used to test your application are in your lab environment. When you use this topology, you can collect test data from every machine that impacts your tests.|

## Use the cloud with Azure Pipelines or Team Foundation Server Build and Release

You can perform automated testing and build-deploy-test automation using the [build and release](/azure/devops/pipelines/index?view=vsts&preserve-view=true) features in Team Foundation Server (TFS) and Azure Test Plans. Some of the benefits are:

* You do not need a Build controller or Test controller.
* The Test agent is installed through a task as part of the build or release.
* It is easy to customize the deployment steps. You are no longer restricted to use a single script. You can also take advantage of the many tasks that are available in the product as well as in Visual Studio Marketplace.
* You don't have to maintain test suites. You can directly run tests from binaries.
* You get a richer inline reporting experience for the tests that run within each build or release.
* You can track which assets (release, build, work items, commits) are currently deployed and tested on each environment.
* You can customize and extend the automation to easily deploy to multiple test environments, and even to production.
* You can schedule the automation to happen whenever there is a check-in or commit, or at a specific time every day.

For more information, see [Use Build or Release management](use-build-or-rm-instead-of-lab-management.md).


## See also

* [Install and configure test agents](../../test/lab-management/install-configure-test-agents.md)
* [Visual Studio Lab Management Guide](/archive/blogs/visualstudioalmrangers/library-of-tooling-and-guidance-solutions-aka-msvsarsolutions)
* [Microsoft DevOps Blog](https://devblogs.microsoft.com/devops/)