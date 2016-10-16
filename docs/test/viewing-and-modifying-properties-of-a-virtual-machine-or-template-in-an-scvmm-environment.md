---
title: "Viewing and Modifying Properties of a Virtual Machine or Template in an SCVMM Environment"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "virtual machine [Lab Management]. view"
  - "virtual machine [Lab Management], change"
ms.assetid: 99e76568-838c-4ecd-811c-068c9105a5b7
caps.latest.revision: 29
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
# Viewing and Modifying Properties of a Virtual Machine or Template in an SCVMM Environment
After you have worked with a virtual machine or template, you might want to update one or more of its properties. For example, if you have added software to the machine or changed some settings, you might want to revise the name or the description of the machine to let other users know about the changes.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
### To view or change the properties of a virtual machine or a template in an environment  
  
1.  Open **Microsoft Test Manager** and connect to the team project.  
  
2.  Open **Lab Center**.  
  
3.  Choose the **Environment** tab.  
  
4.  Choose the environment that the machine or template is in.  
  
5.  Choose **Open**.  
  
6.  To view or change the name or the role, choose **Machines**, and then choose the appropriate edit box.  
  
7.  To view or change the hardware profile, the OS profile, or the machine tags, choose **Machine properties**, and then choose the appropriate tab.  
  
8.  If you have opened the wizard just to view the properties of the virtual machine or the template, close the wizard by choosing **Cancel**. If you have made changes and want to save the changes, choose **Finish**.  
  
### To view or change the properties of a virtual machine or a template stored in the library  
  
1.  Open **Microsoft Test Manager** and connect to the team project.  
  
2.  Open **Lab Center**.  
  
3.  Choose the **Library** tab.  
  
4.  Choose the **Virtual Machines and Templates** sub-tab.  
  
5.  Choose the virtual machine or the template from the list.  
  
6.  Choose **Open**  
  
7.  To view or change the name, the description, or the default role, choose **Name and machine** step, and then choose the appropriate edit box.  
  
8.  To view or change the hardware profile, the OS profile, or the machine tags, click the **Machine properties** step, and then choose the appropriate tab.  
  
9. If you have opened the wizard just to view the properties of the virtual machine or the template, close the wizard by choosing **Cancel**. If you have made changes and want to save the changes, choose **Finish**.  
  
## Properties of Virtual Machines  
 Each virtual machine or template in a SCVMM environment has its own set of properties. If the environment is created from virtual machines or templates in the library, the values for some of these properties are inherited from that source. However, you can overwrite the inherited properties when you create the environment. For example, a virtual machine or a template stored in the library has a default role of Web Server associated with it. When that virtual machine or template is used to create an active environment, the corresponding copy of the virtual machine in the environment is given the role of Web Server. However, you can change the role to Server if you plan to install additional server components in the virtual machine copy. The default role of the original source virtual machine or template in the library remains unchanged.  
  
 The following table summarizes the properties of a virtual machine or a template and when that property is available to be viewed or changed. Not all properties can be edited in all states of the virtual machine or the template.  
  
