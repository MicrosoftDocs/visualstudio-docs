---
title: "How to: Store an SCVMM Environment"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 52b9484b-0265-4774-abeb-e1c0cadf4e96
caps.latest.revision: 11
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
# How to: Store an SCVMM Environment
A *stored environment* is a set of configuration files, virtual machines, and templates that are located on the library servers of the System Center Virtual Manager (SCVMM) for a team project. Stored environments are one way to create deployed environments. A stored environment cannot be started and run. When you deploy a stored environment, virtual machines are created on the team project host groups from the templates and stored virtual machines of the stored environment. When configured correctly, you can deploy multiple copies of a stored environment at the same time without creating computer name conflicts in the external domain. For more information, see [Avoiding Computer Name Conflicts](#AvoidingComputerNameConflicts) in this topic.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
 This topic describes how to create and use stored environments in the following situations:  
  
|||  
|-|-|  
|[Archiving deployed environments](#ArchivingDeployedEnvironments)|Store an environment for later use when you delete a deployed environment.|  
|[Creating stored environments from stored virtual machines and templates](#CreatingaStoredEnvironmentFromStoredVirtualMachinesAndTemplates)|Create a stored environment from virtual machines or templates in the project library.|  
|[Creating a stored network isolated environment](#CreatingaStoredEnvironmentFromaDeployedEnvironmentThatUsesNetworkIsolation)|Store a network isolated environment to create exact duplicates of an environment that can run at the same time.|  
|[Creating a stored environment from a deployed environment](#CreatingaStoredEnvironmentFromaDeployedEnvironmentThatDoesNotUseNetworkIsolation)|Prepare the virtual machines in a deployed environment for re-use and then store the environment to create functionally identical environments that do not use network isolation. You can create stored environments of the following types:<br /><br /> -   [Stored environments of templates](#CreatingaStoredEnvironmentofTemplatesFromaDeployedEnvironment)<br />-   [Stored environments of virtual machines](#CreatingaStoredEnvironmentOfVirtualMachinesFromaDeployedEnvironment)|  
  
##  <a name="AvoidingComputerNameConflicts"></a> Avoiding Computer Name Conflicts  
 A primary consideration in creating any type of virtual environment is avoiding naming conflicts in a domain. Naming conflicts occur when two or more computers share domain identifiers such as computer names or IP addresses. If multiple copies of a virtual machine are running (active) in a domain or workgroup and share one or more of these identifiers, a naming conflict can, and frequently will, occur. A naming conflict between two machines can result in the following situations:  
  
-   One or both of the machines are disconnected from the network.  
  
-   Network traffic is incorrectly targeted. If two machines have the same identity on a network, a command or message that is intended for one machine might be sent to the second.  
  
 The ways that you avoid naming conflicts when you create stored environments depend on whether you use network isolation in your environment and whether you create a stored environment of templates or virtual machines.  
  
-   **Using network isolation**. The network isolation capability of an environment provides a unique identity alias to the external domain for the virtual machines inside an environment. You must make sure that the internal computer names of the machines in a network isolated environment are unique, but the same internal computer name can be used in multiple environments. See the section [Creating a Stored Environment From a Deployed Environment That Uses Network Isolation](#CreatingaStoredEnvironmentFromaDeployedEnvironmentThatUsesNetworkIsolation) in this topic  
  
-   **Using templates**. When you use templates to create a stored environment that does not use network isolation, you can configure a template to automatically generate a unique computer name when it is deployed as a virtual machine. You can also configure the template to connect to the external domain automatically. See the section [Creating a Stored Environment of Templates From a Deployed Environment](#CreatingaStoredEnvironmentofTemplatesFromaDeployedEnvironment) in this topic.  
  
-   **Using stored virtual machines**. To avoid computer name conflicts, a best practice is to create stored virtual machines as workgroup machines; that is, as machines that are not automatically joined to the external domain. If you use virtual machines in a stored environment and you do not use network isolation, you have the responsibility to manually provide a unique computer name for the machines that are created when the environment is deployed and then connect those machines to the external domain. See the section [Creating a Stored Environment Of Virtual Machines From a Deployed Environment](#CreatingaStoredEnvironmentOfVirtualMachinesFromaDeployedEnvironment) in this topic.  
  
##  <a name="ArchivingDeployedEnvironments"></a> Archiving Deployed Environments  
 You can store a deployed environment when you want to delete the environment but you also want to be able to re-create it later. To archive a deployed environment, follow these steps:  
  
1.  In the **Lab** tab of [!INCLUDE[TCMshort](../test/includes/tcmshort_md.md)], make sure that the environment is stopped.  
  
2.  Select the environment, and then choose **Store to library** on the toolbar.  
  
3.  After a copy of the environment has been stored in the team project library, delete the deployed environment.  
  
 The stored environment is an exact duplicate of the deployed environment. Unless the deployed environment used network isolation, only one copy of the archived environment can be deployed at the same time.  
  
##  <a name="CreatingaStoredEnvironmentFromStoredVirtualMachinesAndTemplates"></a> Creating a Stored Environment From Stored Virtual Machines And Templates  
 If the deployed environments that you want to create from a stored environment do not require extensive configuration, such as installing applications or server roles, you can create a stored environment in the team project library directly from the existing stored virtual machines and templates.  
  
 To create a stored environment from stored virtual machines and templates in the team project library, follow these steps:  
  
1.  In the **Library** tab of [!INCLUDE[TCMshort](../test/includes/tcmshort_md.md)], choose **Environments**.  
  
2.  Choose **New**.  
  
3.  Follow the procedure that is described in the **To create an environment from virtual machines or templates** section of [Creating an SCVMM Environment Using Stored Virtual Machines and Templates](../test/creating-an-scvmm-environment-using-stored-virtual-machines-and-templates.md).  
  
 If you use virtual machines in the stored environment, you must make sure that the virtual machines that are created in the deployed environment have unique identities in the external domain.  
  
##  <a name="CreatingaStoredEnvironmentFromaDeployedEnvironmentThatUsesNetworkIsolation"></a> Creating a Stored Environment From a Deployed Environment That Uses Network Isolation  
 Creating an initial deployed environment that uses network isolation usually involves two steps. You first create a deployed environment from stored virtual machines, templates, or a combination of stored virtual machines and templates. You then start the deployed environment and perform additional configuration tasks such as connecting the virtual machines to an internal Active Directory domain. After the deployed environment is created and configured, you can create a stored environment in two steps:  
  
1.  In the In the **Library** tab of [!INCLUDE[TCMshort](../test/includes/tcmshort_md.md)], make sure that the environment is shut down.  
  
2.  Choose **Store to library** on the toolbar.  
  
 When you deploy an environment that uses network isolation, [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] adds an additional network adapter to each virtual machine that presents a unique alias identity to the external domain. Therefore, you can deploy multiple copies of the stored environment at the same time without encountering computer name conflicts.  
  
 For more information, see [Creating and using a network isolated environment](../test/creating-and-using-a-network-isolated-environment.md).  
  
##  <a name="CreatingaStoredEnvironmentFromaDeployedEnvironmentThatDoesNotUseNetworkIsolation"></a> Creating a Stored Environment from a Deployed Environment that Does Not Use Network Isolation  
 The virtual machines in an environment that does not use network isolation might require a significant amount of configuration. For example, you might have to install additional software on some machines, and configure specialized roles and features on server machines. These kinds of configurations can only be performed on machines in deployed environments. When this is the case, you can create a stored environment from a deployed environment. Although you can create a stored environment that is made up of both templates and stored virtual machines, a best practice that reduces the possibility of mistakes is to use only templates or only virtual machines in a stored environment.  
  
###  <a name="CreatingaStoredEnvironmentofTemplatesFromaDeployedEnvironment"></a> Creating a stored environment of templates from a deployed environment  
 You cannot directly create a stored environment of templates from a deployed environment. However, you can create the templates for the stored environment from the virtual machines of the deployed environment, and then re-create the environment in the library. To create a stored environment of templates from a deployed environment, follow these steps:  
  
1.  Create the initial environment. For more information, see [Creating an SCVMM Environment Using Stored Virtual Machines and Templates](../test/creating-an-scvmm-environment-using-stored-virtual-machines-and-templates.md). Create the environment in the team project **Lab**.  
  
2.  To create the templates, follow the procedures that are described in [How to: Store a Virtual Machine or Template](../test/how-to--store-a-virtual-machine-or-template.md).  
  
3.  To create the stored environment, Follow the procedure that is described in the **To create an environment from virtual machines or templates** section of [Creating an SCVMM Environment Using Stored Virtual Machines and Templates](../test/creating-an-scvmm-environment-using-stored-virtual-machines-and-templates.md). Create the environment in the team project **Library**.  
  
 When you create a template, you can configure it to assign a unique identity to each virtual machine that is created from the template. By using this configuration option, you can deploy multiple copies of the stored environment at the same time without encountering computer name conflicts.  
  
###  <a name="CreatingaStoredEnvironmentOfVirtualMachinesFromaDeployedEnvironment"></a> Creating a stored environment of virtual machines from a deployed environment  
 To avoid computer name conflicts, a best practice is to create stored virtual machines as workgroup machines; that is, as machines that are not automatically joined to the external domain. This section assumes that stored virtual machines are not connected to an external domain.  
  
 To create a stored environment of virtual machines from a deployed environment that does not use network isolation, follow these steps:  
  
1.  Create the initial environment. For more information, see [Creating an SCVMM Environment Using Stored Virtual Machines and Templates](../test/creating-an-scvmm-environment-using-stored-virtual-machines-and-templates.md).  
  
2.  In the **Lab** tab of [!INCLUDE[TCMshort](../test/includes/tcmshort_md.md)], make sure that the environment is running.  
  
3.  Use **Environment Viewer** to connect to the environment.  
  
4.  For each machine in the environment, do the following:  
  
    1.  Connect to the virtual machine and login.  
  
    2.  If the virtual machine is joined to a domain, remove it from the domain and join it to a workgroup.  
  
    3.  Change the computer name.  
  
    4.  Restart the machine when you are prompted to do this.  
  
5.  Exit Environment Viewer and then shut down the environment from the [!INCLUDE[TCMshort](../test/includes/tcmshort_md.md)] **Lab** tab.  
  
6.  Select the environment and then choose **Store in library**. Provide  
  
7.  Restore the virtual machines in the environment to their previous state.  
  
    1.  Restart the environment and then connect to it in Environment Viewer.  
  
    2.  Connect to each machine in the environment and restore its original name. If it is necessary, connect the virtual machine to the domain. Restart the machine.  
  
 When a stored environment of virtual machines is deployed to a host group, it is the user's responsibility to make sure that the identity of all domain-joined computers are unique to the domain. For more information, see the **Creating Deployed Environments That Do Not Use Network Isolation From Stored Virtual Machines** section of [Creating an SCVMM Environment Using Stored Virtual Machines and Templates](../test/creating-an-scvmm-environment-using-stored-virtual-machines-and-templates.md).  
  
## See Also  
 [Using a Lab Environment for Your Application Lifecycle](../test/using-a-lab-environment-for-your-application-lifecycle.md)   
 [Guidance for Creating and Managing SCVMM Environments](../test/guidance-for-creating-and-managing-scvmm-environments.md)   
 [Creating Lab Environments](../test/creating-lab-environments.md)   
 [How to: Store a Virtual Machine or Template](../test/how-to--store-a-virtual-machine-or-template.md)   
 [Creating an SCVMM Environment Using Stored Virtual Machines and Templates](../test/creating-an-scvmm-environment-using-stored-virtual-machines-and-templates.md)   
 [Creating and using a network isolated environment](../test/creating-and-using-a-network-isolated-environment.md)   
 [(superseded) How to: Set the Properties of a Virtual Machine or Template](assetId:///09964b12-0115-4bfd-95aa-3dea22bc5093)   
 [Managing Lab Environments and Virtual Machines](../test/managing-lab-environments-and-virtual-machines.md)