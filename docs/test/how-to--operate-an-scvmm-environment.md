---
title: "How to: Operate an SCVMM Environment"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "virtual environments [Lab Management], operate"
  - "Visual Studio ALM, operate a virtual environment"
ms.assetid: ec35b61b-4b57-44ff-aa7d-7d27e925ddf4
caps.latest.revision: 18
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
# How to: Operate an SCVMM Environment
As you work with an environment, the specific actions that you can take depend on whether that environment is active or stored. An active environment is an environment that is deployed to and running on a host group. A stored environment is an environment that is stored in the team project library share.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
 The following table summarizes the actions that you can take on an active or on a stored environment.  
  
|Operation|Active|Stored|  
|---------------|------------|------------|  
|[Deploy](#Deploy)|No|Yes|  
|[Start](#Start)|Yes|No|  
|[Pause](#Pause)|Yes|No|  
|[Shut down](#Shutdown)|Yes|No|  
|[Power off](#Off)|Yes|No|  
|[Store to library](#Store)|Yes|No|  
|[Delete](#Delete)|Yes|Yes|  
  
 You can also change the properties of an active or stored environment. For more information, see [Viewing and Modifying Properties of an SCVMM Environment](../test/viewing-and-modifying-properties-of-an-scvmm-environment.md).  
  
##  <a name="Deploy"></a> Deploy an Environment  
 You can deploy an environment that is stored. Deploying a stored environment creates a copy of each virtual machine or template. The original stored environment is left unchanged in the library. For more information about how to deploy an environment, see [Deploying a Stored SCVMM Environment](../test/deploying-a-stored-scvmm-environment.md).  
  
##  <a name="Start"></a> Start an Environment  
 You can start an environment that is in the Stopped, Paused, or Mixed state. Starting an environment powers on all the virtual machines in that environment and configures the environment capabilities asynchronously. The environment transitions into a Running state as the virtual machines are booting up. If any of the virtual machines fail to start, then the environment is put into a Mixed state. From this state, you can try to start the environment again after you fix the underlying issues. After the machines start, the agents that reside on them finish the configuration.  
  
 The following illustration summarizes the steps to start an environment.  
  
 ![Steps to start a virtual environment](../test/media/startenvironment.png "StartEnvironment")  
  
#### To start an environment  
  
1.  In **Lab Center**, choose the **Lab** tab, and then choose **Environments**.  
  
2.  In the list of environments, choose the environment you want to start.  
  
3.  On the menu bar, choose **Start**. Alternatively, you can right-click the environment and then choose **Start**.  
  
##  <a name="Pause"></a> Pause an Environment  
 You can pause an environment that is in the Running state. When you are not using an environment to run tests or deployment scripts, you can pause it, stop it, or store it in the library to save resources. Pausing an environment is useful when you want to freeze the execution in the middle of a session and come back and resume the session exactly from that point. Pausing holds the CPU execution of each virtual machine of that environment and keeps the virtual machines as they are on the hosts. Pausing does not release any CPU, memory, or disk resources on the physical hosts.  
  
 If pause operation fails, the environment is in a Mixed state. From that state, you can retry the Pause operation.  
  
#### To pause an environment  
  
1.  In **Lab Center**, choose the **Lab** tab, and then choose **Environments**.  
  
2.  In the list of environments, choose the environment you want to pause.  
  
3.  On the menu bar, choose **Pause**. Alternatively, you can right-click the environment and then choose **Pause**.  
  
##  <a name="Shutdown"></a> Shut down an Environment  
 You can shut down an environment that is in the Running, Paused, or Mixed state. If you are taking a longer break in your active work, you can shut down the environment to release the CPU and memory resources held by the virtual machines on the physical host. You might also have to shut down an environment to make a copy of it to store in the library.  
  
 This operation shuts down all the virtual machines in an environment. If any of the virtual machines fails to shut down, then the environment is put into a Mixed state. From this state, you can try to the shut down the environment again after you fix the underlying issues.  
  
##  <a name="Off"></a> Power Off an Environment  
 You can turn off an environment that is in the Running, Paused, or Mixed state. This operation powers off all the virtual machines in an environment. If any of the virtual machines fails to power off, then the environment is put into a Mixed state. From this state, you can try to the stop the environment again after you fix the underlying issues.  
  
 The **Power off** operation simply turns off all the virtual machines and does not shut down the operating system in each of them. We recommend that you use the shut down operation instead of abruptly turning off an environment.  
  
#### To power off an environment  
  
1.  In **Lab Center**, choose the **Lab** tab, and then choose **Environments**.  
  
2.  In the list of environments, choose the environment you want to turn off.  
  
3.  On the menu bar, choose **Power off**. Alternatively, you can right-click the environment and then choose **Power off**.  
  
##  <a name="Store"></a> Store to Library  
 You can store an environment that is in the Running, Paused, or Mixed state. This operation shuts down the environment and moves the environment into the team project library.  
  
##  <a name="Delete"></a> Delete an Environment  
 Deleting the environment releases all the resources held by the environment on hosts and library servers. You can delete an environment that is in a state other than:  
  
-   Creating  
  
-   Starting  
  
-   Deleting  
  
-   Running  
  
-   Stopped or Stored while another copy of that environment is being created.  
  
#### To delete an environment  
  
1.  In **Lab Center**, choose the **Lab** tab, and then choose **Environments**.  
  
2.  In the list of environments, choose the environment you want to delete.  
  
3.  On the menu bar, choose the **X** (Delete) button.  
  
## See Also  
 [How to: Connect to machines in a Lab Environment](../test/how-to--connect-to-machines-in-a-lab-environment.md)   
 [Viewing and Modifying Properties of an SCVMM Environment](../test/viewing-and-modifying-properties-of-an-scvmm-environment.md)