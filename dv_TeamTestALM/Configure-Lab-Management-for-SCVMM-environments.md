---
title: "Configure Lab Management for SCVMM environments"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0e6f56ff-beb0-4d2c-a8c1-5270b1744ff7
caps.latest.revision: 126
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
# Configure Lab Management for SCVMM environments
To create and manage System Center Virtual Machine Manager (SCVMM) environments, you must first configure the required components for Lab Management. These components are:  
  
-   Hyper-V hosts  
  
-   SCVMM  
  
-   Team Foundation Server  
  
-   A test controller  
  
 For more information about Lab Management, see [Using a Lab Environment for Your Application Lifecycle](../dv_TeamTestALM/Using-a-Lab-Environment-for-Your-Application-Lifecycle.md).  
  
 If you are upgrading from earlier versions of Lab Management or SCVMM, see [Upgrading Lab Management Components from Visual Studio 2010](assetId:///41cc4ddb-a118-4176-ada9-ee713e5596a2).  
  
> [!NOTE]
>  Any computers that you use as Library Servers (including the SCVMM machine that has a default library server) and as Hyper-V hosts should be on a gigabit network that is connected to a common network switch. The faster network speed will help improve performance when you deploy virtual machines to hosts and when you save virtual machines to the library from your host.  
  
## Prerequisites  
 The Team Foundation Server administrator must set up and configure Team Foundation Server before configuring Lab Management. For more information about how to set up and configure Team Foundation Server, see the Team Foundation Server Installation Guide. After the administrator has configured Team Foundation Server and created a default team project collection, make sure that you have the following information:  
  
-   *TfsMachine*: The name of the machine that is running Team Foundation Server.  
  
-   *domain*: The Active Directory domain that is used by all machines.  
  
-   *tfssvc*: The account under which Team Foundation Server is running.  
  
    > [!NOTE]
    >  You must use a domain user account and password for the TFSservice account to set up an SCVMM environment for lab management.  
  
-   *domain*\\*tfsadmin*: The account for the Team Foundation Server administrator.  
  
## System requirements  
 The following table summarizes the minimum and recommended hardware and software requirements for the machines used with Lab Management. To make the requirements easier to understand, each role is broken out as if it were installed on a separate machine. For a simpler setup, you can run the *HyperVHost* machine, the *VmmMachine* and the *LibraryMachine* all on the same computer.  
  
|**Role/System**|**Processor**|**Supported operating system**|**RAM**<br /><br /> **(min/**<br /><br /> **recommended)**|**Hard disk (min/ recommended)**|  
|----------------------|-------------------|------------------------------------|---------------------------------------------------|-----------------------------------------|  
|*HyperVHost*|64-bit with hardware virtualization enabled|Windows Server 2012 R2 operating system with Hyper-V 64-bit, Standard, Enterprise and Datacenter Editions<br /><br /> VMM Server 2012 R2 operating system with Hyper-V 64-bit, Standard, Enterprise and Datacenter Editions<br /><br /> Hyper-V Host and Library Server 2012 R2. The Hyper-V Host and Library servers can be running on Windows Server 2012 with VMM server running on 2012 R2.<br /><br /> Windows Server 2008 R2 operating system with Hyper-V 64-bit, Standard, Enterprise, and Datacenter Editions<br /><br /> Windows Server 2008 R2—Server Core installation, Standard, Enterprise, and Datacenter Editions<br /><br /> Windows Server 2008 operating system with Hyper-V 64-bit, Standard, Enterprise, and Datacenter Editions with Service Pack 2<br /><br /> Hyper-V Server 2008 R2 operating system|4GB / 8GB|100 GB/ 200GB|  
|*VmmMachine*|64-bit|Windows Server 2012 R2 operating system with Hyper-V 64-bit, Standard, Enterprise and Datacenter Editions<br /><br /> VMM Server 2012 R2 operating system with Hyper-V 64-bit, Standard, Enterprise and Datacenter Editions<br /><br /> Hyper-V Host and Library Server 2012 R2. The Hyper-V Host and Library servers can be running on Windows Server 2012 with VMM server running on 2012 R2.<br /><br /> Windows Server 2008 R2 operating system 64-bit Standard, Enterprise, and Datacenter Editions<br /><br /> Windows Server 2008 operating system Standard, Enterprise, and Datacenter Editions with Service Pack 2|2GB / 4GB|200GB|  
|*LibraryMachine*|64-bit|Windows Server 2012 R2 operating system with Hyper-V 64-bit, Standard, Enterprise and Datacenter Editions<br /><br /> VMM Server 2012 R2 operating system with Hyper-V 64-bit, Standard, Enterprise and Datacenter Editions<br /><br /> Hyper-V Host and Library Server 2012 R2. The Hyper-V Host and Library servers can be running on Windows Server 2012 with VMM server running on 2012 R2.<br /><br /> Windows Server 2008 R2 operating system 64-bit Standard, Enterprise, and Datacenter Editions|2GB / 4GB|200GB / 500GB|  
|*TfsMachine*|32-bit x86<br /><br /> 64-bit x64|All operating systems that are supported by Team Foundation Server are supported by Visual Studio Lab Management, except Windows 8 clients and servers.|2 GB / 4GB|120GB / 230GB|  
|*ControllerMachine*|32-bit x86<br /><br /> 64-bit x64|All operating systems that are supported by Team Foundation Server are supported by Visual Studio Lab Management, except any operating systems that are not joined to a domain.|2GB / 4GB|120GB / 230GB|  
  
## Configuration procedures  
 The following table details the procedures that you must follow to complete the configuration for Hyper-V, SCVMM, and Lab Management, and the permissions that are required. For a simple setup, the *HyperVHost* machine, the *VmmMachine* and the *LibraryMachine* can be the same machine.  
  
> [!NOTE]
>  All the machines that are used for Lab Management must be joined either to the same domain or domains that have two-way trust between them.  
  
|Step Number|Procedure|Details|Machine Name In Procedure|Permissions Required|Step Completed|  
|-----------------|---------------|-------------|-------------------------------|--------------------------|--------------------|  
|**1**|[Set Up And Configure Hyper-V Hosts](#HyperV)|Hyper-V lets you manage virtual machines and their resources.|*HyperVHost*|Administrator for the *HyperVHost*||  
|**2**|[Install and configure SCVMM](#SCVMM)|SCVMM helps you manage your virtual machines and templates, and where and how you store them.|*VmmMachine* **Note:**  You can use a separate machine as the *LibraryMachine* to use for the library share to store the virtual machines.|Administrator for *VmmMachine*||  
|**3**|[Configure Team Foundation Server to enable Lab Management](#ConfigureTFS)|You configure TFS to give you access to the virtual machines and templates that you have created.|*TfsMachine*|Team Foundation Server Administrator||  
|**4**|[Verify the configuration using Microsoft Test Manager](../dv_TeamTestALM/Connect-Microsoft-Test-Manager-to-your-team-project-and-test-plan.md)|Verify that you can connect to a team project and access the **Lab Center** by using Microsoft Test Manager.|*DesktopClient*|Any user account that has been added to the computer||  
|**5**|[Install test controller](#BuildTestControllers)|If you want to build and deploy your application by using Team Foundation Build and run tests, you will need build controllers and test controllers.|*TfsMachine* **Note:**  It is recommended that you use a separate machine as the *ControllerMachine* to install the test controller.|Team Project Collection Administrator||  
  
##  <a name="HyperV"></a> Set up and configure Hyper-V hosts  
 To set up Hyper-V, you can do one of the following:  
  
-   Enable the Hyper-V role on your computer that has Windows Server 2008 R2 or Windows Server 2012 installed. If you do not have the Hyper-V role enabled on the *HyperVHost* computer, you must first enable this by using Server Manager on each of the Hyper-V hosts so that you can create and manage virtual machines using the steps in the following procedure. For more information about Hyper V, see the following [Microsoft Web site](http://go.microsoft.com/fwlink/?LinkId=179531).  
  
-   Install Hyper-V Server 2008 R2 on your *HyperVHost*. For information about Hyper-V server and how to install it, see the following [Microsoft Web site](http://go.microsoft.com/fwlink/?LinkId=181875).  
  
#### To enable the Hyper-V role on each Hyper-V host with Windows Server  
  
1.  On the Hyper-V host, log on as an administrator.  
  
2.  Choose **Start**, point to **Administrative Tools**, and then choose **Server Manager**.  
  
3.  In the left pane of **Server Manager,** right-choose **Roles** and point to **Add Roles**.  
  
4.  Follow the **Add Roles Wizard**. You can just choose **Next** in all except the following pages of the wizard:  
  
    1.  On the **Select Server Roles** page, select **Hyper-V** and then choose **Next**.  
  
    2.  On the **Create Virtual Networks** page, you must select an active network adapter and then choose **Next**.  
  
        > [!NOTE]
        >  To find which network adapters are active, use the **ipconfig** command to view which network adapters have IP addresses. In the wizard, select the network adapter that should be used for creating a virtual network. You must select an adapter that is connected to the same network as the other machines in the lab. If there are several adapters, select the adapter to which the virtual machines that were created by Lab Management should be connected.  
  
    3.  On the **Confirm Installation Selections** page, choose **Install**.  
  
    4.  On the **Installation Results** page, choose **Close**.  
  
    5.  On the **Do you want to restart now** dialog box, choose **Yes**.  
  
         The machine will restart and continue with **Resume Configuration Wizard**.  
  
    6.  On the **Installation Results** page, you will see a message that states **Installation succeeded**. Choose **Close**.  
  
5.  Install the update described on this [Microsoft Web site](http://go.microsoft.com/fwlink/?LinkId=186068). This update supports the network isolation capability of SCVMM environments.  
  
### Improve the reliability of WinRM  
 Windows Remote Management (WinRM) is used by SCVMM to communicate with Hyper-V hosts. You must make the following changes to the default configuration settings for WinRM. The changes to these settings help improve the reliability of WinRM because Lab Management performs a larger number of operations on Hyper-V hosts than are performed in a typical production scenario for Hyper-V. These changes to the WinRM settings must also be performed on any computer that is used for a library share.  
  
##### To change Windows Remote Management configuration settings  
  
1.  Choose **Start**, open the shortcut menu for the **Command Prompt**, and then choose **Run as administrator**.  
  
    > [!NOTE]
    >  You must be a domain user who has been added to the administrators group for this machine.  
  
2.  At the command prompt, run the following command:  
  
     **winrm set winrm/config @{MaxTimeoutms = "1800000"}**  
  
3.  Restart the winrm service and the SCVMM agent on the host using the following commands:  
  
     **net stop winrm**  
  
     **net start winrm**  
  
     **net start scvmmagent**  
  
4.  If the host OS is Windows Server 2008:  
  
    1.  Run the following command:  
  
         **winrm set winrm/config/Service @{MaxConcurrentOperations="200"}**  
  
    2.  Restart winrm and the SCVMM agent on the host using the following commands:  
  
         **net stop winrm**  
  
         **net start winrm**  
  
         **net start scvmmagent**  
  
### Verify the Hyper-V setup  
  
##### To verify that Hyper-V is installed correctly and is working  
  
1.  Create a virtual machine using Hyper-V and check that you can start the virtual machine.  
  
     If you have enabled the Hyper-V role for your *HyperVHost*, create a virtual machine using the information from the following [Microsoft](http://go.microsoft.com/fwlink/?LinkID=179170).  
  
    > [!NOTE]
    >  You can change the settings for the virtual machine based on your needs. You can update the hard disk size and the memory. For more information about these settings, see the following [Microsoft Web site](http://go.microsoft.com/fwlink/?LinkId=179170).  
  
     If you are using Hyper-V Server, create a virtual machine using the information in the Hyper-V Server Getting Started Guide from the following [Microsoft](http://go.microsoft.com/fwlink/?LinkId=181894).  
  
    > [!NOTE]
    >  If you have multiple hard disk drives on your Hyper-V machine, you must configure the paths for the virtual machines to be the larger disk, or you may not have sufficient disk space to create your virtual machines.  
  
 For more information about Hyper-V, see [this overview of Hyper-V](http://go.microsoft.com/fwlink/?linkid=164925).  
  
> [!NOTE]
>  When you create or start a virtual machine, issues may occur due to antivirus software. For more information, see the following [Microsoft Web site](http://go.microsoft.com/fwlink/?LinkId=180418).  
  
##  <a name="SCVMM"></a> Install and configure SCVMM  
 To access the virtual machines that you create with Hyper-V from Lab Management, you must install and configure SCVMM. SCVMM is a tool for managing your Hyper-V host machines from a central console. Lab Management communicates with SCVMM to be able to use the virtual machines and templates to create environments. Two versions of System Center Virtual Machine Manager are supported for Lab Management: SCVMM 2012 or SCVMM 2008 R2.  
  
> [!NOTE]
>  If you are using the stand-alone Hyper-V Server 2008 R2 operating system, you must install SCVMM on a separate *VmmMachine*. You cannot use the *HyperVHost* computer. For more information about the unique characteristics of Hyper-V Server 2008 R2, see the following [Microsoft Web site](http://go.microsoft.com/fwlink/?LinkID=181875)  
  
### Install and configure SCVMM 2012  
 For information about prerequisites, see: [System Requirements: VMM Management Server](http://go.microsoft.com/fwlink/?LinkId=238153)  
  
##### Install SCVMM server and its administrator console on the VMMMachine  
  
1.  On *VmmMachine*, log on as a domain user who is also a local administrator on the machine.  
  
2.  Run setup.exe.  
  
3.  In System Center 2012 setup, choose **Install**.  
  
    > [!TIP]
    >  If you do not have Microsoft .NET Framework 3.5 SP1 installed, VMM Setup prompts you to install it. Choose **OK**.  
  
4.  In Select features to add, choose **VMM management server** and then choose **Next**. **VMM Console** is automatically installed with the server.  
  
5.  Type your name, organization and product key and choose **Next**.  
  
6.  Choose **I have read, understood, and agreed with the terms of the license agreement** and choose **Next**.  
  
7.  Choose whether to participate in the customer experience improvement program and choose **Next**.  
  
8.  To accept the recommended installation location, choose **Next**.  
  
9. Specify the SQL Server instance to use, as well as any particulars about it, and choose **Next**.  
  
10. Specify the local system account or a domain account as the identity the VMM service will use and choose **Next**.  
  
11. Choose **Next** to accept the default port assignments or to enter different values.  
  
12. Choose **Create a new library share** and choose **Next**.  
  
13. On the Installation summary screen, choose **Install**, and then choose **Close** after the wizard finishes.  
  
 After you install VMM manager, you must add your Hyper-V host machines to a host group, and optionally add more library shares.  
  
##### To configure SCVMM  
  
1.  Open Virtual Machine Manager Console.  
  
    1.  Choose **Start**, **All programs**, **Microsoft System Center 2012**, **Virtual Machine Manager**, and then **Virtual Machine Manager Console**.  
  
    2.  On the **Connect to Server** dialog box, type **localhost:<port number\>**or **<the name of the SCVMM Server\>:<port number\>**, and then choose **Connect**.  
  
2.  To add the *HyperVHost* machines to a host group in SCVMM, choose **Fabric**, and then choose **Add resources**, and then choose **Hyper-V Hosts and Clusters**. Choose **Next** in all except the following pages of the wizard:  
  
    1.  On **Specify the credentials to use for discovery**, choose **Manually enter the credentials**, type the credentials of an administrator for the Hyper-V host, and choose **Next**.  
  
    2.  On the **Specify the search scope for virtual machine host candidates** wizard page, choose **Specify Windows Server computers by names**, in the **Computer names** box, type the computer name of the host that you are adding to SCVMM (for example, *HyperVHost*), and then choose **Next**.  
  
    3.  On the **Select the computer that you want to add as hosts** page, select the Hyper-V host computers and choose **Next**.  
  
    4.  On the **Summary** wizard page, choose **Finish**.  
  
        > [!NOTE]
        >  It is recommended that you configure a separate host group for each team project collection. For example, if you plan to configure Lab Management in two project collections in Team Foundation Server, you can create two host groups in System Center Virtual Machine Manager.  
  
3.  (Optional) By default, SCVMM configures the machine on which it is installed to act as a library server. It also sets up a default library share on the machine. You can add more library servers or shares to improve the performance.  
  
    1.  To add a new library server to SCVMM, choose **Library**, and then choose the **Add library server** button from the ribbon and follow the instructions in the wizard.  
  
    2.  To add a new library share to SCVMM, first create a Windows file share on a library server. Then choose **Library**, in the navigation pane, select the library server where you created the Windows file share, and choose **Library Server** from the menu. In the ribbon, choose **Add library shares** and follow the instruction in the wizard.  
  
        > [!NOTE]
        >  We recommend that you configure a separate library share for each team project collection.  
  
4.  To ensure that virtual machines start quickly and that the host service and any network agents do not timeout, set the minimum amount of memory that the *HyperVHost* machine will always have in reserve. The default memory reserves on the host machine are often too low to accommodate the longer startup time required for virtual machines.  
  
    1.  In the SCVMM Administrator Console, choose **Fabric**.  
  
    2.  In the navigation pane, expand **Servers**, **All Hosts**, choose the Hyper-V host machine, and then choose the **Properties** button from the ribbon.  
  
    3.  In the properties dialog box, choose **Reserves** and then select the **Override host reserves settings from the parent host group** check box.  
  
    4.  In the **Memory (MB)** edit box, type or select `1024`, and then choose **OK**.  
  
    5.  Repeat steps b. through d. for each host.  
  
### Install and configure SCVMM 2008 R2  
  
##### To install SCVMM server and SCVMM Administrator Console on the VmmMachine  
  
1.  On *VmmMachine*, log on as a domain user who is also an administrator on the machine.  
  
2.  To install **System CenterVirtual Machine Manager**, run setup.exe.  
  
3.  To install the SCVMM Server, under **Setup** choose **VMM Server**. Choose **I accept the terms of this agreement**. Then choose **Next** in all except the following pages of the wizard:  
  
    1.  On the **SQL Server Settings** wizard page, choose **Install SQL Server 2005 Express Edition SP3**, and then choose **Next**.  
  
        > [!NOTE]
        >  If you do have an existing instance of SQL that you want to use, then select **Use a supported version of SQL Server**.  
  
    2.  On the **Library Share Settings** wizard page, select **Create a new library share**.  
  
        > [!NOTE]
        >  You can accept the default names and locations for the library share or enter different values.  
  
    3.  On the **Installation Settings** wizard page, you can either accept the default port numbers and VMM service account or enter different values.  
  
    4.  On the **Summary of Settings** wizard page, choose **Install**.  
  
    5.  On the **Installation** wizard page, choose **Close**.  
  
4.  To install the Virtual Machine Manager Administrator Console, under **Setup** choose **VMM Administrator Console**. Choose **I accept the terms of this agreement**. Then choose **Next** in all except the following pages of the wizard:  
  
    1.  On the **Summary of Settings** wizard page, choose **Install**.  
  
    2.  On the **Installation** wizard page, choose **Close**.  
  
5.  On the **System Center Virtual Machine Manager 2008** startup page, choose **Exit**.  
  
 After you install VMM manager, you must add your Hyper-V host machine to a host group, and optionally add more library shares.  
  
> [!NOTE]
>  A host group lets you group the Hyper-V host machines together in a meaningful way based on the purpose of the host machine. For example, a set of host machines might belong to a particular department in your company.  
  
##### To configure SCVMM  
  
1.  Open Virtual Machine Manager Administrator Console.  
  
    1.  Choose **Start**, **All programs**, **Microsoft System Center**, **Virtual Machine Manager 2008 R2**, and then **Virtual Machine Manager Administrator Console**.  
  
    2.  On the **Connect to Server** dialog box, enter **localhost:<port number\>**or **<the name of the SCVMM Server\>:<port number\>**, and then choose **Connect**.  
  
        > [!NOTE]
        >  If you receive an error message that states that you cannot connect because the service is not running, run services.msc and verify that Virtual Machine Manager Service is running.  
  
2.  To add the *HyperVHost* machines to a host group in SCVMM, in the **Actions** pane choose **Add host**. Choose **Next** in all except the following pages of the wizard:  
  
    1.  On **Select Host Location** wizard page of the **Add Hosts** wizard, enter the credentials of an administrator for the Hyper-V host.  
  
    2.  On the **Select Host Servers** wizard page, enter the computer name of the host that you are adding to SCVMM—for example, *HyperVHost*—and then choose **Add**.  
  
    3.  On the **Summary** wizard page, choose **Add Hosts**.  
  
        > [!NOTE]
        >  We recommend that you configure a separate host group for each team project collection. For example, if you plan to configure Lab Management in two project collections in Team Foundation Server, you can create two host groups in System Center Virtual Machine Manager.  
  
3.  (Optional) By default, SCVMM configures the machine on which it is installed to act as a library server. It also sets up a default library share on the machine. You can add more library servers or shares to improve the performance.  
  
    1.  To add a new library server to SCVMM, choose **Add library server** in the **Actions** pane on the right side and follow the instructions in the wizard.  
  
    2.  To add a new library share to SCVMM, first create a Windows file share on a library server. Then select the library server on the **Library** tab of SCVMM Administrator Console and choose **Add library shares** under the **Actions** pane on the right side.  
  
        > [!NOTE]
        >  We recommend that you configure a separate library share for each team project collection.  
  
    3.  On each SCVMM library server, install the update described on this [Microsoft website](http://go.microsoft.com/fwlink/?LinkId=186068). This update supports the network isolation capability of SCVMM environments.  
  
4.  To ensure that virtual machines start quickly and that the host service and any network agents do not timeout, set the minimum amount of memory that the *HyperVHost* machine will always have in reserve. The default memory reserves on the host machine are often too low to accommodate the longer startup time required for virtual machines.  
  
    1.  In the SCVMM Administrator Console, choose **Go**, **Hosts**.  
  
    2.  In the center **All Hosts** pane, open the shortcut menu for the name of the host machine, and then choose **Properties**.  
  
    3.  In the **Host Group Properties for** *host machine* dialog, choose the  **Reserves** tab.  
  
    4.  In the **Memory** edit box, enter or select `1024`, and then choose **OK**. For more information about the minimum required memory for Hyper-V hosts, see this [Microsoft website](http://go.microsoft.com/fwlink/?LinkID=181896).  
  
    5.  Repeat steps b through d for each host.  
  
> [!IMPORTANT]
>  If you have two SCVMM servers that are both configured to be used by Lab Management with a specific Team Foundation Server, then each SCVMM server must be configured to use a unique MAC range. To configure the MAC range, from the Virtual Machine Manager Administration Console, in the lower-left navigation window choose **Administration**, choose **Networking** and then open **Global Static MAC Address Range**. For more information about how to configure the MAC range, see the following [Microsoft Web site](http://go.microsoft.com/fwlink/?LinkId=182078).  
  
##### To verify that SCVMM is installed correctly and is working  
  
1.  In the **Virtual Machine Manager Administrator Console**, in the **Actions** pane on the right side, choose **New virtual machine**. Choose **Next** in all except the following pages of the wizard.  
  
    1.  On the **Select Source** wizard page, select **Create the new virtual machine with a blank virtual hard disk**.  
  
    2.  On the **Virtual Machine Identity** wizard page, in **Virtual machine name**, enter **blank**.  
  
    3.  On the **Select Destination** wizard page, select **Place the virtual machine on a host**.  
  
    4.  On the **Select Host** wizard page, view the ratings, and then choose **Next**.  
  
         You should see all the *HyperVHost* machines that you are using for Lab Management. All of them should have positive star ratings. If not, you might have an issue that must be corrected. To determine why the *HyperVHost* machines are not usable by SCVMM, examine the **Rating Explanation**.  
  
    5.  On the **Summary** wizard page, choose **Create**.  
  
         A new virtual machine called **blank** should be created without any errors and should be visible in the **Virtual Machines** tab of SCVMM. There might be a warning that SCVMM could not locate the boot volume. This is expected and can be ignored.  
  
2.  In the **Virtual Machine Manager Administrator Console**, choose **Virtual Machines**, open the shortcut menu for the virtual machine displayed in the list, and then choose **Start**. If the virtual machine does not start, review the information located on the following sites to identify the cause of the problem:  
  
    -   [New Installation of SCVMM 2008](http://go.microsoft.com/fwlink/?LinkId=139442)  
  
    -   [System Center Virtual Machine Manager TechCenter](http://go.microsoft.com/fwlink/?LinkId=139443)  
  
3.  After the **Status** of the VM is **Running**, open the shortcut menu for the VM, and then choose **Stop**.  
  
     This confirms that your Hyper-V hosts are configured correctly.  
  
4.  To store the virtual machine in the library, open the shortcut menu for the VM, and then choose **Store in library**.  
  
    1.  On the **Select Library Server** wizard page, choose one of the library shares.  
  
    2.  On the **Select Path** wizard page, browse to the path for your library share that you plan to use for your team project collection on Team Foundation Server.  
  
    3.  When you are finished, confirm that a virtual machine called **blank** appears in the **Library** pane in the SCVMM Administrator Console.  
  
         This confirms that the library share is configured correctly.  
  
 You can use the following procedure to improve the performance of virtual machine transfers from the SCVMM library share to a host and also when storing a virtual machine to the SCVMM library share. This performance improvement removes encryption that has security implications if the images are transmitted unencrypted over the network.  
  
##### To improve performance of VM transfers  
  
1.  Enable unencrypted file transfers for library servers.  
  
    1.  Choose the **Library** tab in the SCVMM Administrator console. Open the shortcut menu for each library server in the **Library Servers** tree, and then choose **Properties**.  
  
    2.  Select **Allow unencrypted file transfers**.  
  
    3.  Choose **OK** to close the dialog box.  
  
2.  Enable unencrypted file transfers for host groups.  
  
    1.  Choose the **Hosts** tab in the SCVMM Administrator console. Open the shortcut menu for each host group in the **Hosts** tree, and then choose **Properties**.  
  
    2.  Select **Allow unencrypted file transfers**.  
  
    3.  Choose **OK** to close the dialog box.  
  
##  <a name="ConfigureTFS"></a> Configure Lab Management for Team Foundation Server  
 To enable Team Foundation Server to communicate with the SCVMM server, you must also install the SCVMM Administrator Console on your *TfsMachine* if this is a different computer from the computer that you are using as your *VmmMachine*.  
  
> [!NOTE]
>  If your deployment of Team Foundation Server has more than one application-tier machine, install the console on every application tier in the deployment.  
  
#### To install SCVMM 2012 Console on <TFSMachine\>  
  
1.  Log on to *TfsMachine* as *domain*\\*tfsadmin*.  
  
2.  To install Virtual Machine Manager Administrator Console, run setup.exe for Virtual Machine Manager.  
  
3.  In VMM setup, choose **Install**.  
  
4.  You can just choose **Next** in all except the following pages of the wizard:  
  
    1.  On the **Select features to install** page, choose **VMM console** and then choose **Next**.  
  
    2.  On the license page, you must choose **I agree with the terms of this notice** and then choose **Next**.  
  
    3.  On the **Installation summary** page, choose **Install**.  
  
    4.  On the **Setup completed successfully** page, choose **Close**.  
  
#### To install the SCVMM 2008 R2 Administrator Console on <TfsMachine\>  
  
1.  Logon to *TfsMachine* as *domain*\\*tfsadmin*.  
  
2.  To install Virtual Machine Manager Administrator Console, run setup.exe for Virtual Machine Manager.  
  
3.  Under **Setup** on the **System Center Virtual Machine Manager 2008 R2** startup wizard page, choose **VMM Administrator Console**.  
  
4.  You can just choose **Next** in all except the following pages of the wizard:  
  
    1.  On the **Summary of Settings** wizard page, choose **Install**.  
  
    2.  On the **Installation** wizard page, choose **Close**.  
  
### Configure Lab Management for Team Foundation Server  
 You must configure Lab Management in Team Foundation Server. This enables access to the virtual machines and templates that you create from Microsoft Test Manager. You can then use these virtual machines or templates to create SCVMM environments and store them in a library share. This requires you to select the SCVMM server to use with Team Foundation Server.  
  
##### To configure Lab Management for Team Foundation Server  
  
1.  On *TfsMachine*, choose **Start**, **All programs**, **Microsoft Visual Studio Team Foundation Server**, and then choose **Team Foundation Server Administration Console**.  
  
    > [!NOTE]
    >  You must log on to *TfsMachine* as *domain*\\*tfsadmin*.  
  
2.  In the Administration Console, in the **Application Tier** node, choose **Lab Management**.  
  
3.  Choose **Configure**.  
  
     The **Lab Management Settings** dialog box appears.  
  
4.  On the **Virtual Machine Manager** tab, in **VMM Server Name**, type the name of *VmmMachine*, the server that is running Virtual Machine Manager and that you will use to manage the virtual machines.  
  
5.  Choose **Test** to determine whether Team Foundation Server can communicate with the SCVMM server.  
  
    1.  If Team Foundation Server service account does not have the appropriate permissions on the specified SCVMM, a dialog box prompts you for a user name and password.  
  
    2.  Specify the credentials of an existing member of SCVMM Administrators Role. By using this user name and password, the Team Foundation Server service account will be added to the SCVMM Administrator Role.  
  
     If Team Foundation Server cannot contact the SCVMM server, a red x and an error message is displayed. For more information about how to troubleshoot installation issues, see [Troubleshooting Lab Management](../dv_TeamTestALM/Troubleshooting-Lab-Management.md).  
  
6.  You can use network isolation in Visual Studio Lab Management to enable multiple copies of a lab environment to run at the same time without causing network conflicts, such as conflicts in computer names and Domain Name System (DNS) registration. For more information about network isolation, see [Creating and using a network isolated environment](../dv_TeamTestALM/Creating-and-using-a-network-isolated-environment.md). On the **Network Isolation** tab, follow these steps:  
  
    1.  In **IP Block**, type the range of Internet Protocol (IP) addresses to be assigned to the virtual machines in an environment when an isolated network is created.  
  
         You must type the IP Block using Classless Inter-Domain Routing (CIDR) notation. The CIDR notation is constructed from the IP address, the forward slash (/), and the prefix size. For example, 192.168.0.0/24.  
  
         The addresses that you specify are used only for internal routing among virtual machines and are not exposed beyond the boundaries of an environment. Therefore, you can specify any address range that is not used within your public network. In most cases, you can use the default range of 192.168.23.0/24.  
  
    2.  In **DNS Suffix**, type the suffix of the domain name to be assigned to the environment when an isolated network is created.  
  
         Team Foundation Server uses the suffix that you entered when it registers a unique external name with DNS for each virtual machine in a network-isolated environment. The DNS alias record makes it possible for machines and other objects outside the isolated network to communicate with machines inside the isolated network. Because Team Foundation Server goes into the DNS zone to register the alias record, the service account under which Team Foundation runs must have permissions to add or delete alias records in the specified DNS zone.  
  
         If your Team Foundation Server deployment has more than one application tier and each application tier runs under a different service account, then each application-tier service account must have permission to edit the DNS alias records created by the other application tiers.  
  
         Choose **Test** to determine whether Team Foundation Server can use the suffix.  
  
         If the suffix is valid, a green check mark appears. Choose **OK**.  
  
         If the suffix is not valid, a red x and an error message appear. You must fix the error before you can continue.  
  
7.  If your deployment of Team Foundation Server has more than one application-tier machine, repeat the following steps on each of the other application-tier machines:  
  
    1.  In the Team Foundation Administration Console, choose the **Application Tier** node, choose **Lab Management,** and then choose **Reconfigure**.  
  
         The **Lab Management Settings** dialog box appears.  
  
    2.  Choose the **Virtual Machine Manager** tab, and then choose **Test** to determine whether the application tier can communicate with SCVMM.  
  
         If the Team Foundation Server service account does not have the correct permissions on the specified SCVMM, a dialog box is displayed prompting you for a user name and password. Type the credentials of an existing member of SCVMM Administrators role. When you type this user name and password and choose **OK**, the Team Foundation Server service account of this application tier will be added to the SCVMM Administrator role.  
  
## Configure Lab Management for Each Team Project Collection  
 You must configure the host group and library share from SCVMM that you want to use with each team project collection. For example, you might decide to allocate one host group to each team project collection to evenly divide the virtual machine resources.  
  
 To use the workflow capability from a Team Foundation Build build definition to deploy your application, or run tests by using a test controller on your SCVMM environments, you must add a domain user account that will be used by test agents and build agents.  
  
> [!NOTE]
>  You must have a team project collection already created for this step of the configuration.  
  
#### To configure Lab Management for each team project collection  
  
1.  To select the library share to use to store virtual machines, templates, and SCVMM environments, choose **Team Project Collections** under **Application Tier**.  
  
    > [!IMPORTANT]
    >  You must configure a library share for each team project collection that you want to configure for Lab Management.  
  
2.  In the right-side pane, choose the appropriate team project collection from the list of project collections.  
  
3.  Choose the **Lab Management** tab, and then choose **Configure Library Shares**.  
  
     The **Lab Management Settings** dialog box appears.  
  
4.  On the **Library Shares** tab, choose **Add and Verify**.  
  
     The Select Library Shares dialog box appears.  
  
5.  In the **Select Library Shares** dialog box, choose one or more SCVMM library shares that this team project collection will use, and then choose **Add**.  
  
     The verify process now confirms that Team Foundation Server can connect to the library share. If the verification fails, then a log is generated. You can view the log to identify the problems and then fix them. When they are fixed, you can choose **Verify** to confirm that Team Foundation Server can connect to the library share.  
  
6.  To add the library share to each team project in the team project collection, select the **Auto Provision** check box for the library share.  
  
    > [!NOTE]
    >  If you select to auto-provision the library share, Team Foundation Server automatically adds the library share to all the team projects in this team project collection. For team projects that have not yet been created, the library share is added when the New Team Project wizard creates the project. For team projects that have already been created in this team project collection, the library share is added when these settings are saved. If you clear Auto Provision the library share will no longer be added to new team projects that you add to your team project collection.  
  
7.  To select the host group to use for a team project collection, choose **Host Groups**.  
  
    > [!IMPORTANT]
    >  You must select the host group for each team project collection that you want to configure for Lab Management.  
  
8.  On the **Host Groups** tab, choose **Add and Verify**.  
  
9. In the **Select Host Groups** dialog box, choose one or more SCVMM host groups that this team project collection will use, and then choose **Add**.  
  
10. To add the host group to each team project in the team project collection, choose the **Auto Provision** check box for the host group.  
  
    > [!NOTE]
    >  If you select to auto-provision the host group, Team Foundation Server automatically adds the host group to all the team projects in this team project collection. For team projects that have not yet been created, the host group is added when the New Team Project wizard creates the project. For team projects that have already been created in this team project collection, the host group is added when these settings are saved. If you clear **Auto Provision**, the host group will no longer be added to new team projects that you add to your team project collection.  
  
##  <a name="BuildTestControllers"></a> Install a Test Controller  
 You can use Lab Management to deploy an application to your SCVMM environment and also to run tests on that environment. This requires a test controller. For more information about how to run tests using test settings and environments, see [Setting Up Test Machines to Run Tests or Collect Data](../dv_TeamTestALM/Setting-Up-Test-Machines-to-Run-Tests-or-Collect-Data.md).  
  
#### To install the test controller  
  
1.  Install the test controller on *ControllerMachine* or on a different machine. For information about how to install and configure a test controller, see [Install and configure test agents](../dv_TeamTestALM/Install-and-configure-test-agents.md).  
  
    > [!NOTE]
    >  You must register the test controller with the team project collection that you are using for Lab Management.  
  
2.  Specify the user account to use for communication between the test agents and build agents and between the test controllers and Team Foundation Server.  
  
    > [!CAUTION]
    >  The service account that you specify must be a domain account. For security reasons, this account must have limited privileges. The account that you use must not have any administrative permission or be the account that is used by any trusted service. This includes the build controller and test controller.  
    >   
    >  We recommend that you create two accounts to use for this service account. For more information about how to switch between these two accounts and how existing environments are updated with the service account, see [Configure the Lab Service Account](../dv_TeamTestALM/Configure-the-Lab-Service-Account.md).  
    >   
    >  You must configure the user account for each team project collection that you want to configure for Lab Management.  
  
## See Also  
 [Configure and administer Lab Management](../dv_TeamTestALM/Configure-and-administer-Lab-Management.md)