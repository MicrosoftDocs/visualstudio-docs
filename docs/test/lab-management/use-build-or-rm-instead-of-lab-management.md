---
title: "Use Build or Release Management for automated testing | Microsoft Docs"
ms.custom: ""
ms.date: "05/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-devops-test
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "automated testing, lab management, test lab"
ms.author: gewarren
manager: ghogen
ms.workload: 
  - "multiple"
author: gewarren
---
# Use Build and Release Management instead of Lab Management for automated testing

If you use Microsoft Test Manager (MTM) and Lab Management for 
automated testing or for build-deploy-test automation, 
this topic explains how you can achieve the same goals using the 
[Build &amp; Release](https://www.visualstudio.com/team-services/continuous-integration/)
features in Team Foundation Server (TFS) and Visual Studio Team Services:

* [Build-deploy-test automation](#bdtautomation)

* [Self-service management of SCVMM environments](#managescvmm)

Build and Release Management do not support self-service
creation of network isolated SCVMM environments, and there are
no plans to provide this support in the future. However, there
are some [suggested alternatives](#isolatedenvir).

<a name="bdtautomation"></a>
## Build-deploy-test automation

MTM and Lab Management rely on a XAML build definition to 
automate build, deployment, and testing of your applications.
The XAML build relies on various constructs created in MTM 
such as a lab environment, test suites, and testing settings,
and on various infrastructure components such as a Build
controller, Build agents, Test controller, and Test agents to
achieve this goal. You can accomplish the same with fewer
steps using Build or Release Management in TFS and Team Services.

| Steps | With XAML Build | With Build or Release Management |
|-------|----------------------|-----------------|
| Identify the machines to deploy the build to and run tests. | Create a standard lab environment in MTM with those machines. | n/a |
| Identify the tests to be run. | Create a test suite in MTM, create test cases, and associate automation with each test case. Create test settings in MTM identifying the role of machines in the lab environment in which tests should be run. | Create automated test suite in MTM in the same manner if you plan to manage your testing through test plans. Alternatively, you can skip this if you want to run tests directly from test binaries produced by your builds. There is no need to create test settings in either case. |
| Automate deployment and testing. | Create a XAML build definition using LabDefaultTemplate.*.xaml. Specify the build, test suites, and lab environment in the build definition. | Create a [build definition or a release definition](https://www.visualstudio.com/team-services/continuous-integration/) with a single environment. Run the same deployment script (from the XAML build definition) using the Command line task, and run automated tests using Test Agent Deployment and Run Functional Tests tasks. Specify the list of machines and their credentials as inputs to these tasks. |

Some of the benefits of using Build or Release Management for this scenario are:

* You do not need a Build controller or Test controller.
* The Test agent is installed through a task as part of the build or release.
* It is easy to customize the deployment steps. You are no longer restricted to use a single script. You can also take advantage of the many tasks that are available in the product as well as in Visual Studio Marketplace.
* You do not have to maintain test suites. You can directly run tests from binaries.
* You get a richer inline reporting experience for the tests that ran within each build or release.
* You can track which assets (release, build, work items, commits) are currently deployed and tested on each environment.
* You can customize and extend the automation to easily deploy to multiple test environments, and even to production.
* You can schedule the automation to happen whenever there is a check-in or commit, or at a specific time every day.

<a name="managescvmm"></a>
## Self-service management of SCVMM environments

The [Lab Center in Microsoft Test Manager](https://msdn.microsoft.com/library/dd997438.aspx) supports the ability
to manage a library of environment templates as well as provision
environments on demand using an [SCVMM server](https://technet.microsoft.com/system-center-docs/vmm/vmm).

The self-service provisioning features of Lab Center have two distinct goals:

* Provide a simpler way to manage the infrastructure. Managing VM and environment
  templates and automatically creating private networks to isolate clones of
  environments from each other were examples of infrastructure management.

* Provide a simpler way for teams to consume the virtual machines in their test
  and deployment activities. Making lab environments accessible through the same
  team project security model, and integrated use of those virtual machines in
  test scenarios were examples of easy consumption.

However, given the evolution of richer public and private cloud 
management systems such as [Microsoft Azure](https://azure.microsoft.com/)
and [Microsoft Azure Stack](https://azure.microsoft.com/overview/azure-stack/), 
there is no evolution of infrastructure management features 
in TFS 2017 and beyond. Instead, the focus on easy 
consumption of resources managed through such cloud 
infrastructures continues.

The following table summarizes the typical activities you 
used to perform in Lab Center, and how you can accomplish 
them through SCVMM or Azure (if they are infrastructure 
management activities) or through TFS and Team Services (if 
they are test or deployment activities):

| Steps | With Lab Center | With Build or Release Management |
|-------|----------------------|-----------------|
| Manage a library of environment templates. | Create a lab environment. Install necessary software on the virtual machines. Sysprep and store the environment as a template in library. | Use SCVMM administration console directly to create and manage either virtual machine templates or service templates. When using Azure, select one of the pre-defined [Azure Resource Manager templates](https://azure.microsoft.com/documentation/templates/) from the [Azure Marketplace](https://azure.microsoft.com/marketplace/) or from [Azure quick start templates](https://azure.microsoft.com/documentation/templates/). |
| Create a lab environment. | Select an environment template in the library and deploy it. Provide the necessary parameters to customize the virtual machine configurations. | Use SCVMM administration console directly to create VMs or service instances from templates. Use Azure portal directly to create resources. Or, create a release definition with an environment. Use the Azure tasks or tasks from the [SCVMM Integration extension](https://marketplace.visualstudio.com/items?itemname=ms-vscs-rm.scvmmapp) to create new virtual machines. Creating a new release of this definition is equivalent to creating a new environment in Lab Center. |
| Connect to machines. | Open the lab environment in Environment viewer. | Use SCVMM administration console directly to connect to the virtual machines. Alternatively, use the IP address or DNS names of the virtual machines to open remote desktop sessions. |
| Take a checkpoint of an environment, or restore an environment to a clean checkpoint. | Open the lab environment in Environment viewer. Select the option to take a checkpoint or to restore to a previous checkpoint. | Use SCVMM administration console directly to perform these operations on virtual machines. Or, to perform these steps as part of a larger automation, include the checkpoint tasks from the [SCVMM Integration extension](https://marketplace.visualstudio.com/items?itemname=ms-vscs-rm.scvmmapp) as part of the environment in a release definition. |

<a name="isolatedenvir"></a>
## Self-service creation of network isolated environments

A network isolated lab environment is a group of SCVMM 
virtual machines that can be cloned safely without causing 
network conflicts. This was done in MTM using a series of 
instructions that used a set of network interface cards to 
configure the virtual machines in a private network, and 
another set of network interface cards to configure the 
virtual machines in a public network.

With the evolution of richer public and private cloud 
management systems such as [Microsoft Azure](https://azure.microsoft.com/)
and [Microsoft Azure Stack](https://azure.microsoft.com/overview/azure-stack/), 
you can rely more on the cloud management tools 
directly for similar capabilities. There is no equivalent way
to accomplish this goal in Build and Release Management.

You are encouraged to consider the following alternatives if 
you need network isolation:

* One motivation for network isolation has been the ease of 
  configuration of multiple clones. As each clone is an exact 
  replica of the original, the computer names and configuration
  settings are preserved as is, and this makes it easy to set 
  up new environments. However, the same benefit causes 
  problems to arise later in the lifecycle (for example, in
  production) because the way applications are finally deployed
  is not in the same. **Instead**, consider setting up new
  environments in the same way that you set up production, and
  avoid using network isolation.

* Use a public cloud infrastructure such as [Microsoft Azure](https://azure.microsoft.com/)
  for your testing needs. You can easily use 
  [Azure Resource Manager templates](https://azure.microsoft.com/documentation/templates/) from the [Azure Marketplace](https://azure.microsoft.com/marketplace/) or from [Azure quick start templates](https://azure.microsoft.com/documentation/templates/)
  to set up groups of virtual machines that are 
  connected through a private network, and are exposed to the 
  public network only using a proxy or a 'jumpbox'.
