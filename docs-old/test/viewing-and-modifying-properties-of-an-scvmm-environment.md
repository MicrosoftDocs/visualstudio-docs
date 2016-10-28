---
title: "Viewing and Modifying Properties of an SCVMM Environment"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "virtual environments [Lab Management], changing"
  - "virtual environments [Lab Management], viewing"
ms.assetid: cf97245f-1933-486c-b00b-12f7a2f9b33b
caps.latest.revision: 28
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
# Viewing and Modifying Properties of an SCVMM Environment
You can change the properties or the composition of a SCVMM environment. The following examples illustrate the kinds of changes you might make during the lifecycle of an application.  
  
-   Change the name of an environment or its description after you have installed new applications into it.  
  
-   Remove a virtual machine with an outdated OS and add another virtual machine with a new OS to an existing stored environment.  
  
-   Change the environment capabilities in a stored environment so that all active environments created from it will have those capabilities.  
  
    > [!NOTE]
    >  Installing software on a virtual machine by connecting to it does not constitute a change.  
  
 In [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], you can view and change active environments by choosing the **Lab** tab. You can view and change stored environments by choosing the **Library** tab.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
### To view or change the properties of an active SCVMM environment  
  
1.  Open **Microsoft Test Manager** and connect to the team project.  
  
2.  Open **Lab Center**.  
  
3.  Choose the **Lab** tab.  
  
4.  Choose the **Environments** sub-tab.  
  
     A list of environments is displayed.  
  
5.  Choose the environment that you want to view or change.  
  
6.  Choose **Open**, and then follow the steps in the wizard to view or change the properties.  
  
7.  If you have opened the wizard just to view the properties of the SCVMM environment, choose **Cancel** to close the wizard. If you have made changes and want to save the changes, choose **Finish**.  
  
### To view or change the properties of a stored SCVMM environment  
  
1.  Open **Microsoft Test Manager** and connect to the team project.  
  
2.  Open **Lab Center**.  
  
3.  Choose the **Library** tab.  
  
4.  Choose the **Environments** sub-tab.  
  
     A list of environments is displayed.  
  
5.  Choose the environment that you want to view or change.  
  
6.  Choose **Open**, and then follow the steps in the wizard to view or change the properties.  
  
7.  If you have opened the wizard just to view the properties of the SCVMM environment, choose **Cancel** to close the wizard. If you have made changes and want to save the changes, choose **Finish**.  
  
## Properties of SCVMM Environments  
 Each SCVMM environment has its own set of properties. The following properties are present on all SCVMM environments when either **Active** or **Stored**:  
  
