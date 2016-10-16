---
title: "Deploying a Stored SCVMM Environment"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 7b15cafa-5dd4-40a3-822c-2ba0308000b9
caps.latest.revision: 10
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
# Deploying a Stored SCVMM Environment
You can store an SCVMM environment in your team projects library, and then create new copies of the environment by deploying copies of it.  
  
 This topic is about how to create deploy a copy of an SCVMM environment. To store an SCVMM environment in your team project library, see [How to: Store an SCVMM Environment](../test/how-to--store-an-scvmm-environment.md). For information about the other ways to create and manage SCVMM environments, see [Guidance for Creating and Managing SCVMM Environments](../test/guidance-for-creating-and-managing-scvmm-environments.md). For an overview of lab environments, see [Using a Lab Environment for Your Application Lifecycle](../test/using-a-lab-environment-for-your-application-lifecycle.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
### To deploy a stored environment  
  
1.  In [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], choose **Lab Center**, **Library**, **Environments**.  
  
     The list of available environments is displayed. These environments have been previously defined by team members.  
  
     If you cannot see an environment that you want to use, you can do one of the following:  
  
    -   Create an environment from stored virtual machines. After creating an environment, you can shut it down and store it in the library. For more information, see [Creating an SCVMM Environment Using Stored Virtual Machines and Templates](../test/creating-an-scvmm-environment-using-stored-virtual-machines-and-templates.md)  
  
    -   Create an environment and add it directly to the library. This method allows you to include templates in the stored environment. Templates are virtual machines from which the computer name has been removed. Templates avoid name conflicts when the environment is deployed. Choose **New** and then follow the wizard. For more information, see [How to: Store an SCVMM Environment](../test/how-to--store-an-scvmm-environment.md).  
  
2.  Select an environment from the list and choose **Deploy**.  
  
     Follow the instructions in the wizard.  
  
##  <a name="next"></a> What’s next  
 Here are the tasks that you can perform after you deploy an SCVMM environment:  
  
-   Operate your environment, and manage the virtual machines in the environment. See [Managing Lab Environments and Virtual Machines](../test/managing-lab-environments-and-virtual-machines.md).  
  
-   Run manual and automated tests in your lab environment by using Microsoft Test Manager, the Tcm.exe command line utility, or a build-deploy-test workflow. See [Test on a lab environment](../test/test-on-a-lab-environment.md).  
  
-   Create build-deploy-test workflows to automate the process of creating a build of your application, deploying the build to your lab environment, and running tests on the deployed application. See [Automated build-deploy-test workflows](../test/automated-build-deploy-test-workflows.md).  
  
## See Also  
 [Creating Lab Environments](../test/creating-lab-environments.md)   
 [Using a Lab Environment for Your Application Lifecycle](../test/using-a-lab-environment-for-your-application-lifecycle.md)   
 [Guidance for Creating and Managing SCVMM Environments](../test/guidance-for-creating-and-managing-scvmm-environments.md)   
 [How to: Store an SCVMM Environment](../test/how-to--store-an-scvmm-environment.md)