|Property|Applies to|  
|--------------|----------------|  
|[Computer name](#Computer)|-   Virtual machines in active environments.|  
|[Date created](#Created)|-   Virtual machines and templates stored in the team project library.|  
|[Date modified](#Modified)|-   Virtual machines and templates stored in the team project library.|  
|[Default role](#Role)|-   Virtual machines and templates in stored environments.<br />-   Virtual machines in active environments.|  
|[Description](#Description)|-   Virtual machines and templates stored in the team project library.|  
|[Hardware profile](#Profile)<br /><br /> -   Memory<br />-   CPU<br />-   Total hard disk size|-   Virtual machines and templates in stored environments.<br />-   Virtual machines in active environments.|  
|[ID](#ID)|-   Virtual machines and templates stored in the team project library.|  
|[Internal computer name](#Internal)|-   Virtual machines in active environments.|  
|[Last accessed time](#Last)|-   Virtual machines and templates stored in the team project library.|  
|[Machine tags](#Tags)|-   Virtual machines and templates in stored environments.<br />-   Virtual machines in active environments.|  
|[Modified by](#By)|-   Virtual machines and templates stored in the team project library.|  
|[Name](#Name)|-   Virtual machines and templates in stored environments.<br />-   Virtual machines in active environments.|  
|[OS profile](#OS)<br /><br /> -   Computer name<br />-   Full name<br />-   Organization name<br />-   Administrator password<br />-   Product key<br />-   Time zone<br />-   Operating system<br />-   Domain or workgroup<br />-   One-time commands|-   Templates in stored environments.|  
|[Owner](#Owner)|-   Virtual machines and templates stored in the team project library.|  
|[Path](#Path)|-   Virtual machines and templates stored in the team project library.|  
|[Project library share](#Library)|-   Virtual machines and templates stored in the team project library.|  
|[SCVMM VM name](#SCVMM)|-   Virtual machines and templates in stored environments.<br />-   Virtual machines in active environments.|  
|[Status](#Status)|-   Virtual machines and templates in stored environments.<br />-   Virtual machines in active environments.|  
|[Type](#Type)|-   Virtual machines and templates in stored environments.|  
  
####  <a name="Computer"></a> Computer name  
 This is the name of the computer assigned by the operating system in virtual machine. If the environment is not network isolated, it is made of the name that is returned when you type ‘hostname’ in a command shell inside the virtual machine plus the DNS suffix for the virtual machine. If the environment is network isolated, it is a unique name that is auto-generated by [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] and registered in DNS for the virtual machine.  
  
####  <a name="Created"></a> Date created  
 This is the date and time when the virtual machine or the template was created in the team project library share. In the case when the virtual machine or the template is imported, this is the time when it was imported. In the case when the virtual machine or the template was created from an environment, this is the time when the creation started.  
  
####  <a name="Modified"></a> Date modified  
 This is the date and time when the virtual machine or template was edited by a user. The user changed one or more of the editable properties of the virtual machine or template.  
  
####  <a name="Role"></a> Default role  
 Each virtual machine in an environment has one or more roles associated with it. Roles are used to identify the components of the application that are installed on a virtual machine in an environment. For example, if you are developing a three-tier application, you can associate a role of Web Server with the virtual machine that has the Web-tier in it, a role of Database Server with the virtual machine that has the data-tier in it, and a role of Web Client with the virtual machine that has the browser in it.  
  
 You can assign a default role to a virtual machine or a template; this will be used each time this virtual machine or template is used in an environment. Changing the role of a virtual machine or template changes the icon associated with it. The following roles are available for you to choose from:  
  
-   **Database Server**: Indication that the virtual machine or the template has a database server installed in it.  
  
-   **Web Server**: Indication that the virtual machine or the template has a Web server installed in it.  
  
-   **Server**: Any other generic server, possibly with multiple server-side software components and roles.  
  
-   **Desktop Client**: Indication that the virtual machine or the template has a client operating system installed on it and may be used as the client machine in a multi-machine environment.  
  
-   **Web Client**: Indication that the virtual machine or the template has a client operating system along with a browser installed on it, and may be used as a Web client in a multi-machine environment.  
  
-   **Domain Controller**: Indication that the virtual machine or template has a domain controller installed on it.  
  
-   *Your own role*: If the previous roles do not suit your need, you can define your own roles for virtual machines or templates. To do this, open the virtual machine or template, and type the custom role string in **Default role** text box.  
  
    > [!NOTE]
    >  These roles are just indications of what is installed in a virtual machine or in a template, or indications of the intended use when the environments were created. [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] does not automatically verify that the virtual machines or the templates have the necessary software, nor install the software automatically to fulfill these roles.  
  
####  <a name="Description"></a> Description  
 This is a user-friendly annotation that describes the virtual machine or the template. You might include information such as the operating system, the software that has been installed, intended purpose, and information that you must have in order to connect to the virtual machine.  
  
####  <a name="Profile"></a> Hardware profile  
 These are the hardware properties of the virtual machine or the template. Three properties are currently available:  
  
-   **Memory**: This is the amount of physical memory that should be reserved for the virtual machine when it is deployed on a Hyper-V host.  
  
-   **CPU**: This is the type of CPU being emulated in the virtual machine.  
  
-   **Total hard disk size**: This is total size taken by all the disks of the virtual machine or template. If the virtual machine consists of snapshots, the space that is required for storing the snapshots is considered also.  
  
 Choose a value for memory that meets the requirements of the applications that are installed on your virtual machines. Choosing a very low value causes the virtual machines to take a very long time to start or to do testing. It is recommended that you allocate at least 512 MB of memory for virtual machines and templates that run the [!INCLUDE[winxpsvr](../debugger/includes/winxpsvr_md.md)] or [!INCLUDE[winxp](../codequality/includes/winxp_md.md)] operating systems. Similarly, we recommend that you allocate at least 1024 MB of memory for virtual machines and templates that run [!INCLUDE[firstref_longhorn](../test/includes/firstref_longhorn_md.md)], Vista, or newer operating systems. If you have several roles or applications installed in the virtual machines, increase this memory accordingly.  
  
####  <a name="ID"></a> ID  
 A unique identifier assigned by [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] to track the virtual machine or the template. Use the ID in communications with the system administrator. The ID is also useful if you want to use the programming interface for [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] and build additional features that layer on top of [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)].  
  
####  <a name="Internal"></a> Internal computer name  
 This is applicable only for network isolated environments. It represents the computer name that is returned by the **hostname** command in the virtual machine.  
  
####  <a name="Last"></a> Last accessed time  
 This is the date and time when the virtual machine or the template was last accessed. An access is any operation on or use of the virtual machine or template. In particular, this time stamp is updated whenever:  
  
-   A virtual machine or template is edited.  
  
-   An environment is created that uses the virtual machine or template.  
  
 The following operation does not update the last accessed time:  
  
-   Opening the virtual machine or template to view (but not change) its properties.  
  
 The last accessed time is useful in managing the proliferation of virtual machines. You can write custom scripts to delete all virtual machines and templates that have not been accessed for a long time.  
  
####  <a name="Tags"></a> Machine tags  
 You can associate custom name-value properties for a virtual machine or a template. For example, you can use machine tags to associate each virtual machine or template with the following:  
  
-   Patches and applications installed in the virtual machine.  
  
-   Language or locale of the operating system.  
  
-   Any additional information that is present in SCVMM but not exposed through [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)], for example, information about network cards on the virtual machine or the number of disks.  
  
####  <a name="By"></a> Modified by  
 This is the identity of the last person who edited the virtual machine or the template.  
  
####  <a name="Name"></a> Name  
 This is the name of the virtual machine or the template in the environment. Two virtual machines or templates cannot have the same name in a given environment. This name could be different from the name of the source virtual machine or template that was used to compose the environment.  
  
####  <a name="OS"></a> OS profile  
 This applies only to templates and captures how a template has to be customized when an environment is created from it. The process of customization is specific to the operating system that is located in the virtual machine. Consequently, not all properties described in the following list apply to all operating systems.  
  
-   **Computer name** is the name to be assigned to each instance of a virtual machine created from the template. You may specify an asterisk (*) to indicate that the computer name has to be auto-generated. Therefore, if you use this template to create multiple environments, each instance of the virtual machine will get a unique name.  
  
    > [!NOTE]
    >  The maximum length of a computer name is 15 characters. Most of the special characters are not allowed as part of a computer name.  
  
-   **Full name** is used to customize each virtual machine with the name of the owner for that machine.  
  
    > [!NOTE]
    >  Full name is a valid OS profile property only for [!INCLUDE[winxpsvr](../debugger/includes/winxpsvr_md.md)] and XP operating systems.  
  
-   **Organization name** is the name of your organization or department.  
  
    > [!NOTE]
    >  Organization name is a valid OS profile property only for [!INCLUDE[winxpsvr](../debugger/includes/winxpsvr_md.md)] and XP operating systems.  
  
-   **Administrator password** is the password of the local administrator account on the virtual machine.  
  
    > [!NOTE]
    >  The Administrator account is disabled on [!INCLUDE[TLA#tla_winvista](../test/includes/tlasharptla_winvista_md.md)] and [!INCLUDE[win7](../codequality/includes/win7_md.md)] operating systems. If your virtual machine or template has one of these operating systems, you must also specify the username that has to be added as an administrator.  
  
     For [!INCLUDE[winxpsvr](../debugger/includes/winxpsvr_md.md)] and [!INCLUDE[winxp](../codequality/includes/winxp_md.md)] operating systems, you can specify the administrator password to be blank. To do this, type an asterisk (*) in the administrator password. For newer operating systems, leaving the Administrator password empty is an indication that the password should be blank.  
  
-   **Product key** is a license key that is valid for the version of the operating system that is installed in the virtual machine or the template. If you intend to create multiple environments using this template, the product key you enter must let you do this. For example, use a [!INCLUDE[TLA#tla_mswin](../codequality/includes/tlasharptla_mswin_md.md)] volume license key. Alternatively, you can have an empty value for the product key and customize it during environment creation.  
  
    > [!IMPORTANT]
    >  If the product key does not match the version of the operating system installed in the virtual machine template, you will not be able to successfully customize the virtual machine.  
  
-   **Time zone** is used to customize the virtual machine with the selected information.  
  
-   **Operating system** must match what is installed on the template. This information is used to identify how the customization must occur because the process varies depending on the version and flavor of the operating system.  
  
    > [!NOTE]
    >  Make sure that the operating system is correct whenever you create or import a virtual machine template. Otherwise, the customization might fail.  
  
-   **Domain or workgroup** specifies whether a virtual machine created from this template must be joined to a Workgroup or to an Active Directory domain. If using the workgroup option, you have to specify the name of the workgroup. Similarly, if using the domain option, you have to specify the name of an Active Directory domain and the credentials of a user who has the authority to create new machines in the domain.  
  
     You must enter the user name as either \<domain>\\<username\> (the down-level domain user name format) or the \<username>@\<company>.com (the user principals name format).  
  
-   **One-time commands** are scripts that are executed on a virtual machine the first time a user logs into that virtual machine.  
  
 The following additional constraints apply when a stored environment with templates is being deployed to create an active environment.  
  
-   **Full name** and **Organization name** cannot be empty for the following operating systems: [!INCLUDE[winxpsvr](../debugger/includes/winxpsvr_md.md)] and [!INCLUDE[winxp](../codequality/includes/winxp_md.md)]. For other operating systems, Full name and Organization name should not be specified.  
  
-   Product key cannot be empty.  
  
####  <a name="Owner"></a> Owner  
 This is the identity of the person who imported or created the virtual machine or the template. The owner is the only person who can eventually delete the virtual machine or the template from team project library share. All the contributors in the team project can use, view, and update the virtual machine or the template.  
  
####  <a name="Path"></a> Path  
 This is the location of virtual machine or the template in SCVMM. The path contains the name of the SCVMM library share and the name of the virtual machine or the template in SCVMM.  
  
####  <a name="Library"></a> Project library share  
 This is the location of the virtual machine or template. The library of each team project may be organized into multiple project library shares. For more information about how to create team project library shares, see [Change the Library Share for Your Team Project Collections](../test/change-the-library-share-for-your-team-project-collections.md).  
  
####  <a name="SCVMM"></a> SCVMM VM name  
 Each virtual machine created and managed by [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] as part of an environment is referred through a unique name in Virtual Machine Manager. This name is auto-generated by [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] and has the form Lab_\<GUID>, where GUID is a globally unique identifier. The virtual machine name is useful in relating a virtual machine that is part of an environment to its realization in Virtual Machine Manager. Use the virtual machine name in communications with the system administrator.  
  
####  <a name="Status"></a> Status  
 This is the current state of the virtual machine or template. The following table describes the states supported by [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)].  
  
|Status|Applies to|Description|  
|------------|----------------|-----------------|  
|Stored|Virtual machines or templates in stored environments.|The virtual machine or template is stored in the library and is part of a stored environment.|  
|Stopped|Virtual machines in active environments only.|The virtual machine has been powered off. It is not using CPU or memory resources on the hypervisor.|  
|Running|Virtual machines in active environments only.|The virtual machine has been started.|  
|Paused|Virtual machines in active environments only.|The virtual machine has been suspended. Its CPU execution has been frozen.|  
|Saved|Virtual machines in active environments only.|The virtual machine has been saved through Virtual Machine Manager. Or, the virtual machine could not be started after it was restored to the snapshot.|  
|Creating|Virtual machines or templates in stored environments, Virtual machines in active environments.|The virtual machine or template is being created and cannot be used until the creation is completed.|  
|Starting|Virtual machines in active environments only.|The virtual machine is being started.|  
|Stopping|Virtual machines in active environments only.|The virtual machine is being powered off or being shut down.|  
|Pausing|Virtual machines in active environments only.|The virtual machine is being paused.|  
|Saving|Virtual machines in active environments only.|The virtual machine is being saved. Saving stores the memory and CPU contents of the virtual machine to persistent storage on the host.|  
|Deleting|Virtual machines or templates in stored environments, Virtual machines in active environments.|The virtual machine or template is being deleted.|  
|Updating|Virtual machines or templates in stored environments, Virtual machines in active environments.|Properties of the virtual machine or template are being updated.|  
|UpdateFailed|Virtual machines or templates in stored environments, Virtual machines in active environments.|Properties of the virtual machine or the template could not be updated.|  
|CreatingSnapshot|Virtual machines in active environments only.|A new snapshot is being created on the virtual machine.|  
|DiscardingSnapshot|Virtual machines in active environments only.|A snapshot is being deleted from the virtual machine.|  
|RestoringSnapshot|Virtual machines in active environments only.|The virtual machine is being restored to an earlier snapshot.|  
|UnderMigration|Virtual machines or templates in stored environments, Virtual machines in active environments|The system administrator is migrating the virtual machine or the template from its current location to another library server or to a host group by using Virtual Machine Manager.|  
|CreateFailed|Virtual machines or templates in stored environments, Virtual machines in active environments.|Creation of the virtual machine or the template has failed. The only action available is to delete the virtual machine or the template and try to create it again.|  
|CheckpointActionFailed|Virtual machines in active environments only.|A snapshot operation performed on the virtual machine failed.|  
|Missing|Virtual machines or templates in stored environments, Virtual machines in active environments.|The virtual machine or the template has been deleted by the system administrator who is using Virtual Machine Manager or another tool. Alternatively, the system administrator has used Virtual Machine Manager to deploy the virtual machine or the template from its current location to a host group, possibly for patching.|  
|HostNotResponding|Virtual machines in active environments.|The host on which the virtual machine is deployed is not reachable. Or the Virtual Machine Manager agent running on the host is unavailable.|  
|MigrationFailed|Virtual machines or templates in stored environments, Virtual machines in active environments.|An attempt to migrate the virtual machine or the template by the system administrator has failed. The virtual machine or the template has been left in an unusable state. Only the system administrator can fix this.|  
|CustomizationFailed|Virtual machines in active environments.|The customization of the virtual machine failed during creation. This can occur when one of the customization parameters specified through OS profile is incorrect.|  
|IncompleteVMConfig|Virtual machines or templates in stored environments, Virtual machines in active environments.|One or more files that are required by the virtual machine or template are missing or deleted.|  
|Unsupported|Virtual machines in active environments.|The virtual machine is in a state that is unrecognized by [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)].|  
  
####  <a name="Type"></a> Type  
 Type indicates whether this is a virtual machine or a virtual machine template.  
  
## See Also  
 [Creating Lab Environments](../test/creating-lab-environments.md)