-   [Name](#Name)  
  
-   [Description](#Description)  
  
-   [Status](#Status)  
  
-   [Owner](#Owner)  
  
-   [Date created](#Created)  
  
-   [Date modified](#Modified)  
  
-   [Modified by](#By)  
  
-   [Last accessed time](#Accessed)  
  
-   [List of virtual machines or templates](#VMs)  
  
-   [List of snapshots](#Snapshots)  
  
-   [Capabilities](#Capabilities)  
  
-   [Environment tags](#Tags)  
  
-   [ID](#ID)  
  
 **Active** environments also have the following two properties:  
  
-   [Project host group](#Host)  
  
-   [In use](#InUse)  
  
 **Stored** environments also have the following additional property:  
  
-   [Project library share](#Library)  
  
###  <a name="Name"></a> Name  
 This is the name of the environment.  
  
> [!NOTE]
>  Two environments cannot have the same name if they are in the same team project library share or same team project host group.  
  
###  <a name="Description"></a> Description  
 This is a user friendly annotation that describes the environment.  
  
###  <a name="Status"></a> Status  
 This is the current state of the environment. The following table describes the states that are supported by [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)].  
  
|Status|Applies to|Description|  
|------------|----------------|-----------------|  
|Stored|Stored environments only|The environment is stored in the library and is available for use.|  
|Stopped|Active environments only|All virtual machines in the environment are stopped.|  
|Running|Active environments only|All virtual machines in the environment are running.|  
|Paused|Active environments only|All virtual machines in the environment are paused. A paused virtual machine has its CPU execution suspended. The virtual machine is still using memory and disk resources on the physical host.|  
|Mixed|Active and stored environments|Not all virtual machines in the environment are in the same state. Some of them are in Stopped, Paused, or Running states, whereas others might be in some form of Failed states. This might occur if the state of a virtual machine was changed bypassing [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)]. For example, if you restart a virtual machine and you are connected to it, the state of the environment becomes Mixed.|  
|Creating|Active and stored environments|The environment is being created and cannot be used until it is completed. You can cancel creating the environment.|  
|CreateCancelling|Active and stored environments|A Cancel operation was requested while the environment was under creation.|  
|CreateFailed|Active and stored environments|Creation of the environment has failed. You can retry the creation.|  
|Stopping|Active environments only|The environment is stopping.|  
|Starting|Active environments only|The environment is starting.|  
|Pausing|Active environments only|The environment is pausing.|  
|Deleting|Active and stored environments|The environment is being deleted.|  
|Updating|Active and stored environments|Properties of the environment are being updated.|  
|CreatingSnapshot|Active environments only|A snapshot operation was performed on the environment. A new snapshot is being created.|  
|DiscardingSnapshot|Active environments only|A snapshot is being deleted from the environment.|  
|RestoringSnapshot|Active environments only|A restore operation was performed on the environment. The environment is being restored to an earlier snapshot.|  
|UnderMigration|Active and stored environments|All virtual machines in the environment are being migrated from their current host or library server to another location.|  
|Failed|Active and stored environments|All the virtual machines in the environment have entered one of the following failure states: CheckpointActionFailed, Missing, IncompleteVMConfig, HostNotResponding, CustomizationFailed, MigrationFailed, UpdateFailed, or Unsupported.|  
  
###  <a name="Library"></a> Project library share  
 This is the location of a stored environment. The library of each team project may be organized into multiple project library shares. For more information about how to change team project library shares, see [Change the Library Share for Your Team Project Collections](../test/change-the-library-share-for-your-team-project-collections.md).  
  
###  <a name="Host"></a> Project host group  
 This is the location of an active environment. Each team project may be organized into multiple project host groups. For more information about how to change team project host groups, see [Change the Host Groups for Your Team Project Collections](../test/change-the-host-groups-for-your-team-project-collections.md).  
  
###  <a name="InUse"></a> In use  
 This indicates that the environment is being used. When an environment is marked as **In use**, any additional operations on that environment trigger a warning. Use the **In use** marker to negotiate control of shared environments between team members. You can also include a comment when you mark an environment **In use**.  
  
###  <a name="Owner"></a> Owner  
 This is the identity of the person who created the environment. The owner is the only person other than a system administrator who can delete the environment. All the contributors in the team project can access, view, and update the environment.  
  
###  <a name="Created"></a> Date created  
 This is the date and time when the environment was created.  
  
###  <a name="Modified"></a> Date modified  
 This is the date and time when the environment was changed by a user. The user should have changed one or more of the editable properties of the environment  
  
###  <a name="By"></a> Modified by  
 This is the identity of the person who last modified the environment.  
  
###  <a name="Accessed"></a> Last accessed time  
 This is the date and time when the environment was last accessed. An access is any operation on or use of the environment. The time stamp is updated whenever:  
  
-   An environment is edited.  
  
-   Another environment is created from this environment through store or deploy operations.  
  
-   Any of the following operations is performed on the environment: start, stop, pause, save virtual machine, create snapshot, discard snapshot, restore snapshot.  
  
 The following operation does not update the last accessed time:  
  
-   Opening the environment to view, but not change, its properties.  
  
 The last accessed time is useful in managing the proliferation of virtual machines. You can write custom scripts to delete all environments that have not been accessed for a long time.  
  
###  <a name="VMs"></a> List of virtual machines or templates  
 This is the list of virtual machines or templates that the environment is made of. For a stored environment, this list could include both virtual machines and templates. For an active environment, this list could only include virtual machines.  
  
###  <a name="Snapshots"></a> List of snapshots  
 Each snapshot that you take on the environment has a name and description. In addition, the snapshots have a parent-child relationship with each other that indicates the order in which they have been taken. For more information about snapshots and snapshot operations, see [&#91;NIB&#93; How to: Store the State of Your Environment](assetId:///bc4b2074-e915-44a9-8ce1-e4f8e5af5bb7).  
  
###  <a name="Capabilities"></a> Capabilities  
 Each environment can be configured to support three capabilities: network isolation, test integration, and workflow integration. For more information about these capabilities, see the following topics:  
  
-   [Test on a lab environment](../test/test-on-a-lab-environment.md)  
  
-   [Create a build-deploy-test workflow for an SCVMM environment](../test/create-a-build-deploy-test-workflow-for-an-scvmm-environment.md)  
  
-   [Creating and using a network isolated environment](../test/creating-and-using-a-network-isolated-environment.md)  
  
###  <a name="Tags"></a> Environment tags  
 You can associate custom name-value properties with an environment. Two examples of data that you can associate with each environment are as follows:  
  
-   Purpose of the environment.  
  
-   Date when the environment should be deleted.  
  
###  <a name="ID"></a> ID  
 A unique identifier assigned by [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] to track the environment. Use the ID in communications with the system administrator. The ID is also useful if you want to use the programming interface for [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] and build additional features that layer on top of [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)].  
  
## Additional Considerations  
 If you take a snapshot of the environment, make several changes to the environment, and then restore to the original snapshot, the changes are not restored. In other words, if you change the name or custom properties after a snapshot and restore to the original snapshot, the environment still continues to have the changed name. However, the value of memory is restored when you restore the environment.  
  
> [!CAUTION]
>  If you add or remove a virtual machine from an environment, all the prior snapshots of that environment are obsolete and unavailable. You will not be able to restore the environment to any of those snapshots.  
  
 If you change a stored environment, when those changes finish successfully the environment returns to the Stored state. Similarly, an active environment returns to its original state after the changes are complete. If a stored environment was in the CreateFailed state, you must remove the CreateFailed virtual machine before you make any other changes to the environment.  
  
## See Also  
 [Viewing and Modifying Properties of a Virtual Machine or Template in an SCVMM Environment](../test/viewing-and-modifying-properties-of-a-virtual-machine-or-template-in-an-scvmm-environment.md)   
 [Managing Lab Environments and Virtual Machines](../test/managing-lab-environments-and-virtual-machines.md)