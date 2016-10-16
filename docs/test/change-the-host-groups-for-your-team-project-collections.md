---
title: "Change the Host Groups for Your Team Project Collections"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vstf.tfs.mmc.console.labmgmt.tpc.hostgroups"
helpviewer_keywords: 
  - "Visual Studio ALM, host groups"
  - "host groups [Lab Management]"
ms.assetid: d7739640-6a90-44e7-839d-0d70aa989db6
caps.latest.revision: 46
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
# Change the Host Groups for Your Team Project Collections
You can use the host groups in System Center Virtual Machine Manager as a convenient way to monitor and manage virtual machine hosts. Hosts are the computers in the host group that you use to deploy virtual environments in [!INCLUDE[vstsLabLong](../test/includes/vstslablong_md.md)]. You create and manage host groups by using SCVMM. In [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)], you can specify which host groups to use for a team project collection.  
  
 If you want to add a host to an existing host group, you must use SCVMM to accomplish this task. For more information, see this [Microsoft Web site](http://go.microsoft.com/fwlink/?LinkId=178989). If you do add a host, you must also verify the following:  
  
-   The logical network of the host group is the same as the other hosts so that the virtual machines can communicate with each other.  
  
-   The host has been added to the correct host group.  
  
 After you have configured [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] for the first time, you might later want to change the host groups that are used by your team project collection. For example, you need more hosts because the volume of use has increased. You can choose to add another host group that you can use to your existing team project collection to increase your capacity. You can add multiple host groups to any team project collection.  
  
> [!NOTE]
>  To configure [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] for the first time, see [Configure Lab Management for SCVMM environments](../test/configure-lab-management-for-scvmm-environments.md).  
  
 You can change the host groups for a team project collection using the Administration Console for [!INCLUDE[esprfound](../codequality/includes/esprfound_md.md)]. Or, you can use the command-line to accomplish the same task. For more information about the command-line utility TFSLabConfig, see [Configuring Lab Management with TFSLabConfig](assetId:///28da1061-5a31-4e8b-96a7-116dfed55632).  
  
> [!NOTE]
>  If you want to assign a host group that you have created using SCVMM to a specific team project that you have added to your team project collection, you must use the command-line utility to accomplish this task. You cannot use the administration console to assign host groups to specific team projects. For more information, see [TFSLabConfig CreateTeamProjectHostGroup Command](assetId:///1462f1da-77e9-468f-bd68-6a4f6c7dd386).  
  
 Use the following procedure to change the host groups for your team project collection by using the Administration Console for [!INCLUDE[esprfound](../codequality/includes/esprfound_md.md)]. For each host in a host group that you add, you must also run the steps in the procedure to improve the reliability of WinRM. To expand your virtual lab, see [Expand or change your virtual lab](../test/expand-or-change-your-virtual-lab.md).  
  
### To add or remove host groups for your team project collection  
  
1.  In the Team Foundation Administration Console, under **Application Tier**, click **Team Project Collections**.  
  
2.  In the right-side pane, click the appropriate team project collection from the list of project collections.  
  
3.  Click the **Lab Management** tab, and then click **Configure Host Groups**.  
  
     The **Edit Project Collection Level Lab Management Settings** dialog box is displayed.  
  
4.  To add a host group, on the **Host Groups** tab, click **Add and Verify**.  
  
    1.  In the **Select Host Groups** dialog box, click one or more SCVMM host groups that this team project collection will use, and then click **Add**.  
  
    2.  To add the host group to each team project in the team project collection, select **Auto Provision** for the host group.  
  
        > [!NOTE]
        >  If you select to auto provision the host group, [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] automatically adds the host group to all the team projects in this team project collection. For team projects that have not yet been created, the host group is added when the **New Team Project** wizard creates the project. For team projects that have already been created in this team project collection, the host group is added when these settings are saved. If you clear **Auto Provision** the host group will no longer be added to new team projects that you add to your team project collection.  
  
5.  To delete a host group from your team project collection, on the **Host Groups** tab, select the host group from the list, and click **Delete**.  
  
    > [!IMPORTANT]
    >  Before you can delete a host group from a team project collection, you must first remove all [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] environments that are in this host group using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. Then you must remove the association of this host group from each team project in that project collection using the command line utility TFSLabConfig. For more information about how to do this, see [TFSLabConfig DeleteTeamProjectHostGroup Command](assetId:///45377b79-9e7b-483f-869e-77424f09097b).  
  
6.  Click **OK**.  
  
## Improve the Reliability of WinRM  
 You must make following changes to the default configuration settings for Windows Remote Management for each host in a host group that you have added. The changes to these settings help improve the reliability of WinRM because [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] performs a larger number of operations on Hyper-V hosts than are performed in a typical production scenario for Hyper-V.  
  
#### To change Windows Remote Management configuration settings  
  
1.  Click **Start**, right-click **Command Prompt**, and then click **Run as administrator**.  
  
    > [!NOTE]
    >  You must be a domain user that has been added to the administrators group for this machine.  
  
2.  At the command prompt, run the following command:  
  
     **winrm set winrm/config @{MaxTimeoutms = "1800000"}**  
  
3.  If the host operating system is [!INCLUDE[firstref_longhorn](../test/includes/firstref_longhorn_md.md)] SP2, also run the following command:  
  
     **winrm set winrm/config/Service @{MaxConcurrentOperations="200"} -r:http://\<HyperVHost>**  
  
     (Replace *HyperVHost* with the computer name of the Hyper-V host.)  
  
    > [!NOTE]
    >  To create a WinRM listener on http://\<HyperVHost>, you might also have to run the following command:  
    >   
    >  **winrm quickconfig**  
  
4.  Restart winrm and the SCVMM agent on the hosts after you make these changes using the following commands:  
  
     **net stop winrm**  
  
     **net start winrm**  
  
     **net start vmmagent**  
  
## See Also  
 [Manage team project collections](../Topic/Manage%20team%20project%20collections.md)   
 [Change Existing Lab Management Configurations](../test/change-existing-lab-management-configurations.md)