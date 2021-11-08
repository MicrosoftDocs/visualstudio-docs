---
title: Use Azure Pipelines for automated testing
description: Learn how you can implement automated testing for build-deploy-test automation using Azure Pipelines and Team Foundation Server.
ms.custom: SEO-VS-2020
ms.date: 10/19/2018
ms.topic: how-to
helpviewer_keywords:
  - automated testing, lab management, test lab
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
ms.workload:
  - multiple
author: mikejo5000
---
# Use Azure Test Plans instead of Lab Management for automated testing

If you use Microsoft Test Manager and Lab Management for automated testing or for build-deploy-test automation, this topic explains how you can achieve the same goals using the [build and release](/azure/devops/pipelines/index?view=vsts&preserve-view=true) features in Azure Pipelines and Team Foundation Server (TFS).

> [!NOTE]
> Microsoft Test Manager is deprecated in Visual Studio 2017 and removed in Visual Studio 2019.

## Build-deploy-test automation

Microsoft Test Manager and Lab Management rely on a XAML build definition to automate build, deployment, and testing of your applications. The XAML build relies on various constructs created in Microsoft Test Manager such as a lab environment, test suites, and testing settings, and on various infrastructure components such as a Build controller, Build agents, Test controller, and Test agents to achieve this goal. You can accomplish the same with fewer steps using Azure Pipelines or TFS.

| Steps | With XAML build | In a build or release |
|-------|----------------------|-----------------|
| Identify the machines to deploy the build to and run tests. | Create a standard lab environment in Microsoft Test Manager with those machines. | n/a |
| Identify the tests to be run. | Create a test suite in Microsoft Test Manager, create test cases, and associate automation with each test case. Create test settings in Microsoft Test Manager identifying the role of machines in the lab environment in which tests should be run. | Create automated test suite in Microsoft Test Manager in the same manner if you plan to manage your testing through test plans. Alternatively, you can skip this if you want to run tests directly from test binaries produced by your builds. There is no need to create test settings in either case. |
| Automate deployment and testing. | Create a XAML build definition using LabDefaultTemplate.*.xaml. Specify the build, test suites, and lab environment in the build definition. | Create a [build or release pipeline](/azure/devops/pipelines/index?view=vsts&preserve-view=true) with a single environment. Run the same deployment script (from the XAML build definition) using the Command line task, and run automated tests using Test Agent Deployment and Run Functional Tests tasks. Specify the list of machines and their credentials as inputs to these tasks. |

Some of the benefits of using Azure Pipelines or TFS for this scenario are:

* You do not need a Build controller or Test controller.
* The Test agent is installed through a task as part of the build or release.
* It is easy to customize the deployment steps. You are no longer restricted to use a single script. You can also take advantage of the many tasks that are available in the product as well as in Visual Studio Marketplace.
* You do not have to maintain test suites. You can directly run tests from binaries.
* You get a richer inline reporting experience for the tests that ran within each build or release.
* You can track which assets (release, build, work items, commits) are currently deployed and tested on each environment.
* You can customize and extend the automation to easily deploy to multiple test environments, and even to production.
* You can schedule the automation to happen whenever there is a check-in or commit, or at a specific time every day.

## Self-service management of SCVMM environments

The [Test Center in Microsoft Test Manager](/azure/devops/test/mtm/guidance-mtm-usage?view=vsts&preserve-view=true) supports the ability to manage a library of environment templates as well as provision environments on demand using an [SCVMM server](/system-center/vmm/overview?view=sc-vmm-1801&preserve-view=true).

The self-service provisioning features of Lab Center have two distinct goals:

* Provide a simpler way to manage the infrastructure. Managing VM and environment templates and automatically creating private networks to isolate clones of environments from each other were examples of infrastructure management.

* Provide a simpler way for teams to consume the virtual machines in their test and deployment activities. Making lab environments accessible through the same project security model, and integrated use of those virtual machines in test scenarios were examples of easy consumption.

However, given the evolution of richer public and private cloud management systems such as [Microsoft Azure](https://azure.microsoft.com/) and [Microsoft Azure Stack](https://azure.microsoft.com/overview/azure-stack/), there is no evolution of infrastructure management features in TFS 2017 and beyond. Instead, the focus on easy consumption of resources managed through such cloud infrastructures continues.

The following table summarizes the typical activities you perform in Lab Center, and how you can accomplish them through SCVMM or Azure (if they are infrastructure management activities) or through TFS and Azure DevOps Services (if they are test or deployment activities):

| Steps | With Lab Center | In a build or release |
|-------|-----------------|-----------------------|
| Manage a library of environment templates. | Create a lab environment. Install necessary software on the virtual machines. Sysprep and store the environment as a template in library. | Use SCVMM administration console directly to create and manage either virtual machine templates or service templates. When using Azure, select one of the [Azure quickstart templates](https://azure.microsoft.com/resources/templates/). |
| Create a lab environment. | Select an environment template in the library and deploy it. Provide the necessary parameters to customize the virtual machine configurations. | Use SCVMM administration console directly to create VMs or service instances from templates. Use Azure portal directly to create resources. Or, create a release definition with an environment. Use the Azure tasks or tasks from the [SCVMM Integration extension](https://marketplace.visualstudio.com/items?itemname=ms-vscs-rm.scvmmapp) to create new virtual machines. Creating a new release of this definition is equivalent to creating a new environment in Lab Center. |
| Connect to machines. | Open the lab environment in Environment viewer. | Use SCVMM administration console directly to connect to the virtual machines. Alternatively, use the IP address or DNS names of the virtual machines to open remote desktop sessions. |
| Take a checkpoint of an environment, or restore an environment to a clean checkpoint. | Open the lab environment in Environment viewer. Select the option to take a checkpoint or to restore to a previous checkpoint. | Use SCVMM administration console directly to perform these operations on virtual machines. Or, to perform these steps as part of a larger automation, include the checkpoint tasks from the [SCVMM Integration extension](https://marketplace.visualstudio.com/items?itemname=ms-vscs-rm.scvmmapp) as part of the environment in a release definition. |

## Create network-isolated environments

A network isolated lab environment is a group of SCVMM virtual machines that can be cloned safely without causing network conflicts. This was done in MTM using a series of instructions that used a set of network interface cards to configure the virtual machines in a private network, and another set of network interface cards to configure the virtual machines in a public network.

However, Azure Pipelines and TFS, in conjunction with the SCVMM build and deploy task, can be used to manage SCVMM environments, provision isolated virtual networks, and implement build-deploy-test scenarios. For example, you can use the task to:

* Create, restore, and delete checkpoints
* Create new virtual machines using a template
* Start and stop virtual machines
* Run custom PowerShell scripts for SCVMM

For more information, see [Create a virtual network isolated environment for build-deploy-test scenarios](/azure/devops/pipelines/targets/create-virtual-network?view=vsts&preserve-view=true).
