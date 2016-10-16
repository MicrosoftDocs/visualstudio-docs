---
title: "Creating and using a network isolated environment"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "virtual environment, network isolated"
  - "Visual Studio ALM, network isolation"
  - "Visual Studio ALM, isolated network"
ms.assetid: c7db5e03-358e-486b-a7a9-64ffa3fa64f0
caps.latest.revision: 54
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
# Creating and using a network isolated environment
When you create an SCVMM environment, you can enable network isolation, which allows you to run multiple identical copies (or "clones") of the environment. However, network isolation requires additional configuration steps, including preparing virtual machines and templates, joining virtual machines to a workgroup or domain, and optionally, setting up one of the virtual machines to run a private domain.  
  
 This topic describes the configuration steps required to create a network isolated environment. It assumes that you are already familiar with setting up and managing Active Directory and DNS. For an overview of network isolation, see [Cloning Virtual Machines through Network Isolation](../test/cloning-virtual-machines-through-network-isolation.md).  
  
 This topic contains the following sections:  
  
-   [Before you start](#prereqs)  
  
-   [Process overview](#Overview)  
  
-   [Preparing the virtual machines and templates](#PrepareVirtualMachines)  
  
-   [Setting up the environment](#CreateEnvironment)  
  
-   [Operating a network isolated environment](#OperateEnvironment)  
  
-   [Viewing the status of a network isolated environment](#ViewStatus)  
  
-   [Communicating with a network isolated environment](#Communicate)  
  
##  <a name="prereqs"></a> Before you start  
 If you are going to test an app in a network isolated environment, the app must be able to run on computers that have multiple network adapters. Otherwise, you should not enable network isolation in your lab environment. For information about using other options in SCVMM environments, see [Guidance for Creating and Managing SCVMM Environments](../test/guidance-for-creating-and-managing-scvmm-environments.md).  
  
 Before you can create and use a network isolated environment, you must complete the prerequisite tasks for creating an SCVMM environment. These tasks include:  
  
-   Set up System Center Virtual Machine Virtual Machine Manger and network isolation in your Team Project Collection  
  
-   Set up a test controller with your Team Project Collection  
  
-   Connect Microsoft Test Manager with your Team Project  
  
 For more information, see [Test on a lab environment](../test/test-on-a-lab-environment.md).  
  
##  <a name="Overview"></a> Process overview  
 These steps summarize the creation of a network isolated environment:  
  
1.  Follow these steps to prepare the virtual machines and templates that you want to use in your environment. Then store them all on the same SCVMM host in your Team Project Library.  
  
    1.  Add the virtual machines and templates to a workgroup, not a domain.  
  
    2.  Install a test agent on each virtual machine and template, but don’t configure the test agent.  
  
    3.  If you want the virtual machines to run in a private domain, set up a virtual machine as a domain controller.  
  
    4.  (Recommended) Enable Remote Desktop Services on each virtual machine and template.  
  
    5.  (Recommended) Set the administrator password on each virtual machine and template to not expire.  
  
2.  Create a new SCVMM environment using your stored virtual machines and templates. Enable the network isolation option when you create the environment.  
  
3.  Connect to the virtual machines in your lab environment and configure either a private domain or a workgroup.  
  
4.  In order to be able to create multiple copies of the environment, store the environment in your Team Project Library.  
  
##  <a name="PrepareVirtualMachines"></a> Preparing the virtual machines and templates  
 Before you create a network isolated environment, you must follow these steps to prepare the stored virtual machines and templates so you can copy them to your environment.  
  
 To update properties of the virtual machines: In Microsoft Test Manager, open Lab Center, Environment. Open your environment, and then on the Machine Properties page, select each machine and set its properties.  
  
1.  (Recommended) Configure the computer name of each virtual machine and template before you store them in your library. You can change the computer name of a template while it’s stored in your library. However, you can’t change the computer name of a virtual machine while it’s stored in your library. Instead, after you store a virtual machine, you must deploy it before you can change the computer name.  
  
2.  Add the virtual machines and templates to a workgroup, not a domain. If you want to run a domain in your environment, you can add the running virtual machines to an internal domain after you deploy the environment.  
  
    > [!TIP]
    >  You must add your virtual machines to a workgroup before you store them in your library. However, you can add your templates to a workgroup while they are stored in your library so long as you do it before you deploy a copy of the template to a network isolated environment. To add your templates to a workgroup while they are stored in your library, configure the **workgroup** property.  
  
3.  Install a test agent on each virtual machine and template using the Visual Studio Agents disc or ISO, but don’t configure the test agent.  
  
4.  If you want the machines to run in a private domain, set up a virtual machine as a domain controller. A common way to do this is to create your domain controller as a virtual machine in System Center Virtual Machine Manager (SCVMM) and then import it into your Team Project Library.  
  
     For information about creating the domain controller, see [Prepare a Domain Controller Virtual Machine Using SCVMM](../test/prepare-a-domain-controller-virtual-machine-using-scvmm.md).  
  
5.  (Recommended) Set the administrator password on each virtual machine and template to not expire.  
  
6.  (Recommended) Enable Remote Desktop Services on each virtual machine and template.  
  
7.  Store the virtual machines and templates in your Team Project Library. For specific steps, see [Create virtual machines for SCVMM lab environments](../test/create-virtual-machines-for-manual-testing.md).  
  
##  <a name="CreateEnvironment"></a> Setting up the environment  
 Use this topic to create a new SCVMM environment [Creating an SCVMM Environment Using Stored Virtual Machines and Templates](../test/creating-an-scvmm-environment-using-stored-virtual-machines-and-templates.md). Follow these steps when you create the environment.  
  
-   On the **machines** tab of the **New Environment** wizard, add your stored virtual machines and templates to the environment, and then configure the computer names. You can add a stored virtual machine or template to an environment multiple times, but you must configure the internal identity information for the deployed virtual machines so it is unique in the environment.  
  
-   If you are running a private domain in the environment, add the domain controller virtual machine.  
  
-   On the **Advanced** tab of the **New Environment** wizard, choose the **Enable network isolation for this environment** check box.  
  
-   When you enable network isolation, [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] prompts you to designate one of the virtual machines in the environment as the domain controller. If you are using a private domain in your environment, select your domain controller virtual machine.  
  
 After you create your environment, connect to it, and then perform additional configuration tasks such as joining the machines to the private domain. Then, to enable you to run multiple copies of the environment, shut down the environment and store it in the team project library. You can run as many instances of the stored environment as needed.  
  
#### To configure the environment  
  
1.  Start the environment.  
  
    1.  Select the environment under **Lab** tab in **Lab Center**.  
  
    2.  Choose **Start**.  
  
2.  Wait for the network isolation status of the environment to be **Ready** before you go to the next step.  
  
3.  In **Environment Viewer**, connect to the environment.  
  
4.  If you are using a private domain in your lab environment instead of a workgroup, you must configure your domain controller and add your virtual machines to the domain.  
  
    > [!NOTE]
    >  You must be the owner of the domain controller to complete this step.  
  
    > [!NOTE]
    >  If you want to use a workgroup in your lab environment instead of a private domain, skip this step.  
  
     Follow these steps to configure your domain controller:  
  
    1.  Select the domain controller virtual machine.  
  
    2.  Log on to the domain controller virtual machine using its host connection.  
  
    3.  Open the Windows Services tool (services.msc) and verify that the Active Directory and DNS services are running.  
  
    4.  > [!IMPORTANT]
        >  Restart the domain controller before you join any virtual machines to the private domain, so that out-of-date locator records in DNS are purged. The domain controller must have correct DNS locator records for the new internal IP addresses assigned for network isolation. Domain members rely on these DNS locator records to locate the domain controller. On some versions of Windows servers, out-of-date DNS records are purged only when the service starts.  
  
         On the domain controller virtual machine, choose **Start** and then choose **Restart**. Wait for the virtual machine to restart and for the network isolation status to return to **Ready** before joining the other computers to the domain.  
  
     In **Environment Viewer**, follow these steps on each virtual machine to add them to your private domain:  
  
    1.  Connect to the virtual machine.  
  
    2.  Log on to the virtual machine using **Environment Viewer** or Remote Desktop.  
  
    3.  Choose **Start**, right-click **Computer**, and then choose **Properties**.  
  
    4.  Under **Computer name, domain, and workgroup settings**, change the domain of the computer by selecting the name of the domain that you created in your domain controller virtual machine. Use the credentials of a user in that domain.  
  
    5.  After you join the domain, restart the virtual machine.  
  
    6.  Repeat this step for each virtual machine in the environment other than the domain controller.  
  
5.  If you are using a workgroup in your environment instead of a private domain, in **Environment Viewer** connect to each virtual machine and ensure that the machine is joined to the correct workgroup.  
  
6.  After you finish configuring your private domain or workgroup, wait until the network isolation status of the environment becomes **Ready** before you use the environment. For more information, see [Viewing the Status of Network-Isolated Environments](#ViewStatus).  
  
7.  (Optional) Take a snapshot of the environment by using **Environment Viewer**.  
  
8.  (Optional) If you want to run multiple copies of your environment, follow these steps to store the environment in your Team Project Library:  
  
    1.  In [!INCLUDE[TCMshort](../test/includes/tcmshort_md.md)], on the **Lab** tab, select the environment and then, on the toolbar, choose **Shut Down**.  
  
    2.  Select the environment and then choose **Store in Library** on the toolbar. Enter a new name for the stored environment.  
  
     Now you can deploy multiple copies of the stored environment. For more information on deploying a copy of a stored environment, see [Deploying a Stored SCVMM Environment](../test/deploying-a-stored-scvmm-environment.md).  
  
##  <a name="OperateEnvironment"></a> Operating a network isolated environment  
 In **Lab Center**, on the **Lab** tab, you can start, pause, or shut down an environment that uses network isolation. You can also create snapshots of the environment and store the environment in the team project library. For more information, see [How to: Operate an SCVMM Environment](../test/how-to--operate-an-scvmm-environment.md). If your network isolated environment contains a domain controller, consider these recommendations when operating the environment:  
  
-   Do not use the **Power off** action to turn off a running environment that contains a domain controller virtual machine. Use the **Shut Down** action instead.  
  
-   Do not exceed five snapshots on the environment that has a domain controller virtual machine. More than five snapshots could cause significant decrease in performance.  
  
### Operating machines in a network isolated environment  
 You can use Environment Viewer to administer and configure the machines in the environment. Except for the domain controller machine, you can connect directly to machines in the environment by using either a host or a guest connection in the Environment Viewer.  
  
 Because the domain controller is not connected to the external environment, you must use a host-based connection to directly connect to the domain controller machine in Environment Viewer. If a host-based connection is not available, you can connect to another machine in the environment and then use Remote Desktop to connect to the domain controller.  
  
 For more information, see [How to: Connect to machines in a Lab Environment](../test/how-to--connect-to-machines-in-a-lab-environment.md).  
  
##  <a name="ViewStatus"></a> Viewing the status of network isolated environments  
 Each network-isolated environment has an additional status that describes whether network isolation has been configured correctly in the environment.  
  
#### To view the network isolation status of an environment  
  
1.  In [!INCLUDE[TCMshort](../test/includes/tcmshort_md.md)], open the **Lab Center** of your team project, and then choose the **Lab** tab.  
  
2.  Choose an environment.  
  
3.  In the right-side pane, view the three icons next to **Capabilities**. Network isolation status is represented by the first icon.  
  
4.  Move the pointer over this icon to see a tooltip that explains the icon.  
  
5.  When the status is **Partially Ready** or **Failed**, there is a warning or an error message associated with the environment together with a link to **More details**. Choosing this link provides additional information about the warning or the error and the corrective action.  
  
    > [!NOTE]
    >  The network isolation status is only displayed for environments that are running. If the environment is in any other state, the network isolated status is not available.  
  
 The following table describes the network isolation states.  
  
|State|Description|  
|-----------|-----------------|  
|**Not configured**|Network isolation capability is not enabled in the selected environment.|  
|**Not ready**|Network isolation capability is not ready. This state usually means that the capability is enabled in the environment but the environment is not in a **Running** state.|  
|**In progress**|Network isolation is being configured for the environment. This usually means that the environment is powering up after it has been started.|  
|**Partially ready**|Network isolation has been configured on some virtual machines in the environment but not on all of them. This might be a transient state that indicates the capability is still being configured on the rest of the virtual machines. If this state persists for the environment, then there was a failure configuring isolation on one or more of the virtual machines.|  
|**Ready**|Network isolation is fully configured for the environment and is ready for you to work with the environment.|  
|**Failed**|There was a failure while configuring network isolation capability. Choose **More details** to learn about the problem and the resolution.|  
  
 When you start a network isolated environment, the status usually starts from **Not ready**, transitions to **In progress**, then to **Partially ready**, and finally to **Ready**. The same behavior is seen when you restore a network isolated environment to an earlier snapshot. The time that it takes for the status to become **Ready** depends on several factors, including the time taken by virtual machine to turn on and initialize, and the load on the Hyper-V host that is running the environment.  
  
##  <a name="Communicate"></a> Communicating with network isolated environments  
 To enable communication with the external network, [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] adds a second network adapter to the machines in a network isolated environment. The second adapter provides external network aliases for the computer name and IP address.  
  
### Communicating with a network isolated environment from the external network  
 You can communicate with machines in a network-isolated environment from a computer in the external network by using the aliases of the second network adapter. For example, you can use the computer name alias in the url to open the Web site of a Web server in an isolated network from a browser on a machine in the external network. You can also use the computer name alias as the server name in a connection string that is used to connect an application on the external domain to a database in the network isolated environment.  
  
##### To obtain the external network aliases of a machine in a network-isolated environment  
  
1.  In [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], open **Lab Center**, and then choose **Lab**.  
  
2.  Connect to the environment by using Environment Viewer.  
  
    1.  Select the environment in the list.  
  
    2.  Choose **Connect**.  
  
3.  In Environment Viewer, right-click the machine and choose **System Info**.  
  
    -   The **Computer name** field displays the fully qualified name of the machine on the external network.  
  
    -   The **IP address** displays the IP address on the external network.  
  
### Communicating with the external network from a network isolated environment  
 A machine in a network-isolated environment can communicate with computers in the external network from by using the fully qualified domain name or IP address of the external computer.  
  
## See Also  
 [Prepare a Domain Controller Virtual Machine Using SCVMM](../test/prepare-a-domain-controller-virtual-machine-using-scvmm.md)   
 [Guidance for Creating and Managing SCVMM Environments](../test/guidance-for-creating-and-managing-scvmm-environments.md)   
 [Cloning Virtual Machines through Network Isolation](../test/cloning-virtual-machines-through-network-isolation.md)   
 [Using a Lab Environment for Your Application Lifecycle](../test/using-a-lab-environment-for-your-application-lifecycle.md)