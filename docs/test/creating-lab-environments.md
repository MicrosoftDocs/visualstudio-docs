---
title: "Creating Lab Environments"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio ALM, setting up virtual environments"
ms.assetid: 19105786-2a8b-4afd-94ea-102cfe3c01bf
caps.latest.revision: 69
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Creating Lab Environments
To create either standard lab environments or SCVMM lab environments, you use **Lab Center** in [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. For an introduction to lab environments, see [Using a Lab Environment for Your Application Lifecycle](../test/using-a-lab-environment-for-your-application-lifecycle.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
##  <a name="start"></a> Before you start  
 Before you create lab environments, you might need to configure your lab management components. See [Test on a lab environment](../test/test-on-a-lab-environment.md).  
  
> [!IMPORTANT]
>  To create a lab environment that can contain physical or virtual machines that are running Windows XP, perform the additional steps listed in [Configuring Lab Environments that Contain Windows XP or Windows Server 2003 Machines](../test/configuring-lab-environments-that-contain-windows-xp-or-windows-server-2003-machines.md).  
  
##  <a name="thissection"></a> Creating a lab environment  
 To create a lab environment, open **Microsoft Test Manager**, choose **Lab Center**, and then choose the **Lab** tab. A list appears, showing the environments already deployed in your team project collection. Use this tab to create lab environments and manage those that are running. For information about managing lab environments and importing or creating stored virtual machines and templates, see [Managing Lab Environments and Virtual Machines](../test/managing-lab-environments-and-virtual-machines.md).  
  
 ![Environment list under Lab Center, Lab tab.](../test/media/lm_envwiz_start.png "LM_EnvWiz_Start")  
  
 Follow these steps to create each type of lab environment:  
  
|Task|Description|  
|----------|-----------------|  
|**Create a standard environment**|You create a standard environment from virtual and physical machines that are already running, and then you can add virtual machines that are running on any virtualization platform.<br /><br /> 1.  Choose **New**.<br />2.  In the **New Environment** wizard, choose **Standard environment**.<br />3.  Follow the instructions to add machines to the environment.<br /><br /> For more information, see [Standard lab environments](../test/standard-lab-environments.md)|  
|**Create an SCVMM Environment using running virtual machines**|You can quickly create an SCVMM environment from virtual machines that are already running in an SCVMM host group. You can add a running virtual machine to only one lab environment at a time. However, when you delete the environment, you can add its virtual machines to another lab environment. Here’s how to create an SCVMM environment using running virtual machines:<br /><br /> 1.  Choose **New**.<br />2.  In the **New Environment** wizard, choose **SCVMM environment**.<br />3.  Follow the wizard instructions to add running virtual machines to the environment.<br /><br /> For more information, see [SCVMM (virtual) environments](../test/scvmm--virtual--environments.md).|  
|**Create an SCVMM environment using stored virtual machines and virtual machine templates**|You can create a new SCVMM environment by choosing virtual machines and virtual machine templates that are stored in your Lab Management library. When you choose a stored virtual machine, a copy of that virtual machine is added to your environment. When you add a template to your environment, a new virtual machine is created based on that template; however, you must create an identity for that virtual machine before you can add it to your environment.<br /><br /> Here’s how to create a new SCVMM environment from stored virtual machines and templates.<br /><br /> 1.  Choose **New**.<br />2.  In the new environment wizard, choose **SCVMM environment**.<br />3.  Follow the wizard instructions to add stored virtual machines to the environment.<br /><br /> For more information, see [Creating an SCVMM Environment Using Stored Virtual Machines and Templates](../test/creating-an-scvmm-environment-using-stored-virtual-machines-and-templates.md).|  
|**Deploy a copy of a stored environment**|To deploy a copy of an SCVMM environment that is stored in your Lab Management library, follow these steps:<br /><br /> 1.  Choose the **Deploy** button.<br />     A list of available environments appears, showing environments that team members have defined.<br />2.  Select an environment from the list.<br />3.  Enter a name for your new environment.<br />4.  Choose **Deploy the Environment**.<br /><br /> For more information, see [Deploying a Stored SCVMM Environment](../test/deploying-a-stored-scvmm-environment.md).|  
|**Create a network isolated environment**|A network isolated environment is protected from network conflicts, so you can simultaneously run copies of one virtual machine in multiple environments. For more information, see [Creating and using a network isolated environment](../test/creating-and-using-a-network-isolated-environment.md).|  
  
##  <a name="next"></a> What’s Next  
 Here are the tasks that you can perform after you create a lab environment:  
  
-   Learn how to operate your lab environments, and how to manage lab environments and virtual machines, such as by using snapshots and creating templates. See [Managing Lab Environments and Virtual Machines](../test/managing-lab-environments-and-virtual-machines.md).  
  
-   Run manual and automated tests in your lab environment by using Microsoft Test Manager, the Tcm.exe command line utility, or a build-deploy-test workflow. See [Test on a lab environment](../test/test-on-a-lab-environment.md).  
  
-   Create build-deploy-test workflows to automate the process of creating a build of your application, deploying the build to your lab environment, and running tests on the deployed application. See [Automated build-deploy-test workflows](../test/automated-build-deploy-test-workflows.md).  
  
## See Also  
 [Using a Lab Environment for Your Application Lifecycle](../test/using-a-lab-environment-for-your-application-lifecycle.md)   
 [Test on a lab environment](../test/test-on-a-lab-environment.md)