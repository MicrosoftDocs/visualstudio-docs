---
title: "Using a Lab Environment for Your Application Lifecycle"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b435eb39-dc7c-46fa-a91b-6e6dd614f01c
caps.latest.revision: 111
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Using a Lab Environment for Your Application Lifecycle
You can create and manage lab environments with the Lab Management features of Microsoft Test Manager. A lab environment is a collection of virtual and physical machines, which you can use to develop and test applications. A lab environment can contain multiple roles needed to test multi-tiered applications, such as workstations, web servers, and database servers. In addition, you can use a build-deploy-test workflow with your lab environment to automate the process of building, deploying, and running automated tests on your application.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, Visual Studio Test Professional  
  
 You must use a lab environment to gain the following benefits:  
  
1.  **Use a test plan to run automated tests** − You can run a collection of automated tests, called a *test plan*, and view the progress using Microsoft Test Manager.  
  
2.  **Use a build-deploy-test workflow** − You can use a build-deploy-test workflow to test multi-tiered applications automatically. A typical example is a workflow that starts a build, deploys the build files onto the appropriate machines in a lab environment, and then performs automated tests. In addition, you can schedule your workflow to run at specific intervals.  
  
3.  **Collect diagnostic data from all machines, even during manual testing** − You can collect diagnostic data from multiple machines simultaneously. For example, during a single test run, you can collect IntelliTrace, test impact, and other forms of data from a web server, a database server, and a client.  
  
4.  **Automatic test agent installation** − Lab Management automatically installs test agents on every machine in your environment.  
  
 If you use Lab Management in conjunction with System Center Virtual Machine Manager (SCVMM), you can also get these benefits when you use lab environments:  
  
-   **Quickly reproduce machine configurations** − You can store collections of virtual machines that are configured to recreate typical production environments. You can then perform each test run on a new copy of a stored environment.  
  
-   **Reproduce the exact conditions of a bug** – When a test run fails, you can store a copy of the state of your lab environment, and access it from your build results or a work item.  
  
-   **Run multiple copies of a lab environment at the same time** – You can run multiple copies of your lab environment at the same time without naming conflicts.  
  
 Here are examples of common types of lab environments:  
  
