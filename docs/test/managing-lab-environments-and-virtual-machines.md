---
title: "Managing Lab Environments and Virtual Machines"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "virtual environments [Lab Management], using"
ms.assetid: bd25cfb6-08da-4008-8a9f-e3e5ddb796eb
caps.latest.revision: 33
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
# Managing Lab Environments and Virtual Machines
You manage lab environments, physical machines, virtual machines, and templates in [!INCLUDE[TCMshort](../test/includes/tcmshort_md.md)], in **Lab Center**, using the **Lab** and **Library** tabs.  
  
> [!NOTE]
>  For an overview of lab environments, see [Using a Lab Environment for Your Application Lifecycle](../test/using-a-lab-environment-for-your-application-lifecycle.md). In addition, this topic assumes you understand the concepts in [Guidance for Creating and Managing SCVMM Environments](../test/guidance-for-creating-and-managing-scvmm-environments.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
 ![Lab Management Lab and Library tabs](../test/media/lmguide_lablibrary.png "LMGuide_LabLibrary")  
  
 The **Lab** tab lists the lab environments that have been deployed to your team project lab, and lets you perform these tasks on objects in the team project lab:  
  
1.  Connect to lab environments.  
  
2.  Connect to and manage virtual and physical machines using **Environment Viewer**.  
  
3.  Create, deploy, and manage standard environments and SCVMM environments  
  
4.  Copy a virtual machine and then store the copy in your team project library as a stored virtual machine or template  
  
5.  Copy an SCVMM environment and store the copy in your team project library  
  
6.  Create, restore, and manage snapshots of SCVMM environments  
  
 The **Library** tab lists SCVMM environments, virtual machines, and templates that are stored in your team project library. However, you can’t connect to or run tests on the lab environments and virtual machines in your team project library until you deploy them to your team project lab. Use the **Library** tab to perform these tasks:  
  
1.  Create a new SCVMM environment from stored virtual machines and templates, and then deploy that environment to your team project lab  
  
2.  Import stored virtual machines and templates from SCVMM to your team project library  
  
3.  Manage stored virtual machines, templates, and stored environments  
  
4.  Deploy a new copy of a stored environment to your team project lab  
  
##  <a name="start"></a> Before You Start  
 Before you manage lab environments, machines, and templates, configure your lab management components. See [Test on a lab environment](../test/test-on-a-lab-environment.md).  
  
## Tasks  
 These topics describe how to operate, modify, and manage your lab environments and the machines in those environments:  
  
|Task summary|More information|  
|------------------|----------------------|  
|Create a guest-based or host-based connection to the environment|-   [How to: Connect to machines in a Lab Environment](../test/how-to--connect-to-machines-in-a-lab-environment.md)|  
|Start, pause, shut down, power off, and delete an SCVMM environment|-   [How to: Operate an SCVMM Environment](../test/how-to--operate-an-scvmm-environment.md)|  
|Change properties of an SCVMM environment|-   [Viewing and Modifying Properties of an SCVMM Environment](../test/viewing-and-modifying-properties-of-an-scvmm-environment.md)|  
|Change properties of a virtual machine or template in an SCVMM environment|-   [Viewing and Modifying Properties of a Virtual Machine or Template in an SCVMM Environment](../test/viewing-and-modifying-properties-of-a-virtual-machine-or-template-in-an-scvmm-environment.md)|  
|Store a copy of a deployed virtual machine or template for use in another SCVMM environment|-   [How to: Store a Virtual Machine or Template](../test/how-to--store-a-virtual-machine-or-template.md)|  
|Add virtual machines and templates from System Center Virtual Machine Manager to your Team Project Library|-   [How to: Import a Virtual Machine or Template from SCVMM](../test/how-to--import-a-virtual-machine-or-template-from-scvmm.md)|  
|Store a copy of an SCVMM environment in your library so that you can run multiple instances|-   [How to: Store an SCVMM Environment](../test/how-to--store-an-scvmm-environment.md)|  
|Save a copy of an SCVMM environment as a restore point that you can share with other users|-   [Using Environment Snapshots with SCVMM Environments](../test/using-environment-snapshots-with-scvmm-environments.md)|  
  
##  <a name="next"></a> What’s Next  
 After you learn how to create and manage lab environments and virtual machines, you’re ready to run tests in your lab environments. Use these topics to get started:  
  
 **Run tests in your lab environment:** You can run manual and automated tests in your lab environment, using Microsoft Test Manager, the Tcm.exe command line utility, or a build-deploy-test workflow. See [Test on a lab environment](../test/test-on-a-lab-environment.md).  
  
 **Configure automated build, deployment, and testing:** Create build-deploy-test workflows to automatically create a build of your application, deploy the build to your lab environment, and run tests on the deployed application. See [Automated build-deploy-test workflows](../test/automated-build-deploy-test-workflows.md).  
  
## See Also  
 [Using a Lab Environment for Your Application Lifecycle](../test/using-a-lab-environment-for-your-application-lifecycle.md)   
 [Guidance for Creating and Managing SCVMM Environments](../test/guidance-for-creating-and-managing-scvmm-environments.md)   
 [Creating Lab Environments](../test/creating-lab-environments.md)