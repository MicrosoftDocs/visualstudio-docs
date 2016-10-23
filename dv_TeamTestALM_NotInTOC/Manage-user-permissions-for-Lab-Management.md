---
title: "Manage user permissions for Lab Management"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 86dab407-1ffe-4ea2-8628-8f8c4a225981
caps.latest.revision: 13
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
# Manage user permissions for Lab Management
You can control the level of access that various members of your team have to Lab Management resources by adding each member to security groups for each team project. By default, Team Foundation creates several groups for each project, and each group has its own set of permissions and rights for that project. If the default groups do not provide the appropriate permissions, you can create custom groups that have a specific combination of permissions. For more information about adding users to the default groups, see [Adding and Removing Users To and From Groups](../Topic/Adding%20and%20Removing%20Users%20To%20and%20From%20Groups.md). For more information about creating custom groups, see [Custom Groups in Team Foundation Server](../Topic/Custom%20Groups.md).  
  
## Default Groups and Permissions  
 When you create a team project collection, Team Foundation automatically creates the following default collection-level groups:  
  
-   Project Collection Administrators  
  
-   Project Collection Valid Users  
  
-   Project Collection Service Accounts  
  
-   Project Collection Build Service Accounts  
  
-   Project Collection Proxy Service Accounts  
  
-   Project Collection Test Service Accounts  
  
 Of these groups, the Project Collection Administrators and the Project Collection Build Service Accounts are given explicit permissions to access or control Lab Management resources. For more information about all the default collection-level groups, see [Default Groups in Team Foundation Server](../Topic/Default%20Groups.md).  
  
 Similarly, when you create a team project, Team Foundation automatically creates the following default project-level groups:  
  
-   Project Administrators  
  
-   Contributors  
  
-   Readers  
  
-   Builders  
  
 Of these groups, the Project Administrators, Contributors, and Readers are given explicit permissions to access or control Lab Management resources. For more information about the permissions for all the default collection-level and project-level groups, see [Permission reference](../Topic/Permission%20reference%20for%20Team%20Foundation%20Server.md).  
  
 The following table lists the specific Lab Management permissions that are assigned to users when you add the user to a default group. For many team projects, assigning users to either the Project Administrators group or the Contributors group is sufficient for the individual people to do their jobs.  
  
|Name of Lab Management permission|Name of the permission at the command line|Users who have this permission can:|Project Collection Administrators|Project Collection Build Service Accounts|Project Administrators|Contributors|Readers|  
|-------------------------------------------------------------------------------------|------------------------------------------------|-----------------------------------------|---------------------------------------|-----------------------------------------------|----------------------------|------------------|-------------|  
|View Lab Resources|Read|View information for the various Lab Management resources, which include collection host groups, project host groups, and environment. To view information about a specific lab resource, you must have the View Lab Resources permission for that resource.|X|X|X|X|X|  
|Import Virtual Machine|Create|Import a virtual machine from a VMM library share. This permission differs from Write because users can create an object in Lab Management but not write anything to the Virtual Machine Manager host group or library share.|X||X|X||  
|Write Environment and Virtual Machines|Write|Users who have this permission for a project host group can create environments. Users who have this permission for a project library share can store environments and templates.|X|X|X|X||  
|Edit Environment and Virtual Machines|Edit|Users who have this permission can edit environments and templates. The permission is checked for the object that is being edited.|X|X|X|X||  
|Start|Start|Start an environment.|X|X|X|X||  
|Stop|Stop|Stop an environment.|X|X|X|X||  
|Pause Environment|Pause|Pause an environment.|X|X|X|X||  
|Manage Snapshots|ManageSnapshots|Users who have this permission can perform all snapshot management tasks for an environment, which include taking a snapshot, reverting to a snapshot, renaming a snapshot, deleting a snapshot, and reading a snapshot.|X|X|X|X||  
|Delete Environment and Virtual Machine|Delete|Delete environments and templates. The permission is checked for the object that is being deleted.|X||X|||  
|Manage Lab Location|ManageLocation|Edit the locations of Lab Management resources, which include collection host groups, collection library shares, project host groups, and project library shares. To change a specific location, you must have the Manage Lab Locations permission for that location. This permission for collection-level locations (collection host groups and collection library shares) also lets you create project-level locations (project host group and project library share).|X||X|||  
|Delete Lab Locations|DeleteLocation|Delete the locations for Lab Management resources, which include collection host groups, collection library shares, project host groups, and project library shares. To delete a location, you must have the Delete Lab Location permission for that location.|X||X|||  
|Manage Child Permissions|ManageChildPermissions|Users who have this permission can change the permissions of all the child Lab Management objects. For example, if a user has Manage Child Permission for a team project host group, the user can change permissions for all the environments under that team project host group.|X||X|||  
|Manage Permissions|ManagePermissions|Modify the permissions for a Lab Management object. This permission is checked for the object whose permissions are being modified.|X|||||  
  
## Custom Groups and Permissions  
 If the permissions granted by the default Team Foundation security groups are too inclusive or exclusive, you can create new security groups that have different combinations of permissions. For example, your team might have some users who function as test leads and other users who function as just testers. The policies in your organization require that only test leads are authorized to create virtual machines and templates. Because adding a tester to the default Contributors group would automatically give the tester permission to create new virtual machines and templates, you might want to create a custom group named "Tester" that has just the permissions indicated in the following table. Similarly, your organization has some users who function as a team project administrator and other users who function as test lab administrators. The policies in your organization require that only team project administrators can manage user permissions. Because adding a lab administrator to the default Project Administrators group would automatically give the test lab administrator the ability to manage permissions, you may want to create a custom group named "Lab Administrators." The following table illustrates the specific permissions that might be given to the "Lab Administrators" group and three other custom groups that differ from the permissions in the default groups. For the steps to create custom groups, see [Custom Groups in Team Foundation Server](../Topic/Custom%20Groups.md).  
  
|Name of Lab Management permission|Custom group: Lab Administrator|Custom group: Test Lead|Custom group: Tester|Custom group: Developer|  
|-------------------------------------------------------------------------------------|-------------------------------------|-----------------------------|--------------------------|-----------------------------|  
|View Lab Resources|X|X|X|X|  
|Create VM Template using VMM Virtual Machines|X|X|||  
|Write Environment and Template|X|X|||  
|Edit Environment and Templates|X|X|X|X|  
|Start Environment|X|X|X|X|  
|Stop Environment|X|X|X|X|  
|Pause Environment|X|X|X|X|  
|Manage Environment Snapshots|X|X|X|X|  
|Delete Environment and Templates|X|X|||  
|Manage Lab Location|X||||  
|Delete Lab Location|X||||  
|Manage Child Permissions|||||  
|Manage Permissions|||||  
  
 After you create the custom group, you must add users to those groups. Use the command line utility **TFSLabConfig** to manage the Lab Management permissions for groups or users. For the syntax and other considerations, see [Configuring Lab Management with TFSLabConfig](assetId:///28da1061-5a31-4e8b-96a7-116dfed55632).  
  
 To view what groups or users have existing permissions on the various Lab Management objects, see the [TFSLabConfig Permissions Command](assetId:///15d32934-2784-42c6-9b08-c505002112e6).  
  
## See Also  
 [Configure Lab Management for SCVMM environments](../dv_TeamTestALM/Configure-Lab-Management-for-SCVMM-environments.md)   
 [Change Existing Lab Management Configurations](../dv_TeamTestALM/Change-Existing-Lab-Management-Configurations.md)