|||  
|-|-|  
|![Client&#45;server lab environment](../dv_TeamTestALM/media/topology_clientserver.png "topology_clientserver")|-   This lab environment has a *client/server topology*, which is often used to test an application that has server and client components. In a client/server topology, all of the client and server machines used to test your application are in your lab environment. When you use this topology, you can collect test data from every machine that impacts your tests.|  
|![Server only topology](../dv_TeamTestALM/media/topology_backend.png "topology_backend")|-   This lab environment has a *server topology*, which is often used to run manual tests on server applications, and which allows testers to use their own client machines to verify bugs in the environment. In a backend topology, your lab environment contains only servers. When you use this type of topology, you typically connect to the servers in the lab environment using a client machine that is not part the environment.|  
  
 See [Video: Managing lab environments for testing](http://go.microsoft.com/fwlink/?LinkID=252614).  
  
## Standard Environments and SCVMM Environments  
 There are two types of lab environments that you can create with Visual Studio Lab Management—standard Environments and SCVMM Environments.  However, the capabilities of each type of environment are different.  
  
 **Standard Environments:** Standard environments can contain a mix of virtual and physical machines. You can also add virtual machines to a standard environment that are managed by third-party virtualization frameworks. In addition, standard environments do not require additional server resources such as an SCVMM server.  
  
 **SCVMM environments:** SCVMM environments can only contain virtual machines that are managed by SCVMM (System Center Virtual Machine Manager), so the virtual machines in SCVMM environments can only run on the Hyper-V virtualization framework. However, SCVMM environments provide the following automation and management features that are not available in standard environments:  
  
> [!NOTE]
>  For information on SCVMM, see [Virtual Machine Manager](http://go.microsoft.com/fwlink/?LinkId=226332).  
  
-   **Environment snapshots:** Environment snapshots contain the state of a lab environment, so you can quickly restore a clean environment, or save the state of an environment that has been modified. You can also use a build-deploy-test workflow to automate the process of saving and restoring environment snapshots.  
  
-   **Stored environments:** You can store a copy of an SCVMM environment, and then deploy multiple copies of that environment.  
  
-   **Network isolation:** Network isolation allows you to simultaneously run multiple identical copies of an SCVMM environment without computer name conflicts.  
  
-   **Virtual machine templates:** A virtual machine template is a virtual machine that has had its name and other identifiers removed. When a VM template is deployed in an SCVMM environment, Microsoft Test Manager generates new identifiers. This allows you deploy multiple copies of a virtual machine in the same environment, or multiple environments, and then run the virtual machines simultaneously.  
  
-   **Stored Virtual Machines:** A virtual machine that is stored in your Team Project library and includes unique identifiers.  
  
 For more information about these features, see [Guidance for Creating and Managing SCVMM Environments](../dv_TeamTestALM/Guidance-for-Creating-and-Managing-SCVMM-Environments.md).  
  
 Standard environments and SCVMM environments support many of the same features. However, there are some important differences to consider. The following table compares the features that are available for standard environments and SCVMM environments.  
  
|Capability|SCVMM Environments|Standard Environments|  
|----------------|------------------------|---------------------------|  
|**Testing**|||  
|Run manual tests|Supported|Supported|  
|Run coded UI and other automated tests|Supported|Supported|  
|File rich bugs using diagnostic adapters|Supported|Supported|  
|**Build deployment**|||  
|Automatic build-deploy-test workflows|Supported|Supported|  
|**Environment creation and management**|||  
|Use physical machines in addition to virtual machines|Not supported|Supported|  
|Use third-party virtual machines|Not supported|Supported|  
|Automatically install test agents onto machines in the lab environment|Supported|Supported|  
|Save and deploy the state of a lab environment using environment snapshots|Supported|Not supported|  
|Create lab environments from VM templates|Supported|Not supported|  
|Start/stop/snapshot environment|Supported|Not supported|  
|Connect to the environment using Environment Viewer|Supported|Supported|  
|Run multiple copies of an environment at the same time using network isolation|Supported|Not supported|  
  
## Lab management concepts  
 Here are some additional concepts that you should be familiar with before you continue:  
  
|Term|Description|  
|----------|-----------------|  
|Lab Center|The area of Microsoft Test Manager where you create and manage lab environments.|  
|Team Project Lab|The collection of lab environments that have been set up so you can connect to them and run their virtual machines.|  
|Team Project Library|An archive of stored virtual machines, templates, and stored lab environments that have been imported into the host group of your team project. You can use the items in your library with SCVMM environments; however, you can’t add them directly to a standard environment. You can’t run the items in your library; instead you use them to deploy a new environment.|  
|Deployed Environment|A lab environment that has been deployed to your team project lab so that you can connect to it and run its machines.|  
  
## Next Steps  
  
|Task|Related content|  
|----------|---------------------|  
|**Configure Lab Management components:** Determine the components that you need to configure before you can create, view, or modify lab environments.|[Test on a lab environment](../dv_TeamTestALM/Test-on-a-lab-environment.md)|  
|**Plan your SCVMM environments:** Before you create or manage an SCVMM environment, decide whether to use running virtual machines, stored virtual machines, templates, a stored environment, and whether to enable network isolation.|[Guidance for Creating and Managing SCVMM Environments](../dv_TeamTestALM/Guidance-for-Creating-and-Managing-SCVMM-Environments.md)|  
|**Learn more about network isolation:** If you want to run multiple identical copies of a lab environment, including unique identifying information, use an SCVMM environment and enable network isolation.|[Cloning Virtual Machines through Network Isolation](../dv_TeamTestALM/Cloning-Virtual-Machines-through-Network-Isolation.md)|  
|**Create new lab environments:** After you configure lab management, you can create standard environments and SCVMM environments, or you can deploy a copy of an SCVMM environment.|[Creating Lab Environments](../dv_TeamTestALM/Creating-Lab-Environments.md)|  
|**Manage your lab environments and virtual machines** After you create a lab environment, you can connect to the environment, view the environment, modify the environment, and create environment snapshots. You can then manage your environments, virtual machines, and templates in your Team Project Library.|[Managing Lab Environments and Virtual Machines](../dv_TeamTestALM/Managing-Lab-Environments-and-Virtual-Machines.md)|  
|**Run tests in your lab environment:** You can run manual and automated tests in your lab environment, using Microsoft Test Manager, the Tcm.exe command line utility, or a build-deploy-test workflow.|[Running Tests in Lab Environments](assetId:///f32d85ef-9a80-4cb8-9ad4-6601e20ba1e7)|  
|**Configure automated build, deployment, and testing:** Create build-deploy-test workflows to automate the process of creating a build of your application, deploying the build to your lab environment, and running tests on the deployed application.|[Automated build-deploy-test workflows](../dv_TeamTestALM/Automated-build-deploy-test-workflows.md)|  
|**Fix issues in your lab environment:** If you encounter trouble creating or connecting to your lab environment, you might need to repair the environment, or in some configurations, take extra steps to configure the environment.|[Troubleshooting Lab Management](../dv_TeamTestALM/Troubleshooting-Lab-Management.md)|  
  
## External resources  
  
### Guidance and hands-on lab  
 [Testing for Continuous Delivery with Visual Studio 2012](http://go.microsoft.com/fwlink/?LinkID=255187)  
  
 [Testing for Continuous Delivery with Visual Studio 2012– Chapter 3: Lab Environments](http://go.microsoft.com/fwlink/?LinkID=255192)  
  
 [Visual Studio Lab Management Guide](http://go.microsoft.com/fwlink/?LinkID=230951)  
  
### Videos  
 [Managing lab environments for testing](http://go.microsoft.com/fwlink/?LinkID=252614)  
  
### Forum  
 [Visual Studio ALM + Team Foundation Server Blog](http://go.microsoft.com/fwlink/?LinkID=254496)  
  
## See Also  
 [Test apps early and often](../dv_TeamTestALM/Test-apps-early-and-often.md)   
 [Setting Up Test Machines to Run Tests or Collect Data](../dv_TeamTestALM/Setting-Up-Test-Machines-to-Run-Tests-or-Collect-Data.md)